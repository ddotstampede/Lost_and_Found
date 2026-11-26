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
                //[^1] vorübergehend lösung die nur das letzte element in der liste nimmt, sollte später durch eine auswahl ersetzt werden
             
                switch (auswahl)
                    {
                        case "1":
                            customers.Add(new Customer("Geralt", 55, "geralt@rivia.com", "1048596", "kovstrasse 576"));
                            break;
                        case "2":
                            employees.Add(new Employee("roche", 21, "1"));
                            break;
                        case "3":
                            tickets.Add(customers[^1].OpenTicket());
                            break;
                        case "4":
                            items.Add(new Item("Schlüssel", "Ein einzelner Schlüssel mit einem roten Schlüsselanhänger."));
                            break;
                        case "5":
                            
                            employees[0].notifyCustomer(tickets[^1], items[^1]);
                            break;
                        case "6":
                           
                            employees[0].CloseTicket(tickets[^1]);
                            break;
                        case "7":
                            showsaveddata();
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

            static void showsaveddata()
            {
                Console.WriteLine("\n================ ÜBERSICHT ================");

                Console.WriteLine("\n--- Kunden ---");
                if (customers.Count == 0)
                {
                    Console.WriteLine("  (Keine Kunden vorhanden)");
                }
                else
                {
                    for (int i = 0; i < customers.Count; i++)
                    {
                        Console.WriteLine($"  {i + 1}. {customers[i].GetInfo()}");
                    }
                }

                Console.WriteLine("\n--- Mitarbeiter ---");
                if (employees.Count == 0)
                {
                    Console.WriteLine("  (Keine Mitarbeiter vorhanden)");
                }
                else
                {
                    for (int i = 0; i < employees.Count; i++)
                    {
                        Console.WriteLine($"  {i + 1}. {employees[i].GetInfo()}");
                    }
                }

                Console.WriteLine("\n--- Tickets ---");
                if (tickets.Count == 0)
                {
                    Console.WriteLine("  (Keine Tickets vorhanden)");
                }
                else
                {
                    foreach (Ticket ticket in tickets)
                    {
                        string status = ticket.IsOpen ? "Offen" : "Geschlossen";
                        Console.WriteLine($"  Ticket #{ticket.Ticketid} | Typ: {ticket.Type} | Beschreibung: {ticket.Description} | Ersteller: {ticket.Creator.Name} | Datum: {ticket.DateTime:dd.MM.yyyy HH:mm} | Status: {status}");
                    }
                }

                Console.WriteLine("\n--- Fundstücke (Items) ---");
                if (items.Count == 0)
                {
                    Console.WriteLine("  (Keine Fundstücke vorhanden)");
                }
                else
                {
                    for (int i = 0; i < items.Count; i++)
                    {
                        Console.WriteLine($"  {i + 1}. Typ: {items[i].Type} | Beschreibung: {items[i].Description}");
                    }
                }

                Console.WriteLine("\n===========================================");
            }
            
        }
    }

