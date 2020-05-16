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
     public partial class DodawanieCechy : Form
    {
        public SzwalniaEntities db;
        public DodawanieCechy()
        {
            InitializeComponent();
            db = Start.szwalnia;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            Elementy_Cechy_Slownik cechaNew = new Elementy_Cechy_Slownik();
            cechaNew.Cecha = txtNazwa.Text;
            db.Elementy_Cechy_Slownik.Add(cechaNew);
        }

        private void DodawanieCechy_FormClosed(object sender, FormClosedEventArgs e)
        {
            Start.GetForm.Show();
        }
    }
}
