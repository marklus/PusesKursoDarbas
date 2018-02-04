using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI_PER_Nauja
{
   public class Miestas
    {
        public List<Šalis> Šaliu_sarasas { get; private set; } = new List<Šalis>();

        public string Pavadinimas { get; private set; }
        public int GyvSkaicius { get; private set; }
        public int Plotas_kv_km { get; private set; }


        public Miestas(string pavadinimas, int gyvSkaicius, int plotas_kv_km)
        {
            Pavadinimas = pavadinimas;
            GyvSkaicius = gyvSkaicius;
            Plotas_kv_km = plotas_kv_km;

        }

        public Miestas(string eilute)
        {
            var isskaidyta = eilute.Split(';');
            Pavadinimas = isskaidyta[0];
            GyvSkaicius = Convert.ToInt32(isskaidyta[1]);
            Plotas_kv_km = Convert.ToInt32(isskaidyta[2]);
        }


    }
}
