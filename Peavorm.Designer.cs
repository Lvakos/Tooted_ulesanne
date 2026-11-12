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
        private Button btnArve;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Peavorm));
            btnTooted = new Button();
            btnArve = new Button();
            pictureBox1 = new PictureBox();
            github = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnTooted
            // 
            resources.ApplyResources(btnTooted, "btnTooted");
            btnTooted.BackColor = Color.FromArgb(255, 128, 0);
            btnTooted.ForeColor = SystemColors.ButtonHighlight;
            btnTooted.Name = "btnTooted";
            btnTooted.UseVisualStyleBackColor = false;
            btnTooted.Click += btnTooted_Click;
            // 
            // btnArve
            // 
            resources.ApplyResources(btnArve, "btnArve");
            btnArve.BackColor = Color.FromArgb(255, 128, 0);
            btnArve.ForeColor = SystemColors.ButtonHighlight;
            btnArve.Name = "btnArve";
            btnArve.UseVisualStyleBackColor = false;
            btnArve.Click += btnArve_Click;
            // 
            // pictureBox1
            // 
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.BackgroundImage = Properties.Resources.waurma;
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // github
            // 
            resources.ApplyResources(github, "github");
            github.BackColor = Color.White;
            github.BackgroundImage = Properties.Resources._25231;
            github.Cursor = Cursors.Hand;
            github.Name = "github";
            github.UseVisualStyleBackColor = false;
            github.Click += github_Click;
            // 
            // Peavorm
            // 
            resources.ApplyResources(this, "$this");
            BackColor = Color.FromArgb(255, 192, 128);
            Controls.Add(github);
            Controls.Add(pictureBox1);
            Controls.Add(btnTooted);
            Controls.Add(btnArve);
            Name = "Peavorm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button github;
    }
}