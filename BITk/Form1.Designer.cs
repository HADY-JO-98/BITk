namespace BITk
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Form5_lb = new System.Windows.Forms.ListBox();
            this.Form5_label_name = new System.Windows.Forms.Label();
            this.form5_btn_newRes = new System.Windows.Forms.Button();
            this.form5_btn_cancelRes = new System.Windows.Forms.Button();
            this.form5_btn_getRes = new System.Windows.Forms.Button();
            this.form5_llabel_signout = new System.Windows.Forms.LinkLabel();
            this.form5_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 176);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 21);
            this.button1.TabIndex = 21;
            this.button1.Text = "Map View";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 122);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "New Reservation:";
            // 
            // Form5_lb
            // 
            this.Form5_lb.FormattingEnabled = true;
            this.Form5_lb.HorizontalScrollbar = true;
            this.Form5_lb.Location = new System.Drawing.Point(143, 60);
            this.Form5_lb.Name = "Form5_lb";
            this.Form5_lb.Size = new System.Drawing.Size(336, 160);
            this.Form5_lb.TabIndex = 19;
            // 
            // Form5_label_name
            // 
            this.Form5_label_name.AutoSize = true;
            this.Form5_label_name.Location = new System.Drawing.Point(429, 26);
            this.Form5_label_name.Name = "Form5_label_name";
            this.Form5_label_name.Size = new System.Drawing.Size(35, 13);
            this.Form5_label_name.TabIndex = 18;
            this.Form5_label_name.Text = "label1";
            // 
            // form5_btn_newRes
            // 
            this.form5_btn_newRes.Location = new System.Drawing.Point(12, 146);
            this.form5_btn_newRes.Name = "form5_btn_newRes";
            this.form5_btn_newRes.Size = new System.Drawing.Size(112, 23);
            this.form5_btn_newRes.TabIndex = 17;
            this.form5_btn_newRes.Text = "Querry View";
            this.form5_btn_newRes.UseVisualStyleBackColor = true;
            this.form5_btn_newRes.Click += new System.EventHandler(this.form5_btn_newRes_Click);
            // 
            // form5_btn_cancelRes
            // 
            this.form5_btn_cancelRes.Location = new System.Drawing.Point(12, 60);
            this.form5_btn_cancelRes.Name = "form5_btn_cancelRes";
            this.form5_btn_cancelRes.Size = new System.Drawing.Size(112, 23);
            this.form5_btn_cancelRes.TabIndex = 16;
            this.form5_btn_cancelRes.Text = "cancel reservation";
            this.form5_btn_cancelRes.UseVisualStyleBackColor = true;
            this.form5_btn_cancelRes.Click += new System.EventHandler(this.form5_btn_cancelRes_Click);
            // 
            // form5_btn_getRes
            // 
            this.form5_btn_getRes.Location = new System.Drawing.Point(12, 26);
            this.form5_btn_getRes.Name = "form5_btn_getRes";
            this.form5_btn_getRes.Size = new System.Drawing.Size(112, 23);
            this.form5_btn_getRes.TabIndex = 15;
            this.form5_btn_getRes.Text = "current reservations";
            this.form5_btn_getRes.UseVisualStyleBackColor = true;
            this.form5_btn_getRes.Click += new System.EventHandler(this.form5_btn_getRes_Click);
            // 
            // form5_llabel_signout
            // 
            this.form5_llabel_signout.AutoSize = true;
            this.form5_llabel_signout.Location = new System.Drawing.Point(412, 42);
            this.form5_llabel_signout.Name = "form5_llabel_signout";
            this.form5_llabel_signout.Size = new System.Drawing.Size(44, 13);
            this.form5_llabel_signout.TabIndex = 14;
            this.form5_llabel_signout.TabStop = true;
            this.form5_llabel_signout.Text = "sign out";
            this.form5_llabel_signout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.form5_llabel_signout_LinkClicked);
            // 
            // form5_label
            // 
            this.form5_label.AutoSize = true;
            this.form5_label.Location = new System.Drawing.Point(373, 26);
            this.form5_label.Name = "form5_label";
            this.form5_label.Size = new System.Drawing.Size(52, 13);
            this.form5_label.TabIndex = 13;
            this.form5_label.Text = "welcome,";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 249);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Form5_lb);
            this.Controls.Add(this.Form5_label_name);
            this.Controls.Add(this.form5_btn_newRes);
            this.Controls.Add(this.form5_btn_cancelRes);
            this.Controls.Add(this.form5_btn_getRes);
            this.Controls.Add(this.form5_llabel_signout);
            this.Controls.Add(this.form5_label);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox Form5_lb;
        private System.Windows.Forms.Label Form5_label_name;
        private System.Windows.Forms.Button form5_btn_newRes;
        private System.Windows.Forms.Button form5_btn_cancelRes;
        private System.Windows.Forms.Button form5_btn_getRes;
        private System.Windows.Forms.LinkLabel form5_llabel_signout;
        private System.Windows.Forms.Label form5_label;
    }
}