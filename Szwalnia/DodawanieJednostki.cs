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
    public partial class DodawanieJednostki : Form
    {
        public SzwalniaEntities db;
        public Elementy_Jednostki jednostkaNew = new Elementy_Jednostki();
        public DodawanieJednostki()
        {
            InitializeComponent();
            db = Start.szwalnia;
            jednostkaNew.Jednostka = txtNazwa.Text;           
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            db.Elementy_Jednostki.Add(jednostkaNew);
        }

        private void DodawanieJednostki_FormClosed(object sender, FormClosedEventArgs e)
        {
            Start.GetForm.Show();
        }
    }
}
