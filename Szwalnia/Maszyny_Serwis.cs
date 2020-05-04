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
    public partial class Maszyny_Serwis : Form
    {
        private SzwalniaEntities db;
        public Maszyny_Serwis()
        {
            InitializeComponent();
            db = new SzwalniaEntities();
            dgvMaszynySerwis.DataSource = db.vMaszyny_Serwis.ToList();
        }

        private void Maszyny_Serwis_Load(object sender, EventArgs e)
        {

        }
    }
}
