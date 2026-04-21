using grupo01ProyectoFinal.Clases;
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
    public partial class frmReporteProvincia : Form
    {
        public string cedulaUsuario = string.Empty;
        public frmReporteProvincia()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            frmPrincipal formPrincipal = new frmPrincipal();
            formPrincipal.cedulaUsuarioLoggeado = cedulaUsuario;
            formPrincipal.Show();
            Close();
        }

        private void frmReporteProvincia_Load(object sender, EventArgs e)
        {
            CargarCmbProvincias();
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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            cmbProvincias.SelectedIndex = 0;
        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            string codigoProvincia = cmbProvincias.SelectedValue.ToString();
            string nombreProvincia = cmbProvincias.Text.Trim();

            //VALIDAR SI EXISTEN REGISTROS ANTES DE GENERAR EL REPORTE
            ReporteProvincia objReporteProvincia = new ReporteProvincia();
            objReporteProvincia.CodProvincia = codigoProvincia;

            DataTable dtReporte = objReporteProvincia.ResultadosPresidente();

            if (dtReporte.Rows.Count > 0)
            {
                GenerarReporte(codigoProvincia, nombreProvincia);
            }
            else
            {
                MessageBox.Show("No se han emitido votos en el sistema.", "Generación Reporte", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void GenerarReporte(string codProvincia, string nombreProvincia)
        {
            frmShowReportePresidenteProvincia reportePresidenteProvincia = new frmShowReportePresidenteProvincia();
            reportePresidenteProvincia.CodigoProvincia = codProvincia;
            reportePresidenteProvincia.NombreProvincia = nombreProvincia;
            reportePresidenteProvincia.ShowDialog();
        }
    }
}
