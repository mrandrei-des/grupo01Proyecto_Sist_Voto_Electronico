using grupo01ProyectoFinal.Clases;
using mylibreria2026;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace grupo01ProyectoFinal
{
    public partial class frmLogin : Form
    {

        //creamos variable globales
        public DataSet ds;

        public frmLogin()
        {
            InitializeComponent();
        }

        public void limpiar()
        {
            txtCedulaingresa.Clear();
            txtpassword.Clear();
            txtCedulaingresa.Focus();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
           
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            frmRegistroUsuario formRegistroUsuario = new frmRegistroUsuario();
            formRegistroUsuario.Show();
            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIngresa_Click(object sender, EventArgs e)
        {
            try
            {
                string contrasena;
                contrasena = Utilidades.Codificar(txtpassword.Text.Trim());

                DataTable dtConsulta = new DataTable();
                Usuario objUsuario = new Usuario();

                objUsuario.Cedula = txtCedulaingresa.Text.Trim();
                objUsuario.Contrasenna = contrasena;
                dtConsulta = objUsuario.Consultar_UsuarioRegistrado();

                if (dtConsulta.Rows.Count > 0) // Se valida que reamente haya traído al menos 1 registro
                {
                    string usuario = dtConsulta.Rows[0]["Cedula"].ToString();
                    string clave = dtConsulta.Rows[0]["contrasenna"].ToString();
                    string perfil = dtConsulta.Rows[0]["IdPerfil"].ToString();
                    DateTime fechaActual = DateTime.Now;
                    DateTime fechaVencimientoCedula = Convert.ToDateTime(dtConsulta.Rows[0]["FechaVencimientoCedula"].ToString());

                    //Revisar si la fecha de vencimiento ya se cumplió con respecto a la fecha de hoy
                    if (fechaVencimientoCedula < fechaActual)
                    {
                        MessageBox.Show("Su documento de identidad ya ha vencido. No podrá emitir su voto hasta que no cuente con un documento vigente.", "Documento de identidad vencido", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }
                    else
                    {
                        if (usuario == txtCedulaingresa.Text && clave == Utilidades.Codificar(txtpassword.Text.Trim()))
                        {
                            //perfil de administador

                            if (perfil == "1")
                            {

                                this.Hide();
                                frmPrincipal menu1 = new frmPrincipal();
                                menu1.cedulaUsuarioLoggeado = usuario;
                                menu1.Show();
                            }
                            else if (perfil == "2")
                            {
                                this.Hide();
                                frmPrincipal menu1 = new frmPrincipal();
                                menu1.cedulaUsuarioLoggeado = usuario;

                                //voy a negar partes del menu dependiendo del perfil
                                menu1.aReportesToolStripMenuItem.Visible = false;
                                menu1.aMantenimientosToolStripMenuItem.Visible = false;
                                menu1.aEstadisticasToolStripMenuItem.Visible = false;

                                // Deshabilita opciones, pero no muestra la pantalla
                                menu1.Show();
                            }
                            else
                            {
                                this.Hide();
                                frmPrincipal menu1 = new frmPrincipal();
                                menu1.cedulaUsuarioLoggeado = usuario;

                                //voy a negar partes del menu dependiendo del perfil
                                menu1.aReportesToolStripMenuItem.Visible = false;
                                menu1.aMantenimientosToolStripMenuItem.Visible = false;
                                menu1.Show();
                            }
                        }
                        else
                        {
                            MessageBox.Show("La contraseña y la clave no coinciden, por favor verificar...", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtCedulaingresa.Focus();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No se encontró ningún usuario registrado.", "Inicio de Sesión", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    txtCedulaingresa.Focus();
                }                
            }

            catch (Exception ex)
            {
                ex.ToString();
                MessageBox.Show("Usuario o contraseña incorrectos. Favor Verifique..", "Ingreso a Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                limpiar();

            }
        }

        private void txtCedulaingresa_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Validar que solo ingrese números o letras
            if (!char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }else
            {
                e.Handled = false;
            }
        }
    }
}


