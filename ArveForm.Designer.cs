namespace Tooted
{
    partial class ArveForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArveForm));
            lblTooted = new Label();
            tabTooted = new TabControl();
            lblOstukorv = new Label();
            listOstukorv = new ListBox();
            lblKokku = new Label();
            ostaBtn = new Button();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // lblTooted
            // 
            resources.ApplyResources(lblTooted, "lblTooted");
            lblTooted.Name = "lblTooted";
            // 
            // tabTooted
            // 
            resources.ApplyResources(tabTooted, "tabTooted");
            tabTooted.Name = "tabTooted";
            tabTooted.SelectedIndex = 0;
            // 
            // lblOstukorv
            // 
            resources.ApplyResources(lblOstukorv, "lblOstukorv");
            lblOstukorv.Name = "lblOstukorv";
            lblOstukorv.Click += lblOstukorv_Click;
            // 
            // listOstukorv
            // 
            resources.ApplyResources(listOstukorv, "listOstukorv");
            listOstukorv.BackColor = Color.FromArgb(255, 128, 0);
            listOstukorv.ForeColor = Color.White;
            listOstukorv.Name = "listOstukorv";
            listOstukorv.DoubleClick += listOstukorv_DoubleClick;
            // 
            // lblKokku
            // 
            resources.ApplyResources(lblKokku, "lblKokku");
            lblKokku.Name = "lblKokku";
            lblKokku.Click += lblKokku_Click;
            // 
            // ostaBtn
            // 
            resources.ApplyResources(ostaBtn, "ostaBtn");
            ostaBtn.BackColor = Color.FromArgb(255, 128, 0);
            ostaBtn.Cursor = Cursors.Hand;
            ostaBtn.ForeColor = Color.White;
            ostaBtn.Name = "ostaBtn";
            ostaBtn.UseVisualStyleBackColor = false;
            ostaBtn.Click += ostaBtn_Click;
            // 
            // pictureBox2
            // 
            resources.ApplyResources(pictureBox2, "pictureBox2");
            pictureBox2.BackgroundImage = Properties.Resources.waurma;
            pictureBox2.Name = "pictureBox2";
            pictureBox2.TabStop = false;
            // 
            // ArveForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            Controls.Add(pictureBox2);
            Controls.Add(lblTooted);
            Controls.Add(tabTooted);
            Controls.Add(lblOstukorv);
            Controls.Add(listOstukorv);
            Controls.Add(lblKokku);
            Controls.Add(ostaBtn);
            Name = "ArveForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTooted;
        private TabControl tabTooted;
        private Label lblOstukorv;
        private ListBox listOstukorv;
        private Label lblKokku;
        private Button ostaBtn;
        private PictureBox pictureBox2;
    }
}
