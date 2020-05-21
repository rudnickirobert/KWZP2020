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
    public partial class DodajOferte : Form
    {
        public SzwalniaEntities db;
        public Oferta ofertaNowa = new Oferta();
        private bool czyZainicjowane;
        public DodajOferte()
        {
            db = Start.szwalnia;
            InitializeComponent();
            //cmbElement.Sorted = true;
            cmbElement.DataSource = db.vElementy_Nie_Wlasne.ToList();
            cmbElement.ValueMember = "ID_Element";
            cmbElement.DisplayMember = "Element_Nazwa";
            cmbDostawca.DataSource = db.Dostawcy_Zaopatrzenie.ToList();
            cmbDostawca.ValueMember = "ID_Dostawcy";
            cmbDostawca.DisplayMember = "Nazwa";
            cmbJednostka.DataSource = db.Elementy_Jednostki.ToList();
            cmbJednostka.ValueMember = "ID_jednostka";
            cmbJednostka.DisplayMember = "Jednostka";
            lblIDElementu.Text = "ID: ";
            czyZainicjowane = true;
        }

        private void cmbElement_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (czyZainicjowane)
            {
                int numerElementu = Convert.ToInt32(cmbElement.SelectedValue);
                vElementy_Nie_Wlasne numer = db.vElementy_Nie_Wlasne.Where(element => element.ID_Element == numerElementu).FirstOrDefault();
                lblIDElementu.Text = "ID: " + numer.ID_Element.ToString();
            }
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            if (numIloscMax.Value < numIloscMin.Value || numIloscMax.Value < Convert.ToInt32(numIloscPoj.Value))
            {
                MessageBox.Show("Ilość maksymalna nie może być mniejsza niż ilość minimalna!");
            }
            else
            {
                ofertaNowa.ID_Element = Convert.ToInt32(cmbElement.SelectedValue);
                ofertaNowa.Element_Oznaczenie = txtOznacz.Text;
                ofertaNowa.ID_Dostawcy = Convert.ToInt32(cmbDostawca.SelectedValue);
                ofertaNowa.Cena_Jedn = numCenaJedn.Value;
                ofertaNowa.Data_Oferty = dtpDataOferty.Value;
                ofertaNowa.Ilosc_Minimalna = Decimal.ToInt32(numIloscMin.Value);
                ofertaNowa.Ilosc_Maksymalna = Decimal.ToInt32(numIloscMax.Value);
                ofertaNowa.Ilosc_W_Opakowaniu_Pojedynczym = Decimal.ToInt32(numIloscPoj.Value);
                ofertaNowa.ID_Jednostka = Convert.ToInt32(cmbJednostka.SelectedValue);
                ofertaNowa.Ilosc_W_Opakowaniu_Zbiorczym = Decimal.ToInt32(numIloscZbiorcza.Value);
                ofertaNowa.Deklarowany_czas_dostawy = Decimal.ToInt32(numCzasDostawy.Value);

                db.Oferta.Add(ofertaNowa);
                db.SaveChanges();
                Start.DataBaseRefresh();
                MessageBox.Show("Dodano nową ofertę.");
            }
        }

        private void DodajOferte_FormClosed(object sender, FormClosedEventArgs e)
        {
            Start.GetForm.Show();
        }

        private void btnWstecz_Click(object sender, EventArgs e)
        {
            Application.OpenForms[typeof(Oferty).Name].Show();
            this.Hide();
        }
    }
}
