using mylibreria2026;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grupo01ProyectoFinal.Clases
{
    internal class Canton
    {
        private string codProvincia;
        private string codCanton;
        private string descripcion;

        public string CodProvincia { get => codProvincia; set => codProvincia = value; }
        public string CodCanton { get => codCanton; set => codCanton = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }

        public Canton(string codProvincia, string codCanton, string descripcion)
        {
            CodProvincia = codProvincia;
            CodCanton = codCanton;
            Descripcion = descripcion;
        }

        public Canton() { }

        public DataTable Listar()
        {
            DataSet ds = new DataSet();
            string cmd = string.Format("SELECT CodigoCanton as Valor, Descripcion as Texto FROM Cantones WHERE CodigoProvincia = '{0}' ORDER BY CodigoProvincia ASC, CodigoCanton ASC", this.codProvincia); ;

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
