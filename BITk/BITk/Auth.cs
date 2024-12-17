using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BITk
{
    public class Auth
    {
        DataBase db1;

        public Auth(DataBase db1)
        {
            this.db1 = db1;
        }

        public Auth()
        {
        }

        public int login(string username, string password)
        {
            int result = 0;

            try
            {
                string query = "SELECT UserTypeId FROM Users WHERE Username = @username AND Password = @password";

                using (SqlConnection connection = new SqlConnection("your_connection_string"))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);
                    adapter.SelectCommand = command;

                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                    {
                        result = Convert.ToInt32(ds.Tables[0].Rows[0]["RoleId"]);
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            return result;
        }

        public void create_user(string username, string password, string firstname, string lastname)
        {
            int UserTypeID = 1;
            string db_command = "SELECT FROM [Hotel].[dbo].[Users] (u_type_id,username,password,firstName,lastName)Values('" + UserTypeID + "','" + username + "','" + password + "','" + firstname + "','" + lastname + "')";
            DataSet ds1 = db1.Read(db_command);
            if (ds1.Tables[0].Rows.Count != 0)
            {
                MessageBox.Show("User is already taken");
            }
            else
            {
                try
                {
                    string db_command1 = "INSERT INTO [Hotel].[dbo].[Users] (u_type_id,username,password,firstName,lastName)Values('" + UserTypeID + "','" + username + "','" + password + "','" + firstname + "','" + lastname + "')";
                    db1.Command(db_command1);
                    MessageBox.Show("User created succesfully!");
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error Insert" + e.ToString());
                }
            }
        }
    }
}