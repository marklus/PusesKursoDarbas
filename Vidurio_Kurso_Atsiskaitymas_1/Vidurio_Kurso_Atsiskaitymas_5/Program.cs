using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vidurio_Kurso_Atsiskaitymas_5
{
    /*
     Sukurti programą naudojant delegatus,
     programa skirta marketingo programai, 
     pagal tai koks yra biudžetas 
     turi parinkti ar bus siunčiama puodukai ar ženkliukai ar tušinukai,
     į konsolės langą išvesti adresus kuriems bus siunčiamos marketingo dovanos.
     */

    class Program
    {
        public delegate void MyDelegatas(double b);
        public event MyDelegatas ManoIvykis;



        public void IvykioApdorojimas(double budget)
        {
            if (ManoIvykis!=null)
            {

            }        
        }

        public static void IvykisIvyko(double b)
        {
 

            List<string> adresai = new List<string>()
            {
                "adresas1","adresas2","adresas3"
            };
            List<double> biudzetai = new List<double>()
            {
                500,1500,3000
            };

            foreach (var budget in biudzetai)
            {

                if (budget >= 2000 && budget < 3000)
                {
                    Console.WriteLine("Puodukai");
                }

                else if (budget > 2000 && budget >= 3000)
                {
                    Console.WriteLine("zenkliukai");
                }

                else if (budget <= 1000)
                {
                    Console.WriteLine("tusinukai");
                }
            }
        }

        static void Main(string[] args)
        {

            Program p = new Program();
            p.ManoIvykis += new MyDelegatas(IvykisIvyko);

           Console.WriteLine("Koks biudžetas?");
            double b=Convert.ToDouble(Console.ReadLine());
            
            p.IvykioApdorojimas(b);

        }
    }
}
