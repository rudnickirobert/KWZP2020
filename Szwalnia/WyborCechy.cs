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
    public partial class WyborCechy : Form
    {
        public SzwalniaEntities db;
        public int ID;
        public WyborCechy()
        {
            InitializeComponent();
            db = Start.szwalnia;
            dgvListaCech.ReadOnly = true;
            dgvListaCech.DataSource = db.Elementy_Cechy_Slownik.ToList();
            dgvListaCech.Columns[0].Visible = false;
            dgvListaCech.Columns[2].Visible = false;
            dgvListaCech.Columns[3].Visible = false;
            dgvListaCech.ReadOnly = true;
        }
        private void dgvListaCech_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int numID = Convert.ToInt32(dgvListaCech.CurrentRow.Cells[0].Value);
            ID = numID;
            Elementy_Cechy_Slownik cecha = db.Elementy_Cechy_Slownik.Where(wybrany => wybrany.ID_Cecha == ID).First();
            txtNazwa.Text = cecha.Cecha;
        }
        private void btnDodawanie_Click(object sender, EventArgs e)
        {
            DodawanieCechy cecha = new DodawanieCechy();
            cecha.Show();
            this.Hide();
        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            Elementy_Cechy_Slownik cechaUsun = db.Elementy_Cechy_Slownik.Where(wybrany => wybrany.ID_Cecha == ID).First();
            db.Elementy_Cechy_Slownik.Remove(cechaUsun);
            db.SaveChanges();
            Start.DataBaseRefresh();
            dgvListaCech.Refresh();
            MessageBox.Show("Pomyślnie usunięto element");
        }

        private void btnWstecz_Click(object sender, EventArgs e)
        {
            Application.OpenForms[typeof(ElementyForm).Name].Show();
            this.Hide();
        }

        private void WyborCechy_FormClosed(object sender, FormClosedEventArgs e)
        {
            Start.GetForm.Show();
        }
    }
}
