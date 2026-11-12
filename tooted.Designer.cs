namespace Tooted
{
    partial class tooted
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tooted));
            txtNimetus = new MaskedTextBox();
            txtKogus = new MaskedTextBox();
            txtHind = new MaskedTextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            cmbKategooria = new ComboBox();
            btnLisaKategooria = new Button();
            btnKustutaKategooria = new Button();
            btnOtsi = new Button();
            btnLisa = new Button();
            btnUuenda = new Button();
            btnKustuta = new Button();
            picPilt = new PictureBox();
            dataGridTooted = new DataGridView();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picPilt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridTooted).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtNimetus
            // 
            resources.ApplyResources(txtNimetus, "txtNimetus");
            txtNimetus.Name = "txtNimetus";
            // 
            // txtKogus
            // 
            resources.ApplyResources(txtKogus, "txtKogus");
            txtKogus.Name = "txtKogus";
            // 
            // txtHind
            // 
            resources.ApplyResources(txtHind, "txtHind");
            txtHind.Name = "txtHind";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.Name = "label4";
            // 
            // cmbKategooria
            // 
            resources.ApplyResources(cmbKategooria, "cmbKategooria");
            cmbKategooria.FormattingEnabled = true;
            cmbKategooria.Items.AddRange(new object[] { resources.GetString("cmbKategooria.Items"), resources.GetString("cmbKategooria.Items1"), resources.GetString("cmbKategooria.Items2") });
            cmbKategooria.Name = "cmbKategooria";
            cmbKategooria.SelectedIndexChanged += cmbKategooria_SelectedIndexChanged;
            // 
            // btnLisaKategooria
            // 
            btnLisaKategooria.BackColor = Color.FromArgb(255, 128, 0);
            btnLisaKategooria.Cursor = Cursors.Hand;
            resources.ApplyResources(btnLisaKategooria, "btnLisaKategooria");
            btnLisaKategooria.ForeColor = Color.White;
            btnLisaKategooria.Name = "btnLisaKategooria";
            btnLisaKategooria.UseVisualStyleBackColor = false;
            btnLisaKategooria.Click += btnLisaKategooria_Click;
            // 
            // btnKustutaKategooria
            // 
            btnKustutaKategooria.BackColor = Color.FromArgb(255, 128, 0);
            btnKustutaKategooria.Cursor = Cursors.Hand;
            resources.ApplyResources(btnKustutaKategooria, "btnKustutaKategooria");
            btnKustutaKategooria.ForeColor = Color.White;
            btnKustutaKategooria.Name = "btnKustutaKategooria";
            btnKustutaKategooria.UseVisualStyleBackColor = false;
            btnKustutaKategooria.Click += btnKustutaKategooria_Click;
            // 
            // btnOtsi
            // 
            btnOtsi.BackColor = Color.FromArgb(255, 128, 0);
            btnOtsi.Cursor = Cursors.Hand;
            resources.ApplyResources(btnOtsi, "btnOtsi");
            btnOtsi.ForeColor = Color.White;
            btnOtsi.Name = "btnOtsi";
            btnOtsi.UseVisualStyleBackColor = false;
            btnOtsi.Click += btnOtsi_Click;
            // 
            // btnLisa
            // 
            btnLisa.BackColor = Color.FromArgb(255, 128, 0);
            btnLisa.Cursor = Cursors.Hand;
            resources.ApplyResources(btnLisa, "btnLisa");
            btnLisa.ForeColor = Color.White;
            btnLisa.Name = "btnLisa";
            btnLisa.UseVisualStyleBackColor = false;
            btnLisa.Click += btnLisa_Click;
            // 
            // btnUuenda
            // 
            btnUuenda.BackColor = Color.FromArgb(255, 128, 0);
            btnUuenda.Cursor = Cursors.Hand;
            resources.ApplyResources(btnUuenda, "btnUuenda");
            btnUuenda.ForeColor = Color.White;
            btnUuenda.Name = "btnUuenda";
            btnUuenda.UseVisualStyleBackColor = false;
            btnUuenda.Click += btnUuenda_Click;
            // 
            // btnKustuta
            // 
            btnKustuta.BackColor = Color.FromArgb(255, 128, 0);
            btnKustuta.Cursor = Cursors.Hand;
            resources.ApplyResources(btnKustuta, "btnKustuta");
            btnKustuta.ForeColor = Color.White;
            btnKustuta.Name = "btnKustuta";
            btnKustuta.UseVisualStyleBackColor = false;
            btnKustuta.Click += btnKustuta_Click;
            // 
            // picPilt
            // 
            resources.ApplyResources(picPilt, "picPilt");
            picPilt.Name = "picPilt";
            picPilt.TabStop = false;
            // 
            // dataGridTooted
            // 
            dataGridTooted.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(dataGridTooted, "dataGridTooted");
            dataGridTooted.Name = "dataGridTooted";
            dataGridTooted.CellClick += dataGridViewTooted_CellClick;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.waurma;
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // tooted
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            Controls.Add(pictureBox1);
            Controls.Add(dataGridTooted);
            Controls.Add(picPilt);
            Controls.Add(btnKustuta);
            Controls.Add(btnUuenda);
            Controls.Add(btnLisa);
            Controls.Add(btnOtsi);
            Controls.Add(btnKustutaKategooria);
            Controls.Add(btnLisaKategooria);
            Controls.Add(cmbKategooria);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtHind);
            Controls.Add(txtKogus);
            Controls.Add(txtNimetus);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "tooted";
            ((System.ComponentModel.ISupportInitialize)picPilt).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridTooted).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private MaskedTextBox txtNimetus;
        private MaskedTextBox txtKogus;
        private MaskedTextBox txtHind;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox cmbKategooria;
        private Button btnLisaKategooria;
        private Button btnKustutaKategooria;
        private Button btnOtsi;
        private Button btnLisa;
        private Button btnUuenda;
        private Button btnKustuta;
        private PictureBox picPilt;
        private DataGridView dataGridTooted;
        private PictureBox pictureBox1;
    }
}
