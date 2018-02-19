using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Vidurio_Kurs0_Atsiskaitymas_4
{
    /*Sukurti programą kuri naudodama išimtis pasakytų kuris asmuos iš listo yra dar vaikas,
     * kuris yra jau pensininkas,
     * duomenis nuskaityti iš txt failo. */


    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int amzius;
                string vardas;

                StreamReader reader = new StreamReader(@"C:/Users/Martynas/source/repos/Vidurio_Kurso_Atsiskaitymas_1/Vidurio_Kurso_Atsiskaitymas_3/failas.txt");
                string duomenys = reader.ReadToEnd();

                Console.WriteLine(duomenys);

                string[] eilutes = duomenys.Split(' ');

                foreach (string eil in eilutes)
                {

                    vardas = eilutes[0].Trim();
                    amzius = Int32.Parse(eilutes[1]);

                    if (amzius <= 12)
                    {
                        Console.WriteLine("{0} yra vaikas", vardas);
                    }

                    if (amzius > 12 && amzius > 52)
                    {
                        Console.WriteLine("{0} yra senioras", vardas);
                    }

                }

                reader.Close();
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
        }
    }
}
