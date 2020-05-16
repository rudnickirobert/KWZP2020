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
        public int ostatniNumerProcesu;
        public NowyProces(SzwalniaEntities db)
        {
            InitializeComponent();
            this.db = db;
            dgvUkryty.DataSource = db.Proces_Produkcyjny.ToList();
            int numerOstatniegoProcesu = dgvUkryty.Rows.Count;
            lblNumerProcesu.Text = (numerOstatniegoProcesu+1).ToString();
        }

        private void btnWyzeruj_Click(object sender, EventArgs e)
        {
            mtbDataRozpoczecia.Text = "";
            mtbDataZakonczenia.Text = "";
            tbIdZamowienieElement.Text = "";
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
            if(string.IsNullOrEmpty(tbIdZamowienieElement.Text))
            {
                MessageBox.Show("Uzupełnienie pola 'ID zamówienie element' jest wymagane!");
            }
            else
            { 
               proces.ID_Zamowienie_Element = Convert.ToInt32(tbIdZamowienieElement.Text);
               //proces.Proponowana_data_dostawy_materialu = Convert.ToDateTime(mtbProponowanaData.Text);
               //proces.Data_Rozpoczecia = Convert.ToDateTime(mtbDataRozpoczecia.Text);
               //proces.Data_Zakonczenia = Convert.ToDateTime(mtbDataZakonczenia.Text);
               //proces.Uwagi = tbUwagi.Text;
               db.Proces_Produkcyjny.Add(proces);
               db.SaveChanges();
               MessageBox.Show("Dodano nowy proces produkcyjny");
            }
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
    }
}
