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
    public partial class LearnMore : Form
    {
        public LearnMore(Dish d)
        {
            InitializeComponent();
            this.Text = d.Name;

            image.Image = d.Image;
            lbName.Text = d.Name;
            txtDescription.Text = d.Description;
            lbPrice.Text = "Price: " + d.Price.ToString() + " VND";
            int min = d.Preptime;
            lbPrepTime.Text = "Preparation time: "+(min / 60).ToString() + "h" + (min % 60).ToString() + "m";
            string str="";
            for (int i = 0; i < d.Allergens.Length - 1; i++)
                str += d.Allergens[i]+", ";
            str += d.Allergens[d.Allergens.Length - 1];
            lbAllergens.Text = "Allergens: "+str;
            lbCalories.Text = "Calories: " + d.Calories.ToString() + "cal";
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void image_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LearnMore_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
