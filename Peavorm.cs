using System;
using System.ComponentModel;
using System.Globalization;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using System.Windows.Forms;

namespace Tooted
{
    public partial class Peavorm : Form
    {
        private bool _keelLaetud = false;
        public Peavorm()
        {
            InitializeComponent();
            LisaKasutajateNupp();
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;

            if (AktiivneKasutaja.OnAdmin)
            {
                btnTooted.Visible = true;
                btnArve.Visible = false;
            }
            else
            {
                btnTooted.Visible = false;
                btnArve.Visible = true;
            }

            Load += Peavorm_Load;

            comboLanguage.SelectedIndexChanged +=
                comboLanguage_SelectedIndexChanged;
        }

        private void Peavorm_Load(object sender, EventArgs e)
        {
            _keelLaetud = false;

            comboLanguage.Items.Clear();
            comboLanguage.Items.Add("Eesti");
            comboLanguage.Items.Add("English");

            string lang = Settings.Default.UserLanguage;

            if (lang == "en-US")
                comboLanguage.SelectedItem = "English";
            else
                comboLanguage.SelectedItem = "Eesti";

            _keelLaetud = true;
        }

        private void ApplyResourcesToControl(
            Control ctrl,
            ComponentResourceManager res)
        {
            res.ApplyResources(ctrl, ctrl.Name);

            foreach (Control child in ctrl.Controls)
            {
                ApplyResourcesToControl(child, res);
            }
        }

        private void ChangeLanguage(string lang)
        {
            // Salvesta valik
            Settings.Default.UserLanguage = lang;
            Settings.Default.Save();

            // Muuda kultuur
            Thread.CurrentThread.CurrentUICulture =
                new CultureInfo(lang);

            Thread.CurrentThread.CurrentCulture =
                new CultureInfo(lang);

            // Rakenda ressursid uuesti
            var res =
                new ComponentResourceManager(typeof(Peavorm));

            ApplyResourcesToControl(this, res);

            // Vormi pealkiri
            res.ApplyResources(this, "$this");
        }

        private void comboLanguage_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            if (!_keelLaetud)
                return;

            if (comboLanguage.SelectedItem.ToString() == "English")
                ChangeLanguage("en-US");
            else
                ChangeLanguage("et-EE");
        }
        private void btnTooted_Click(object sender, EventArgs e)
        {
            tooted f = new tooted();
            f.ShowDialog();
        }

        private void btnArve_Click(object sender, EventArgs e)
        {
            ArveForm arve = new ArveForm();
            arve.ShowDialog();
        }

        private void github_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                    {
                        FileName = "https://github.com/Lvakos/Tooted_ulesanne",
                        UseShellExecute = true
                    });
}
            catch (Exception ex)
            {
                MessageBox.Show("Brauserit ei saanud avada: " + ex.Message);
            }
        }

        private void LisaKasutajateNupp()
        {
            var btnKasutajad = new Button
            {
                Name = "btnKasutajad",
                Text = "Kasutajate haldamine",
                Location = new Point(137, 163),
                Size = new Size(200, 40),
                BackColor = Color.FromArgb(255, 128, 0),
                ForeColor = Color.White,
                UseVisualStyleBackColor = false,
                TabIndex = 6
            };

            var resources =
                new ComponentResourceManager(typeof(Peavorm));

            resources.ApplyResources(
                btnKasutajad,
                btnKasutajad.Name);

            btnKasutajad.Visible = AktiivneKasutaja.OnAdmin;

            btnKasutajad.Click += (sender, e) =>
            {
                if (!AktiivneKasutaja.OnAdmin)
                    return;

                using (var form = new Kasutajad())
                {
                    form.ShowDialog(this);
                }

                string titleFormat =
                    resources.GetString("MainTitleFormat");

                if (!string.IsNullOrEmpty(titleFormat))
                {
                    Text = string.Format(
                        CultureInfo.CurrentCulture,
                        titleFormat,
                        AktiivneKasutaja.Nimi,
                        AktiivneKasutaja.Roll);
                }
            };

            Controls.Add(btnKasutajad);
        }
    }
}