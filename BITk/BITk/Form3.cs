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
    public partial class Form3 : Form
    {
        Users u1;
        DataBase db1;
        private int number;
        private DateTime date1;
        private DateTime date2;

        public Form3(Users u1)
        {
            InitializeComponent();
            this.u1 = u1;
            this.Show();
            u1.init_form7_fields(form7_cb_roomType, form7_cb_price, form7_cb_roomCap, Form7_label_name);
            this.db1 = u1.getDB();
            form7_dtp_start.MinDate = DateTime.UtcNow;
            form7_dtp_end.MinDate = form7_dtp_start.MinDate.AddDays(1);
        }

        public Form3(Users u1, int number, DateTime date1, DateTime date2) : this(u1)
        {
            this.number = number;
            this.date1 = date1;
            this.date2 = date2;
        }

        private void form7_dtp_start_ValueChanged(object sender, EventArgs e)
        {
            form7_dtp_end.MinDate = form7_dtp_start.Value.AddDays(1);
        }
        private void form7_dtp_end_ValueChanged(object sender, EventArgs e)
        {
            form7_dtp_start.MaxDate = form7_dtp_end.Value.AddDays(-1);
        }
        private void form7_btn_search_Click(object sender, EventArgs e)
        {
            u1.search_rooms(form7_cb_roomType, form7_cb_price, form7_cb_roomCap, form7_dtp_start, form7_dtp_end, Form7_lb);
        }
        private void Form7_btn_reserve_Click(object sender, EventArgs e)
        {
            if (Form7_lb.SelectedIndex != -1)
            {
                int number = u1.reserve_room(Form7_lb);
                Form4 f4 = new Form4(u1, number, form7_dtp_start.Value.Date, form7_dtp_end.Value.Date);
                Form3.ActiveForm.Hide();
                f4.Show();
            }
            else
            {
                MessageBox.Show("Please select a value!");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1(u1.get_username(), u1.getDB());
            f1.Show();
            this.Hide();
        }
        private void Form7_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}