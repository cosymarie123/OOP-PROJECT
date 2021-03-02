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
    public partial class SignIn : FormFormatting
    {
        public SignIn()
        {
            InitializeComponent();
            this.Font = new Font("Rockwell", 13, FontStyle.Regular);
            placehdrtxtPassword.UseSystemPasswordChar = true;

            this.BackgroundImage = Properties.Resources.beach;
            Timer tm = new Timer();
            tm.Interval = 5000;
            tm.Tick += new EventHandler(changeImage);
            tm.Start();
        }
        private void changeImage(object sender, EventArgs e)
        {
            List<Bitmap> b1 = new List<Bitmap>();
            b1.Add(Properties.Resources.beach);
            int index = DateTime.Now.Second % b1.Count;
            this.BackgroundImage = b1[index];
        }

        private void btnPasswordHideShow_Click(object sender, EventArgs e)
        {
            placehdrtxtPassword.UseSystemPasswordChar = !placehdrtxtPassword.UseSystemPasswordChar;
            bool val = placehdrtxtPassword.UseSystemPasswordChar;
            if (!val)
            {
                placehdrtxtPassword.PasswordChar = '*';
                btnPasswordHideShow.BackgroundImage = Properties.Resources.eye;
            }
            else
            {
                placehdrtxtPassword.PasswordChar = new char();
                btnPasswordHideShow.BackgroundImage = Properties.Resources.hide;
            }
        }

        private void btnSignUpNow_Click(object sender, EventArgs e)
        {
            SignUp signup = new SignUp();
            this.Hide();
            signup.Show();
        }
    }
}
