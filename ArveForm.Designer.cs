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
            lblTooted.AutoSize = true;
            lblTooted.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTooted.Location = new Point(20, 15);
            lblTooted.Name = "lblTooted";
            lblTooted.Size = new Size(56, 19);
            lblTooted.TabIndex = 0;
            lblTooted.Text = "Tooted";
            //
            // tabTooted
            //
            tabTooted.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            tabTooted.Location = new Point(20, 40);
            tabTooted.Name = "tabTooted";
            tabTooted.SelectedIndex = 0;
            tabTooted.Size = new Size(745, 540);
            tabTooted.TabIndex = 0;
            //
            // lblOstukorv
            //
            lblOstukorv.AutoSize = true;
            lblOstukorv.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblOstukorv.Location = new Point(785, 15);
            lblOstukorv.Name = "lblOstukorv";
            lblOstukorv.Size = new Size(237, 19);
            lblOstukorv.TabIndex = 1;
            lblOstukorv.Text = "Ostukorv (topeltklõps = eemalda)";
            //
            // listOstukorv
            //
            listOstukorv.BackColor = Color.FromArgb(255, 128, 0);
            listOstukorv.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold | FontStyle.Italic);
            listOstukorv.ForeColor = Color.White;
            listOstukorv.HorizontalScrollbar = true;
            listOstukorv.ItemHeight = 20;
            listOstukorv.Location = new Point(785, 40);
            listOstukorv.Name = "listOstukorv";
            listOstukorv.Size = new Size(275, 404);
            listOstukorv.TabIndex = 1;
            listOstukorv.DoubleClick += listOstukorv_DoubleClick;
            //
            // lblKokku
            //
            lblKokku.AutoSize = true;
            lblKokku.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblKokku.Location = new Point(785, 455);
            lblKokku.Name = "lblKokku";
            lblKokku.Size = new Size(98, 25);
            lblKokku.TabIndex = 2;
            lblKokku.Text = "Kokku: 0 €";
            //
            // ostaBtn
            //
            ostaBtn.BackColor = Color.FromArgb(255, 128, 0);
            ostaBtn.Cursor = Cursors.Hand;
            ostaBtn.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            ostaBtn.ForeColor = Color.White;
            ostaBtn.Location = new Point(785, 490);
            ostaBtn.Name = "ostaBtn";
            ostaBtn.Size = new Size(275, 40);
            ostaBtn.TabIndex = 3;
            ostaBtn.Text = "Osta tooted";
            ostaBtn.UseVisualStyleBackColor = false;
            ostaBtn.Click += ostaBtn_Click;
            //
            // pictureBox2
            //
            pictureBox2.BackgroundImage = Properties.Resources.waurma;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.ErrorImage = null;
            pictureBox2.InitialImage = null;
            pictureBox2.Location = new Point(941, 538);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(119, 53);
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            //
            // ArveForm
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(1080, 600);
            Controls.Add(pictureBox2);
            Controls.Add(lblTooted);
            Controls.Add(tabTooted);
            Controls.Add(lblOstukorv);
            Controls.Add(listOstukorv);
            Controls.Add(lblKokku);
            Controls.Add(ostaBtn);
            Name = "ArveForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pood";
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
