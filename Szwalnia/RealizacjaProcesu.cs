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
    public partial class RealizacjaProcesu : Form
    {
        public SzwalniaEntities db;
        public int IdProcesu;
        public RealizacjaProcesu(SzwalniaEntities db,int IdProcesu)
        {
            InitializeComponent();
            this.db = db;
            this.IdProcesu = IdProcesu;
            Proces_Produkcyjny proces = db.Proces_Produkcyjny.Where(wybrany => wybrany.ID_Procesu_Produkcyjnego == IdProcesu).First();
            lblProces.Text = "Realizacja procesu dla procesu produkcyjnego o ID " + proces.ID_Procesu_Produkcyjnego;
            dgvRealizacjaProcesu.DataSource = db.vRealizacjaProcesuProdukcyjnegoDetails.Where(realizacja => realizacja.ID_Procesu_Produkcyjnego == proces.ID_Procesu_Produkcyjnego).ToList();
            dgvRealizacjaProcesu.Columns[0].Visible = false;
        }

        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            db.SaveChanges();
            MessageBox.Show("Zaaktualizowano realizację procesu");
        }

        private void btnNowy_Click(object sender, EventArgs e)
        {
            NowaRealizacjaProcesu nowaRealizacja = new NowaRealizacjaProcesu(db, IdProcesu);
            nowaRealizacja.Show();
        }
    }
}
