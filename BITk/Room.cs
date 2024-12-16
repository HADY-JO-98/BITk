using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BITk
{
    public partial class Room : Form
    {
        Cleaning clean1;
        DataBase db1;
        public Room(string username, DataBase db1)
        {
            InitializeComponent();
            this.db1 = db1;
            init_cleaner(username);
            clean1.list_assigned_rooms(form3_lb);
        }

        public void init_cleaner(String username)
        {
            String db_command = "SELECT * FROM [Hotel].[dbo].[Users] Where username='" + username + "'";
            DataSet ds1 = db1.Read(db_command);
            DataRow dr1 = ds1.Tables[0].Rows[0];
            this.clean1 = new Cleaning(int.Parse(dr1["UserID"].ToString()), dr1["firstName"].ToString(), dr1["lastName"].ToString(), dr1["username"].ToString(), this.db1, Form3_label_name);
        }

        private void form3_llabel_signout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            clean1.log_out();
        }
    }
}
