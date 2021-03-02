namespace OOP_PROJECT
{
    partial class LearnMore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LearnMore));
            this.image = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbName = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbPrepTime = new System.Windows.Forms.Label();
            this.lbAllergens = new System.Windows.Forms.Label();
            this.lbCalories = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // image
            // 
            this.image.Dock = System.Windows.Forms.DockStyle.Left;
            this.image.Location = new System.Drawing.Point(0, 0);
            this.image.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(300, 300);
            this.image.TabIndex = 0;
            this.image.TabStop = false;
            this.toolTip1.SetToolTip(this.image, "Double-click to close");
            this.image.DoubleClick += new System.EventHandler(this.image_DoubleClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lbName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtDescription, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(300, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.85101F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 59.14899F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(400, 146);
            this.tableLayoutPanel1.TabIndex = 1;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(96)))), ((int)(((byte)(85)))));
            this.lbName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbName.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.White;
            this.lbName.Location = new System.Drawing.Point(3, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(394, 59);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "label1";
            this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.White;
            this.txtDescription.CausesValidation = false;
            this.txtDescription.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDescription.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtDescription.ForeColor = System.Drawing.Color.Green;
            this.txtDescription.HideSelection = false;
            this.txtDescription.Location = new System.Drawing.Point(3, 62);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(394, 81);
            this.txtDescription.TabIndex = 1;
            this.txtDescription.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.lbPrice, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbPrepTime, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbAllergens, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lbCalories, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(300, 146);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(400, 154);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.BackColor = System.Drawing.Color.White;
            this.lbPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbPrice.Location = new System.Drawing.Point(9, 3);
            this.lbPrice.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(183, 72);
            this.lbPrice.TabIndex = 0;
            this.lbPrice.Text = "label2";
            this.lbPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbPrepTime
            // 
            this.lbPrepTime.AutoSize = true;
            this.lbPrepTime.BackColor = System.Drawing.Color.Khaki;
            this.lbPrepTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbPrepTime.Location = new System.Drawing.Point(207, 3);
            this.lbPrepTime.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbPrepTime.Name = "lbPrepTime";
            this.lbPrepTime.Size = new System.Drawing.Size(184, 72);
            this.lbPrepTime.TabIndex = 1;
            this.lbPrepTime.Text = "label3";
            this.lbPrepTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbAllergens
            // 
            this.lbAllergens.AutoSize = true;
            this.lbAllergens.BackColor = System.Drawing.Color.Khaki;
            this.lbAllergens.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbAllergens.Location = new System.Drawing.Point(9, 78);
            this.lbAllergens.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbAllergens.Name = "lbAllergens";
            this.lbAllergens.Size = new System.Drawing.Size(183, 73);
            this.lbAllergens.TabIndex = 2;
            this.lbAllergens.Text = "label4";
            this.lbAllergens.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbCalories
            // 
            this.lbCalories.AutoSize = true;
            this.lbCalories.BackColor = System.Drawing.Color.White;
            this.lbCalories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbCalories.Location = new System.Drawing.Point(207, 78);
            this.lbCalories.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbCalories.Name = "lbCalories";
            this.lbCalories.Size = new System.Drawing.Size(184, 73);
            this.lbCalories.TabIndex = 3;
            this.lbCalories.Text = "label5";
            this.lbCalories.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LearnMore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(700, 300);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.image);
            this.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "LearnMore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LearnMore";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LearnMore_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox image;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbPrepTime;
        private System.Windows.Forms.Label lbAllergens;
        private System.Windows.Forms.Label lbCalories;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox txtDescription;
    }
}