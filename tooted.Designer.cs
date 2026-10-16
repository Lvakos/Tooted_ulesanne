namespace Tooted
{
    partial class tooted
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
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
            ((System.ComponentModel.ISupportInitialize)picPilt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridTooted).BeginInit();
            SuspendLayout();
            // 
            // txtNimetus
            // 
            txtNimetus.Font = new Font("Segoe UI", 14F);
            txtNimetus.Location = new Point(169, 26);
            txtNimetus.Name = "txtNimetus";
            txtNimetus.Size = new Size(157, 32);
            txtNimetus.TabIndex = 1;
            // 
            // txtKogus
            // 
            txtKogus.Font = new Font("Segoe UI", 14F);
            txtKogus.Location = new Point(168, 73);
            txtKogus.Name = "txtKogus";
            txtKogus.Size = new Size(157, 32);
            txtKogus.TabIndex = 2;
            // 
            // txtHind
            // 
            txtHind.Font = new Font("Segoe UI", 14F);
            txtHind.Location = new Point(168, 120);
            txtHind.Name = "txtHind";
            txtHind.Size = new Size(157, 32);
            txtHind.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(40, 32);
            label1.Name = "label1";
            label1.Size = new Size(123, 21);
            label1.TabIndex = 5;
            label1.Text = "Toode nimetus";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(105, 79);
            label2.Name = "label2";
            label2.Size = new Size(57, 21);
            label2.TabIndex = 6;
            label2.Text = "Kogus";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(115, 126);
            label3.Name = "label3";
            label3.Size = new Size(47, 21);
            label3.TabIndex = 7;
            label3.Text = "Hind";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(69, 176);
            label4.Name = "label4";
            label4.Size = new Size(94, 21);
            label4.TabIndex = 8;
            label4.Text = "Kategooria";
            // 
            // cmbKategooria
            // 
            cmbKategooria.Font = new Font("Segoe UI", 14F);
            cmbKategooria.FormattingEnabled = true;
            cmbKategooria.Items.AddRange(new object[] { "Toidutooded", "Elektroonika", "Riided ja jalatsid" });
            cmbKategooria.Location = new Point(168, 170);
            cmbKategooria.Name = "cmbKategooria";
            cmbKategooria.Size = new Size(156, 33);
            cmbKategooria.TabIndex = 9;
            cmbKategooria.SelectedIndexChanged += cmbKategooria_SelectedIndexChanged;
            // 
            // btnLisaKategooria
            // 
            btnLisaKategooria.Cursor = Cursors.Hand;
            btnLisaKategooria.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 186);
            btnLisaKategooria.Location = new Point(115, 218);
            btnLisaKategooria.Name = "btnLisaKategooria";
            btnLisaKategooria.Size = new Size(105, 55);
            btnLisaKategooria.TabIndex = 10;
            btnLisaKategooria.Text = "Lisa kategooria";
            btnLisaKategooria.UseVisualStyleBackColor = true;
            btnLisaKategooria.Click += btnLisaKategooria_Click;
            // 
            // btnKustutaKategooria
            // 
            btnKustutaKategooria.Cursor = Cursors.Hand;
            btnKustutaKategooria.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 186);
            btnKustutaKategooria.Location = new Point(226, 218);
            btnKustutaKategooria.Name = "btnKustutaKategooria";
            btnKustutaKategooria.Size = new Size(105, 55);
            btnKustutaKategooria.TabIndex = 11;
            btnKustutaKategooria.Text = "Kustuta Kategooria";
            btnKustutaKategooria.UseVisualStyleBackColor = true;
            btnKustutaKategooria.Click += btnKustutaKategooria_Click;
            // 
            // btnOtsi
            // 
            btnOtsi.Cursor = Cursors.Hand;
            btnOtsi.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 186);
            btnOtsi.Location = new Point(337, 218);
            btnOtsi.Name = "btnOtsi";
            btnOtsi.Size = new Size(105, 35);
            btnOtsi.TabIndex = 12;
            btnOtsi.Text = "Otsi Fail";
            btnOtsi.UseVisualStyleBackColor = true;
            btnOtsi.Click += btnOtsi_Click;
            // 
            // btnLisa
            // 
            btnLisa.Cursor = Cursors.Hand;
            btnLisa.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 186);
            btnLisa.Location = new Point(448, 218);
            btnLisa.Name = "btnLisa";
            btnLisa.Size = new Size(105, 35);
            btnLisa.TabIndex = 13;
            btnLisa.Text = "Lisa";
            btnLisa.UseVisualStyleBackColor = true;
            btnLisa.Click += btnLisa_Click;
            // 
            // btnUuenda
            // 
            btnUuenda.Cursor = Cursors.Hand;
            btnUuenda.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 186);
            btnUuenda.Location = new Point(559, 218);
            btnUuenda.Name = "btnUuenda";
            btnUuenda.Size = new Size(95, 35);
            btnUuenda.TabIndex = 14;
            btnUuenda.Text = "Uuenda";
            btnUuenda.UseVisualStyleBackColor = true;
            btnUuenda.Click += btnUuenda_Click;
            // 
            // btnKustuta
            // 
            btnKustuta.Cursor = Cursors.Hand;
            btnKustuta.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 186);
            btnKustuta.Location = new Point(660, 218);
            btnKustuta.Name = "btnKustuta";
            btnKustuta.Size = new Size(92, 35);
            btnKustuta.TabIndex = 15;
            btnKustuta.Text = "Kustuta";
            btnKustuta.UseVisualStyleBackColor = true;
            btnKustuta.Click += btnKustuta_Click;
            // 
            // picPilt
            // 
            picPilt.Location = new Point(437, 32);
            picPilt.Name = "picPilt";
            picPilt.Size = new Size(233, 180);
            picPilt.SizeMode = PictureBoxSizeMode.Zoom;
            picPilt.TabIndex = 16;
            picPilt.TabStop = false;
            // 
            // dataGridTooted
            // 
            dataGridTooted.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridTooted.Location = new Point(115, 279);
            dataGridTooted.Name = "dataGridTooted";
            dataGridTooted.Size = new Size(637, 205);
            dataGridTooted.TabIndex = 17;
            dataGridTooted.CellClick += dataGridViewTooted_CellClick;
            // 
            // tooted
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(857, 496);
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
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)picPilt).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridTooted).EndInit();
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

    }
}
