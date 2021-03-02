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
    public partial class FormFormatting : Form
    {
        public FormFormatting()
        {
            InitializeComponent();
            this.Size = new Size(1300, 700);
            this.Font = new Font("Rockwell", 13, FontStyle.Regular);
            this.CenterToScreen();
        }
    }
}
