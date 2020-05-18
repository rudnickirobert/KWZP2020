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
    public partial class SzczegolyZamowienia : Form
    {
        public SzwalniaEntities db;
        public SzczegolyZamowienia(SzwalniaEntities db, int ID)
        {
            InitializeComponent();
            this.db = db;

            dgvSzczegoly.DataSource = db.Zamowienie_Element.ToList();
            dgvSzczegoly.Columns[0].Visible = false;
        }
    }
}
