﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void BtnElegir_Click(object sender, EventArgs e)
        {
            openFileDialogImg.ShowDialog();
            Rut.Text = openFileDialogImg.FileName;
            BtnConv.Enabled = true;
        }

        private void BtnConv_Click(object sender, EventArgs e)
        {

        }

        private void BtnCompr_Click(object sender, EventArgs e)
        {

        }

        private void BtnEnviar_Click(object sender, EventArgs e)
        {

        }
    }
}
