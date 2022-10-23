using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCong_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtA.Text);
            int b = int.Parse(txtB.Text);
            Calculation cal = new Calculator.Calculation(a, b);
            txtKetQua.Text = cal.Execute("+").ToString();
            //if (txtA.Text != String.Empty)
            //{
            //    double a = double.Parse(txtA.Text);
            //    double b = double.Parse(txtB.Text);
            //    double c = a + b;
            //    txtKetQua.Text = c.ToString();
            //}
        }

        private void buttonTru_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtA.Text);
            double b = double.Parse(txtB.Text);
            double c = a - b;
            txtKetQua.Text = c.ToString();
        }
    }

    }

