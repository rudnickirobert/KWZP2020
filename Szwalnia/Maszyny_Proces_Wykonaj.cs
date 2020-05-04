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
    public partial class Maszyny_Proces_Wykonaj : Form
    {
        public Maszyny_Proces_Wykonaj(SzwalniaEntities db, String Maszyny_Proces_1)
        {
            InitializeComponent();
            Maszyny_Proces Proces = db.Maszyny_Proces.Where(Rodzaj1 => Rodzaj1.ID_Maszyny_Proces.ToString() == Maszyny_Proces_1).First();
            label8.Text = Proces.ID_Maszyny_Proces.ToString();
            txtRodzaj_Maszyny.Text = Proces.Rodzaj_Maszyny.ToString();
            txtLiczba.Text = Proces.Liczba.ToString();
            txtLiczba_rbh.Text = Proces.Liczba_Rbh.ToString();
            dgvRodzaj_Maszyny.DataSource = db.vMaszyny_rdz_lb.Where(Rodzaj1 => Rodzaj1.ID_Maszyny_Proces.ToString() == Maszyny_Proces_1).ToList();
        }

        private void Maszyny_Proces_Wykonaj_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
