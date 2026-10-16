using System;
using System.Linq;
using System.Windows.Forms;

namespace Tooted
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using var db = new ToodedContext();

            string email = txtEmail.Text.Trim();
            string parool = txtParool.Text;

            var kasutaja = db.Kasutajad.FirstOrDefault(k => k.Email == email);

            if (kasutaja == null)
            {
                lblVeateade.Text = "Vale email!";
                return;
            }

            if (!PasswordHelper.Verify(parool, kasutaja.ParoolHash))
            {
                lblVeateade.Text = "Vale parool!";
                return;
            }

            // roll salvestatakse globaalselt
            AktiivneKasutaja.Nimi = kasutaja.Nimi;
            AktiivneKasutaja.Roll = kasutaja.Roll;

            // Program.cs avab peale seda peamenüü
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
