namespace Curs4Tema
{
    public class Program
    {
        public static void Main(string [] args)
        {
            Category categ1 = new Category(1, "Prima Categorie", "categorie1.jpg", true);
            Category categ2 = new Category(2, "A Doua Categorie", "categorie2.jpg", false);
            Money priceProd1 = new Money(10, "RON");
            Money priceProd2 = new Money(15.5m, "RON");
            Money priceProd3 = new Money(7.5m, "RON");
            Product prod1 = new Product(1, "Produs 1", "produs1.jpg", 1, priceProd1, 0.5f);
            Product prod2 = new Product(2, "Produs 2", "produs2.jpg", 1, priceProd2, 0.75f);
            Product prod3 = new Product(3, "Produs 3", "produs3.jpg", 2, priceProd3, 1.25f);




        }
    }
}