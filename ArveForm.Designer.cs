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
            listTooted = new ListBox();
            lblOstukorv = new Label();
            listOstukorv = new ListBox();
            lblKokku = new Label();
            btnLisaKorvi = new Button();
            btnGenPDF = new Button();
            btnSaadaEmail = new Button();
            pictureBox1 = new PictureBox();
            toodeNimi = new Label();
            toodeKirjeldus = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            lblTooted.AutoSize = true;
            lblTooted.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTooted.Location = new Point(20, 15);
            lblTooted.Name = "lblTooted";
            lblTooted.Size = new Size(56, 19);
            lblTooted.TabIndex = 0;
            lblTooted.Text = "Tooted";
            listTooted.BackColor = Color.FromArgb(255, 128, 0);
            listTooted.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            listTooted.ForeColor = Color.White;
            listTooted.ItemHeight = 21;
            listTooted.Location = new Point(20, 40);
            listTooted.Name = "listTooted";
            listTooted.Size = new Size(220, 277);
            listTooted.TabIndex = 0;
            listTooted.SelectedIndexChanged += listTooted_SelectedIndexChanged;
            lblOstukorv.AutoSize = true;
            lblOstukorv.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblOstukorv.Location = new Point(260, 15);
            lblOstukorv.Name = "lblOstukorv";
            lblOstukorv.Size = new Size(237, 19);
            lblOstukorv.TabIndex = 1;
            lblOstukorv.Text = "Ostukorv (topeltklõps = eemalda)";
            listOstukorv.BackColor = Color.FromArgb(255, 128, 0);
            listOstukorv.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            listOstukorv.ForeColor = Color.White;
            listOstukorv.ItemHeight = 21;
            listOstukorv.Location = new Point(260, 40);
            listOstukorv.Name = "listOstukorv";
            listOstukorv.Size = new Size(250, 277);
            listOstukorv.TabIndex = 1;
            listOstukorv.DoubleClick += listOstukorv_DoubleClick;
            lblKokku.AutoSize = true;
            lblKokku.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblKokku.Location = new Point(340, 332);
            lblKokku.Name = "lblKokku";
            lblKokku.Size = new Size(88, 21);
            lblKokku.TabIndex = 2;
            lblKokku.Text = "Kokku: 0 €";
            btnLisaKorvi.BackColor = Color.FromArgb(255, 128, 0);
            btnLisaKorvi.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnLisaKorvi.Location = new Point(530, 40);
            btnLisaKorvi.Name = "btnLisaKorvi";
            btnLisaKorvi.Size = new Size(150, 35);
            btnLisaKorvi.TabIndex = 2;
            btnLisaKorvi.Text = "Lisa toode korvi";
            btnLisaKorvi.UseVisualStyleBackColor = false;
            btnLisaKorvi.Click += btnLisaKorvi_Click;
            btnGenPDF.BackColor = Color.FromArgb(255, 128, 0);
            btnGenPDF.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnGenPDF.Location = new Point(530, 85);
            btnGenPDF.Name = "btnGenPDF";
            btnGenPDF.Size = new Size(150, 35);
            btnGenPDF.TabIndex = 3;
            btnGenPDF.Text = "Genereeri PDF";
            btnGenPDF.UseVisualStyleBackColor = false;
            btnGenPDF.Click += btnGenPDF_Click;
            btnSaadaEmail.BackColor = Color.FromArgb(255, 128, 0);
            btnSaadaEmail.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnSaadaEmail.Location = new Point(530, 130);
            btnSaadaEmail.Name = "btnSaadaEmail";
            btnSaadaEmail.Size = new Size(150, 35);
            btnSaadaEmail.TabIndex = 4;
            btnSaadaEmail.Text = "Saada emailiga";
            btnSaadaEmail.UseVisualStyleBackColor = false;
            btnSaadaEmail.Click += btnSaadaEmail_Click;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(530, 180);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 120);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            toodeNimi.AutoSize = true;
            toodeNimi.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            toodeNimi.Location = new Point(530, 305);
            toodeNimi.Name = "toodeNimi";
            toodeNimi.Size = new Size(0, 21);
            toodeNimi.TabIndex = 6;
            toodeKirjeldus.AutoSize = true;
            toodeKirjeldus.Font = new Font("Segoe UI", 9F);
            toodeKirjeldus.Location = new Point(530, 330);
            toodeKirjeldus.Name = "toodeKirjeldus";
            toodeKirjeldus.Size = new Size(0, 15);
            toodeKirjeldus.TabIndex = 7;
            pictureBox2.BackgroundImage = Properties.Resources.waurma;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.ErrorImage = null;
            pictureBox2.ImageLocation = "Images\\waurma.png";
            pictureBox2.InitialImage = null;
            pictureBox2.Location = new Point(579, 351);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(119, 53);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(710, 416);
            Controls.Add(pictureBox2);
            Controls.Add(lblTooted);
            Controls.Add(listTooted);
            Controls.Add(lblOstukorv);
            Controls.Add(listOstukorv);
            Controls.Add(lblKokku);
            Controls.Add(btnLisaKorvi);
            Controls.Add(btnGenPDF);
            Controls.Add(btnSaadaEmail);
            Controls.Add(pictureBox1);
            Controls.Add(toodeNimi);
            Controls.Add(toodeKirjeldus);
            Name = "ArveForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Arve";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTooted;
        private ListBox listTooted;
        private Label lblOstukorv;
        private ListBox listOstukorv;
        private Label lblKokku;
        private Button btnLisaKorvi;
        private Button btnGenPDF;
        private Button btnSaadaEmail;
        private PictureBox pictureBox1;
        private Label toodeNimi;
        private Label toodeKirjeldus;
        private PictureBox pictureBox2;
    }
}
