using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs4Tema
{
    internal class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public bool IsNew { get; set; }

        public Category()
        {
            Id = 0;
            Name = "";
            Image = "";
            IsNew = true;
        }

        public Category(int id, string name, string image, bool isNew)
        {
            Id = id;
            Name = name;
            Image = image;
            IsNew = isNew;
            Console.WriteLine($"I have been created with the folowing values: " +
                $"{Id}, {Name}, {Image}, {IsNew}");
        }
    }
}
