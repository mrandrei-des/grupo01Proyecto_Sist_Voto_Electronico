using grupo01ProyectoFinal.Clases;
using mylibreria2026;
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
    public partial class frmRegistroUsuario : Form
    {
        DataSet ds = new DataSet();

        public frmRegistroUsuario()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            frmLogin formLogin = new frmLogin();
            formLogin.Show();
            Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void LimpiarFormulario()
        { 
            txtIdentificacion.Clear();
            txtNombre.Clear();
            txtApellidos.Clear();
            dtpFechaVencimiento.Value = DateTime.Now;
            txtContrasenna.Clear();
            txtCorreo.Clear();
            MoverCmbProvincias("1");
            MoverCmbCantones("01");
            MoverCmbDistritos("001");
            txtIdentificacion.Enabled = true;
            txtIdentificacion.ReadOnly = false;
            txtIdentificacion.Focus();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            RegistrarUsuario();
        }

        private void RegistrarUsuario()
        {
            try
            {
                if(ValidarUsuario())
                {
                    string numIdentificacion = txtIdentificacion.Text.Trim();
                    string contrasenna = Utilidades.Codificar(txtContrasenna.Text.Trim());
                    string correoElectronico = txtCorreo.Text.Trim();
                    Usuario objUsuario = new Usuario();

                    objUsuario.Cedula = numIdentificacion;
                    objUsuario.Contrasenna = contrasenna;
                    objUsuario.Correo = correoElectronico;

                    if(objUsuario.Registrar())
                    {
                        MessageBox.Show("Usuario registrado exitosamente. Por favor inicie sesión para proceder con la emisión del voto.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmLogin formLogin = new frmLogin();
                        formLogin.Show();
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("No se logró registrar el usuario. Por favor inténtelo nuevamente.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un problema al momento de registrar su usuario en el sistema. Inténtelo nuevamente más tarde. [004][" + ex.Message + "]", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarUsuario()
        {
            string numIdentificacion = txtIdentificacion.Text.Trim();
            string contrasenna = txtContrasenna.Text.Trim();
            string correoElectronico = txtCorreo.Text.Trim();

            if (numIdentificacion.Equals(""))
            {
                MessageBox.Show("Por favor digite un número de identificación válido.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                txtIdentificacion.ReadOnly = false;
                txtIdentificacion.Enabled = true;
                txtIdentificacion.Focus();
                return false;
            }

            if (contrasenna.Length < 8 || contrasenna.Length > 15)
            {
                MessageBox.Show("La contraseña debe tener un tamaño mínimo de 8 y máximo 15 carácteres.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                txtContrasenna.Focus();
                return false;
            }

            if (correoElectronico.Equals("") || !correoElectronico.Contains("@"))
            {
                MessageBox.Show("Por favor digite un correo electrónico válido.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                txtCorreo.Focus();
                return false;
            }

            return true;
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            string numIdentificacion = txtIdentificacion.Text.Trim();
            try
            {
                if(!numIdentificacion.Equals(""))
                {
                    // Valida que la identificación no esté registrada en el padrón nacional
                    PadronNacional objPadron = new PadronNacional();
                    objPadron.Cedula = numIdentificacion;

                    DataTable dtDatosPersona = objPadron.ListarInformacionVotacion_x_Cedula();
                    if (dtDatosPersona.Rows.Count > 0)
                    {
                        // Existe la persona en el padrón
                        Usuario objUsuario = new Usuario();
                        objUsuario.Cedula = numIdentificacion;
                        DataTable dtUsuario = objUsuario.Consultar();

                        if (dtUsuario.Rows.Count > 0)
                        {
                            MessageBox.Show("La identificación ya cuenta con un usuario en el sistema. Por favor inicie sesión.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            frmLogin formLogin = new frmLogin();
                            formLogin.Show();
                            Close();
                        }
                        else
                        {
                            // Carga en pantalla la información
                            txtNombre.Text = dtDatosPersona.Rows[0]["Nombre"].ToString();
                            txtApellidos.Text = dtDatosPersona.Rows[0]["Apellidos"].ToString();
                            DateTime fechaActual = DateTime.Now;
                            DateTime fechaVencimientoCedula = Convert.ToDateTime(dtDatosPersona.Rows[0]["FechaVencimientoCedula"].ToString());
                            dtpFechaVencimiento.Value = fechaVencimientoCedula;
                            string codProvincia = dtDatosPersona.Rows[0]["CodProvincia"].ToString();
                            string codCanton = dtDatosPersona.Rows[0]["CodCanton"].ToString();
                            string codDistrito = dtDatosPersona.Rows[0]["CodDistrito"].ToString();

                            MoverCmbProvincias(codProvincia);
                            MoverCmbCantones(codCanton);
                            MoverCmbDistritos(codDistrito);


                            //Revisar si la fecha de vencimiento ya se cumplió con respecto a la fecha de hoy
                            if(fechaVencimientoCedula < fechaActual)
                            {
                                MessageBox.Show("Su documento de identidad ya ha vencido. No podrá emitir su voto hasta que no cuente con un documento vigente.", "Documento de identidad vencido", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                txtContrasenna.Enabled = false;
                                txtCorreo.Enabled = false;
                                btnRegistro.Enabled = false;
                            }else
                            {
                                txtIdentificacion.ReadOnly = true;
                                txtIdentificacion.Enabled = false;
                                txtContrasenna.Enabled = true;
                                txtCorreo.Enabled = true;
                                btnRegistro.Enabled = true;
                                txtContrasenna.Focus();
                            }
                        }                               
                    }
                    else
                    {
                        MessageBox.Show("La identificación ingresada no se encuentra en el padrón nacional.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        txtIdentificacion.Focus();
                    }
                }else
                {
                    MessageBox.Show("Por favor digite un número de identificación válido.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    txtIdentificacion.Focus();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un problema al momento de consultar en el padrón nacional. [001][" + ex.Message + "]", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void frmRegistroUsuario_Load(object sender, EventArgs e)
        {
            txtNombre.ReadOnly = true;
            txtApellidos.ReadOnly = true;

            CargarComboBoxes();

            cmbProvincias.Enabled = false;
            cmbCantones.Enabled = false;
            cmbDistritos.Enabled = false;
            txtIdentificacion.Focus();
        }

        private void CargarComboBoxes()
        {
            //Idealmente que la lista sea del tipo clase OpcionCombo que tenga 2 atributos: CodigoProvincia y NombreProvincia
            CargarCmbProvincias();
            CargarCmbCantones();
            CargarCmbDistritos();
        }

        private void CargarCmbProvincias()
        {
            Provincia objProvincia = new Provincia();
            DataTable dtProvincias = objProvincia.Listar();
            if (dtProvincias.Rows.Count > 0)
            {
                cmbProvincias.DataSource = dtProvincias;
                cmbProvincias.DisplayMember = "Texto";
                cmbProvincias.ValueMember = "Valor";
            }          
        }

        private void MoverCmbProvincias(string codigoProvincia)
        {
            for (int i = 0; i < cmbProvincias.Items.Count; i++)
            {
                DataRowView fila = (DataRowView)cmbProvincias.Items[i];
                if (fila["Valor"].ToString() == codigoProvincia)
                {
                    cmbProvincias.SelectedIndex = i;
                    break;
                }
            }
        }

        private void CargarCmbCantones()
        {
            string CodigoProvincia = cmbProvincias.SelectedValue.ToString();

            Canton objCanton = new Canton();
            objCanton.CodProvincia = CodigoProvincia;

            DataTable dtCantones = objCanton.Listar();

            if (dtCantones.Rows.Count > 0)
            {
                cmbCantones.DataSource = dtCantones;
                cmbCantones.DisplayMember = "Texto";
                cmbCantones.ValueMember = "Valor";
            }            
        }

        private void MoverCmbCantones(string codigoCanton)
        {
            for (int i = 0; i < cmbCantones.Items.Count; i++)
            {
                DataRowView fila = (DataRowView)cmbCantones.Items[i];
                if (fila["Valor"].ToString() == codigoCanton)
                {
                    cmbCantones.SelectedIndex = i;
                    break;
                }
            }
        }

        private void CargarCmbDistritos()
        {
            string CodigoProvincia = cmbProvincias.SelectedValue.ToString();
            string CodigoCanton = cmbCantones.SelectedValue.ToString();
            Distrito objDistrito = new Distrito();
            objDistrito.CodProvincia = CodigoProvincia;
            objDistrito.CodCanton = CodigoCanton;
            DataTable dtDistritos = objDistrito.Listar();

            if (dtDistritos.Rows.Count > 0)
            {
                cmbDistritos.DataSource = dtDistritos;
                cmbDistritos.DisplayMember = "Texto";
                cmbDistritos.ValueMember = "Valor";
            }            
        }

        private void MoverCmbDistritos(string codigoDistrito)
        {
            for (int i = 0; i < cmbDistritos.Items.Count; i++)
            {
                DataRowView fila = (DataRowView)cmbDistritos.Items[i];
                if (fila["Valor"].ToString() == codigoDistrito)
                {
                    cmbDistritos.SelectedIndex = i;
                    break;
                }
            }
        }

        private void cmbProvincias_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarCmbCantones();
        }

        private void cmbCantones_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarCmbDistritos();
        }

        private void txtIdentificacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Validar que solo ingrese números o letras
            if (!char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Validar que solo ingrese números´, letras el arroba y puntos
            if (!char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar) && !(e.KeyChar == '@') && !(e.KeyChar == '.') && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtContrasenna_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Validar que solo ingrese números o letras
            if (!char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }

            if(txtContrasenna.Text.Length >= 15)
            {
                e.Handled = true; 
            }
        }
    }
}
