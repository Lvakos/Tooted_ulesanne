using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tooted
{
    public partial class ArveForm : Form
    {
        private static readonly Color Oranz = Color.FromArgb(255, 128, 0);

        private readonly ToodedContext _db = new ToodedContext();
        private readonly List<OstukorviRida> ostukorv = new List<OstukorviRida>();
        private readonly ToolTip vihje = new ToolTip();

        public ArveForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;

            LaeOstukorv();
        }

        private void LaeOstukorv()
        {
            ostukorv.Clear();
            ostukorv.AddRange(_db.Ostukorv
                .Include(r => r.Toode)
                .Where(r => r.KasutajaId == AktiivneKasutaja.Id)
                .OrderBy(r => r.Id)
                .ToList());

            var muudetud = new List<string>();
            foreach (var rida in ostukorv.ToList())
            {
                if (rida.Kogus <= rida.Toode.Kogus) continue;

                muudetud.Add(rida.Toode.Toodenimetus);
                if (rida.Toode.Kogus <= 0)
                {
                    ostukorv.Remove(rida);
                    _db.Ostukorv.Remove(rida);
                }
                else
                {
                    rida.Kogus = rida.Toode.Kogus;
                }
            }

            if (muudetud.Count > 0)
            {
                _db.SaveChanges();
                MessageBox.Show("Laoseis on muutunud, ostukorvi uuendati:\n" + string.Join("\n", muudetud),
                    "Ostukorv", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            UuendaOstukorvi();
            LaeTooted();
        }

        private bool SalvestaOstukorv()
        {
            try
            {
                _db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ostukorvi salvestamine ebaõnnestus: " + (ex.InnerException?.Message ?? ex.Message));
                return false;
            }
        }

        private void LaeTooted()
        {
            int valitudLeht = Math.Max(0, tabTooted.SelectedIndex);

            foreach (TabPage leht in tabTooted.TabPages.Cast<TabPage>().ToList())
            {
                foreach (var pilt in leht.Controls.OfType<Control>().SelectMany(KoikPildid))
                    pilt.Image?.Dispose();
                leht.Dispose();
            }
            tabTooted.TabPages.Clear();

            var tooted = _db.Toodetabel
                .Include(t => t.Kategooria)
                .OrderBy(t => t.Toodenimetus)
                .ToList();

            tabTooted.TabPages.Add(LooLeht("Kõik tooted", tooted));

            foreach (var grupp in tooted
                         .Where(t => t.Kategooria != null)
                         .GroupBy(t => t.Kategooria.Kategooria_nimetus)
                         .OrderBy(g => g.Key))
            {
                tabTooted.TabPages.Add(LooLeht(grupp.Key, grupp.ToList()));
            }

            if (valitudLeht < tabTooted.TabPages.Count)
                tabTooted.SelectedIndex = valitudLeht;
        }

        private static IEnumerable<PictureBox> KoikPildid(Control c) =>
            (c is PictureBox p ? new[] { p } : Enumerable.Empty<PictureBox>())
                .Concat(c.Controls.OfType<Control>().SelectMany(KoikPildid));

        private TabPage LooLeht(string pealkiri, List<Toode> tooted)
        {
            var leht = new TabPage(pealkiri) { BackColor = Color.FromArgb(255, 224, 192) };

            var paneel = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true,
                WrapContents = true,
                Padding = new Padding(6),
                BackColor = leht.BackColor
            };

            if (tooted.Count == 0)
            {
                paneel.Controls.Add(new Label { Text = "Tooteid pole.", AutoSize = true, Margin = new Padding(10) });
            }

            foreach (var toode in tooted)
                paneel.Controls.Add(LooTootekaart(toode));

            leht.Controls.Add(paneel);
            return leht;
        }

        private Panel LooTootekaart(Toode t)
        {
            int korvis = ostukorv.FirstOrDefault(r => r.Toode.Id == t.Id)?.Kogus ?? 0;
            int saadaval = Math.Max(0, t.Kogus - korvis);

            var kaart = new Panel
            {
                Size = new Size(165, 262),
                Margin = new Padding(8),
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle
            };

            var pilt = new PictureBox
            {
                Bounds = new Rectangle(6, 6, 151, 130),
                SizeMode = PictureBoxSizeMode.Zoom,
                Image = Pildid.Lae(t.Pilt),
                Cursor = Cursors.Hand,
                BackColor = Color.White
            };
            vihje.SetToolTip(pilt, "Klõpsa, et pilti suurendada");

            var nimi = new Label
            {
                Bounds = new Rectangle(6, 140, 151, 38),
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Segoe UI", 9.75F, FontStyle.Bold),
                AutoEllipsis = true,
                Text = t.Toodenimetus
            };

            var hind = new Label
            {
                Bounds = new Rectangle(6, 178, 151, 24),
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Segoe UI", 12F, FontStyle.Bold),
                ForeColor = Oranz,
                Text = $"{t.Hind:0.00} €"
            };

            var laos = new Label
            {
                Bounds = new Rectangle(6, 202, 151, 18),
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Segoe UI", 8.25F),
                ForeColor = t.Kogus > 0 ? Color.DimGray : Color.Firebrick,
                Text = t.Kogus > 0 ? $"Laos: {t.Kogus} tk" : "Laost otsas"
            };

            var kogus = new NumericUpDown
            {
                Bounds = new Rectangle(6, 225, 55, 27),
                Minimum = 1,
                Maximum = Math.Max(1, saadaval),
                Value = 1,
                Enabled = saadaval > 0
            };

            var nupp = new Button
            {
                Bounds = new Rectangle(66, 223, 91, 30),
                Text = "Lisa korvi",
                BackColor = Oranz,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                Cursor = Cursors.Hand,
                Enabled = saadaval > 0
            };
            nupp.FlatAppearance.BorderSize = 0;

            nupp.Click += (s, e) =>
            {
                if (LisaKorvi(t, (int)kogus.Value))
                {
                    int jaanud = t.Kogus - (ostukorv.First(r => r.Toode.Id == t.Id).Kogus);
                    kogus.Maximum = Math.Max(1, jaanud);
                    kogus.Value = 1;
                    kogus.Enabled = nupp.Enabled = jaanud > 0;
                }
            };

            pilt.Click += (s, e) => NaitaSuurtPilti(t, pilt.Image);

            kaart.Controls.AddRange(new Control[] { pilt, nimi, hind, laos, kogus, nupp });
            return kaart;
        }

        private void NaitaSuurtPilti(Toode toode, Image? pilt)
        {
            if (pilt == null) return;

            using Form aken = new Form
            {
                Text = toode.Toodenimetus,
                StartPosition = FormStartPosition.CenterParent,
                ClientSize = new Size(800, 600),
                KeyPreview = true
            };

            var suurPilt = new PictureBox
            {
                Dock = DockStyle.Fill,
                SizeMode = PictureBoxSizeMode.Zoom,
                BackColor = Color.Black,
                Image = pilt
            };

            suurPilt.Click += (s, a) => aken.Close();
            aken.KeyDown += (s, a) => { if (a.KeyCode == Keys.Escape) aken.Close(); };

            aken.Controls.Add(suurPilt);
            aken.ShowDialog(this);
            suurPilt.Image = null;
        }

        private bool LisaKorvi(Toode toode, int kogus)
        {
            var olemas = ostukorv.FirstOrDefault(r => r.Toode.Id == toode.Id);
            int kokkuKorvis = (olemas?.Kogus ?? 0) + kogus;

            if (kokkuKorvis > toode.Kogus)
            {
                MessageBox.Show($"Laos on ainult {toode.Kogus} tk.", "Ostukorv");
                return false;
            }

            OstukorviRida? uus = null;
            if (olemas != null)
            {
                olemas.Kogus = kokkuKorvis;
            }
            else
            {
                uus = new OstukorviRida { KasutajaId = AktiivneKasutaja.Id, Toode = toode, Kogus = kogus };
                _db.Ostukorv.Add(uus);
                ostukorv.Add(uus);
            }

            if (!SalvestaOstukorv())
            {
                if (uus != null)
                {
                    _db.Entry(uus).State = EntityState.Detached;
                    ostukorv.Remove(uus);
                }
                else
                {
                    olemas!.Kogus -= kogus;
                }
                return false;
            }

            UuendaOstukorvi();
            listOstukorv.SelectedIndex = ostukorv.FindIndex(r => r.Toode.Id == toode.Id);
            return true;
        }

        private void listOstukorv_DoubleClick(object sender, EventArgs e)
        {
            if (listOstukorv.SelectedItem is not OstukorviRida rida) return;

            if (MessageBox.Show($"Eemaldada \"{rida.Toode.Toodenimetus}\" korvist?",
                    "Ostukorv", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ostukorv.Remove(rida);
                _db.Ostukorv.Remove(rida);
                SalvestaOstukorv();
                UuendaOstukorvi();
                LaeTooted();
            }
        }

        private void UuendaOstukorvi()
        {
            listOstukorv.Items.Clear();
            foreach (var rida in ostukorv)
                listOstukorv.Items.Add(rida);

            ArvutaKoguSumma();
        }

        private void ArvutaKoguSumma()
        {
            lblKokku.Text = $"Kokku: {ostukorv.Sum(r => r.Summa):0.00} €";
        }

        private async void ostaBtn_Click(object sender, EventArgs e)
        {
            if (ostukorv.Count == 0)
            {
                MessageBox.Show("Ostukorv on tühi.");
                return;
            }

            foreach (var rida in ostukorv)
            {
                if (rida.Kogus > rida.Toode.Kogus)
                {
                    MessageBox.Show($"Laos pole piisavalt: {rida.Toode.Toodenimetus}");
                    return;
                }
            }

            MakseAndmed makse;
            using (var payment = new Payment(ostukorv.Sum(r => r.Summa)))
            {
                if (payment.ShowDialog(this) != DialogResult.OK || payment.Andmed == null)
                    return;
                makse = payment.Andmed;
            }

            string arveNr = DateTime.Now.ToString("yyyyMMdd-HHmmss");
            Directory.CreateDirectory("Arved");
            string pdfTee = Path.GetFullPath(Path.Combine("Arved", $"Arve_{arveNr}.pdf"));

            try
            {
                ArvePdf.Loo(pdfTee, arveNr, makse, ostukorv);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PDF-i loomine ebaõnnestus: " + ex.Message);
                return;
            }

            string saatja = "", appParool = "", saaja = makse.Email;
            while (true)
            {
                if (!KusiEmailiAndmed(ref saatja, ref appParool, ref saaja))
                {
                    KatkestaOst(pdfTee);
                    return;
                }

                string? viga = await SaadaArve(saatja, appParool, saaja, pdfTee, arveNr, makse);
                if (viga == null)
                    break;

                if (MessageBox.Show("Saatmine ebaõnnestus. Kontrolli saatja e-maili ja app passwordit.\n\n" + viga,
                        "E-mail", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning) != DialogResult.Retry)
                {
                    KatkestaOst(pdfTee);
                    return;
                }
            }

            foreach (var rida in ostukorv)
                rida.Toode.Kogus -= rida.Kogus;
            _db.Ostukorv.RemoveRange(ostukorv);
            _db.SaveChanges();

            ostukorv.Clear();
            UuendaOstukorvi();
            LaeTooted();

            MessageBox.Show($"Täname ostu eest!\n\nArve saadeti aadressile {saaja}.\nPDF: {pdfTee}",
                "Ost õnnestus", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private static void KatkestaOst(string pdfTee)
        {
            try { File.Delete(pdfTee); } catch { }
            MessageBox.Show("Ost katkestati. Ostukorv jäi alles (see on salvestatud).", "Ost");
        }

        private async Task<string?> SaadaArve(string saatja, string appParool, string saaja,
            string pdfTee, string arveNr, MakseAndmed makse)
        {
            try
            {
                UseWaitCursor = true;
                ostaBtn.Enabled = false;

                using var mail = new MailMessage();
                mail.From = new MailAddress(saatja, ArvePdf.MyyjaNimi);
                mail.To.Add(saaja);
                mail.Subject = $"Arve nr {arveNr}";
                mail.Body =
                    $"Tere, {makse.Nimi}!\n\n" +
                    "Täname ostu eest. Arve on manuses.\n\n" +
                    $"Arve nr: {arveNr}\n" +
                    $"Kokku: {ostukorv.Sum(r => r.Summa):0.00} €\n" +
                    $"Makseviis: {makse.KaartArvel}\n\n" +
                    $"{ArvePdf.MyyjaNimi}";
                mail.Attachments.Add(new Attachment(pdfTee));

                using var smtp = new SmtpClient("smtp.gmail.com", 587)
                {
                    Credentials = new NetworkCredential(saatja, appParool),
                    EnableSsl = true
                };

                await smtp.SendMailAsync(mail);
                return null;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            finally
            {
                UseWaitCursor = false;
                ostaBtn.Enabled = true;
            }
        }

        private bool KusiEmailiAndmed(ref string saatja, ref string appParool, ref string saaja)
        {
            using Form aken = new Form();
            aken.Text = "Saada arve e-mailiga";
            aken.StartPosition = FormStartPosition.CenterParent;
            aken.ClientSize = new Size(340, 260);
            aken.FormBorderStyle = FormBorderStyle.FixedDialog;
            aken.BackColor = BackColor;
            aken.MaximizeBox = false;
            aken.MinimizeBox = false;

            Label lblSaatja = new Label { Text = "Saatja e-mail (Gmail):", Location = new Point(15, 15), AutoSize = true };
            TextBox txtSaatja = new TextBox { Location = new Point(15, 35), Width = 310, Text = saatja };

            Label lblParool = new Label { Text = "App password:", Location = new Point(15, 70), AutoSize = true };
            TextBox txtParool = new TextBox { Location = new Point(15, 90), Width = 310, UseSystemPasswordChar = true, Text = appParool };

            Label lblSaaja = new Label { Text = "Saaja e-mail:", Location = new Point(15, 125), AutoSize = true };
            TextBox txtSaaja = new TextBox { Location = new Point(15, 145), Width = 310, Text = saaja };

            Button btnSaada = new Button { Text = "Saada", Location = new Point(15, 200), Width = 150, Height = 32, BackColor = Oranz, ForeColor = Color.White };
            Button btnLoobu = new Button { Text = "Loobu", Location = new Point(175, 200), Width = 150, Height = 32, DialogResult = DialogResult.Cancel };

            btnSaada.Click += (s, args) =>
            {
                if (!OnEmail(txtSaatja.Text) || !OnEmail(txtSaaja.Text))
                {
                    MessageBox.Show("Sisesta korrektne saatja ja saaja e-mail!");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtParool.Text))
                {
                    MessageBox.Show("Sisesta app password!");
                    return;
                }

                aken.DialogResult = DialogResult.OK;
            };

            aken.Controls.AddRange(new Control[] { lblSaatja, txtSaatja, lblParool, txtParool, lblSaaja, txtSaaja, btnSaada, btnLoobu });
            aken.AcceptButton = btnSaada;
            aken.CancelButton = btnLoobu;
            aken.Shown += (s, a) => (string.IsNullOrEmpty(txtSaatja.Text) ? txtSaatja : txtParool).Focus();

            if (aken.ShowDialog(this) != DialogResult.OK)
                return false;

            saatja = txtSaatja.Text.Trim();
            appParool = txtParool.Text.Replace(" ", "");
            saaja = txtSaaja.Text.Trim();
            return true;
        }

        internal static bool OnEmail(string tekst)
        {
            try
            {
                return new MailAddress(tekst.Trim()).Address == tekst.Trim();
            }
            catch
            {
                return false;
            }
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            _db.Dispose();
            base.OnFormClosed(e);
        }
    }
}
