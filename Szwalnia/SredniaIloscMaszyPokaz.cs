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
    public partial class SredniaIloscMaszyPokaz : Form
    {
        public SredniaIloscMaszyPokaz(SzwalniaEntities db)
        {
            InitializeComponent();
            dgvSredniaIloscMaszyn.DataSource = db.vSrednia_ilosc_maszyn.ToList();
        }
    }
}
