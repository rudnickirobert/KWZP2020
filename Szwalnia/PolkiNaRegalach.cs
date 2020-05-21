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
        private int furtherForms;
        bool isFull(int i)
        {
            int idPolka = Convert.ToInt16(dgvPolkiNaRegale.Rows[i].Cells[1].Value);
            return db.Zawartosc.Where(content => content.ID_Polka == idPolka).Any();
        }
        public PolkiNaRegalach()
        {
            InitializeComponent();
            db = Start.szwalnia;
            dgvPolkiNaRegale.ReadOnly = true;
            furtherForms = 0;
            cmbOznaczenie.Sorted = true;
            cmbOznaczenie.DataSource = db.Regaly.ToList();
            cmbOznaczenie.DisplayMember = "Oznaczenie";
        }

    private void dgvPolkiNaRegale_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (isFull(dgvPolkiNaRegale.CurrentRow.Index))
            {
                ZawartoscPolki zawartosc = new ZawartoscPolki(Convert.ToInt32(dgvPolkiNaRegale.CurrentRow.Cells[1].Value));
                furtherForms++;
                zawartosc.Show();
            }
        }

        private void cmbOznaczenie_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvPolkiNaRegale.DataSource = db.vPolki_na_regalach.Where(regal => regal.Oznaczenie.Equals(cmbOznaczenie.Text)).ToList();
            dgvPolkiNaRegale.Columns[0].Visible = false;
            dgvPolkiNaRegale.Columns[1].HeaderText = "Nr półki";
            dgvPolkiNaRegale.Columns[2].HeaderText = "Wymiary półki";

            for (int i = 0; i < dgvPolkiNaRegale.RowCount; i++)
            {
                if (isFull(i))
                    dgvPolkiNaRegale.Rows[i].DefaultCellStyle.BackColor = Color.IndianRed;
                else
                    dgvPolkiNaRegale.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen;
            }
        }
        
        private void PolkiNaRegalach_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (furtherForms>0)
                for (int i = 0; i < furtherForms; i++) 
                    if (Application.OpenForms[typeof(ZawartoscPolki).Name]!= null)
                        Application.OpenForms[typeof(ZawartoscPolki).Name].Close();
            
            Start.GetForm.Show();
        }

    }
}
