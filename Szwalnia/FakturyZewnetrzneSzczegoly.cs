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
    public partial class FakturyZewnetrzneSzczegoly : Form
    {
        private SzwalniaEntities db;
        public int ostatniNumerFaktury;
        public FakturyZewnetrzneSzczegoly(SzwalniaEntities db)
        {
            InitializeComponent();
            this.db = db;
            dgvFakturyZewnetrzne.DataSource = db.vFakturyZewnetrzne.ToList();
            dgvFakturyZewnetrzne.Columns[0].Visible = false;
        }

        private void btnZamknij_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
