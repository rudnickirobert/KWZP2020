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
    public partial class MaszynyProcesWykonaj : Form
    {
        public MaszynyProcesWykonaj(SzwalniaEntities db, String maszynyProces)
        {
            InitializeComponent();
            Maszyny_Proces proces = db.Maszyny_Proces.Where(rodzaj => rodzaj.ID_Maszyny_Proces.ToString() == maszynyProces).First();
            lblIdMaszynyProces.Text = proces.ID_Maszyny_Proces.ToString();
            txtRodzajMaszyny.Text = proces.Rodzaj_Maszyny.ToString();
            txtLiczba.Text = proces.Liczba.ToString();
            txtLiczbaRbh.Text = proces.Liczba_Rbh.ToString();
           
        }
    }
}
