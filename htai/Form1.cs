using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace htai
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCong_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (tbSoA.Text != String.Empty)
=======
            if (tbSoA.Text != String.Empty && tbSoB.Text != String.Empty)
>>>>>>> feature-cal
            {
                double a = double.Parse(tbSoA.Text);
                double b = double.Parse(tbSoB.Text);
                double c = a + b;
                tbKQ.Text = c.ToString(); 
            }
        }

        private void tbTru_Click(object sender, EventArgs e)
        {
            double a = double.Parse(tbSoA.Text);
            double b = double.Parse(tbSoB.Text);
            double c = a - b;
            tbKQ.Text = c.ToString();
        }
    }
}
