using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs3
{
    internal class Elev : Persoana
    {
        protected string Liceu { get; set; }
        public float MedieCapacitate { get; set; }

        public Elev( string liceu, float medieCapac) : base("Ionel", "Vasilescu", 23)
        {
            Liceu = liceu;
            MedieCapacitate = medieCapac;
        }


    }
}
