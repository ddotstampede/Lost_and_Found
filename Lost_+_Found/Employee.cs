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
                ticket.IsOpen = false;
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
            // Here you can implement the actual email sending logic.
        }
        public void notifyCustomer(Ticket ticket)
        {
            if (ticket.Type == Item.Type)
            {
                Console.WriteLine($"Notifying {ticket.Creator.Name} about Ticket #{ticket.Ticketid}.");
                // Here you can implement the actual notification logic, e.g., sending an email.
            }
            else
            {
                Console.WriteLine($"Ticket #{ticket.Ticketid} is closed. No notification sent.");
            }
        }
    }
}
