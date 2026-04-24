using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace grupo01ProyectoFinal.Forms
{
    public partial class frmReporteFinalesPresidente : Form
    {
        public string cedulaUsuario = string.Empty;
        public frmReporteFinalesPresidente()
        {
            InitializeComponent();
        }

        private void frmReporteFinalesPresidente_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            frmPrincipal formPrincipal = new frmPrincipal();
            formPrincipal.cedulaUsuarioLoggeado = cedulaUsuario;
            formPrincipal.Show();
            this.Close();
        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            GenerarReporte();
        }

        private void GenerarReporte()
        {
            frmShowReportePresidenteFinal formReporte = new frmShowReportePresidenteFinal();
            formReporte.Show();
        }
    }
}
