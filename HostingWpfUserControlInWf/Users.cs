using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostingWpfUserControlInWf
{
    public class Users
    {
     Database db1;
     int id;
     String firstname;
     String lastname;
    
        
       public Users(int id,String firstname,String lastname,Database db1)
        {
        this.db1=db1;
        this.id = id;
        this.firstname = firstname;
        this.lastname = lastname;
        }

       public Database get_Database()
       {
           return db1;
       }


    }
}
