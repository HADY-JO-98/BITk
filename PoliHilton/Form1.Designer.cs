namespace PoliHilton
{
    partial class Form1
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
            this.form1_textBoxUsername = new System.Windows.Forms.TextBox();
            this.form1_textBoxPass = new System.Windows.Forms.TextBox();
            this.form1_label_username = new System.Windows.Forms.Label();
            this.form1_label_password = new System.Windows.Forms.Label();
            this.form1_button_signin = new System.Windows.Forms.Button();
            this.form1_tab = new System.Windows.Forms.TabControl();
            this.form1_tab1 = new System.Windows.Forms.TabPage();
            this.form1_tab2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.form1_tab2_confpass = new System.Windows.Forms.TextBox();
            this.form1_tab2_pass = new System.Windows.Forms.TextBox();
            this.form1_tab2_username = new System.Windows.Forms.TextBox();
            this.form1_tab2_lastName = new System.Windows.Forms.TextBox();
            this.form1_tab2_firstName = new System.Windows.Forms.TextBox();
            this.form1_lable2 = new System.Windows.Forms.Label();
            this.form1_tab2_passlable = new System.Windows.Forms.Label();
            this.form1_tab2_user_lable = new System.Windows.Forms.Label();
            this.form1_lable1 = new System.Windows.Forms.Label();
            this.form1_label_signup = new System.Windows.Forms.Label();
            this.form1_button_signup = new System.Windows.Forms.Button();
            this.form1_tab.SuspendLayout();
            this.form1_tab1.SuspendLayout();
            this.form1_tab2.SuspendLayout();
            this.SuspendLayout();
            // 
            // form1_textBoxUsername
            // 
            this.form1_textBoxUsername.Location = new System.Drawing.Point(104, 54);
            this.form1_textBoxUsername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.form1_textBoxUsername.Name = "form1_textBoxUsername";
            this.form1_textBoxUsername.Size = new System.Drawing.Size(132, 22);
            this.form1_textBoxUsername.TabIndex = 0;
            // 
            // form1_textBoxPass
            // 
            this.form1_textBoxPass.Location = new System.Drawing.Point(104, 103);
            this.form1_textBoxPass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.form1_textBoxPass.Name = "form1_textBoxPass";
            this.form1_textBoxPass.PasswordChar = '*';
            this.form1_textBoxPass.Size = new System.Drawing.Size(132, 22);
            this.form1_textBoxPass.TabIndex = 1;
            // 
            // form1_label_username
            // 
            this.form1_label_username.AutoSize = true;
            this.form1_label_username.Location = new System.Drawing.Point(19, 57);
            this.form1_label_username.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.form1_label_username.Name = "form1_label_username";
            this.form1_label_username.Size = new System.Drawing.Size(73, 17);
            this.form1_label_username.TabIndex = 2;
            this.form1_label_username.Text = "Username";
            // 
            // form1_label_password
            // 
            this.form1_label_password.AutoSize = true;
            this.form1_label_password.Location = new System.Drawing.Point(19, 107);
            this.form1_label_password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.form1_label_password.Name = "form1_label_password";
            this.form1_label_password.Size = new System.Drawing.Size(69, 17);
            this.form1_label_password.TabIndex = 3;
            this.form1_label_password.Text = "Password";
            // 
            // form1_button_signin
            // 
            this.form1_button_signin.AutoSize = true;
            this.form1_button_signin.Location = new System.Drawing.Point(301, 71);
            this.form1_button_signin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.form1_button_signin.Name = "form1_button_signin";
            this.form1_button_signin.Size = new System.Drawing.Size(133, 33);
            this.form1_button_signin.TabIndex = 4;
            this.form1_button_signin.Text = "Sign In";
            this.form1_button_signin.UseVisualStyleBackColor = true;
            this.form1_button_signin.Click += new System.EventHandler(this.form1_button_signin_Click);
            // 
            // form1_tab
            // 
            this.form1_tab.Controls.Add(this.form1_tab1);
            this.form1_tab.Controls.Add(this.form1_tab2);
            this.form1_tab.Location = new System.Drawing.Point(12, 12);
            this.form1_tab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.form1_tab.Name = "form1_tab";
            this.form1_tab.SelectedIndex = 0;
            this.form1_tab.Size = new System.Drawing.Size(485, 230);
            this.form1_tab.TabIndex = 7;
            // 
            // form1_tab1
            // 
            this.form1_tab1.Controls.Add(this.form1_textBoxUsername);
            this.form1_tab1.Controls.Add(this.form1_textBoxPass);
            this.form1_tab1.Controls.Add(this.form1_label_username);
            this.form1_tab1.Controls.Add(this.form1_button_signin);
            this.form1_tab1.Controls.Add(this.form1_label_password);
            this.form1_tab1.Location = new System.Drawing.Point(4, 25);
            this.form1_tab1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.form1_tab1.Name = "form1_tab1";
            this.form1_tab1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.form1_tab1.Size = new System.Drawing.Size(477, 201);
            this.form1_tab1.TabIndex = 0;
            this.form1_tab1.Text = "Log In";
            this.form1_tab1.UseVisualStyleBackColor = true;
            // 
            // form1_tab2
            // 
            this.form1_tab2.Controls.Add(this.label1);
            this.form1_tab2.Controls.Add(this.form1_tab2_confpass);
            this.form1_tab2.Controls.Add(this.form1_tab2_pass);
            this.form1_tab2.Controls.Add(this.form1_tab2_username);
            this.form1_tab2.Controls.Add(this.form1_tab2_lastName);
            this.form1_tab2.Controls.Add(this.form1_tab2_firstName);
            this.form1_tab2.Controls.Add(this.form1_lable2);
            this.form1_tab2.Controls.Add(this.form1_tab2_passlable);
            this.form1_tab2.Controls.Add(this.form1_tab2_user_lable);
            this.form1_tab2.Controls.Add(this.form1_lable1);
            this.form1_tab2.Controls.Add(this.form1_label_signup);
            this.form1_tab2.Controls.Add(this.form1_button_signup);
            this.form1_tab2.Location = new System.Drawing.Point(4, 25);
            this.form1_tab2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.form1_tab2.Name = "form1_tab2";
            this.form1_tab2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.form1_tab2.Size = new System.Drawing.Size(477, 201);
            this.form1_tab2.TabIndex = 1;
            this.form1_tab2.Text = "Sign up";
            this.form1_tab2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 100);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Confirm Password";
            // 
            // form1_tab2_confpass
            // 
            this.form1_tab2_confpass.Location = new System.Drawing.Point(289, 96);
            this.form1_tab2_confpass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.form1_tab2_confpass.Name = "form1_tab2_confpass";
            this.form1_tab2_confpass.PasswordChar = '*';
            this.form1_tab2_confpass.Size = new System.Drawing.Size(136, 22);
            this.form1_tab2_confpass.TabIndex = 13;
            // 
            // form1_tab2_pass
            // 
            this.form1_tab2_pass.Location = new System.Drawing.Point(289, 66);
            this.form1_tab2_pass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.form1_tab2_pass.Name = "form1_tab2_pass";
            this.form1_tab2_pass.PasswordChar = '*';
            this.form1_tab2_pass.Size = new System.Drawing.Size(136, 22);
            this.form1_tab2_pass.TabIndex = 12;
            // 
            // form1_tab2_username
            // 
            this.form1_tab2_username.Location = new System.Drawing.Point(289, 37);
            this.form1_tab2_username.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.form1_tab2_username.Name = "form1_tab2_username";
            this.form1_tab2_username.Size = new System.Drawing.Size(136, 22);
            this.form1_tab2_username.TabIndex = 11;
            // 
            // form1_tab2_lastName
            // 
            this.form1_tab2_lastName.Location = new System.Drawing.Point(35, 110);
            this.form1_tab2_lastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.form1_tab2_lastName.Name = "form1_tab2_lastName";
            this.form1_tab2_lastName.Size = new System.Drawing.Size(100, 22);
            this.form1_tab2_lastName.TabIndex = 10;
            // 
            // form1_tab2_firstName
            // 
            this.form1_tab2_firstName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.form1_tab2_firstName.Location = new System.Drawing.Point(35, 57);
            this.form1_tab2_firstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.form1_tab2_firstName.Name = "form1_tab2_firstName";
            this.form1_tab2_firstName.Size = new System.Drawing.Size(100, 22);
            this.form1_tab2_firstName.TabIndex = 9;
            // 
            // form1_lable2
            // 
            this.form1_lable2.AutoSize = true;
            this.form1_lable2.Location = new System.Drawing.Point(45, 89);
            this.form1_lable2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.form1_lable2.Name = "form1_lable2";
            this.form1_lable2.Size = new System.Drawing.Size(76, 17);
            this.form1_lable2.TabIndex = 8;
            this.form1_lable2.Text = "Last Name";
            // 
            // form1_tab2_passlable
            // 
            this.form1_tab2_passlable.AutoSize = true;
            this.form1_tab2_passlable.Location = new System.Drawing.Point(161, 66);
            this.form1_tab2_passlable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.form1_tab2_passlable.Name = "form1_tab2_passlable";
            this.form1_tab2_passlable.Size = new System.Drawing.Size(69, 17);
            this.form1_tab2_passlable.TabIndex = 8;
            this.form1_tab2_passlable.Text = "Password";
            // 
            // form1_tab2_user_lable
            // 
            this.form1_tab2_user_lable.AutoSize = true;
            this.form1_tab2_user_lable.Location = new System.Drawing.Point(161, 37);
            this.form1_tab2_user_lable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.form1_tab2_user_lable.Name = "form1_tab2_user_lable";
            this.form1_tab2_user_lable.Size = new System.Drawing.Size(73, 17);
            this.form1_tab2_user_lable.TabIndex = 8;
            this.form1_tab2_user_lable.Text = "Username";
            // 
            // form1_lable1
            // 
            this.form1_lable1.AutoSize = true;
            this.form1_lable1.Location = new System.Drawing.Point(45, 37);
            this.form1_lable1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.form1_lable1.Name = "form1_lable1";
            this.form1_lable1.Size = new System.Drawing.Size(76, 17);
            this.form1_lable1.TabIndex = 8;
            this.form1_lable1.Text = "First Name";
            // 
            // form1_label_signup
            // 
            this.form1_label_signup.AutoSize = true;
            this.form1_label_signup.Location = new System.Drawing.Point(95, 12);
            this.form1_label_signup.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.form1_label_signup.Name = "form1_label_signup";
            this.form1_label_signup.Size = new System.Drawing.Size(264, 17);
            this.form1_label_signup.TabIndex = 8;
            this.form1_label_signup.Text = "Don\'t have an account yet? Sign Up now";
            // 
            // form1_button_signup
            // 
            this.form1_button_signup.AutoSize = true;
            this.form1_button_signup.Location = new System.Drawing.Point(289, 137);
            this.form1_button_signup.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.form1_button_signup.Name = "form1_button_signup";
            this.form1_button_signup.Size = new System.Drawing.Size(133, 33);
            this.form1_button_signup.TabIndex = 7;
            this.form1_button_signup.Text = "Sign Up";
            this.form1_button_signup.UseVisualStyleBackColor = true;
            this.form1_button_signup.Click += new System.EventHandler(this.form1_button_signup_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 249);
            this.Controls.Add(this.form1_tab);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.form1_tab.ResumeLayout(false);
            this.form1_tab1.ResumeLayout(false);
            this.form1_tab1.PerformLayout();
            this.form1_tab2.ResumeLayout(false);
            this.form1_tab2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox form1_textBoxUsername;
        private System.Windows.Forms.TextBox form1_textBoxPass;
        private System.Windows.Forms.Label form1_label_username;
        private System.Windows.Forms.Label form1_label_password;
        private System.Windows.Forms.Button form1_button_signin;
        private System.Windows.Forms.TabControl form1_tab;
        private System.Windows.Forms.TabPage form1_tab1;
        private System.Windows.Forms.TabPage form1_tab2;
        private System.Windows.Forms.TextBox form1_tab2_pass;
        private System.Windows.Forms.TextBox form1_tab2_username;
        private System.Windows.Forms.TextBox form1_tab2_lastName;
        private System.Windows.Forms.TextBox form1_tab2_firstName;
        private System.Windows.Forms.Label form1_lable2;
        private System.Windows.Forms.Label form1_tab2_passlable;
        private System.Windows.Forms.Label form1_tab2_user_lable;
        private System.Windows.Forms.Label form1_lable1;
        private System.Windows.Forms.Label form1_label_signup;
        private System.Windows.Forms.Button form1_button_signup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox form1_tab2_confpass;

    }
}

