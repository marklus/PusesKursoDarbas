using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI_PER_Nauja
{
   public class Šalis
    {

        public string Pavadinimas { get; private set; }
        public string Žemynas { get; private set; }
        public List<Miestas> Miestu_sarasas { get; private set; } = new List<Miestas>();//kur talpint

        public Šalis(string failas)
        {
            var tekstas = File.ReadAllLines(failas);

            Pavadinimas = tekstas[0];
            Žemynas = tekstas[1];

            var ilgis = tekstas.Length;

            for (int i = 2; i < ilgis; i++)
            {
                var miestas = new Miestas(tekstas[i]);
                Miestu_sarasas.Add(miestas);//ką talpint
            }
        }


    }
}
