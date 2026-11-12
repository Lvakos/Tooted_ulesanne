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
            comboLanguage = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnTooted
            // 
            btnTooted.BackColor = Color.FromArgb(255, 128, 0);
            resources.ApplyResources(btnTooted, "btnTooted");
            btnTooted.ForeColor = SystemColors.ButtonHighlight;
            btnTooted.Name = "btnTooted";
            btnTooted.UseVisualStyleBackColor = false;
            btnTooted.Click += btnTooted_Click;
            // 
            // btnArve
            // 
            btnArve.BackColor = Color.FromArgb(255, 128, 0);
            resources.ApplyResources(btnArve, "btnArve");
            btnArve.ForeColor = SystemColors.ButtonHighlight;
            btnArve.Name = "btnArve";
            btnArve.UseVisualStyleBackColor = false;
            btnArve.Click += btnArve_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.waurma;
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // github
            // 
            github.BackColor = Color.White;
            github.BackgroundImage = Properties.Resources._25231;
            resources.ApplyResources(github, "github");
            github.Cursor = Cursors.Hand;
            github.Name = "github";
            github.UseVisualStyleBackColor = false;
            github.Click += github_Click;
            // 
            // comboLanguage
            // 
            comboLanguage.DropDownStyle = ComboBoxStyle.DropDownList;
            comboLanguage.FormattingEnabled = true;
            resources.ApplyResources(comboLanguage, "comboLanguage");
            comboLanguage.Name = "comboLanguage";
            // 
            // Peavorm
            // 
            AccessibleRole = AccessibleRole.None;
            BackColor = Color.FromArgb(255, 192, 128);
            resources.ApplyResources(this, "$this");
            Controls.Add(comboLanguage);
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
        private ComboBox comboLanguage;
    }
}