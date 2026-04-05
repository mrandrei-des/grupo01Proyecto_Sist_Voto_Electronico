using mylibreria2026;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grupo01ProyectoFinal.Clases
{
    internal class Distrito
    {
        private string codProvincia;
        private string codCanton;
        private string codDistrito;
        private string descripcion;

        public string CodProvincia { get => codProvincia; set => codProvincia = value; }
        public string CodCanton { get => codCanton; set => codCanton = value; }
        public string CodDistrito { get => codDistrito; set => codDistrito = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }

        public Distrito(string codProvincia, string codCanton, string codDistrito, string descripcion)
        {
            CodProvincia = codProvincia;
            CodCanton = codCanton;
            CodDistrito = codDistrito;
            Descripcion = descripcion;
        }

        public Distrito() { }

        public DataTable Listar()
        {
            DataSet ds = new DataSet();
            string cmd = string.Format("SELECT CodigoDistrito as Valor, Descripcion as Texto FROM Distritos WHERE CodigoProvincia = '{0}' AND CodigoCanton = '{1}' ORDER BY CodigoProvincia ASC, CodigoCanton ASC, CodigoDistrito ASC", this.codProvincia, this.codCanton);

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
