using System;
using System.Collections.Generic;
using System.Text;

namespace Lost___Found
{
    public class Employee : Person
    {
        

        public string EmployeeID { get; private set; }

        public Employee(string name, int age, string employeeID) : base(name, age)
        {

            EmployeeID = employeeID;
        }

        public void AddCustomer()
        {


        }
        public override string GetInfo()
        {
            string baseInfo = base.GetInfo();
            return $"{baseInfo} , EmployeeID: {EmployeeID}";
        }
        public void CloseTicket(Ticket ticket)
        {
            if (ticket.IsOpen)
            {
                ticket.Close();
                Console.WriteLine($"Ticket #{ticket.Ticketid} has been closed.");
            }
            else
            {
                Console.WriteLine($"Ticket #{ticket.Ticketid} is already closed.");
            }
        }
        public void sendingemail(Customer customer, string subject, string body)
        {
            Console.WriteLine($"Sending email to {customer.Email}...");
            Console.WriteLine($"Subject: {subject}");
            Console.WriteLine($"Body: {body}");
            
        }
        public void notifyCustomer(Ticket ticket, Item item)
        {
            if (ticket == null || item == null)
            {
                Console.WriteLine("Ticket or item cannot be null.");
                return;
            }

            if (!ticket.IsOpen)
            {
                Console.WriteLine($"Ticket #{ticket.Ticketid} is closed. No notification sent.");
                return;
            }

            if (string.Equals(ticket.Type, item.Type, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"Notifying {ticket.Creator.Name} about Ticket #{ticket.Ticketid}.");
                string subject = $"Matching item found for Ticket #{ticket.Ticketid}";
                string body = $"Hello {ticket.Creator.Name}, a matching item ({item.Type} - {item.Description}) has been found for your ticket #{ticket.Ticketid}.";
                sendingemail(ticket.Creator, subject, body);
            }
            else
            {
                Console.WriteLine($"Item '{item.Type}' does not match Ticket #{ticket.Ticketid} ('{ticket.Type}'). No notification sent.");
            }
        }
    }
}
