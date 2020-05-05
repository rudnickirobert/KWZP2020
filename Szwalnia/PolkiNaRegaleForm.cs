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
    public partial class PolkiNaRegaleForm : Form
    {
        public SzwalniaEntities db;
        public PolkiNaRegaleForm(SzwalniaEntities szwalnia_passed, string oznaczenie)
        {
            InitializeComponent();
            vPolki_na_regalach storage = db.vPolki_na_regalach.Where(regal => regal.Oznaczenie == oznaczenie).First();

            lblTitle.Text = "REGAŁ " + storage.Oznaczenie;

            dgvRegaly.DataSource = db.vPolki_na_regalach.Where(regal => regal.Oznaczenie == storage.Oznaczenie).ToList();
        }
        private void dgvRegaly_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }    
}
