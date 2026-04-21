using grupo01ProyectoFinal.Clases;
using mylibreria2026;
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
    public partial class frmEstadisticaProvincia : Form
    {
        public string cedulaUsuario = string.Empty;
        public frmEstadisticaProvincia()
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
            rdoTipoVotacionPresidente.Checked = true;
            cmbProvincias.SelectedIndex = 0;
        }

        private void CargarCmbProvincias()
        {
            Provincia objProvincia = new Provincia();
            DataTable dtProvincias = objProvincia.Listar();
            if (dtProvincias.Rows.Count > 0)
            {
                cmbProvincias.DataSource = dtProvincias;
                cmbProvincias.DisplayMember = "Texto";
                cmbProvincias.ValueMember = "Valor";
            }
        }

        private void frmReporteProvincia_Load(object sender, EventArgs e)
        {
            CargarCmbProvincias();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            string codigoProvincia = cmbProvincias.SelectedValue.ToString();
            string nombreProvincia = cmbProvincias.Text.Trim();
            string tipoVotacion = "Diputado";

            if (rdoTipoVotacionPresidente.Checked)
            {
                tipoVotacion = "Presidente";
            }

            else { }

            ReporteProvincia objReporteProvincia = new ReporteProvincia();
            objReporteProvincia.CodProvincia = codigoProvincia;

            DataTable dtReporte = objReporteProvincia.ResultadosPresidente();

            if (dtReporte.Rows.Count > 0)
            {
                GenerarReporteProvincia(tipoVotacion, codigoProvincia, nombreProvincia);
            }
            else
            {
                MessageBox.Show("No se han emitido votos en el sistema.", "Generación Reporte", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void GenerarReporteProvincia(string tipoVotacion, string codigoProvincia, string nombreProvincia)
        {
            if(tipoVotacion == "Presidente")
            {
                frmShowEstadisticasPresidencialProvincia reportePresidente = new frmShowEstadisticasPresidencialProvincia();
                reportePresidente.CodigoProvincia = codigoProvincia;
                reportePresidente.NombreProvincia = nombreProvincia;
                reportePresidente.ShowDialog();
            }else
            {

            }
        }
    }
}
