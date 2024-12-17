using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace BITk
{
    internal class Reception
    {
        DataBase db1;
        int id;
        string firstname;
        string lastname;
        Reservation res1;
        public Reception(int id, string firstname, string lastname, DataBase db1)
        {
            this.db1 = db1;
            this.id = id;
            this.firstname = firstname;
            this.lastname = lastname;
        }
        public string user_info()
        {
            return firstname + " " + lastname;
        }
        public void reception_dataset_populate_rname(ComboBox g1)
        {
            string command_cleaner = "SELECT RoomID FROM [Hotel].[dbo].[Rooms]";
            DataSet ds1 = db1.Read(command_cleaner);
            foreach (DataTable table in ds1.Tables)
            {
                foreach (DataRow dr in table.Rows)
                {
                    g1.Items.Add(dr["RoomID"].ToString());
                }
            }
        }
        public void reception_dataset_populate_uname(ComboBox g1)
        {
            String command_cleaner = "SELECT Username FROM [Hotel].[dbo].[Users]";
            DataSet ds1 = db1.Read(command_cleaner);
            foreach (DataTable table in ds1.Tables)
            {
                foreach (DataRow dr in table.Rows)
                {
                    g1.Items.Add(dr["Username"].ToString());
                }
            }
        }
        public void create_rezervation(int RoomID, int UserID, DateTime CheckinDate, DateTime CheckOutDate, int Rezervation_Price)
        {
            String db_command1 = "INSERT INTO [Hotel].[dbo].[Rezervations] (RoomID,UserID,CheckinDate,CheckOutDate,rez_price)Values('" + RoomID + "','" + UserID + "','" + CheckinDate + "','" + CheckOutDate + "','" + Rezervation_Price + "')";
            db1.Command(db_command1);
            MessageBox.Show("Reservation created succesfully!");
        }
        public void create_user(String username, String password, String firstname, String lastname, int u_type_id)
        {
            String db_command = "SELECT * FROM [Hotel].[dbo].[Users] Where username='" + username + "'";
            DataSet ds1 = db1.Read(db_command);
            if (ds1.Tables[0].Rows.Count != 0)
            {
                MessageBox.Show("User already taken");
            }
            else if (u_type_id == 2)
            {
                MessageBox.Show("You cannot create an administrator account");
            }
            else if (username == "" || lastname == "" || firstname == "" || password == "")
            {
                MessageBox.Show("No field should be left NULL");
            }
            else
            {
                try
                {
                    String db_command1 = "INSERT INTO [Hotel].[dbo].[Users] (u_type_id,username,password,firstName,lastName)Values('" + u_type_id + "','" + username + "','" + password + "','" + firstname + "','" + lastname + "')";
                    db1.Command(db_command1);
                    MessageBox.Show("User created succesfully!");
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error Insert" + e.ToString());
                }
            }
        }
        public int calculate_price(int room_number)
        {
            string command_cleaner = $"SELECT * FROM [Hotel].[dbo].[RoomTypes] JOIN [Hotel].[dbo].[Rooms] ON [Hotel].[dbo].[RoomTypes].RoomTypeID=[Hotel].[dbo].[Rooms].RoomTypeID WHERE RoomID='{room_number}'";
            DataSet ds1 = db1.Read(command_cleaner);

            foreach (DataTable table in ds1.Tables)
            {
                foreach (DataRow dr in table.Rows)
                {
                    command_cleaner = $"SELECT * FROM [Hotel].[dbo].[Discounts] WHERE RoomID='{dr["RoomID"]}'";
                    DataSet ds2 = db1.Read(command_cleaner);
                    if (ds2.Tables[0].Rows.Count != 0)
                    {
                        DataRow dr2 = ds2.Tables[0].Rows[0];
                        return int.Parse(dr2["price"].ToString());
                    }
                    return int.Parse(dr["price"].ToString());
                }
            }
            return 0;
        }
        public int return_rid(int room_number)
        {
            String command_cleaner = "SELECT * FROM [Hotel].[dbo].[Rooms] [Rooms] WHERE r_number='" + room_number + "' ";
            DataSet ds1 = db1.Read(command_cleaner);
            foreach (DataTable table in ds1.Tables)
            {
                foreach (DataRow dr in table.Rows)
                {
                    room_number = int.Parse(dr["RoomID"].ToString());
                }
            }
            return room_number;
        }
        public int return_uid(string Username)
        {
            String command_cleaner = "SELECT * FROM [Hotel].[dbo].[Users] [Rooms] WHERE username='" + Username + "' ";
            DataSet ds1 = db1.Read(command_cleaner);
            foreach (DataTable table in ds1.Tables)
            {
                foreach (DataRow dr in table.Rows)
                {
                    Username = dr["Username"].ToString();
                }
            }
            return int.Parse(Username);
        }
        public void reception_dataset_populate(System.Windows.Forms.DataGridView g1)
        {
            DateTime reference = DateTime.UtcNow.AddDays(-1);
            String command_reception = "SELECT * FROM [Hotel].[dbo].[Users] JOIN [Hotel].[dbo].[Rezervations] on [Hotel].[dbo].[Users].UserID=[Hotel].[dbo].[Rezervations].UserID JOIN [Hotel].[dbo].[Rooms] on [Hotel].[dbo].[Rezervations].RoomID=[Hotel].[dbo].[Rooms].RoomID Where CheckOutDate>Convert(datetime,'" + reference + "')";
            DataSet ds1 = db1.Read(command_reception);
            foreach (DataTable table in ds1.Tables)
            {
                g1.DataSource = table;
            }
            g1.Columns[0].Visible = false;
            g1.Columns[1].Visible = false;
            g1.Columns[3].Visible = false;
            g1.Columns[4].Visible = false;
            g1.Columns[5].Visible = false;
            g1.Columns[6].Visible = false;
            g1.Columns[7].Visible = false;
            g1.Columns[8].Visible = false;
            // g1.Columns[9].Visible = false;
            g1.Columns[12].Visible = false;
            g1.Columns[13].Visible = false;
            g1.Columns[15].Visible = false;
            g1.Columns[16].Visible = false;
            g1.Columns[17].Visible = false;
        }
        public void delete_rezervation(System.Windows.Forms.DataGridView g1)
        {
            int rowindex = g1.CurrentCell.RowIndex;
            string value = g1.Rows[rowindex].Cells[6].Value.ToString();
            // MessageBox.Show(g1.Rows[rowindex].Cells[6].Value.ToString());
            String db_command = "DELETE FROM [Hotel].[dbo].[Rezervations] Where RezervationID='" + int.Parse(value) + "' ";
            DataSet ds1 = db1.Read(db_command);
            MessageBox.Show("Reservation deleted!");
        }
        public void check_out(System.Windows.Forms.DataGridView g1)
        {
            int rowindex = g1.CurrentCell.RowIndex;
            string value = g1.Rows[rowindex].Cells[6].Value.ToString();
            DateTime reference = DateTime.UtcNow;

            String db_command = "UPDATE [Hotel].[dbo].[Rezervations] SET CheckOutDate=Convert(datetime,'" + reference + "') Where RezervationID='" + int.Parse(value) + "'";
            db1.Command(db_command);
            DataGridViewRow row = g1.SelectedRows[0];
            int id_room = int.Parse(row.Cells["RoomID"].Value.ToString());
            //aici mutam camera in dabelul de cleaning
            String db_command1 = "INSERT INTO [Hotel].[dbo].[Cleaning] (RoomID,UserID,Status,CleaningDate)Values('" + id_room + "','2','Pending',Convert(datetime,'" + reference + "'))";
            db1.Command(db_command1);
            MessageBox.Show("User Checked out!");
        }
    }
}