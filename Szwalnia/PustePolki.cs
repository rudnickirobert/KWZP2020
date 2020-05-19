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
    public partial class PustePolki : Form
    {
        public SzwalniaEntities db;
        public PustePolki()
        {
            InitializeComponent();
            db = Start.szwalnia;
            dgvPustePolki.DataSource = db.vWolnePolki.ToList();
            lblPustePolki.Text = "Puste półki: " + db.vWolnePolki.Count();
        }
    }
}
