using mylibreria2026;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grupo01ProyectoFinal.Clases
{
    internal class PartidoPolitico
    {
        private string codigo;
        private string nombre;
        private string nombreBandera;

        public PartidoPolitico() { }

        public PartidoPolitico(string codigo, string nombre, string nombreBandera)
        {
            Codigo = codigo;
            Nombre = nombre;
            NombreBandera = nombreBandera;
        }

        public string Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string NombreBandera { get => nombreBandera; set => nombreBandera = value; }

        public DataTable Consultar()
        {
            DataSet ds = new DataSet();
            string cmd = string.Format("SELECT CodigoPartido, Descripcion AS Nombre, NombreImagenBandera as NombreBandera FROM PartidosPoliticos WHERE CodigoPartido = '{0}'", this.Codigo);

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
