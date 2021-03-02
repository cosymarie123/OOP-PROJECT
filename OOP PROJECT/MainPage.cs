using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_PROJECT
{
    public partial class MainPage : BasePage
    {
        
        public MainPage()
        {

            

            InitializeComponent();
            //Menu panels: location & size
            pnlOriginals.Location = new Point(110, pnlChristmas.Location.Y + pnlChristmas.Size.Height + 40); this.pnlOriginals.Size = new System.Drawing.Size(520, 520);
            pnlCombo.Location = new Point(pnlOriginals.Location.X + pnlOriginals.Size.Width + 20, pnlOriginals.Location.Y); this.pnlCombo.Size = new System.Drawing.Size(520, 250);
            pnlSpecialMenu.Location = new Point(pnlCombo.Location.X, pnlCombo.Location.Y + pnlCombo.Size.Height + 20); this.pnlSpecialMenu.Size = new System.Drawing.Size(520, 250);
            

            pnlSnacks.Location = new Point(pnlOriginals.Location.X, pnlOriginals.Location.Y+520+20); this.pnlSnacks.Size = new System.Drawing.Size(340, 340);
            pnlBurger.Location = new Point(pnlSnacks.Location.X+340+20, pnlSnacks.Location.Y); this.pnlBurger.Size = new System.Drawing.Size(340, 340);
            pnlChicken.Location = new Point(pnlBurger.Location.X+340+20, pnlSnacks.Location.Y); this.pnlChicken.Size = new System.Drawing.Size(340, 340);

            pnlSalads.Location = new Point(pnlSnacks.Location.X, pnlSnacks.Location.Y + 340 + 20); this.pnlSalads.Size = new System.Drawing.Size(340, 340);
            pnlDesserts.Location = new Point(pnlSalads.Location.X + 340 + 20, pnlSalads.Location.Y); this.pnlDesserts.Size = new System.Drawing.Size(340, 340);
            pnlDrinks.Location = new Point(pnlDesserts.Location.X + 340 + 20, pnlSalads.Location.Y); this.pnlDrinks.Size = new System.Drawing.Size(340, 340);

            pnlMexican.Location = new Point(pnlSalads.Location.X, pnlSalads.Location.Y + 340 + 20); pnlMexican.Size = new Size(520,340);
            pnlViet.Location = new Point(pnlMexican.Location.X + pnlMexican.Size.Width + 20, pnlMexican.Location.Y); pnlViet.Size = new Size(520, 340);
            
            
            //Adding the panels to the MainPage form
            this.Controls.Add(pnlOriginals);
            this.Controls.Add(pnlSnacks);
            this.Controls.Add(pnlBurger);
            this.Controls.Add(pnlChicken);
            this.Controls.Add(pnlSalads);
            this.Controls.Add(pnlDesserts);
            this.Controls.Add(pnlDrinks);
            this.Controls.Add(pnlMexican);
            this.Controls.Add(pnlViet);

            //Wrapper panel
            Panel wrapper = new Panel();
            wrapper.Location = new Point(pnlOriginals.Location.X - 40, pnlOriginals.Location.Y - 40);
            //t width = pnlCombo.Location.X + pnlCombo.Size.Width + 40 - wrapper.Location.X;
            int width = pnlChicken.Right - pnlSnacks.Left + 80;
            int height = pnlMexican.Location.Y + pnlMexican.Size.Height + 40 - wrapper.Location.Y + 50;
            wrapper.Size = new Size(width, height);
            wrapper.BackColor = Color.White;
            this.Controls.Add(wrapper);

            

            //set Cursor as the finger
            pnlChristmas.Cursor = pnlRedWednesday.Cursor =
            pnlOriginals.Cursor = pnlCombo.Cursor= pnlSpecialMenu.Cursor=
            pnlSnacks.Cursor = pnlBurger.Cursor = pnlChicken.Cursor =
            pnlSalads.Cursor = pnlDesserts.Cursor = pnlDrinks.Cursor =
            pnlMexican.Cursor = pnlViet.Cursor =
            Cursors.Hand;
            
            

            //Update the Order listview
            for (int i = 0; i < Program.order.list.Count; i++)
            {
                string[] arr = new string[3];
                //    add items to ListView
                arr[0] = Program.order.list[i].Name;
                arr[1] = Program.order.items[i].ToString();
                arr[2] = (Program.order.list[i].Price * Program.order.items[i]).ToString();
                ListViewItem itm = new ListViewItem(arr);
                lst_total.Items.Add(itm);
            }

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void pnlBurger_Click(object sender, EventArgs e)
        {
            Burger menu = new Burger();
            menu.Show();
            this.Hide();
        }

        private void pnlSnacks_Click(object sender, EventArgs e)
        {
            Snacks menu = new Snacks();
            menu.Show();
            this.Hide();
        }

        private void pnlChicken_Click(object sender, EventArgs e)
        {
            Chicken menu = new Chicken();
            menu.Show();
            this.Hide();
        }

        private void pnlSalads_Click(object sender, EventArgs e)
        {
            Salads menu = new Salads();
            menu.Show();
            this.Hide();
        }

        private void pnlDesserts_Click(object sender, EventArgs e)
        {
            Desserts menu = new Desserts();
            menu.Show();
            this.Hide();
        }

        private void pnlDrinks_Click(object sender, EventArgs e)
        {
            Drinks menu = new Drinks();
            menu.Show();
            this.Hide();
        }

        private void pnlMexican_Click(object sender, EventArgs e)
        {
            Mexican menu = new Mexican();
            menu.Show();
            this.Hide();
        }

        private void pnlViet_Click(object sender, EventArgs e)
        {
            Viet menu = new Viet();
            menu.Show();
            this.Hide();
        }
        

        private void pnlOriginals_Click(object sender, EventArgs e)
        {
            Originals o = new Originals();
            o.Show();
        }

        private void panel2_Click(object sender, EventArgs e)
        {

        }

        private void pnlCombo_Click(object sender, EventArgs e)
        {
            Combo m = new Combo();
            m.Show();
        }

        private void pnlSpecialMenu_Click(object sender, EventArgs e)
        {
            Specials s = new Specials();
            s.Show();
        }
    }
}
