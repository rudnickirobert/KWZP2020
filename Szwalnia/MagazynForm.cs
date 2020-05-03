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
        public SzwalniaEntities szwalnia_passed;
        public MagazynForm(SzwalniaEntities szwalnia)
        {
            szwalnia_passed = szwalnia;
            InitializeComponent();
        }

        private void btnElementyForm_Click(object sender, EventArgs e)
        {
            Wybor_elementu wybor = new Wybor_elementu(szwalnia_passed);
            wybor.Show();
            this.Close();
        }

        private void btnPolki_Click(object sender, EventArgs e)
        {
            RegalyForm regal = new RegalyForm(szwalnia_passed);
            regal.Show();
            this.Close();
        }
    }
}
