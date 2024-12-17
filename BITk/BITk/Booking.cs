using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BITk
{
    class Booking
    {
        DataBase DataBase;
        string type, status, guest;
        int price;
        DateTime BookedUntil;

        public Booking( DataBase DataBase)
        {
            this.DataBase = DataBase;
        }

        public void getStatus()
        { //takes data about the room from the database(type, status(occupied or not), price and the date it is free from
            //if the user is admin he can see the current guest of the room
        }

        public void reserve()
        {
            //when the user clicks on a room, something(smth smth dark side from WPF) will appear which will make a reservation
        }

        public void log_out()
        {
            Signning u1 = new Signning(this.DataBase);
        }
    }
}