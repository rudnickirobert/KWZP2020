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
    public partial class ElementyZamowienia : Form
    {
        public SzwalniaEntities db;
        public ElementyZamowienia(SzwalniaEntities db)
        {
            InitializeComponent();
            this.db = db;

            cbElement.DataSource = db.Elementy.ToList();
            cbElement.ValueMember = "ID_Element";
            cbElement.DisplayMember = "Element_Nazwa";
            cbElement.Invalidate();
        }

        private void btnNowy_Click(object sender, EventArgs e)
        {
            ElementyForm elementyForm = new ElementyForm();
            elementyForm.Show();
        }
    }
}
