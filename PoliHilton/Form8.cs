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
    public partial class Form8 : Form
    {
        Users u1;
        int room_number;
        DateTime startDate;
        DateTime endDate;
        public Form8(Users u1,int room_number,DateTime s,DateTime e)
        {
            InitializeComponent();
            this.u1 = u1;
            this.room_number = room_number;
            this.Show();
            this.startDate = s;
            this.endDate = e;
            textBox2.Text= endDate.ToShortDateString();
            textBox1.Text = startDate.ToShortDateString();
            u1.fill_room_fields_final(form8_tb_roomName, form8_tb_roomNo, form8_tb_roomFloor, form8_tb_roomCap, form8_tb_roomSurface,form8_tb_roomOrientation,form8_tb_roomPrice,form8_tb_roomDisc,form8_tb_total,room_number);
        }

        private void form8_tb_roomName_TextChanged(object sender, EventArgs e)
        {

        }

        private void form8_btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void form8_btn_reserve_Click(object sender, EventArgs e)
        {
            int result=u1.final_reserver_form8(form8_tb_roomNo, textBox1, textBox2,form8_tb_total);
            if (result == 1)
            {
                MessageBox.Show("Successfully Reserved");
            }
            else
            {
                MessageBox.Show("There is already a reservation for that room for that date");
            }
            this.Close();
        }


    }

}
