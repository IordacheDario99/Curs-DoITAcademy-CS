namespace Curs3Tema
{
    public class Program
    {
        public static void Main(string[] args)
        {
            TriunghiEchilateral te1 = new TriunghiEchilateral();
            TriunghiEchilateral te2 = new TriunghiEchilateral();
            te1.Latura = 5.5;
            te1.Nume = "Triunghi echilateral 1";
            te1.AfiseazaAria();
            te1.AfiseazaPerimetrul();
            Console.WriteLine();

            te2.Latura = 20;
            te2.Nume = "Triunghi echilateral 2";
            te2.AfiseazaAria();
            te2.AfiseazaPerimetrul();
            Console.WriteLine();

            TriunghiDreptunghic td1 = new TriunghiDreptunghic();
            td1.Nume = "Triunghi Dreptunghic 1";
            td1.Cateta1 = 10;
            td1.Cateta2 = 5;
            td1.AfiseazaAria();
            td1.AfiseazaPerimetrul();
            Console.WriteLine();

            Cerc c1 = new Cerc();
            c1.Nume = "Cerc 1";
            c1.Raza = 7.8;
            c1.AfiseazaAria();
            c1.AfiseazaPerimetrul();
            Console.WriteLine();

            Dreptunghi dr1 = new Dreptunghi();
            Dreptunghi dr2 = new Dreptunghi();
            dr1.Nume = "Dreptunghi 1";
            dr2.Nume = "Dreptunghi 2";

            dr1.Lungime = 10;
            dr1.Latime = 2;

            dr2.Lungime = 5;
            dr2.Latime = 2;

            dr1.AfiseazaAria();
            dr1.AfiseazaPerimetrul();
            Console.WriteLine();

            dr2.AfiseazaAria();
            dr2.AfiseazaPerimetrul();
            Console.WriteLine();



        }
    }

}