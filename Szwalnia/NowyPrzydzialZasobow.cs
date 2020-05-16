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
    public partial class NowyPrzydzialZasobow : Form
    {
        public SzwalniaEntities db;
        public int idEtapu;
        public NowyPrzydzialZasobow(SzwalniaEntities db, int idEtapu)
        {
            InitializeComponent();
            this.db = db;
            this.idEtapu = idEtapu;
            cbxPracownik.Enabled = false;
            cbxMaszyna.Enabled = false;

        }

        private void btnDzisRozpoczecie_Click(object sender, EventArgs e)
        {
            mtbDataRozpoczecia.Text= DateTime.Now.ToString();
        }

        private void btnDzisZakonczenie_Click(object sender, EventArgs e)
        {
            mtbDataZakonczenia.Text = DateTime.Now.ToString();
        }

        private void btnWyzeruj_Click(object sender, EventArgs e)
        {
            cbxPracownik.Text = "";
            cbxMaszyna.Text = "";
            mtbDataRozpoczecia.Text = "";
            mtbDataZakonczenia.Text = "";
        }

        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            Przydzial_Zasobow przydzial = new Przydzial_Zasobow();
            if (string.IsNullOrEmpty(cbxPracownik.Text) && string.IsNullOrEmpty(cbxMaszyna.Text))
            {
                MessageBox.Show("Uzupełnienie obu pól 'Pracownik' oraz 'Maszyna' jest wymagane!");
            }
            else
            {
                przydzial.ID_Pracownika = Convert.ToInt32(cbxPracownik.SelectedValue);
                przydzial.ID_Maszyny = Convert.ToInt32(cbxMaszyna.SelectedValue);
                przydzial.Data_Rozpoczecia = Convert.ToDateTime(mtbDataRozpoczecia);
                przydzial.Data_Zakonczenia = Convert.ToDateTime(mtbDataZakonczenia);
                przydzial.ID_Realizacji_Procesu = idEtapu;
                db.Przydzial_Zasobow.Add(przydzial);
                db.SaveChanges();
                MessageBox.Show("Dodano nowy przydział zasobów");
            }
        }

        private void btnWszyscyPracownicy_Click(object sender, EventArgs e)
        {
            cbxPracownik.Enabled = true;
            cbxPracownik.DataSource = db.vWszyscyPracownicyProdukcji.ToList();
            cbxPracownik.DisplayMember = "Pracownik";
            cbxPracownik.ValueMember = "ID_Pracownika";
        }

        private void btnWolniPracownicy_Click(object sender, EventArgs e)
        {
            cbxPracownik.Enabled = true;
            cbxPracownik.DataSource = db.vWolniPracownicyProdukcji.ToList();
            cbxPracownik.DisplayMember = "Pracownik";
            cbxPracownik.ValueMember = "ID_Pracownika";
        }

        private void btnWszystkieMaszyny_Click(object sender, EventArgs e)
        {
            cbxMaszyna.Enabled = true;
            cbxMaszyna.DataSource = db.vWszystkieMaszyny.ToList();
            cbxMaszyna.DisplayMember = "Maszyna";
            cbxMaszyna.ValueMember = "ID_Maszyny";

        }

        private void btnWolneMaszyny_Click(object sender, EventArgs e)
        {
            cbxMaszyna.Enabled = true;
            cbxMaszyna.DataSource = db.vWolneMaszyny.ToList();
            cbxMaszyna.DisplayMember = "Maszyna";
            cbxMaszyna.ValueMember = "ID_Maszyny";

        }
    }
}
