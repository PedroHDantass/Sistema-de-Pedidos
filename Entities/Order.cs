using Store.Entities.Enums;
using System.Text;
namespace Store.Entities
{
    internal class Order
    {
        public DateTime Moment {  get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
        public Order() { }
        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }

        public double Total()
        {
            double sum=0;

            foreach (OrderItem i in Items)
            {
                sum += i.SubTotal();
            }

            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("ORDER SUMMARY");
            sb.AppendLine("Order moment: "+ Moment);
            sb.AppendLine("Order Status: "+ Status);
            sb.AppendLine("");
            sb.AppendLine($"Client: {Client.Name} ({Client.BirthDate}) - {Client.Email}");
            sb.AppendLine("Order items");
            foreach (OrderItem i in Items)

            {
                sb.AppendLine($"{i.Product.Name}, {i.Price},  Quantity: {i.Quatity}, Subtotal: ${i.SubTotal()}");
            }

            sb.AppendLine("Total price: "+ Total());

            return sb.ToString();
        }
    }
}
