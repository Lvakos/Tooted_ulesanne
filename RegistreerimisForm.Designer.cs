namespace Tooted
{
    partial class RegistreerimisForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistreerimisForm));
            lblNimi = new Label();
            txtNimi = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblParool = new Label();
            txtParool = new TextBox();
            lblKordus = new Label();
            txtKordus = new TextBox();
            btnRegistreeru = new Button();
            btnTagasi = new Button();
            lblVeateade = new Label();
            SuspendLayout();
            // 
            // lblNimi
            // 
            resources.ApplyResources(lblNimi, "lblNimi");
            lblNimi.Name = "lblNimi";
            lblNimi.Click += lblNimi_Click;
            // 
            // txtNimi
            // 
            resources.ApplyResources(txtNimi, "txtNimi");
            txtNimi.Name = "txtNimi";
            // 
            // lblEmail
            // 
            resources.ApplyResources(lblEmail, "lblEmail");
            lblEmail.Name = "lblEmail";
            // 
            // txtEmail
            // 
            resources.ApplyResources(txtEmail, "txtEmail");
            txtEmail.Name = "txtEmail";
            // 
            // lblParool
            // 
            resources.ApplyResources(lblParool, "lblParool");
            lblParool.Name = "lblParool";
            // 
            // txtParool
            // 
            resources.ApplyResources(txtParool, "txtParool");
            txtParool.Name = "txtParool";
            // 
            // lblKordus
            // 
            resources.ApplyResources(lblKordus, "lblKordus");
            lblKordus.Name = "lblKordus";
            // 
            // txtKordus
            // 
            resources.ApplyResources(txtKordus, "txtKordus");
            txtKordus.Name = "txtKordus";
            // 
            // btnRegistreeru
            // 
            resources.ApplyResources(btnRegistreeru, "btnRegistreeru");
            btnRegistreeru.BackColor = Color.FromArgb(255, 128, 0);
            btnRegistreeru.ForeColor = Color.White;
            btnRegistreeru.Name = "btnRegistreeru";
            btnRegistreeru.UseVisualStyleBackColor = false;
            btnRegistreeru.Click += btnRegistreeru_Click;
            // 
            // btnTagasi
            // 
            resources.ApplyResources(btnTagasi, "btnTagasi");
            btnTagasi.BackColor = Color.White;
            btnTagasi.ForeColor = Color.FromArgb(255, 128, 0);
            btnTagasi.Name = "btnTagasi";
            btnTagasi.UseVisualStyleBackColor = false;
            btnTagasi.Click += btnTagasi_Click;
            // 
            // lblVeateade
            // 
            resources.ApplyResources(lblVeateade, "lblVeateade");
            lblVeateade.ForeColor = Color.Red;
            lblVeateade.Name = "lblVeateade";
            // 
            // RegistreerimisForm
            // 
            AcceptButton = btnRegistreeru;
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            CancelButton = btnTagasi;
            Controls.Add(lblNimi);
            Controls.Add(txtNimi);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Controls.Add(lblParool);
            Controls.Add(txtParool);
            Controls.Add(lblKordus);
            Controls.Add(txtKordus);
            Controls.Add(btnRegistreeru);
            Controls.Add(btnTagasi);
            Controls.Add(lblVeateade);
            Name = "RegistreerimisForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNimi;
        private TextBox txtNimi;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblParool;
        private TextBox txtParool;
        private Label lblKordus;
        private TextBox txtKordus;
        private Button btnRegistreeru;
        private Button btnTagasi;
        private Label lblVeateade;
    }
}
