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

            Zamowienia zamowienia = db.Zamowienia.Where(wybrane => wybrane.ID_Zamowienia == ID).First();
            lblOpis.Text = "Zamówienie o ID: " + zamowienia.ID_Zamowienia;

            dgvSzczegoly.DataSource = db.vKlienciZamowienie.Where(elementy => elementy.ID_Zamowienia == zamowienia.ID_Zamowienia).ToList();
            dgvSzczegoly.Columns[0].Visible = false;
        }
    }
}
