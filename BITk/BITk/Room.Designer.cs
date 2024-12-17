namespace BITk
{
    partial class Room
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
            this.Form3_label_name = new System.Windows.Forms.Label();
            this.form3_lb = new System.Windows.Forms.ListBox();
            this.form3_label_asignedRooms = new System.Windows.Forms.Label();
            this.form3_btn_cleaned = new System.Windows.Forms.Button();
            this.form3_btn_inProgress = new System.Windows.Forms.Button();
            this.form3_label_roomStatus = new System.Windows.Forms.Label();
            this.form3_llabel_signout = new System.Windows.Forms.LinkLabel();
            this.form3_label_welcome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Form3_label_name
            // 
            this.Form3_label_name.AutoSize = true;
            this.Form3_label_name.Location = new System.Drawing.Point(300, 12);
            this.Form3_label_name.Name = "Form3_label_name";
            this.Form3_label_name.Size = new System.Drawing.Size(35, 13);
            this.Form3_label_name.TabIndex = 21;
            this.Form3_label_name.Text = "label1";
            // 
            // form3_lb
            // 
            this.form3_lb.FormattingEnabled = true;
            this.form3_lb.HorizontalScrollbar = true;
            this.form3_lb.Location = new System.Drawing.Point(10, 45);
            this.form3_lb.Name = "form3_lb";
            this.form3_lb.Size = new System.Drawing.Size(326, 212);
            this.form3_lb.TabIndex = 20;
            // 
            // form3_label_asignedRooms
            // 
            this.form3_label_asignedRooms.AutoSize = true;
            this.form3_label_asignedRooms.Location = new System.Drawing.Point(19, 22);
            this.form3_label_asignedRooms.Name = "form3_label_asignedRooms";
            this.form3_label_asignedRooms.Size = new System.Drawing.Size(75, 13);
            this.form3_label_asignedRooms.TabIndex = 19;
            this.form3_label_asignedRooms.Text = "asigned rooms";
            // 
            // form3_btn_cleaned
            // 
            this.form3_btn_cleaned.Location = new System.Drawing.Point(61, 290);
            this.form3_btn_cleaned.Name = "form3_btn_cleaned";
            this.form3_btn_cleaned.Size = new System.Drawing.Size(75, 23);
            this.form3_btn_cleaned.TabIndex = 18;
            this.form3_btn_cleaned.Text = "Cleaned";
            this.form3_btn_cleaned.UseVisualStyleBackColor = true;
            // 
            // form3_btn_inProgress
            // 
            this.form3_btn_inProgress.Location = new System.Drawing.Point(196, 290);
            this.form3_btn_inProgress.Name = "form3_btn_inProgress";
            this.form3_btn_inProgress.Size = new System.Drawing.Size(75, 23);
            this.form3_btn_inProgress.TabIndex = 17;
            this.form3_btn_inProgress.Text = "In progress";
            this.form3_btn_inProgress.UseVisualStyleBackColor = true;
            // 
            // form3_label_roomStatus
            // 
            this.form3_label_roomStatus.AutoSize = true;
            this.form3_label_roomStatus.Location = new System.Drawing.Point(116, 273);
            this.form3_label_roomStatus.Name = "form3_label_roomStatus";
            this.form3_label_roomStatus.Size = new System.Drawing.Size(100, 13);
            this.form3_label_roomStatus.TabIndex = 16;
            this.form3_label_roomStatus.Text = "change room status";
            // 
            // form3_llabel_signout
            // 
            this.form3_llabel_signout.AutoSize = true;
            this.form3_llabel_signout.Location = new System.Drawing.Point(273, 27);
            this.form3_llabel_signout.Name = "form3_llabel_signout";
            this.form3_llabel_signout.Size = new System.Drawing.Size(44, 13);
            this.form3_llabel_signout.TabIndex = 15;
            this.form3_llabel_signout.TabStop = true;
            this.form3_llabel_signout.Text = "sign out";
            this.form3_llabel_signout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.form3_llabel_signout_LinkClicked);
            // 
            // form3_label_welcome
            // 
            this.form3_label_welcome.AutoSize = true;
            this.form3_label_welcome.Location = new System.Drawing.Point(248, 12);
            this.form3_label_welcome.Name = "form3_label_welcome";
            this.form3_label_welcome.Size = new System.Drawing.Size(58, 13);
            this.form3_label_welcome.TabIndex = 14;
            this.form3_label_welcome.Text = "Welcome, ";
            // 
            // Room
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 324);
            this.Controls.Add(this.Form3_label_name);
            this.Controls.Add(this.form3_lb);
            this.Controls.Add(this.form3_label_asignedRooms);
            this.Controls.Add(this.form3_btn_cleaned);
            this.Controls.Add(this.form3_btn_inProgress);
            this.Controls.Add(this.form3_label_roomStatus);
            this.Controls.Add(this.form3_llabel_signout);
            this.Controls.Add(this.form3_label_welcome);
            this.Name = "Room";
            this.Text = "Room";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Form3_label_name;
        private System.Windows.Forms.ListBox form3_lb;
        private System.Windows.Forms.Label form3_label_asignedRooms;
        private System.Windows.Forms.Button form3_btn_cleaned;
        private System.Windows.Forms.Button form3_btn_inProgress;
        private System.Windows.Forms.Label form3_label_roomStatus;
        private System.Windows.Forms.LinkLabel form3_llabel_signout;
        private System.Windows.Forms.Label form3_label_welcome;
    }
}