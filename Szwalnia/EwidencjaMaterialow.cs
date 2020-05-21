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
    public partial class EwidencjaMaterialow : Form
    {
        public SzwalniaEntities db;
        public EwidencjaMaterialow()
        {
            InitializeComponent();
            db = Start.szwalnia;
            dgvEwidencjaMatarialow.ReadOnly = true;
            dgvEwidencjaMatarialow.DataSource = db.vEwidencja_dostaw_wewnetrznych.ToList();
            dgvEwidencjaMatarialow.Columns[0].Visible = false;
        }

        private void EwidencjaMaterialow_FormClosed(object sender, FormClosedEventArgs e)
        {
            Start.GetForm.Show();
        }
    }
}
