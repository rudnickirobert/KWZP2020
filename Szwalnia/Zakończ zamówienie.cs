using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Szwalnia
{
    public partial class ZakonczZamowienie : Form
    {
        public SzwalniaEntities db;

        public ZakonczZamowienie(SzwalniaEntities db)
        {
            InitializeComponent();
            this.db = db;

            cbIDZamowienia.ValueMember = "ID_Zamowienia";
            cbIDZamowienia.DisplayMember = "ID_Zamowienia";
            cbIDZamowienia.DataSource = db.Zamowienia.Distinct().ToList();
            cbIDZamowienia.Invalidate();
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            Zamowienia zamowienia = new Zamowienia();
            zamowienia.Data_Zakonczenia = Convert.ToDateTime(dtpZakonczenie.Value);
           zamowienia.ID_Zamowienia = Convert.ToInt32(cbIDZamowienia.SelectedValue);
            //db.Zamowienia.Add(zamowienia);
           // db.SubmitChanges();
            MessageBox.Show("Zamówienie zostało zakończone");
            this.Close();
        }

        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
