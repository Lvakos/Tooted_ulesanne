using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tooted
{
    public partial class Peavorm : Form
    {
        public Peavorm()
        {
            InitializeComponent();
        }
        private void btnTooted_Click(object sender, EventArgs e)
        {
            tooted f = new tooted();
            f.ShowDialog();
        }

        private void btnPood_Click(object sender, EventArgs e)
        {
            Form1 poodForm = new Form1();
            poodForm.ShowDialog();
        }

        private void btnArve_Click(object sender, EventArgs e)
        {
            ArveForm arve = new ArveForm();
            arve.ShowDialog();
        }
    }
}
