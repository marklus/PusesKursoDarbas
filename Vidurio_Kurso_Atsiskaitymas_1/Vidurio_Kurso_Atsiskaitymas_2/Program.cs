using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vidurio_Kurso_Atsiskaitymas_2
{
    /*
     * Sukurti interface gyvūnas(minamlu kad turėtų vardą+
     * ir string tipo metodą kuris jį apibūdina),+
     * interface turi paveldėti bent 3 skirtingos klasės,+
     * main dalyje panaudoti visas klases,+
     * priskiriant objektą į vieną objektą.+? 
    */
    public interface IGyvunas
    {
        string Vardas { get; set; }
        int Metai { get; set; }
        int Svoris { get; set; }
        void Atspausdina();

    }


    class Suo : IGyvunas
    {
        public string Vardas{get; set;}
        public int Metai { get; set; }
        public int Svoris { get; set; }
        public void Atspausdina()
        {
            Console.WriteLine("Gyvuno vardas yra {0} amzius {1} svoris {2}", Vardas, Metai, Svoris);
        }

        public Suo(string vardas,int metai, int svoris)
        {
            this.Vardas = vardas;
            this.Metai = metai;
            this.Svoris = svoris;
        }
    }


    

    class Kate: IGyvunas

    {
        public string Vardas { get; set; }
        public int Metai { get; set; }
        public int Svoris { get; set; }

        public void Atspausdina()
        {
            Console.WriteLine("Gyvuno vardas yra {0} amzius {1} svoris {2}", Vardas, Metai, Svoris);
        }

        public Kate(string vardas, int metai, int svoris)
        {
            this.Vardas = vardas;
            this.Metai = metai;
            this.Svoris = svoris;
        }
    }

    class Pele: IGyvunas

    {
        public string Vardas { get; set; }
        public int Metai { get; set; }
        public int Svoris { get; set; }


        public void Atspausdina()
        {
            Console.WriteLine("Gyvuno vardas yra {0} amzius {1} svoris {2}", Vardas, Metai, Svoris);
        }

        public Pele(string vardas, int metai, int svoris)
        {
            this.Vardas = vardas;
            this.Metai = metai;
            this.Svoris = svoris;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Suo sun = new Suo("Bartas",8, 60);
            sun.Atspausdina();

            Kate kat = new Kate("Dzeris ", 3, 20);
            kat.Atspausdina();

            Pele pel = new Pele("Piteris ", 1, 1);
            pel.Atspausdina();

            Console.ReadLine();


        }
    }
}
