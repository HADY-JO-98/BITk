using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows;
using System.Windows.Forms;

namespace BITk
{
    public class Users
    {
        DataBase db1;
        int id;
        string firstname;
        string lastname;
        string username;

        public Users(int id,string firstname,string lastname,string username,DataBase db1,System.Windows.Forms.Label l1)
        {
            this.db1 = db1;
            this.firstname = firstname;
            this.lastname = lastname;
            this.username = username;
            this.id = id;
            l1.Text = username;
        }
        public string get_user()
        {
            return " " + firstname + " " + lastname;
        }
        public string get_username()
        {
            return username;
        }
        public DataBase getDB()
        {
            return db1;
        }
        public DataSet list_current_rezervation(System.Windows.Forms.ListBox l1)
        {
            l1.Items.Clear();
            DataSet ds_reservations = new DataSet();
            String command_cleaner = "SELECT * FROM [Hotel].[dbo].[Rezervations] Join [Hotel].[dbo].[Rooms] ON [Hotel].[dbo].[Rezervations].RoomID=[Hotel].[dbo].[Rooms].RoomID WHERE UserID='" + id + "'";
            DataSet ds1 = db1.Read(command_cleaner);
            foreach (DataRow dr in ds1.Tables[0].Rows)
            {
                char[] separator = { ' ' };
                string[] words1 = dr.ItemArray.GetValue(3).ToString().Split(separator, StringSplitOptions.RemoveEmptyEntries);
                string[] words2 = dr.ItemArray.GetValue(4).ToString().Split(separator, StringSplitOptions.RemoveEmptyEntries);
                String line = "room: " + dr["RoomID"].ToString() + " Room Number: " + dr["RoomID"].ToString() + "  start date: " + dr["CheckinDate"].ToString()
                    + "  end date: " + dr["CheckOutDate"].ToString() + "  price: " + dr["Rezervation_Price"].ToString();
                l1.Items.Add(line);

            }
            return ds_reservations;
        }
        public void cancel_reservation(System.Windows.Forms.ListBox l1)
        {
            char[] separator = { ' ' };
            try
            {
                string[] words = l1.SelectedItem.ToString().Split(separator, StringSplitOptions.RemoveEmptyEntries);
                String command = "DELETE FROM [Hotel].[dbo].[Rezervations] WHERE RoomID = '" + int.Parse(words[1]) + "' AND UserID='" + this.id + "'";
                db1.Command(command);
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }
        }
        public void new_reservation()
        {

        }
        public void init_form7_fields(System.Windows.Forms.ComboBox c1, System.Windows.Forms.ComboBox c2,System.Windows.Forms.ComboBox c3, System.Windows.Forms.Label l1)
        {
            l1.Text = "" + firstname + " " + lastname;
            DataSet ds_reservations = new DataSet();
            String command = "SELECT * FROM [Hotel].[dbo].[RoomTypes] ";
            DataSet ds1 = db1.Read(command);
            foreach (DataRow dr in ds1.Tables[0].Rows)
            {
                c1.Items.Add(dr.ItemArray.GetValue(2));
                c3.Items.Add(dr.ItemArray.GetValue(1));
            }
            c2.Items.Add("1-50");
            c2.Items.Add("50-100");
            c2.Items.Add("100-150");
            c2.Items.Add("150-200");
            c2.Items.Add("200-999");
        }
        public void log_out(int nr)
        {
            Signning s1 = new Signning(this.db1);
            if (nr == 1)
                Form1.ActiveForm.Hide();
            else
                Form3.ActiveForm.Hide();
            s1.Show();
        }
        public void search_rooms(System.Windows.Forms.ComboBox c1, System.Windows.Forms.ComboBox c2, System.Windows.Forms.ComboBox c3, System.Windows.Forms.DateTimePicker d1, System.Windows.Forms.DateTimePicker d2, System.Windows.Forms.ListBox l1)
        {
            l1.Items.Clear();
            try
            {
                String type = c1.SelectedItem.ToString();
                char[] separator = { '-' };
                string[] price = c2.SelectedItem.ToString().Split(separator, StringSplitOptions.RemoveEmptyEntries);
                String capacity = c3.SelectedItem.ToString();
                DateTime dateStart = d1.Value.Date;
                DateTime dateEnd = d2.Value.Date;
                String command = "SELECT * FROM [Hotel].[dbo].[RoomTypes] t1 JOIN [Hotel].[dbo].[Rooms] t2 ON t1.RoomTypeID=t2.RoomTypeID  WHERE t1.name = '" + type + "' AND t1.capacity = '" + capacity + "' AND t1.price BETWEEN '" + price[0] + "' AND '" + price[1] + "'";
                DataSet ds1 = db1.Read(command);
                foreach (DataRow dr in ds1.Tables[0].Rows)
                {
                    command = "SELECT * FROM [Hotel].[dbo].[Rezervations] WHERE RoomID='" + dr["RoomID"].ToString() + "' AND CheckOutID > Convert(datetime,'" + dateStart + "')";
                    DataSet ds2 = db1.Read(command);
                    if (ds2.Tables[0].Rows.Count == 0)
                    {
                        command = "SELECT * FROM [Hotel].[dbo].[Discounts] WHERE RoomID='" + dr["RoomID"].ToString() + "'";
                        DataSet ds3 = db1.Read(command);
                        String price_true = "";
                        if (ds3.Tables[0].Rows.Count == 0)
                        {
                            price_true = dr["price"].ToString();
                        }
                        else
                        {
                            DataRow dr2 = ds3.Tables[0].Rows[0];
                            price_true = dr2["price"].ToString();
                        }
                        //String line = "Number:" + dr.ItemArray.GetValue(0).ToString() + "  Type:" + type + "  Capacity:" + capacity + "  Price:" + dr.ItemArray.GetValue(1).ToString();
                        String line = " Room Number: " + dr["RoomID"].ToString() + " capacity: " + dr["capacity"].ToString() + "  type: " + dr["name"].ToString() + "  price: " + price_true;
                        l1.Items.Add(line);
                    }
                    else { }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }
        }
        public int reserve_room(System.Windows.Forms.ListBox l1)
        {
            char[] separator = { ' ' };
            string[] words = l1.SelectedItem.ToString().Split(separator, StringSplitOptions.RemoveEmptyEntries);
            int room_number = int.Parse(words[1]);
            return room_number;

        }
        public void fill_room_fields_final(System.Windows.Forms.TextBox t1, System.Windows.Forms.TextBox t2, System.Windows.Forms.TextBox t3, System.Windows.Forms.TextBox t4, System.Windows.Forms.TextBox t5, System.Windows.Forms.TextBox t6, System.Windows.Forms.TextBox t7, System.Windows.Forms.TextBox t8, System.Windows.Forms.TextBox t9, int room_number)
        {
            String command = "SELECT t1.name, t2.RoomNumber, t2.Floor, t1.capacity, t2.surface, t2.orientation, t1.price FROM [Hotel].[dbo].[RoomTypes] t1 JOIN [Hotel].[dbo].[Rooms] t2 ON t1.RoomTypeID=t2.RoomTypeID WHERE t2.RoomID='" + room_number + "'";
            DataSet ds1 = db1.Read(command);
            foreach (DataRow dr in ds1.Tables[0].Rows)
            {
                command = "SELECT * FROM [Hotel].[dbo].[Discounts] WHERE RoomID='" + room_number + "'";
                DataSet ds2 = db1.Read(command);
                if (ds2.Tables[0].Rows.Count == 0)
                {
                    t8.Text = "0";
                    t9.Text = dr.ItemArray.GetValue(6).ToString();
                }
                else
                {
                    DataRow dr1 = ds2.Tables[0].Rows[0];
                    int new_price = int.Parse(dr1["price"].ToString());
                    t8.Text = "" + (int.Parse(dr["price"].ToString()) - new_price);
                    t9.Text = new_price.ToString();
                }
                t1.Text = dr.ItemArray.GetValue(0).ToString();
                t2.Text = dr.ItemArray.GetValue(1).ToString();
                t3.Text = dr.ItemArray.GetValue(2).ToString();
                t4.Text = dr.ItemArray.GetValue(3).ToString();
                t5.Text = dr.ItemArray.GetValue(4).ToString();
                t6.Text = dr.ItemArray.GetValue(5).ToString();
                t7.Text = dr.ItemArray.GetValue(6).ToString();
            }
        }
        public int final_reserver_form8(System.Windows.Forms.TextBox t1, System.Windows.Forms.TextBox t2, System.Windows.Forms.TextBox t3, System.Windows.Forms.TextBox t4)
        {
            int ret = 1;
            int room_number = int.Parse(t1.Text);
            DateTime start = Convert.ToDateTime(t2.Text);
            DateTime end = Convert.ToDateTime(t3.Text);
            int total = int.Parse(t4.Text);
            String command = "SELECT * FROM [Hotel].[dbo].[Rooms] WHERE RoomID='" + room_number + "'";
            DataSet ds1 = db1.Read(command);
            DataRow dr1 = ds1.Tables[0].Rows[0];
            int room_id = int.Parse(dr1["RoomId"].ToString());
            command = "SELECT * FROM [Hotel].[dbo].[Rezervations] t1 JOIN [Hotel].[dbo].[Rooms] t2 on t1.RoomID=t2.RoomID WHERE RoomID='" + room_number + "' AND Ch > Convert(datetime,'" + start + "')";
            ds1 = db1.Read(command);
            if (ds1.Tables[0].Rows.Count != 0) { ret = 0; }
            else
            {
                command = "INSERT INTO [Hotel].[dbo].[Rezervations] (UserID,RoomID,CheckInDate,CheckOutID,Rezervation_Price)Values('" + this.id + "','" + room_id + "',Convert(datetime,'" + start + "'),Convert(datetime,'" + end + "'),'" + total + "')";
                db1.Command(command);
            }
            return ret;
        }

        internal DataSet list_current_rezervation(Label form5_label_name)
        {
            throw new NotImplementedException();
        }
    }
}