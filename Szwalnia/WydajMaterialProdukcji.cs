using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Szwalnia
{
    public partial class WydajMaterialProdukcji : Form
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
        public WydajMaterialProdukcji()
        {
            InitializeComponent();
            db = Start.szwalnia;
            if (db.vDostawyNiewydaneZPolkami.Any())
            {
                dgvMaterialyDoWydania.DataSource = db.vDostawyNiewydaneZPolkami.Where(dostawa => dostawa.ID_Zamowienia > 0).ToList();
                dgvMaterialyDoWydania.Columns[0].HeaderText = "Numer zamówienia";
                dgvMaterialyDoWydania.Columns[1].HeaderText = "Numer dostawy";
                dgvMaterialyDoWydania.Columns[2].Visible = false;
                dgvMaterialyDoWydania.Columns[3].HeaderText = "Nazwa materiału";
                dgvMaterialyDoWydania.Columns[4].HeaderText = "Ilość";
                dgvMaterialyDoWydania.Columns[5].HeaderText = "Sugerowana data wydania";
                dgvMaterialyDoWydania.Columns[6].HeaderText = "Numer półki";
                dgvMaterialyDoWydania.ReadOnly = true;
            }
            else
            {
                DataTable brakDostawDoWydania = new DataTable();
                brakDostawDoWydania.Columns.Add("Informacja");
                brakDostawDoWydania.Rows.Add("Brak dostaw do wydania");
                dgvMaterialyDoWydania.DataSource = brakDostawDoWydania;
            }
            if (db.vPracownicyMagazynu.Where(pracownik => pracownik.ID_Pracownika > 0).Any())
            {
                cmbPracownik.DataSource = db.vPracownicyMagazynu.ToList();
                cmbPracownik.DisplayMember = "Dane_osobowe";
                cmbPracownik.ValueMember = "ID_Pracownika";
            }
            else
            {
                DataTable brakPracownikow = new DataTable();
                brakPracownikow.Columns.Add("Informacja");
                brakPracownikow.Rows.Add("Nie ma takich pracownikow");
                cmbPracownik.DataSource = brakPracownikow;
                cmbPracownik.DisplayMember = "Informacja";
                cmbPracownik.ValueMember = "Informacja";
            }
        }

        private void dgvMaterialyDoWydania_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (db.vMaterialyNiewydaneZDatami.Any())
            {
                int intIDZamowienie = Convert.ToInt32(dgvMaterialyDoWydania.CurrentRow.Cells[0].Value);
                int intElementID = Convert.ToInt32(dgvMaterialyDoWydania.CurrentRow.Cells[2].Value);
                int intIDDostawy = Convert.ToInt32(dgvMaterialyDoWydania.CurrentRow.Cells[1].Value);
                int intPolka = Convert.ToInt32(dgvMaterialyDoWydania.CurrentRow.Cells[6].Value);
                int intIlosc = Convert.ToInt32(dgvMaterialyDoWydania.CurrentRow.Cells[4].Value);
                int intPracownikID = Convert.ToInt32(cmbPracownik.SelectedValue);
                PopupAcceptDeny akceptujWydanie = new PopupAcceptDeny(true, intIDZamowienie, intElementID, intIDDostawy, intPolka, intIlosc, intPracownikID);
                akceptujWydanie.Show();
            }
        }

        private void WydajMaterialProdukcji_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!zamknieciePrzezInnyFormularz)
            {
                Application.OpenForms[typeof(ObslugaDostaw).Name].Show();
            }
        }
    }
}
