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

namespace grupo01ProyectoFinal.Forms
{
    public partial class frmShowReporteDiputadosResultados : Form
    {
        public frmShowReporteDiputadosResultados()
        {
            InitializeComponent();
        }

        public string CodigoProvincia { get; set; }
        public string NombreProvincia { get; set; }
        public int CantidadDiputadosAsignar { get; set; }
        public DataTable DtSubcociente { get; set; }
        public DataTable DtCociente { get; set; }
        public DataTable DtCalculoResiduo { get; set; }
        public DataTable DtAsignacionResiduo { get; set; }
        public DataTable DtResultados { get; set; }

        private void frmShowReporteDiputadosResultados_Load(object sender, EventArgs e)
        {
            GenerarReporte();           
        }

        private void GenerarReporte()
        {
            try
            {
                DataTable dtDiputadosProvincia = new DataTable();
                dtDiputadosProvincia = ConsultarDiputadosProvincia(CodigoProvincia);

                reportViewer1.LocalReport.DataSources.Clear();

                reportViewer1.LocalReport.DataSources.Add(
                    new ReportDataSource("DS_DiputadosProvincia", dtDiputadosProvincia)
                );

                reportViewer1.LocalReport.DataSources.Add(
                    new ReportDataSource("DS_Subcociente", DtSubcociente)
                );

                reportViewer1.LocalReport.DataSources.Add(
                    new ReportDataSource("DS_Cociente", DtCociente)
                );

                reportViewer1.LocalReport.DataSources.Add(
                    new ReportDataSource("DS_CalculoResiduo", DtCalculoResiduo)
                );

                reportViewer1.LocalReport.DataSources.Add(
                    new ReportDataSource("DS_AsignacionResiduo", DtAsignacionResiduo)
                );

                reportViewer1.LocalReport.DataSources.Add(
                    new ReportDataSource("DS_Resultados", DtResultados)
                );

                reportViewer1.LocalReport.SetParameters(new ReportParameter[]
                {
                    new ReportParameter("NombreProvincia", NombreProvincia),
                    new ReportParameter("CantidadDiputadosAsignar", CantidadDiputadosAsignar.ToString())
                });

                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un problema a la hora de generar el reporte. [001][" + ex.Message + "]", "Problema con el reporte", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private DataTable ConsultarDiputadosProvincia(string codigoProvincia)
        {
            try
            {
                DataTable dtConsulta = new DataTable();
                ReporteProvincia reporte = new ReporteProvincia();
                reporte.CodProvincia = codigoProvincia;

                dtConsulta = reporte.ResultadosDiputados();

                return dtConsulta;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un problema al momento de consultar los resultados de los diputados. [002]["+ex.Message+"]", "Problema al consultar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return new DataTable();
        }
    }
}
