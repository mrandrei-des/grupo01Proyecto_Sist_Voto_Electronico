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
    internal class DistritoElectoral
    {
        private string codigoElectoral;
        private string codigoProvincia;
        private string codigoCanton;
        private string codigoDistrito;

        public DistritoElectoral(string codigoElectoral, string codigoProvincia, string codigoCanton, string codigoDistrito)
        {
            CodigoElectoral = codigoElectoral;
            CodigoProvincia = codigoProvincia;
            CodigoCanton = codigoCanton;
            CodigoDistrito = codigoDistrito;
        }

        public DistritoElectoral() { }

        public string CodigoElectoral { get => codigoElectoral; set => codigoElectoral = value; }
        public string CodigoProvincia { get => codigoProvincia; set => codigoProvincia = value; }
        public string CodigoCanton { get => codigoCanton; set => codigoCanton = value; }
        public string CodigoDistrito { get => codigoDistrito; set => codigoDistrito = value; }

        public DataTable Consultar_x_CodigoElectoral()
        {
            try
            {
                DataSet ds = new DataSet();
                string cmd = string.Format("EXEC sp_Consultar_DistritoElectoral_x_Codigo '{0}'", this.CodigoElectoral);

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
                MessageBox.Show("Ha ocurrido un error al consultar en el Distrito Electoral. [001]["+ex.Message+"]", "Problema al consultar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return new DataTable();
        }

        public DataTable Consultar_x_Provincia()
        {
            try
            {
                DataSet ds = new DataSet();
                string cmd = string.Format("EXEC sp_Consultar_DistritoElectoral_x_Provincia '{0}'", this.CodigoProvincia);

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
                MessageBox.Show("Ha ocurrido un error al consultar en el Distrito Electoral. [002][" + ex.Message + "]", "Problema al consultar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return new DataTable();
        }

        public DataTable Consultar_x_Canton()
        {
            try
            {
                DataSet ds = new DataSet();
                string cmd = string.Format("EXEC sp_Consultar_DistritoElectoral_x_Canton '{0}', '{1}'", this.CodigoProvincia, this.CodigoCanton);

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
                MessageBox.Show("Ha ocurrido un error al consultar en el Distrito Electoral. [003][" + ex.Message + "]", "Problema al consultar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return new DataTable();
        }
    }
}
