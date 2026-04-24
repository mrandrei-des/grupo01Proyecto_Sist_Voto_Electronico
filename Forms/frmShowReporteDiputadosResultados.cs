using grupo01ProyectoFinal.DataSet_Reportes;
using grupo01ProyectoFinal.DataSet_Reportes.DataSetReporteProvinciaTableAdapters;
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
                reportViewer1.LocalReport.DataSources.Clear();

                sp_Consulta_Resultados_Diputados_x_ProvinciaTableAdapter1.Fill(dataSetResultadosDiputados1.sp_Consulta_Resultados_Diputados_x_Provincia, CodigoProvincia);

                reportViewer1.LocalReport.DataSources.Clear();

                reportViewer1.LocalReport.DataSources.Add(
                    new ReportDataSource("DS_VotosRegistrados", (DataTable)dataSetResultadosDiputados1.sp_Consulta_Resultados_Diputados_x_Provincia)
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
                    new ReportParameter("NombreProvincia", NombreProvincia)
                });

                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un problema a la hora de generar el reporte. [001][" + ex.Message + "]", "Problema con el reporte", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
