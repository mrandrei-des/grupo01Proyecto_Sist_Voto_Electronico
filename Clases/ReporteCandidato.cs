using mylibreria2026;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace grupo01ProyectoFinal.Clases
{
    internal class ReporteCandidato
    {
        private string codigoCandidato;

        public ReporteCandidato()
        {
        }
        public ReporteCandidato(string codigoCandidato)
        {
            CodigoCandidato = codigoCandidato;
        }

        public string CodigoCandidato { get => codigoCandidato; set => codigoCandidato = value; }

        public DataTable DevuelveResultadosFinales_Presidente()
        {
            try
            {
                DataSet ds = new DataSet();
                string cmd = string.Format("EXEC sp_ReporteResultados_Presidente_Finales");

                ds = Utilidades.Ejecutar(cmd);

                if (ds.Tables.Count > 0)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        return ds.Tables[0];
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un problema a la hora de extraer información para el informe. Por favor revisar. [001][" + ex.Message + "]", "Problema al consultar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return new DataTable();
        }
    }
}
