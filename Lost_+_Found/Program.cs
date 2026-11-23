namespace Lost___Found
{
    public class Program
    {
        static void Main(string[] args)
        {
           Customer customer = new Customer("john doe",19,"john.doe@example.com","123-456-7890","teststreet 123");
           Console.WriteLine(customer.GetInfo());
        }
    }
}
