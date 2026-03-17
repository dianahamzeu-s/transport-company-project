using System;
using System.Collections.Generic;

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
        static List<Sofer> soferi = new List<Sofer>();

        static void Main(string[] args)
        {
            string optiune;

            do
            {
                Console.WriteLine("\n=== MENIU ===");
                Console.WriteLine("1. Adauga sofer");
                Console.WriteLine("2. Afiseaza soferi");
                Console.WriteLine("3. Cauta sofer dupa nume");
                Console.WriteLine("0. Iesire");

                Console.Write("Alege optiunea: ");
                optiune = Console.ReadLine();

                switch (optiune)
                {
                    case "1":
                        AdaugaSofer();
                        break;
                    case "2":
                        AfiseazaSoferi();
                        break;
                    case "3":
                        CautaSofer();
                        break;
                }

            } while (optiune != "0");
        }

        static void AdaugaSofer()
        {
            Console.Write("ID: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Nume: ");
            string nume = Console.ReadLine();

            Sofer s = new Sofer(id, nume);
            soferi.Add(s);

            Console.WriteLine("Sofer adaugat!");
        }

        static void AfiseazaSoferi()
        {
            if (soferi.Count == 0)
            {
                Console.WriteLine("Nu exista soferi.");
                return;
            }

            foreach (Sofer s in soferi)
            {
                Console.WriteLine($"ID: {s.Id}, Nume: {s.Nume}, Km: {s.Kilometri}");
            }
        }

        static void CautaSofer()
        {
            Console.Write("Introdu nume: ");
            string nume = Console.ReadLine();

            foreach (Sofer s in soferi)
            {
                if (s.Nume.ToLower() == nume.ToLower())
                {
                    Console.WriteLine($"Gasit: {s.Nume}, Km: {s.Kilometri}");
                    return;
                }
            }

            Console.WriteLine("Soferul nu a fost gasit.");
        }
    }
}
