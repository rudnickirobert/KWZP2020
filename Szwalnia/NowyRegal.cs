﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Szwalnia
{
    public partial class NowyRegal : Form
    {
        SzwalniaEntities db;
        public NowyRegal()
        {
            InitializeComponent();
            db = Start.szwalnia;
            btnDodajRegal.Enabled = false;
        }
        private bool isUnique()
        {
            return db.Regaly.Where(regal => regal.Oznaczenie.Equals(txtOznaczenie.Text)).Count() == 0;
        }

        private void txtOznaczenie_TextChanged(object sender, EventArgs e)
        {
            if (txtOznaczenie.TextLength == 2)
                btnDodajRegal.Enabled = true;
            else btnDodajRegal.Enabled = false;
        }

        private void btnDodajRegal_Click(object sender, EventArgs e)
        {
            txtOznaczenie.Text = txtOznaczenie.Text.ToUpper();
            string nowy = txtOznaczenie.Text;
           
            Regaly regalNew = new Regaly();

            if (isUnique())
            {
                regalNew.Oznaczenie = txtOznaczenie.Text;
                db.Regaly.Add(regalNew);
                db.SaveChanges();
                MessageBox.Show("Pomyślnie dodano do bazy regał " + txtOznaczenie.Text);
                this.Close();
            }
            else
                MessageBox.Show("Regał " + nowy + " już istnieje!");
                regalNew = null;    
        }

        private void NowyRegal_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms[typeof(NowaPolka).Name] == null)
                Start.GetForm.Show();
            else if (!NowaPolka.isClosedByAnotherForm)
                Start.GetForm.Show();
            else
            {
                Application.OpenForms[typeof(NowaPolka).Name].Close();
                NowaPolka nowaPolka = new NowaPolka();
                nowaPolka.Show();
            }
        }
    }
}
