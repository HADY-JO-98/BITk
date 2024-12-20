﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows;
using System.Windows.Forms;

namespace BITk
{
    internal class Cleaning
    {
        DataBase db1;
        int id;
        string firstname;
        string lastname;
        string username;

        public Cleaning(DataBase db1, int id, string firstname, string lastname, string username, System.Windows.Forms.Label l1)
        {
            this.db1 = db1;
            this.id = id;
            this.firstname = firstname;
            this.lastname = lastname;
            this.username = username;
        }

        public Cleaning(int v1, string v2, string v3, string v4, DataBase db1, Label form3_label_name)
        {
            this.db1 = db1;
        }

        public DataSet list_assigned_rooms(System.Windows.Forms.ListBox l1)
        {
            l1.Items.Clear();
            DataSet ds_rooms = new DataSet();
            String command_cleaner = "SELECT * FROM [Hotel].[dbo].[Cleaning] JOIN [polihilton].[dbo].[Rooms] ON Cleaning.r_id=Rooms.r_id WHERE u_id='" + id + "' AND status NOT LIKE 'Cleaned'";
            DataSet ds1 = db1.Read(command_cleaner);
            foreach (DataRow dr in ds1.Tables[0].Rows)
            {
                String line = "room id: " + dr.ItemArray.GetValue(1).ToString() + " Room Number: " + dr.ItemArray.GetValue(7).ToString() + "  status: " + dr.ItemArray.GetValue(3).ToString();
                l1.Items.Add(line);
            }
            return ds_rooms;
        }

        public void in_progress(System.Windows.Forms.ListBox l1)
        {
            char[] separator = { ' ' };
            try
            {
                string[] words = l1.SelectedItem.ToString().Split(separator, StringSplitOptions.RemoveEmptyEntries);
                String command = "UPDATE [Hotel].[dbo].[Cleaning] SET status = 'In progress' WHERE r_id = '" + words[2] + "'";
                db1.Command(command);
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }
        }

        public void cleaned(System.Windows.Forms.ListBox l1)
        {
            char[] separator = { ' ' };
            try
            {
                string[] words = l1.SelectedItem.ToString().Split(separator, StringSplitOptions.RemoveEmptyEntries);
                String command = "UPDATE [Hotel].[dbo].[Cleaning] SET status = 'Cleaned' WHERE r_id = '" + words[2] + "'";
                db1.Command(command);
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }
        }

        public void log_out()
        {
            Signning f1 = new Signning(this.db1);
//            Form3.ActiveForm.Hide();
//            f1.Show();
        }
    }
}
