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
    internal class Diputados_x_Provincia
    {
        private string codProvincia;
        private int cantidad;

        public Diputados_x_Provincia() { }

        public Diputados_x_Provincia(string codProvincia, int cantidad)
        {
            CodProvincia = codProvincia;
            Cantidad = cantidad;
        }

        public string CodProvincia { get => codProvincia; set => codProvincia = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }

        public int ConsultaCantidadDiputados_x_Provincia()
        {
            try
            {
                string cmd = string.Format("EXEC sp_Consulta_Diputados_x_Provincia '{0}'", this.CodProvincia);
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                int cantidad = 0;

                ds = Utilidades.Ejecutar(cmd);
                dt = ds.Tables[0];

                cantidad = Convert.ToInt32(dt.Rows[0]["Cantidad"].ToString());
                return cantidad;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se logró obtener la cantidad de diputados por provincia. [" + ex.Message + "]", "Consulta Diputados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return -1;
            }
        }
    }
}
