using BITk;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BITk
{
    public class Admin
    {
        DataBase db1;
        int id;
       string firstname;
       string lastname;
        private string v;

        public Admin(int id,string firstname,string lastname, DataBase db1)
        {
            this.db1 = db1;
            this.id = id;
            this.firstname = firstname;
            this.lastname = lastname;
        }

        public Admin(string v)
        {
            this.v = v;
        }

        public string getname() 
        {
            return " " + firstname + " " + lastname;
        }

        public void dataset_populate(string command, System.Windows.Forms.DataGridView g1)
        {
            //string command_cleaner = "SELECT * FROM [Hotel].[dbo].[Users] WHERE u_type_id='" + type + "'";
            DataSet ds1 = db1.Read(command);
            foreach (DataTable table in ds1.Tables)
            {
                g1.DataSource = table;
            }
            g1.Columns[0].Visible = false;
        }

        public void dataset_select(System.Windows.Forms.DataGridView g1, System.Windows.Forms.TextBox t1, System.Windows.Forms.TextBox t2, System.Windows.Forms.TextBox t3, System.Windows.Forms.TextBox t4)
        {
            if (g1.SelectedRows.Count != 0)
            {
                DataGridViewRow row = g1.SelectedRows[0];
                t1.Text = row.Cells["First Name"].Value.ToString();
                t2.Text = row.Cells["Last Name"].Value.ToString();
                t3.Text = row.Cells["Username"].Value.ToString();
                t4.Text = row.Cells["Password"].Value.ToString();
            }
        }

        public void modify_user(System.Windows.Forms.DataGridView g1, System.Windows.Forms.TextBox t1, System.Windows.Forms.TextBox t2, System.Windows.Forms.TextBox t3, System.Windows.Forms.TextBox t4)
        {
            if ((g1.SelectedRows.Count == 0) || (t1.TextLength <= 1) || (t2.TextLength <= 1) || (t3.TextLength <= 1) || (t4.TextLength <= 1))
            {
                MessageBox.Show("No empty fields Please");
            }
            else
            {
                DataGridViewRow row = g1.SelectedRows[0];
                int id = int.Parse(row.Cells["Id"].Value.ToString());
               string db_command = "UPDATE [Hotel].[dbo].[Users] SET username='" + t3.Text + "',password='" + t4.Text + "',firstName='" + t1.Text + "',lastName='" + t2.Text + "' WHERE u_id='" + id + "'";
                db1.Command(db_command);
            }
        }

        public void promote_admin(System.Windows.Forms.DataGridView g1)
        {
            if (g1.SelectedRows.Count != 0)
            {
                DataGridViewRow row = g1.SelectedRows[0];
                int id = int.Parse(row.Cells["Id"].Value.ToString());
               string db_command = "UPDATE [Hotel].[dbo].[Users] SET u_type_id='2' WHERE u_id='" + id + "'";
                db1.Command(db_command);
            }
            else
            {
                MessageBox.Show("Please select entry");
            }
        }

        public void demote_admin(System.Windows.Forms.DataGridView g1)
        {
            if (g1.SelectedRows.Count != 0)
            {
                DataGridViewRow row = g1.SelectedRows[0];
                int id = int.Parse(row.Cells["Id"].Value.ToString());
               string db_command = "UPDATE [Hotel].[dbo].[Users] SET u_type_id='1' WHERE u_id='" + id + "'";
                db1.Command(db_command);
            }
            else
            {
                MessageBox.Show("Please select entry");
            }
        }

        public void adding_user(System.Windows.Forms.TextBox t1, System.Windows.Forms.TextBox t2, System.Windows.Forms.TextBox t3, System.Windows.Forms.TextBox t4, int type)
        {
            if ((t1.TextLength <= 1) || (t2.TextLength <= 1) || (t3.TextLength <= 1) || (t4.TextLength <= 1))
            {
                MessageBox.Show("No empty fields Please");
            }
            else
            {
               string db_command = "SELECT * FROM [Hotel].[dbo].[Users] WHERE username='" + t1.Text + "'";
                DataSet ds1 = db1.Read(db_command);
                if (ds1.Tables[0].Rows.Count == 0)
                {
                   string db_command1 = "INSERT INTO [Hotel].[dbo].[Users] (u_type_id,username,password,firstName,lastName)Values('" + type + "','" + t1.Text + "','" + t2.Text + "','" + t3.Text + "','" + t4.Text + "')";
                    db1.Command(db_command1);
                    MessageBox.Show("User created succesfully!");
                }
                else
                {
                    MessageBox.Show("User Already Exists");
                }
            }
        }

        public void delete_user(System.Windows.Forms.DataGridView g1)
        {
            if (g1.SelectedRows.Count != 0)
            {
                DataGridViewRow row = g1.SelectedRows[0];
                if (int.Parse(row.Cells["Id"].Value.ToString()) == this.id)
                {
                    MessageBox.Show("Can't Delete Yourself");
                }
                else
                {
                    //TO-DO: Add deletion of everything adjecent

                   string db_command1 = "DELETE FROM [Hotel].[dbo].[Users] WHERE u_id='" + int.Parse(row.Cells["ID"].Value.ToString()) + "'";
                    db1.Command(db_command1);
                }
            }
        }

        public void prices_udpate(System.Windows.Forms.DataGridView g1, System.Windows.Forms.DataGridView g2)
        {
           string command_cleaner = "SELECT name,capacity,price FROM [Hotel].[dbo].[RoomTypes] ";
            DataSet ds1 = db1.Read(command_cleaner);
            foreach (DataTable table in ds1.Tables)
            {
                g1.DataSource = table;
            }
            command_cleaner = "SELECT * FROM [Hotel].[dbo].[Discounts] ";
            ds1 = db1.Read(command_cleaner);
            foreach (DataTable table in ds1.Tables)
            {
                g2.DataSource = table;
            }
        }

        public void room_info_update(System.Windows.Forms.DataGridView g1)
        {
            DateTime dateStart = DateTime.UtcNow;
           string command_cleaner = "SELECT rez_id AS Id, r_number AS Number, r_floor AS Floor, orientation AS Orientation, surface AS Surface, start_date AS 'Start date', end_date AS 'End date', rez_price AS Price FROM [Hotel].[dbo].[Rooms] INNER JOIN [Hotel].[dbo].[Rezervations] ON Rooms.r_id=Rezervations.r_id WHERE end_date > Convert(datetime,'" + dateStart + "') ";
            DataSet ds1 = db1.Read(command_cleaner);
            foreach (DataTable table in ds1.Tables)
            {
                g1.DataSource = table;
            }
        }

        public void prices_selected(System.Windows.Forms.DataGridView g1, System.Windows.Forms.TextBox t1)
        {
            if (g1.SelectedRows.Count != 0)
            {
                DataGridViewRow row = g1.SelectedRows[0];
                t1.Text = row.Cells["price"].Value.ToString();

            }
        }

        public void prices_new_update(System.Windows.Forms.DataGridView g1, System.Windows.Forms.TextBox t1)
        {
            int price;
            if ((g1.SelectedRows.Count == 0) || (t1.TextLength == 0) || !(int.TryParse(t1.Text.ToString(), out price)))
            {
                MessageBox.Show("Price canot bestring or empty");
            }
            else
            {
                DataGridViewRow row = g1.SelectedRows[0];
               string type = row.Cells["name"].Value.ToString();
               string db_command = "UPDATE [Hotel].[dbo].[RoomTypes] SET price='" + price + "' WHERE name ='" + type + "'";
                db1.Command(db_command);
            }
        }

        public void delete_discount(System.Windows.Forms.DataGridView g1)
        {
            if (g1.SelectedRows.Count != 0)
            {
                DataGridViewRow row = g1.SelectedRows[0];
                int id = int.Parse(row.Cells["d_id"].Value.ToString());
               string db_command1 = "DELETE FROM [Hotel].[dbo].[Discounts] WHERE d_id='" + id + "'";
                db1.Command(db_command1);
            }
        }

        public void populate_discount_drop_type(System.Windows.Forms.ComboBox c1)
        {
           string command_cleaner = "SELECT name FROM [Hotel].[dbo].[RoomTypes]";
            DataSet ds1 = db1.Read(command_cleaner);
            foreach (DataTable table in ds1.Tables)
            {
                foreach (DataRow dr in table.Rows)
                {
                    c1.Items.Add(dr["name"].ToString());
                }
            }
        }

        public void populate_discount_drop_room(System.Windows.Forms.ComboBox c1, System.Windows.Forms.TextBox t1,string type)
        {
           string command_cleaner = "SELECT * FROM [Hotel].[dbo].[RoomTypes] Where name='" + type + "'";
            DataSet ds1 = db1.Read(command_cleaner);
            int id_type = 0;
            foreach (DataTable table in ds1.Tables)
            {
                foreach (DataRow dr in table.Rows)
                {
                    id_type = int.Parse(dr["r_type_id"].ToString());
                    t1.Text = dr["price"].ToString();
                }
            }
            command_cleaner = "SELECT * FROM [Hotel].[dbo].[Rooms] Where r_type_id='" + id_type + "'";
            ds1 = db1.Read(command_cleaner);
            foreach (DataTable table in ds1.Tables)
            {
                foreach (DataRow dr in table.Rows)
                {
                    c1.Items.Add(dr["r_number"].ToString());
                }
            }

        }

        public void add_discount(System.Windows.Forms.ComboBox c2, System.Windows.Forms.TextBox t1)
        {
            int price;
            if ((c2.SelectedIndex == -1) || (t1.TextLength == 0) || !(int.TryParse(t1.Text.ToString(), out price)))
            {
                MessageBox.Show("Please enter a number and not empty orstring and select room and type!");
            }
            else
            {
               string command_cleaner = "SELECT * FROM [Hotel].[dbo].[Rooms] Where r_number='" + c2.Text + "'";
                DataSet ds1 = db1.Read(command_cleaner);
                int id_type = 0;
                foreach (DataTable table in ds1.Tables)
                {
                    foreach (DataRow dr in table.Rows)
                    {
                        id_type = int.Parse(dr["r_id"].ToString());
                    }
                }
               string db_command1 = "INSERT INTO [Hotel].[dbo].[Discounts] (r_id,price)Values('" + id_type + "','" + price + "')";
                db1.Command(db_command1);
            }
        }

        public void delete_rezervation(System.Windows.Forms.DataGridView g1)
        {
            if (g1.SelectedRows.Count != 0)
            {
                DataGridViewRow row = g1.SelectedRows[0];
                int id = int.Parse(row.Cells["Id"].Value.ToString());
               string db_command1 = "DELETE FROM [Hotel].[dbo].[Rezervations] WHERE rez_id='" + id + "'";
                db1.Command(db_command1);
            }
        }

        public void populate_user_reservation(System.Windows.Forms.DataGridView g1, System.Windows.Forms.DataGridView g2)
        {
            if (g1.SelectedRows.Count != 0)
            {
                DataGridViewRow row = g1.SelectedRows[0];
                int id_u = int.Parse(row.Cells["Id"].Value.ToString());
               string command_cleaner = "SELECT r_number AS Number, start_date AS 'Start date',end_date AS 'End date',rez_price AS Price FROM [Hotel].[dbo].[Rezervations] t1 JOIN [Hotel].[dbo].[Rooms] t2 ON t1.r_id=t2.r_id WHERE u_id='" + id_u + "'";
                DataSet ds1 = db1.Read(command_cleaner);
                foreach (DataTable table in ds1.Tables)
                {
                    g2.DataSource = table;
                }
            }
        }

        public void populate_cleaning_assigned(System.Windows.Forms.DataGridView g1)
        {
           string command_cleaner = "SELECT t1.r_id AS Id, r_number as Number, r_floor AS Floor, status AS Status, date_required AS 'Required date',clean_id FROM [Hotel].[dbo].[Cleaning] t1 JOIN [Hotel].[dbo].[Rooms] t2 ON t1.r_id = t2.r_id WHERE status='Pending' ";
            DataSet ds1 = db1.Read(command_cleaner);
            foreach (DataTable table in ds1.Tables)
            {
                g1.DataSource = table;
                g1.Columns[0].Visible = false;
                g1.Columns[5].Visible = false;
            }

        }
        public void populate_assigned_rooms(System.Windows.Forms.DataGridView g1, System.Windows.Forms.DataGridView g2)
        {
            if (g1.SelectedRows.Count != 0)
            {
                DataGridViewRow row = g1.SelectedRows[0];
                int id_u = int.Parse(row.Cells["id"].Value.ToString());
               string command_cleaner = "SELECT t1.r_id AS Id, r_number AS Number, r_floor AS Floor, status AS Status, date_required AS 'Required date', clean_id FROM [Hotel].[dbo].[Cleaning] t1 JOIN [Hotel].[dbo].[Rooms] t2 ON t1.r_id = t2.r_id WHERE t1.u_id = '" + id_u + "' AND status='Assigned'";
                DataSet ds1 = db1.Read(command_cleaner);
                foreach (DataTable table in ds1.Tables)
                {
                    g2.DataSource = table;
                }
                g2.Columns[0].Visible = false;
                g2.Columns[5].Visible = false;
            }
        }

        public void assign_cleaning(System.Windows.Forms.DataGridView g1, System.Windows.Forms.DataGridView g2)
        {
            if (g1.SelectedRows.Count != 0)
            {
                if (g2.SelectedRows.Count != 0)
                {
                    DataGridViewRow row = g1.SelectedRows[0];
                    int id_u = int.Parse(row.Cells["Id"].Value.ToString());
                    row = g2.SelectedRows[0];
                    int id_c = int.Parse(row.Cells["clean_id"].Value.ToString());

                   string db_command = "UPDATE [Hotel].[dbo].[Cleaning] SET status='Assigned', u_id='" + id_u + "' WHERE clean_id='" + id_c + "'";
                    db1.Command(db_command);
                }
            }
        }


        public void delete_assignment(System.Windows.Forms.DataGridView g1)
        {
            if (g1.SelectedRows.Count != 0)
            {
                DataGridViewRow row = g1.SelectedRows[0];
                int id_u = int.Parse(row.Cells["Id"].Value.ToString());
                int id_c = int.Parse(row.Cells["clean_id"].Value.ToString());
               string db_command = "UPDATE [Hotel].[dbo].[Cleaning] SET status='Pending' WHERE clean_id='" + id_c + "'";
                db1.Command(db_command);
            }
        }

        public void auto_assign_cleaning()
        {
           string command_cleaner = "SELECT * FROM [Hotel].[dbo].[Users] Where u_type_id='3'";
            DataSet ds1 = db1.Read(command_cleaner);
            DataTable t1 = ds1.Tables[0];
            command_cleaner = "SELECT * FROM [Hotel].[dbo].[Cleaning] Where status='Pending' OR status='in progress'";
            ds1 = db1.Read(command_cleaner);
            DataTable t2 = ds1.Tables[0];
            int divider = t1.Rows.Count;
            int rows_clean = t2.Rows.Count;
            int iter = rows_clean / divider;
            int leftower = rows_clean % divider;
            //MessageBox.Show("" + iter + "" + leftower);
           string id_u = "0";
           string id_c = "0";
           string db_command = "";
            DataRow r_user;
            DataRow r_clean;
            for (int j = 0; j < iter; j++)
            {
                for (int i = 0; i < divider; i++)
                {
                    r_user = t1.Rows[i];
                    r_clean = t2.Rows[i + divider * j];
                    id_u = r_user["u_id"].ToString();
                    id_c = r_clean["clean_id"].ToString();
                    // MessageBox.Show("user: " + id_u + "cleaning job: " + id_c);
                    db_command = "UPDATE [Hotel].[dbo].[Cleaning] SET status='Assigned', u_id='" + id_u + "' WHERE clean_id='" + id_c + "'";
                    db1.Command(db_command);
                }
            }
            if (leftower != 0)
            {
                for (int i = 0; i < leftower; i++)
                {
                    r_user = t1.Rows[i];
                    r_clean = t2.Rows[i + divider * iter];
                    id_u = r_user["u_id"].ToString();
                    id_c = r_clean["clean_id"].ToString();
                    // MessageBox.Show("user: " + id_u + "cleaning job: " + id_c);
                    db_command = "UPDATE [Hotel].[dbo].[Cleaning] SET status='Assigned', u_id='" + id_u + "' WHERE clean_id='" + id_c + "'";
                    db1.Command(db_command);
                }
            }
        }

        public void statistic_income(System.Windows.Forms.TextBox t1, System.Windows.Forms.TextBox t2)
        {
            //Age wise
            int total = 0;
           string db_command = "SELECT * FROM [Hotel].[dbo].[Rezervations] ";
            DataSet ds1 = db1.Read(db_command);
            foreach (DataTable table in ds1.Tables)
            {
                foreach (DataRow dr in table.Rows)
                {
                    DateTime time1 = Convert.ToDateTime(dr["start_date"].ToString());
                    DateTime time2 = Convert.ToDateTime(dr["end_date"].ToString());
                    int price = Int16.Parse(dr["rez_price"].ToString());
                    total = total + (int)(time2 - time1).TotalDays * price;
                }
            }
            t1.Text = total.ToString();
            //Montly
            total = 0;
            DateTime reference = DateTime.UtcNow.AddMonths(-1);
           string sql = "SELECT * FROM [Hotel].[dbo].[Rezervations] WHERE start_date > Convert(datetime,'" + reference + "')";
            ds1 = db1.Read(sql);
            foreach (DataTable table in ds1.Tables)
            {
                foreach (DataRow dr in table.Rows)
                {
                    DateTime time1 = Convert.ToDateTime(dr["start_date"].ToString());
                    DateTime time2 = Convert.ToDateTime(dr["end_date"].ToString());
                    int price = Int16.Parse(dr["rez_price"].ToString());
                    total = total + (int)(time2 - time1).TotalDays * price;
                }
            }
            t2.Text = total.ToString();
        }

        public void statistic_customers(System.Windows.Forms.TextBox t1, System.Windows.Forms.TextBox t2)
        {
            //Age wise
            int total = 0;
           string db_command = "SELECT * FROM [Hotel].[dbo].[Rezervations] ";
            DataSet ds1 = db1.Read(db_command);
            foreach (DataTable table in ds1.Tables)
            {
                foreach (DataRow dr in table.Rows)
                {
                    total = total + 1;
                }
            }
            t1.Text = total.ToString();
            //Montly
            total = 0;
            DateTime reference = DateTime.UtcNow.AddMonths(-1);
           string sql = "SELECT * FROM [Hotel].[dbo].[Rezervations] WHERE start_date > Convert(datetime,'" + reference + "')";
            ds1 = db1.Read(sql);
            foreach (DataTable table in ds1.Tables)
            {
                foreach (DataRow dr in table.Rows)
                {
                    total = total + 1;
                }
            }
            t2.Text = total.ToString();
        }


        public void statistic_totals(System.Windows.Forms.TextBox t1, System.Windows.Forms.TextBox t2, System.Windows.Forms.TextBox t3, System.Windows.Forms.TextBox t4)
        {
            //user
           string sql = "SELECT * FROM [Hotel].[dbo].[Users] WHERE u_type_id='1'";
            DataSet ds1 = db1.Read(sql);
            t1.Text = ds1.Tables[0].Rows.Count.ToString();
            //Cleaner
            sql = "SELECT * FROM [Hotel].[dbo].[Users] WHERE u_type_id='3'";
            ds1 = db1.Read(sql);
            t2.Text = ds1.Tables[0].Rows.Count.ToString();
            //Reception
            sql = "SELECT * FROM [Hotel].[dbo].[Users] WHERE u_type_id='4'";
            ds1 = db1.Read(sql);
            t3.Text = ds1.Tables[0].Rows.Count.ToString();
            //Admin
            sql = "SELECT * FROM [Hotel].[dbo].[Users] WHERE u_type_id='2'";
            ds1 = db1.Read(sql);
            t4.Text = ds1.Tables[0].Rows.Count.ToString();
        }

        public void cleaned_rooms(System.Windows.Forms.TextBox t1)
        {
            int total = 0;
            DateTime reference = DateTime.UtcNow.AddMonths(-1);
           string sql = "SELECT * FROM [Hotel].[dbo].[Cleaning] WHERE status='Cleaned' AND date_required > Convert(datetime,'" + reference + "')";
            DataSet ds1 = db1.Read(sql);
            foreach (DataTable table in ds1.Tables)
            {
                foreach (DataRow dr in table.Rows)
                {
                    total = total + 1;
                }
            }
            t1.Text = total.ToString();
        }

        public void statistics_rooms(System.Windows.Forms.TextBox t1, System.Windows.Forms.TextBox t2)
        {
            int total = 0;
            DateTime reference = DateTime.UtcNow;
           string sql = "SELECT * FROM [Hotel].[dbo].[Rezervations] WHERE end_date > Convert(datetime,'" + reference + "') AND start_date < Convert(datetime,'" + reference + "')";
            DataSet ds1 = db1.Read(sql);
            foreach (DataTable table in ds1.Tables)
            {
                foreach (DataRow dr in table.Rows)
                {
                    total = total + 1;
                }
            }
            t1.Text = total.ToString();

            sql = "SELECT * FROM [Hotel].[dbo].[Rooms]";
            ds1 = db1.Read(sql);
            t2.Text = (ds1.Tables[0].Rows.Count - total).ToString();
        }

    }
}