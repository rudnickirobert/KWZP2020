using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace Szwalnia
{
    public partial class KontrolaEfektywnosciSzczegoly : Form
    {
        public SzwalniaEntities db;
        public int idProcesu;
        Kontrola_Efektywnosci kontrola = new Kontrola_Efektywnosci();
        public const string pustePole = "    .  .     :  :";
        public KontrolaEfektywnosciSzczegoly(SzwalniaEntities db, int idProcesu)
        {
            InitializeComponent();
            this.db = db;
            this.idProcesu = idProcesu; 
            kontrola = this.db.Kontrola_Efektywnosci.Where(proces => proces.ID_Procesu_Produkcyjnego == idProcesu).First();
            lblProces.Text = "Kontrola efektywności dla procesu produkcyjnego o ID " + kontrola.ID_Procesu_Produkcyjnego;
            mtbDataKontroli.Text = kontrola.Data_Kontroli.ToString();
            txtLiczbaPoprawnych.Text = kontrola.Liczba_Poprawnych.ToString();
            txtUwagiDoKontroli.Text = kontrola.Uwagi;
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(mtbDataKontroli.Text))
            {
                MessageBox.Show("Uzupełnienie pola Data kontroli jest wymagane!");
            }
            else
            {
                kontrola.Data_Kontroli = Convert.ToDateTime(mtbDataKontroli.Text);
            }
            
            if (!string.IsNullOrWhiteSpace(txtLiczbaPoprawnych.Text))
            {

                kontrola.Liczba_Poprawnych = Convert.ToInt32(txtLiczbaPoprawnych.Text);
            }

            if (txtLiczbaPoprawnych.Text=="")
            {
                kontrola.Liczba_Poprawnych = null;
            }

            if (!string.IsNullOrEmpty(txtUwagiDoKontroli.Text))
            {
                kontrola.Uwagi = txtUwagiDoKontroli.Text;
            }

            if (txtUwagiDoKontroli.Text == "")
            {
                kontrola.Uwagi = "";
            }

            this.db.Entry(kontrola).State = EntityState.Modified;
            db.SaveChanges();
            MessageBox.Show("Zaaktualizowano kontrolę efektywności");
            this.Close();

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
