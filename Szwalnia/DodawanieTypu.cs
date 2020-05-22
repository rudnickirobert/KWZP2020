﻿using System;
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
    public partial class DodawanieTypu : Form
    {
        public SzwalniaEntities db;
        public Elementy_Typy typNew = new Elementy_Typy();
        public bool czyZamowienie;
        public bool zamykanie;
        public DodawanieTypu()
        {
            InitializeComponent();
            db = Start.szwalnia;
            typNew.Typ = txtNazwa.Text;
            zamykanie = true;
            if (chBoxWlasny.Checked == true)
                typNew.Czy_wlasne = true;
            else
                typNew.Czy_wlasne = false;
            
        }
        public DodawanieTypu(bool czyZamowienie)
        {
            InitializeComponent();
            db = Start.szwalnia;
            typNew.Typ = txtNazwa.Text;
            zamykanie = false;
            if (chBoxWlasny.Checked == true)
                typNew.Czy_wlasne = true;
            else 
                typNew.Czy_wlasne = false;  
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            List<Elementy_Typy> powtorzenie = db.Elementy_Typy.Where(nazwa => nazwa.Typ == txtNazwa.Text).ToList();
            bool blad = powtorzenie.Any();            

            if (blad)
            { MessageBox.Show("Już istnieje taki typ"); }
            else
            {
                typNew.Typ = txtNazwa.Text;
                typNew.Czy_wlasne = chBoxWlasny.Checked;
                MessageBox.Show("Pomyślnie dodano nowy rekord do bazy danych.");
                db.Elementy_Typy.Add(typNew);
                db.SaveChanges();
                Start.DataBaseRefresh();
            }
        }

        private void DodawanieTypu_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (zamykanie)
                Start.GetForm.Show();
            else 
                this.Hide();
        }

        private void btnWstecz_Click(object sender, EventArgs e)
        {
            if (zamykanie)
            {
                Application.OpenForms[typeof(ElementyForm).Name].Show();
                this.Hide();
            }
            else 
                this.Hide();
        }

        private void txtNazwa_TextChanged(object sender, EventArgs e)
        {
            if (txtNazwa.TextLength > 0)
                btnDodaj.Enabled = true;
            else
                btnDodaj.Enabled = false;
        }
    }
}
