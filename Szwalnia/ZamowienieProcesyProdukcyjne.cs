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
    public partial class ZamowienieProcesyProdukcyjne : Form
    {
        public SzwalniaEntities db;
        public int ostatniNumerZamowienia;
        public ZamowienieProcesyProdukcyjne(SzwalniaEntities db)
        {
            InitializeComponent();
            this.db = db;
            dgvProcesyProdukcyjne.DataSource = db.vZamowienieProcesyProdukcyjne.ToList();
            int ostatnieZamowienie = dgvProcesyProdukcyjne.Rows.Cast<DataGridViewRow>().Max(wartosc => Convert.ToInt32(wartosc.Cells["ID_Zamowienia"].Value));
            ostatniNumerZamowienia = ostatnieZamowienie;
        }

        private void btnSzukaj_Click(object sender, EventArgs e)
        {
            if (nudNumerZamowienia.Value > 0)
            {
                if (nudNumerZamowienia.Value <= ostatniNumerZamowienia)
                {
                    dgvProcesyProdukcyjne.DataSource = this.db.vZamowienieProcesyProdukcyjne.Where(zamowienie => zamowienie.ID_Zamowienia == nudNumerZamowienia.Value).ToList();
                    dgvProcesyProdukcyjne.Columns[1].Visible = false;
                }
                else
                    MessageBox.Show("Nie istnieje takie ID Zamowienia!");
            }
            else
                MessageBox.Show("Wprowadź poprawne ID Zamowienia (wieksze od zera)!");
        }
    }
}
