namespace OOP_PROJECT
{
    partial class SignIn
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
            this.placehdrtxtEmail = new OOP_PROJECT.PlaceHolderTextBox();
            this.placehdrtxtPassword = new OOP_PROJECT.PlaceHolderTextBox();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSignUpNow = new System.Windows.Forms.Button();
            this.btnPasswordHideShow = new OOP_PROJECT.BorderlessButton();
            this.SuspendLayout();
            // 
            // placehdrtxtEmail
            // 
            this.placehdrtxtEmail.Font = new System.Drawing.Font("Rockwell", 12F);
            this.placehdrtxtEmail.ForeColor = System.Drawing.Color.Gray;
            this.placehdrtxtEmail.Location = new System.Drawing.Point(526, 233);
            this.placehdrtxtEmail.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.placehdrtxtEmail.Multiline = true;
            this.placehdrtxtEmail.Name = "placehdrtxtEmail";
            this.placehdrtxtEmail.PlaceHolderText = "Email";
            this.placehdrtxtEmail.Size = new System.Drawing.Size(232, 42);
            this.placehdrtxtEmail.TabIndex = 2;
            this.placehdrtxtEmail.Text = "Email";
            // 
            // placehdrtxtPassword
            // 
            this.placehdrtxtPassword.Font = new System.Drawing.Font("Rockwell", 12F);
            this.placehdrtxtPassword.ForeColor = System.Drawing.Color.Gray;
            this.placehdrtxtPassword.Location = new System.Drawing.Point(526, 274);
            this.placehdrtxtPassword.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.placehdrtxtPassword.Multiline = true;
            this.placehdrtxtPassword.Name = "placehdrtxtPassword";
            this.placehdrtxtPassword.PlaceHolderText = "Password";
            this.placehdrtxtPassword.Size = new System.Drawing.Size(232, 42);
            this.placehdrtxtPassword.TabIndex = 2;
            this.placehdrtxtPassword.Text = "Password";
            // 
            // btnSignIn
            // 
            this.btnSignIn.BackColor = System.Drawing.Color.White;
            this.btnSignIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignIn.FlatAppearance.BorderSize = 0;
            this.btnSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(96)))), ((int)(((byte)(85)))));
            this.btnSignIn.Location = new System.Drawing.Point(526, 322);
            this.btnSignIn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(232, 43);
            this.btnSignIn.TabIndex = 7;
            this.btnSignIn.Text = "SIGN IN";
            this.btnSignIn.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(552, 376);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Don\'t have an account?";
            // 
            // btnSignUpNow
            // 
            this.btnSignUpNow.BackColor = System.Drawing.Color.White;
            this.btnSignUpNow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignUpNow.FlatAppearance.BorderSize = 0;
            this.btnSignUpNow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignUpNow.ForeColor = System.Drawing.Color.Green;
            this.btnSignUpNow.Location = new System.Drawing.Point(582, 408);
            this.btnSignUpNow.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSignUpNow.Name = "btnSignUpNow";
            this.btnSignUpNow.Size = new System.Drawing.Size(116, 39);
            this.btnSignUpNow.TabIndex = 9;
            this.btnSignUpNow.Text = "Sign up now";
            this.btnSignUpNow.UseVisualStyleBackColor = false;
            this.btnSignUpNow.Click += new System.EventHandler(this.btnSignUpNow_Click);
            // 
            // btnPasswordHideShow
            // 
            this.btnPasswordHideShow.BackgroundImage = global::OOP_PROJECT.Properties.Resources.hide;
            this.btnPasswordHideShow.FlatAppearance.BorderSize = 0;
            this.btnPasswordHideShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPasswordHideShow.Location = new System.Drawing.Point(720, 277);
            this.btnPasswordHideShow.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnPasswordHideShow.Name = "btnPasswordHideShow";
            this.btnPasswordHideShow.Size = new System.Drawing.Size(33, 35);
            this.btnPasswordHideShow.TabIndex = 10;
            this.btnPasswordHideShow.Text = "o";
            this.btnPasswordHideShow.UseVisualStyleBackColor = true;
            this.btnPasswordHideShow.Click += new System.EventHandler(this.btnPasswordHideShow_Click);
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 661);
            this.Controls.Add(this.btnPasswordHideShow);
            this.Controls.Add(this.btnSignUpNow);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.placehdrtxtPassword);
            this.Controls.Add(this.placehdrtxtEmail);
            this.Font = new System.Drawing.Font("Rockwell", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.Name = "SignIn";
            this.Text = "SignIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PlaceHolderTextBox placehdrtxtEmail;
        private PlaceHolderTextBox placehdrtxtPassword;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSignUpNow;
        private BorderlessButton btnPasswordHideShow;
    }
}