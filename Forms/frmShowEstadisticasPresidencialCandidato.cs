using grupo01ProyectoFinal.Clases;
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
    public partial class frmShowEstadisticasPresidencialCandidato : Form
    {
        public frmShowEstadisticasPresidencialCandidato()
        {
            InitializeComponent();
        }

        public string CodigoPartido { get; set; }

        private void frmShowEstadisticasPresidencialCandidato_Load(object sender, EventArgs e)
        {
            string nombrePartido = DevuelveNombrePartidoPolitico(CodigoPartido);
            string nombreCandidato = DevuelveNombreCandidatoPolitico(CodigoPartido);

            sp_Estadisticas_Resultados_Presidente_x_CandidatoTableAdapter1.Fill(dataSetReporteCandidato1.sp_Estadisticas_Resultados_Presidente_x_Candidato, CodigoPartido);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(
                new ReportDataSource("DS_EST_CANDIDATO", (DataTable)dataSetReporteCandidato1.sp_Estadisticas_Resultados_Presidente_x_Candidato)
            );

            reportViewer1.LocalReport.SetParameters(new ReportParameter[]
            {
                    new ReportParameter("NombrePartido", nombrePartido),
                    new ReportParameter("NombreCandidato", nombreCandidato)
            });


            this.reportViewer1.RefreshReport();
        }

        private string DevuelveNombrePartidoPolitico(string codPartido)
        {
            try
            {
                PartidoPolitico objPartido = new PartidoPolitico();
                objPartido.Codigo = codPartido;

                DataTable dtReporte = new DataTable();
                dtReporte = objPartido.Consultar();

                if (dtReporte.Rows.Count > 0)
                {
                    return dtReporte.Rows[0]["Nombre"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un problema al consultar la información para el reporte. [002][" + ex.Message + "]", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return "";
        }

        private string DevuelveNombreCandidatoPolitico(string codPartido)
        {
            try
            {
                Candidato objCandidato = new Candidato();
                objCandidato.CodPartido = codPartido;

                DataTable dtReporte = new DataTable();
                dtReporte = objCandidato.Consultar();

                if (dtReporte.Rows.Count > 0)
                {
                    string nombre, apellido1, apellido2;
                    nombre = dtReporte.Rows[0]["Nombre"].ToString();
                    apellido1 = dtReporte.Rows[0]["Apellido1"].ToString();
                    apellido2 = dtReporte.Rows[0]["Apellido2"].ToString();

                    return nombre + " " + apellido1 + " " + apellido2;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un problema al consultar la información para el reporte. [001][" + ex.Message + "]", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return "";
        }
    }
}
