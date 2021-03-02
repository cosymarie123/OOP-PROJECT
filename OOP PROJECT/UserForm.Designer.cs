namespace OOP_PROJECT
{
    partial class UserForm
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
            this.btnSignUp = new System.Windows.Forms.Button();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.btnBasePage = new System.Windows.Forms.Button();
            this.btnMainPage = new System.Windows.Forms.Button();
            this.mnBurger = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSignUp
            // 
            this.btnSignUp.Location = new System.Drawing.Point(0, 0);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(75, 23);
            this.btnSignUp.TabIndex = 0;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // btnSignIn
            // 
            this.btnSignIn.Location = new System.Drawing.Point(81, 0);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(75, 23);
            this.btnSignIn.TabIndex = 1;
            this.btnSignIn.Text = "Sign In";
            this.btnSignIn.UseVisualStyleBackColor = true;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // btnBasePage
            // 
            this.btnBasePage.Location = new System.Drawing.Point(162, 0);
            this.btnBasePage.Name = "btnBasePage";
            this.btnBasePage.Size = new System.Drawing.Size(75, 23);
            this.btnBasePage.TabIndex = 2;
            this.btnBasePage.Text = "BasePage";
            this.btnBasePage.UseVisualStyleBackColor = true;
            this.btnBasePage.Click += new System.EventHandler(this.btnBasePage_Click);
            // 
            // btnMainPage
            // 
            this.btnMainPage.Location = new System.Drawing.Point(0, 30);
            this.btnMainPage.Name = "btnMainPage";
            this.btnMainPage.Size = new System.Drawing.Size(75, 23);
            this.btnMainPage.TabIndex = 3;
            this.btnMainPage.Text = "Main Page";
            this.btnMainPage.UseVisualStyleBackColor = true;
            this.btnMainPage.Click += new System.EventHandler(this.btnMainPage_Click);
            // 
            // mnBurger
            // 
            this.mnBurger.Location = new System.Drawing.Point(81, 29);
            this.mnBurger.Name = "mnBurger";
            this.mnBurger.Size = new System.Drawing.Size(75, 23);
            this.mnBurger.TabIndex = 4;
            this.mnBurger.Text = "Burger";
            this.mnBurger.UseVisualStyleBackColor = true;
            this.mnBurger.Click += new System.EventHandler(this.mnBurger_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 133);
            this.Controls.Add(this.mnBurger);
            this.Controls.Add(this.btnMainPage);
            this.Controls.Add(this.btnBasePage);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.btnSignUp);
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.Button btnBasePage;
        private System.Windows.Forms.Button btnMainPage;
        private System.Windows.Forms.Button mnBurger;
    }
}