namespace Tooted
{
    partial class Peavorm
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

        private Button btnTooted;
        private Button btnPood;
        private Button btnArve;

        private void InitializeComponent()
        {
            btnTooted = new Button();
            btnPood = new Button();
            btnArve = new Button();
            pictureBox1 = new PictureBox();
            github = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            btnTooted.BackColor = Color.FromArgb(255, 128, 0);
            btnTooted.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnTooted.ForeColor = SystemColors.ButtonHighlight;
            btnTooted.Location = new Point(137, 71);
            btnTooted.Name = "btnTooted";
            btnTooted.Size = new Size(200, 40);
            btnTooted.TabIndex = 0;
            btnTooted.Text = "Tootehaldus";
            btnTooted.UseVisualStyleBackColor = false;
            btnTooted.Click += btnTooted_Click;
            btnPood.BackColor = Color.FromArgb(255, 128, 0);
            btnPood.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnPood.ForeColor = SystemColors.ButtonHighlight;
            btnPood.Location = new Point(137, 121);
            btnPood.Name = "btnPood";
            btnPood.Size = new Size(200, 40);
            btnPood.TabIndex = 1;
            btnPood.Text = "Pood";
            btnPood.UseVisualStyleBackColor = false;
            btnPood.Click += btnPood_Click;
            btnArve.BackColor = Color.FromArgb(255, 128, 0);
            btnArve.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnArve.ForeColor = SystemColors.ButtonHighlight;
            btnArve.Location = new Point(137, 171);
            btnArve.Name = "btnArve";
            btnArve.Size = new Size(200, 40);
            btnArve.TabIndex = 2;
            btnArve.Text = "Arve";
            btnArve.UseVisualStyleBackColor = false;
            btnArve.Click += btnArve_Click;
            pictureBox1.BackgroundImage = Properties.Resources.waurma;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.ErrorImage = null;
            pictureBox1.ImageLocation = "Images\\waurma.png";
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(179, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(119, 53);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            github.BackColor = Color.White;
            github.BackgroundImage = Properties.Resources._25231;
            github.BackgroundImageLayout = ImageLayout.Stretch;
            github.Location = new Point(211, 217);
            github.Name = "github";
            github.Size = new Size(53, 51);
            github.TabIndex = 4;
            github.UseVisualStyleBackColor = false;
            github.Cursor = Cursors.Hand;
            github.Click += github_Click;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(493, 273);
            Controls.Add(github);
            Controls.Add(pictureBox1);
            Controls.Add(btnTooted);
            Controls.Add(btnPood);
            Controls.Add(btnArve);
            Name = "Peavorm";
            Text = "Peamenüü";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button github;
    }
}