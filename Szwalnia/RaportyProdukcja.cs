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
    public partial class RaportyProdukcja : Form
    {
        public SzwalniaEntities db;
        public RaportyProdukcja(SzwalniaEntities db)
        {
            InitializeComponent();
            this.db = db;
        }

        private void btnWstecz_Click(object sender, EventArgs e)
        {
            Produkcja produkcja = new Produkcja(db);
            produkcja.Show();
            this.Close();
        }

        private void btnProcesy_Click(object sender, EventArgs e)
        {
            RaportProcesyProdukcyjne raportProcesyProdukcyjne = new RaportProcesyProdukcyjne(db);
            raportProcesyProdukcyjne.Show();
        }

        private void btnPraownicy_Click(object sender, EventArgs e)
        {
            RaportPracownicyProdukcji raportPracownicyProdukcji = new RaportPracownicyProdukcji(db);
            raportPracownicyProdukcji.Show();
        }

        private void btnMaterialOdpad_Click(object sender, EventArgs e)
        {
            RaportNieuzytyMaterial raportNieuzytyMaterial = new RaportNieuzytyMaterial(db);
            raportNieuzytyMaterial.Show();
        }

        private void btnKontrolaEfektywnosci_Click(object sender, EventArgs e)
        {
            RaportKontrolaEfektywnosci raportKontrolaEfektywnosci = new RaportKontrolaEfektywnosci(db);
            raportKontrolaEfektywnosci.Show();
        }

        private void btnMaszyny_Click(object sender, EventArgs e)
        {
            RaportMaszynyProdukcja raportMaszynyProdukcja = new RaportMaszynyProdukcja(db);
            raportMaszynyProdukcja.Show();
        }
    }
}
