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
    public partial class NiewykorzystanyMaterialWMiesiacu : Form
    {
        public SzwalniaEntities db;
        public NiewykorzystanyMaterialWMiesiacu(SzwalniaEntities db)
        {
            InitializeComponent();
            this.db = db;
            
        }

        private void btnPokaz_Click(object sender, EventArgs e)
        {
           dgvNiewykorzystanyMaterial.DataSource = this.db.vNiezuzyteWMiesiacu.Where(miesiac => miesiac.Miesiac == nudNumerMiesiaca.Value).ToList();
            dgvNiewykorzystanyMaterial.Columns[0].Visible = false;
            dgvNiewykorzystanyMaterial.Columns[4].Visible = false;

        }
    }
}
