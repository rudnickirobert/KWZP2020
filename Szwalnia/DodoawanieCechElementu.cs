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
    public partial class DodoawanieCechElementu : Form
    {
        public DodoawanieCechElementu()
        {
            InitializeComponent();
        }

        private void DodoawanieCechElementu_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'szwalniaDataSet2.Elementy_Cechy_Slownik' . Możesz go przenieść lub usunąć.
            this.elementy_Cechy_SlownikTableAdapter.Fill(this.szwalniaDataSet2.Elementy_Cechy_Slownik);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'szwalniaDataSet1.Elementy' . Możesz go przenieść lub usunąć.
            this.elementyTableAdapter.Fill(this.szwalniaDataSet1.Elementy);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'szwalniaDataSet.Elementy_Jednostki' . Możesz go przenieść lub usunąć.
            this.elementy_JednostkiTableAdapter.Fill(this.szwalniaDataSet.Elementy_Jednostki);

        }
    }
}
