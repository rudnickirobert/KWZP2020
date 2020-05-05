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
    public partial class MaszynyProcesSzukaj : Form
    {
        private SzwalniaEntities Szwalnia;
        public MaszynyProcesSzukaj(SzwalniaEntities db)
        {
            InitializeComponent();
            Szwalnia = db;
        }
        private void btnSzukaj_Click(object sender, EventArgs e)
        {
            MaszynyProcesWykonaj maszynyProcesWykonaj = new MaszynyProcesWykonaj(Szwalnia, txtbSzukaj.Text);
            maszynyProcesWykonaj.Show();
        }
    }
}
