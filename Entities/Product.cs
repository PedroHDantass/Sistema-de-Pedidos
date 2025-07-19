namespace Store.Entities
{
    internal class Product
    {

        //propriedades
        public string Name { get; set; }
        public double Price { get; set; }

        //construtores
        public Product()
        {

        }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
}
