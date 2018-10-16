using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 0)
            {
                double r1 = Convert.ToDouble(textBox1.Text);
                double r2 = Convert.ToDouble(textBox2.Text);
                double r3 = Convert.ToDouble(textBox3.Text);
                double r4 = Convert.ToDouble(textBox4.Text);
                double r5 = Convert.ToDouble(textBox5.Text);

            }
        }
    }
}
