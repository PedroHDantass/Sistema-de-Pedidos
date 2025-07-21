using Store.Entities;
using Store.Entities.Enums;
using System.Globalization;

namespace Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data: ");

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.Write("Birth date (DD/MM/YYYY): ");

            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            Client client = new Client(name, email, birthDate);

            Console.WriteLine();

            Console.WriteLine("Enter order date:");

            Console.Write("Status (PedingPayment, Processing, Shipped, Delivered): ");

            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Console.WriteLine();

            Console.Write("How many items to this order? ");

            int n = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Order order = new Order(DateTime.Now, status, client);

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");

                Console.Write("Product name: ");
                string nameProduct = Console.ReadLine();
                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quatity: ");
                int quantity = int.Parse(Console.ReadLine());

                Product product = new Product(nameProduct, price);

                OrderItem orderItem = new OrderItem(quantity,price, product);          
            
                order.AddItem(orderItem);

                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine(order);         
        }
    }
}