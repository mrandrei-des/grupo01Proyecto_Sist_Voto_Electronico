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
    public partial class frmShowReportePresidenteFinal : Form
    {
        public frmShowReportePresidenteFinal()
        {
            InitializeComponent();
        }

        private void frmShowReportePresidenteFinal_Load(object sender, EventArgs e)
        {            
            DataTable dtConsulta = new DataTable();
            dtConsulta = ConsultaInfoResultadosFinales_Presidente();

            reportViewer1.LocalReport.DataSources.Clear();

            reportViewer1.LocalReport.DataSources.Add(
                new ReportDataSource("DS_Resultados_Finales_Presidente", dtConsulta)
            );

            this.reportViewer1.RefreshReport();
        }

        private DataTable ConsultaInfoResultadosFinales_Presidente() 
        {
            try
            {
                DataTable dtConsulta = new DataTable();
                ReporteCandidato reporte = new ReporteCandidato();
                dtConsulta = reporte.DevuelveResultadosFinales_Presidente();
                return dtConsulta;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un problema al consultar la información para el reporte. [001][" + ex.Message + "]", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return new DataTable();
        }

    }
}
