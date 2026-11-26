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


        // neues ticket erstellen und daten vom kunden abfragen
        public static Ticket CreateFromInput(Customer creator)
        {
            Console.Write("Ticket-Typ eingeben : ");
            string type = Console.ReadLine() ?? "Allgemein";

            Console.Write("Beschreibung eingeben: ");
            string description = Console.ReadLine() ?? "";

            Console.Write("Ist das Ticket offen? (j/n): ");
            string inputOpen = Console.ReadLine()?.Trim().ToLower() ?? "j";
            bool isOpen = inputOpen == "j" || inputOpen == "ja";

            return new Ticket(type, description, isOpen, creator, DateTime.Now);
        }
       
        public void Close()
        {
            IsOpen = false;
        }

       public static List<Ticket> LoadFromFile(List<Customer> customers, string pfad = "tickets.txt")
       {
           List<Ticket> liste = new List<Ticket>();
          if (!File.Exists(pfad)) return liste;

           foreach (string zeile in File.ReadAllLines(pfad))
           {
             string[] teile = zeile.Split(';');
              if (teile.Length >= 4
                  && bool.TryParse(teile[2], out bool isOpen)
                  && int.TryParse(teile[3], out int creatorIndex)
                  && creatorIndex >= 0 && creatorIndex < customers.Count)
              {
                 Customer ersteller = customers[creatorIndex];
                  Ticket t = new Ticket(teile[0], teile[1], isOpen, ersteller, DateTime.Now);
                 liste.Add(t);
                  ersteller.tickets.Add(t);
              }
           }
          return liste;
       }
    }
}
