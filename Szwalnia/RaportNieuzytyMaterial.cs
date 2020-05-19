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
    public partial class RaportNieuzytyMaterial : Form
    {
        public SzwalniaEntities db;
        public RaportNieuzytyMaterial(SzwalniaEntities db)
        {
            InitializeComponent();

            this.db = db;

            dgvNieuzytyMaterialOdpad.DataSource = db.vNieuzytyMaterialOdpad.ToList();

            dgvNieuzytyMaterialOdpad.Columns[1].Visible = false;
            dgvNieuzytyMaterialOdpad.Columns[2].Visible = false;
            dgvNieuzytyMaterialOdpad.Columns[4].Visible = false;
            dgvNieuzytyMaterialOdpad.Columns[0].HeaderText = "ID zamówienia";
            dgvNieuzytyMaterialOdpad.Columns[3].HeaderText = "ID procesu produkcyjnego";
            dgvNieuzytyMaterialOdpad.Columns[5].HeaderText = "ID elementu";
            dgvNieuzytyMaterialOdpad.Columns[6].HeaderText = "Nazwa elementu";
            dgvNieuzytyMaterialOdpad.Columns[7].HeaderText = "Jednostka";
            dgvNieuzytyMaterialOdpad.Columns[8].HeaderText = "Odpad";
            dgvNieuzytyMaterialOdpad.Columns[9].HeaderText = "Niewykorzystany materiał";
            dgvNieuzytyMaterialOdpad.Columns[10].HeaderText = "Magazyn odebrał";
            dgvNieuzytyMaterialOdpad.Columns[11].HeaderText = "Data zakończenia procesu";
        }

        private void btnSzukajIDPrcoesu_Click(object sender, EventArgs e)
        {
            dgvNieuzytyMaterialOdpad.DataSource = this.db.vNieuzytyMaterialOdpad.Where(proces => proces.ID_Procesu_Produkcyjnego == nudProces.Value).ToList();
            dgvNieuzytyMaterialOdpad.Columns.OfType<DataGridViewColumn>().ToList().ForEach(kolumna => kolumna.Visible = true);
            dgvNieuzytyMaterialOdpad.Columns[1].Visible = false;
            dgvNieuzytyMaterialOdpad.Columns[2].Visible = false;
            dgvNieuzytyMaterialOdpad.Columns[4].Visible = false;
        }

        private void btnSzukajDataZakonczenia_Click(object sender, EventArgs e)
        {
            dgvNieuzytyMaterialOdpad.DataSource = this.db.vNieuzytyMaterialOdpad.Where(data => (data.Data_Zakończenia.Value.Month == dtpDataZakonczenia.Value.Month) && (data.Data_Zakończenia.Value.Year == dtpDataZakonczenia.Value.Year)).ToList();
            dgvNieuzytyMaterialOdpad.Columns.OfType<DataGridViewColumn>().ToList().ForEach(kolumna => kolumna.Visible = true);
            dgvNieuzytyMaterialOdpad.Columns[1].Visible = false;
            dgvNieuzytyMaterialOdpad.Columns[2].Visible = false;
            dgvNieuzytyMaterialOdpad.Columns[4].Visible = false;
        }

        private void btnMagazynNieOdebral_Click(object sender, EventArgs e)
        {
            dgvNieuzytyMaterialOdpad.DataSource = this.db.vNieuzytyMaterialOdpad.Where(material => material.Magazyn_Odebrał_Materiał == false).ToList();
            dgvNieuzytyMaterialOdpad.Columns.OfType<DataGridViewColumn>().ToList().ForEach(kolumna => kolumna.Visible = true);
            dgvNieuzytyMaterialOdpad.Columns[1].Visible = false;
            dgvNieuzytyMaterialOdpad.Columns[2].Visible = false;
            dgvNieuzytyMaterialOdpad.Columns[4].Visible = false;
        }

        private void btnMaterialWyswietlWszystko_Click(object sender, EventArgs e)
        {
            dgvNieuzytyMaterialOdpad.DataSource = db.vNieuzytyMaterialOdpad.ToList();
            dgvNieuzytyMaterialOdpad.Columns[1].Visible = false;
            dgvNieuzytyMaterialOdpad.Columns[2].Visible = false;
            dgvNieuzytyMaterialOdpad.Columns[4].Visible = false;
            dgvNieuzytyMaterialOdpad.Columns[0].HeaderText = "ID zamówienia";
            dgvNieuzytyMaterialOdpad.Columns[3].HeaderText = "ID procesu produkcyjnego";
            dgvNieuzytyMaterialOdpad.Columns[5].HeaderText = "ID elementu";
            dgvNieuzytyMaterialOdpad.Columns[6].HeaderText = "Nazwa elementu";
            dgvNieuzytyMaterialOdpad.Columns[7].HeaderText = "Jednostka";
            dgvNieuzytyMaterialOdpad.Columns[8].HeaderText = "Odpad";
            dgvNieuzytyMaterialOdpad.Columns[9].HeaderText = "Niewykorzystany materiał";
            dgvNieuzytyMaterialOdpad.Columns[10].HeaderText = "Magazyn odebrał";
            dgvNieuzytyMaterialOdpad.Columns[11].HeaderText = "Data zakończenia";
        }
    }
}
