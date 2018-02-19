using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vidurio_Kurso_Atsiskaitymas_1
{
    /*
     * Sukurti klasę pavadinimu mokykla. Joje būtų kintamieji:
     * klasės skaičius, +
     * klasės raidė, +
     * mokinių skaičius, +
     * mokymosi pradžios metai, +
     * metodas skirtas apskaičiuoti kiek metų mokiniai jau mokosi. 
     * Sukurti paveldimą klasę pavadinimu klasė. +
     * Informacija būtų paveldima iš prieš tai buvusios klasės. +
     * Papildomai klasė turėtų sąrašą su mokinių vardais
     * ir masyvą su jų vidurkiais.
     */

    public class mokykla
    {
        public int KlasesSkaicius { get; set; }
        public char KlasesRaide { get;  }
        public int MokiniuSkaicius { get; set; }
        public int MokymosiPradziosMetai { get; set; }

      /*  public mokykla(int KlSkaicius,char KlRaide, int MokSkaicius,int PradziosM)
        {
            this.KlasesSkaicius = KlasesSkaicius;
            this.KlasesRaide = KlRaide;
            this.MokiniuSkaicius = MokSkaicius;
            this.MokymosiPradziosMetai = PradziosM;
        }*/

        public mokykla(int KlasesSkaicius,  int MokiniuSkaicius, int MokymosiPradziosMetai)
        {

        }

        public void KiekMetuMokosi(int MokymosiPradziosMetai)
        {
        
            int KiekMokos = 2018 - MokymosiPradziosMetai;
            Console.WriteLine("Mokiniai mokosi jau {0} .m", KiekMokos);
        }

    }

    public class klase : mokykla
    {
        public klase(int KlasesSkaicius,  int MokiniuSkaicius, int MokymosiPradziosMetai)
            : base(KlasesSkaicius, MokiniuSkaicius, MokymosiPradziosMetai)

        {
            
        }

        public void vidurkiai()
        {

            Console.WriteLine("Iveskite mokiniu skaičiu");
            int MokiniuSkaicius = Convert.ToInt32(Console.ReadLine());
            double[] vidurkiai=new double[MokiniuSkaicius];

            List<string> vardai = new List<string>();
            Console.WriteLine("Iveskite vidurkius");

            for (int i = 0; i < MokiniuSkaicius; i++)
            {
                vidurkiai[i]= Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine("Vidurkiai yra\n");
            foreach (double vidurkis in vidurkiai)
            {
                Console.WriteLine(vidurkis);
            }

        }

        public void vardai()
        {
            Console.WriteLine("Iveskite mokiniu skaičiu");
            int MokiniuSkaicius = Convert.ToInt32(Console.ReadLine());
            List<string> vardai = new List<string>();
            Console.WriteLine("Iveskite vardus");

            for (int i = 0; i < MokiniuSkaicius; i++)
            {

                vardai.Add(Console.ReadLine());

            }

            Console.WriteLine("Vardai yra\n");
            foreach (string vardas in vardai)
            {
                Console.WriteLine(vardas);
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Nuo kelintų metų pradėjo mokytis mokiniai");
            int MokymosiPradziosMetai = Convert.ToInt32(Console.ReadLine());

            mokykla mok = new mokykla(10,10,10);
            klase kl = new klase(10,10,10);

            kl.vardai();
            kl.vidurkiai();

            mok.KiekMetuMokosi(MokymosiPradziosMetai);
        }
    }
}
