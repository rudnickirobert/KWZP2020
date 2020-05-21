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
    public partial class PanelFinansow : Form
    {
        public SzwalniaEntities db;
        public PanelFinansow(SzwalniaEntities db)
        {
            InitializeComponent();
            this.db = db;

            dgvRozchody.DataSource = db.vRozchody.ToList();
            dgvRozchody.Columns[0].Visible = false;

            dgvPrzychody.DataSource = db.vPrzychody.ToList();
            dgvPrzychody.Columns[0].Visible = false;

            dgvBilans.DataSource = db.vBilans.ToList();
            dgvBilans.Columns[0].Visible = false;
        }

        private void btnZamknij_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnZyski_Click(object sender, EventArgs e)
        {
            Zyski zyski = new Zyski(db);
            zyski.Show();
        }
    }
}
