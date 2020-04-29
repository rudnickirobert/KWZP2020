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
    public partial class Realizacja_proc_szcz : Form
    {
        public Realizacja_proc_szcz(SzwalniaEntities db)
        {
            InitializeComponent();

        }

        private void btnRealProcSzcz_Click(object sender, EventArgs e)
        {
            SzwalniaEntities db = new SzwalniaEntities();
            dgvRealProc.DataSource = db.vRealizacjaProcesuProdukcyjnegoDetails.Where(details => details.ID_Procesu_Produkcyjnego == numIDProcP.Value).ToList();
        }

    }
}
