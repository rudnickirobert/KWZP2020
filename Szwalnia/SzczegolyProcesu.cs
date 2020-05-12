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
    public partial class SzczegolyProcesu : Form
    {
        public SzwalniaEntities db;
        public int IdProcesu;
        public SzczegolyProcesu(SzwalniaEntities db, int IdProcesu)
        {
            InitializeComponent();
            this.db = db;
            this.IdProcesu = IdProcesu;
        }

        private void btnRealizacjaProcesu_Click(object sender, EventArgs e)
        {
            RealizacjaProcesu realizacjaProcesu = new RealizacjaProcesu(db,IdProcesu);
            realizacjaProcesu.Show();
        }

        private void btnKontrolaEfektywnosci_Click(object sender, EventArgs e)
        {
            KontrolaEfektywnosciFormSzczegoly kontrolaEfektywnosciFormSzczegoly = new KontrolaEfektywnosciFormSzczegoly(db, IdProcesu);
            kontrolaEfektywnosciFormSzczegoly.Show();
        }

        private void btnMaterialProdukcja_Click(object sender, EventArgs e)
        {
            NiewykorzystanyMaterialProces niewykorzystanyMaterialProces = new NiewykorzystanyMaterialProces(db, IdProcesu);
            niewykorzystanyMaterialProces.Show();
        }
    }
}
