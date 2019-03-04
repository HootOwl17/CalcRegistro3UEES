using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registro3UEES
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double R1 = Convert.ToDouble(txtRegistro1.Text);
            double R2 = Convert.ToDouble(txtRegistro2.Text);

            double D = 6 - ((R1 + R2)*0.3);
            double R3 = D / 0.4;

            if (R3>10)
            {
                MessageBox.Show("Ni con 10 la pasas :c");
            }
            else
            {
                txtRegistro3.Text = R3.ToString();
            }
            
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            txtRegistro1.Clear();
            txtRegistro2.Clear();
            txtRegistro3.Clear();
        }
    }
}
