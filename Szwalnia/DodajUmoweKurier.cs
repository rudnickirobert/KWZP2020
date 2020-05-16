using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Szwalnia
{
    public partial class DodajUmoweKurier : Form
    {
        public DodajUmoweKurier()
        {
            InitializeComponent();
        }

        private void DodajUmoweKurier_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'szwalniaDataSet4.Dostawcy_Zaopatrzenie' . Możesz go przenieść lub usunąć.
            this.dostawcy_ZaopatrzenieTableAdapter.Fill(this.szwalniaDataSet4.Dostawcy_Zaopatrzenie);

        }
    }
}
