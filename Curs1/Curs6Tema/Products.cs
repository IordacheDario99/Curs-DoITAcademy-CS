namespace Curs6Tema
{
    public class Products
    {
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public float ProductPrice { get; set; }
        public Category ProductCategory { get; set; }

        public Products(string name, string description, float price, Category category)
        {
            ProductName = name;
            ProductDescription = description;
            ProductPrice = price;
            ProductCategory = category;
        }
    }
}