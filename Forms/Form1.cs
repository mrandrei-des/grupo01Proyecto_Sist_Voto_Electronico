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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            cedulaUsuarioLoggeado = "305310569";
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

        private void aRegistroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formRegistroUsuario = new frmRegistroUsuario();
            formRegistroUsuario.Show();
            this.Hide();
        }

        private void bPresidencialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPresidentes formPresidentes = new frmPresidentes();
            formPresidentes.Show();
            this.Hide();
        }

        private void bDiputacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDiputados formDiputados = new frmDiputados();
            formDiputados.Show();
        }

        private void bMantPadronNacionalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMantPadronNacional formMantPadronNacional = new frmMantPadronNacional();
            formMantPadronNacional.Show();
            this.Hide();
        }

        private void bMantDistritoElectoralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMantDist formMantDistritoElectoral = new frmMantDist();
            formMantDistritoElectoral.Show();
            this.Hide();
        }

        private void toolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            frmReporteProvincia formReporteProvincia = new frmReporteProvincia();
            formReporteProvincia.Show();
            this.Hide();
        }

        private void porCandidatoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmReporteCandidato formReporteCandidado = new frmReporteCandidato();
            formReporteCandidado.Show();
            this.Hide();
        }

        private void bCerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bMantCandidatosPoliticosToolStripMenuItem_Click(object sender, EventArgs e)
        {

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
            formReporteCandidato.Show();
            this.Hide();
        }

        private void bReportePorProvinciastoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmReporteProvincia formReporteProvincia = new frmReporteProvincia();
            formReporteProvincia.Show();
            this.Hide();
        }

        private void bMantPadronNacionalToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmMantPadronNacional formMantPadron = new frmMantPadronNacional();
            formMantPadron.Show();
            this.Hide();
        }

        private void bPresidencialToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmPresidentes formPresidentes = new frmPresidentes();
            formPresidentes.cedulaUsuario = cedulaUsuarioLoggeado;
            formPresidentes.Show();
            this.Hide();
        }
    }
}
