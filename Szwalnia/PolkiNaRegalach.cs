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
    public partial class PolkiNaRegalach : Form
    {
        public SzwalniaEntities db;
        public bool isFull(int i)
        {
            int idPolka = Convert.ToInt16(dgvPolkiNaRegale.Rows[i].Cells[1].Value);
            if (db.Zawartosc.Where(content => content.ID_Polka == idPolka).Any())
                return true;
            else
                return false;
        }
        public PolkiNaRegalach()
        {
            InitializeComponent();
            db = Start.szwalnia;
            cmbOznaczenie.Sorted = true;
            cmbOznaczenie.DataSource = db.Regaly.ToList();
            cmbOznaczenie.DisplayMember = "Oznaczenie";
        }

        private void btnLupa_Click(object sender, EventArgs e)
        {
            dgvPolkiNaRegale.DataSource = db.vPolki_na_regalach.Where(regal => regal.Oznaczenie.Equals(cmbOznaczenie.Text)).ToList();
            dgvPolkiNaRegale.Columns[0].Visible = dgvPolkiNaRegale.Columns[2].Visible =
                dgvPolkiNaRegale.Columns[3].Visible = dgvPolkiNaRegale.Columns[4].Visible = false;

            for (int i = 0; i < dgvPolkiNaRegale.RowCount; i++)
            {
                if (isFull(i))
                {
                    dgvPolkiNaRegale.Rows[i].Cells[6].Value = "zajęta";
                    dgvPolkiNaRegale.Rows[i].DefaultCellStyle.BackColor = Color.IndianRed;
                }
                else
                {
                    dgvPolkiNaRegale.Rows[i].Cells[6].Value = "pusta";
                    dgvPolkiNaRegale.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen;
                }
            }
        }

    private void dgvPolkiNaRegale_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (isFull(dgvPolkiNaRegale.CurrentRow.Index))
            {
                ZawartoscPolki zawartosc = new ZawartoscPolki(Convert.ToInt32(dgvPolkiNaRegale.CurrentRow.Cells[1].Value));
                zawartosc.Show();
            }
            //tego okienka przy przejściu do zawartości półki nie chować
        }

        private void PolkiNaRegalach_FormClosed(object sender, FormClosedEventArgs e)
        {
            foreach (DataGridViewRow row in dgvPolkiNaRegale.Rows)
                row.Cells[6].Value = "      ";
            //to jest po to, żeby nie były wprowadzone w bazie żadne zmiany
            Start.GetForm.Show();
        }

    }
}
