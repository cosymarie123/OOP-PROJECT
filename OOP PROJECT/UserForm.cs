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
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SignUp signup = new SignUp();
            signup.Show();
            this.Hide();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            SignIn signin = new SignIn();
            signin.Show();
            this.Hide();
        }

        private void btnBasePage_Click(object sender, EventArgs e)
        {
            BasePage basepage = new BasePage();
            basepage.Show();
            this.Hide();
        }

        private void btnMainPage_Click(object sender, EventArgs e)
        {
            MainPage mainpage = new MainPage();
            mainpage.Show();
            this.Hide();
        }

        private void mnBurger_Click(object sender, EventArgs e)
        {
            Burger b = new Burger();
            b.Show();
            this.Hide();
        }
    }
}
