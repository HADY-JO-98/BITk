using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace HostingWpfUserControlInWf
{   
    class Booking
    {
        Database database;
        String type, status, guest;
        int price;
        DateTime occupiedUntil;
        UserControl1 uc;

        public Booking(Database database, UserControl1 uc)
        {
            this.database = database;
            this.uc=uc;
        }

        public int[] getStatus(DateTime arrivalDate, DateTime departureDate, Label label1)
        {
            int[] occupiedRooms=new int[100];
            int occupiedRoomNo;
            int index=0;
            int roomId = 0;
            Button button = new Button();
            DataSet dsReservations, dsRooms;
            
            database.init();
            dsReservations = database.Read("Select * from Rezervations", "Rezervations");
            foreach (DataRow dr in dsReservations.Tables["Rezervations"].Rows)
            {
                DateTime? start_rez = (DateTime?)dr["start_date"];
                DateTime? end_rez = (DateTime?)dr["end_date"];
                if (!(arrivalDate.Ticks > end_rez.Value.Date.Ticks || departureDate.Ticks < start_rez.Value.Date.Ticks))
                {  
                    roomId = (int)dr["r_id"];
                    dsRooms = database.Read("Select * from Rooms where r_id="+roomId,"Rooms");                
                    foreach (DataRow data in dsRooms.Tables["Rooms"].Rows)
                    {  occupiedRooms[index]=(int)data["r_number"];
                       index++;
                       String name = "button" + occupiedRooms[index - 1].ToString(); 
                       object item = uc.LayoutRoot.FindName(name);
                       if (item is Button)
                        {   Button btn = (Button)item;
                            btn.Background = new SolidColorBrush(Colors.Red);   
                            btn.Opacity=0.4;   
                            
                        }
                        
                        /*
                            if (name == "button112" || name == "button113" || name == "button205" || name == "button210" || name == "button211")
                            {
                                Path btn = (Button)item;
                                btn.Background.Fill = new SolidColorBrush(Colors.Red);
                                btn.Opacity = 0.4;
                            }*/
                    }                
                }
            }
            return occupiedRooms;
        }

        public String toolTipText(DateTime arrivalDate, DateTime departureDate)
        {
            String text="";
            if (arrivalDate == null || departureDate == null) { 
               
            }
            return text;
        }

        public void reserve() { 
          //when the user clicks on a room, something(smth smth dark side from WPF) will appear which will make a reservation
        }

    }
}
