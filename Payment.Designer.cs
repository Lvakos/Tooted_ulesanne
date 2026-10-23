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
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.waurma;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.ErrorImage = null;
            pictureBox2.ImageLocation = "Images\\waurma.png";
            pictureBox2.InitialImage = null;
            pictureBox2.Location = new Point(394, 233);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(119, 53);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // card1
            // 
            card1.BackColor = Color.White;
            card1.BackgroundImage = Properties.Resources.visa;
            card1.BackgroundImageLayout = ImageLayout.Stretch;
            card1.Cursor = Cursors.Hand;
            card1.Location = new Point(11, 180);
            card1.Name = "card1";
            card1.Size = new Size(83, 81);
            card1.TabIndex = 10;
            card1.UseVisualStyleBackColor = false;
            // 
            // card2
            // 
            card2.BackColor = Color.White;
            card2.BackgroundImage = Properties.Resources.mastercard;
            card2.BackgroundImageLayout = ImageLayout.Stretch;
            card2.Cursor = Cursors.Hand;
            card2.Location = new Point(100, 180);
            card2.Name = "card2";
            card2.Size = new Size(83, 81);
            card2.TabIndex = 11;
            card2.UseVisualStyleBackColor = false;
            // 
            // card3
            // 
            card3.BackColor = Color.White;
            card3.BackgroundImage = Properties.Resources.paypal;
            card3.BackgroundImageLayout = ImageLayout.Stretch;
            card3.Cursor = Cursors.Hand;
            card3.Location = new Point(189, 180);
            card3.Name = "card3";
            card3.Size = new Size(83, 81);
            card3.TabIndex = 12;
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
            lblMaksevoimalus.Click += lblTooted_Click;
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
            lblAndmed.Click += label1_Click;
            // 
            // Address
            // 
            Address.Location = new Point(12, 61);
            Address.Name = "Address";
            Address.Size = new Size(240, 23);
            Address.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(11, 38);
            label1.Name = "label1";
            label1.Size = new Size(70, 21);
            label1.TabIndex = 16;
            label1.Text = "Address";
            label1.Click += label1_Click_1;
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
            Nimi.Name = "Nimi";
            Nimi.Size = new Size(240, 23);
            Nimi.TabIndex = 17;
            Nimi.TextChanged += textBox1_TextChanged;
            // 
            // Payment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(525, 298);
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
            Name = "Payment";
            Text = "Maksevõimalus";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
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
    }
}