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
    public partial class InneProdukcja : Form
    {
        public SzwalniaEntities db;
        public InneProdukcja(SzwalniaEntities db)
        {
            InitializeComponent();
            this.db = db;
        }

        private void btnNowyRodzajEtapu_Click(object sender, EventArgs e)
        {
            NowyRodzajEtapu nowyRodzajEtapu = new NowyRodzajEtapu(db);
            nowyRodzajEtapu.Show();
        }

        private void btnSredniCzasProdukcji_Click(object sender, EventArgs e)
        {
            SredniCzasProdukcji sredniCzasProdukcji = new SredniCzasProdukcji(db);
            sredniCzasProdukcji.Show();
        }

        private void btnSzacowanyCzas_Click(object sender, EventArgs e)
        {
            SzacowanyCzasWykonaniaNowegoElementu szacowanyCzasWykonaniaNowegoElementu = new SzacowanyCzasWykonaniaNowegoElementu(db);
            szacowanyCzasWykonaniaNowegoElementu.Show();
        }

        private void btnRodzajEtapu_Click(object sender, EventArgs e)
        {
            RodzajEtapu rodzajEtapu = new RodzajEtapu(db);
            rodzajEtapu.Show();
        }
    }
}
