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
    public partial class Form1 : Form
    {
        public Pasaulis Pasaulis { get; private set; } = new Pasaulis();
        public Form1()
        {
            InitializeComponent();
        }

        private void baigtiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void failasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nurodytiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var failoPasirinkimas = new OpenFileDialog())
            {

                failoPasirinkimas.Filter = "csv failai (*.csv)|*.csv";
                failoPasirinkimas.Multiselect = true;

                if (failoPasirinkimas.ShowDialog() == DialogResult.OK)
                {
                    foreach (var file in failoPasirinkimas.FileNames)
                    {
                        var šalis = new Šalis(file);
                        Pasaulis.Šaliu_sarasas.Add(šalis);

                        var skirtukas = new TabPage(šalis.Pavadinimas);
                        tabControl1.Controls.Add(skirtukas);

                        skirtukas.Controls.Add(new DataGridView()
                        {
                            Dock = DockStyle.Fill,
                            DataSource = Pasaulis.Šaliu_sarasas.Last().Miestu_sarasas
                        });

                    }
                }
            }

        }

        private void skaičiavimaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var forma = new Skaiciavimai(Pasaulis);
            forma.ShowDialog();
        }
    }
}
