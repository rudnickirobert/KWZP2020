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
        public int idProcesu;
        public int idZamowienieElement;
        public SzczegolyProcesu(SzwalniaEntities db, int idProcesu, int idZamowienieElement)
        {
            InitializeComponent();
            this.db = db;
            this.idProcesu = idProcesu;
            this.idZamowienieElement = idZamowienieElement;
            Proces_Produkcyjny proces = db.Proces_Produkcyjny.Where(wybrany => wybrany.ID_Procesu_Produkcyjnego == idProcesu).First();
            lblProces.Text = "Szczegóły procesu produkcyjnego o ID " + proces.ID_Procesu_Produkcyjnego;
        }

        private void btnRealizacjaProcesu_Click(object sender, EventArgs e)
        {
            RealizacjaProcesu realizacjaProcesu = new RealizacjaProcesu(db,idProcesu);
            realizacjaProcesu.Show();
        }

        private void btnKontrolaEfektywnosci_Click(object sender, EventArgs e)
        {
            KontrolaEfektywnosciSzczegoly kontrolaEfektywnosciFormSzczegoly = new KontrolaEfektywnosciSzczegoly(db, idProcesu);
            kontrolaEfektywnosciFormSzczegoly.Show();
        }

        private void btnMaterialProdukcja_Click(object sender, EventArgs e)
        {
            NiewykorzystanyMaterialProces niewykorzystanyMaterialProces = new NiewykorzystanyMaterialProces(db, idProcesu);
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
            ProdukcjaOdTechnologii produkcjaOdTechnologii = new ProdukcjaOdTechnologii(db,idProcesu);
            produkcjaOdTechnologii.Show();

        }

        private void btnOdbiorMaterialu_Click(object sender, EventArgs e)
        {
            OdbiorMaterialu odbiorMaterialu = new OdbiorMaterialu(db, idProcesu);
            odbiorMaterialu.Show();
        }

        private void btnEdycja_Click(object sender, EventArgs e)
        {
            EdycjaProcesu edycjaProcesu = new EdycjaProcesu(db, idProcesu, idZamowienieElement);
            edycjaProcesu.Show();
        }
    }
}
