namespace Lost___Found
{
    public class Program
    {
        static void Main(string[] args)
        {
           Customer customer = new Customer("john doe",19,"john.doe@example.com","123-456-7890","teststreet 123");
            Ticket ticket = customer.OpenTicket("Wallet", "I lost my wallet in the park.");
            Console.WriteLine(customer.GetInfo());
            Console.WriteLine($"Ticket #{ticket.Ticketid} von {ticket.Creator.Name}: {ticket.Type}");
           // Console.WriteLine(ticket.GetInfo());
        }
    }
}
