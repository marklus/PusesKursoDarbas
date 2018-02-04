using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI_PER_Nauja
{
    public class Pasaulis
    {
        public List<Šalis> Šaliu_sarasas { get; private set; } = new List<Šalis>();

        public List<int> žmonių { get; private set; } = new List<int>();

        public Miestas DidžiausiasPlotas()
        {
            var gyv = Šaliu_sarasas.First().Miestu_sarasas.First();

            foreach (var šalis in Šaliu_sarasas)
            {
                foreach (var miestas in šalis.Miestu_sarasas)
                {
                    if (miestas.Plotas_kv_km > gyv.Plotas_kv_km)
                    {
                        gyv = miestas;
                    }
                }
            }
            return gyv;
        }


        public Miestas MažiausiasPlotas()
        {
            var gyv = Šaliu_sarasas.First().Miestu_sarasas.First();

            foreach (var šalis in Šaliu_sarasas)
            {
                foreach (var miestas in šalis.Miestu_sarasas)
                {
                    if (miestas.Plotas_kv_km < gyv.Plotas_kv_km)
                    {
                        gyv = miestas;
                    }
                }
            }
            return gyv;
        }

        public Miestas DaugiausiaiGyventoju()
        {
            var gyv = Šaliu_sarasas.First().Miestu_sarasas.First();

            foreach (var šalis in Šaliu_sarasas)
            {
                foreach (var miestas in šalis.Miestu_sarasas)
                {
                    if (miestas.GyvSkaicius > gyv.GyvSkaicius)
                    {
                        gyv = miestas;
                    }
                }
            }
            return gyv;
        }

        public Miestas MažiausiaiGyventoju()
        {
            var gyv = Šaliu_sarasas.First().Miestu_sarasas.First();

            foreach (var šalis in Šaliu_sarasas)
            {
                foreach (var miestas in šalis.Miestu_sarasas)
                {
                    if (miestas.GyvSkaicius < gyv.GyvSkaicius)
                    {
                        gyv = miestas;
                    }
                }
            }
            return gyv;
        }

        public int ŠaliųSkaičius()
        {
            var šalių = Šaliu_sarasas.First().Miestu_sarasas.First();
            int ŠalSk = 0;
            foreach (var šalis in Šaliu_sarasas)
            {

                int šaliųSkaicius = ŠalSk;
                šaliųSkaicius++;

            }
            return ŠalSk;
        }

        /*   public int ŠaliųSkaičius()
           {
               var šalių = Šaliu_sarasas.First().Miestu_sarasas.First();

               foreach (var šalis in Šaliu_sarasas)
               {

                   int šaliųSkaicius = kazkas;
                   šaliųSkaicius++;

               }
               return kazkas ;
           }*/

        /*public Miestas Bendras_Gyventojų_skaičius_Pasaulyje()
        {
            foreach (var šalis in Šaliu_sarasas)
            {
                foreach (var miestas in šalis.Miestu_sarasas)
                {
                    do
                    {

                    } while (true);
                }
            }
            return gyv;
        }*/



    }
}
