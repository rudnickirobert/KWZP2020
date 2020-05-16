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
    public partial class DodawanieDostaw : Form
    {
        public SzwalniaEntities db;
        public DodawanieDostaw(bool czyPuste)
        {
            InitializeComponent();
            db = Start.szwalnia;
            if (czyPuste) 
            {
                dgvListaMaterialow.Visible = false;
            }
            else
            {
                dgvListaMaterialow.Visible = true;
                dgvListaMaterialow.DataSource = db.vMaterialyDoZamowieniaBrak.ToList();
                dgvListaMaterialow.Columns[0].HeaderText = "Numer zamówienia";
                dgvListaMaterialow.Columns[1].HeaderText = "Numer produktu";
                dgvListaMaterialow.Columns[2].HeaderText = "Nazwa produktu";
                dgvListaMaterialow.Columns[3].HeaderText = "Brakująca ilość";
                dgvListaMaterialow.AutoResizeRows();
            }
        }

        private void DodawanieDostaw_FormClosed(object sender, FormClosedEventArgs e)
        {
            Start.GetForm.Show();
        }

    }
}
