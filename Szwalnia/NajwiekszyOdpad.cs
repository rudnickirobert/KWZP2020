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
    public partial class NajwiekszyOdpad : Form
    {
        public SzwalniaEntities db;
        public NajwiekszyOdpad( SzwalniaEntities db)
        {
            InitializeComponent();
            this.db = db;
        }

        private void btnPokaz_Click(object sender, EventArgs e)
        {
            dgvOdpad.DataSource = this.db.vProcesMaxOdpadMiesiac.Where(miesiac => miesiac.Miesiac == nudNumerMiesiaca.Value).ToList();
            dgvOdpad.Columns[0].Visible = false;
            dgvOdpad.Columns[1].Visible = false;
        }
    }
}
