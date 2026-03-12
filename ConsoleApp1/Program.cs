using System;

namespace TransportCompany
{
    class Sofer
    {
        public int Id;
        public string Nume;
        public double Kilometri;

        public Sofer(int id, string nume)
        {
            Id = id;
            Nume = nume;
            Kilometri = 0;
        }
    }

    class Masina
    {
        public string Model;
        public string NumarInmatriculare;
        public double Kilometri;

        public Masina(string model, string numar)
        {
            Model = model;
            NumarInmatriculare = numar;
            Kilometri = 0;
        }
    }
    class Traseu
    {
        public string Plecare;
        public string Destinatie;
        public double Distanta;

        public Traseu(string plecare, string destinatie, double distanta)
        {
            Plecare = plecare;
            Destinatie = destinatie;
            Distanta = distanta;
        }
    }

    class Cursa
    {
        public Sofer sofer;
        public Masina masina;
        public double distanta;

        public Cursa(Sofer s, Masina m, double d)
        {
            sofer = s;
            masina = m;
            distanta = d;

            sofer.Kilometri += d;
            masina.Kilometri += d;
        }
    }
}
namespace TransportCompany
{
    class Program
    {
        static void Main(string[] args)
        {
            Sofer sofer1 = new Sofer(1, "Ana Antonescu");
            Masina masina1 = new Masina("Mercedes Sprinter", "SV10ABC");

            Traseu traseu1 = new Traseu("Suceava", "Cluj", 300);

            Cursa cursa1 = new Cursa(sofer1, masina1, traseu1.Distanta);

            Console.WriteLine("Sofer: " + sofer1.Nume);
            Console.WriteLine("Traseu: " + traseu1.Plecare + " -> " + traseu1.Destinatie);
            Console.WriteLine("Distanta: " + traseu1.Distanta + " km");

            Console.WriteLine("Kilometri parcursi de sofer: " + sofer1.Kilometri);
            Console.WriteLine("Kilometri parcursi de masina: " + masina1.Kilometri);
        }
    }
}