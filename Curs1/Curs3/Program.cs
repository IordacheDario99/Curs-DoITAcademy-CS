using System;


namespace Curs3
{
    class Program
    {
        private string ala = "bala";
        //enum este o colectie de constante de tip int (strict int)        
        static void Main(string[] args)
        {
            Elev Andrei = new Elev();
            Student Dario = new Student();
            Student Alin = new Student();
            Persoana p1 = new Persoana();
            p1.adresa = "Strada Fericirii nr 54";
            Console.WriteLine(p1.adresa);
            p1.SetNumeSiPrenume("Ionica", "Vasile");
            p1.PrintNumeComplet();
            p1.SchimbPrenume("Petrica");
            p1.PrintNumeComplet();

            Persoana p4 = new Persoana();
            p4.SchimbaNumePrenumeCNP("NUME", "PRENUME", "1000");
            p4.PrintNumeComplet();
            var numeComplet =  p4.Prenume;
            Console.WriteLine(numeComplet);

            Persoana pers1 = new Persoana();
            pers1.Prenume = "Cursant";
            pers1.Nume = "DoItAcademy";


        }
    }


}
