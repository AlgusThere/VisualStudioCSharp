using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Captcha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] harf = { "a", "b", "c", "d", "e", "f", "g" };
            string[] sembol = { "+", "-", "*", "/", "#" };

            Random rand = new Random();
            int s1, s2, s3;
            s1 = rand.Next(0 , harf.Length);
            s2 = rand.Next(0 , sembol.Length);
            s3 = rand.Next(0,10);

            label1.Text = harf[s1].ToString() + sembol[s2].ToString() + s3.ToString();
        }
    }
}
