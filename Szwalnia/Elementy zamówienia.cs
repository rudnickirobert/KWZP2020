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


            cbIDZamowienia.DataSource = db.Zamowienia.ToList();
            cbIDZamowienia.ValueMember = "ID_Zamowienia";
            cbIDZamowienia.DisplayMember = "ID_Zamowienia";
            cbIDZamowienia.Invalidate();

        }

        private void btnNowy_Click(object sender, EventArgs e)
        {
            ElementyForm elementyForm = new ElementyForm();
            elementyForm.Show();
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            Zamowienie_Element zamowienieElement = new Zamowienie_Element();
            zamowienieElement.ID_Zamowienie_Element = Convert.ToInt32(cbElement.SelectedValue);
            zamowienieElement.ID_Zamowienia = Convert.ToInt32(cbIDZamowienia.SelectedValue);
            zamowienieElement.Ilosc = Convert.ToInt32(txtIlosc.Text);
            db.Zamowienie_Element.Add(zamowienieElement);
            db.SaveChanges();
            MessageBox.Show("Dodano element zamówienia");
            this.Close();
        }

        private void btnNastepny_Click(object sender, EventArgs e)
        {
            Zamowienie_Element zamowienieElement = new Zamowienie_Element();
            zamowienieElement.ID_Zamowienie_Element = Convert.ToInt32(cbElement.SelectedValue);
            zamowienieElement.ID_Zamowienia = Convert.ToInt32(cbIDZamowienia.SelectedValue);
            zamowienieElement.Ilosc = Convert.ToInt32(txtIlosc.Text);
            db.Zamowienie_Element.Add(zamowienieElement);
            db.SaveChanges();
            MessageBox.Show("Dodano element zamówienia");
            cbElement.Text = "";
            txtIlosc.Text = "";
        }
    }
}
