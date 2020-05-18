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
    public partial class KontrolaEfektywnosciSzczegoly : Form
    {
        public SzwalniaEntities db;
        public int IdProcesu;
        public KontrolaEfektywnosciSzczegoly(SzwalniaEntities db, int IdProcesu)
        {
            InitializeComponent();
            this.db = db;
            this.IdProcesu = IdProcesu; 
            Kontrola_Efektywnosci numerProcesu = db.Kontrola_Efektywnosci.Where(proces => proces.ID_Procesu_Produkcyjnego == IdProcesu).First();
            lblProces.Text = "Kontrola efektywności dla procesu produkcyjnego o ID " + numerProcesu.ID_Procesu_Produkcyjnego;
            mtbDataKontroli.Text = numerProcesu.Data_Kontroli.ToString();
            txtLiczbaPoprawnych.Text = numerProcesu.Liczba_Poprawnych.ToString();
            txtUwagiDoKontroli.Text = numerProcesu.Uwagi.ToString();            
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(mtbDataKontroli.Text))
            {
                MessageBox.Show("Uzupełnienie pola Data kontroli jest wymagane!");
            }
            else
            {
                db.SaveChanges();
                MessageBox.Show("Zaaktualizowano kontrolę efektywności");
            }
        }

        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDzisiaj_Click(object sender, EventArgs e)
        {
            mtbDataKontroli.Text = DateTime.Now.ToString();
        }

        private void btnWyzeruj_Click(object sender, EventArgs e)
        {
            mtbDataKontroli.Text = "";
            txtUwagiDoKontroli.Text = "";
            txtLiczbaPoprawnych.Text = "";
        }
    }
}
