using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOP_PROJECT.Properties;

namespace OOP_PROJECT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string str = "beach";
            //pictureBox1.Image=(Image) Resources.ResourceManager.GetObject("ImageName");

            panel1.BackgroundImage = (Image)Resources.ResourceManager.GetObject(str);

            textBox1.Text = "McFlurry® with OREO® Cookies";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            this.Hide();
            f2.Show();
            

            int[] arr = new int[] { 1, 2, 3, 4, 5, 6 };
            int y_initial = 0;
            int k = 0, x=100, y = y_initial;
            
            for (int i = 1; i <= arr.Length/2; i++)
            {
                for (int j = 1; j <= 2 && k < arr.Length; j++) 
                {
                    TextBox txtbox = new TextBox();
                   if (j % 2 != 0)
                    {
                        x = 0;
                        y = y_initial;
                        txtbox.Text = arr[k++].ToString();
                        txtbox.Location = new Point(x, y);
                        x += 200;
                        //y unchanged;
                    }
                    if (j%2==0)
                    {
                        txtbox.Text = arr[k++].ToString();
                        txtbox.Location = new Point(x, y);
                        x +=100;
                        //y += 100;
                    }
                    txtbox.TextAlign = HorizontalAlignment.Center;
                    f2.Controls.Add(txtbox);
                }
                y_initial += 100;
            }

            //#region
            //{
            //    TextBox txtbox = new TextBox();

            //    if (i % 2 != 0)
            //    {
            //        txtbox.Text = i.ToString();
            //        txtbox.Location = new Point(x, y);
            //        x += 100;
            //        y += 100;
            //    }
            //    else
            //    {
            //        txtbox.Text = i.ToString();
            //        txtbox.Location = new Point(x, y);
            //        y += 100;
            //        x = 0;
            //    }
            //    f2.Controls.Add(txtbox);
            //}
            //#endregion

            TextBox tb = new TextBox();
            var lines = tb.Lines.Count();

            PictureBox picturebox1= new PictureBox();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image =  Resources.beach;
            //picturebox1.Image =  Image.FromFile("C:/Users/sony/source/repos/OOP PROJECT/Images for OOP/beach.jpg");
           this.Controls.Add(picturebox1);
            //pictureBox1.Parent = this;
            pictureBox1.Show();


        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dish h = new Dish();
            Panel panelbig = new Panel();
            panelbig.Size = new Size(400, 400);
            panelbig.BackColor = Color.Brown;

            Panel panelsmall = new Panel();
            panelsmall.Size = new Size(100, 100);
            panelsmall.Location = new Point(10, 10);

            //panelsmall.BackgroundImage = Image.FromFile(h.lstDish[1].Image);


            panelbig.Controls.Add(panelsmall);
            this.Controls.Add(panelbig);
            textBox2.Text= h.lstDish[1].Name;
        }
    }
}
