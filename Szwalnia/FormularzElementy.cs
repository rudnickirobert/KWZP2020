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
    public partial class FormularzElementy : Form
    {
        public SzwalniaEntities szwalniaPassed;
        public FormularzElementy()
        {
            InitializeComponent();
        }

        private void btnElementy_Click(object sender, EventArgs e)
        {
            DodawanieElementu dodawanieElement = new DodawanieElementu();
            dodawanieElement.Show();
            this.Close();
        }

        private void btnTypy_Click(object sender, EventArgs e)
        {
            DodawanieTypu dodawanieTypu = new DodawanieTypu();
            dodawanieTypu.Show();
            this.Close();
        }

        private void btnCechy_Click(object sender, EventArgs e)
        {
            DodawanieCechy dodawanieCechy = new DodawanieCechy();
            dodawanieCechy.Show();
            this.Close();
        }

        private void btnCechyElementow_Click(object sender, EventArgs e)
        {
            DodawanieCechElementu dodawanieCechElementu = new DodawanieCechElementu();
            dodawanieCechElementu.Show();
            this.Close();
        }

        private void btnJednostka_Click(object sender, EventArgs e)
        {
            DodawanieJednostki dodawanieJednostki = new DodawanieJednostki();
            dodawanieJednostki.Show();
            this.Close();
        }
    }
}
