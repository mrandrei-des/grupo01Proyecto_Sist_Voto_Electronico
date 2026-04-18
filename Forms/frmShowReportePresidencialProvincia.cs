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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace grupo01ProyectoFinal.Forms
{
    public partial class frmShowReportePresidencialProvincia : Form
    {
        public frmShowReportePresidencialProvincia()
        {
            InitializeComponent();
        }

        public string CodigoProvincia { get; set; }
        public string NombreProvincia { get; set; }

        private void frmShowReportePresidencialProvincia_Load(object sender, EventArgs e)
        {
            sp_Reporte_Resultados_Presidente_x_ProvinciaTableAdapter1.Fill(dataSetReporteProvincia1.sp_Reporte_Resultados_Presidente_x_Provincia, CodigoProvincia);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(
                new ReportDataSource("DS_ReporteVotacionesProvincia", (DataTable)dataSetReporteProvincia1.sp_Reporte_Resultados_Presidente_x_Provincia)
            );

            reportViewer1.LocalReport.SetParameters(new ReportParameter[]
            {
                    new ReportParameter("ProvinciaSeleccionada", NombreProvincia)
            });
           
            this.reportViewer1.RefreshReport();
        }
    }
}
