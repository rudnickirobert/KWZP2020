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

        private void dgvListaKlientow_CellDoubleClik(object sender, DataGridViewCellEventArgs e)
        {
            int numID = Convert.ToInt32(dgvListaKlientow.CurrentRow.Cells[0].Value);
            KlienciSzczegoly klienciSzczegoly = new KlienciSzczegoly(db, Decimal.ToInt32(numID));
            klienciSzczegoly.Show();
            this.Close();
        }
    }
}
