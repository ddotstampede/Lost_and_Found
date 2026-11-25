namespace Lost___Found
{
    public class Program
    {
        // ki hat hier geholfen für ki teil der aufgabe
        static List<Customer> customers = new List<Customer>();
        static List<Employee> employees = new List<Employee>();
        static List<Ticket> tickets = new List<Ticket>();
        static List<Item> items = new List<Item>();
        static void Main(string[] args)
        {
           Customer customer = new Customer("john doe",19,"john.doe@example.com","123-456-7890","teststreet 123");
            Ticket ticket = customer.OpenTicket();
            Console.WriteLine(customer.GetInfo());
            Console.WriteLine($"Ticket #{ticket.Ticketid} von {ticket.Creator.Name}: {ticket.Type}");
           // Console.WriteLine(ticket.GetInfo());
        }
    }
}
