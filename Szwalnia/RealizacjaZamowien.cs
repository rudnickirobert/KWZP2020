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
    public partial class RealizacjaZamowien : Form
    {
        public SzwalniaEntities db;
        public RealizacjaZamowien()
        {
            db = Start.szwalnia;
            InitializeComponent();
            if (db.vDostawyDoWydania.Any())
            {
                dgvDostarczenia.DataSource = db.vDostawyDoWydania.Where(dostawa => dostawa.ID_Zamowienie_Element > 0).ToList();
                dgvDostarczenia.Columns[0].Visible = false;
                dgvDostarczenia.Columns[1].Visible = false;
                dgvDostarczenia.Columns[5].Visible = false;
                dgvDostarczenia.Columns[6].Visible = false;
                dgvDostarczenia.Columns[2].HeaderText = "Ilość";
                dgvDostarczenia.Columns[4].HeaderText = "Nazwa materiału";
                dgvDostarczenia.Columns[3].HeaderText = "Proponowana data dostarczenia";
            }
            else
            {
                DataTable brakDostawDoWydania = new DataTable();
                brakDostawDoWydania.Columns.Add("Informacja");
                brakDostawDoWydania.Rows.Add("Brak dostaw do wydania");
                dgvDostarczenia.DataSource = brakDostawDoWydania;
                dgvDostarczenia.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
        }

        private void RealizacjaZamowien_FormClosed(object sender, FormClosedEventArgs e)
        {
            Start.GetForm.Show();
        }

        private void dgvDostarczenia_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (db.vMaterialyNiewydaneZDatami.Any())
            {
                int intIDZamowienieElement = Convert.ToInt32(dgvDostarczenia.CurrentRow.Cells[0].Value);
                int intIDElement = Convert.ToInt32(dgvDostarczenia.CurrentRow.Cells[1].Value);
                int intIlosc = Convert.ToInt32(dgvDostarczenia.CurrentRow.Cells[2].Value);
                int intProponowanaData = Convert.ToInt32(dgvDostarczenia.CurrentRow.Cells[3].Value);
                int intElementNazwa = Convert.ToInt32(dgvDostarczenia.CurrentRow.Cells[4].Value);
                int intIDZamowienia = Convert.ToInt32(dgvDostarczenia.CurrentRow.Cells[5].Value);
                int intIDDostawy = Convert.ToInt32(dgvDostarczenia.CurrentRow.Cells[5].Value;
                //PopupAcceptDeny akceptujWydanie = new PopupAcceptDeny(true, intIDZamowienie, intIDZamowienieElement, intElementID, intIDDostawy, intPolka, intIlosc, intPracownikID);
                //akceptujWydanie.Show();
            }
        }
    }
    }
}
