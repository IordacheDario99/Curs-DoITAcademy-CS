using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs6Tema
{
    public class Shop
    {
        public List<Products> Products  { get; set; }
        public List<Category> Category { get; set; }

        public Shop()
        {
            Products = new List<Products>();
            Category = new List<Category>();
        }
    }
}
