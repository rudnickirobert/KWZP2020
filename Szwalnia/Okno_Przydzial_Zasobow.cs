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
    public partial class Okno_Przydzial_Zasobow : Form

    {
        private SzwalniaEntities db;

        public Okno_Przydzial_Zasobow(SzwalniaEntities zasob)
        {
            InitializeComponent();
            db = zasob;
        }
       
        private void btnClose_Click(object sender, EventArgs e)
        {
            Szczegoly szczegoly = new Szczegoly(db, Decimal.ToInt32(numericID.Value));
            szczegoly.Show();
            this.Close();
        }
    }
}
