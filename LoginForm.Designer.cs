namespace Tooted
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblParool = new Label();
            txtParool = new TextBox();
            btnLogin = new Button();
            lblVeateade = new Label();
            btnRegistreeru = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblEmail
            // 
            resources.ApplyResources(lblEmail, "lblEmail");
            lblEmail.Name = "lblEmail";
            lblEmail.Click += lblEmail_Click;
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
            lblParool.Click += lblParool_Click;
            // 
            // txtParool
            // 
            resources.ApplyResources(txtParool, "txtParool");
            txtParool.Name = "txtParool";
            // 
            // btnLogin
            // 
            resources.ApplyResources(btnLogin, "btnLogin");
            btnLogin.BackColor = Color.FromArgb(255, 128, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Name = "btnLogin";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblVeateade
            // 
            resources.ApplyResources(lblVeateade, "lblVeateade");
            lblVeateade.ForeColor = Color.Red;
            lblVeateade.Name = "lblVeateade";
            // 
            // btnRegistreeru
            // 
            resources.ApplyResources(btnRegistreeru, "btnRegistreeru");
            btnRegistreeru.BackColor = Color.White;
            btnRegistreeru.Cursor = Cursors.Hand;
            btnRegistreeru.ForeColor = Color.FromArgb(255, 128, 0);
            btnRegistreeru.Name = "btnRegistreeru";
            btnRegistreeru.UseVisualStyleBackColor = false;
            btnRegistreeru.Click += btnRegistreeru_Click;
            // 
            // pictureBox1
            // 
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.BackgroundImage = Properties.Resources.waurma;
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            AcceptButton = btnLogin;
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            Controls.Add(pictureBox1);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Controls.Add(lblParool);
            Controls.Add(txtParool);
            Controls.Add(btnLogin);
            Controls.Add(lblVeateade);
            Controls.Add(btnRegistreeru);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblParool;
        private TextBox txtParool;
        private Button btnLogin;
        private Label lblVeateade;
        private PictureBox pictureBox1;
        private Button btnRegistreeru;
    }
}
