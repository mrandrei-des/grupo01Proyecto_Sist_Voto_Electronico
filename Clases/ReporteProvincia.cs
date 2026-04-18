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
    internal class ReporteProvincia
    {
        private string codProvincia;

        public ReporteProvincia() { }

        public ReporteProvincia(string codProvincia)
        {
            CodProvincia = codProvincia;
        }

        public string CodProvincia { get => codProvincia; set => codProvincia = value; }

        public DataTable ResultadosPresidente()
        {
            try
            {
                DataSet ds = new DataSet();
                string cmd = string.Format("EXEC sp_Reporte_Resultados_Presidente_x_Provincia '{0}'", this.codProvincia);

                ds = Utilidades.Ejecutar(cmd);

                if (ds.Tables.Count > 0)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        return ds.Tables[0];
                    }
                }

                return new DataTable();
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un problema a la hora de extraer información para el reporte. Por favor revisar.", "Problema al consultar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return new DataTable();
        }
    }
}
