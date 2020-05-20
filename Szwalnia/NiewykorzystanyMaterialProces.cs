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
    public partial class NiewykorzystanyMaterialProces : Form
    {
        public SzwalniaEntities db;
        public int idProcesu;
        Material_Na_Produkcji material = new Material_Na_Produkcji();
        public NiewykorzystanyMaterialProces(SzwalniaEntities db, int idProcesu )
        {
            InitializeComponent();
            this.db = db;
            this.idProcesu = idProcesu;
            Proces_Produkcyjny proces = db.Proces_Produkcyjny.Where(wybrany => wybrany.ID_Procesu_Produkcyjnego == idProcesu).First();
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

        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNowy_Click(object sender, EventArgs e)
        {
            NowyNiewykorzystanyMaterialOdpad nowyNiewykorzystanyMaterialOdpad = new NowyNiewykorzystanyMaterialOdpad(db, idProcesu);
            nowyNiewykorzystanyMaterialOdpad.Show();
        }

        private void btnEdycja_Click(object sender, EventArgs e)
        {

            material.ID_Procesu_Produkcyjnego = idProcesu;

            if (!string.IsNullOrEmpty(tbOdpad.Text))
            {
                material.Odpad = Convert.ToUInt64(tbOdpad.Text);
            }

            if (!string.IsNullOrEmpty(tbNiewykorzystanyMaterial.Text))
            {
                material.Niezuzyty_material = Convert.ToUInt64(tbNiewykorzystanyMaterial.Text);
            }

            this.db.Entry(material).State = EntityState.Modified;
            db.SaveChanges();
            MessageBox.Show("Zaktualizowano niewykorzystany materiał / odpad");
        }

        private void dgvNiewykorzystanyMaterial_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            material.ID_Material_Na_Produkcji= Convert.ToInt32(dgvNiewykorzystanyMaterial.CurrentRow.Cells[2].Value);
            material.ID_Elementy_Proces = Convert.ToInt32(dgvNiewykorzystanyMaterial.CurrentRow.Cells[4].Value);
            material.Magazyn_odebral_material = Convert.ToBoolean(dgvNiewykorzystanyMaterial.CurrentRow.Cells[10].Value);
            material = this.db.Material_Na_Produkcji.Where(numer => numer.ID_Material_Na_Produkcji== material.ID_Material_Na_Produkcji).First();
            tbOdpad.Text = material.Odpad.ToString();
            tbNiewykorzystanyMaterial.Text = material.Niezuzyty_material.ToString(); 
        }
    }
}
