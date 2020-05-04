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
    public partial class Maszyny_Proces_Szukaj : Form
    {
        private SzwalniaEntities db;
        public Maszyny_Proces_Szukaj()
        {
            InitializeComponent();
            db = new SzwalniaEntities();
        }

        private void Maszyny_Proces_Szukaj_Load(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            Maszyny_Proces_Wykonaj maszyny_Proces_Wykonaj = new Maszyny_Proces_Wykonaj(db, txtbox.Text);
            maszyny_Proces_Wykonaj.Show();
        }
    }
}
