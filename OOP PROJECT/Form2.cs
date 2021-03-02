using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_PROJECT
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }
        Form1 f1 = new Form1();
        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            f1.Show();
            f1.textBox1.Text = "Back again!";
        }
    }
}
