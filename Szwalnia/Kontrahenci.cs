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
    public partial class Kontrahenci : Form

    {
        public SzwalniaEntities db;
        public Kontrahenci()
        {
            InitializeComponent();
            db = Start.szwalnia;
        }

        private void Kontrahenci_FormClosed(object sender, FormClosedEventArgs e)
        {
            Start.GetForm.Show();
        }

        private void btnOferty_Click(object sender, EventArgs e)
        {
            Oferty oferta = new Oferty();
            oferta.Show();
            this.Hide();
        }

        private void btnDostawcy_Click(object sender, EventArgs e)
        {
            Dostawcy dostawca = new Dostawcy();
            dostawca.Show();
            this.Hide();
        }

        private void btnUmowyKur_Click(object sender, EventArgs e)
        {
            UmowyKurierzy umowa = new UmowyKurierzy();
            umowa.Show();
            this.Hide();
        }

        private void btnKurierzy_Click(object sender, EventArgs e)
        {
            KurierzyLista kurier = new KurierzyLista();
            kurier.Show();
            this.Hide();
        }
    }
}
