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
    public partial class EwidencjaDostawWewnetrznych : Form
    {
        public SzwalniaEntities db;
        public EwidencjaDostawWewnetrznych()
        {
            InitializeComponent();
            db = Start.szwalnia;
            dgvEwidencjaProduktow.ReadOnly = true;
            dgvEwidencjaProduktow.DataSource = db.vEwidencja_dostaw_zewnetrznych.ToList();
            dgvEwidencjaProduktow.Columns[0].Visible = false;
        }

        private void EwidencjaDostawWewnetrznych_FormClosed(object sender, FormClosedEventArgs e)
        {
            Start.GetForm.Show();
        }
    }
}
