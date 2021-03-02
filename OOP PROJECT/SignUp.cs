using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace OOP_PROJECT
{
    public partial class SignUp : FormFormatting
    {
        public SignUp()
        {
            InitializeComponent();
            this.Font = new Font("Rockwell", 13, FontStyle.Regular);
            btnSignUp.Font = new Font("Rockwell", 18, FontStyle.Regular);

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
            b1.Add(Properties.Resources.clear_shopping_cart);
            int index = DateTime.Now.Second % b1.Count;
            this.BackgroundImage = b1[index];
        }

        

        private void borderlessButton1_Click(object sender, EventArgs e)
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

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            CreateNewAccount();

            
            MainPage mainpage = new MainPage();
            mainpage.Show();
            this.Hide();
            
        }

        private Person CreateNewAccount()
        {
            string email = placehdrtxtEmail.Text;
            string password = placehdrtxtEmail.Text;
            string name = placehdrtxtName.Text;
            string birthdate = txtDay.Text + " " + txtMonth.Text + " " + txtYear.Text;
            
            string accountinfo = email + "\t" + password + "\t" + name + "\t" + birthdate + "\r\n";
            File.AppendAllText("C:/Users/sony/source/repos/OOP PROJECT/RefTextFiles/accounts.TXT", accountinfo);

            Person person = new Person(email, password, name,
                int.Parse(txtDay.Text), txtMonth.Text, int.Parse(txtYear.Text));

            
            return person;
            
        }
    }
}
