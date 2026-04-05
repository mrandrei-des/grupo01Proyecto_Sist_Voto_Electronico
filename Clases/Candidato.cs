using mylibreria2026;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grupo01ProyectoFinal.Clases
{
    internal class Candidato
    {
        private string codigoCandidato;
        private string nombre;
        private string apellido1;
        private string apellido2;
        private string nombreImagen;
        private int estado;
        private string codPartido;

        public Candidato(string codigoCandidato, string nombre, string apellido1, string apellido2, string nombreImagen, int estado, string codPartido)
        {
            CodigoCandidato = codigoCandidato;
            Nombre = nombre;
            Apellido1 = apellido1;
            Apellido2 = apellido2;
            NombreImagen = nombreImagen;
            Estado = estado;
            CodPartido = codPartido;
        }

        public Candidato() { }

        public string CodigoCandidato { get => codigoCandidato; set => codigoCandidato = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido1 { get => apellido1; set => apellido1 = value; }
        public string Apellido2 { get => apellido2; set => apellido2 = value; }
        public string NombreImagen { get => nombreImagen; set => nombreImagen = value; }
        public int Estado { get => estado; set => estado = value; }
        public string CodPartido { get => codPartido; set => codPartido = value; }

        public DataTable Consultar()
        {
            DataSet ds = new DataSet();
            string cmd = string.Format("SELECT CodigoCandidato as CodCandidato, Nombre, PrimerApellido as Apellido1, SegundoApellido as Apellido2, NombreImagenFoto as NombreImagen, IdEstado as NumEstado, CodigoPartido as CodPartido FROM Candidatos WHERE CodigoPartido = '{0}'", this.codPartido);

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
