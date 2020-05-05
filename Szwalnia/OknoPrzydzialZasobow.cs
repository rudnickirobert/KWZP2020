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
    public partial class OknoPrzydzialZasobow : Form
    {
        private SzwalniaEntities db;
        public OknoPrzydzialZasobow(SzwalniaEntities zasob)
        {
            InitializeComponent();
            db = zasob;
        }
        private void btnSzczegoly_Click(object sender, EventArgs e)
        {
            Szczegoly szczegoly = new Szczegoly(db, Decimal.ToInt32(numericID.Value));
            szczegoly.Show();
            this.Close();
        }
    }
}
