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
    public partial class DodawanieElementu : Form
    {
        public DodawanieElementu()
        {
            InitializeComponent();
        }

        private void dgvListaTypy_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            szwalnia.Oferta.Add(ofertaNew);
            szwalnia.SaveChanges();
        }
    }
}
