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
    public partial class GuideForm : BasePage
    {
        int PW;
        bool Guide;
        public GuideForm()
        {
            InitializeComponent();
            PW = Spanel.Height;
            Guide = false;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnGuide_Click(object sender, EventArgs e)
        {
            if (Guide) btnGuide.Text = "G\nU\nI\nD\nE";
            else btnGuide.Text = "G\nU\nI\nD\nE\nD";
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(Guide)
            {
                Spanel.Height = Spanel.Height + 20;
                if(Spanel.Height >= PW)
                {
                    timer1.Stop();
                    Guide = false;
                    this.Refresh();
                }
            }
            else
            {
                Spanel.Height = Spanel.Height - 20;
                if(Spanel.Height <= 0)
                {
                    timer1.Stop();
                    Guide = true;
                    this.Refresh();
                }
            }
        }
    }
}
