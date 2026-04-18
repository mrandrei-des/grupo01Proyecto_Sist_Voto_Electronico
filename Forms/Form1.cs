using grupo01ProyectoFinal.Clases;
using grupo01ProyectoFinal.Forms;
using mylibreria2026;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace grupo01ProyectoFinal
{
    public partial class frmPrincipal : Form
    {
        public string cedulaUsuarioLoggeado;
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            OcultarOpcionesMenu();
        }

        private void bSalirDelSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aAcercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Form formAcercaDe = new frmAcercade();
            formAcercaDe.Show();
        }

        private void bCerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin formLogin = new frmLogin();
            formLogin.Show();
            Close();
        }

        private void bEstadisticasPorProvinciaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bEstadisticasPorCandidatoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bReportePorCandidatoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmReporteCandidato formReporteCandidato = new frmReporteCandidato();
            formReporteCandidato.cedulaUsuario = cedulaUsuarioLoggeado;
            formReporteCandidato.Show();
            Close();
        }

        private void bReportePorProvinciastoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmReporteProvincia formReporteProvincia = new frmReporteProvincia();
            formReporteProvincia.cedulaUsuario = cedulaUsuarioLoggeado;
            formReporteProvincia.Show();
            Close();
        }

        private void bMantPadronNacionalToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmMantPadronNacional formMantPadron = new frmMantPadronNacional();
            formMantPadron.cedulaUsuario = cedulaUsuarioLoggeado;
            formMantPadron.Show();
            Close();
        }

        private void bPresidencialToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmPresidentes formPresidentes = new frmPresidentes();
            formPresidentes.cedulaUsuario = cedulaUsuarioLoggeado;
            formPresidentes.Show();
            Close();
        }

        private void resultadosDiputadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmResultadosDiputados formResDiputados = new frmResultadosDiputados();
            formResDiputados.cedulaUsuario = cedulaUsuarioLoggeado;
            formResDiputados.Show();
            Close();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void bDiputacionToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void bMantDistritoElectoralToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void aIngresar_Click(object sender, EventArgs e)
        {

        }

        private void aMesaVotacionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        // Cada vez que se carga el formulario, se deben ocultar las opciones de menú porque se crean cada vez que se crea un formulario principal
        private void OcultarOpcionesMenu()
        {
            Usuario objUsuario = new Usuario();
            objUsuario.Cedula = cedulaUsuarioLoggeado;

            DataTable dtConsulta = new DataTable();
            dtConsulta = objUsuario.Consultar();

            if (dtConsulta.Rows.Count > 0)
            {
                string perfil = dtConsulta.Rows[0]["numPerfil"].ToString();

                if (perfil == "1") // Es usuario administrador, puede ver todas las opciones
                {
                    
                }
                else if (perfil == "2") // Es un votante, se restringen las opciones
                {
                    this.aReportesToolStripMenuItem.Visible = false;
                    this.aMantenimientosToolStripMenuItem.Visible = false;
                }
                else // Cualquier otro perfil se restringe
                {
                    this.aReportesToolStripMenuItem.Visible = false;
                    this.aMantenimientosToolStripMenuItem.Visible = false;
                }
            }else
            {            
                MessageBox.Show("No se logró establecer comunicación con el servidor. Por favor inténtelo nuevamente.", "Consulta de usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmLogin formLogin = new frmLogin();
                formLogin.Show();
                Close();
            }
        }
    }
}
