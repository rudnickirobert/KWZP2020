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
        public Kontrahenci(SzwalniaEntities szwalnia)
        {
            InitializeComponent();
        }

        private void Kontrahenci_FormClosed(object sender, FormClosedEventArgs e)
        {
            Start start = new Start();
            start.Show();
        }
    }
}
