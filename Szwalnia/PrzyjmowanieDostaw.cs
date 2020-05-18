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
        public SzwalniaEntities db;
        public PrzyjmowanieDostaw(bool czyPuste)
        {
            InitializeComponent();
            db = Start.szwalnia;
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
            }    
        }

        private void dgvDostawyDoPrzyjecia_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            WyborPolkiDoOdlozenia wybieraniePolkiDoOdlozeniaElementu = new WyborPolkiDoOdlozenia();
            wybieraniePolkiDoOdlozeniaElementu.Show();
            this.Close();
        }

        private void PrzyjmowanieDostaw_FormClosed(object sender, FormClosedEventArgs e)
        {
            Start.GetForm.Show();
        }
    }
}
