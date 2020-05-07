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
    public partial class FakturyZewnetrzne : Form
    {
        public SzwalniaEntities db;
        public FakturyZewnetrzne(SzwalniaEntities szwalnia)
        {
            InitializeComponent();
            db = szwalnia;
            dgvFakturyZewnetrzne.DataSource = db.Faktury_Zewnetrzne.ToList();
        }

        private void dgvFakturyZewnetrzne_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int numerIDFaktury = Convert.ToInt32(dgvFakturyZewnetrzne.CurrentRow.Cells[0].Value);
            FakturyZewnetrzneSzczegoly fakturyZewnetrzneSzczegoly = new FakturyZewnetrzneSzczegoly(db, Decimal.ToInt32(numerIDFaktury));
            fakturyZewnetrzneSzczegoly.Show();
            this.Close();
        }
    }
}
