namespace Curs3Tema2
{
    public class Program
    {
        public enum SpecializareFacultate
        {
            AUTOMATICA = 1,
            ELECTRONICA = 2,
            COMUNICATII = 3,
            AUTO = 4,
            FINANTE = 5,
            CONTABILITATE = 6
        }
        public static void Main(string[] args)
        {
            Student stud1 = new Student();
            stud1.SetNume("Yu-Pei");
            stud1.SetPrennume("Sun");
            stud1.SetCnp("1922111234764");
            stud1.SetFacultate("Politehnica");
            stud1.SetVarsta(28);
            stud1.SetSpecializare(SpecializareFacultate.FINANTE);
            stud1.SetMedie(9.87f);
            stud1.PrinteazaInformatiiComplete();

            Student stud2 = new Student();
            stud2.SetNume("Popescu");
            stud2.SetPrennume("Ion");
            stud2.SetCnp("1800518171704");
            stud2.SetFacultate("Politehnica");
            stud2.SetVarsta(25);
            stud2.SetSpecializare(SpecializareFacultate.AUTOMATICA);
            stud2.SetMedie(8.45f);
            stud2.PrinteazaInformatiiComplete();
        }
    }

}