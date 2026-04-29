using grupo01ProyectoFinal.Clases;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace grupo01ProyectoFinal.Forms
{
    public partial class frmShowEstadisticasPresidencialProvincia : Form
    {
        public frmShowEstadisticasPresidencialProvincia()
        {
            InitializeComponent();
        }

        public string CodigoProvincia { get; set; }
        public string NombreProvincia { get; set; }

        private void frmShowReportePresidencialProvincia_Load(object sender, EventArgs e)
        {
            DataTable dtPresidenteProvincia = new DataTable();
            dtPresidenteProvincia = ConsultarPresidenteProvincia(CodigoProvincia);

            reportViewer1.LocalReport.DataSources.Clear();

            reportViewer1.LocalReport.DataSources.Add(
                new ReportDataSource("DS_EstadisticasPresidenteProvincia", dtPresidenteProvincia)
            );

            reportViewer1.LocalReport.SetParameters(new ReportParameter[]
            {
                new ReportParameter("ProvinciaSeleccionada", NombreProvincia)
            });
           
            this.reportViewer1.RefreshReport();
        }

        private DataTable ConsultarPresidenteProvincia(string codigoProvincia)
        {
            try
            {
                DataTable dtConsulta = new DataTable();
                ReporteProvincia reporte = new ReporteProvincia();
                reporte.CodProvincia = codigoProvincia;

                dtConsulta = reporte.ResultadosPresidente();

                return dtConsulta;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un problema al momento de consultar los resultados de los diputados. [002][" + ex.Message + "]", "Problema al consultar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return new DataTable();
        }
    }
}
