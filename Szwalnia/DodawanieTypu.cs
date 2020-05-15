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
    public partial class DodawanieTypu : Form
    {
        public SzwalniaEntities db;
        public Elementy_Typy typNew = new Elementy_Typy();
        public DodawanieTypu()
        {
            InitializeComponent();
            db = Start.szwalnia;
            typNew.Typ = txtNazwa.Text;
            if (chBoxWlasny.Checked == true)
            { typNew.Czy_wlasne = true; }
            else { typNew.Czy_wlasne = false; }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            db.Elementy_Typy.Add(typNew);
        }

        private void DodawanieTypu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Start.GetForm.Show();
        }
    }
}
