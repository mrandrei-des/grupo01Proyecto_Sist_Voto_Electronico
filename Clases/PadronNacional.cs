using mylibreria2026;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grupo01ProyectoFinal.Clases
{
    internal class PadronNacional
    {
        private string cedula;
        private string codelec;
        private DateTime fechaVencimiento;
        private string nombre;
        private string apellido1;
        private string apellido2;

        public PadronNacional(string cedula, string codelec, DateTime fechaVencimiento, string nombre, string apellido1, string apellido2)
        {
            this.cedula = cedula;
            this.codelec = codelec;
            this.fechaVencimiento = fechaVencimiento;
            this.nombre = nombre;
            this.apellido1 = apellido1;
            this.apellido2 = apellido2;
        }

        public PadronNacional() { }

        public string Cedula { get => cedula; set => cedula = value; }
        public string Codelec { get => codelec; set => codelec = value; }
        public DateTime FechaVencimiento { get => fechaVencimiento; set => fechaVencimiento = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido1 { get => apellido1; set => apellido1 = value; }
        public string Apellido2 { get => apellido2; set => apellido2 = value; }

        public DataTable Listar_x_Provincia(string codProvincia)
        {
            DataSet ds = new DataSet();
            string cmd = string.Format("EXEC sp_Consulta_PadronNacional_x_Provincia '{0}'", codProvincia);

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

        public DataTable Listar_x_Cedula()
        {
            DataSet ds = new DataSet();
            string cmd = string.Format("EXEC sp_Consulta_PadronNacional_x_Cedula '{0}'", this.cedula);

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
        
        public DataTable ListarInformacionVotacion_x_Cedula()
        {
            DataSet ds = new DataSet();
            string cmd = string.Format("SELECT p.Nombre as Nombre, p.PrimerApellido + ' ' + p.SegundoApellido as Apellidos, d.CodigoProvincia as CodProvincia, d.CodigoCanton as CodCanton, d.CodigoDistrito as CodDistrito, p.FechaVencimientoCedula FROM PadronNacional p, DistritosElectorales d WHERE p.Codele = d.Codele and p.Cedula = '{0}'", this.cedula);

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
