using grupo01ProyectoFinal.DataSet_Reportes;
using grupo01ProyectoFinal.DataSet_Reportes.DataSetReporteCandidatoTableAdapters;
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
    public partial class frmShowReportePresidenteFinal : Form
    {
        public frmShowReportePresidenteFinal()
        {
            InitializeComponent();
        }

        private void frmShowReportePresidenteFinal_Load(object sender, EventArgs e)
        {
            sp_ReporteResultados_Presidente_FinalesTableAdapter1.Fill(dataSetReportePresidenteFinales1.sp_ReporteResultados_Presidente_Finales);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(
                new ReportDataSource("DS_ResultadosFinales_Presidente", (DataTable)dataSetReportePresidenteFinales1.sp_ReporteResultados_Presidente_Finales)
            );

            //reportViewer1.LocalReport.SetParameters(new ReportParameter[]
            //{
            //        new ReportParameter("CodPartido", CodigoPartido),
            //        new ReportParameter("NombrePartido", nombrePartido),
            //        new ReportParameter("NombreCandidato", nombreCandidato)
            //});

            this.reportViewer1.RefreshReport();
        }
    }
}
