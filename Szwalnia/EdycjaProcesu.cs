using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Szwalnia
{
    public partial class EdycjaProcesu : Form
    {
        public SzwalniaEntities db;
        Proces_Produkcyjny proces = new Proces_Produkcyjny();
        int idProcesu;
        public const string pustePole = "  .  .       :  :";
        public int idZamowienieElement;
        public EdycjaProcesu(SzwalniaEntities db, int idProcesu, int idZamowienieElement)
        {
            InitializeComponent();
            this.db = db;
            this.idProcesu = idProcesu;
            this.idZamowienieElement = idZamowienieElement;
            lblOpis.Text = "Edycja procesu produkcyjnego o ID " + idProcesu;
            proces = this.db.Proces_Produkcyjny.Where(procesProdukcyjny => procesProdukcyjny.ID_Procesu_Produkcyjnego == idProcesu).First();
            cbxZamowienieElement.DataSource = db.Zamowienie_Element.ToList();
            cbxZamowienieElement.ValueMember = "ID_Zamowienie_Element";
            cbxZamowienieElement.DisplayMember = "ID_Zamowienie_Element";
            mtbProponowanaData.Text = proces.Proponowana_data_dostawy_materialu.ToString();
            mtbDataRozpoczecia.Text = proces.Data_Rozpoczecia.ToString();
            mtbDataZakonczenia.Text = proces.Data_Zakonczenia.ToString();
            cbxZamowienieElement.SelectedValue = idZamowienieElement;
            tbUwagi.Text = proces.Uwagi;
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbxZamowienieElement.Text))
            {
                MessageBox.Show("Uzupełnienie pola 'ID zamówienie element' jest wymagane!");
                return;
            }
            else
            {
                proces.ID_Zamowienie_Element = Convert.ToInt32(cbxZamowienieElement.Text);
            }

            if (mtbProponowanaData.Text != pustePole)
            {
                proces.Proponowana_data_dostawy_materialu = Convert.ToDateTime(mtbProponowanaData.Text);
            }

            if (mtbDataRozpoczecia.Text != pustePole)
            {
                proces.Data_Rozpoczecia = Convert.ToDateTime(mtbDataRozpoczecia.Text);
            }

            if (mtbDataZakonczenia.Text != pustePole)
            {
                proces.Data_Zakonczenia = Convert.ToDateTime(mtbDataZakonczenia.Text);
            }
            if (tbUwagi.TextLength <= 300)
            {
                proces.Uwagi = tbUwagi.Text;
            }

            this.db.Entry(proces).State = EntityState.Modified;
            db.SaveChanges();
            MessageBox.Show("Zapisano zmiany w procesie");
            this.Close();

        }

        private void btnDzisProponowana_Click(object sender, EventArgs e)
        {
            mtbProponowanaData.Text = DateTime.Now.ToString();
        }

        private void btnDzisRozpoczecie_Click(object sender, EventArgs e)
        {
            mtbDataRozpoczecia.Text = DateTime.Now.ToString();
        }

        private void btnDzisZakonczenie_Click(object sender, EventArgs e)
        {
            mtbDataZakonczenia.Text = DateTime.Now.ToString();
        }

        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
