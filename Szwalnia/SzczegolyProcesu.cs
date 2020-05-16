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
    public partial class SzczegolyProcesu : Form
    {
        public SzwalniaEntities db;
        public int IdProcesu;
        public SzczegolyProcesu(SzwalniaEntities db, int IdProcesu)
        {
            InitializeComponent();
            this.db = db;
            this.IdProcesu = IdProcesu;
            Proces_Produkcyjny proces = db.Proces_Produkcyjny.Where(wybrany => wybrany.ID_Procesu_Produkcyjnego == IdProcesu).First();
            lblProces.Text = "Szczegóły procesu produkcyjnego o ID " + proces.ID_Procesu_Produkcyjnego;
        }

        private void btnRealizacjaProcesu_Click(object sender, EventArgs e)
        {
            RealizacjaProcesu realizacjaProcesu = new RealizacjaProcesu(db,IdProcesu);
            realizacjaProcesu.Show();
        }

        private void btnKontrolaEfektywnosci_Click(object sender, EventArgs e)
        {
            KontrolaEfektywnosciFormSzczegoly kontrolaEfektywnosciFormSzczegoly = new KontrolaEfektywnosciFormSzczegoly(db, IdProcesu);
            kontrolaEfektywnosciFormSzczegoly.Show();
        }

        private void btnMaterialProdukcja_Click(object sender, EventArgs e)
        {
            NiewykorzystanyMaterialProces niewykorzystanyMaterialProces = new NiewykorzystanyMaterialProces(db, IdProcesu);
            niewykorzystanyMaterialProces.Show();
        }

        private void btnWstecz_Click(object sender, EventArgs e)
        {
            PrzegladProcesowProdukcyjnych przegladProcesowProdukcyjnych = new PrzegladProcesowProdukcyjnych(db);
            przegladProcesowProdukcyjnych.Show();
            this.Close();
        }

        private void btnTechnologia_Click(object sender, EventArgs e)
        {
            ProdukcjaOdTechnologii produkcjaOdTechnologii = new ProdukcjaOdTechnologii(db,IdProcesu);
            produkcjaOdTechnologii.Show();

        }

        private void btnOdbiorMaterialu_Click(object sender, EventArgs e)
        {
            OdebranyMaterialProdukcja odebranyMaterialProdukcja = new OdebranyMaterialProdukcja(db, IdProcesu);
            odebranyMaterialProdukcja.Show();
        }
    }
}
