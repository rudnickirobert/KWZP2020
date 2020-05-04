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
    public partial class Obsluga_szukaj : Form
    {
        private SzwalniaEntities db;
        public Obsluga_szukaj()
        {
            InitializeComponent();
            db = new SzwalniaEntities();
        }


        private void Obsluga_szukaj_Load(object sender, EventArgs e)
        {

        }

        private void btnwlwyl_Click_1(object sender, EventArgs e)
        {
            Obsluga_done obsluga_done = new Obsluga_done(db, txtboxlabki.Text);
            obsluga_done.Show();
        }
    }
}
