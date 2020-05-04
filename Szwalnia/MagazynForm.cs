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
    public partial class MagazynForm : Form
    {
        public SzwalniaEntities db;
        public MagazynForm(SzwalniaEntities szwalnia)
        {
            db = szwalnia;
            InitializeComponent();
        }
        private void btnElementyForm_Click(object sender, EventArgs e)
        {
            Wybor_elementu wybor = new Wybor_elementu(db);
            wybor.Show();
            this.Close();
        }
        private void btnPolki_Click(object sender, EventArgs e)
        {
            RegalyPolkiForm regal = new RegalyPolkiForm(db);
            regal.Show();
            this.Close();
        }
    }
}
