using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace grupo01ProyectoFinal.Forms
{
    public partial class frmReporteCandidato : Form
    {
        public string cedulaUsuario = string.Empty;
        private string partidoCandidatoSeleccionado;

        public frmReporteCandidato()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            frmPrincipal formPrincipal = new frmPrincipal();
            formPrincipal.cedulaUsuarioLoggeado = cedulaUsuario;
            formPrincipal.Show();
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            partidoCandidatoSeleccionado = "";
            rdoCandidatoPUSC.Checked = true;
        }

        private void frmReporteCandidato_Load(object sender, EventArgs e)
        {

        }

        private void rdoCandidatoPUSC_CheckedChanged(object sender, EventArgs e)
        {
            if(rdoCandidatoPUSC.Checked)
            {
                partidoCandidatoSeleccionado = "PUSC";
            }else
            {
                partidoCandidatoSeleccionado = "";
            }
        }

        private void rdoCandidatoPLN_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoCandidatoPLN.Checked)
            {
                partidoCandidatoSeleccionado = "PLN";
            }
            else
            {
                partidoCandidatoSeleccionado = "";
            }
        }

        private void rdoCandidatoPPSO_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoCandidatoPPSO.Checked)
            {
                partidoCandidatoSeleccionado = "PPSO";
            }
            else
            {
                partidoCandidatoSeleccionado = "";
            }
        }

        private void rdoCandidatoVotoBlanco_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoCandidatoVotoBlanco.Checked)
            {
                partidoCandidatoSeleccionado = "BLANCO";
            }
            else
            {
                partidoCandidatoSeleccionado = "";
            }
        }

        private void rdoCandidatoPNR_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoCandidatoPNR.Checked)
            {
                partidoCandidatoSeleccionado = "PNR";
            }
            else
            {
                partidoCandidatoSeleccionado = "";
            }
        }

        private void rdoCandidatoPFA_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoCandidatoPFA.Checked)
            {
                partidoCandidatoSeleccionado = "PFA";
            }
            else
            {
                partidoCandidatoSeleccionado = "";
            }
        }

        private void rdoCandidatoPLP_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoCandidatoPLP.Checked)
            {
                partidoCandidatoSeleccionado = "PLP";
            }
            else
            {
                partidoCandidatoSeleccionado = "";
            }
        }

        private void rdoCandidatoVotoNulo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoCandidatoVotoNulo.Checked)
            {
                partidoCandidatoSeleccionado = "NULO";
            }
            else
            {
                partidoCandidatoSeleccionado = "";
            }
        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(partidoCandidatoSeleccionado))
            {
                MessageBox.Show("No ha seleccionado un candidado.", "Generación de Reporte", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }

            frmShowReporteCandidato reportePresidente = new frmShowReporteCandidato();
            reportePresidente.CodigoPartido = partidoCandidatoSeleccionado;            
            reportePresidente.ShowDialog();
        }

        private void pbCandidatoPLN_Click(object sender, EventArgs e)
        {
            rdoCandidatoPLN.Checked = true;
        }

        private void pbCandidatoPUSC_Click(object sender, EventArgs e)
        {
            rdoCandidatoPUSC.Checked = true;
        }

        private void pbCandidatoPPSO_Click(object sender, EventArgs e)
        {
            rdoCandidatoPPSO.Checked = true;
        }

        private void pbCandidatoVotoBlanco_Click(object sender, EventArgs e)
        {
            rdoCandidatoVotoBlanco.Checked = true;
        }

        private void pbCandidatoVotoNulo_Click(object sender, EventArgs e)
        {
            rdoCandidatoVotoNulo.Checked = true;
        }

        private void pbCandidatoPLP_Click(object sender, EventArgs e)
        {
            rdoCandidatoPLP.Checked = true;
        }

        private void pbCandidatoPFA_Click(object sender, EventArgs e)
        {
            rdoCandidatoPFA.Checked = true;
        }

        private void pbCandidatoPNR_Click(object sender, EventArgs e)
        {
            rdoCandidatoPNR.Checked = true;
        }
    }
}
