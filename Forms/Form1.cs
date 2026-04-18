using grupo01ProyectoFinal.Forms;
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
    }
}
