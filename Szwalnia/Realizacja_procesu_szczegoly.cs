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
    public partial class Realizacja_procesu_szczegoly : Form
    {
        SzwalniaEntities db;
        public Realizacja_procesu_szczegoly(SzwalniaEntities db)
        {
            this.db = db;
            InitializeComponent();

        }

        private void btnRealizacjaProcesuSzczegoly_Click(object sender, EventArgs e)
        {
                       dgvRealProc.DataSource = this.db.vRealizacjaProcesuProdukcyjnegoDetails.Where(details => details.ID_Procesu_Produkcyjnego == numIDProcP.Value).ToList();
        }

    }
}
