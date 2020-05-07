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
    public partial class RaportyProdukcja : Form
    {
        public SzwalniaEntities db;
        public RaportyProdukcja(SzwalniaEntities db)
        {
            InitializeComponent();
            this.db = db;
        }

        private void btnNiewykorzystanyMaterial_Click(object sender, EventArgs e)
        {
            NiewykorzystanyMaterialWMiesiacu niewykorzystanyMaterialWMiesiacu = new NiewykorzystanyMaterialWMiesiacu(db);
            niewykorzystanyMaterialWMiesiacu.Show();
        }

        private void btnOdpadyProces_Click(object sender, EventArgs e)
        {
            NajwiekszyOdpad najwiekszyOdpad = new NajwiekszyOdpad(db);
            najwiekszyOdpad.Show();
        }
    }
}
