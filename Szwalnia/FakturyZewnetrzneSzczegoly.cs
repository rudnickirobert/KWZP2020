using System;
using System.CodeDom.Compiler;
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
    public partial class FakturyZewnetrzneSzczegoly : Form
    {
        public FakturyZewnetrzneSzczegoly(SzwalniaEntities db, int ID)
        {
            InitializeComponent();
            //Nie moge naprawic bledu ** TEST **
            //FakturyZewnetrzne faktura = db.Faktury_Zewnetrzne.Where(wybrane => wybrane.ID_Faktura_zewnetrzna == ID).First();
            //txtNrFaktury.Text =       faktura.Nr_Faktury;
            //txtNazwaFirmy.Text =      faktura.Nazwa_Firmy;
            //txtKosztNetto.Text =      faktura.Netto;
           // txtKosztBrutto.Text =     faktura.Brutto;
           // textWartoscPodatku.Text = faktura.Podatek;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void lblNazwa_Click(object sender, EventArgs e)
        {

        }

        private void btnWrocKlienci_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }
    }
}
