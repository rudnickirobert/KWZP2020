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
        public DodajOferte(SzwalniaEntities szwalnia)
        {
            db = szwalnia;
            InitializeComponent();
            ofertaNowa.ID_Element = cmbElement.SelectedIndex;
            ofertaNowa.Element_Oznaczenie = txtOznacz.Text;
            ofertaNowa.ID_Dostawcy = cmbDostawca.SelectedIndex;
            ofertaNowa.Cena_Jedn = numCenaJedn.Value;
            ofertaNowa.Data_Oferty = dtpDataOferty.Value;
            ofertaNowa.Ilosc_Minimalna = Decimal.ToInt32(numIloscMin.Value);
            ofertaNowa.Ilosc_Maksymalna = Decimal.ToInt32(numIloscMax.Value);
            ofertaNowa.Ilosc_W_Opakowaniu_Pojedynczym = Decimal.ToInt32(numIloscPoj.Value);
            ofertaNowa.ID_Jednostka = cmbJednostka.SelectedIndex;
            ofertaNowa.Ilosc_W_Opakowaniu_Zbiorczym = Decimal.ToInt32(numIloscZbiorcza.Value);
            ofertaNowa.Deklarowany_czas_dostawy = Decimal.ToInt32(numCzasDostawy.Value);
            //fixed

        }
           
        private void btnZapisz_Click(object sender, EventArgs e)
        {
            if (numIloscMax.Value < numIloscMin.Value)
            {
                MessageBox.Show("Ilość maksymalna nie może być mniejsza niż ilość minimalna!");
            }
            else
            {
                db.Oferta.Add(ofertaNowa);
                db.SaveChanges();
                MessageBox.Show("Dodano nową ofertę.");
                
            }
            
            
        }

        private void DodajOferte_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'szwalniaDataSet5.Elementy' . Możesz go przenieść lub usunąć.
            this.elementyTableAdapter1.Fill(this.szwalniaDataSet5.Elementy);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'jednostki.Elementy_Jednostki' . Możesz go przenieść lub usunąć.
            this.elementy_JednostkiTableAdapter.Fill(this.jednostki.Elementy_Jednostki);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'szwalniaDataSet4.Dostawcy_Zaopatrzenie' . Możesz go przenieść lub usunąć.
            this.dostawcy_ZaopatrzenieTableAdapter.Fill(this.szwalniaDataSet4.Dostawcy_Zaopatrzenie);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'szwalniaDataSet3.Elementy' . Możesz go przenieść lub usunąć.
            this.elementyTableAdapter.Fill(this.szwalniaDataSet3.Elementy);

        }

        private void DodajOferte_FormClosed(object sender, FormClosedEventArgs e)
        {
            Start.GetForm.Show();
        }
        
    }
}
