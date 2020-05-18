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
    public partial class WyborPracownika : Form
    {
        public SzwalniaEntities db;
        public WyborPracownika(SzwalniaEntities szwalnia)
        {
            InitializeComponent();
            db = szwalnia;
            dgvListaPracownikow.DataSource = db.vDanePracownika.ToList();
        }

        private void dgvListaPracownikow_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int numerIDPracownika = Convert.ToInt32(dgvListaPracownikow.CurrentRow.Cells[0].Value);
            PracownicySzczegoly pracownicySzczegoly = new PracownicySzczegoly(db, Decimal.ToInt32(numerIDPracownika));
            pracownicySzczegoly.Show();
            this.Close();
        }

        private void btnZamknij_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
