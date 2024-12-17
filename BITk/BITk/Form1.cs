using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;

namespace BITk
{
    public partial class Form1 : Form
    {
        Users u1;
        DataBase db1;
        private string v;
        private DataBase dataBase;

        public Form1(DataBase db1,string username)
        {
            InitializeComponent();
            this.Show();
            this.db1 = db1;
            init_user(username);
            Form5_label_name.Text = u1.get_user();
            u1.list_current_rezervation(Form5_label_name);
        }

        public Form1(string v, DataBase dataBase)
        {
            this.v = v;
            this.dataBase = dataBase;
        }

        public void init_user(String username)
        {
            String db_command = "SELECT * FROM [Hotel].[dbo].[Users] Where username='" + username + "'";
            DataSet ds1 = db1.Read(db_command);
            DataRow dr1 = ds1.Tables[0].Rows[0];
            this.u1 = new Users(int.Parse(dr1["UserID"].ToString()), dr1["firstName"].ToString(), dr1["lastName"].ToString(), dr1["username"].ToString(), this.db1, Form5_label_name);
        }
        private void form5_llabel_signout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            u1.log_out(1);
        }
        private void form5_btn_getRes_Click(object sender, EventArgs e)
        {
            u1.list_current_rezervation(Form5_label_name);
        }
        private void form5_btn_cancelRes_Click(object sender, EventArgs e)
        {
            u1.cancel_reservation(Form5_lb);
            u1.list_current_rezervation(Form5_label_name);
        }
        private void form5_btn_newRes_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3(u1);
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

        private void Form5_label_name_Click(object sender, EventArgs e)
        {

        }
    }
}