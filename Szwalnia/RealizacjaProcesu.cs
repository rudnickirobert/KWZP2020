using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Szwalnia
{
    public partial class RealizacjaProcesu : Form
    {
        public SzwalniaEntities db;
        public int idProcesu;
        public const string pustePole = "  .  .       :  :";
        Realizacja_Procesu realizacjaProcesu = new Realizacja_Procesu();
        public RealizacjaProcesu(SzwalniaEntities db,int idProcesu)
        {
            InitializeComponent();
            this.db = db;
            this.idProcesu = idProcesu;
            Proces_Produkcyjny proces = db.Proces_Produkcyjny.Where(wybrany => wybrany.ID_Procesu_Produkcyjnego == idProcesu).First();
            lblProces.Text = "Realizacja procesu dla procesu produkcyjnego o ID " + proces.ID_Procesu_Produkcyjnego;
            dgvRealizacjaProcesu.DataSource = null;
            dgvRealizacjaProcesu.DataSource = db.vRealizacjaProcesuProdukcyjnego.Where(realizacja => realizacja.ID_Procesu_Produkcyjnego == proces.ID_Procesu_Produkcyjnego).ToList();
            dgvRealizacjaProcesu.Columns[0].Visible = false;
            dgvRealizacjaProcesu.Columns[1].Visible = false;
            dgvRealizacjaProcesu.Columns[2].HeaderText = "Etap";
            dgvRealizacjaProcesu.Columns[3].HeaderText = "Data rozpoczęcia";
            dgvRealizacjaProcesu.Columns[4].HeaderText = "Data zakończenia";
            dgvRealizacjaProcesu.Columns[2].Width = 120;
            dgvRealizacjaProcesu.Columns[3].Width = 130;
            dgvRealizacjaProcesu.Columns[4].Width = 130;
            dgvRealizacjaProcesu.Columns[5].HeaderText = "Data kontroli";
            dgvRealizacjaProcesu.Columns[6].HeaderText = "Uwagi do kontroli";


            cbxEtapNowa.DataSource = db.Rodzaj_Etapu.ToList();
            cbxEtapNowa.DisplayMember = "Nazwa";
            cbxEtapNowa.ValueMember = "ID_etapu";

            cbxEtapEdycja.DataSource = db.Rodzaj_Etapu.ToList();
            cbxEtapEdycja.DisplayMember = "Nazwa";
            cbxEtapEdycja.ValueMember = "ID_etapu";
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(cbxEtapEdycja.Text))
            {
                MessageBox.Show("Uzupełnienie pola 'Nazwa etapu' jest wymagane!");
            }
            else
            {   
                realizacjaProcesu.ID_Procesu_Produkcyjnego = this.idProcesu;
                realizacjaProcesu.ID_Etapu = Convert.ToInt32(cbxEtapEdycja.SelectedValue);

                if (mtbDataRozpoczeciaEdycja.Text != pustePole)
                {
                    realizacjaProcesu.Data_Rozpoczecia_Procesu = Convert.ToDateTime(mtbDataRozpoczeciaEdycja.Text);
                }

                if (mtbDataZakonczeniaEdycja.Text != pustePole)
                {
                    realizacjaProcesu.Data_Zakonczenia_Procesu = Convert.ToDateTime(mtbDataZakonczeniaEdycja.Text);
                }

                if (mtbDataKontroliEdycja.Text != pustePole)
                {
                    realizacjaProcesu.Data_Kontroli = Convert.ToDateTime(mtbDataKontroliEdycja.Text);
                }

                realizacjaProcesu.Uwagi_Kontroli = tbUwagiKontrolaEdycja.Text;

                this.db.Entry(realizacjaProcesu).State = EntityState.Modified;
                db.SaveChanges();
                MessageBox.Show("Zaktualizowano realizację procesu");
            }
            dgvRealizacjaProcesu.DataSource = db.vRealizacjaProcesuProdukcyjnego.Where(realizacja => realizacja.ID_Procesu_Produkcyjnego == idProcesu).ToList();

        }

        private void dgvRealizacjaProcesu_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int numerEtapu = Convert.ToInt32(dgvRealizacjaProcesu.CurrentRow.Cells[1].Value);
            string nazwaEtapu = dgvRealizacjaProcesu.CurrentRow.Cells[2].Value.ToString();
            PrzydzialZasobowRealizacja przydzialZasobowRealizacja = new PrzydzialZasobowRealizacja(db, Decimal.ToInt32(numerEtapu), nazwaEtapu);
            przydzialZasobowRealizacja.Show();
        }

        private void btnDataRozpoczeciaNowa_Click(object sender, EventArgs e)
        {
            mtbDataRozpoczeciaNowa.Text = DateTime.Now.ToString();
        }

        private void btnDataZakonczeniaNowa_Click(object sender, EventArgs e)
        {
            mtbDataZakonczeniaNowa.Text = DateTime.Now.ToString();
        }

        private void btnDzisRozpoczecieEdycja_Click(object sender, EventArgs e)
        {
            mtbDataRozpoczeciaEdycja.Text = DateTime.Now.ToString();
        }

        private void btnDzisZakonczenieEdycja_Click(object sender, EventArgs e)
        {
            mtbDataZakonczeniaEdycja.Text = DateTime.Now.ToString();
        }

        private void btnNowa_Click(object sender, EventArgs e)
        {
            Realizacja_Procesu realizacjaProcesu = new Realizacja_Procesu();

            if (string.IsNullOrEmpty(cbxEtapNowa.Text))
            {
                MessageBox.Show("Uzupełnienie pola 'Nazwa etapu' jest wymagane!");
            }
            else
            {
                realizacjaProcesu.ID_Procesu_Produkcyjnego = this.idProcesu;
                realizacjaProcesu.ID_Etapu = Convert.ToInt32(cbxEtapNowa.SelectedValue);

                if (mtbDataRozpoczeciaNowa.Text != pustePole)
                {
                    realizacjaProcesu.Data_Rozpoczecia_Procesu = Convert.ToDateTime(mtbDataRozpoczeciaNowa.Text);
                }

                if (mtbDataZakonczeniaNowa.Text != pustePole)
                {
                    realizacjaProcesu.Data_Zakonczenia_Procesu = Convert.ToDateTime(mtbDataZakonczeniaNowa.Text);
                }

                if (mtbDataKontroliNowa.Text != pustePole)
                {
                    realizacjaProcesu.Data_Kontroli = Convert.ToDateTime(mtbDataKontroliNowa.Text);
                }

                realizacjaProcesu.Uwagi_Kontroli = tbUwagiKontrolaNowa.Text;

                db.Realizacja_Procesu.Add(realizacjaProcesu);
                db.SaveChanges();
                MessageBox.Show("Dodano nową realizację");
                dgvRealizacjaProcesu.DataSource = db.vRealizacjaProcesuProdukcyjnego.Where(realizacja => realizacja.ID_Procesu_Produkcyjnego ==idProcesu).ToList();
            }
        }

        private void dgvRealizacjaProcesu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            realizacjaProcesu.ID_Realizacji_Procesu = Convert.ToInt32(dgvRealizacjaProcesu.CurrentRow.Cells[1].Value);
            realizacjaProcesu = this.db.Realizacja_Procesu.Where(numer => numer.ID_Realizacji_Procesu == realizacjaProcesu.ID_Realizacji_Procesu).First();
            cbxEtapEdycja.SelectedValue = realizacjaProcesu.ID_Etapu;
            mtbDataRozpoczeciaEdycja.Text = realizacjaProcesu.Data_Rozpoczecia_Procesu.ToString();
            mtbDataZakonczeniaEdycja.Text = realizacjaProcesu.Data_Zakonczenia_Procesu.ToString();
            mtbDataKontroliEdycja.Text = realizacjaProcesu.Data_Kontroli.ToString();
            tbUwagiKontrolaEdycja.Text = realizacjaProcesu.Uwagi_Kontroli;
        }

        private void btnDzisKontrolaNowa_Click(object sender, EventArgs e)
        {
            mtbDataKontroliNowa.Text = DateTime.Now.ToString();
        }

        private void btnDzisKontrolaEdycja_Click(object sender, EventArgs e)
        {
            mtbDataKontroliEdycja.Text = DateTime.Now.ToString();
        }
    }
}
