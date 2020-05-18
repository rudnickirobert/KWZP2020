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
    public partial class WydajMaterialProdukcji : Form
    {
        public SzwalniaEntities db;
        public WydajMaterialProdukcji()
        {
            InitializeComponent();
            db = Start.szwalnia;
            if (db.vMaterialyNiewydaneZDatami.Any())
            {
                dgvMaterialyDoWydania.DataSource = db.vMaterialyNiewydaneZDatami.Where(dostawa => dostawa.ID_Zamowienie_Element > 0).ToList();
            }
            else
            {
                DataTable brakDostawDoWydania = new DataTable();
                brakDostawDoWydania.Columns.Add("Informacja");
                brakDostawDoWydania.Rows.Add("Brak dostaw do wydania");
                dgvMaterialyDoWydania.DataSource = brakDostawDoWydania;
            }    
        }

        private void dgvMaterialyDoWydania_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int intIDZamowienie = Convert.ToInt32(dgvMaterialyDoWydania.CurrentRow.Cells[0]);
            int intIDZamowienieElement = Convert.ToInt32(dgvMaterialyDoWydania.CurrentRow.Cells[1]);
            int intElementID = Convert.ToInt32(dgvMaterialyDoWydania.CurrentRow.Cells[2]);
            int intIDDostawy = Convert.ToInt32(dgvMaterialyDoWydania.CurrentRow.Cells[5]);
            int intPolka = Convert.ToInt32(dgvMaterialyDoWydania.CurrentRow.Cells[7]);
            int intIlosc = Convert.ToInt32(dgvMaterialyDoWydania.CurrentRow.Cells[4]);
            PopupAcceptDeny akceptujWydanie = new PopupAcceptDeny(true, intIDZamowienie, intIDZamowienieElement, intElementID, intIDDostawy, intPolka, intIlosc);
            this.Hide();
        }
    }
}
