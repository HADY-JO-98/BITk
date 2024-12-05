using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoliHilton
{
    public partial class Form4 : Form
    {
        //every button must call a function of the class that controlls it : required by Prof
        //Final form only log out required
       Reception r1;
       Database db1;
        public Form4(String username,Database db1)
        {
            InitializeComponent();
            this.db1 = db1;
            this.Show();
            init_reception(username);
            r1.reception_dataset_populate_rname(form4_cb_roomnumber);
            r1.reception_dataset_populate_uname(form4_cb_username);
            r1.reception_dataset_populate(form4_datagridview);
            r1.reception_dataset_populate(form4_datagridview2);
            form4_label_user.Text = "Hello " + r1.user_info() + " !";
            form4_dtp_checkin.MinDate = DateTime.UtcNow;
            form4_dtp_checkout.MinDate = form4_dtp_checkin.MinDate.AddDays(1); ;

        }

        public void init_reception(String username)
        {
            String db_command = "SELECT * FROM [polihilton].[dbo].[Users] Where username='" + username + "'";
            DataSet ds1 = db1.Read(db_command);
            DataRow dr1 = ds1.Tables[0].Rows[0];
            this.r1 = new Reception(int.Parse(dr1["u_id"].ToString()), dr1["firstName"].ToString(), dr1["lastName"].ToString(), this.db1);
        }

     

        private void form4_button_createrezervation_Click(object sender, EventArgs e)
        {
            if (form4_cb_roomnumber.SelectedIndex >= 0 && form4_cb_username.SelectedIndex>=0)
            {
                form4_textPrice.Text = r1.calculate_price(int.Parse(form4_cb_roomnumber.SelectedItem.ToString())).ToString();
                DateTime check_in = form4_dtp_checkin.Value.Date; 
                DateTime check_out = form4_dtp_checkout.Value.Date;
                int uid=r1.return_uid(form4_cb_username.SelectedItem.ToString());
                int rid = r1.return_rid(int.Parse(form4_cb_roomnumber.SelectedItem.ToString()));
                r1.create_rezervation(rid, uid, check_in, check_out, int.Parse(form4_textPrice.Text));
                r1.reception_dataset_populate(form4_datagridview);
                r1.reception_dataset_populate(form4_datagridview2);
                
            }
            else
            {
                MessageBox.Show("You must select the room and the username");
            }
        }

        private void form4_button_createuser_Click(object sender, EventArgs e)
        {
            //in case u dont input a usertype it will be by default =1
            if (form4_text_usertypeid.Text == "")
            {
                form4_text_usertypeid.Text="1";
            }
                r1.create_user(form4_text_username.Text, form4_text_password.Text, form4_text_firstname.Text, form4_text_lastname.Text, int.Parse(form4_text_usertypeid.Text));
                form4_cb_username.Items.Clear();
                r1.reception_dataset_populate_uname(form4_cb_username);
        }

        private void form4_button_showrezervations_Click(object sender, EventArgs e)
        {
            r1.reception_dataset_populate(form4_datagridview);
        }

        private void form4_button_deleterezervation_Click(object sender, EventArgs e)
        {
            r1.delete_rezervation(form4_datagridview);
            r1.reception_dataset_populate(form4_datagridview);
            r1.reception_dataset_populate(form4_datagridview2);
        }

        private void form4_cb_roomnumber_SelectedIndexChanged(object sender, EventArgs e)
        {
             form4_textPrice.Text=r1.calculate_price(int.Parse(form4_cb_roomnumber.SelectedItem.ToString())).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            r1.check_out(form4_datagridview2);
            r1.reception_dataset_populate(form4_datagridview);
            r1.reception_dataset_populate(form4_datagridview2);
        }

        private void logut_button_admin_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1(this.db1);
            f1.Show();
            this.Hide();
        }

        private void form4_dtp_checkin_ValueChanged(object sender, EventArgs e)
        {
            form4_dtp_checkout.MinDate = form4_dtp_checkin.Value.AddDays(1);
        }

        private void form4_dtp_checkout_ValueChanged(object sender, EventArgs e)
        {
            //form4_dtp_checkin.MaxDate = form4_dtp_checkout.Value.AddDays(-1);
            //creates errors solves itself
        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
