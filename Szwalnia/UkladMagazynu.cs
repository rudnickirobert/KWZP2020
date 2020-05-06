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
    public partial class UkladMagazynu : Form
    {
        public SzwalniaEntities szwalnia;
        public UkladMagazynu(SzwalniaEntities db)
        {
            InitializeComponent();
            szwalnia = db;
            int a = db.Polki.Count();
        }

        private void btnZnajdzPolke_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDodajRegal_Click(object sender, EventArgs e)
        {

        }

        private void btnDodajPolke_Click(object sender, EventArgs e)
        {

        }

        private void btnDodajRozmiar_Click(object sender, EventArgs e)
        {

        }

        
    }
}
