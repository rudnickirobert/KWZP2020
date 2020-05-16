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
            Obsluga_Techniczna obsluga = db.Obsluga_Techniczna.Where(rodzaj => rodzaj.Rodzaj_Obslugi.Nazwa == rodzajObslugi).First();
            lblTitle.Text = obsluga.Rodzaj_Obslugi.Nazwa;
            txtRodzaj.Text = obsluga.Rodzaj_Obslugi.Nazwa;
            txtMaszyna.Text = obsluga.Maszyny.Srodki_Trwale.Producent;
            txtPracownik.Text = obsluga.Pracownicy.Nazwisko;
            //txtData.Text = obsluga.Data_Wykonania.ToString();
           // dgvObsluga.DataSource = db.vObsluga.Where(rodzaj => rodzaj.Expr1 == rodzajObslugi).ToList();
        }
    }
}
