using grupo01ProyectoFinal.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace grupo01ProyectoFinal
{
    public partial class frmAcercade : Form
    {
        public string cedulaUsuario;
        private string nombreManualUsuario;
        public frmAcercade()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDescargarManualUsuario_Click(object sender, EventArgs e)
        {
            // Se desarrolla toda la lógica para que el usuario pueda descargar el manual de usuario en PDF
            Process.Start(nombreManualUsuario);            
        }

        private void frmAcercade_Load(object sender, EventArgs e)
        {
            CargarManualUsuario();
        }

        private void CargarManualUsuario()
        {
            try
            {
                DataTable dtConsulta = new DataTable();
                Usuario objUsuario = new Usuario();

                objUsuario.Cedula = cedulaUsuario;
                dtConsulta = objUsuario.Consultar();

                if(dtConsulta.Rows.Count > 0)
                {
                    int numPerfil = Convert.ToInt32(dtConsulta.Rows[0]["numPerfil"].ToString());
                    if(numPerfil == 1)
                    {
                        nombreManualUsuario = @"C:\C#2026\Proyecto\grupo01ProyectoFinal\Insumos\ManualUsuario\ManualUsuario_Administrador.pdf";
                    }
                    else
                    {
                        nombreManualUsuario = @"C:\C#2026\Proyecto\grupo01ProyectoFinal\Insumos\ManualUsuario\ManualUsuario_Votante.pdf";
                    }

                    btnDescargarManualUsuario.Enabled = true;
                }else
                {
                    MessageBox.Show("Manual de Usuario no está disponible", "Problema al cargar el Manual de Usuario", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    btnDescargarManualUsuario.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un problema al preparar el manual de usuario. Por favor inténtelo más tarde. [001]["+ex.Message+"]", "Manual de Usuario no está disponible", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnDescargarManualUsuario.Enabled = false;
            }
        }
    }
}
