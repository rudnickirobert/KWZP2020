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
        private SzwalniaEntities bd;
        public PrzygotowanieProdukcji(SzwalniaEntities db)
        {
            InitializeComponent();
            bd = db;
        }
        private void btnMaszynyProcesLiczba_Click(object sender, EventArgs e)
        {
            MaszynyProcesSzukaj maszynyProcesSzukaj = new MaszynyProcesSzukaj(bd);
            maszynyProcesSzukaj.Show();
        }
        private void btnSumaCzasuProcesu_Click(object sender, EventArgs e)
        {
            SumaCzasuPokaz sumaCzasuPokaz = new SumaCzasuPokaz(bd);
            sumaCzasuPokaz.Show();
        }
        private void btnSredniaIloscMaszyn_Click(object sender, EventArgs e)
        {
            SredniaIloscMaszyPokaz sredniaIloscMaszynPokaz = new SredniaIloscMaszyPokaz(bd);
            sredniaIloscMaszynPokaz.Show();
        }
        private void btnMaszynySerwis_Click(object sender, EventArgs e)
        {
            MaszynySerwis maszynySerwis = new MaszynySerwis(bd);
            maszynySerwis.Show();
        }
        private void btnObslugaMaszyn_Click(object sender, EventArgs e)
        {
            ObslugaSzukaj obslugaSzukaj = new ObslugaSzukaj(bd);
            obslugaSzukaj.Show();
        }
    }
}
