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
    public partial class RealizacjaProcesuSzczegoly : Form
    {
        SzwalniaEntities db;
        public RealizacjaProcesuSzczegoly(SzwalniaEntities db)
        {
            this.db = db;
            InitializeComponent();

        }

        private void btnRealizacjaProcesuSzczegoly_Click(object sender, EventArgs e)
        {
           dgvRealizacjaProcesu.DataSource = this.db.vRealizacjaProcesuProdukcyjnegoDetails.Where(details => details.ID_Procesu_Produkcyjnego == numIDProcesuProdukcyjnego.Value).ToList();
        }

    }
}
