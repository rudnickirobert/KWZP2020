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
    public partial class RaportMaszynyProdukcja : Form
    {
        public SzwalniaEntities db;
        public RaportMaszynyProdukcja(SzwalniaEntities db)
        {
            InitializeComponent();
            this.db = db;
            dgvMaszyny.DataSource = db.vPrzydzialZasobow.ToList();
            dgvMaszyny.Columns[0].Visible = false;
            dgvMaszyny.Columns[1].Visible = false;
            dgvMaszyny.Columns[5].Visible = false;
            dgvMaszyny.Columns[6].Visible = false;
            dgvMaszyny.Columns[7].Visible = false;
            dgvMaszyny.Columns[2].HeaderText = "ID procesu produkcyjnego";
            dgvMaszyny.Columns[3].HeaderText = "ID realizacji procesu";
            dgvMaszyny.Columns[4].HeaderText = "Nazwa etapu";
            dgvMaszyny.Columns[8].HeaderText = "ID maszyny";
            dgvMaszyny.Columns[9].HeaderText = "Nazwa maszyny";
            dgvMaszyny.Columns[10].HeaderText = "Data rozpoczęcia";
            dgvMaszyny.Columns[11].HeaderText = "Data zakończenia";
            cbxEtap.DataSource = db.Rodzaj_Etapu.ToList();
            cbxEtap.DisplayMember = "Nazwa";
            cbxEtap.ValueMember = "Nazwa";
            cbxMaszyna.DataSource = db.vWszystkieMaszynyProdukcja.ToList();
            cbxMaszyna.DisplayMember = "Maszyna";
            cbxMaszyna.ValueMember = "ID_Maszyny";
        }

        private void btnIdProcesu_Click(object sender, EventArgs e)
        {
            dgvMaszyny.DataSource = this.db.vPrzydzialZasobow.Where(proces => proces.ID_procesu_produkcyjnego == nudProces.Value).ToList();
            dgvMaszyny.Columns.OfType<DataGridViewColumn>().ToList().ForEach(kolumna => kolumna.Visible = true);
            dgvMaszyny.Columns[0].Visible = false;
            dgvMaszyny.Columns[1].Visible = false;
            dgvMaszyny.Columns[2].Visible = false;
            dgvMaszyny.Columns[5].Visible = false;
            dgvMaszyny.Columns[6].Visible = false;
            dgvMaszyny.Columns[7].Visible = false;
        }

        private void btnIdRealizacji_Click(object sender, EventArgs e)
        {
            dgvMaszyny.DataSource = this.db.vPrzydzialZasobow.Where(proces => proces.ID_Realizacji_Procesu == nudRealizacja.Value).ToList();
            dgvMaszyny.Columns.OfType<DataGridViewColumn>().ToList().ForEach(kolumna => kolumna.Visible = true);
            dgvMaszyny.Columns[0].Visible = false;
            dgvMaszyny.Columns[1].Visible = false;
            dgvMaszyny.Columns[3].Visible = false;
            dgvMaszyny.Columns[5].Visible = false;
            dgvMaszyny.Columns[6].Visible = false;
            dgvMaszyny.Columns[7].Visible = false;
        }

        private void btnEtap_Click(object sender, EventArgs e)
        {
            dgvMaszyny.DataSource = this.db.vPrzydzialZasobow.Where(etap => etap.Nazwa_etapu == cbxEtap.SelectedValue.ToString()).ToList();
            dgvMaszyny.Columns.OfType<DataGridViewColumn>().ToList().ForEach(kolumna => kolumna.Visible = true);
            dgvMaszyny.Columns[0].Visible = false;
            dgvMaszyny.Columns[1].Visible = false;
            dgvMaszyny.Columns[4].Visible = false;
            dgvMaszyny.Columns[5].Visible = false;
            dgvMaszyny.Columns[6].Visible = false;
            dgvMaszyny.Columns[7].Visible = false;
        }

        private void btnMaszyna_Click(object sender, EventArgs e)
        {
            int numer = Convert.ToInt32(cbxMaszyna.SelectedValue);
            dgvMaszyny.DataSource = this.db.vPrzydzialZasobow.Where(pracownik => pracownik.ID_pracownika == numer).ToList();
            dgvMaszyny.Columns.OfType<DataGridViewColumn>().ToList().ForEach(kolumna => kolumna.Visible = true);
            dgvMaszyny.Columns[0].Visible = false;
            dgvMaszyny.Columns[1].Visible = false;
            dgvMaszyny.Columns[5].Visible = false;
            dgvMaszyny.Columns[6].Visible = false;
            dgvMaszyny.Columns[7].Visible = false;
        }

        private void btnWszystkie_Click(object sender, EventArgs e)
        {
            dgvMaszyny.DataSource = db.vPrzydzialZasobow.ToList();
            dgvMaszyny.Columns[0].Visible = false;
            dgvMaszyny.Columns[1].Visible = false;
            dgvMaszyny.Columns[5].Visible = false;
            dgvMaszyny.Columns[6].Visible = false;
            dgvMaszyny.Columns[7].Visible = false;
        }

        private void btnData_Click(object sender, EventArgs e)
        {
            dgvMaszyny.DataSource = this.db.vPrzydzialZasobow.Where(data => ((data.Data_rozpoczęcia.Value.Month == dtpData.Value.Month) && (data.Data_rozpoczęcia.Value.Year == dtpData.Value.Year)) | ((data.Data_zakończenia.Value.Month == dtpData.Value.Month) && (data.Data_zakończenia.Value.Year == dtpData.Value.Year))).ToList();
            dgvMaszyny.Columns.OfType<DataGridViewColumn>().ToList().ForEach(kolumna => kolumna.Visible = true);
            dgvMaszyny.Columns[0].Visible = false;
            dgvMaszyny.Columns[1].Visible = false;
            dgvMaszyny.Columns[5].Visible = false;
            dgvMaszyny.Columns[6].Visible = false;
            dgvMaszyny.Columns[7].Visible = false;
        }
    }
}
