using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs4Tema
{
    internal static class Config
    {
        public static string CategoriesFolder { get; set; }
        public static string ProductsFolder { get; set; }
        public static string DatabaseFolder { get; set; }

        static Config()
        {
            CategoriesFolder = "categories";
            ProductsFolder = "products";
            DatabaseFolder = "database";
            Console.WriteLine($"I have been created with the folowing values: " +
                $"{CategoriesFolder}, {ProductsFolder}, {DatabaseFolder}");
        }
    }
}
