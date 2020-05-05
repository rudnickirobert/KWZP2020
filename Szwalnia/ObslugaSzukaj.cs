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
    public partial class ObslugaSzukaj : Form
    {
        private SzwalniaEntities db;
        public ObslugaSzukaj(SzwalniaEntities db)
        {
            InitializeComponent();
        }
        private void btnSzukaj_Click(object sender, EventArgs e)
        {
            ObslugaZrobione obslugaZrobione = new ObslugaZrobione(db, txtbSzukaj.Text);
            obslugaZrobione.Show();
        }
    }
}
