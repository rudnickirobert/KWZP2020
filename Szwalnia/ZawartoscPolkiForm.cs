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
    public partial class ZawartoscPolkiForm : Form
    {
        public ZawartoscPolkiForm(SzwalniaEntities szwalnia_passed, int numer_polki)
        {
            InitializeComponent();
            //tutaj prace trwaja, stad komentarze
            //lblTitle.Text = numer_polki;
            //vZawartosc_polki content = szwalnia_passed.vZawartosc_polki.Where(regal => regal.ID_Polka == numer_polki).First();
            //txtID.Text = content.ID_Polka;  
        }
    }
}
