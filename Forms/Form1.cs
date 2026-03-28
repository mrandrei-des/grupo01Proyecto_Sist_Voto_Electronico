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

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
         
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
            frmDiputados frmDiputados = new frmDiputados();
            frmDiputados.Show();
        }
    }
}
