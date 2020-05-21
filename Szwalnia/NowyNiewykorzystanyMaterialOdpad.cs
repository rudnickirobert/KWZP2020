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
    public partial class NowyNiewykorzystanyMaterialOdpad : Form
    {
        public SzwalniaEntities db;
        public int idProcesu;
        public NowyNiewykorzystanyMaterialOdpad(SzwalniaEntities db, int idProcesu)
        {
            InitializeComponent();
            this.db = db;
            this.idProcesu = idProcesu;
            vElementyProcesProdukcyjny proces = db.vElementyProcesProdukcyjny.Where(elementy => elementy.ID_Procesu_Produkcyjnego == idProcesu).First();
            lblTekst.Text = "do procesu produkcyjnego o ID " + proces.ID_Procesu_Produkcyjnego;
            cbxElement.DataSource = db.vElementyProcesProdukcyjny.Where(material => material.ID_Procesu_Produkcyjnego == proces.ID_Procesu_Produkcyjnego).ToList();
            cbxElement.DisplayMember = "Element";
            cbxElement.ValueMember = "ID_Elementy_Proces";
            
        }

        void nowy()
        {
            Material_Na_Produkcji materialProdukcja = new Material_Na_Produkcji();

            if (string.IsNullOrEmpty(cbxElement.Text))
            {
                MessageBox.Show("Uzupełnienie pola 'Element' jest wymagane!");
            }
            else
            {
                materialProdukcja.ID_Elementy_Proces = Convert.ToInt32(cbxElement.SelectedValue);
                materialProdukcja.ID_Procesu_Produkcyjnego = idProcesu;

                if (!string.IsNullOrEmpty(tbOdpad.Text))
                {
                    materialProdukcja.Odpad = Convert.ToUInt64(tbOdpad.Text);
                }

                if (!string.IsNullOrEmpty(tbNiewykorzystanyMaterial.Text))
                {
                    materialProdukcja.Niezuzyty_material = Convert.ToUInt64(tbNiewykorzystanyMaterial.Text);
                }
                materialProdukcja.Magazyn_odebral_material = chbOdbior.Checked;

            }
            db.Material_Na_Produkcji.Add(materialProdukcja);
            db.SaveChanges();
            MessageBox.Show("Dodano nowy niewykorzystany materiał / odpad");
        }
        private void btnZapisz_Click(object sender, EventArgs e)
        {
            nowy();
            cbxElement.Text = "";
            tbNiewykorzystanyMaterial.Text = "";
            tbOdpad.Text = "";
            chbOdbior.Checked = false;

        }
        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnWyzeruj_Click(object sender, EventArgs e)
        {
            cbxElement.Text = "";
            tbNiewykorzystanyMaterial.Text = "";
            tbOdpad.Text = "";
            chbOdbior.Checked = false;
        }

        private void cbxElement_SelectedIndexChanged(object sender, EventArgs e)
        {
            string numer = cbxElement.SelectedValue.ToString();
            dgvUkryty.DataSource = db.vElementyProcesProdukcyjny.Where(material => (material.ID_Elementy_Proces.ToString() == numer)).ToList();
            dgvUkryty.Columns.OfType<DataGridViewColumn>().ToList().ForEach(kolumna => kolumna.Visible = false);
            dgvUkryty.Columns[8].Visible = true;
        }

        private void NowyNiewykorzystanyMaterialOdpad_FormClosed(object sender, FormClosedEventArgs e)
        {
            NiewykorzystanyMaterialProces niewykorzystanyMaterialProces = new NiewykorzystanyMaterialProces(db, idProcesu);
            niewykorzystanyMaterialProces.Show();
        }

        private void btnZapiszZamknij_Click(object sender, EventArgs e)
        {
            nowy();
            this.Close();
        }
    }
}
