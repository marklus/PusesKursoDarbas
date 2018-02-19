using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Vidurio_Kurso_Atsiskaitymas_3
{
    /*
     * Sukurti telefonų knygą su random skirtingų vardų,
     * pavardžių
     * ir numerių;
     */
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> phonebook = new Dictionary<string, int>();
            phonebook["Janas Kazuklas"] = 45451654;
            phonebook["Petras Namas"] = 324879;
            phonebook["Algis Danas"] = 45465654;
            phonebook["Juzas Švedas"] = 541223;
            phonebook["Jurgis Kamas"] = 45465654;
            phonebook["Dakas Pakas"] = 654565;
            phonebook["Mekas Pekas"] = 421354;
            phonebook["Benas Tenas"] = 3623217;
            phonebook["Piteris Penas"] = 2131231;
            phonebook["Fenas Šemas"] = 2143574;
            phonebook["Kazkas Kazinkoks"] = 45465654; 
            phonebook.Add(" Algis Būrys ",122);

            Console.WriteLine("Vardas   Pavardė   Numeris");
            Console.WriteLine("------------------------");

            foreach (var tlf in phonebook)
            {
                Console.WriteLine(tlf);
            }
        }
    }
}
