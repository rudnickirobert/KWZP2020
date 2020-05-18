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
        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnZapisz_Click(object sender, EventArgs e)
        {
            int id_zamowienia = (int)cbIDZamowienia.SelectedValue;
            Zamowienia zamowienia = db.Zamowienia.Where(x => x.ID_Zamowienia == id_zamowienia).First();
            zamowienia.Data_Zakonczenia = Convert.ToDateTime(dtpZakonczenie.Value);
            db.SaveChanges();
            MessageBox.Show("Zamówienie zostało zakończone");
            this.Close();
        }
    }
}
