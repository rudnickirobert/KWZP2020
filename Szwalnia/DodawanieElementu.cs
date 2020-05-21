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
    public partial class DodawanieElementu : Form
    {
        public SzwalniaEntities db;
        public Elementy elementNew = new Elementy();
        public DodawanieElementu()
        {
            InitializeComponent();
            db = Start.szwalnia;
            dgvListaTypy.ReadOnly = true;
            dgvListaTypy.DataSource = db.Elementy_Typy.ToList();
            
        }

        private void dgvListaTypy_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int numID = Convert.ToInt32(dgvListaTypy.CurrentRow.Cells[0].Value);
            elementNew.ID_Element_Typ = numID;
            Elementy_Typy typNew = db.Elementy_Typy.Where(wybrany => wybrany.ID_Element_Typ == numID).First();
            txtTyp.Text = typNew.Typ;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            elementNew.Element_Nazwa = txtNazwa.Text;
            elementNew.Okres_Przydatnosci_Miesiace = Decimal.ToInt32(numOkres.Value);
            MessageBox.Show("Pomyślnie dodano nowy rekord do bazy danych.");
            db.Elementy.Add(elementNew);
            db.SaveChanges();
        }

        private void DodawanieElementu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Start.GetForm.Show();
        }

        private void btnWstecz_Click(object sender, EventArgs e)
        {
            Application.OpenForms[typeof(ElementyForm).Name].Show();
            this.Hide();
        }
    }
}
