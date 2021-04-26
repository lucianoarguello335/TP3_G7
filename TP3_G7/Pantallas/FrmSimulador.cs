﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TP3_G7.Pantallas
{
    public partial class FrmSimulador : Form
    {
        public FrmSimulador()
        {
            InitializeComponent();
        }

        private void FrmSimulador_Load(object sender, EventArgs e)
        {

        }

        private void CmbMetodo_SelectedValueChanged(object sender, EventArgs e)
        {
            TxtCotaInf.Enabled = false;
            TxtCotaSup.Enabled = false;
            TxtMedia.Enabled = false;
            TxtDesv.Enabled = false;
            TxtLambda.Enabled = false;
            switch (CmbMetodo.SelectedItem)
            {
                case "Uniforme":
                    TxtCotaInf.Enabled = true;
                    TxtCotaSup.Enabled = true;
                    break;
                case "Exponencial Negativa":
                    TxtMedia.Enabled = true;
                    TxtLambda.Enabled = true;
                    break;
                case "Normal":
                    TxtMedia.Enabled = true;
                    TxtDesv.Enabled = true;
                    break;
                case "Poisson":
                    TxtLambda.Enabled = true;
                    break;
            }
        }
    }
}