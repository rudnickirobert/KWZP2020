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
    public partial class Srednia_Il_Maszyn_Pokaz : Form
    {
        private SzwalniaEntities db;
        public Srednia_Il_Maszyn_Pokaz()
        {
            InitializeComponent();
            db = new SzwalniaEntities();
            dgv_Srednia_Il.DataSource = db.vSrednia_Il_Maszyn.ToList();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Srednia_Il_Maszyn_Pokaz_Load(object sender, EventArgs e)
        {

        }

        private void dgv_Srednia_Il_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
