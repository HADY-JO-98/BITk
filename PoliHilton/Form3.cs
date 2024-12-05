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
    public partial class Form3 : Form
    {
       Cleaning clean1;
       Database db1;
       //every button must call a function of the class that controlls it : required by Prof
        //Final form only log out required
        public Form3(String username,Database db1)
        {
            InitializeComponent();
            this.db1 = db1;
            this.Show();
            init_cleaner(username);
            clean1.list_assigned_rooms(form3_lb);

        }

        public void init_cleaner(String username)
        {
            String db_command = "SELECT * FROM [polihilton].[dbo].[Users] Where username='" + username + "'";
            DataSet ds1 = db1.Read(db_command);
            DataRow dr1 = ds1.Tables[0].Rows[0];
            this.clean1 = new Cleaning(int.Parse(dr1["u_id"].ToString()), dr1["firstName"].ToString(), dr1["lastName"].ToString(),dr1["username"].ToString(), this.db1,Form3_label_name);
            
        }

        private void form3_btn_asigne_Click(object sender, EventArgs e)
        {
            clean1.list_assigned_rooms(form3_lb);
        }

        private void form3_btn_submit_Click(object sender, EventArgs e)
        {
            // get info from dataset to clean1.cleaned(int roomid)
        }
        
        private void form3_btn_inProgress_Click(object sender, EventArgs e)
        {
            clean1.in_progress(form3_lb);
            clean1.list_assigned_rooms(form3_lb);
        }

        private void form3_btn_cleaned_Click(object sender, EventArgs e)
        {
            clean1.cleaned(form3_lb);
            clean1.list_assigned_rooms(form3_lb);
        

        }

        private void form3_llabel_signout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            clean1.log_out();
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
