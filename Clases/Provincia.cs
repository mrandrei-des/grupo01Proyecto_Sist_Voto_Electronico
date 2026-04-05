using mylibreria2026;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grupo01ProyectoFinal.Clases
{
    internal class Provincia
    {
        private string codProvincia;
        private string descripcion;

        public string CodProvincia { get => codProvincia; set => codProvincia = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }

        public Provincia(string codProvincia, string descripcion)
        {
            CodProvincia = codProvincia;
            Descripcion = descripcion;
        }

        public Provincia() { }

        public DataTable Listar()
        {
            DataSet ds = new DataSet();
            string cmd = "SELECT CodigoProvincia as Valor, Descripcion as Texto FROM Provincias ORDER BY CodigoProvincia ASC";

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
    }
}
