namespace Tooted
{
    partial class Payment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pictureBox2 = new PictureBox();
            card1 = new Button();
            card2 = new Button();
            card3 = new Button();
            lblMaksevoimalus = new Label();
            lblAndmed = new Label();
            Address = new TextBox();
            label1 = new Label();
            label2 = new Label();
            Nimi = new TextBox();
            label3 = new Label();
            Email = new TextBox();
            lblSumma = new Label();
            lblVihje = new Label();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            //
            // pictureBox2
            //
            pictureBox2.BackgroundImage = Properties.Resources.waurma;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.ErrorImage = null;
            pictureBox2.InitialImage = null;
            pictureBox2.Location = new Point(394, 259);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(119, 53);
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            //
            // card1
            //
            card1.AccessibleName = "Visa";
            card1.BackColor = Color.White;
            card1.BackgroundImage = Properties.Resources.visa;
            card1.BackgroundImageLayout = ImageLayout.Stretch;
            card1.Cursor = Cursors.Hand;
            card1.Location = new Point(11, 180);
            card1.Name = "card1";
            card1.Size = new Size(83, 81);
            card1.TabIndex = 4;
            card1.Tag = "Visa";
            card1.UseVisualStyleBackColor = false;
            //
            // card2
            //
            card2.AccessibleName = "Mastercard";
            card2.BackColor = Color.White;
            card2.BackgroundImage = Properties.Resources.mastercard;
            card2.BackgroundImageLayout = ImageLayout.Stretch;
            card2.Cursor = Cursors.Hand;
            card2.Location = new Point(100, 180);
            card2.Name = "card2";
            card2.Size = new Size(83, 81);
            card2.TabIndex = 5;
            card2.Tag = "Mastercard";
            card2.UseVisualStyleBackColor = false;
            //
            // card3
            //
            card3.AccessibleName = "PayPal";
            card3.BackColor = Color.White;
            card3.BackgroundImage = Properties.Resources.Paypal;
            card3.BackgroundImageLayout = ImageLayout.Stretch;
            card3.Cursor = Cursors.Hand;
            card3.Location = new Point(189, 180);
            card3.Name = "card3";
            card3.Size = new Size(83, 81);
            card3.TabIndex = 6;
            card3.Tag = "PayPal";
            card3.UseVisualStyleBackColor = false;
            //
            // lblMaksevoimalus
            //
            lblMaksevoimalus.AutoSize = true;
            lblMaksevoimalus.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblMaksevoimalus.Location = new Point(11, 156);
            lblMaksevoimalus.Name = "lblMaksevoimalus";
            lblMaksevoimalus.Size = new Size(129, 21);
            lblMaksevoimalus.TabIndex = 13;
            lblMaksevoimalus.Text = "Maksevõimalus";
            //
            // lblAndmed
            //
            lblAndmed.AutoSize = true;
            lblAndmed.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblAndmed.Location = new Point(13, 9);
            lblAndmed.Name = "lblAndmed";
            lblAndmed.Size = new Size(75, 21);
            lblAndmed.TabIndex = 14;
            lblAndmed.Text = "Andmed";
            //
            // Address
            //
            Address.Location = new Point(12, 61);
            Address.MaxLength = 150;
            Address.Name = "Address";
            Address.Size = new Size(230, 23);
            Address.TabIndex = 0;
            //
            // label1
            //
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(11, 38);
            label1.Name = "label1";
            label1.Size = new Size(70, 21);
            label1.TabIndex = 16;
            label1.Text = "Aadress";
            //
            // label2
            //
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(12, 98);
            label2.Name = "label2";
            label2.Size = new Size(48, 21);
            label2.TabIndex = 18;
            label2.Text = "Nimi";
            //
            // Nimi
            //
            Nimi.Location = new Point(13, 121);
            Nimi.MaxLength = 100;
            Nimi.Name = "Nimi";
            Nimi.Size = new Size(230, 23);
            Nimi.TabIndex = 1;
            //
            // label3
            //
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(268, 38);
            label3.Name = "label3";
            label3.Size = new Size(61, 21);
            label3.TabIndex = 19;
            label3.Text = "E-mail";
            //
            // Email
            //
            Email.Location = new Point(269, 61);
            Email.MaxLength = 120;
            Email.Name = "Email";
            Email.Size = new Size(230, 23);
            Email.TabIndex = 2;
            //
            // lblSumma
            //
            lblSumma.AutoSize = true;
            lblSumma.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblSumma.Location = new Point(290, 185);
            lblSumma.Name = "lblSumma";
            lblSumma.Size = new Size(120, 25);
            lblSumma.TabIndex = 21;
            lblSumma.Text = "Tasuda: 0 €";
            //
            // lblVihje
            //
            lblVihje.AutoSize = true;
            lblVihje.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblVihje.Location = new Point(11, 268);
            lblVihje.Name = "lblVihje";
            lblVihje.Size = new Size(260, 15);
            lblVihje.TabIndex = 22;
            lblVihje.Text = "Täida andmed ja klõpsa makseviisil, et maksta.";
            //
            // errorProvider1
            //
            errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider1.ContainerControl = this;
            //
            // Payment
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(525, 324);
            Controls.Add(lblVihje);
            Controls.Add(lblSumma);
            Controls.Add(label3);
            Controls.Add(Email);
            Controls.Add(label2);
            Controls.Add(Nimi);
            Controls.Add(label1);
            Controls.Add(Address);
            Controls.Add(lblAndmed);
            Controls.Add(lblMaksevoimalus);
            Controls.Add(card3);
            Controls.Add(card2);
            Controls.Add(card1);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Payment";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Maksevõimalus";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private Button card1;
        private Button card2;
        private Button card3;
        private Label lblMaksevoimalus;
        private Label lblAndmed;
        private TextBox Address;
        private Label label1;
        private Label label2;
        private TextBox Nimi;
        private Label label3;
        private TextBox Email;
        private Label lblSumma;
        private Label lblVihje;
        private ErrorProvider errorProvider1;
    }
}
