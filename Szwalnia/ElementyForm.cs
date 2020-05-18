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
    public partial class ElementyForm : Form
    {
        public SzwalniaEntities db;
        public ElementyForm()
        {
            InitializeComponent();
            db = Start.szwalnia;
        }

        private void btnWybor_Click(object sender, EventArgs e)
        {
            WyborElementu wybor = new WyborElementu();
            wybor.Show();
            this.Hide();
        }

        private void btnElement_Click(object sender, EventArgs e)
        {
            DodawanieElementu element = new DodawanieElementu();
            element.Show();
            this.Hide();
        }

        private void btnTyp_Click(object sender, EventArgs e)
        {
            DodawanieTypu typ = new DodawanieTypu();
            typ.Show();
            this.Hide();
        }

        private void btnCecha_Click(object sender, EventArgs e)
        {
            DodawanieCechy cecha = new DodawanieCechy();
            cecha.Show();
            this.Hide();
        }

        private void btnJednostka_Click(object sender, EventArgs e)
        {
            DodawanieJednostki jednostka = new DodawanieJednostki();
            jednostka.Show();
            this.Hide();
        }

        private void ElementyForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Start.GetForm.Show();
        }

        private void btnWstecz_Click(object sender, EventArgs e)
        {            
            Application.OpenForms[typeof(MagazynForm).Name].Show();
            this.Hide();
        }

        private void btnWyborTypu_Click(object sender, EventArgs e)
        {

        }

        private void btnWyborCechy_Click(object sender, EventArgs e)
        {

        }

        private void btnWyborJednostki_Click(object sender, EventArgs e)
        {

        }
    }
}
