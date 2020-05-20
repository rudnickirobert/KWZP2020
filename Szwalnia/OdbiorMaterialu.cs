using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Szwalnia
{
    public partial class OdbiorMaterialu : Form
    {
        public SzwalniaEntities db;
        public int idProcesu;
        public int nrProcesu;
        public OdbiorMaterialu(SzwalniaEntities db, int idProcesu)
        {
            InitializeComponent();
            this.db = db;
            nrProcesu = idProcesu;

            lblProces.Text = "Odbiór materiału w procesie produkcyjnym o ID " + idProcesu;
            lblMagazyn.Text = "Materiał w magazynie";
            lblProdukcja.Text = "Materiał na produkcji";
            
            dgvOdebranyMaterialMagazyn.DataSource = this.db.vOdebranyMaterialMagazyn.Where(num => num.ID_Procesu_Produkcyjnego == idProcesu).ToList();
            dgvOdebranyMaterialMagazyn.Columns[0].Visible = false;
            dgvOdebranyMaterialMagazyn.Columns[1].HeaderText = "ID dostarczenia";
            dgvOdebranyMaterialMagazyn.Columns[2].HeaderText = "Nazwa elementu";
            dgvOdebranyMaterialMagazyn.Columns[3].HeaderText = "ID elementu";
            dgvOdebranyMaterialMagazyn.Columns[4].HeaderText = "Ilość";
            dgvOdebranyMaterialMagazyn.Columns[5].HeaderText = "Data dostarczenia";

            dgvOdebranyMaterialProdukcja.DataSource = this.db.vOdebranyMaterialProdukcja.Where(nun => nun.ID_Procesu_Produkcyjnego == idProcesu).ToList();
            dgvOdebranyMaterialProdukcja.Columns[0].Visible = false;
            dgvOdebranyMaterialProdukcja.Columns[1].HeaderText = "ID dostarczenia";
            dgvOdebranyMaterialProdukcja.Columns[2].HeaderText = "Nazwa elementu";
            dgvOdebranyMaterialProdukcja.Columns[3].HeaderText = "ID elementu";
            dgvOdebranyMaterialProdukcja.Columns[4].HeaderText = "Ilość";
            dgvOdebranyMaterialProdukcja.Columns[5].HeaderText = "Data dostarczenia";

        }

        private void dgvOdebranyMaterialMagazyn_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int numerDostarczenia = Convert.ToInt32(dgvOdebranyMaterialMagazyn.CurrentRow.Cells[1].Value);
            Odbior_Dostarczenia odbiorDostarczenia = new Odbior_Dostarczenia();
            DialogResult dialogResult = MessageBox.Show("Czy odebrano materiał z magazynu?", "Odbiór materiału", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                odbiorDostarczenia.ID_Procesu_Produkcyjnego = Convert.ToInt32(dgvOdebranyMaterialMagazyn.CurrentRow.Cells[0].Value );
                odbiorDostarczenia.ID_Dostarczenia = Convert.ToInt32(dgvOdebranyMaterialMagazyn.CurrentRow.Cells[1].Value);
                odbiorDostarczenia.Odebrano = true;
                db.Odbior_Dostarczenia.Add(odbiorDostarczenia);
                db.SaveChanges();
                MessageBox.Show("Odebrano materiał z magazynu");
                dgvOdebranyMaterialProdukcja.DataSource = this.db.vOdebranyMaterialProdukcja.Where(nun => nun.ID_Procesu_Produkcyjnego == nrProcesu).ToList();
                dgvOdebranyMaterialProdukcja.Columns[0].Visible = false;
                dgvOdebranyMaterialProdukcja.Columns[1].HeaderText = "ID dostarczenia";
                dgvOdebranyMaterialProdukcja.Columns[2].HeaderText = "Nazwa elementu";
                dgvOdebranyMaterialProdukcja.Columns[3].HeaderText = "ID elementu";
                dgvOdebranyMaterialProdukcja.Columns[4].HeaderText = "Ilość";
                dgvOdebranyMaterialProdukcja.Columns[5].HeaderText = "Data dostarczenia";
            }
            
        }        
    }
}
