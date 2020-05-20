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
    public partial class PrzyjmowanieDostaw : Form
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
        public PrzyjmowanieDostaw(bool czyPuste)
        {
            InitializeComponent();
            db = Start.szwalnia;
            zamknieciePrzezInnyFormularz = false;
            if (czyPuste)
            {
                DataTable informacjaOBrakuDostaw = new DataTable();
                informacjaOBrakuDostaw.Columns.Add("Informacja");
                informacjaOBrakuDostaw.Rows.Add("Nie ma dostaw, które należy przyjąć");
                dgvDostawyDoPrzyjecia.DataSource = informacjaOBrakuDostaw;
            }
            else
            {                
                dgvDostawyDoPrzyjecia.DataSource = db.vDostawyDoOdbioru.ToList();
                dgvDostawyDoPrzyjecia.Columns[0].HeaderText = "ID Dostawy";
                dgvDostawyDoPrzyjecia.Columns[1].Visible = false;
                dgvDostawyDoPrzyjecia.Columns[2].HeaderText = "Nazwa elementu";
                dgvDostawyDoPrzyjecia.Columns[3].HeaderText = "Ilość";
                dgvDostawyDoPrzyjecia.Columns[4].HeaderText = "Ilość paczek";
            }    
        }
          
        private void PrzyjmowanieDostaw_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!zamknieciePrzezInnyFormularz)
            {
                Application.OpenForms[typeof(ObslugaDostaw).Name].Show();
            }
        }

        private void dgvDostawyDoPrzyjecia_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (db.vDostawyDoOdbioru.Where(doOdebrania => doOdebrania.Ilosc > 0).Any())
            {
                int intDostawaID = Convert.ToInt32(dgvDostawyDoPrzyjecia.CurrentRow.Cells[0].Value);
                int intElementID = Convert.ToInt32(dgvDostawyDoPrzyjecia.CurrentRow.Cells[2].Value);
                int intIlosc = Convert.ToInt32(dgvDostawyDoPrzyjecia.CurrentRow.Cells[3].Value);
                int intIloscPaczek = Convert.ToInt32(dgvDostawyDoPrzyjecia.CurrentRow.Cells[4].Value);
                WyborPolkiDoOdlozenia wybieraniePolkiDoOdlozeniaElementu = new WyborPolkiDoOdlozenia("dostawa", intDostawaID, intElementID, intIlosc, intIloscPaczek);
                wybieraniePolkiDoOdlozeniaElementu.Show();
                this.Hide();
            }
        }
    }
}
