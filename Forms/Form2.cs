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

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                //vamos a trabajar con el login datos contra db y los perfiles de usuario
                string contrasena;
                contrasena = Utilidades.Codificar(txtpassword.Text.Trim());
                string cmd = string.Format("select * from Usuarios where Cedula=@Cedula AND Contrasena=@Contrasenna", txtCedulaingresa.Text, contrasena); //revisar .Trim
                DataSet ds = Utilidades.Ejecutar(cmd);
                
                string usuario = ds.Tables[0].Rows[0]["Cedula"].ToString();
                string clave = ds.Tables[0].Rows[0]["contrasenna"].ToString();
                string perfil = ds.Tables[0].Rows[0]["NOPERFIL"].ToString();

                //vamos a relacionar el perfil con el Menu

                if (usuario == txtCedulaingresa.Text && clave == Utilidades.Codificar(txtpassword.Text.Trim())) 
                {


                    //perfil de administador

                    if (perfil == "1")
                    {

                        this.Hide();
                        frmPrincipal menu1 = new frmPrincipal();
                        menu1.Show();
                    }
                    else if (perfil == "2")
                    {
                        this.Hide();
                        frmPrincipal menu1 = new frmPrincipal();
                        //voy a negar partes del menu dependiendo del perfil
                        menu1.aReportesToolStripMenuItem.Visible = false;
                        menu1.aMantenimientosToolStripMenuItem.Visible = false;

                    }

                    else
                    {
                        this.Hide();
                        frmPrincipal menu1 = new frmPrincipal();
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

            catch (Exception ex)
            {
                ex.ToString();
                MessageBox.Show("Usuario o contraseña incorrectos. Favor Verifique..", "Ingreso a Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                limpiar();

            }

        }

        public void limpiar()
        {
            txtCedulaingresa.Clear();
            txtpassword.Clear();
            txtCedulaingresa.Focus();
        }
        private void btnConsultar_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}


