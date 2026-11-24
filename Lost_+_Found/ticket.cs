using System;
using System.Collections.Generic;
using System.Text;

namespace Lost___Found
{
    public class Ticket
    {

        public static int TicketCounter = 1;
        public int Ticketid { get; private set; }
        public string Type { get; private set; }
        public string Description { get; private set; }
        public Customer Creator { get; private set; }
        public DateTime DateTime { get; private set; } = DateTime.Now;
        public bool IsOpen { get; private set ; }

        public Ticket( string name, string description, bool isOpen, Customer creator, DateTime dateTime)
        {
            Ticketid = TicketCounter++;
            Type = name;
            Description = description;
            IsOpen = isOpen;
            Creator = creator;
            DateTime = DateTime.Now;

        }

        
        //Todo methode ausarbeiten
       
    


}
   
}
