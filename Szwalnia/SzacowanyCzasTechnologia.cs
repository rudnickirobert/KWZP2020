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
    public partial class SzacowanyCzasTechnologia : Form
    {
        SzwalniaEntities db;
        public SzacowanyCzasTechnologia(SzwalniaEntities db)
        {
            InitializeComponent();
            this.db = db;
        }

        private void btnSzacowanyCzasTechnologow_Click(object sender, EventArgs e)
        {
            dgvCzasTechnologow.DataSource = this.db.vSzacowanaDataZamowieniaTechnologow.Where(szacowanaData => szacowanaData.ID_Zamowienia == numIDZamowienia.Value).ToList();
            dgvCzasTechnologow.Columns[0].Visible = false;
            dgvCzasTechnologow.Columns[1].HeaderText = "ID zamówienie element";
            dgvCzasTechnologow.Columns[2].HeaderText = "Nazwa produktu";
            dgvCzasTechnologow.Columns[3].HeaderText = "Czas wykonania [h]";
            dgvCzasTechnologow.Columns[4].HeaderText = "Prognozowana data wykonania";
        }
    }
}
