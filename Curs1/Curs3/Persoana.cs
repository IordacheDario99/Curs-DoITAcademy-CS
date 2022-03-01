using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs3
{
    internal class Persoana
    {
        //private string nume;
        //private string prenume;
        private int varsta;
        private string cnp;
        private bool esteBarbat;
        public string adresa;

        public Persoana()
        {

        }
        public Persoana(string nume, string prenume, int varsta)
        {
            this.Nume = nume;
            this.Varsta = varsta;
            this.Prenume = prenume;

        }
        public int getVarsta { get { return varsta; } }

        public string Nume { get; set; }
        public string Prenume { get; set; }
        public int Varsta { get; set; }

        protected string Cnp
        {
            get { return cnp; }
            set { cnp = value; }
        }
        public bool EsteBarbat
        {
            get { return esteBarbat; }
            set { esteBarbat = value; }
        }




        /*public void SetNume(string nume)
        {
            this.nume = nume;
        }
        public string GetPrenume()
        {
            return prenume;
        }
        public void SetPrenume(string prenume)
        {
            this.prenume = prenume;
        }

        public int GetVarsta()
        {
            return varsta;
        }
        public void SetVarsta(int varsta)
        {
            this.varsta = varsta;
        }

        public string GetCno()
        {
            return cnp;
        }
        public void SetCnp(string cnp)
        {
            this.cnp = cnp;
        }

        public bool GetEsteBarbat()
        {
            return esteBarbat;
        }
        public void SetEsteBarbat(bool esteBarbat)
        {
            this.esteBarbat = esteBarbat;
        }*/

        public void ShowSoemthing()
        {
            Console.WriteLine("prenumele meu este: " + Prenume);
        }

        public void SetNumeSiPrenume(string nume, string prenume)
        {
            Nume = nume;
            Prenume = prenume;

        }
        public void PrintNumeComplet()
        {
            System.Console.WriteLine("Numele si prenumele: " + Nume + " " + Prenume);
        }

        private string GetNumeComplet()
        {
            return Prenume + " " + Nume;
        }
        public void SchimbPrenume(string nouPrenume)
        {
            Prenume = nouPrenume;
        }

        public void SchimbaNumePrenumeCNP(string nume, string prenume = " PRENUME", string cnp = "CNP")
        {
            this.Nume = nume;
            this.Prenume = prenume;
            this.Cnp = cnp;
        }
    }
}
