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
    public partial class Wybor_klienta : Form
    {
        public SzwalniaEntities db;

        public Wybor_klienta(SzwalniaEntities szwalnia)
        {
            InitializeComponent();
            db = szwalnia;
        }

        private void btnSzukaj_MouseClick(object sender, MouseEventArgs e)
        {
            Klienci_szczegoly klienci_Szczegoly = new Klienci_szczegoly(db, txtNazwaFirmy.Text);
            klienci_Szczegoly.Show();
        }
    }
}
