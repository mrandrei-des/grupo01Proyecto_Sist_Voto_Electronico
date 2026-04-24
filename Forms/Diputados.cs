using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using grupo01ProyectoFinal.Clases;
using System.Collections.Concurrent;


namespace grupo01ProyectoFinal
{
    public partial class frmDiputados : Form
    {
        public int tiempoRestante = 90;
        public string cedulaUsuario = string.Empty;
        private string partidoSeleccionado = "";
        public bool puedeRegresarPresidentes = true;
        public bool puedeContinuarDiputados = true;
        private bool votoGuardado = false;

        public frmDiputados()
        {
            InitializeComponent();
        }

        private void Diputados_Load(object sender, EventArgs e)
        {
            frmPrincipal formPrincipal = new frmPrincipal();
            formPrincipal.cedulaUsuarioLoggeado = cedulaUsuario;
            PuedeEmitirVotos();

            if (!puedeRegresarPresidentes && !puedeContinuarDiputados)
            {
                MessageBox.Show("Ya ha emitido sus dos sufragios. Gracias por vivir nuestra democracia.", "Votos Emitidos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                formPrincipal.Show();
                Close();
                return;
            }

            if (puedeContinuarDiputados)
            {
                timTiempoVotacion.Interval = 1000;
                timTiempoVotacion.Start();             
            }
            else
            {
                btnGuardarVoto.Enabled = false;
                BloquearTextBoxes();
                MessageBox.Show("Ya ha emitido su sufragio para las votaciones Presidenciales.", "Revisión Voto", MessageBoxButtons.OK, MessageBoxIcon.Hand);

                if (!puedeRegresarPresidentes)
                {
                    MessageBox.Show("Ya ha emitido su sufragio para las votaciones de Presidente.", "Revisión Voto", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    formPrincipal.Show();
                    Close();
                }
                else
                {
                    frmPresidentes formPresidentes = new frmPresidentes();
                    formPresidentes.cedulaUsuario = cedulaUsuario;
                    formPresidentes.tiempoRestante = tiempoRestante;
                    formPresidentes.Show();
                    Close();
                }
            }
        }

        private void ValidarContenidoSoloUnTextbox(string nombretxtPermitido)
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
                            if (innerCtrl.Name != nombretxtPermitido)
                            {
                                innerCtrl.Text = ""; // Limpiar el contenido de los TextBoxes que no están permitidos
                            }
                            else
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

        private void BloquearTextBoxes()
        {
            txtPUSC.Enabled = false;
            txtPLN.Enabled = false;
            txtPPSO.Enabled = false;
            txtVotoBlanco.Enabled = false;
            txtPNR.Enabled = false;
            txtPFA.Enabled = false;
            txtPLP.Enabled = false;
            txtVotoNulo.Enabled = false;
        }

        private void PuedeEmitirVotos()
        {

            DataTable dtUsuario = new DataTable();
            Usuario objUsuario = new Usuario();

            objUsuario.Cedula = cedulaUsuario;
            dtUsuario = objUsuario.Consultar();

            if (Convert.ToBoolean(dtUsuario.Rows[0]["estadoVotoDiputado"]) == false)
            {
                puedeContinuarDiputados = true;
            }
            else
            {
                puedeContinuarDiputados = false;
            }

            if (Convert.ToBoolean(dtUsuario.Rows[0]["estadoVotoPresidente"]) == false)
            {
                puedeRegresarPresidentes = true;
                votoGuardado = false;
            }
            else
            {
                puedeRegresarPresidentes = false;
                votoGuardado = true;
            }
        }

        private void btnGuardarVoto_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void Guardar()
        {
            try
            {
                frmPrincipal formPrincipal = new frmPrincipal();
                formPrincipal.cedulaUsuarioLoggeado = cedulaUsuario;

                if (tiempoRestante == 0)
                {
                    partidoSeleccionado = "NULO";
                }
                else
                {
                    if (string.IsNullOrEmpty(partidoSeleccionado))
                    {
                        MessageBox.Show("No ha seleccionado partido político para su voto. Por favor marque una opción.", "Revisión Voto", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        return;
                    }
                    else
                    {
                        if (MessageBox.Show("¿Está seguro que desea emitir su voto con esta elección?", "Confirmación de Sufragio", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                        {
                            return;
                        }
                    }
                }

                if (cedulaUsuario.Equals(""))
                {
                    MessageBox.Show("No se encontró la identificación del votante. Por favor inténtelo nuevamente. [002]", "Revisión de Datos Voto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    formPrincipal.Show();
                    Close();
                }

                BloquearTextBoxes();
                btnGuardarVoto.Enabled = false;

                // Para obtener el código electoral del votante
                PadronNacional objPadron = new PadronNacional();
                objPadron.Cedula = cedulaUsuario;
                DataTable dt = objPadron.Listar_x_Cedula();
                string codelec = dt.Rows[0]["COD_ELECTORAL"].ToString();

                Voto objVoto = new Voto();
                objVoto.Cedula = cedulaUsuario;
                objVoto.Codelec = codelec;
                objVoto.CodigoPartido = partidoSeleccionado;

                if (objVoto.GuardarVotoDiputado() && objVoto.GuardarBitacoraVotoEmitido_Diputado())
                {
                    Usuario objUsuario = new Usuario();
                    objUsuario.Cedula = cedulaUsuario;

                    if (objUsuario.ActualizarEstadoVotoDiputado())
                    {
                        MessageBox.Show("Voto guardado exitosamente.", "Voto Registrado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        frmPrincipal principal = new frmPrincipal();
                        principal.cedulaUsuarioLoggeado = cedulaUsuario;
                        principal.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se logró actualizar la información del estado del usuario. Por favor comunicarse con Soporte Técnico.", "Requiere Soporte Técnico", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                }
                else
                {
                    MessageBox.Show("No se logró guardar su voto. Por favor inténtelo nuevamente.", "Guardar Voto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    frmPrincipal principal = new frmPrincipal();
                    principal.cedulaUsuarioLoggeado = cedulaUsuario;
                    principal.Show();
                    this.Close();
                }
            }
            catch (Exception ex) { 
                MessageBox.Show("Ha ocurrido un problema a la hora de guardar el voto. Por favor inténtelo nuevamente. [001][" + ex.Message + "]", "Guardar Voto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                frmPrincipal formPrincipal = new frmPrincipal();
                formPrincipal.cedulaUsuarioLoggeado = cedulaUsuario;
                formPrincipal.Show();
                Close();            
            }
        }

        private void btnLimpiaDiputados_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            txtPUSC.Clear();
            txtPLN.Clear();
            txtPPSO.Clear();
            txtVotoBlanco.Clear();
            txtPNR.Clear();
            txtPFA.Clear();
            txtPLP.Clear();
            txtVotoNulo.Clear();
            partidoSeleccionado = "";
        }

        private void timTiempoVotacion_Tick(object sender, EventArgs e)
        {
            tiempoRestante = tiempoRestante - 1;
            int minutosRestantes = tiempoRestante / 60;
            int segundosRestantes = tiempoRestante % 60;

            if (minutosRestantes > 0)
            {
                txtTiempoVotacionMinutos.Text = minutosRestantes.ToString("00");
            }
            else
            {
                txtTiempoVotacionMinutos.Text = "00";
            }

            if (segundosRestantes > 0)
            {
                txtTiempoVotacionSegundos.Text = segundosRestantes.ToString("00");
                if(minutosRestantes == 0)
                {
                    txtTiempoVotacionMinutos.ForeColor = Color.Red;
                    txtTiempoVotacionSegundos.ForeColor = Color.Red;
                }
            }
            else
            {
                txtTiempoVotacionSegundos.Text = "00";
            }

            if (tiempoRestante <= 0)
            {
                tiempoRestante = 0;
                timTiempoVotacion.Stop();
                BloquearTextBoxes();
                MessageBox.Show("El tiempo para votar ha terminado. Se procederá a registrar su voto como NULO.", "Tiempo Terminado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                partidoSeleccionado = "NULO";                
                Guardar();            }
        }

        private void txtPUSC_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarVoto(sender, e, "txtPUSC");

            // Si realmente presiónó la X, entonces guarda el código del partido votado
            if (!e.Handled)
            {
                partidoSeleccionado = "PUSC";
            }
        }

        private void txtPLN_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarVoto(sender, e, "txtPLN");

            // Si realmente presiónó la X, entonces guarda el código del partido votado
            if (!e.Handled)
            {
                partidoSeleccionado = "PLN";
            }
        }

        private void txtPPSO_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarVoto(sender, e, "txtPPSO");

            // Si realmente presiónó la X, entonces guarda el código del partido votado
            if (!e.Handled)
            {
                partidoSeleccionado = "PPSO";
            }
        }

        private void txtVotoBlanco_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarVoto(sender, e, "txtVotoBlanco");

            // Si realmente presiónó la X, entonces guarda el código del partido votado
            if (!e.Handled)
            {
                partidoSeleccionado = "BLANCO";
            }
        }

        private void txtPNR_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarVoto(sender, e, "txtPNR");

            // Si realmente presiónó la X, entonces guarda el código del partido votado
            if (!e.Handled)
            {
                partidoSeleccionado = "PNR";
            }
        }

        private void txtPFA_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarVoto(sender, e, "txtPFA");

            // Si realmente presiónó la X, entonces guarda el código del partido votado
            if (!e.Handled)
            {
                partidoSeleccionado = "PFA";
            }
        }

        private void txtPLP_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarVoto(sender, e, "txtPLP");

            // Si realmente presiónó la X, entonces guarda el código del partido votado
            if (!e.Handled)
            {
                partidoSeleccionado = "PLP";
            }
        }

        private void txtVotoNulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarVoto(sender, e, "txtVotoNulo");

            // Si realmente presiónó la X, entonces guarda el código del partido votado
            if (!e.Handled)
            {
                partidoSeleccionado = "NULO";
            }
        }

        private void pbPusc_Click(object sender, EventArgs e)
        {
            txtPUSC.Focus();
        }

        private void pbPln_Click(object sender, EventArgs e)
        {
            txtPLN.Focus();
        }

        private void pbPpso_Click(object sender, EventArgs e)
        {
            txtPPSO.Focus();
        }

        private void pbCandidatoVotoBlanco_Click(object sender, EventArgs e)
        {
            txtVotoBlanco.Focus();
        }

        private void pbPnr_Click(object sender, EventArgs e)
        {
            txtPNR.Focus();
        }

        private void PbPfa_Click(object sender, EventArgs e)
        {
            txtPFA.Focus();
        }

        private void pbPlp_Click(object sender, EventArgs e)
        {
            txtPLP.Focus();
        }

        private void pbCandidatoVotoNulo_Click(object sender, EventArgs e)
        {
            txtVotoNulo.Focus();
        }
    }      
}
