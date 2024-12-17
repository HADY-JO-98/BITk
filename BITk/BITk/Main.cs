using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BITk
{
    //line 193 & 204 have ttwo functions incomplete.
    public partial class Main : Form
    {
        Admin a1;
        DataBase db1;
        private string v;
        private string username;
        private DataBase dataBase;
        public Main(DataBase db1, string username)
        {
            InitializeComponent();
            this.Show();
            this.db1 = db1;
            this.username = username;
            init_admin(username);
            form_initialization_data();

        }

        public Main(string v, string username, DataBase dataBase, DataBase db1)
        {
            this.v = v;
            this.username = username;
            this.dataBase = dataBase;
            this.db1 = db1;
        }

        public Main(string username, DataBase db1)
        {
            this.username = username;
            this.db1 = db1;
        }

        private void init_admin(string username)
        {
            String db_command = "SELECT * FROM [Hotel].[dbo].[Users] Where username='" + username + "'";
            DataSet ds1 = db1.Read(db_command);
            DataRow dr1 = ds1.Tables[0].Rows[0];
            this.a1 = new Admin(int.Parse(dr1["UserID"].ToString()), dr1["FirstName"].ToString(), dr1["LastName"].ToString(), this.db1);
        }
        public void form_initialization_data()
        {
            label_user.Text = "Hello, '"+a1.getname()+"'!";
            a1.dataset_populate("SELECT UserID AS Id, firstName AS 'First Name', lastName AS 'Last Name', username AS Username,password AS Password FROM [Hotel].[dbo].[Users] WHERE UserTypeID=1", dataGridView1);
            a1.dataset_populate("SELECT UserID AS Id, firstName AS 'First Name', lastName AS 'Last Name', username AS Username,password AS Password FROM [Hotel].[dbo].[Users] WHERE UserTypeID=3", dataGridView2);
            a1.dataset_populate("SELECT UserID AS Id, firstName AS 'First Name', lastName AS 'Last Name', username AS Username,password AS Password FROM [Hotel].[dbo].[Users] WHERE UserTypeID=4", dataGridView3);
            a1.dataset_populate("SELECT UserID AS Id, firstName AS 'First Name', lastName AS 'Last Name', username AS Username,password AS Password FROM [Hotel].[dbo].[Users] WHERE UserTypeID=2", dataGridView4);
            init_statistics();
        }

        public void init_statistics()
        {
            a1.statistic_income(textBox1, textBox2);
            a1.statistic_customers(textBox3, textBox4);
            a1.statistic_totals(textBox5, textBox6, textBox7, textBox9);
            a1.cleaned_rooms(textBox11);
            a1.statistics_rooms(textBox12, textBox13);
        }

        private void _Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Drawing2D.LinearGradientBrush gradientBrush = new System.Drawing.Drawing2D.LinearGradientBrush(this.ClientRectangle, Color.Beige, Color.DarkGreen, System.Drawing.Drawing2D.LinearGradientMode.Vertical);
            e.Graphics.FillRectangle(gradientBrush, this.ClientRectangle);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            a1.adding_user(textBox1, textBox2, textBox3, textBox4, 1);
            form_initialization_data();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            a1.delete_user(dataGridView1);
            form_initialization_data();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            a1.modify_user(dataGridView1, textBox1, textBox2, textBox3, textBox4);
            form_initialization_data();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            a1.promote_admin(dataGridView1);
            form_initialization_data();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            a1.dataset_select(dataGridView1, textBox1, textBox2, textBox3, textBox4);
        }

        private void button6_click(object sender, EventArgs e)
        {
            a1.dataset_select(dataGridView2, textBox5, textBox6, textBox7, textBox8);
        }

        private void button7_click(object sender, EventArgs e)
        {
            a1.promote_admin(dataGridView2);
            form_initialization_data();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            a1.modify_user(dataGridView2, textBox5, textBox6, textBox7, textBox8);
            form_initialization_data();
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            a1.delete_user(dataGridView2);
            form_initialization_data();
        }

        private void button10_click(object sender, EventArgs e)
        {
            a1.adding_user( textBox5, textBox6, textBox7, textBox8, 3);
            form_initialization_data();
        }

        private void button11_click(object sender, EventArgs e)
        {
            a1.dataset_select(dataGridView3, textBox9, textBox10, textBox11, textBox12);
        }

        private void button12_click(object sender, EventArgs e)
        {
            a1.promote_admin(dataGridView3);
            form_initialization_data();
        }

        private void button13_click(object sender, EventArgs e)
        {
            a1.modify_user(dataGridView3, textBox9, textBox10, textBox11, textBox12);
            form_initialization_data();
        }

        private void button14_click(object sender, EventArgs e)
        {
            a1.delete_user(dataGridView3);
            form_initialization_data();
        }

        private void button15_click(object sender, EventArgs e)
        {
            a1.adding_user(textBox9, textBox10, textBox11, textBox12, 4);
            form_initialization_data();
        }

        private void button16_click(object sender, EventArgs e)
        {
            a1.dataset_select(dataGridView4, textBox13, textBox14, textBox15, textBox16);
        }

        private void button17_click(object sender, EventArgs e)
        {
            a1.promote_admin(dataGridView4);
            form_initialization_data();
        }

        private void button18_click(object sender, EventArgs e)
        {
            a1.modify_user(dataGridView4, textBox13, textBox14, textBox15, textBox16);
        }

        private void button19_click(object sender, EventArgs e)
        {
            a1.delete_user(dataGridView4);
            form_initialization_data();
        }

        private void button20_click(object sender, EventArgs e)
        {
            a1.adding_user(textBox13, textBox14, textBox15, textBox16, 2);
            form_initialization_data();
        }

        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            a1.prices_selected(dataGridView6, form2_Prices_NewPrice);
        }

        private void form2_UpdatePricesBtn_Prices_Click(object sender, EventArgs e)
        {
            a1.prices_new_update(dataGridView3, form2_Prices_NewPrice);
            form_initialization_data();
        }

        private void dataGridView6_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string type = comboBox1.Text;
            a1.populate_discount_drop_room(comboBox2, textBox18, type);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button22_Click(object sender, EventArgs e)
        {
            a1.add_discount(comboBox2, textBox18);
            form_initialization_data();
        }

        private void form2_Rez_Delete_Click(object sender, EventArgs e)
        {
            a1.delete_rezervation(dataGridView5);
            form_initialization_data();
        }

        private void dataGridView9_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            a1.populate_user_reservation(dataGridView9, dataGridView8);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            a1.assign_cleaning(dataGridView12, dataGridView11);
            form_initialization_data();
            a1.populate_assigned_rooms(dataGridView12, dataGridView10);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            a1.auto_assign_cleaning();
            form_initialization_data();
            a1.populate_assigned_rooms(dataGridView12, dataGridView10);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            a1.delete_assignment(dataGridView10);
            form_initialization_data();
            a1.populate_assigned_rooms(dataGridView12, dataGridView10);
        }

        private void logut_button_admin_Click(object sender, EventArgs e)
        {
            Signning signning = new Signning(this.db1);
            this.Hide();
            signning.Show();
        }
    }
}
