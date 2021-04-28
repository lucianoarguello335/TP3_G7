using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TP3_G7.Metodos;

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
            LimpiarCampos();
            DesactivarCampos();
        }

        private void CmbMetodo_SelectedValueChanged(object sender, EventArgs e)
        {
            LimpiarCampos();
            DesactivarCampos();
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

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            CmbMetodo.SelectedIndex = -1;
            LimpiarCampos();
        }

        private void BtnGenerar_Click(object sender, EventArgs e)
        {
            try
            {
                switch (CmbMetodo.SelectedItem)
                {
                    case "Uniforme":
                        GenerarUniforme();
                        break;
                    //case "Exponencial Negativa":
                    //    GenerarExpNegativa();
                    //    break;
                    //case "Normal":
                    //    GenerarNormal();
                    //    break;
                    //case "Poisson":
                    //    GenerarPoisson();
                    //    break;
                }

            }
            catch (Exception)
            {

                throw new ApplicationException();
            }
   
        }

        private void GenerarUniforme()
        {
            var result = new Uniforme();
            long cotaInf = long.Parse(TxtCotaInf.Text);
            long cotaSup = long.Parse(TxtCotaSup.Text);
            result.AleatorioUniforme(cotaInf, cotaSup);
        }

        private void LimpiarCampos()
        {
            TxtCantNums.Text = "";
            RbInt5.Checked = false;
            RbInt10.Checked = false;
            RbInt15.Checked = false;
            RbInt20.Checked = false;
            TxtCotaInf.Text = "";
            TxtCotaSup.Text = "";
            TxtMedia.Text = "";
            TxtDesv.Text = "";
            TxtLambda.Text = "";
        }

        private void DesactivarCampos()
        {
            TxtCotaInf.Enabled = false;
            TxtCotaSup.Enabled = false;
            TxtMedia.Enabled = false;
            TxtDesv.Enabled = false;
            TxtLambda.Enabled = false;
        }
    }
}
