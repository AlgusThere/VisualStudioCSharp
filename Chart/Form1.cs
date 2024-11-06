using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chart1.Series["Film"].Points.AddXY("The Northman", 9);
            chart1.Series["Film"].Points.AddXY("Mad Max", 9.5);
            chart1.Series["Film"].Points.AddXY("Interstellar", 10);
        }
    }
}
