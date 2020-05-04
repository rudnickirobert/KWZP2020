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
    public partial class Polki_na_regale : Form
    {
        public SzwalniaEntities szwalnia_passed;
        public Polki_na_regale(SzwalniaEntities szwalnia_passed, string oznaczenie)
        {
            InitializeComponent();
            vPolki_na_regalach storage = szwalnia_passed.vPolki_na_regalach.Where(regal => regal.Oznaczenie == oznaczenie).First();

            lblTitle.Text = "REGAL " + storage.Oznaczenie;

            dgvRegaly.DataSource = szwalnia_passed.vPolki_na_regalach.Where(regal => regal.Oznaczenie == storage.Oznaczenie).ToList();
        }

        private void dgvRegaly_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvRegaly.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                //MessageBox.Show(dgvRegaly.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
                string numer = dgvRegaly.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

                lblTest.Text = numer;
                Zawartosc_polkiForm polka = new Zawartosc_polkiForm(szwalnia_passed, numer);
                polka.Show();
            }
        }
    }    
}
