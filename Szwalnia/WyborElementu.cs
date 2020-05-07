﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Szwalnia
{
    public partial class WyborElementu : Form
    {
        public SzwalniaEntities db;
        public Start start;
        public WyborElementu(SzwalniaEntities szwalnia, Start startowy)
        {
            InitializeComponent();
            db = szwalnia;
            start = startowy;
            dgvListaElementow.DataSource = db.Elementy.ToList();
        }

        private void dgvListaElementow_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int numID = Convert.ToInt32(dgvListaElementow.CurrentRow.Cells[0].Value);
            ElementSzczegoly szczegolyElement = new ElementSzczegoly(db, start, Decimal.ToInt32(numID));
            szczegolyElement.Show();
            this.Hide();
        }

        private void WyborElementu_FormClosed(object sender, FormClosedEventArgs e)
        {
            start.Show();
        }
    }
}
