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
    public partial class CheckOut : BasePage
    {
        NumericUpDown nud = new NumericUpDown();
        private bool added = false;
        private int i, id;
        public CheckOut()
        {
            InitializeComponent();

            ////
            //Dish d1 = new Dish("A",10);
            //Dish d2 = new Dish("B",20);
            //Dish d3 = new Dish("C", 15);
            //Program.order.list.Add(d1);
            //Program.order.list.Add(d2);
            //Program.order.list.Add(d3);

            //Program.order.items.Add(3);
            //Program.order.items.Add(1);
            //Program.order.items.Add(2);
            ////

            #region setting up the lst_Check
            for (int i = 0; i < Program.order.list.Count; i++)
            {
                string[] arr = new string[3];
                arr[0] = Program.order.list[i].Name;
                arr[1] = Program.order.items[i].ToString();
                arr[2] = (Program.order.list[i].Price * Program.order.items[i]).ToString();
                ListViewItem lvi = new ListViewItem(arr);
                lst_Check.Items.Add(lvi);
                lst_Check.Items[i].Checked = true;
                if (i % 2 == 0)
                    lst_Check.Items[i].BackColor = Color.FromArgb(192, 255, 192);
            }

            #endregion
            //

            ResetCheckTotal();

        }
        private void ResetCheckTotal()
        {
            int total = 0;
            int it = 0;
            foreach (ListViewItem item in lst_Check.CheckedItems)
            {
                it += int.Parse(item.SubItems[1].Text);
                total += int.Parse(item.SubItems[2].Text)* int.Parse(item.SubItems[1].Text);
                
            }
            lbTotal.Text = total.ToString() + " VND";
            lbItems.Text = it.ToString();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ResetCheckTotal();
        }

        private void lst_Check_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lst_Check.SelectedItems.Count!=0)
            {
                if (added)
                {
                    foreach (Control d in this.Controls)
                    {
                        if (d is NumericUpDown)
                        {
                            this.Controls.Remove(d);
                            var allNumUD = this.Controls.OfType<NumericUpDown>();
                        }    
                    }
                    added = true;
                }

                i = lst_Check.SelectedItems[0].Index;
                id = i + 1;
                Point pos = new Point(lst_Check.Location.X, lst_Check.Location.Y);

                //NumericUpDown nud = new NumericUpDown();
                nud.ForeColor = Color.Green;
                //nud.TextAlign = HorizontalAlignment.Center;
                nud.Size = new Size(46, 28);
                
                toolTip1.SetToolTip(nud, "Enter number of items.\r\nEnter to update items");

                added = true;
                this.Controls.Add(nud);
                nud.Text = lst_Check.SelectedItems[0].SubItems[1].Text;
                //nud.Location = new Point(pos.X + lst_Check.Width + 20, pos.Y + id * 25);
                nud.Location = new Point(pos.X + lst_Check.Columns[0].Width +5
                    , pos.Y + id * 25);
                nud.Leave += (s, a) =>
                {
                    UpdateOrder();
                    this.Controls.Remove(nud);
                    added = false;
                };
                nud.KeyDown += (se, r) =>
                {
                    if (r.KeyCode == Keys.Enter)
                    {
                        UpdateOrder();
                        this.Controls.Remove(nud);
                        added = false;
                    }
                };
                nud.BringToFront();

            }
        }

        private void UpdateOrder()
        {
            int value = (int)nud.Value;
            Program.order.items[i] = value;
            lst_Check.SelectedItems[0].SubItems[1].Text = value.ToString();
            lst_Check.SelectedItems[0].SubItems[2].Text = (Program.order.list[i].Price * value).ToString();
        }
    }
}
        