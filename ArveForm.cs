using Microsoft.EntityFrameworkCore;
using PdfSharpCore.Drawing;
using PdfSharpCore.Pdf;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;


namespace Tooted
{
    public partial class ArveForm : Form
    {
        private readonly ToodedContext _db = new ToodedContext();
        List<OstukorviRida> ostukorv = new List<OstukorviRida>();

        // Valitud toode = see, mis on listTooted'is valitud
        public Toode SelectedToode => listTooted.SelectedItem as Toode;

        public ArveForm()
        {
            InitializeComponent();
            LaeTooted();
            ArvutaKoguSumma();
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
        }

        // Laeb kõik tooted andmebaasist listTooted'i
        private void LaeTooted()
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

            listTooted.DataSource = _db.Toodetabel
                .Include(t => t.Kategooria)
                .ToList();
            listTooted.DisplayMember = "Toodenimetus";
        }

        // Näitab valitud toote pilti, nime ja infot
        private void NaitaToodet(Toode toode)
        {
            toodeNimi.Text = toode.Toodenimetus;
            toodeKirjeldus.Text = $"{toode.Hind:0.00} € | {toode.Kogus} tk | {toode.Kategooria?.Kategooria_nimetus}";

            pictureBox1.Image?.Dispose();
            pictureBox1.Image = null;

            if (string.IsNullOrEmpty(toode.Pilt)) return;

            // Sama kaust nagu tooted.cs-is: bin\...\Images või projekti Images
            string[] kohad =
            {
                Path.Combine("Images", toode.Pilt),
                Path.Combine(@"..\..\..\Images", toode.Pilt)
            };

            foreach (string tee in kohad)
            {
                if (File.Exists(tee))
                {
                    // Laeme mälu kaudu, et fail ei jääks lukku
                    pictureBox1.Image = Image.FromStream(new MemoryStream(File.ReadAllBytes(tee)));
                    break;
                }
            }
        }

        private void listTooted_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectedToode != null)
                NaitaToodet(SelectedToode);
        }

        private void btnLisaKorvi_Click(object sender, EventArgs e)
        {
            if (SelectedToode == null)
            {
                MessageBox.Show("Vali toode enne ostukorvi lisamist.");
                return;
            }

            string kogusStr = Microsoft.VisualBasic.Interaction.InputBox(
                "Sisesta kogus", "Kogus", "1");

            if (!int.TryParse(kogusStr, out int kogus) || kogus <= 0)
            {
                MessageBox.Show("Vale kogus.");
                return;
            }

            // Kui sama toode on juba korvis, suurendame kogust
            var olemas = ostukorv.FirstOrDefault(r => r.Toode.Id == SelectedToode.Id);
            int kokkuKorvis = (olemas?.Kogus ?? 0) + kogus;

            if (kokkuKorvis > SelectedToode.Kogus)
            {
                MessageBox.Show($"Laos on ainult {SelectedToode.Kogus} tk.");
                return;
            }

            if (olemas != null)
            {
                olemas.Kogus = kokkuKorvis;
            }
            else
            {
                ostukorv.Add(new OstukorviRida
                {
                    Toode = SelectedToode,
                    Kogus = kogus
                });
            }

            UuendaOstukorvi();
        }

        // Topeltklõps ostukorvi real eemaldab selle
        private void listOstukorv_DoubleClick(object sender, EventArgs e)
        {
            if (listOstukorv.SelectedItem is not OstukorviRida rida) return;

            if (MessageBox.Show($"Eemaldada \"{rida.Toode.Toodenimetus}\" korvist?",
                    "Ostukorv", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ostukorv.Remove(rida);
                UuendaOstukorvi();
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
            float kokku = ostukorv.Sum(r => r.Summa);

            lblKokku.Text = $"Kokku: {kokku:0.00} €";
        }

        private void btnGenPDF_Click(object sender, EventArgs e)
        {
            if (ostukorv.Count == 0)
            {
                MessageBox.Show("Ostukorv on tühi.");
                return;
            }

            Directory.CreateDirectory("Arved");

            string failinimi = $"Arved/Arve_{DateTime.Now:yyyyMMdd_HHmmss}.pdf";

            PdfDocument document = new PdfDocument();
            PdfPage page = document.AddPage();
            XGraphics gfx = XGraphics.FromPdfPage(page);

            XFont font = new XFont("Verdana", 12);

            gfx.DrawString("Arve", new XFont("Verdana", 20), XBrushes.Black,
                new XRect(0, 20, page.Width, 40), XStringFormats.TopCenter);

            gfx.DrawString($"Kuupäev: {DateTime.Now:dd.MM.yyyy HH:mm}", font, XBrushes.Black,
                new XRect(20, 55, page.Width - 40, 20), XStringFormats.TopLeft);

            int y = 90;
            foreach (var item in ostukorv)
            {
                gfx.DrawString(item.ToString(), font, XBrushes.Black,
                    new XRect(20, y, page.Width - 40, 20), XStringFormats.TopLeft);
                y += 30;
            }

            gfx.DrawString($"Kokku: {ostukorv.Sum(r => r.Summa):0.00} €",
                new XFont("Verdana", 14), XBrushes.Black,
                new XRect(20, y + 20, page.Width, 20), XStringFormats.TopLeft);

            document.Save(failinimi);

            MessageBox.Show($"PDF on loodud:\n{failinimi}");
        }


        private void btnSaadaEmail_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists("Arved") || Directory.GetFiles("Arved").Length == 0)
            {
                MessageBox.Show("Loo enne PDF arve.");
                return;
            }

            string email = Microsoft.VisualBasic.Interaction.InputBox(
                "Sisesta e-mail", "Saaja", "nimi@example.com");

            if (string.IsNullOrEmpty(email)) return;

            string pdfPath = Directory.GetFiles("Arved")
                .OrderByDescending(f => f)
                .First();

            try
            {
                var mail = new MailMessage();
                mail.From = new MailAddress("sinu_gmail@gmail.com");
                mail.To.Add(email);
                mail.Subject = "Arve";
                mail.Body = "Arve on manuses.";
                mail.Attachments.Add(new Attachment(pdfPath));

                var smtp = new SmtpClient("smtp.gmail.com", 587)
                {
                    Credentials = new NetworkCredential("sinu_gmail@gmail.com", "parool"),
                    EnableSsl = true
                };

                smtp.Send(mail);

                MessageBox.Show("Arve saadetud!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Viga: " + ex.Message);
            }
        }
    }
}
