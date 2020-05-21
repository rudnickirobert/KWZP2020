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
    public partial class SrodkiTrwale : Form
    {
        public SzwalniaEntities db;
        public SrodkiTrwale(SzwalniaEntities db)
        {
            InitializeComponent();
            this.db = db;

            dgvSrodki.DataSource = db.vSrodkiWszystkie.ToList();
            dgvZamortyzowane.DataSource = db.vSrodkiZamortyzowane.ToList();
        }

        private void btnZamknij_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            NowySrodekTrwaly nowySrodekTrwaly = new NowySrodekTrwaly(db);
            nowySrodekTrwaly.Show();
        }
    }
}
