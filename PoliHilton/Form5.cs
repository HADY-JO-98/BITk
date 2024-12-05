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
    public partial class Form5 : Form
    {
        //every button must call a function of the class that controlls it : required by Prof
        //is based on users, Iza needs to implement the creation of Booking and the req fuctions
        Users u1;
        Database db1;
        public Form5(String username,Database db1)
        {
            InitializeComponent();
            this.Show();
            this.db1 = db1;
            init_user(username);
            Form5_label_name.Text = u1.getUser();
            u1.list_current_reservations(Form5_lb);
        }

        public void init_user(String username)
        {
            String db_command = "SELECT * FROM [polihilton].[dbo].[Users] Where username='" + username + "'";
            DataSet ds1 = db1.Read(db_command);
            DataRow dr1 = ds1.Tables[0].Rows[0];
            this.u1 = new Users(int.Parse(dr1["u_id"].ToString()), dr1["firstName"].ToString(), dr1["lastName"].ToString(), dr1["username"].ToString(), this.db1, Form5_label_name);
        }

      

        private void form5_llabel_signout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            u1.log_out(1);
        }

        private void form5_btn_getRes_Click(object sender, EventArgs e)
        {
            u1.list_current_reservations(Form5_lb);
        }

        private void form5_btn_cancelRes_Click(object sender, EventArgs e)
        {
            u1.cancel_reservation(Form5_lb);
            u1.list_current_reservations(Form5_lb);
        }
        
        private void form5_btn_newRes_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7(u1);
            this.Hide();
      
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("WPF Format");
        }

        private void Form5_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

    }
}
