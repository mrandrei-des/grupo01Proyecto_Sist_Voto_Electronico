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
    internal class Usuario
    {
        private string cedula;
        private string contrasenna;
        private string correo;
        private bool votoPresidenteEmitido;
        private bool votoDiputadoEmitido;
        private int estado;
        private int perfil;

        public string Cedula { get => cedula; set => cedula = value; }
        public string Contrasenna { get => contrasenna; set => contrasenna = value; }
        public string Correo { get => correo; set => correo = value; }
        public bool VotoPresidenteEmitido { get => votoPresidenteEmitido; set => votoPresidenteEmitido = value; }
        public bool VotoDiputadoEmitido { get => votoDiputadoEmitido; set => votoDiputadoEmitido = value; }
        public int Estado { get => estado; set => estado = value; }
        public int Perfil { get => perfil; set => perfil = value; }

        public Usuario() { }

        public Usuario(string cedula, string contrasenna, string correo, bool votoPresidenteEmitido, bool votoDiputadoEmitido, int estado, int perfil)
        {
            Cedula = cedula;
            Contrasenna = contrasenna;
            Correo = correo;
            VotoPresidenteEmitido = votoPresidenteEmitido;
            VotoDiputadoEmitido = votoDiputadoEmitido;
            Estado = estado;
            Perfil = perfil;
        }        

        public bool Registrar()
        {
            try
            {
                string cmd = string.Format("EXEC sp_Ingresar_Usuario_Votante '{0}','{1}','{2}'", this.Cedula, this.Contrasenna, this.Correo);
                Utilidades.Ejecutar(cmd);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un problema al momento de registrar su usuario en el sistema. Inténtelo nuevamente más tarde. [004][" + ex.Message + "]", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public DataTable Consultar()
        {
            DataSet ds = new DataSet();
            string cmd = string.Format("SELECT Cedula, Contrasenna, CorreoElectronico as Correo, VotoPresidenteEmitido AS estadoVotoPresidente, VotoDiputadoEmitido AS estadoVotoDiputado, IdEstado AS numEstado, IdPerfil as numPerfil FROM Usuarios WHERE Cedula = '{0}'", this.Cedula);

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

        public bool ActualizarEstadoVotoPresidente()
        {
            try
            {
                string cmd = string.Format("EXEC sp_Actualiza_Estado_Voto_Presidente '{0}'", this.cedula);
                Utilidades.Ejecutar(cmd);

                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }
    }
}
