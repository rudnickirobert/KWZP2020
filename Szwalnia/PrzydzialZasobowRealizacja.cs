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
    public partial class PrzydzialZasobowRealizacja : Form
    {
        public SzwalniaEntities db;
        public int idEtapu;
        public string nazwaEtapu;
        public PrzydzialZasobowRealizacja(SzwalniaEntities db, int idEtapu, string nazwaEtapu)
        {
            InitializeComponent();
            this.db = db;
            this.idEtapu = idEtapu;
            this.nazwaEtapu = nazwaEtapu;

            vRealizacjaProcesuProdukcyjnegoDetails realizacja = db.vRealizacjaProcesuProdukcyjnegoDetails.Where(wybrany => wybrany.Nazwa_etapu == nazwaEtapu).First();
            lblRealizacja.Text = "Przydział zasobów dla etapu " + realizacja.Nazwa_etapu;
            dgvPrzydzialZasobowRealizacja.DataSource = db.vPrzydzialZasobow.Where(przydzial => przydzial.ID_realizacji_procesu == idEtapu).ToList();
            dgvPrzydzialZasobowRealizacja.Columns[0].Visible = false;
            dgvPrzydzialZasobowRealizacja.Columns[1].Visible = false;
            dgvPrzydzialZasobowRealizacja.Columns[2].Visible = false;
            dgvPrzydzialZasobowRealizacja.Columns[3].HeaderText = "ID pracownika";
            dgvPrzydzialZasobowRealizacja.Columns[4].HeaderText = "Imię";
            dgvPrzydzialZasobowRealizacja.Columns[6].HeaderText = "ID maszyny";
            dgvPrzydzialZasobowRealizacja.Columns[7].HeaderText = "Nazwa maszyny";
            dgvPrzydzialZasobowRealizacja.Columns[8].HeaderText = "Data rozpoczęcia";
            dgvPrzydzialZasobowRealizacja.Columns[9].HeaderText = "Data zakończenia";

        }

        private void btnNowy_Click(object sender, EventArgs e)
        {
            NowyPrzydzialZasobow nowyPrzydzialZasobow = new NowyPrzydzialZasobow(db, idEtapu);
            nowyPrzydzialZasobow.Show();

        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            db.SaveChanges();
            MessageBox.Show("Zaaktualizowano przydział zasobów");
        }

        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
