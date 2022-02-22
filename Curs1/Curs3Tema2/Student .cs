using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs3Tema2
{
    public class Student
    {
        private string nume, prenume, cnp, facultate;
        private short varsta;
        private float medie;
        private Program.SpecializareFacultate specializare;


        public string GetNume() { return nume; }
        public void SetNume(string nume) { this.nume = nume; }
        public string GetPrenume() { return prenume; }
        public void SetPrennume(string prenume) { this.prenume = prenume; }
        public string GetCnp() { return cnp; }
        public void SetCnp(string cnp) { this.cnp = cnp; }
        public string GetFacultate() { return facultate; }
        public void SetFacultate(string facultate) { this.facultate = facultate; }
        public short GetVarsta() { return varsta; }
        public void SetVarsta(short varsta) { this.varsta = varsta; }
        public float GetMedie() { return medie; }
        public void SetMedie(float medie) { this.medie = medie; }
        public Program.SpecializareFacultate GetSpecializare() { return specializare; }
        public void SetSpecializare(Program.SpecializareFacultate specializare) { this.specializare = specializare; }

        public void PrinteazaInformatiiComplete()
        {
            Console.WriteLine($"Studentul {nume} {prenume}, cnp {cnp}, cu varsta de {varsta} ani este student la" +
                $" {facultate}, specializarea {specializare} avand media {medie}");
        }
    }
}
