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
        private SzwalniaEntities szwalnia;
        public PrzygotowanieProdukcji(SzwalniaEntities db)
        {
            InitializeComponent();
            szwalnia = db;
        }
        private void btnMaszynyProcesLiczba_Click(object sender, EventArgs e)
        {
            MaszynyProcesSzukaj maszynyProcesSzukaj = new MaszynyProcesSzukaj(szwalnia);
            maszynyProcesSzukaj.Show();
        }
        private void btnSumaCzasuProcesu_Click(object sender, EventArgs e)
        {
            SumaCzasuPokaz sumaCzasuPokaz = new SumaCzasuPokaz(szwalnia);
            sumaCzasuPokaz.Show();
        }
        private void btnSredniaIloscMaszyn_Click(object sender, EventArgs e)
        {
            SredniaIloscMaszyPokaz sredniaIloscMaszynPokaz = new SredniaIloscMaszyPokaz(szwalnia);
            sredniaIloscMaszynPokaz.Show();
        }
        private void btnMaszynySerwis_Click(object sender, EventArgs e)
        {
            MaszynySerwis maszynySerwis = new MaszynySerwis(szwalnia);
            maszynySerwis.Show();
        }
        private void btnObslugaMaszyn_Click(object sender, EventArgs e)
        {
            ObslugaSzukaj obslugaSzukaj = new ObslugaSzukaj(szwalnia);
            obslugaSzukaj.Show();
        }
    }
}
