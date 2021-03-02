namespace OOP_PROJECT
{
    partial class CheckOut
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lst_Check = new System.Windows.Forms.ListView();
            this.btnTotal = new System.Windows.Forms.Button();
            this.Dish = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Items = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbItems = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lst_Check
            // 
            this.lst_Check.BackColor = System.Drawing.Color.White;
            this.lst_Check.CheckBoxes = true;
            this.lst_Check.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Dish,
            this.Items,
            this.Price});
            this.lst_Check.FullRowSelect = true;
            this.lst_Check.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lst_Check.Location = new System.Drawing.Point(328, 135);
            this.lst_Check.MultiSelect = false;
            this.lst_Check.Name = "lst_Check";
            this.lst_Check.Size = new System.Drawing.Size(500, 317);
            this.lst_Check.TabIndex = 6;
            this.lst_Check.UseCompatibleStateImageBehavior = false;
            this.lst_Check.View = System.Windows.Forms.View.Details;
            this.lst_Check.SelectedIndexChanged += new System.EventHandler(this.lst_Check_SelectedIndexChanged);
            // 
            // btnTotal
            // 
            this.btnTotal.BackColor = System.Drawing.Color.Green;
            this.btnTotal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTotal.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotal.ForeColor = System.Drawing.Color.White;
            this.btnTotal.Location = new System.Drawing.Point(3, 3);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(263, 36);
            this.btnTotal.TabIndex = 7;
            this.btnTotal.Text = "TOTAL";
            this.toolTip1.SetToolTip(this.btnTotal, "Update your current total");
            this.btnTotal.UseVisualStyleBackColor = false;
            this.btnTotal.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // Dish
            // 
            this.Dish.Text = "Dish";
            this.Dish.Width = 263;
            // 
            // Items
            // 
            this.Items.Text = "Items";
            this.Items.Width = 56;
            // 
            // Price
            // 
            this.Price.Text = "Price";
            this.Price.Width = 134;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.01219F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.9878F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 171F));
            this.tableLayoutPanel1.Controls.Add(this.btnTotal, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbItems, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbTotal, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(328, 468);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(500, 42);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // lbItems
            // 
            this.lbItems.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbItems.AutoSize = true;
            this.lbItems.Location = new System.Drawing.Point(298, 11);
            this.lbItems.Name = "lbItems";
            this.lbItems.Size = new System.Drawing.Size(0, 20);
            this.lbItems.TabIndex = 8;
            // 
            // lbTotal
            // 
            this.lbTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbTotal.AutoSize = true;
            this.lbTotal.Location = new System.Drawing.Point(414, 11);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(0, 20);
            this.lbTotal.TabIndex = 9;
            // 
            // CheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 661);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lst_Check);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "CheckOut";
            this.Text = "CheckOut";
            this.Controls.SetChildIndex(this.lst_Check, 0);
            this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lst_Check;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.ColumnHeader Items;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbItems;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ColumnHeader Dish;
    }
}