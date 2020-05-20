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
    public partial class DodajNowyJezyk : Form
    {
        public SzwalniaEntities db;
        public DodajNowyJezyk(SzwalniaEntities db)
        {
            InitializeComponent();
            this.db = db;

            cbImieNazwisko.DataSource = db.vImieNazwiskoPracownika.ToList();
            cbImieNazwisko.ValueMember = "ID_Pracownika";
            cbImieNazwisko.DisplayMember = "Imie_i_nazwisko_pracownika";
            cbImieNazwisko.Invalidate();

            cbJezyk.DataSource = db.vJezyk.ToList();
            cbJezyk.ValueMember = "ID_Jezyk";
            cbJezyk.DisplayMember = "Jezyk";
            cbJezyk.Invalidate();
        }

        private void btnZamknij_Click(object sender, EventArgs e)
        {
            Znajomosc_Jezykow znajomoscJezykow = new Znajomosc_Jezykow();
            znajomoscJezykow.ID_Jezyka = Convert.ToInt32(cbJezyk.SelectedValue);
            znajomoscJezykow.ID_Pracownika = Convert.ToInt32(cbImieNazwisko.SelectedValue);
            db.Znajomosc_Jezykow.Add(znajomoscJezykow);
            db.SaveChanges();
            MessageBox.Show("Dodano znajomość języka pracownikowi");
            cbJezyk.Text = "";
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            Znajomosc_Jezykow znajomoscJezykow = new Znajomosc_Jezykow();
            znajomoscJezykow.ID_Jezyka = Convert.ToInt32(cbJezyk.SelectedValue);
            znajomoscJezykow.ID_Pracownika = Convert.ToInt32(cbImieNazwisko.SelectedValue);
            db.Znajomosc_Jezykow.Add(znajomoscJezykow);
            db.SaveChanges();
            MessageBox.Show("Dodano znajomość języka pracownikowi");
            this.Close();
        }
    }
}
