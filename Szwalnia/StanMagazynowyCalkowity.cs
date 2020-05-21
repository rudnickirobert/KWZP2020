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
    public partial class StanMagazynowyCalkowity : Form
    {
        public SzwalniaEntities db;
        public StanMagazynowyCalkowity()
        {
            InitializeComponent();
            db = Start.szwalnia;
            dgvStanMagazynowyCalosciowy.ReadOnly = true;
            dgvStanMagazynowyCalosciowy.DataSource = db.vStan_magazynowy_polki.ToList();
            dgvStanMagazynowyCalosciowy.Columns[0].Visible = false;
        }

        private void StanMagazynowyCalkowity_FormClosed(object sender, FormClosedEventArgs e)
        {
            Start.GetForm.Show();
        }
    }
}
