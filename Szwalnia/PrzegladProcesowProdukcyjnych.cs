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
    public partial class PrzegladProcesowProdukcyjnych : Form
    {
        public SzwalniaEntities db;
        public int ostatniNumerZamowienia;
        Proces_Produkcyjny proces = new Proces_Produkcyjny();
        public PrzegladProcesowProdukcyjnych(SzwalniaEntities db)
        {
            InitializeComponent();
            this.db = db; 
        }

        private void btnWszystkieProcesy_Click(object sender, EventArgs e)
        {
            dgvProcesyProdukcyjne.DataSource = db.vZamowienieProcesyProdukcyjne.ToList();
            dgvProcesyProdukcyjne.Columns.OfType<DataGridViewColumn>().ToList().ForEach(kolumna => kolumna.Visible = true);
        }

        private void btnRozpoczeteProcesy_Click(object sender, EventArgs e)
        {
            dgvProcesyProdukcyjne.DataSource = this.db.vZamowienieProcesyProdukcyjne.Where(data => data.Data_Zakonczenia.Value == null).ToList();
            dgvProcesyProdukcyjne.Columns.OfType<DataGridViewColumn>().ToList().ForEach(kolumna => kolumna.Visible = true);
        }

        private void btnIdProcesu_Click(object sender, EventArgs e)
        {
            dgvProcesyProdukcyjne.DataSource = this.db.vZamowienieProcesyProdukcyjne.Where(numer => numer.ID_Procesu_Produkcyjnego == nudNumerProcesu.Value).ToList();
            dgvProcesyProdukcyjne.Columns.OfType<DataGridViewColumn>().ToList().ForEach(kolumna => kolumna.Visible = true);
            dgvProcesyProdukcyjne.Columns[0].Visible = false;
        }

        private void btnIdZamowienia_Click(object sender, EventArgs e)
        {
            if (nudNumerZamowienia.Value > 0)
            {
                if (nudNumerZamowienia.Value <= ostatniNumerZamowienia)
                {
                    dgvProcesyProdukcyjne.DataSource = this.db.vZamowienieProcesyProdukcyjne.Where(zamowienie => zamowienie.ID_Zamowienia == nudNumerZamowienia.Value).ToList();
                    dgvProcesyProdukcyjne.Columns.OfType<DataGridViewColumn>().ToList().ForEach(kolumna => kolumna.Visible = true);
                    dgvProcesyProdukcyjne.Columns[1].Visible = false;
                }
                else
                    MessageBox.Show("Nie istnieje takie ID Zamowienia!");
            }
            else
                MessageBox.Show("Wprowadź poprawne ID Zamowienia (wieksze od zera)!");
        }

        private void dgvProcesyProdukcyjne_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int numerProcesu = Convert.ToInt32(dgvProcesyProdukcyjne.CurrentRow.Cells[0].Value);
            int nummerZamowienieElement = Convert.ToInt32(dgvProcesyProdukcyjne.CurrentRow.Cells[2].Value);
            SzczegolyProcesu szczegolyProcesu = new SzczegolyProcesu(db, Decimal.ToInt32(numerProcesu), Decimal.ToInt32(nummerZamowienieElement));
            this.Close();
            szczegolyProcesu.Show();
        }

        private void btnIdZamowienieElement_Click(object sender, EventArgs e)
        {

            dgvProcesyProdukcyjne.DataSource = this.db.vZamowienieProcesyProdukcyjne.Where(numer => numer.ID_Zamowienie_Element == nudNumerZamowienieElement.Value).ToList();
            dgvProcesyProdukcyjne.Columns.OfType<DataGridViewColumn>().ToList().ForEach(kolumna => kolumna.Visible = true);
            dgvProcesyProdukcyjne.Columns[2].Visible = false;
        }

        private void btnDataRozpoczecia_Click(object sender, EventArgs e)
        {

            dgvProcesyProdukcyjne.DataSource = this.db.vZamowienieProcesyProdukcyjne.Where(data => (data.Data_Rozpoczecia.Value.Day == dtpDataRozpoczecia.Value.Day) && (data.Data_Rozpoczecia.Value.Month == dtpDataRozpoczecia.Value.Month) && (data.Data_Rozpoczecia.Value.Year == dtpDataRozpoczecia.Value.Year)).ToList();
            dgvProcesyProdukcyjne.Columns.OfType<DataGridViewColumn>().ToList().ForEach(kolumna => kolumna.Visible = true);
        }

        private void btnDataZakonczenia_Click(object sender, EventArgs e)
        {

            dgvProcesyProdukcyjne.DataSource = this.db.vZamowienieProcesyProdukcyjne.Where(data => (data.Data_Zakonczenia.Value.Day == dtpDataZakonczenia.Value.Day) && (data.Data_Zakonczenia.Value.Month == dtpDataZakonczenia.Value.Month) && (data.Data_Zakonczenia.Value.Year == dtpDataZakonczenia.Value.Year) ).ToList();
            dgvProcesyProdukcyjne.Columns.OfType<DataGridViewColumn>().ToList().ForEach(kolumna => kolumna.Visible = true);
        }

        private void btnWstecz_Click(object sender, EventArgs e)
        {
            ProcesProdukcyjny procesProdukcyjny = new ProcesProdukcyjny(db);
            procesProdukcyjny.Show();
            this.Close();
        }

        private void PrzegladProcesowProdukcyjnych_Load(object sender, EventArgs e)
        {
            dgvProcesyProdukcyjne.DataSource = db.vZamowienieProcesyProdukcyjne.ToList();
            dgvProcesyProdukcyjne.Columns.OfType<DataGridViewColumn>().ToList().ForEach(kolumna => kolumna.Visible = true);
            int ostatniNumer = dgvProcesyProdukcyjne.Rows.Cast<DataGridViewRow>().Max(wartosc => Convert.ToInt32(wartosc.Cells["ID_Zamowienia"].Value));
            ostatniNumerZamowienia = ostatniNumer;
            dgvProcesyProdukcyjne.Columns[0].HeaderText = "ID procesu produkcyjnego";
            dgvProcesyProdukcyjne.Columns[1].HeaderText = "ID zamówienia";
            dgvProcesyProdukcyjne.Columns[2].HeaderText = "ID zamówienia element";
            dgvProcesyProdukcyjne.Columns[4].HeaderText = "Proponowana data dostawy materiału";
            dgvProcesyProdukcyjne.Columns[5].HeaderText = "Data rozpoczęcia";
            dgvProcesyProdukcyjne.Columns[6].HeaderText = "Data zakończenia";
            dgvProcesyProdukcyjne.Columns[0].Width = 95;
            dgvProcesyProdukcyjne.Columns[7].Width = 130;
        }
    }
}
