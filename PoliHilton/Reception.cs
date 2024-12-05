using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace PoliHilton
{
   public class Reception
   {
       //We need functions for all the buttons/actions posssible selected
       //Initalization is done and log out
       Database db1;
       int id;
       String firstname;
       String lastname;
       Form4 f4;
       public Reception(int id,String firstname,String lastname,Database db1)
       {
            this.db1=db1;
            this.id = id;
            this.firstname = firstname;
            this.lastname = lastname;
        
       }

       public String user_info()
       {
           return "" + firstname + " " + lastname;
       }
      
       public void reception_dataset_populate_rname(ComboBox g1)
       {
           //aici populam comboboxul cu camere
           String command_cleaner = "SELECT r_number FROM [polihilton].[dbo].[Rooms]";
           DataSet ds1 = db1.Read(command_cleaner);
           foreach (DataTable table in ds1.Tables)
           {
               foreach (DataRow dr in table.Rows)
               {
                g1.Items.Add(dr["r_number"].ToString());
               }
           }
       }
       public void reception_dataset_populate_uname(ComboBox g1)
       {
           //aici populam comboboxul cu useri
           String command_cleaner = "SELECT username FROM [polihilton].[dbo].[Users]";
           DataSet ds1 = db1.Read(command_cleaner); 
           foreach (DataTable table in ds1.Tables)
           {
               foreach (DataRow dr in table.Rows)
               {
                   g1.Items.Add(dr["username"].ToString());

               }
           }
       }
       public void create_rezervation(int room_id,int user_id,DateTime s_date,DateTime e_date, int r_price)
       {
           String db_command1 = "INSERT INTO [polihilton].[dbo].[Rezervations] (r_id,u_id,start_date,end_date,rez_price)Values('" + room_id + "','" + user_id + "','" + s_date + "','" + e_date + "','" + r_price + "')";
           db1.Command(db_command1);
           MessageBox.Show("Reservation created succesfully!");
       }
       public void create_user(String username, String password, String firstname, String lastname, int u_type_id)
       {
           String db_command = "SELECT * FROM [polihilton].[dbo].[Users] Where username='" + username + "'";
           DataSet ds1 = db1.Read(db_command);
           if (ds1.Tables[0].Rows.Count != 0)
           {
               MessageBox.Show("User already taken");
           }
           else if(u_type_id==2)
           {
               MessageBox.Show("You cannot create an administrator account");
           }
           else if (username=="" ||lastname=="" ||firstname=="" ||password=="" )
           {
               MessageBox.Show("No field should be left NULL");
           }
           else
           {
               try
               {
                   String db_command1 = "INSERT INTO [polihilton].[dbo].[Users] (u_type_id,username,password,firstName,lastName)Values('" + u_type_id + "','" + username + "','" + password + "','" + firstname + "','" + lastname + "')";
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

           String command_cleaner = "SELECT * FROM [polihilton].[dbo].[RoomTypes] JOIN [polihilton].[dbo].[Rooms] ON [polihilton].[dbo].[RoomTypes].r_type_id=[polihilton].[dbo].[Rooms].r_type_id WHERE r_number='" + room_number + "' ";
           DataSet ds1 = db1.Read(command_cleaner);
           foreach (DataTable table in ds1.Tables)
           {
               foreach (DataRow dr in table.Rows)
               {
                   command_cleaner = "SELECT * FROM [polihilton].[dbo].[Discounts] WHERE r_id='" + dr["r_id"].ToString() +"' ";
                   DataSet ds2 = db1.Read(command_cleaner);
                   if (ds2.Tables[0].Rows.Count != 0)
                   {
                       DataRow dr2 = ds2.Tables[0].Rows[0];
                       room_number = int.Parse(dr2["price"].ToString());
                   }
                   else
                   {
                       room_number = int.Parse(dr["price"].ToString());
                   }
               }
           }
           return room_number;//defapt room_number aici reprezinta pretul camerei curente
       }
       public int return_rid(int room_number)
       {
           //aici returnam numarului unei camere in fucntie de id-ul ei.adica introducem id si primim nr camerei
           String command_cleaner = "SELECT * FROM [polihilton].[dbo].[Rooms] [Rooms] WHERE r_number='" + room_number + "' ";
           DataSet ds1 = db1.Read(command_cleaner);
           foreach (DataTable table in ds1.Tables)
           {
               foreach (DataRow dr in table.Rows)
               {
                   room_number = int.Parse(dr["r_id"].ToString());
               }
           }
           return room_number;
       }
       public int return_uid(string u_name)
       {
           //aici introducem id unui user si ii aflam usernamul
           String command_cleaner = "SELECT * FROM [polihilton].[dbo].[Users] [Rooms] WHERE username='" + u_name + "' ";
           DataSet ds1 = db1.Read(command_cleaner);
           foreach (DataTable table in ds1.Tables)
           {
               foreach (DataRow dr in table.Rows)
               {
                   u_name=dr["u_id"].ToString();
               }
           }
           return int.Parse(u_name);
       }
       public void reception_dataset_populate(System.Windows.Forms.DataGridView g1)
       {
           DateTime reference = DateTime.UtcNow.AddDays(-1);
           String command_reception = "SELECT * FROM [polihilton].[dbo].[Users] JOIN [polihilton].[dbo].[Rezervations] on [polihilton].[dbo].[Users].u_id=[polihilton].[dbo].[Rezervations].u_id JOIN [polihilton].[dbo].[Rooms] on [polihilton].[dbo].[Rezervations].r_id=[polihilton].[dbo].[Rooms].r_id Where end_date>Convert(datetime,'" + reference + "')";
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
           string value=g1.Rows[rowindex].Cells[6].Value.ToString();
          // MessageBox.Show(g1.Rows[rowindex].Cells[6].Value.ToString());
           String db_command = "DELETE FROM [polihilton].[dbo].[Rezervations] Where rez_id='" +int.Parse(value)  + "' ";
           DataSet ds1 = db1.Read(db_command);
           MessageBox.Show("Reservation deleted!");
       }

       public void check_out(System.Windows.Forms.DataGridView g1)
       {
           int rowindex = g1.CurrentCell.RowIndex;
           string value = g1.Rows[rowindex].Cells[6].Value.ToString();
           DateTime reference = DateTime.UtcNow;
           
           String db_command = "UPDATE [polihilton].[dbo].[Rezervations] SET end_date=Convert(datetime,'" + reference + "') Where rez_id='" + int.Parse(value) + "'";
           db1.Command(db_command);
           DataGridViewRow row = g1.SelectedRows[0];
           int id_room = int.Parse(row.Cells["r_id"].Value.ToString());
           //aici mutam camera in dabelul de cleaning
           String db_command1 = "INSERT INTO [polihilton].[dbo].[Cleaning] (r_id,u_id,status,date_required)Values('" + id_room + "','2','Pending',Convert(datetime,'" + reference + "'))";
           db1.Command(db_command1);
           MessageBox.Show("User Checked out!");
       }
       


    }
}
