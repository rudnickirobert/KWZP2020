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
        private SzwalniaEntities db;
        public ElementyZamowienia(SzwalniaEntities db)
        {
            InitializeComponent();
            this.db = db;
            uzupelnijcbElement();
            uzupelmnijcbIDZamowienia();
        }

        public ElementyZamowienia(SzwalniaEntities db, int id_zamowienia)
        {
            InitializeComponent();
            this.db = db;
            uzupelnijcbElement();
            uzupelmnijcbIDZamowienia(id_zamowienia);
        }
        private void uzupelmnijcbIDZamowienia(int id_zamowienia)
        {
            cbIDZamowienia.DataSource = db.Zamowienia.Where(z => z.ID_Zamowienia == id_zamowienia).ToList();
            cbIDZamowienia.ValueMember = "ID_Zamowienia";
            cbIDZamowienia.DisplayMember = "ID_Zamowienia";
        }
        private void uzupelmnijcbIDZamowienia()
        {
            cbIDZamowienia.DataSource = db.Zamowienia.ToList();
            cbIDZamowienia.ValueMember = "ID_Zamowienia";
            cbIDZamowienia.DisplayMember = "ID_Zamowienia";
        }
        private void uzupelnijcbElement()
        {
            cbElement.DataSource = db.vElementyDlaZamowien.ToList();
            cbElement.ValueMember = "ID_Element";
            cbElement.DisplayMember = "Element_Nazwa";
            cbElement.Refresh();
        }

        private void btnNowy_Click(object sender, EventArgs e)
        {
            ElementyForm elementyForm = new ElementyForm();
            elementyForm.Show();
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            Zamowienie_Element zamowienieElement = new Zamowienie_Element();
            zamowienieElement.ID_Element = Convert.ToInt32(cbElement.SelectedValue);
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
            zamowienieElement.ID_Element = Convert.ToInt32(cbElement.SelectedValue);
            zamowienieElement.ID_Zamowienia = Convert.ToInt32(cbIDZamowienia.SelectedValue);
            zamowienieElement.Ilosc = Convert.ToInt32(txtIlosc.Text);
            db.Zamowienie_Element.Add(zamowienieElement);
            db.SaveChanges();
            MessageBox.Show("Dodano element zamówienia");
            cbElement.Text = "";
            txtIlosc.Text = "";
        }

        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
