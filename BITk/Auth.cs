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

        public int login(string username, string password)
        {
            string db_command = "SELECT * FROM [Hotel].[dbo].[Users] WHERE Username='" + username + "' AND Password='" + password + "'";
            DataSet ds = new DataSet();
            if (ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("User and pass combination not foumd");
                return 0;
            }
            else
            {
                DataRow dr1 = ds.Tables[0].Rows[0];
                return int.Parse(dr1["UserTypeID"].ToString());
            }
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