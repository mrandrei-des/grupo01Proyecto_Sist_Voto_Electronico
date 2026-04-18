using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.CompilerServices;

namespace grupo01ProyectoFinal
{
    public partial class frmAcercade : Form
    {
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
        }

        private void frmAcercade_Load(object sender, EventArgs e)
        {

        }
    }
}
