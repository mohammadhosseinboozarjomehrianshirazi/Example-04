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
    public partial class show : Form
    {
        
        public show()
        {
            InitializeComponent();
        }

        private void show_Load(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines("sampel.txt");
            for (int i = 0; i < lines.Length; i++) 
            {
                listBox1.Items.Add(lines[i]);
            }
        }
    }
}
