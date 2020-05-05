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
    public partial class ZarzadzanieForm : Form
    {
        public SzwalniaEntities db;
        public ZarzadzanieForm(SzwalniaEntities szwalnia)
        {
            db = szwalnia;
            InitializeComponent();
        }
        private void btnZamknij_MouseClick(object sender, MouseEventArgs e)
        {
             this.Close();
        }

        private void btnKlienciForm_Click(object sender, EventArgs e)
        {
            WyborKlienta wyborKlienta = new WyborKlienta(db);
            wyborKlienta.Show();
            this.Close();
        }

        private void btnFakturyZewnetrzne_Click(object sender, EventArgs e)
        {
            FakturyZewnetrzne fakturyZewnetrzne = new FakturyZewnetrzne(db);
            fakturyZewnetrzne.Show();
        }

        private void ZarzadzanieForm_Load(object sender, EventArgs e)
        {

        }
    }
}
