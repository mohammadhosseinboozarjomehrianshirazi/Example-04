using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            moshtari form = new moshtari();
            form.stdname = textBox1.Text;
            form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            show sx = new show();
             sx.Show();
        }
    }
}
