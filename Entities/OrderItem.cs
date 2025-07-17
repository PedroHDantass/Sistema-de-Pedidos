namespace Store.Entities
{
    internal class OrderItem
    {
        public int Quatity { get; set; }

        public double Price { get; set; }

        public double SubTotal()
        {
            return Price * Quatity;
        }
    }
}
