namespace Lost___Found
{
    public class Program
    {
        // ki hat hier geholfen für ki teil der aufgabe
        static List<Customer> customers = new List<Customer>();
        static List<Employee> employees = new List<Employee>();
        static List<Ticket> tickets = new List<Ticket>();
        static List<Item> items = new List<Item>();
       
           //Customer customer = new Customer("john doe",19,"john.doe@example.com","123-456-7890","teststreet 123");
           // Ticket ticket = customer.OpenTicket();
           // Console.WriteLine(customer.GetInfo());
           // Console.WriteLine($"Ticket #{ticket.Ticketid} von {ticket.Creator.Name}: {ticket.Type}");
            // Console.WriteLine(ticket.GetInfo());
            static void Main(string[] args)
            {
                bool running = true;

                while (running)
                {
                    Console.WriteLine("\n=== Lost & Found ===");
                    Console.WriteLine("1. Kunde anlegen");
                    Console.WriteLine("2. Mitarbeiter anlegen");
                    Console.WriteLine("3. Ticket für einen Kunden anlegen");
                    Console.WriteLine("4. Fundstück (Item) anlegen");
                    Console.WriteLine("5. Kunde benachrichtigen (Ticket mit Fundstück abgleichen)");
                    Console.WriteLine("6. Ticket schließen");
                    Console.WriteLine("7. Übersicht anzeigen");
                    Console.WriteLine("0. Beenden");
                    Console.Write("Auswahl: ");

                    string auswahl = Console.ReadLine()?.Trim() ?? "";

                    switch (auswahl)
                    {
                        case "1":
                            customers.Add(new Customer("Geralt", 55, "geralt@rivia.com", "1048596", "kovstrasse 576"));
                            break;
                        case "2":
                            employees.Add(new Employee("roche", 21, "1"));
                            break;
                        case "3":
                            tickets.Add(customers[0].OpenTicket());
                            break;
                        case "4":
                            items.Add(new Item("Schlüssel", "Ein einzelner Schlüssel mit einem roten Schlüsselanhänger."));
                            break;
                        case "5":
                            // KundeBenachrichtigen();
                            employees[0].notifyCustomer(tickets[0], items[0]);
                            break;
                        case "6":
                            // TicketSchliessen();
                            employees[0].CloseTicket(tickets[0]);
                            break;
                        case "7":
                            // UebersichtAnzeigen();
                            break;
                        case "0":
                            running = false;
                            Console.WriteLine("Programm wird beendet.");
                            break;
                        default:
                            Console.WriteLine("Ungültige Eingabe. Bitte eine Zahl von 0 bis 7 eingeben.");
                            break;
                    }
                }
            }
        }
    }

