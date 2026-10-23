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
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(30, 25);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(41, 15);
            lblEmail.TabIndex = 0;
            lblEmail.Text = "E-mail";
            txtEmail.Location = new Point(30, 45);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(240, 23);
            txtEmail.TabIndex = 0;
            lblParool.AutoSize = true;
            lblParool.Location = new Point(30, 80);
            lblParool.Name = "lblParool";
            lblParool.Size = new Size(41, 15);
            lblParool.TabIndex = 1;
            lblParool.Text = "Parool";
            txtParool.Location = new Point(30, 100);
            txtParool.Name = "txtParool";
            txtParool.PasswordChar = '*';
            txtParool.Size = new Size(240, 23);
            txtParool.TabIndex = 1;
            btnLogin.BackColor = Color.FromArgb(255, 128, 0);
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 186);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(30, 140);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(240, 35);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Logi sisse";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            lblVeateade.AutoSize = true;
            lblVeateade.ForeColor = Color.Red;
            lblVeateade.Location = new Point(30, 222);
            lblVeateade.Name = "lblVeateade";
            lblVeateade.Size = new Size(0, 15);
            lblVeateade.TabIndex = 3;
            btnRegistreeru.BackColor = Color.White;
            btnRegistreeru.Cursor = Cursors.Hand;
            btnRegistreeru.ForeColor = Color.FromArgb(255, 128, 0);
            btnRegistreeru.Location = new Point(30, 183);
            btnRegistreeru.Name = "btnRegistreeru";
            btnRegistreeru.Size = new Size(240, 30);
            btnRegistreeru.TabIndex = 5;
            btnRegistreeru.Text = "Pole kontot? Registreeru";
            btnRegistreeru.UseVisualStyleBackColor = false;
            btnRegistreeru.Click += btnRegistreeru_Click;
            pictureBox1.BackgroundImage = Properties.Resources.waurma;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.ErrorImage = null;
            pictureBox1.ImageLocation = "Images\\waurma.png";
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(89, 245);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(119, 53);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(300, 310);
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
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WaurmaID";
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
