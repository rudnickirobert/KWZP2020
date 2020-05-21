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
    public partial class WyborTypu : Form
    {
        public SzwalniaEntities db;
        public int ID;
        public WyborTypu()
        {
            InitializeComponent();
            db = Start.szwalnia;
            dgvListaTypow.DataSource = db.Elementy_Typy.ToList();
            dgvListaTypow.Columns[3].Visible = false;
            dgvListaTypow.Columns[4].Visible = false;
            dgvListaTypow.ReadOnly = true;
        }

        private void dgvListaTypow_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int numID = Convert.ToInt32(dgvListaTypow.CurrentRow.Cells[0].Value);
            ID = numID;
            Elementy_Typy typ = db.Elementy_Typy.Where(wybrany => wybrany.ID_Element_Typ == ID).First();
            txtNazwa.Text =typ.Typ;
            if(typ.Czy_wlasne==true)
            { 
                txtWlasny.Text = "TAK";
            }
            else 
            { 
                txtWlasny.Text = "NIE";                
            }
        }

        private void btnWstecz_Click(object sender, EventArgs e)
        {
            Application.OpenForms[typeof(ElementyForm).Name].Show();
            this.Hide();
        }

        private void btnDodawanie_Click(object sender, EventArgs e)
        {
            DodawanieTypu typ = new DodawanieTypu();
            typ.Show();
            this.Hide();
        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            Elementy_Typy typUsun = db.Elementy_Typy.Where(wybrany => wybrany.ID_Element_Typ == ID).First();
            db.Elementy_Typy.Remove(typUsun);
            db.SaveChanges();
            dgvListaTypow.Refresh();
            MessageBox.Show("Pomyślnie usunięto element");            
        }

    }
}
