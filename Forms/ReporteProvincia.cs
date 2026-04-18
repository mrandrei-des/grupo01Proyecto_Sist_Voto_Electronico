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
    public partial class frmReporteProvincia : Form
    {
        public frmReporteProvincia()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            frmPrincipal formPrincipal = new frmPrincipal();
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

            if(rdoTipoVotacionPresidente.Checked)
            {
                tipoVotacion = "Presidente";
            }

            GenerarReporteProvincia(tipoVotacion, codigoProvincia, nombreProvincia);
        }

        private void GenerarReporteProvincia(string tipoVotacion, string codigoProvincia, string nombreProvincia)
        {
            //Consulta la base de datos para obtener el número de votantes por cada provincia
            //Hay que estudiar la posibilida de traer la cantidad de votos por cada partido político
            if(tipoVotacion == "Presidente")
            {
                frmShowReportePresidencialProvincia reportePresidente = new frmShowReportePresidencialProvincia();
                reportePresidente.CodigoProvincia = codigoProvincia;
                reportePresidente.NombreProvincia = nombreProvincia;
                reportePresidente.ShowDialog();
            }
        }
    }
}
