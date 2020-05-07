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
    public partial class ProcesyProdukcyjneID : Form
    {
        public SzwalniaEntities db;
        public ProcesyProdukcyjneID( SzwalniaEntities db)
        {
            InitializeComponent();
            this.db = db;
            
        }

        private void btnPokaz_Click(object sender, EventArgs e)
        {
            dgvProcesProdukcyjny.DataSource = this.db.Proces_Produkcyjny.Where(numer => numer.ID_Procesu_Produkcyjnego == nudIdProcesu.Value).ToList();
            dgvProcesProdukcyjny.Columns[1].Visible = false;
        }
    }
}
