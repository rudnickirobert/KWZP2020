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
    public partial class OdbierzMaterialZProdukcji : Form
    {
        private static bool zamknieciePrzezInnyFormularz;
        public static bool czyZamknietyPrzezInny
        {
            get
            {
                return zamknieciePrzezInnyFormularz;
            }
            set
            {
                if (zamknieciePrzezInnyFormularz != value)
                    zamknieciePrzezInnyFormularz = value;
            }
        }
        public SzwalniaEntities db;
        public OdbierzMaterialZProdukcji()
        {
            InitializeComponent();
            db = Start.szwalnia;
            if (db.vNieodebraneMaterialyWgDostawcyZNazwaIOferta.Any())
            {
                dgvMaterialDoOdebrania.DataSource = db.vNieodebraneMaterialyWgDostawcyZNazwaIOferta.ToList();
                dgvMaterialDoOdebrania.Columns[0].Visible = false;
                dgvMaterialDoOdebrania.Columns[1].Visible = false;
                dgvMaterialDoOdebrania.Columns[2].Visible = false;
                dgvMaterialDoOdebrania.Columns[3].HeaderText = "Nazwa materiału";
                dgvMaterialDoOdebrania.Columns[4].HeaderText = "Ilość pozostała";
                dgvMaterialDoOdebrania.Columns[5].Visible = false;
            }
            else
            {
                DataTable informacjaOBrakuMaterialowDoOdbioru = new DataTable();
                informacjaOBrakuMaterialowDoOdbioru.Columns.Add("Informacja");
                informacjaOBrakuMaterialowDoOdbioru.Rows.Add("Brak resztek materiałów do odbioru");
                dgvMaterialDoOdebrania.DataSource = informacjaOBrakuMaterialowDoOdbioru;
            }
        }


        private void dgvMaterialDoOdebrania_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (db.vNieodebraneMaterialyWgDostawcyZNazwaIOferta.Any())
            {
                int intDostawaID = Convert.ToInt32(dgvMaterialDoOdebrania.CurrentRow.Cells[1].Value);
                int intElementID = Convert.ToInt32(dgvMaterialDoOdebrania.CurrentRow.Cells[2].Value);
                int intIlosc = Convert.ToInt32(dgvMaterialDoOdebrania.CurrentRow.Cells[4].Value);
                double intIloscLacznie = Convert.ToDouble(dgvMaterialDoOdebrania.CurrentRow.Cells[4].Value);
                double intIloscWPaczce = Convert.ToDouble(dgvMaterialDoOdebrania.CurrentRow.Cells[5].Value);
                double dblIlosc = intIloscLacznie / intIloscWPaczce;
                int intIDZamowienieElement = Convert.ToInt32(dgvMaterialDoOdebrania.CurrentRow.Cells[0].Value);
                WyborPolkiDoOdlozenia wyborPolki = new WyborPolkiDoOdlozenia("przyjecieResztek", intDostawaID, intElementID, dblIlosc,intIlosc, intIDZamowienieElement);
                wyborPolki.Show();
                this.Hide();
            }
        }

        private void OdbierzMaterialZProdukcji_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!zamknieciePrzezInnyFormularz)
            {
                Application.OpenForms[typeof(ObslugaDostaw).Name].Show();
            }
        }
    }
}
