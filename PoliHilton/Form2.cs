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
    public partial class Form2 : Form
    {
        //every button must call a function of the class that controlls it : required by Prof
        //Lat form only log out required
        Admin a1;
        Database db1;
        public Form2(String username,Database db1)
        {
            InitializeComponent();
            this.Show();
            this.db1 = db1;
            init_admin(username);           
            form_initialization_data();
        }

        public void form_initialization_data()
        {
            label_user.Text="Hello "+a1.getName()+"!";
            a1.dataset_populate("SELECT u_id AS Id, firstName AS 'First Name', lastName AS 'Last Name', username AS Username,password AS Password FROM [polihilton].[dbo].[Users] WHERE u_type_id=3", form2_dataGridView_Cleaner);
            a1.dataset_populate("SELECT u_id AS Id, firstName AS 'First Name', lastName AS 'Last Name', username AS Username,password AS Password FROM [polihilton].[dbo].[Users] WHERE u_type_id=2", form2_dataGridView_Manager);
            a1.dataset_populate("SELECT u_id AS Id, firstName AS 'First Name', lastName AS 'Last Name', username AS Username,password AS Password FROM [polihilton].[dbo].[Users] WHERE u_type_id=1", form2_DataGridView_Customer);
            a1.dataset_populate("SELECT u_id AS Id, firstName AS 'First Name', lastName AS 'Last Name', username AS Username,password AS Password FROM [polihilton].[dbo].[Users] WHERE u_type_id=1", dataGridView6);
            a1.dataset_populate("SELECT u_id AS Id, firstName AS 'First Name', lastName AS 'Last Name', username AS Username,password AS Password FROM [polihilton].[dbo].[Users] WHERE u_type_id=4", form2_DataGridView_Reception);
            a1.prices_udpate(dataGridView3, dataGridView4);
            a1.room_info_update(dataGridView5);
            a1.populate_discount_drop_type(comboBox1);
            a1.dataset_populate("SELECT u_id AS Id, firstName AS 'First Name', lastName AS 'Last Name' FROM [polihilton].[dbo].[Users] WHERE u_type_id=3", dataGridView2);
            a1.populate_cleaning_assigned(dataGridView7);
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

        public void init_admin(String username)
        {
            String db_command = "SELECT * FROM [polihilton].[dbo].[Users] Where username='" + username + "'";
            DataSet ds1 = db1.Read(db_command);
            DataRow dr1 = ds1.Tables[0].Rows[0];
            this.a1 = new Admin(int.Parse(dr1["u_id"].ToString()), dr1["firstName"].ToString(), dr1["lastName"].ToString(), this.db1);
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void adToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void modificationToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void adsadaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void statisticToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void asdsaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void discountToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            a1.adding_user(form2_Cleaner_UserName, form2_Cleaner_Password, form2_Cleaner_FirstName, form2_Cleaner_LastName,3);
            form_initialization_data();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage8_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void form2_SelectBtn_Cleaner_Click(object sender, EventArgs e)
        {
            a1.dataset_select(form2_dataGridView_Cleaner, form2_Cleaner_FirstName, form2_Cleaner_LastName, form2_Cleaner_UserName, form2_Cleaner_Password);
        }

        private void logut_button_admin_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1(this.db1);
            this.Hide();
            f1.Show();
        }

        private void form2_dataGridView_Cleaner_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            a1.dataset_select(form2_dataGridView_Cleaner, form2_Cleaner_FirstName, form2_Cleaner_LastName, form2_Cleaner_UserName, form2_Cleaner_Password);
        }

        private void form2_SelectBtn_Manager_Click(object sender, EventArgs e)
        {
            a1.dataset_select(form2_dataGridView_Manager,textBox8, form2_Manager_LastName, form2_Manager_UserName, form2_Manager_Password);        
        }

        private void form2_dataGridView_Manager_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            a1.dataset_select(form2_dataGridView_Manager, textBox8, form2_Manager_LastName, form2_Manager_UserName, form2_Manager_Password);
        }

        private void form2_SelectBtn_Customer_Click(object sender, EventArgs e)
        {
            a1.dataset_select(form2_DataGridView_Customer, form2_Customer_FirstName, form2_Customer_LastName, form2_Customer_UserName, form2_Customer_Password);
        }

        private void form2_DataGridView_Customer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            a1.dataset_select(form2_DataGridView_Customer, form2_Customer_FirstName, form2_Customer_LastName, form2_Customer_UserName, form2_Customer_Password);
        }

        private void form2_DataGridView_Reception_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            a1.dataset_select(form2_DataGridView_Reception, form2_Reception_FirstName, form2_Reception_LastName, form2_Reception_UserName, form2_Reception_Password);
        }

        private void form2_SelectBtn_Reception_Click(object sender, EventArgs e)
        {
            a1.dataset_select(form2_DataGridView_Reception, form2_Reception_FirstName, form2_Reception_LastName, form2_Reception_UserName, form2_Reception_Password);
        }

        private void form2_AddNewBtn_Manager_Click(object sender, EventArgs e)
        {
            a1.adding_user(form2_Manager_UserName, form2_Manager_Password, textBox8, form2_Manager_LastName, 2);
            form_initialization_data();
        }

        private void form2_AddNewBtn_Customer_Click(object sender, EventArgs e)
        {
            a1.adding_user(form2_Customer_UserName, form2_Customer_Password, form2_Customer_FirstName, form2_Customer_LastName, 1);
            form_initialization_data();
        }

        private void form2_AddNewBtn_Reception_Click(object sender, EventArgs e)
        {
            a1.adding_user(form2_Reception_UserName, form2_Reception_Password, form2_Reception_FirstName, form2_Reception_LastName, 4);
            form_initialization_data();
        }

        private void form2_DeleteBtn_Cleaner_Click(object sender, EventArgs e)
        {
            a1.delete_user(form2_dataGridView_Cleaner);
            form_initialization_data();

        }

        private void form2_DeleteBtn_Manager_Click(object sender, EventArgs e)
        {
            a1.delete_user(form2_dataGridView_Manager);
            form_initialization_data();
        }

        private void form2_ModifyBtn_Customer_Click(object sender, EventArgs e)
        {
            a1.modify_user(form2_DataGridView_Customer, form2_Customer_FirstName, form2_Customer_LastName, form2_Customer_UserName, form2_Customer_Password);
            form_initialization_data();
        }

        private void form2_DeleteBtn_Reception_Click(object sender, EventArgs e)
        {
            a1.delete_user(form2_DataGridView_Reception);
            form_initialization_data();
        }

        private void form2_DeleteBtn_Customer_Click(object sender, EventArgs e)
        {
            a1.delete_user(form2_DataGridView_Customer);
            form_initialization_data();
        }

        private void form2_ModifyBtn_Cleaner_Click(object sender, EventArgs e)
        {
            a1.modify_user(form2_dataGridView_Cleaner, form2_Cleaner_FirstName, form2_Cleaner_LastName, form2_Cleaner_UserName, form2_Cleaner_Password);
            form_initialization_data();
        }

        private void form2_ModifyBtn_Manager_Click(object sender, EventArgs e)
        {
            a1.modify_user(form2_dataGridView_Manager, textBox8, form2_Manager_LastName, form2_Manager_UserName, form2_Manager_Password);
            form_initialization_data();
        }

        private void form2_ModifyBtn_Reception_Click(object sender, EventArgs e)
        {
            a1.modify_user(form2_DataGridView_Reception, form2_Reception_FirstName, form2_Reception_LastName, form2_Reception_UserName, form2_Reception_Password);
            form_initialization_data();
        }

        private void form2_PromoteToAdmBtn_Cleaner_Click(object sender, EventArgs e)
        {
            a1.promote_admin(form2_dataGridView_Cleaner);
            form_initialization_data();
        }

        private void form2_PromoteToAdmBtn_Customer_Click(object sender, EventArgs e)
        {
            a1.promote_admin(form2_DataGridView_Customer);
            form_initialization_data();
        }

        private void form2_PromoteToAdmBtn_Reception_Click(object sender, EventArgs e)
        {
            a1.promote_admin(form2_DataGridView_Reception);
            form_initialization_data();
        }

        private void form2_PromoteToAdmBtn_Manager_Click(object sender, EventArgs e)
        {
            a1.demote_admin(form2_dataGridView_Manager);
            form_initialization_data();
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            a1.prices_selected(dataGridView3,form2_Prices_NewPrice);
        }

        private void form2_UpdatePricesBtn_Prices_Click(object sender, EventArgs e)
        {
            a1.prices_new_update(dataGridView3, form2_Prices_NewPrice);
            form_initialization_data();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            a1.delete_discount(dataGridView4);
            form_initialization_data();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String type = comboBox1.Text;
            a1.populate_discount_drop_room(comboBox2,textBox18, type);  
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

        private void dataGridView6_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            a1.populate_user_reservation(dataGridView6, dataGridView1);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            a1.assign_cleaning(dataGridView2, dataGridView7);
            form_initialization_data();
            a1.populate_assigned_rooms(dataGridView2, dataGridView8);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            a1.delete_assignment(dataGridView8);
            form_initialization_data();
            a1.populate_assigned_rooms(dataGridView2, dataGridView8);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            a1.auto_assign_cleaning();
            form_initialization_data();
            a1.populate_assigned_rooms(dataGridView2, dataGridView8);
        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            a1.populate_assigned_rooms(dataGridView2, dataGridView8);
            
        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void form2_dataGridView_Manager_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            a1.dataset_select(form2_dataGridView_Manager, textBox8, form2_Manager_LastName, form2_Manager_UserName, form2_Manager_Password);
        }

        private void form2_DataGridView_Customer_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            a1.dataset_select(form2_DataGridView_Customer, form2_Customer_FirstName, form2_Customer_LastName, form2_Customer_UserName, form2_Customer_Password);
       
        }

        private void form2_DataGridView_Reception_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            a1.dataset_select(form2_DataGridView_Reception, form2_Reception_FirstName, form2_Reception_LastName, form2_Reception_UserName, form2_Reception_Password);
       
        }

        private void form2_Prices_NewPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage10_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView7_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


    }
}
