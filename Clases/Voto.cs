using mylibreria2026;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace grupo01ProyectoFinal.Clases
{
    internal class Voto
    {
        private string cedula;
        private int tipoEleccion;
        private string codelec;
        private string codigoPartido;
        private string codigoCandidato;

        public Voto() { }

        public Voto(string cedula, int tipoEleccion, string codelec, string codigoPartido, string codigoCandidato)
        {
            Cedula = cedula;
            TipoEleccion = tipoEleccion;
            Codelec = codelec;
            CodigoPartido = codigoPartido;
            CodigoCandidato = codigoCandidato;
        }

        public string Cedula { get => cedula; set => cedula = value; }
        public int TipoEleccion { get => tipoEleccion; set => tipoEleccion = value; }
        public string Codelec { get => codelec; set => codelec = value; }
        public string CodigoPartido { get => codigoPartido; set => codigoPartido = value; }
        public string CodigoCandidato { get => codigoCandidato; set => codigoCandidato = value; }

        public bool GuardarVoto()
        {
            try
            {
                string cmd = string.Format("EXEC sp_Inserta_Voto_Emitido '{0}','{1}','{2}','{3}','{4}'", this.Cedula, this.TipoEleccion, this.Codelec, this.codigoPartido, this.CodigoCandidato);

                Utilidades.Ejecutar(cmd);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un problema a la hora de guardar el voto. Por favor inténtelo nuevamente. [001][" + ex.Message + "]", "Guardar Voto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }
    }
}
