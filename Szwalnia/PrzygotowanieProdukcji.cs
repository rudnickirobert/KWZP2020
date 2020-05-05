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
    public partial class PrzygotowanieProdukcji : Form
    {
        private SzwalniaEntities Szwalnia;
        public PrzygotowanieProdukcji(SzwalniaEntities db)
        {
            InitializeComponent();
            Szwalnia = db;
        }
        private void btnMaszynyProcesLiczba_Click(object sender, EventArgs e)
        {
            MaszynyProcesSzukaj maszynyProcesSzukaj = new MaszynyProcesSzukaj(Szwalnia);
            maszynyProcesSzukaj.Show();
        }
        private void btnSumaCzasuProcesu_Click(object sender, EventArgs e)
        {
            SumaCzasuPokaz sumaCzasuPokaz = new SumaCzasuPokaz(Szwalnia);
            sumaCzasuPokaz.Show();
        }
        private void btnSredniaIloscMaszyn_Click(object sender, EventArgs e)
        {
            SredniaIloscMaszyPokaz sredniaIloscMaszynPokaz = new SredniaIloscMaszyPokaz(Szwalnia);
            sredniaIloscMaszynPokaz.Show();
        }
        private void btnMaszynySerwis_Click(object sender, EventArgs e)
        {
            MaszynySerwis maszynySerwis = new MaszynySerwis(Szwalnia);
            maszynySerwis.Show();
        }
        private void btnObslugaMaszyn_Click(object sender, EventArgs e)
        {
            ObslugaSzukaj obslugaSzukaj = new ObslugaSzukaj(Szwalnia);
            obslugaSzukaj.Show();
        }
    }
}
