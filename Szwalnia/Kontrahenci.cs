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
    }
}
