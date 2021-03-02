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
    public partial class BaseForm : Form
    {
        
        public BaseForm()
        {
            InitializeComponent();
            this.Size = new Size(1300, 700);
            this.Font = new Font("Rockwell", 13, FontStyle.Regular);
            
            
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }   
    }
}
