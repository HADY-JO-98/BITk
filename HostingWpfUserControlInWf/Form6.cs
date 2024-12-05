using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HostingWpfUserControlInWf;

namespace PoliHilton
{
    public partial class Form6 : Form
    {
        Users u1;
        Booking b1;
        UserControl1 wpf = new UserControl1();
      
        public Form6() {
            InitializeComponent();
        }
      /*  public Form6(Users u1)
        {
            InitializeComponent();
            b1 = new Booking(u1.get_Database());
            this.u1 = u1;
            this.Show();
        } */

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            wpf.button101.Visible = false;
        }
    }
}
