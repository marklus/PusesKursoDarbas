using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_PER_Nauja
{
    public partial class Skaiciavimai : Form
    {

        public Skaiciavimai(Pasaulis pasauliukas)
        {

            InitializeComponent();

            var daugiausiaiGyventoju = pasauliukas.DaugiausiaiGyventoju();
            textBox1.Text = daugiausiaiGyventoju.Pavadinimas;


            var mažiausiaiGyventoju = pasauliukas.MažiausiaiGyventoju();
            textBox2.Text = mažiausiaiGyventoju.Pavadinimas;

            var didžiausiasPlotas = pasauliukas.DidžiausiasPlotas();
            textBox3.Text = didžiausiasPlotas.Plotas_kv_km.ToString();


            var mažiausiasPlotas = pasauliukas.MažiausiasPlotas();
            textBox4.Text = mažiausiasPlotas.Plotas_kv_km.ToString();



           /* var šaliųSkaičius = pasauliukas.ŠaliųSkaičius();
            textBox3.Text = šaliųSkaičius.Pavadinimas.ToString();*/
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
