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
            tabpood.SuspendLayout();
            SuspendLayout();

            // Form3
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 630);
            this.Controls.Add(this.tabpood);
            this.Name = "Form3";
            this.Text = "Pood";
            this.ResumeLayout(false);
            // 
            // tabControl1
            // 
            tabpood.Controls.Add(tabPage1);
            tabpood.Controls.Add(tabPage2);
            tabpood.Location = new Point(10, 10);
            tabpood.Name = "tabPood";
            tabpood.SelectedIndex = 0;
            tabpood.Size = new Size(900, 600);
            tabpood.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(892, 572);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(892, 578);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(919, 624);
            Controls.Add(tabpood);
            Name = "Form1";
            Text = "Form1";
            tabpood.ResumeLayout(false);
            ResumeLayout(false);

            }
        #endregion
        private TabControl tabpood;
        private TabPage tabPage1;
        private TabPage tabPage2;
    }
}