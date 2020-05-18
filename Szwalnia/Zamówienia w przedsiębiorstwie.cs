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
    public partial class ZamówieniaWPrzedsiębiorstwie : Form
    {
        public SzwalniaEntities db;
        public ZamówieniaWPrzedsiębiorstwie(SzwalniaEntities szwalnia)
        {
            db = szwalnia;
            InitializeComponent();
            dgvZamowienia.DataSource = db.vZamowienie.ToList();
        }

        private void dgvZamowienia_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int numerIDZamowienia = Convert.ToInt32(dgvZamowienia.CurrentRow.Cells[0].Value);
            SzczegolyZamowienia szczegolyZamowienia = new SzczegolyZamowienia(db, Decimal.ToInt32(numerIDZamowienia));
            szczegolyZamowienia.Show();
            this.Close();
        }

        private void btnZamknij_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
