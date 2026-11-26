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

        public Customer AddCustomer(List<Customer> customers)
        {
            Console.Write("Name des Kunden eingeben: ");
            string name = Console.ReadLine()?.Trim() ?? "";

            int age;
            while (true)
            {
                Console.Write("Alter des Kunden eingeben: ");
                if (int.TryParse(Console.ReadLine(), out age) && age >= 0)
                {
                    break;
                }
                Console.WriteLine("Ungültige Eingabe. Bitte eine gültige Zahl für das Alter eingeben.");
            }

            Console.Write("E-Mail eingeben: ");
            string email = Console.ReadLine()?.Trim() ?? "";

            Console.Write("Telefonnummer eingeben: ");
            string phonenumber = Console.ReadLine()?.Trim() ?? "";

            Console.Write("Adresse eingeben: ");
            string adresse = Console.ReadLine()?.Trim() ?? "";

            Customer newCustomer = new Customer(name, age, email, phonenumber, adresse);
            customers?.Add(newCustomer);

            Console.WriteLine($"Kunde '{newCustomer.Name}' wurde erfolgreich angelegt.");
            return newCustomer;
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
