using Microsoft.EntityFrameworkCore;

namespace Tooted
{
    partial class Form1
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
            tabpood = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            pictureBox1 = new PictureBox();
            tabpood.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tabpood
            // 
            tabpood.Controls.Add(tabPage1);
            tabpood.Controls.Add(tabPage2);
            tabpood.Font = new Font("Segoe UI", 12F);
            tabpood.Location = new Point(10, 10);
            tabpood.Name = "tabpood";
            tabpood.SelectedIndex = 0;
            tabpood.Size = new Size(900, 532);
            tabpood.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.FromArgb(255, 128, 0);
            tabPage1.Location = new Point(4, 30);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(892, 498);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.Click += tabPage1_Click;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.FromArgb(255, 128, 0);
            tabPage2.Font = new Font("Segoe UI", 12F);
            tabPage2.ForeColor = Color.White;
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(892, 572);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.waurma;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.ErrorImage = null;
            pictureBox1.ImageLocation = "Images\\waurma.png";
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(788, 559);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(119, 53);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(919, 624);
            Controls.Add(pictureBox1);
            Controls.Add(tabpood);
            Name = "Form1";
            Text = "Form1";
            tabpood.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);

        }
        #endregion
        private TabControl tabpood;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private PictureBox pictureBox1;
    }
}