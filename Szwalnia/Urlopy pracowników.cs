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
    public partial class UrlopyPracownikow : Form
    {
        public SzwalniaEntities db;
        public UrlopyPracownikow(SzwalniaEntities db)
        {
            InitializeComponent();

            dgvUrlopy.DataSource = db.vUrlopPracownika.ToList();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            NowyUrlop nowyUrlop = new NowyUrlop(db);
            nowyUrlop.Show();
        }

        private void btnZamknij_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
