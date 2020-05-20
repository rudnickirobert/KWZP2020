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
    public partial class StanMagazynowyElementy : Form
    {
        public SzwalniaEntities db;
        public StanMagazynowyElementy()
        {
            InitializeComponent();
            db = Start.szwalnia;
            dgvStanMagazynowyElementy.DataSource = db.vStan_magazynowy_elementy.ToList();
            dgvStanMagazynowyElementy.Columns[0].Visible = false;
        }

        private void dgvStanMagazynowyElementy_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            GdzieLezaElementy gdzie = new GdzieLezaElementy(Convert.ToInt32(dgvStanMagazynowyElementy.CurrentRow.Cells[1].Value));
            gdzie.Show();
        }
    }
}
