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
    public partial class Przygotowanie_Produkcji : Form
    {
        public Przygotowanie_Produkcji()
        {
            InitializeComponent();
        }

        private void Przygotowanie_Produkcji_Load(object sender, EventArgs e)
        {

        }

        private void btn_MaszynyProces_Szukaj_Click_1(object sender, EventArgs e)
        {
            Maszyny_Proces_Szukaj maszyny_Proces_Szukaj = new Maszyny_Proces_Szukaj();
            maszyny_Proces_Szukaj.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Suma_Czasu_Pokaz suma_Czasu_Pokaz = new Suma_Czasu_Pokaz();
            suma_Czasu_Pokaz.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Srednia_Il_Maszyn_Pokaz srednia_Il_Maszyn_Pokaz = new Srednia_Il_Maszyn_Pokaz();
            srednia_Il_Maszyn_Pokaz.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Maszyny_Serwis maszyny_Serwis = new Maszyny_Serwis();
            maszyny_Serwis.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Obsluga_szukaj obsluga_Szukaj = new Obsluga_szukaj();
            obsluga_Szukaj.Show();
        }
    }
}
