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
    public partial class Form7 : Form
    {
        Users u1;
        Database db1;
        public Form7(Users u1)
        {
            InitializeComponent();
            this.u1 = u1;
            this.Show();
            u1.init_form7_fields(form7_cb_roomType, form7_cb_price, form7_cb_roomCap,Form7_label_name);
            this.db1 = u1.getDB();
            form7_dtp_start.MinDate = DateTime.UtcNow;
            form7_dtp_end.MinDate = form7_dtp_start.MinDate.AddDays(1);
        }

        private void form7_llabel_signout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            u1.log_out(0);
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
                Form8 f8 = new Form8(u1, number, form7_dtp_start.Value.Date, form7_dtp_end.Value.Date);
                Form7.ActiveForm.Hide();
                f8.Show();
            }
            else
            {
                MessageBox.Show("Please select a value!");
            }

        }

        private void Form7_label_name_Click(object sender, EventArgs e)
        {

        }

        private void form7_dtp_start_ValueChanged(object sender, EventArgs e)
        {
            form7_dtp_end.MinDate = form7_dtp_start.Value.AddDays(1);
        }

        private void form7_dtp_end_ValueChanged(object sender, EventArgs e)
        {
            //form7_dtp_start.MaxDate = form7_dtp_end.Value.AddDays(-1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5(u1.getusername(), u1.getDB());
            f5.Show();
            this.Hide();
        }

        private void Form7_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

      
        
    }
}
