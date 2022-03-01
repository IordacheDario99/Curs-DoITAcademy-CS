using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs3
{
    internal class Student : Persoana
    {
        protected string Facultate { get; set; }
        protected float Medie { get; set; }

        public void PrinteazaInformatiiComplete()
        {
            Console.WriteLine($"Studentul {Nume} {Prenume}, cnp {Cnp}, cu varsta de {Varsta} ani, " +
                $"student la facultatea {Facultate} cu media {Medie}");
        }
    }
}
