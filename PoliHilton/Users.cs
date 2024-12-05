using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PoliHilton
{
    public class Users
    {
     Database db1;
     int id;
     String firstname;
     String lastname;
     String username;
      
        
       public Users(int id,String firstname,String lastname,String username,Database db1,System.Windows.Forms.Label l1)
        {
           
            this.db1=db1;
            this.id = id;
            this.firstname = firstname;
            this.lastname = lastname;
            this.username = username;
            l1.Text = username;
        }

       public String getUser()
       {
           return "" + firstname + " " + lastname;
       }

       public String getusername()
       {
           return username;
       }

       public Database getDB()
       {
           return db1;
       }

       public DataSet list_current_reservations(System.Windows.Forms.ListBox l1)
       {
           l1.Items.Clear();
           DataSet ds_reservations = new DataSet();
           String command_cleaner = "SELECT * FROM [polihilton].[dbo].[Rezervations] Join [polihilton].[dbo].[Rooms] ON [polihilton].[dbo].[Rezervations].r_id=[polihilton].[dbo].[Rooms].r_id WHERE u_id='" + id + "'";
           DataSet ds1 = db1.Read(command_cleaner);
           foreach (DataRow dr in ds1.Tables[0].Rows)
           {
               char[] separator = { ' ' };
               string[] words1 = dr.ItemArray.GetValue(3).ToString().Split(separator, StringSplitOptions.RemoveEmptyEntries);
               string[] words2 = dr.ItemArray.GetValue(4).ToString().Split(separator, StringSplitOptions.RemoveEmptyEntries);
               String line = "room: " + dr["r_id"].ToString() +" Room Number: "+dr["r_number"].ToString() + "  start date: " + dr["start_date"].ToString()
                   + "  end date: " + dr["end_date"].ToString() + "  price: " + dr["rez_price"].ToString();
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
               String command = "DELETE FROM [polihilton].[dbo].[Rezervations] WHERE r_id = '" + int.Parse(words[1]) + "' AND u_id='"+this.id+"'";
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
       public void init_form7_fields(System.Windows.Forms.ComboBox c1, System.Windows.Forms.ComboBox c2, 
           System.Windows.Forms.ComboBox c3,System.Windows.Forms.Label l1)
       {
           l1.Text = ""+firstname+" "+lastname;
           DataSet ds_reservations = new DataSet();
           String command = "SELECT * FROM [polihilton].[dbo].[RoomTypes] ";
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
           Form1 f1 = new Form1(this.db1);
           if (nr==1)
               Form5.ActiveForm.Hide();
           else
               Form7.ActiveForm.Hide();
           f1.Show();
       }
       public void search_rooms(System.Windows.Forms.ComboBox c1, System.Windows.Forms.ComboBox c2,
            System.Windows.Forms.ComboBox c3, System.Windows.Forms.DateTimePicker d1,
            System.Windows.Forms.DateTimePicker d2,System.Windows.Forms.ListBox l1)
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
               String command = "SELECT * FROM [polihilton].[dbo].[RoomTypes] t1 JOIN [polihilton].[dbo].[Rooms] t2 ON t1.r_type_id=t2.r_type_id  WHERE t1.name = '" + type + "' AND t1.capacity = '" + capacity + "' AND t1.price BETWEEN '" + price[0] + "' AND '" + price[1] + "'";
               DataSet ds1 = db1.Read(command);
               foreach (DataRow dr in ds1.Tables[0].Rows)
               {
                   command = "SELECT * FROM [polihilton].[dbo].[Rezervations] WHERE r_id='"+dr["r_id"].ToString()+"' AND end_date > Convert(datetime,'" + dateStart + "')";
                   DataSet ds2 = db1.Read(command);
                  if (ds2.Tables[0].Rows.Count == 0)
                   {
                       command = "SELECT * FROM [polihilton].[dbo].[Discounts] WHERE r_id='" + dr["r_id"].ToString() + "'";
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
                       String line = "number: " + dr["r_id"].ToString() + " Room Number: "+dr["r_number"].ToString()+ " capacity: " + dr["capacity"].ToString() + "  type: " + dr["name"].ToString() + "  price: " + price_true;
                       l1.Items.Add(line);
                  }
                  else {  }
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



        public void fill_room_fields_final(System.Windows.Forms.TextBox t1, System.Windows.Forms.TextBox t2, System.Windows.Forms.TextBox t3, System.Windows.Forms.TextBox t4, 
            System.Windows.Forms.TextBox t5, System.Windows.Forms.TextBox t6, System.Windows.Forms.TextBox t7, System.Windows.Forms.TextBox t8, System.Windows.Forms.TextBox t9,int room_number)
        {
            String command = "SELECT t1.name, t2.r_number, t2.r_floor, t1.capacity, t2.surface, t2.orientation, t1.price FROM [polihilton].[dbo].[RoomTypes] t1 JOIN [polihilton].[dbo].[Rooms] t2 ON t1.r_type_id=t2.r_type_id WHERE t2.r_id='"+room_number+"'";
            DataSet ds1 = db1.Read(command);
            foreach (DataRow dr in ds1.Tables[0].Rows)
            {
                command = "SELECT * FROM [polihilton].[dbo].[Discounts] WHERE r_id='" +room_number+ "'";
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
                    t8.Text = ""+(int.Parse(dr["price"].ToString())-new_price);
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
            int total=int.Parse(t4.Text);
            String command = "SELECT * FROM [polihilton].[dbo].[Rooms] WHERE r_number='" + room_number + "'";
            DataSet ds1 = db1.Read(command);
            DataRow dr1 = ds1.Tables[0].Rows[0];
            int room_id = int.Parse(dr1["r_id"].ToString());
            command = "SELECT * FROM [polihilton].[dbo].[Rezervations] t1 JOIN [polihilton].[dbo].[Rooms] t2 on t1.r_id=t2.r_id WHERE r_number='" + room_number + "' AND end_date > Convert(datetime,'" + start + "')";                    
            ds1 = db1.Read(command);
            if (ds1.Tables[0].Rows.Count != 0) { ret = 0; }
            else
            {
                command = "INSERT INTO [polihilton].[dbo].[Rezervations] (u_id,r_id,start_date,end_date,rez_price)Values('" + this.id + "','" + room_id + "',Convert(datetime,'" + start + "'),Convert(datetime,'" + end + "'),'"+total+"')";
                db1.Command(command);
            }
            return ret;
        }



    }
}
