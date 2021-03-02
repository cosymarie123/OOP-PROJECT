namespace OOP_PROJECT
{
    partial class BasePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BasePage));
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CheckOut = new System.Windows.Forms.Button();
            this.lbCustomize = new System.Windows.Forms.Label();
            this.lbGuide = new System.Windows.Forms.Label();
            this.lbLocations = new System.Windows.Forms.Label();
            this.MainPage = new System.Windows.Forms.Label();
            this.lbSearch = new System.Windows.Forms.Label();
            this.lbWelcome = new System.Windows.Forms.Label();
            this.lbMotto = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlCO = new System.Windows.Forms.Panel();
            this.lst_total = new System.Windows.Forms.ListView();
            this.Dish = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Items = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnCheckPlease = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlCO.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(96)))), ((int)(((byte)(85)))));
            this.pnlHeader.Controls.Add(this.pictureBox1);
            this.pnlHeader.Controls.Add(this.CheckOut);
            this.pnlHeader.Controls.Add(this.lbCustomize);
            this.pnlHeader.Controls.Add(this.lbGuide);
            this.pnlHeader.Controls.Add(this.lbLocations);
            this.pnlHeader.Controls.Add(this.MainPage);
            this.pnlHeader.Controls.Add(this.lbSearch);
            this.pnlHeader.Controls.Add(this.lbWelcome);
            this.pnlHeader.ForeColor = System.Drawing.Color.White;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1265, 120);
            this.pnlHeader.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OOP_PROJECT.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // CheckOut
            // 
            this.CheckOut.BackColor = System.Drawing.Color.White;
            this.CheckOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheckOut.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.CheckOut.FlatAppearance.BorderSize = 0;
            this.CheckOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckOut.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckOut.ForeColor = System.Drawing.Color.Green;
            this.CheckOut.Location = new System.Drawing.Point(1125, 65);
            this.CheckOut.Name = "CheckOut";
            this.CheckOut.Size = new System.Drawing.Size(125, 46);
            this.CheckOut.TabIndex = 1;
            this.CheckOut.Text = "CHECK-OUT";
            this.CheckOut.UseVisualStyleBackColor = false;
            this.CheckOut.Click += new System.EventHandler(this.CheckOut_Click);
            // 
            // lbCustomize
            // 
            this.lbCustomize.AutoSize = true;
            this.lbCustomize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbCustomize.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCustomize.Location = new System.Drawing.Point(974, 78);
            this.lbCustomize.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCustomize.Name = "lbCustomize";
            this.lbCustomize.Size = new System.Drawing.Size(100, 19);
            this.lbCustomize.TabIndex = 1;
            this.lbCustomize.Text = "CUSTOMIZE";
            // 
            // lbGuide
            // 
            this.lbGuide.AutoSize = true;
            this.lbGuide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbGuide.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGuide.Location = new System.Drawing.Point(851, 78);
            this.lbGuide.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbGuide.Name = "lbGuide";
            this.lbGuide.Size = new System.Drawing.Size(59, 19);
            this.lbGuide.TabIndex = 1;
            this.lbGuide.Text = "GUIDE";
            // 
            // lbLocations
            // 
            this.lbLocations.AutoSize = true;
            this.lbLocations.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbLocations.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLocations.Location = new System.Drawing.Point(674, 78);
            this.lbLocations.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbLocations.Name = "lbLocations";
            this.lbLocations.Size = new System.Drawing.Size(104, 19);
            this.lbLocations.TabIndex = 1;
            this.lbLocations.Text = "LOCATIONS";
            // 
            // MainPage
            // 
            this.MainPage.AutoSize = true;
            this.MainPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MainPage.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainPage.Location = new System.Drawing.Point(339, 78);
            this.MainPage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MainPage.Name = "MainPage";
            this.MainPage.Size = new System.Drawing.Size(106, 19);
            this.MainPage.TabIndex = 1;
            this.MainPage.Text = "MAIN PAGE";
            this.MainPage.Click += new System.EventHandler(this.MainPage_Click);
            // 
            // lbSearch
            // 
            this.lbSearch.AutoSize = true;
            this.lbSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbSearch.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSearch.Location = new System.Drawing.Point(511, 78);
            this.lbSearch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(75, 19);
            this.lbSearch.TabIndex = 1;
            this.lbSearch.Text = "SEARCH";
            // 
            // lbWelcome
            // 
            this.lbWelcome.AutoSize = true;
            this.lbWelcome.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWelcome.Location = new System.Drawing.Point(123, 3);
            this.lbWelcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbWelcome.Name = "lbWelcome";
            this.lbWelcome.Size = new System.Drawing.Size(155, 108);
            this.lbWelcome.TabIndex = 0;
            this.lbWelcome.Text = "The\r\nChopping\r\nBites";
            this.lbWelcome.Click += new System.EventHandler(this.lbWelcome_Click);
            // 
            // lbMotto
            // 
            this.lbMotto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbMotto.AutoSize = true;
            this.lbMotto.ForeColor = System.Drawing.Color.White;
            this.lbMotto.Location = new System.Drawing.Point(47, 11);
            this.lbMotto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMotto.Name = "lbMotto";
            this.lbMotto.Size = new System.Drawing.Size(187, 20);
            this.lbMotto.TabIndex = 0;
            this.lbMotto.Text = "© Quality is our recipe";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.panel1.Controls.Add(this.lbMotto);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 623);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1284, 38);
            this.panel1.TabIndex = 2;
            this.panel1.Visible = false;
            // 
            // pnlCO
            // 
            this.pnlCO.BackColor = System.Drawing.Color.White;
            this.pnlCO.Controls.Add(this.lst_total);
            this.pnlCO.Controls.Add(this.btnCheckPlease);
            this.pnlCO.Controls.Add(this.btnClose);
            this.pnlCO.Location = new System.Drawing.Point(870, 110);
            this.pnlCO.Name = "pnlCO";
            this.pnlCO.Size = new System.Drawing.Size(380, 380);
            this.pnlCO.TabIndex = 0;
            // 
            // lst_total
            // 
            this.lst_total.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Dish,
            this.Items,
            this.Price});
            this.lst_total.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_total.Location = new System.Drawing.Point(14, 14);
            this.lst_total.Name = "lst_total";
            this.lst_total.Size = new System.Drawing.Size(349, 305);
            this.lst_total.TabIndex = 0;
            this.lst_total.UseCompatibleStateImageBehavior = false;
            this.lst_total.View = System.Windows.Forms.View.Details;
            // 
            // Dish
            // 
            this.Dish.Text = "Dish";
            this.Dish.Width = 205;
            // 
            // Items
            // 
            this.Items.Text = "Items";
            this.Items.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Items.Width = 58;
            // 
            // Price
            // 
            this.Price.Text = "Price";
            this.Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Price.Width = 82;
            // 
            // btnCheckPlease
            // 
            this.btnCheckPlease.BackColor = System.Drawing.Color.Green;
            this.btnCheckPlease.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckPlease.Font = new System.Drawing.Font("Rockwell", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckPlease.ForeColor = System.Drawing.Color.White;
            this.btnCheckPlease.Location = new System.Drawing.Point(14, 325);
            this.btnCheckPlease.Name = "btnCheckPlease";
            this.btnCheckPlease.Size = new System.Drawing.Size(148, 33);
            this.btnCheckPlease.TabIndex = 1;
            this.btnCheckPlease.Text = "Check Please!";
            this.btnCheckPlease.UseVisualStyleBackColor = false;
            this.btnCheckPlease.Click += new System.EventHandler(this.btnCheckPlease_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Green;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(288, 325);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 33);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "CLOSE";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // BasePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1284, 661);
            this.Controls.Add(this.pnlCO);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Rockwell", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(100, 0);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "BasePage";
            this.Text = "BasePage";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlCO.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lbCustomize;
        private System.Windows.Forms.Label lbGuide;
        private System.Windows.Forms.Label lbLocations;
        private System.Windows.Forms.Label lbSearch;
        private System.Windows.Forms.Label lbWelcome;
        private System.Windows.Forms.Label lbMotto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label MainPage;
        private System.Windows.Forms.Button CheckOut;
        private System.Windows.Forms.Panel pnlCO;
        private System.Windows.Forms.Button btnClose;
        public System.Windows.Forms.ListView lst_total;
        private System.Windows.Forms.Button btnCheckPlease;
        private System.Windows.Forms.ColumnHeader Dish;
        private System.Windows.Forms.ColumnHeader Items;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}