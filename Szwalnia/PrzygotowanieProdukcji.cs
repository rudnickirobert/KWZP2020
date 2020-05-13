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
    public partial class PrzygotowanieProdukcji : Form
    {
        private SzwalniaEntities szwalnia;
        public PrzygotowanieProdukcji(SzwalniaEntities db)
        {
            InitializeComponent();
            szwalnia = db;
            
            cmbRodzajObslugi.DataSource = db.Rodzaj_Obslugi.ToList();
            cmbRodzajObslugi.DisplayMember = "Nazwa";
            cmbRodzajObslugi.ValueMember = "Nazwa";
        }

        private void btnSzukaj_Click(object sender, EventArgs e)
        {
           
            dgvObsluga.DataSource = szwalnia.vObsluga.Where(nazwa => nazwa.Rodzaj_obsługi == cmbRodzajObslugi.Text).ToList();
            
        }
    }
}
