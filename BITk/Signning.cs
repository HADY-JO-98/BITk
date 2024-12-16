using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BITk
{
    public partial class Signning : Form
    {
        Auth a1;
        DataBase db1;
        private DataBase dataBase;

        public Signning()
        {
            InitializeComponent();
            db1 = new DataBase();
        }

        public Signning(DataBase dataBase)
        {
            this.dataBase = dataBase;
        }

        private void _Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Drawing2D.LinearGradientBrush gradientBrush = new System.Drawing.Drawing2D.LinearGradientBrush(this.ClientRectangle, Color.Beige, Color.DarkGreen, System.Drawing.Drawing2D.LinearGradientMode.Vertical);
                e.Graphics.FillRectangle(gradientBrush, this.ClientRectangle);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = a1.login(textBox3.Text.ToString(), textBox3.Text.ToString());
            switch (id)
            {
                case 1: login_user(textBox3.Text.ToString()); this.Hide(); break;
                case 2: login_admin(textBox3.Text.ToString()); this.Hide(); break;
                case 3: login_cleaner(textBox3.Text.ToString()); this.Hide(); break;
                case 4: login_reception(textBox3.Text.ToString()); this.Hide(); break;
            }
        }
        public void login_user(string username)
        {
            Form4 f4 = new Form4(username, this.db1);
        }
        public void login_admin(string username)
        {
            Main m1 = new Main(username, this.db1);
        }
        public void login_cleaner(string username)
        {
            Room f3 = new Room(username, this.db1);
        }
        public void login_reception(string username)
        {
            Reservation f4 = new Reservation(username, this.db1);
        }
    }
}
