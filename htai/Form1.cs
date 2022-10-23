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
            int a = int.Parse(tbSoA.Text);
            int b = int.Parse(tbSoB.Text);
            Calculation cal = new Calculation(a, b);
            tbKQ.Text = cal.Execute("+").ToString();
        }

        private void tbTru_Click(object sender, EventArgs e)
        {
            int a = int.Parse(tbSoA.Text);
            int b = int.Parse(tbSoB.Text);
            Calculation cal = new Calculation(a, b);
            tbKQ.Text = cal.Execute("-").ToString();
        }

        private void btNhan_Click(object sender, EventArgs e)
        {
            int a = int.Parse(tbSoA.Text);
            int b = int.Parse(tbSoB.Text);
            Calculation cal = new Calculation(a, b);
            tbKQ.Text = cal.Execute("*").ToString();
        }

        private void btChia_Click(object sender, EventArgs e)
        {
            int a = int.Parse(tbSoA.Text);
            int b = int.Parse(tbSoB.Text);
            Calculation cal = new Calculation(a, b);
            tbKQ.Text = cal.Execute("/").ToString();
        }
    }
}
