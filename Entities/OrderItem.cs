namespace Store.Entities
{
    internal class OrderItem
    {
        public int Quatity { get; set; }

        public double Price { get; set; }

        public Product Product { get; set; }

        public OrderItem() { }

        public OrderItem(int quatity, double price, Product product)
        {
            Quatity = quatity;
            Price = price;
            Product = product;
        }

        public double SubTotal()
        {
            return Price * Quatity;
        }
    }
}
