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
        public SzwalniaEntities szwalniaPassed;
        public MagazynForm(SzwalniaEntities szwalnia)
        {
            szwalniaPassed = szwalnia;
            InitializeComponent();
        }

        private void btnElementyForm_Click(object sender, EventArgs e)
        {
            WyborElementu wybor = new WyborElementu(szwalniaPassed);
            wybor.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UkladMagazynu uklad = new UkladMagazynu(szwalniaPassed);
            uklad.Show();
            this.Close();
        }
    }
}
