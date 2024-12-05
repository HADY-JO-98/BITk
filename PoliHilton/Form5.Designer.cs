namespace PoliHilton
{
    partial class Form5
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
            this.form5_panel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Form5_lb = new System.Windows.Forms.ListBox();
            this.Form5_label_name = new System.Windows.Forms.Label();
            this.form5_btn_newRes = new System.Windows.Forms.Button();
            this.form5_btn_cancelRes = new System.Windows.Forms.Button();
            this.form5_btn_getRes = new System.Windows.Forms.Button();
            this.form5_llabel_signout = new System.Windows.Forms.LinkLabel();
            this.form5_label = new System.Windows.Forms.Label();
            this.form5_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // form5_panel
            // 
            this.form5_panel.Controls.Add(this.button1);
            this.form5_panel.Controls.Add(this.label1);
            this.form5_panel.Controls.Add(this.Form5_lb);
            this.form5_panel.Controls.Add(this.Form5_label_name);
            this.form5_panel.Controls.Add(this.form5_btn_newRes);
            this.form5_panel.Controls.Add(this.form5_btn_cancelRes);
            this.form5_panel.Controls.Add(this.form5_btn_getRes);
            this.form5_panel.Controls.Add(this.form5_llabel_signout);
            this.form5_panel.Controls.Add(this.form5_label);
            this.form5_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.form5_panel.Location = new System.Drawing.Point(0, 0);
            this.form5_panel.Margin = new System.Windows.Forms.Padding(4);
            this.form5_panel.Name = "form5_panel";
            this.form5_panel.Size = new System.Drawing.Size(649, 287);
            this.form5_panel.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 26);
            this.button1.TabIndex = 12;
            this.button1.Text = "Map View";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "New Reservation:";
            // 
            // Form5_lb
            // 
            this.Form5_lb.FormattingEnabled = true;
            this.Form5_lb.HorizontalScrollbar = true;
            this.Form5_lb.ItemHeight = 16;
            this.Form5_lb.Location = new System.Drawing.Point(191, 64);
            this.Form5_lb.Margin = new System.Windows.Forms.Padding(4);
            this.Form5_lb.Name = "Form5_lb";
            this.Form5_lb.Size = new System.Drawing.Size(447, 196);
            this.Form5_lb.TabIndex = 10;
            // 
            // Form5_label_name
            // 
            this.Form5_label_name.AutoSize = true;
            this.Form5_label_name.Location = new System.Drawing.Point(572, 22);
            this.Form5_label_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Form5_label_name.Name = "Form5_label_name";
            this.Form5_label_name.Size = new System.Drawing.Size(46, 17);
            this.Form5_label_name.TabIndex = 9;
            this.Form5_label_name.Text = "label1";
            // 
            // form5_btn_newRes
            // 
            this.form5_btn_newRes.Location = new System.Drawing.Point(16, 170);
            this.form5_btn_newRes.Margin = new System.Windows.Forms.Padding(4);
            this.form5_btn_newRes.Name = "form5_btn_newRes";
            this.form5_btn_newRes.Size = new System.Drawing.Size(149, 28);
            this.form5_btn_newRes.TabIndex = 7;
            this.form5_btn_newRes.Text = "Querry View";
            this.form5_btn_newRes.UseVisualStyleBackColor = true;
            this.form5_btn_newRes.Click += new System.EventHandler(this.form5_btn_newRes_Click);
            // 
            // form5_btn_cancelRes
            // 
            this.form5_btn_cancelRes.Location = new System.Drawing.Point(16, 64);
            this.form5_btn_cancelRes.Margin = new System.Windows.Forms.Padding(4);
            this.form5_btn_cancelRes.Name = "form5_btn_cancelRes";
            this.form5_btn_cancelRes.Size = new System.Drawing.Size(149, 28);
            this.form5_btn_cancelRes.TabIndex = 6;
            this.form5_btn_cancelRes.Text = "cancel reservation";
            this.form5_btn_cancelRes.UseVisualStyleBackColor = true;
            this.form5_btn_cancelRes.Click += new System.EventHandler(this.form5_btn_cancelRes_Click);
            // 
            // form5_btn_getRes
            // 
            this.form5_btn_getRes.Location = new System.Drawing.Point(16, 22);
            this.form5_btn_getRes.Margin = new System.Windows.Forms.Padding(4);
            this.form5_btn_getRes.Name = "form5_btn_getRes";
            this.form5_btn_getRes.Size = new System.Drawing.Size(149, 28);
            this.form5_btn_getRes.TabIndex = 5;
            this.form5_btn_getRes.Text = "current reservations";
            this.form5_btn_getRes.UseVisualStyleBackColor = true;
            this.form5_btn_getRes.Click += new System.EventHandler(this.form5_btn_getRes_Click);
            // 
            // form5_llabel_signout
            // 
            this.form5_llabel_signout.AutoSize = true;
            this.form5_llabel_signout.Location = new System.Drawing.Point(549, 42);
            this.form5_llabel_signout.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.form5_llabel_signout.Name = "form5_llabel_signout";
            this.form5_llabel_signout.Size = new System.Drawing.Size(58, 17);
            this.form5_llabel_signout.TabIndex = 3;
            this.form5_llabel_signout.TabStop = true;
            this.form5_llabel_signout.Text = "sign out";
            this.form5_llabel_signout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.form5_llabel_signout_LinkClicked);
            // 
            // form5_label
            // 
            this.form5_label.AutoSize = true;
            this.form5_label.Location = new System.Drawing.Point(497, 22);
            this.form5_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.form5_label.Name = "form5_label";
            this.form5_label.Size = new System.Drawing.Size(66, 17);
            this.form5_label.TabIndex = 1;
            this.form5_label.Text = "welcome,";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 287);
            this.Controls.Add(this.form5_panel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form5";
            this.Text = "Form5";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form5_FormClosed);
            this.form5_panel.ResumeLayout(false);
            this.form5_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel form5_panel;
        private System.Windows.Forms.Button form5_btn_cancelRes;
        private System.Windows.Forms.Button form5_btn_getRes;
        private System.Windows.Forms.LinkLabel form5_llabel_signout;
        private System.Windows.Forms.Label form5_label;
        private System.Windows.Forms.Button form5_btn_newRes;
        private System.Windows.Forms.Label Form5_label_name;
        private System.Windows.Forms.ListBox Form5_lb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}