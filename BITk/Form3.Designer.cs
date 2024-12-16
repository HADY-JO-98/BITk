namespace BITk
{
    partial class Form3
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
            this.form7_panel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.Form7_btn_reserve = new System.Windows.Forms.Button();
            this.Form7_lb = new System.Windows.Forms.ListBox();
            this.Form7_label_name = new System.Windows.Forms.Label();
            this.form7_label_endDate = new System.Windows.Forms.Label();
            this.form7_label_startDate = new System.Windows.Forms.Label();
            this.form7_dtp_end = new System.Windows.Forms.DateTimePicker();
            this.form7_dtp_start = new System.Windows.Forms.DateTimePicker();
            this.form7_label_roomCap = new System.Windows.Forms.Label();
            this.form7_label_price = new System.Windows.Forms.Label();
            this.form7_label_roomType = new System.Windows.Forms.Label();
            this.form7_cb_roomCap = new System.Windows.Forms.ComboBox();
            this.form7_cb_price = new System.Windows.Forms.ComboBox();
            this.form7_cb_roomType = new System.Windows.Forms.ComboBox();
            this.form7_btn_search = new System.Windows.Forms.Button();
            this.form7_llabel_signout = new System.Windows.Forms.LinkLabel();
            this.form7_label = new System.Windows.Forms.Label();
            this.form7_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // form7_panel
            // 
            this.form7_panel.Controls.Add(this.button1);
            this.form7_panel.Controls.Add(this.Form7_btn_reserve);
            this.form7_panel.Controls.Add(this.Form7_lb);
            this.form7_panel.Controls.Add(this.Form7_label_name);
            this.form7_panel.Controls.Add(this.form7_label_endDate);
            this.form7_panel.Controls.Add(this.form7_label_startDate);
            this.form7_panel.Controls.Add(this.form7_dtp_end);
            this.form7_panel.Controls.Add(this.form7_dtp_start);
            this.form7_panel.Controls.Add(this.form7_label_roomCap);
            this.form7_panel.Controls.Add(this.form7_label_price);
            this.form7_panel.Controls.Add(this.form7_label_roomType);
            this.form7_panel.Controls.Add(this.form7_cb_roomCap);
            this.form7_panel.Controls.Add(this.form7_cb_price);
            this.form7_panel.Controls.Add(this.form7_cb_roomType);
            this.form7_panel.Controls.Add(this.form7_btn_search);
            this.form7_panel.Controls.Add(this.form7_llabel_signout);
            this.form7_panel.Controls.Add(this.form7_label);
            this.form7_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.form7_panel.Location = new System.Drawing.Point(0, 0);
            this.form7_panel.Name = "form7_panel";
            this.form7_panel.Size = new System.Drawing.Size(580, 290);
            this.form7_panel.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(404, 124);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 19);
            this.button1.TabIndex = 19;
            this.button1.Text = "View Reservations";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form7_btn_reserve
            // 
            this.Form7_btn_reserve.Location = new System.Drawing.Point(222, 124);
            this.Form7_btn_reserve.Name = "Form7_btn_reserve";
            this.Form7_btn_reserve.Size = new System.Drawing.Size(122, 20);
            this.Form7_btn_reserve.TabIndex = 18;
            this.Form7_btn_reserve.Text = "Reserve room";
            this.Form7_btn_reserve.UseVisualStyleBackColor = true;
            this.Form7_btn_reserve.Click += new System.EventHandler(this.Form7_btn_reserve_Click);
            // 
            // Form7_lb
            // 
            this.Form7_lb.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Form7_lb.FormattingEnabled = true;
            this.Form7_lb.Location = new System.Drawing.Point(0, 169);
            this.Form7_lb.Name = "Form7_lb";
            this.Form7_lb.Size = new System.Drawing.Size(580, 121);
            this.Form7_lb.TabIndex = 17;
            // 
            // Form7_label_name
            // 
            this.Form7_label_name.AutoSize = true;
            this.Form7_label_name.Location = new System.Drawing.Point(540, 9);
            this.Form7_label_name.Name = "Form7_label_name";
            this.Form7_label_name.Size = new System.Drawing.Size(35, 13);
            this.Form7_label_name.TabIndex = 16;
            this.Form7_label_name.Text = "label1";
            // 
            // form7_label_endDate
            // 
            this.form7_label_endDate.AutoSize = true;
            this.form7_label_endDate.Location = new System.Drawing.Point(458, 81);
            this.form7_label_endDate.Name = "form7_label_endDate";
            this.form7_label_endDate.Size = new System.Drawing.Size(82, 13);
            this.form7_label_endDate.TabIndex = 15;
            this.form7_label_endDate.Text = "Select end date";
            // 
            // form7_label_startDate
            // 
            this.form7_label_startDate.AutoSize = true;
            this.form7_label_startDate.Location = new System.Drawing.Point(458, 55);
            this.form7_label_startDate.Name = "form7_label_startDate";
            this.form7_label_startDate.Size = new System.Drawing.Size(84, 13);
            this.form7_label_startDate.TabIndex = 14;
            this.form7_label_startDate.Text = "Select start date";
            // 
            // form7_dtp_end
            // 
            this.form7_dtp_end.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.form7_dtp_end.Location = new System.Drawing.Point(340, 76);
            this.form7_dtp_end.Name = "form7_dtp_end";
            this.form7_dtp_end.Size = new System.Drawing.Size(113, 20);
            this.form7_dtp_end.TabIndex = 13;
            this.form7_dtp_end.ValueChanged += new System.EventHandler(this.form7_dtp_end_ValueChanged);
            // 
            // form7_dtp_start
            // 
            this.form7_dtp_start.Cursor = System.Windows.Forms.Cursors.Default;
            this.form7_dtp_start.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.form7_dtp_start.Location = new System.Drawing.Point(340, 48);
            this.form7_dtp_start.Name = "form7_dtp_start";
            this.form7_dtp_start.Size = new System.Drawing.Size(113, 20);
            this.form7_dtp_start.TabIndex = 12;
            this.form7_dtp_start.ValueChanged += new System.EventHandler(this.form7_dtp_start_ValueChanged);
            // 
            // form7_label_roomCap
            // 
            this.form7_label_roomCap.AutoSize = true;
            this.form7_label_roomCap.Location = new System.Drawing.Point(167, 102);
            this.form7_label_roomCap.Name = "form7_label_roomCap";
            this.form7_label_roomCap.Size = new System.Drawing.Size(106, 13);
            this.form7_label_roomCap.TabIndex = 11;
            this.form7_label_roomCap.Text = "Select room capacity";
            // 
            // form7_label_price
            // 
            this.form7_label_price.AutoSize = true;
            this.form7_label_price.Location = new System.Drawing.Point(167, 76);
            this.form7_label_price.Name = "form7_label_price";
            this.form7_label_price.Size = new System.Drawing.Size(93, 13);
            this.form7_label_price.TabIndex = 10;
            this.form7_label_price.Text = "Select price range";
            // 
            // form7_label_roomType
            // 
            this.form7_label_roomType.AutoSize = true;
            this.form7_label_roomType.Location = new System.Drawing.Point(167, 47);
            this.form7_label_roomType.Name = "form7_label_roomType";
            this.form7_label_roomType.Size = new System.Drawing.Size(86, 13);
            this.form7_label_roomType.TabIndex = 9;
            this.form7_label_roomType.Text = "Select room type";
            // 
            // form7_cb_roomCap
            // 
            this.form7_cb_roomCap.FormattingEnabled = true;
            this.form7_cb_roomCap.Location = new System.Drawing.Point(29, 94);
            this.form7_cb_roomCap.Name = "form7_cb_roomCap";
            this.form7_cb_roomCap.Size = new System.Drawing.Size(121, 21);
            this.form7_cb_roomCap.TabIndex = 8;
            this.form7_cb_roomCap.Text = "All";
            // 
            // form7_cb_price
            // 
            this.form7_cb_price.FormattingEnabled = true;
            this.form7_cb_price.Location = new System.Drawing.Point(29, 67);
            this.form7_cb_price.Name = "form7_cb_price";
            this.form7_cb_price.Size = new System.Drawing.Size(121, 21);
            this.form7_cb_price.TabIndex = 7;
            this.form7_cb_price.Text = "All";
            // 
            // form7_cb_roomType
            // 
            this.form7_cb_roomType.FormattingEnabled = true;
            this.form7_cb_roomType.Location = new System.Drawing.Point(29, 40);
            this.form7_cb_roomType.Name = "form7_cb_roomType";
            this.form7_cb_roomType.Size = new System.Drawing.Size(121, 21);
            this.form7_cb_roomType.TabIndex = 6;
            this.form7_cb_roomType.Text = "All";
            // 
            // form7_btn_search
            // 
            this.form7_btn_search.Location = new System.Drawing.Point(75, 124);
            this.form7_btn_search.Name = "form7_btn_search";
            this.form7_btn_search.Size = new System.Drawing.Size(75, 20);
            this.form7_btn_search.TabIndex = 5;
            this.form7_btn_search.Text = "Search";
            this.form7_btn_search.UseVisualStyleBackColor = true;
            this.form7_btn_search.Click += new System.EventHandler(this.form7_btn_search_Click);
            // 
            // form7_llabel_signout
            // 
            this.form7_llabel_signout.AutoSize = true;
            this.form7_llabel_signout.Location = new System.Drawing.Point(512, 31);
            this.form7_llabel_signout.Name = "form7_llabel_signout";
            this.form7_llabel_signout.Size = new System.Drawing.Size(44, 13);
            this.form7_llabel_signout.TabIndex = 3;
            this.form7_llabel_signout.TabStop = true;
            this.form7_llabel_signout.Text = "sign out";
            // 
            // form7_label
            // 
            this.form7_label.AutoSize = true;
            this.form7_label.Location = new System.Drawing.Point(486, 9);
            this.form7_label.Name = "form7_label";
            this.form7_label.Size = new System.Drawing.Size(58, 13);
            this.form7_label.TabIndex = 1;
            this.form7_label.Text = "Welcome, ";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 290);
            this.Controls.Add(this.form7_panel);
            this.Name = "Form3";
            this.Text = "Form3";
            this.form7_panel.ResumeLayout(false);
            this.form7_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel form7_panel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Form7_btn_reserve;
        private System.Windows.Forms.ListBox Form7_lb;
        private System.Windows.Forms.Label Form7_label_name;
        private System.Windows.Forms.Label form7_label_endDate;
        private System.Windows.Forms.Label form7_label_startDate;
        private System.Windows.Forms.DateTimePicker form7_dtp_end;
        private System.Windows.Forms.DateTimePicker form7_dtp_start;
        private System.Windows.Forms.Label form7_label_roomCap;
        private System.Windows.Forms.Label form7_label_price;
        private System.Windows.Forms.Label form7_label_roomType;
        private System.Windows.Forms.ComboBox form7_cb_roomCap;
        private System.Windows.Forms.ComboBox form7_cb_price;
        private System.Windows.Forms.ComboBox form7_cb_roomType;
        private System.Windows.Forms.Button form7_btn_search;
        private System.Windows.Forms.LinkLabel form7_llabel_signout;
        private System.Windows.Forms.Label form7_label;
    }
}