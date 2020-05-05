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
    public partial class SumaCzasuPokaz : Form
    {
        public SumaCzasuPokaz(SzwalniaEntities db)
        {
            InitializeComponent();
            dgvSumaCzasu.DataSource = db.vSuma_czasu_proces.ToList();
        }
    }
}
