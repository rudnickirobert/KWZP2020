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
    public partial class NowyProces : Form
    {
        public SzwalniaEntities db;
        public int ostatniNumerProcesu;
        public NowyProces(SzwalniaEntities db)
        {
            InitializeComponent();
            this.db = db;
            dgvUkryty.DataSource = db.Proces_Produkcyjny.ToList();
            int numerOstatniegoProcesu = dgvUkryty.Rows.Count;
            lblNumerProcesu.Text = (numerOstatniegoProcesu+1).ToString();
        }

        private void btnWyzeruj_Click(object sender, EventArgs e)
        {
            tbDataRozpoczecia.Text = "";
            tbDataZakonczenia.Text = "";
            tbIdZamowienieElement.Text = "";
            tbProponowanaData.Text = "";
            tbUwagi.Text = "";
        }

        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
