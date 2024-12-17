using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.Data.Common;

namespace BITk
{
    public class DataBase
    {
        SqlConnection Hotel;
        public DataBase()
        {
            this.Hotel = new SqlConnection(@"Data Source=localhost;" +
                                            "Trusted_Connection=yes;" +
                                            "database=Hotel;" +
                                            "connection timeout=30");
        }
        public void init()
        {
            try
            {
                Hotel.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error Connection" + e.ToString());
            }
        }

        public void Command(string command)
        {

            using (SqlCommand myCommand = new SqlCommand(command, this.Hotel))
            {
                try
                {
                    myCommand.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error Insert" + e.ToString());
                }
            }

        }

        public DataSet Read(string command)
        {
            DataSet dsUniv = new DataSet();
            SqlDataAdapter daUniv = new SqlDataAdapter();
            daUniv = new SqlDataAdapter(command, Hotel);
            daUniv.Fill(dsUniv, "table");
            return dsUniv;
        }

        public void Close()
        {
            try
            {
                Hotel.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}