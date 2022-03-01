using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs4Tema
{
    internal class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public int CategoryId { get; set; }
        public Money Price { get; set; }
        public float WeightInKg { get; set; }

        public Product(int id, string name, string image, int categoryId, Money price, float wik)
        {
            Id = id;
            Name = name;
            Image = image;
            CategoryId = categoryId;
            Price = price;
            WeightInKg = wik;

            Console.WriteLine($"I have been created with the folowing values: " +
                $"{Id}, {Name}, {Image}, {CategoryId}, {Price.Amount} {Price.Currency}, {WeightInKg}");

        }
    }
}
