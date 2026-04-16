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


namespace grupo01ProyectoFinal
{
    public partial class frmDiputados : Form
    {
        private System.Windows.Forms.Timer timer;
        private int tipoRestante;
        private int tiempoRestante = 60; // 1 minuto en segundos
        private Label lblMinutos;
        private Label lblSegundos;
        private string partidoSeleccionado = "";
        private TextBox[] txtBoxes = new TextBox[8]; // tus 8 textboxes de voto

        public frmDiputados()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Diputados_Load(object sender, EventArgs e)
        {

        }

        private void IniciarTimer()
        {
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000; // cada 1 segundo
            timer.Tick += Timer_Tick;
            timer.Start();
            ActualizarDisplay();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            frmPrincipal principal = new frmPrincipal();
            principal.Show();
            Close();
        }


        private void lblvotoPPSO_Click(object sender, EventArgs e)
        {

        }

        private void pbPpso_Click(object sender, EventArgs e)
        {

        }

        private void grbPapeleta_Enter(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            {
                if (string.IsNullOrEmpty(partidoSeleccionado))
                { 
                    DialogResult dr = MessageBox.Show(
                        "No ha seleccionado ningún partido.\n¿Desea continuar sin votar?",
                        "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dr == DialogResult.No) return;
                }
                Guardar();
            }

        }

        private void btnGuardarVoto_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void Guardar()
        {
            timer?.Stop();

            string codigoPartido = string.IsNullOrEmpty(partidoSeleccionado) ? "NULO" : partidoSeleccionado;

            string connStr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Sist_Votaciones_Electronicos;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string comando = @"INSERT INTO VotosEmitidos 
                          (Cedula, IdTipoEleccion, Codele, NumeroJuntaReceptora, CodigoPartido, CodigoCandidato, FechaEmisionVoto) 
                          VALUES 
                          (@Cedula, @IdTipoEleccion, @Codele, @NumeroJuntaReceptora, @CodigoPartido, @CodigoCandidato, @FechaEmisionVoto)";

                SqlCommand cmd = new SqlCommand(comando, conn);

                cmd.Parameters.AddWithValue("@Cedula", ""); // variable de cédula
                cmd.Parameters.AddWithValue("@IdTipoEleccion", 2);
                cmd.Parameters.AddWithValue("@Codele", "");    // variable de codele
                cmd.Parameters.AddWithValue("@NumeroJuntaReceptora", "");     // variable de junta
                cmd.Parameters.AddWithValue("@CodigoPartido", codigoPartido);
                cmd.Parameters.AddWithValue("@CodigoCandidato", "");    //variable de candidato
                cmd.Parameters.AddWithValue("@FechaEmisionVoto", DateTime.Now);

                conn.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show($"Voto guardado exitosamente.\nPartido: {codigoPartido}",
                "Voto Registrado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }
        private void timer1_Tick_1(object sender, EventArgs e)
        {
     
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000; // cada 1 segundo
            timer.Tick += Timer_Tick;
            timer.Start();
            ActualizarDisplay();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            tiempoRestante--;
            ActualizarDisplay();

            // Pone los números en rojo cuando quedan 10 segundos o menos
            if (tiempoRestante <= 10)
            {
                txtMinutos.ForeColor = Color.Red;
                txtSegundos.ForeColor = Color.Red;
            }

            if (tiempoRestante <= 0)
            {
                timer.Stop();
                TiempoAgotado();
            }
        }
        private void ActualizarDisplay()
        {
            int minutos = tiempoRestante / 60;
            int segundos = tiempoRestante % 60;
            lblMinutos.Text = minutos.ToString("D2"); // "01"
            lblSegundos.Text = segundos.ToString("D2"); // "00"
        }

        private void TiempoAgotado()
        {
            foreach (TextBox txt in txtBoxes)
                txt.Enabled = false; // bloquea los campos de voto

            MessageBox.Show("¡Tiempo agotado!\nVoto guardado automáticamente.",
                "Tiempo Expirado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Guardar();// guarda el voto automáticamente
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
        }
        private void Txt_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;

            // Solo acepta X o x
            if (txt.Text.ToUpper() != "X" && txt.Text != "")
            {
                txt.Text = "";
                return;
            }

            if (txt.Text.ToUpper() == "X")
            {
                // Limpiar todos los demás TextBox (solo un voto)
                foreach (TextBox t in txtBoxes)
                {
                    if (t != txt)
                        t.Text = "";
                }

                // Guardar qué partido fue seleccionado según el TextBox
                partidoSeleccionado = txt.Tag.ToString(); // ← Tag debe tener el nombre del partido
            }
            else
            {
                partidoSeleccionado = ""; // si borra la X, deselecciona
            }
        }

        
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            timer?.Stop();
            base.OnFormClosing(e);
        }

    }
        
}
