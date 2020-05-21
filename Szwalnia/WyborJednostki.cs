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
    public partial class WyborJednostki : Form
    {
        public SzwalniaEntities db;
        public int ID;
        public WyborJednostki()
        {
            InitializeComponent();
            db = Start.szwalnia;
            dgvListaJednostek.ReadOnly = true;
            dgvListaJednostek.DataSource = db.Elementy_Jednostki.ToList();
            dgvListaJednostek.Columns[2].Visible = false;
            dgvListaJednostek.Columns[3].Visible = false;
            dgvListaJednostek.Columns[4].Visible = false;
        }

        private void dgvListaJednostek_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int numID = Convert.ToInt32(dgvListaJednostek.CurrentRow.Cells[0].Value);
            ID = numID;
            Elementy_Jednostki jednostka = db.Elementy_Jednostki.Where(wybrany => wybrany.ID_jednostka == ID).First();
            txtNazwa.Text = jednostka.Jednostka;
        }

        private void btnDodawanie_Click(object sender, EventArgs e)
        {
            DodawanieJednostki jednostkaNew = new DodawanieJednostki();
            jednostkaNew.Show();
            this.Hide();
        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            Elementy_Jednostki jednostkaUsun = db.Elementy_Jednostki.Where(wybrany => wybrany.ID_jednostka == ID).First();
            db.Elementy_Jednostki.Remove(jednostkaUsun);
            db.SaveChanges();
            MessageBox.Show("Pomyślnie usunięto element");
        }

        private void btnWstecz_Click(object sender, EventArgs e)
        {
            Application.OpenForms[typeof(ElementyForm).Name].Show();
            this.Hide();
        }
    }
}
