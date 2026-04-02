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

namespace grupo01ProyectoFinal
{
    public partial class frmPresidentes : Form
    {
        private string partidoVotado = "";
        private int tiempoRestante = 90;
        private bool puedeContinuarDiputados = true;
        private bool votoGuardado = false;
        public frmPresidentes()
        {
            InitializeComponent();
        }

        private void ValidarContenidoSoloUnTextbox(string nombreTxtPermitido)
        {
            // Lo que hace este método es validar que solo un TextBox tenga contenido, y el resto estén vacíos. El parámetro nombreTxtPermitido es el nombre del TextBox que se permite tener contenido, mientras que los demás serán limpiados.
            for (int i = 0; i < this.Controls.Count; i++)
            {
                Control ctrl = this.Controls[i];

                if (ctrl is GroupBox)
                {
                    for (int j = 0; j < ctrl.Controls.Count; j++)
                    {
                        Control innerCtrl = ctrl.Controls[j];
                        if (innerCtrl is TextBox)
                        {
                            if (innerCtrl.Name != nombreTxtPermitido)
                            {
                                innerCtrl.Text = ""; // Limpiar el contenido de los TextBoxes que no están permitidos
                            }else
                            {
                                // Si el textbox permitido ya tiene una X, entonces se limpia para permitir ingresar otra X
                                if (!string.IsNullOrEmpty(innerCtrl.Text))
                                {
                                    innerCtrl.Text = string.Empty;
                                }
                            }
                        }
                    }
                    break;
                }
            }
        }

        private void ValidarVoto(object sender, KeyPressEventArgs e, string nombreTxT)
        {
            // Revisar que la tecla presionada sea la X
            if (e.KeyChar == 'X' || e.KeyChar == 'x')
            {            
                // Si es la X, permitir la entrada y validar que solo este TextBox tenga contenido
                ValidarContenidoSoloUnTextbox(nombreTxT);
            }
            else
            {
                // Si no es la X, cancelar la entrada
                e.Handled = true;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

            Limpiar();
        }

        private void Limpiar()
        {
            partidoVotado = "";
            txtVotoPUSC.Clear();
            txtVotoPLN.Clear();
            txtVotoPPSO.Clear();
            txtVotoBlanco.Clear();
            txtVotoPNR.Clear();
            txtVotoPFA.Clear();
            txtVotoPLP.Clear();
            txtVotoNulo.Clear();
        }

        private void BloquearTextBoxes()
        {
            txtVotoPUSC.Enabled = false;
            txtVotoPLN.Enabled = false;
            txtVotoPPSO.Enabled = false;
            txtVotoBlanco.Enabled = false;
            txtVotoPNR.Enabled = false;
            txtVotoPFA.Enabled = false;
            txtVotoPLP.Enabled = false;
            txtVotoNulo.Enabled = false;
        }

        private void frmPresidentes_Load(object sender, EventArgs e)
        {
            if(!votoGuardado)
            {
                timTiempoVotacion.Interval = 1000;
                timTiempoVotacion.Start(); // Iniciar el temporizador al cargar el formulario                
            }
            
            if(!puedeContinuarDiputados)
            {
                btnContinuarVotacion.Enabled = false;
            }
        }

        private void txtVotoPUSC_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarVoto(sender, e, "txtVotoPUSC");

            // Si realmente presiónó la X, entonces guarda el código del partido votado
            if (!e.Handled)
            {
                partidoVotado = "PUSC";
            }
        }

        private void txtVotoPLN_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarVoto(sender, e, "txtVotoPLN");

            // Si realmente presiónó la X, entonces guarda el código del partido votado
            if (!e.Handled)
            {
                partidoVotado = "PLN";
            }
        }

        private void txtVotoPPSO_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarVoto(sender, e, "txtVotoPPSO");

            // Si realmente presiónó la X, entonces guarda el código del partido votado
            if (!e.Handled)
            {
                partidoVotado = "PPSO";
            }
        }

        private void txtVotoBlanco_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarVoto(sender, e, "txtVotoBlanco");

            // Si realmente presiónó la X, entonces guarda el código del partido votado
            if (!e.Handled)
            {
                partidoVotado = "BLANCO";
            }
        }

        private void txtVotoPNR_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarVoto(sender, e, "txtVotoPNR");

            // Si realmente presiónó la X, entonces guarda el código del partido votado
            if (!e.Handled)
            {
                partidoVotado = "PNR";
            }
        }

        private void txtVotoPFA_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarVoto(sender, e, "txtVotoPFA");
            // Si realmente presiónó la X, entonces guarda el código del partido votado
            if (!e.Handled)
            {
                partidoVotado = "PFA";
            }
        }

        private void txtVotoPLP_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarVoto(sender, e, "txtVotoPLP");

            // Si realmente presiónó la X, entonces guarda el código del partido votado
            if (!e.Handled)
            {
                partidoVotado = "PLP";
            }
        }

        private void txtVotoNulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarVoto(sender, e, "txtVotoNulo");

            // Si realmente presiónó la X, entonces guarda el código del partido votado
            if (!e.Handled)
            {
                partidoVotado = "NULO";
            }

        }

        private void btnGuardarVoto_Click(object sender, EventArgs e)
        {
            // Si no hay tiempo, el voto se guarda como nulo, sin importar si el usuario marcó alguna opción o no
            if (tiempoRestante == 0)
            {
                partidoVotado = "NULO";
            }else
            {
                if (string.IsNullOrEmpty(partidoVotado))
                {
                    MessageBox.Show("No ha emitido su voto. Por favor marque una opción.", "Revisión Voto", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
                }
                else
                {
                    if(MessageBox.Show("¿Está seguro que desea emitir así su voto?", "Confirmación de Sufragio", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        return;
                    }
                }
            }

            BloquearTextBoxes();

            // Procede a guardar el voto en la base de datos o donde se requiera. Por ahora, solo se muestra un mensaje de confirmación.
            MessageBox.Show("Su voto ha sido registrado. Gracias por ejercer su derecho al voto.", "Voto Registrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            votoGuardado = true;
            frmDiputados formDiputados = new frmDiputados();
            formDiputados.Show();
            this.Close();

        }

        private void btnContinuarVotacion_Click(object sender, EventArgs e)
        {
            frmDiputados formDiputados = new frmDiputados();
            formDiputados.Show();
            this.Hide();
        }

        private void timTiempoVotacion_Tick(object sender, EventArgs e)
        {
            tiempoRestante = tiempoRestante - 1;
            int minutosRestantes = tiempoRestante / 60;
            int segundosRestantes = tiempoRestante % 60;

            if (minutosRestantes > 0)
            {
                txtTiempoVotacionMinutos.Text = minutosRestantes.ToString("00");
            }else
            {
                txtTiempoVotacionMinutos.Text = "00";
            }

            if(segundosRestantes > 0)
            {
                txtTiempoVotacionSegundos.Text = segundosRestantes.ToString("00");
            }else
            {
                txtTiempoVotacionSegundos.Text = "00";
            }

            if (tiempoRestante <= 0)
            {
                tiempoRestante = 0;
                BloquearTextBoxes();
                timTiempoVotacion.Stop();
                MessageBox.Show("El tiempo para votar ha terminado. Se procederá a registrar su voto como NULO.", "Tiempo Terminado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                partidoVotado = "NULO";
                btnGuardarVoto.PerformClick(); // Simular el click en el botón de guardar voto para registrar el voto nulo
            }
        }

        private void pbCandidatoPUSC_Click(object sender, EventArgs e)
        {
            txtVotoPUSC.Focus();
        }

        private void pbCandidatoPLN_Click(object sender, EventArgs e)
        {
            txtVotoPLN.Focus();
        }

        private void pbCandidatoPPSO_Click(object sender, EventArgs e)
        {
            txtVotoPPSO.Focus();
        }

        private void pbCandidatoVotoBlanco_Click(object sender, EventArgs e)
        {
            txtVotoBlanco.Focus();
        }

        private void pbCandidatoPNR_Click(object sender, EventArgs e)
        {
            txtVotoPNR.Focus();
        }

        private void pbCandidatoPFA_Click(object sender, EventArgs e)
        {
            txtVotoPFA.Focus();
        }

        private void pbCandidatoPLP_Click(object sender, EventArgs e)
        {
            txtVotoPLP.Focus();
        }

        private void pbCandidatoVotoNulo_Click(object sender, EventArgs e)
        {
            txtVotoNulo.Focus();
        }
    }
}
