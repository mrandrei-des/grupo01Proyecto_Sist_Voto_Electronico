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
        }

        private void aMesaVotacionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bPresidencialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPresidentes formPresidentes = new frmPresidentes();
            formPresidentes.Show();
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
        }

        private void bMantDistritoElectoralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMantDist formMantDistritoElectoral = new frmMantDist();
            formMantDistritoElectoral.Show();
        }

        private void toolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            frmReporteProvincia formReporteProvincia = new frmReporteProvincia();
            formReporteProvincia.Show();
        }

        private void porCandidatoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmReporteCandidato formReporteCandidado = new frmReporteCandidato();
            formReporteCandidado.Show();
        }

        private void bCerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bPresidencialToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bDiputacionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bMantPadronNacionalToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bMantDistritoElectoralToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void bReportePorProvinciastoolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void bReportePorCandidatoToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
