namespace PoliHilton
{
    partial class Form4
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
            this.form4_button_createrezervation = new System.Windows.Forms.Button();
            this.form4_label_username = new System.Windows.Forms.Label();
            this.form4_label_roomid = new System.Windows.Forms.Label();
            this.form4_label_checkindate = new System.Windows.Forms.Label();
            this.form4_label_checkoutdate = new System.Windows.Forms.Label();
            this.form4_dtp_checkin = new System.Windows.Forms.DateTimePicker();
            this.form4_dtp_checkout = new System.Windows.Forms.DateTimePicker();
            this.form4_tabcontrol = new System.Windows.Forms.TabControl();
            this.form4_tabpage_createrezervations = new System.Windows.Forms.TabPage();
            this.form4_cb_roomnumber = new System.Windows.Forms.ComboBox();
            this.form4_cb_username = new System.Windows.Forms.ComboBox();
            this.form4_label_rezervationprice = new System.Windows.Forms.Label();
            this.form4_textPrice = new System.Windows.Forms.TextBox();
            this.form4_tabpage_createuser = new System.Windows.Forms.TabPage();
            this.form4_text_lastname = new System.Windows.Forms.TextBox();
            this.form4_text_firstname = new System.Windows.Forms.TextBox();
            this.form4_text_usertypeid = new System.Windows.Forms.TextBox();
            this.form4_label_usertypeid = new System.Windows.Forms.Label();
            this.form4_label_firstname = new System.Windows.Forms.Label();
            this.form4_label_lastname = new System.Windows.Forms.Label();
            this.form1_label_password = new System.Windows.Forms.Label();
            this.form4_text_password = new System.Windows.Forms.TextBox();
            this.form4_button_createuser = new System.Windows.Forms.Button();
            this.form4_text_username = new System.Windows.Forms.TextBox();
            this.form1_label_username = new System.Windows.Forms.Label();
            this.form4_tabpage_deleterezervations = new System.Windows.Forms.TabPage();
            this.form4_button_deleterezervation = new System.Windows.Forms.Button();
            this.form4_datagridview = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.form4_button_checkout = new System.Windows.Forms.Button();
            this.form4_datagridview2 = new System.Windows.Forms.DataGridView();
            this.form4_label_user = new System.Windows.Forms.Label();
            this.form4_button_logout = new System.Windows.Forms.Button();
            this.form4_tabcontrol.SuspendLayout();
            this.form4_tabpage_createrezervations.SuspendLayout();
            this.form4_tabpage_createuser.SuspendLayout();
            this.form4_tabpage_deleterezervations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.form4_datagridview)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.form4_datagridview2)).BeginInit();
            this.SuspendLayout();
            // 
            // form4_button_createrezervation
            // 
            this.form4_button_createrezervation.Location = new System.Drawing.Point(146, 257);
            this.form4_button_createrezervation.Margin = new System.Windows.Forms.Padding(4);
            this.form4_button_createrezervation.Name = "form4_button_createrezervation";
            this.form4_button_createrezervation.Size = new System.Drawing.Size(383, 37);
            this.form4_button_createrezervation.TabIndex = 0;
            this.form4_button_createrezervation.Text = "Create Reservation";
            this.form4_button_createrezervation.UseVisualStyleBackColor = true;
            this.form4_button_createrezervation.Click += new System.EventHandler(this.form4_button_createrezervation_Click);
            // 
            // form4_label_username
            // 
            this.form4_label_username.AutoSize = true;
            this.form4_label_username.Location = new System.Drawing.Point(142, 41);
            this.form4_label_username.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.form4_label_username.Name = "form4_label_username";
            this.form4_label_username.Size = new System.Drawing.Size(73, 17);
            this.form4_label_username.TabIndex = 2;
            this.form4_label_username.Text = "Username";
            // 
            // form4_label_roomid
            // 
            this.form4_label_roomid.AutoSize = true;
            this.form4_label_roomid.Location = new System.Drawing.Point(142, 78);
            this.form4_label_roomid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.form4_label_roomid.Name = "form4_label_roomid";
            this.form4_label_roomid.Size = new System.Drawing.Size(99, 17);
            this.form4_label_roomid.TabIndex = 3;
            this.form4_label_roomid.Text = "Room Number";
            // 
            // form4_label_checkindate
            // 
            this.form4_label_checkindate.AutoSize = true;
            this.form4_label_checkindate.Location = new System.Drawing.Point(142, 124);
            this.form4_label_checkindate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.form4_label_checkindate.Name = "form4_label_checkindate";
            this.form4_label_checkindate.Size = new System.Drawing.Size(97, 17);
            this.form4_label_checkindate.TabIndex = 5;
            this.form4_label_checkindate.Text = "Check-In Date";
            // 
            // form4_label_checkoutdate
            // 
            this.form4_label_checkoutdate.AutoSize = true;
            this.form4_label_checkoutdate.Location = new System.Drawing.Point(142, 166);
            this.form4_label_checkoutdate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.form4_label_checkoutdate.Name = "form4_label_checkoutdate";
            this.form4_label_checkoutdate.Size = new System.Drawing.Size(109, 17);
            this.form4_label_checkoutdate.TabIndex = 7;
            this.form4_label_checkoutdate.Text = "Check-Out Date";
            // 
            // form4_dtp_checkin
            // 
            this.form4_dtp_checkin.Location = new System.Drawing.Point(262, 117);
            this.form4_dtp_checkin.Margin = new System.Windows.Forms.Padding(4);
            this.form4_dtp_checkin.Name = "form4_dtp_checkin";
            this.form4_dtp_checkin.Size = new System.Drawing.Size(265, 22);
            this.form4_dtp_checkin.TabIndex = 10;
            this.form4_dtp_checkin.ValueChanged += new System.EventHandler(this.form4_dtp_checkin_ValueChanged);
            // 
            // form4_dtp_checkout
            // 
            this.form4_dtp_checkout.Location = new System.Drawing.Point(262, 159);
            this.form4_dtp_checkout.Margin = new System.Windows.Forms.Padding(4);
            this.form4_dtp_checkout.Name = "form4_dtp_checkout";
            this.form4_dtp_checkout.Size = new System.Drawing.Size(265, 22);
            this.form4_dtp_checkout.TabIndex = 11;
            this.form4_dtp_checkout.ValueChanged += new System.EventHandler(this.form4_dtp_checkout_ValueChanged);
            // 
            // form4_tabcontrol
            // 
            this.form4_tabcontrol.Controls.Add(this.form4_tabpage_createrezervations);
            this.form4_tabcontrol.Controls.Add(this.form4_tabpage_createuser);
            this.form4_tabcontrol.Controls.Add(this.form4_tabpage_deleterezervations);
            this.form4_tabcontrol.Controls.Add(this.tabPage1);
            this.form4_tabcontrol.Location = new System.Drawing.Point(13, 14);
            this.form4_tabcontrol.Margin = new System.Windows.Forms.Padding(4);
            this.form4_tabcontrol.Name = "form4_tabcontrol";
            this.form4_tabcontrol.SelectedIndex = 0;
            this.form4_tabcontrol.Size = new System.Drawing.Size(698, 356);
            this.form4_tabcontrol.TabIndex = 12;
            // 
            // form4_tabpage_createrezervations
            // 
            this.form4_tabpage_createrezervations.Controls.Add(this.form4_cb_roomnumber);
            this.form4_tabpage_createrezervations.Controls.Add(this.form4_cb_username);
            this.form4_tabpage_createrezervations.Controls.Add(this.form4_label_rezervationprice);
            this.form4_tabpage_createrezervations.Controls.Add(this.form4_textPrice);
            this.form4_tabpage_createrezervations.Controls.Add(this.form4_label_username);
            this.form4_tabpage_createrezervations.Controls.Add(this.form4_button_createrezervation);
            this.form4_tabpage_createrezervations.Controls.Add(this.form4_label_checkoutdate);
            this.form4_tabpage_createrezervations.Controls.Add(this.form4_dtp_checkout);
            this.form4_tabpage_createrezervations.Controls.Add(this.form4_label_checkindate);
            this.form4_tabpage_createrezervations.Controls.Add(this.form4_label_roomid);
            this.form4_tabpage_createrezervations.Controls.Add(this.form4_dtp_checkin);
            this.form4_tabpage_createrezervations.Location = new System.Drawing.Point(4, 25);
            this.form4_tabpage_createrezervations.Margin = new System.Windows.Forms.Padding(4);
            this.form4_tabpage_createrezervations.Name = "form4_tabpage_createrezervations";
            this.form4_tabpage_createrezervations.Padding = new System.Windows.Forms.Padding(4);
            this.form4_tabpage_createrezervations.Size = new System.Drawing.Size(690, 327);
            this.form4_tabpage_createrezervations.TabIndex = 0;
            this.form4_tabpage_createrezervations.Text = "Create Rezervation";
            this.form4_tabpage_createrezervations.UseVisualStyleBackColor = true;
            // 
            // form4_cb_roomnumber
            // 
            this.form4_cb_roomnumber.FormattingEnabled = true;
            this.form4_cb_roomnumber.Location = new System.Drawing.Point(262, 74);
            this.form4_cb_roomnumber.Margin = new System.Windows.Forms.Padding(4);
            this.form4_cb_roomnumber.Name = "form4_cb_roomnumber";
            this.form4_cb_roomnumber.Size = new System.Drawing.Size(265, 24);
            this.form4_cb_roomnumber.TabIndex = 15;
            this.form4_cb_roomnumber.SelectedIndexChanged += new System.EventHandler(this.form4_cb_roomnumber_SelectedIndexChanged);
            // 
            // form4_cb_username
            // 
            this.form4_cb_username.FormattingEnabled = true;
            this.form4_cb_username.Location = new System.Drawing.Point(262, 31);
            this.form4_cb_username.Margin = new System.Windows.Forms.Padding(4);
            this.form4_cb_username.Name = "form4_cb_username";
            this.form4_cb_username.Size = new System.Drawing.Size(265, 24);
            this.form4_cb_username.TabIndex = 14;
            // 
            // form4_label_rezervationprice
            // 
            this.form4_label_rezervationprice.AutoSize = true;
            this.form4_label_rezervationprice.Location = new System.Drawing.Point(142, 207);
            this.form4_label_rezervationprice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.form4_label_rezervationprice.Name = "form4_label_rezervationprice";
            this.form4_label_rezervationprice.Size = new System.Drawing.Size(120, 17);
            this.form4_label_rezervationprice.TabIndex = 13;
            this.form4_label_rezervationprice.Text = "Rezervation Price";
            // 
            // form4_textPrice
            // 
            this.form4_textPrice.Location = new System.Drawing.Point(262, 203);
            this.form4_textPrice.Margin = new System.Windows.Forms.Padding(4);
            this.form4_textPrice.Name = "form4_textPrice";
            this.form4_textPrice.ReadOnly = true;
            this.form4_textPrice.Size = new System.Drawing.Size(265, 22);
            this.form4_textPrice.TabIndex = 12;
            // 
            // form4_tabpage_createuser
            // 
            this.form4_tabpage_createuser.Controls.Add(this.form4_text_lastname);
            this.form4_tabpage_createuser.Controls.Add(this.form4_text_firstname);
            this.form4_tabpage_createuser.Controls.Add(this.form4_text_usertypeid);
            this.form4_tabpage_createuser.Controls.Add(this.form4_label_usertypeid);
            this.form4_tabpage_createuser.Controls.Add(this.form4_label_firstname);
            this.form4_tabpage_createuser.Controls.Add(this.form4_label_lastname);
            this.form4_tabpage_createuser.Controls.Add(this.form1_label_password);
            this.form4_tabpage_createuser.Controls.Add(this.form4_text_password);
            this.form4_tabpage_createuser.Controls.Add(this.form4_button_createuser);
            this.form4_tabpage_createuser.Controls.Add(this.form4_text_username);
            this.form4_tabpage_createuser.Controls.Add(this.form1_label_username);
            this.form4_tabpage_createuser.Location = new System.Drawing.Point(4, 25);
            this.form4_tabpage_createuser.Margin = new System.Windows.Forms.Padding(4);
            this.form4_tabpage_createuser.Name = "form4_tabpage_createuser";
            this.form4_tabpage_createuser.Padding = new System.Windows.Forms.Padding(4);
            this.form4_tabpage_createuser.Size = new System.Drawing.Size(690, 327);
            this.form4_tabpage_createuser.TabIndex = 1;
            this.form4_tabpage_createuser.Text = "Create User";
            this.form4_tabpage_createuser.UseVisualStyleBackColor = true;
            // 
            // form4_text_lastname
            // 
            this.form4_text_lastname.Location = new System.Drawing.Point(307, 191);
            this.form4_text_lastname.Margin = new System.Windows.Forms.Padding(4);
            this.form4_text_lastname.Name = "form4_text_lastname";
            this.form4_text_lastname.Size = new System.Drawing.Size(132, 22);
            this.form4_text_lastname.TabIndex = 13;
            // 
            // form4_text_firstname
            // 
            this.form4_text_firstname.Location = new System.Drawing.Point(307, 147);
            this.form4_text_firstname.Margin = new System.Windows.Forms.Padding(4);
            this.form4_text_firstname.Name = "form4_text_firstname";
            this.form4_text_firstname.Size = new System.Drawing.Size(132, 22);
            this.form4_text_firstname.TabIndex = 12;
            // 
            // form4_text_usertypeid
            // 
            this.form4_text_usertypeid.Location = new System.Drawing.Point(307, 104);
            this.form4_text_usertypeid.Margin = new System.Windows.Forms.Padding(4);
            this.form4_text_usertypeid.Name = "form4_text_usertypeid";
            this.form4_text_usertypeid.Size = new System.Drawing.Size(132, 22);
            this.form4_text_usertypeid.TabIndex = 11;
            // 
            // form4_label_usertypeid
            // 
            this.form4_label_usertypeid.AutoSize = true;
            this.form4_label_usertypeid.Location = new System.Drawing.Point(208, 107);
            this.form4_label_usertypeid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.form4_label_usertypeid.Name = "form4_label_usertypeid";
            this.form4_label_usertypeid.Size = new System.Drawing.Size(91, 17);
            this.form4_label_usertypeid.TabIndex = 10;
            this.form4_label_usertypeid.Text = "User Type ID";
            // 
            // form4_label_firstname
            // 
            this.form4_label_firstname.AutoSize = true;
            this.form4_label_firstname.Location = new System.Drawing.Point(208, 150);
            this.form4_label_firstname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.form4_label_firstname.Name = "form4_label_firstname";
            this.form4_label_firstname.Size = new System.Drawing.Size(76, 17);
            this.form4_label_firstname.TabIndex = 9;
            this.form4_label_firstname.Text = "First Name";
            // 
            // form4_label_lastname
            // 
            this.form4_label_lastname.AutoSize = true;
            this.form4_label_lastname.Location = new System.Drawing.Point(208, 195);
            this.form4_label_lastname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.form4_label_lastname.Name = "form4_label_lastname";
            this.form4_label_lastname.Size = new System.Drawing.Size(76, 17);
            this.form4_label_lastname.TabIndex = 8;
            this.form4_label_lastname.Text = "Last Name";
            // 
            // form1_label_password
            // 
            this.form1_label_password.AutoSize = true;
            this.form1_label_password.Location = new System.Drawing.Point(208, 64);
            this.form1_label_password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.form1_label_password.Name = "form1_label_password";
            this.form1_label_password.Size = new System.Drawing.Size(69, 17);
            this.form1_label_password.TabIndex = 7;
            this.form1_label_password.Text = "Password";
            // 
            // form4_text_password
            // 
            this.form4_text_password.Location = new System.Drawing.Point(307, 60);
            this.form4_text_password.Margin = new System.Windows.Forms.Padding(4);
            this.form4_text_password.Name = "form4_text_password";
            this.form4_text_password.Size = new System.Drawing.Size(132, 22);
            this.form4_text_password.TabIndex = 6;
            // 
            // form4_button_createuser
            // 
            this.form4_button_createuser.AutoSize = true;
            this.form4_button_createuser.Location = new System.Drawing.Point(212, 253);
            this.form4_button_createuser.Margin = new System.Windows.Forms.Padding(4);
            this.form4_button_createuser.Name = "form4_button_createuser";
            this.form4_button_createuser.Size = new System.Drawing.Size(227, 33);
            this.form4_button_createuser.TabIndex = 5;
            this.form4_button_createuser.Text = "Create User";
            this.form4_button_createuser.UseVisualStyleBackColor = true;
            this.form4_button_createuser.Click += new System.EventHandler(this.form4_button_createuser_Click);
            // 
            // form4_text_username
            // 
            this.form4_text_username.Location = new System.Drawing.Point(307, 15);
            this.form4_text_username.Margin = new System.Windows.Forms.Padding(4);
            this.form4_text_username.Name = "form4_text_username";
            this.form4_text_username.Size = new System.Drawing.Size(132, 22);
            this.form4_text_username.TabIndex = 4;
            // 
            // form1_label_username
            // 
            this.form1_label_username.AutoSize = true;
            this.form1_label_username.Location = new System.Drawing.Point(208, 19);
            this.form1_label_username.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.form1_label_username.Name = "form1_label_username";
            this.form1_label_username.Size = new System.Drawing.Size(73, 17);
            this.form1_label_username.TabIndex = 3;
            this.form1_label_username.Text = "Username";
            // 
            // form4_tabpage_deleterezervations
            // 
            this.form4_tabpage_deleterezervations.Controls.Add(this.form4_button_deleterezervation);
            this.form4_tabpage_deleterezervations.Controls.Add(this.form4_datagridview);
            this.form4_tabpage_deleterezervations.Location = new System.Drawing.Point(4, 25);
            this.form4_tabpage_deleterezervations.Margin = new System.Windows.Forms.Padding(4);
            this.form4_tabpage_deleterezervations.Name = "form4_tabpage_deleterezervations";
            this.form4_tabpage_deleterezervations.Padding = new System.Windows.Forms.Padding(4);
            this.form4_tabpage_deleterezervations.Size = new System.Drawing.Size(690, 327);
            this.form4_tabpage_deleterezervations.TabIndex = 2;
            this.form4_tabpage_deleterezervations.Text = "Rezervations";
            this.form4_tabpage_deleterezervations.UseVisualStyleBackColor = true;
            // 
            // form4_button_deleterezervation
            // 
            this.form4_button_deleterezervation.Location = new System.Drawing.Point(242, 271);
            this.form4_button_deleterezervation.Margin = new System.Windows.Forms.Padding(4);
            this.form4_button_deleterezervation.Name = "form4_button_deleterezervation";
            this.form4_button_deleterezervation.Size = new System.Drawing.Size(191, 28);
            this.form4_button_deleterezervation.TabIndex = 2;
            this.form4_button_deleterezervation.Text = "Delete Reservation";
            this.form4_button_deleterezervation.UseVisualStyleBackColor = true;
            this.form4_button_deleterezervation.Click += new System.EventHandler(this.form4_button_deleterezervation_Click);
            // 
            // form4_datagridview
            // 
            this.form4_datagridview.AllowUserToAddRows = false;
            this.form4_datagridview.AllowUserToDeleteRows = false;
            this.form4_datagridview.AllowUserToResizeColumns = false;
            this.form4_datagridview.AllowUserToResizeRows = false;
            this.form4_datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.form4_datagridview.Location = new System.Drawing.Point(76, 8);
            this.form4_datagridview.Margin = new System.Windows.Forms.Padding(4);
            this.form4_datagridview.MultiSelect = false;
            this.form4_datagridview.Name = "form4_datagridview";
            this.form4_datagridview.ReadOnly = true;
            this.form4_datagridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.form4_datagridview.Size = new System.Drawing.Size(547, 246);
            this.form4_datagridview.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.form4_button_checkout);
            this.tabPage1.Controls.Add(this.form4_datagridview2);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(690, 327);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Check Out";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // form4_button_checkout
            // 
            this.form4_button_checkout.Location = new System.Drawing.Point(257, 273);
            this.form4_button_checkout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.form4_button_checkout.Name = "form4_button_checkout";
            this.form4_button_checkout.Size = new System.Drawing.Size(181, 27);
            this.form4_button_checkout.TabIndex = 1;
            this.form4_button_checkout.Text = "Check Out User";
            this.form4_button_checkout.UseVisualStyleBackColor = true;
            this.form4_button_checkout.Click += new System.EventHandler(this.button1_Click);
            // 
            // form4_datagridview2
            // 
            this.form4_datagridview2.AllowUserToAddRows = false;
            this.form4_datagridview2.AllowUserToDeleteRows = false;
            this.form4_datagridview2.AllowUserToResizeColumns = false;
            this.form4_datagridview2.AllowUserToResizeRows = false;
            this.form4_datagridview2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.form4_datagridview2.Location = new System.Drawing.Point(74, 16);
            this.form4_datagridview2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.form4_datagridview2.MultiSelect = false;
            this.form4_datagridview2.Name = "form4_datagridview2";
            this.form4_datagridview2.ReadOnly = true;
            this.form4_datagridview2.RowTemplate.Height = 24;
            this.form4_datagridview2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.form4_datagridview2.Size = new System.Drawing.Size(545, 238);
            this.form4_datagridview2.TabIndex = 0;
            // 
            // form4_label_user
            // 
            this.form4_label_user.AutoSize = true;
            this.form4_label_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.form4_label_user.Location = new System.Drawing.Point(532, 2);
            this.form4_label_user.Name = "form4_label_user";
            this.form4_label_user.Size = new System.Drawing.Size(94, 20);
            this.form4_label_user.TabIndex = 14;
            this.form4_label_user.Text = "Hello User!";
            // 
            // form4_button_logout
            // 
            this.form4_button_logout.Location = new System.Drawing.Point(432, 0);
            this.form4_button_logout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.form4_button_logout.Name = "form4_button_logout";
            this.form4_button_logout.Size = new System.Drawing.Size(75, 28);
            this.form4_button_logout.TabIndex = 13;
            this.form4_button_logout.Text = "Log out";
            this.form4_button_logout.UseVisualStyleBackColor = true;
            this.form4_button_logout.Click += new System.EventHandler(this.logut_button_admin_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 378);
            this.Controls.Add(this.form4_label_user);
            this.Controls.Add(this.form4_button_logout);
            this.Controls.Add(this.form4_tabcontrol);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form4";
            this.Text = "Form4";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form4_FormClosed);
            this.form4_tabcontrol.ResumeLayout(false);
            this.form4_tabpage_createrezervations.ResumeLayout(false);
            this.form4_tabpage_createrezervations.PerformLayout();
            this.form4_tabpage_createuser.ResumeLayout(false);
            this.form4_tabpage_createuser.PerformLayout();
            this.form4_tabpage_deleterezervations.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.form4_datagridview)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.form4_datagridview2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button form4_button_createrezervation;
        private System.Windows.Forms.Label form4_label_username;
        private System.Windows.Forms.Label form4_label_roomid;
        private System.Windows.Forms.Label form4_label_checkindate;
        private System.Windows.Forms.Label form4_label_checkoutdate;
        private System.Windows.Forms.DateTimePicker form4_dtp_checkin;
        private System.Windows.Forms.DateTimePicker form4_dtp_checkout;
        private System.Windows.Forms.TabControl form4_tabcontrol;
        private System.Windows.Forms.TabPage form4_tabpage_createrezervations;
        private System.Windows.Forms.TabPage form4_tabpage_createuser;
        private System.Windows.Forms.Label form4_label_rezervationprice;
        private System.Windows.Forms.TextBox form4_textPrice;
        private System.Windows.Forms.Label form1_label_username;
        private System.Windows.Forms.TextBox form4_text_username;
        private System.Windows.Forms.Button form4_button_createuser;
        private System.Windows.Forms.TextBox form4_text_password;
        private System.Windows.Forms.Label form1_label_password;
        private System.Windows.Forms.TextBox form4_text_lastname;
        private System.Windows.Forms.TextBox form4_text_firstname;
        private System.Windows.Forms.TextBox form4_text_usertypeid;
        private System.Windows.Forms.Label form4_label_usertypeid;
        private System.Windows.Forms.Label form4_label_firstname;
        private System.Windows.Forms.Label form4_label_lastname;
        private System.Windows.Forms.TabPage form4_tabpage_deleterezervations;
        private System.Windows.Forms.Button form4_button_deleterezervation;
        private System.Windows.Forms.DataGridView form4_datagridview;
        private System.Windows.Forms.ComboBox form4_cb_roomnumber;
        private System.Windows.Forms.ComboBox form4_cb_username;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button form4_button_checkout;
        private System.Windows.Forms.DataGridView form4_datagridview2;
        private System.Windows.Forms.Label form4_label_user;
        private System.Windows.Forms.Button form4_button_logout;
    }
}