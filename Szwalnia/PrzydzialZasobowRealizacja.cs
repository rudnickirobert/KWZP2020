using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.Entity;
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
        public const string pustePole = "  .  .       :  :";
        Przydzial_Zasobow przydzial = new Przydzial_Zasobow();
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
            dgvPrzydzialZasobowRealizacja.Columns[3].Visible = false;
            dgvPrzydzialZasobowRealizacja.Columns[4].HeaderText = "ID pracownika";
            dgvPrzydzialZasobowRealizacja.Columns[5].HeaderText = "Imię";
            dgvPrzydzialZasobowRealizacja.Columns[7].HeaderText = "ID maszyny";
            dgvPrzydzialZasobowRealizacja.Columns[8].HeaderText = "Nazwa maszyny";
            dgvPrzydzialZasobowRealizacja.Columns[9].HeaderText = "Data rozpoczęcia";
            dgvPrzydzialZasobowRealizacja.Columns[10].HeaderText = "Data zakończenia";

        }

        private void btnNowy_Click(object sender, EventArgs e)
        {
            NowyPrzydzialZasobow nowyPrzydzialZasobow = new NowyPrzydzialZasobow(db, idEtapu);
            nowyPrzydzialZasobow.Show();

        }


        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDzisRozpoczecie_Click(object sender, EventArgs e)
        {
            mtbDataRozpoczecia.Text = DateTime.Now.ToString();
        }

        private void btnDzisZakonczenie_Click(object sender, EventArgs e)
        {
            mtbDataZakonczenia.Text = DateTime.Now.ToString();
        }

        private void btnEdycja_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbPracownik.Text))
            {
                MessageBox.Show("Uzupełnienie obu pola 'Pracownik' jest wymagane!");
            }
            else
            {
                if (string.IsNullOrEmpty(tbMaszyna.Text))
                {
                    MessageBox.Show("Uzupełnienie obu pola 'Maszyna' jest wymagane!");
                }
                else
                {
                    przydzial.ID_Pracownika = Convert.ToInt32(tbPracownik.Text);
                    przydzial.ID_Maszyny = Convert.ToInt32(tbMaszyna.Text);

                    if (mtbDataRozpoczecia.Text != pustePole)
                    {
                        przydzial.Data_Rozpoczecia = Convert.ToDateTime(mtbDataRozpoczecia.Text);
                    }

                    if (mtbDataZakonczenia.Text != pustePole)
                    {
                        przydzial.Data_Zakonczenia = Convert.ToDateTime(mtbDataZakonczenia.Text);
                    }

                    this.db.Entry(przydzial).State = EntityState.Modified;
                    db.SaveChanges();
                    MessageBox.Show("Zaktualizowano przydział zasobów");
                }
            }
        }

        private void dgvPrzydzialZasobowRealizacja_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            przydzial.ID_Przydzial_Zasobow = Convert.ToInt32(dgvPrzydzialZasobowRealizacja.CurrentRow.Cells[0].Value);
            przydzial.ID_Realizacji_Procesu = Convert.ToInt32(dgvPrzydzialZasobowRealizacja.CurrentRow.Cells[2].Value);
            przydzial = this.db.Przydzial_Zasobow.Where(numer => numer.ID_Przydzial_Zasobow == przydzial.ID_Przydzial_Zasobow).First();
            tbPracownik.Text = przydzial.ID_Pracownika.ToString();
            tbMaszyna.Text = przydzial.ID_Maszyny.ToString();
            mtbDataRozpoczecia.Text = przydzial.Data_Rozpoczecia.ToString();
            mtbDataZakonczenia.Text = przydzial.Data_Zakonczenia.ToString();
        }
    }
}
