using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//This class is used for Form6(iza)

namespace PoliHilton
{   
    class Booking
    {
        Database database;
        String type, status, guest;
        int price;
        DateTime occupiedUntil;
        
        public Booking(Database database)
        {
            this.database = database;
        }

        public void getStatus()
        { //takes data about the room from the database(type, status(occupied or not), price and the date it is free from
            //if the user is admin he can see the current guest of the room
        }
        public void reserve() { 
          //when the user clicks on a room, something(smth smth dark side from WPF) will appear which will make a reservation
        }

        public void log_out()
        {
            Form1 f1 = new Form1(this.database);
        }


    }
}
