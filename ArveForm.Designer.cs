namespace Tooted
{
    partial class ArveForm
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
        /// 
        private System.Windows.Forms.ListBox listOstukorv;
        private System.Windows.Forms.Button btnLisaKorvi;
        private System.Windows.Forms.Button btnGenPDF;
        private System.Windows.Forms.Button btnSaadaEmail;
        private DataGridView dataGridTooted;

        private void InitializeComponent()
        {

            this.listOstukorv = new System.Windows.Forms.ListBox();
            this.btnLisaKorvi = new System.Windows.Forms.Button();
            this.btnGenPDF = new System.Windows.Forms.Button();
            this.btnSaadaEmail = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // listOstukorv
            this.listOstukorv.Location = new System.Drawing.Point(20, 20);
            this.listOstukorv.Size = new System.Drawing.Size(300, 300);

            // btnLisaKorvi
            this.btnLisaKorvi.Text = "Lisa toode korvi";
            this.btnLisaKorvi.Location = new System.Drawing.Point(350, 20);
            this.btnLisaKorvi.Click += btnLisaKorvi_Click;

            // btnGenPDF
            this.btnGenPDF.Text = "Genereeri PDF";
            this.btnGenPDF.Location = new System.Drawing.Point(350, 70);
            this.btnGenPDF.Click += btnGenPDF_Click;

            // btnSaadaEmail
            this.btnSaadaEmail.Text = "Saada emailiga";
            this.btnSaadaEmail.Location = new System.Drawing.Point(350, 120);
            this.btnSaadaEmail.Click += btnSaadaEmail_Click;

            // ArveForm
            this.ClientSize = new System.Drawing.Size(550, 350);
            this.Controls.Add(this.listOstukorv);
            this.Controls.Add(this.btnLisaKorvi);
            this.Controls.Add(this.btnGenPDF);
            this.Controls.Add(this.btnSaadaEmail);
            this.Text = "Arve";
            this.ResumeLayout(false);
        }

        #endregion
    }
}