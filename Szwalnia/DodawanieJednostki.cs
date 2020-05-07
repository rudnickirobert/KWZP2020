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
        public SzwalniaEntities szwalniaPassed;
        public Elementy_Jednostki jednostkaNew = new Elementy_Jednostki();
        public DodawanieJednostki()
        {
            InitializeComponent();
            jednostkaNew.Jednostka = txtNazwa.Text;           
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            szwalniaPassed.Elementy_Jednostki.Add(jednostkaNew);
            //szwalniaPassed.SaveChanges();
        }

        private void DodawanieJednostki_FormClosed(object sender, FormClosedEventArgs e)
        {
            Start start = new Start();
            start.Show();
        }
    }
}
