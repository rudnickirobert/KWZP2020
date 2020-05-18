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
    public partial class NiewykorzystanyMaterialProces : Form
    {
        public SzwalniaEntities db;
        public int IdProcesu;
        public NiewykorzystanyMaterialProces(SzwalniaEntities db, int IdProcesu )
        {
            InitializeComponent();
            this.db = db;
            this.IdProcesu = IdProcesu;
            Proces_Produkcyjny proces = db.Proces_Produkcyjny.Where(wybrany => wybrany.ID_Procesu_Produkcyjnego == IdProcesu).First();
            lblTekst.Text = "Niewykorzystany materiał / odpad w procesie produkcyjnym o ID " + proces.ID_Procesu_Produkcyjnego;
            dgvNiewykorzystanyMaterial.DataSource = db.vNieuzytyMaterialOdpad.Where(material => material.ID_Procesu_Produkcyjnego == proces.ID_Procesu_Produkcyjnego).ToList();
           
            dgvNiewykorzystanyMaterial.Columns[0].Visible = false;
            dgvNiewykorzystanyMaterial.Columns[1].Visible = false;
            dgvNiewykorzystanyMaterial.Columns[2].Visible = false;
            dgvNiewykorzystanyMaterial.Columns[3].Visible = false;
            dgvNiewykorzystanyMaterial.Columns[4].Visible = false;
            dgvNiewykorzystanyMaterial.Columns[11].Visible = false;

            dgvNiewykorzystanyMaterial.Columns[5].HeaderText = "ID elementu";
            dgvNiewykorzystanyMaterial.Columns[6].HeaderText = "Nazwa elementu";
            dgvNiewykorzystanyMaterial.Columns[9].HeaderText = "Niewykorzystany materiał";
            dgvNiewykorzystanyMaterial.Columns[10].HeaderText = "Magazyn odebrał";
            

        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            db.SaveChanges();
            MessageBox.Show("Zaaktualizowano realizację procesu");
        }

        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNowy_Click(object sender, EventArgs e)
        {
            NowyNiewykorzystanyMaterialOdpad nowyNiewykorzystanyMaterialOdpad = new NowyNiewykorzystanyMaterialOdpad(db, IdProcesu);
            nowyNiewykorzystanyMaterialOdpad.Show();
        }
    }
}
