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
    public partial class NowyProces : Form
    {
        public SzwalniaEntities db;
        public int nowyProces;
        public const string pustePole = "  .  .       :  :";
        public NowyProces(SzwalniaEntities db)
        {
            InitializeComponent();
            this.db = db;
            dgvUkryty.DataSource = db.Proces_Produkcyjny.ToList();
            int numerOstatniegoProcesu = dgvUkryty.Rows.Count;
            lblNumerProcesu.Text = (numerOstatniegoProcesu+1).ToString();
            cbxZamowienieElement.DataSource = db.Zamowienie_Element.ToList();
            cbxZamowienieElement.DisplayMember = "ID_Zamowienie_Element";
            cbxZamowienieElement.ValueMember = "ID_Zamowienie_Element";
            this.nowyProces = numerOstatniegoProcesu + 1;


        }

        private void btnWyzeruj_Click(object sender, EventArgs e)
        {
            mtbDataRozpoczecia.Text = "";
            mtbDataZakonczenia.Text = "";
            cbxZamowienieElement.Text = "";
            mtbProponowanaData.Text = "";
            tbUwagi.Text = "";
        }

        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            Proces_Produkcyjny proces = new Proces_Produkcyjny();

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

            proces.Uwagi = tbUwagi.Text;

            db.Proces_Produkcyjny.Add(proces);
            db.SaveChanges();
            MessageBox.Show("Dodano nowy proces produkcyjny");

            Kontrola_Efektywnosci kontrola = new Kontrola_Efektywnosci();
            kontrola.ID_Procesu_Produkcyjnego = nowyProces;
            db.Kontrola_Efektywnosci.Add(kontrola);
            db.SaveChanges();
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

        private void NowyProces_FormClosed(object sender, FormClosedEventArgs e)
        {
            ProcesProdukcyjny proces = new ProcesProdukcyjny(db);
            proces.Show();
        }
    }
}
