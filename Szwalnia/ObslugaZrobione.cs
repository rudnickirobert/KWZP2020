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
    public partial class ObslugaZrobione : Form
    {
        public ObslugaZrobione(SzwalniaEntities db, String rodzajObslugi)
        {
            InitializeComponent();
            Obsluga_Techniczna obslga = db.Obsluga_Techniczna.Where(rodzaj => rodzaj.Rodzaj_Obslugi.Nazwa == rodzajObslugi).First();
            lblTitle.Text = obslga.Rodzaj_Obslugi.Nazwa;
            txtRodzaj.Text = obslga.Rodzaj_Obslugi.Nazwa;
            txtMaszyna.Text = obslga.Maszyny.Model;
            txtPracownik.Text = obslga.Pracownicy.Nazwisko;
            txtData.Text = obslga.Data_Wykonania.ToString();
            dgvObsluga.DataSource = db.vObsluga.Where(rodzaj => rodzaj.Nazwa == rodzajObslugi).ToList();
        }
    }
}
