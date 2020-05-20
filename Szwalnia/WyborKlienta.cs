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
    public partial class WyborKlienta : Form
    {
        public SzwalniaEntities db;

        public WyborKlienta(SzwalniaEntities szwalnia)
        {
            InitializeComponent();
            db = szwalnia;
            dgvListaKlientow.DataSource = db.Klienci.ToList();
        }

        private void dgvListaKlientow_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int numerIDKlienta = Convert.ToInt32(dgvListaKlientow.CurrentRow.Cells[0].Value);
            KlienciSzczegoly klienciSzczegoly = new KlienciSzczegoly(db, Decimal.ToInt32(numerIDKlienta));
            klienciSzczegoly.Show();
            this.Close();
        }

        private void btnZamknij_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
