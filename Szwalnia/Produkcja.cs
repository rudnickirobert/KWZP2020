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
    public partial class Produkcja : Form
    {
        public SzwalniaEntities db;
        public Produkcja(SzwalniaEntities db)
        {
            InitializeComponent();
            this.db = db;
        }

        private void btnRaporty_Click(object sender, EventArgs e)
        {
            RaportyProdukcja formularzRaportyProdukcja = new RaportyProdukcja(db);
            formularzRaportyProdukcja.Show();
            this.Close();
        }

        private void btnProcesProdukcyjny_Click(object sender, EventArgs e)
        {
            ProcesProdukcyjny formularzProcesProdukcyjny = new ProcesProdukcyjny(db);
            formularzProcesProdukcyjny.Show();
            this.Close();
        }

        private void btnInne_Click(object sender, EventArgs e)
        {
            InneProdukcja formularzInneProdukcja = new InneProdukcja(db);
            formularzInneProdukcja.Show();
            this.Close();
        }

        private void btnWstecz_Click(object sender, EventArgs e)
        {
            Start.GetForm.Show();

        }

    }
}
