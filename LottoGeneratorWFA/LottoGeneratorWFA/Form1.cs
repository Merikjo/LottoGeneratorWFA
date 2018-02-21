using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LottoGeneratorWFA
{
  
    public partial class Form1 : Form
    {

        static Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void lottobtn_Click(object sender, EventArgs e)
        {
            int a = rand.Next(1, 40);
            int b = rand.Next(1, 40);
            int c = rand.Next(1, 40);
            int d = rand.Next(1, 40);
            int f = rand.Next(1, 40);
            int g = rand.Next(1, 40);
            int h = rand.Next(1, 40);

            num1.Text = a.ToString();
            num2.Text = b.ToString();
            num3.Text = c.ToString();
            num4.Text = d.ToString();
            num5.Text = f.ToString();
            num6.Text = g.ToString();
            num7.Text = h.ToString(); 
        }
    }
}
