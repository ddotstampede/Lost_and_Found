using System;
using System.Collections.Generic;
using System.Text;

namespace Lost___Found
{
    public class Ticket
    {   

        private static int TicketCounter = 1;
        private int Ticketid { get; set; }
        private string Name { get; set; }
        private string Description { get; set; }
        private DateTime DateTime { get; set; } = DateTime.Now;
        private bool IsOpen { get; set; }

        public Ticket( string name, string description, bool isOpen)
        {
            Ticketid = TicketCounter++;
            Name = name;
            Description = description;
            IsOpen = isOpen;

        }

        
        //Todo methode ausarbeiten
        public static Ticket  OpenTicket( string name, string description)
        {
           return new Ticket(name, description, true );
        }
    


}
   
}
