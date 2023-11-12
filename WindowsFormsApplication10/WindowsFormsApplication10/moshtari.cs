using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication10
{
    public partial class moshtari : Form
    {

        public string stdname { get; set; }
        public moshtari()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            { 
            string name = textBox1.Text;
            string family = textBox2.Text;
            string tel = textBox3.Text;
            string lines = name + "," + family + "," + tel + "\n";
            File.WriteAllText("sampel.txt",lines);
              }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
