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
            frmPrincipal formPrincipal = new frmPrincipal();
            formPrincipal.Show();
            this.Close();
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
            // Valida los datos (constraseña y correo)
            // Guarda los datos
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
                    string cmd = string.Format("EXEC sp_Ingresar_Usuario_Votante '{0}','{1}','{2}'", numIdentificacion, contrasenna, correoElectronico);

                    Utilidades.Ejecutar(cmd);
                    MessageBox.Show("Usuario registrado exitosamente. Por favor inicie sesión para proceder con la emisión del voto.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarFormulario();
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
                    string cmd = string.Format("SELECT p.Nombre as Nombre, p.PrimerApellido + ' ' + p.SegundoApellido as Apellidos, d.CodigoProvincia as CodProvincia, d.CodigoCanton as CodCanton, d.CodigoDistrito as CodDistrito FROM PadronNacional p, DistritosElectorales d WHERE p.Codele = d.Codele and p.Cedula = '{0}'", numIdentificacion);
                    DataSet datosPersona = Utilidades.Ejecutar(cmd);

                    if(datosPersona.Tables.Count > 0)
                    {
                        if (datosPersona.Tables[0].Rows.Count > 0)
                        {
                            // Existe la persona en el padrón

                            cmd = string.Format("SELECT * FROM Usuarios WHERE Cedula = '{0}'", numIdentificacion);
                            ds = Utilidades.Ejecutar(cmd);

                            if (ds.Tables.Count > 0) {
                                if (ds.Tables[0].Rows.Count > 0)
                                {
                                    MessageBox.Show("La identificación ya cuenta con un usuario en el sistema. Por favor inicie sesión.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                    LimpiarFormulario();
                                    txtIdentificacion.Focus();
                                }
                                else
                                {
                                    // Carga en pantalla la información

                                    txtNombre.Text = datosPersona.Tables[0].Rows[0]["Nombre"].ToString();
                                    txtApellidos.Text = datosPersona.Tables[0].Rows[0]["Apellidos"].ToString();
                                    string codProvincia = datosPersona.Tables[0].Rows[0]["CodProvincia"].ToString();
                                    string codCanton = datosPersona.Tables[0].Rows[0]["CodCanton"].ToString();
                                    string codDistrito = datosPersona.Tables[0].Rows[0]["CodDistrito"].ToString();

                                    MoverCmbProvincias(codProvincia);
                                    MoverCmbCantones(codCanton);
                                    MoverCmbDistritos(codDistrito);
                                    txtIdentificacion.ReadOnly = true;
                                    txtIdentificacion.Enabled = false;
                                    txtContrasenna.Focus();
                                }                            
                            }else
                            {
                                MessageBox.Show("No se pudo comprobar si la identificación ya cuenta con un usuario registrado. [003]", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("La identificación ingresada no se encuentra en el padrón nacional.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            txtIdentificacion.Focus();
                        }
                    }else
                    {
                        MessageBox.Show("No se pudo corroborar si la identificación se encuentra en el padrón nacional. [002]", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
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


            // Al mover un combo box se activa el evento de SelectedIndexChanged que hace que cargue el otro combo box
            // Mover los combos según el distrito electoral que le corresponda
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
            string cmd = "SELECT CodigoProvincia as Valor, Descripcion as Texto FROM Provincias ORDER BY CodigoProvincia ASC";

            ds = Utilidades.Ejecutar(cmd);

            if (ds.Tables.Count > 0)
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    cmbProvincias.DataSource = ds.Tables[0];
                    cmbProvincias.DisplayMember = "Texto";
                    cmbProvincias.ValueMember = "Valor";
                }
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

            string cmd = string.Format("SELECT CodigoCanton as Valor, Descripcion as Texto FROM Cantones WHERE CodigoProvincia = '{0}' ORDER BY CodigoProvincia ASC, CodigoCanton ASC", CodigoProvincia);

            ds = Utilidades.Ejecutar(cmd);

            if (ds.Tables.Count > 0)
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    cmbCantones.DataSource = ds.Tables[0];
                    cmbCantones.DisplayMember = "Texto";
                    cmbCantones.ValueMember = "Valor";
                }
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

            string cmd = string.Format("SELECT CodigoDistrito as Valor, Descripcion as Texto FROM Distritos WHERE CodigoProvincia = '{0}' AND CodigoCanton = '{1}' ORDER BY CodigoProvincia ASC, CodigoCanton ASC, CodigoDistrito ASC", CodigoProvincia, CodigoCanton);

            ds = Utilidades.Ejecutar(cmd);

            if (ds.Tables.Count > 0)
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    cmbDistritos.DataSource = ds.Tables[0];
                    cmbDistritos.DisplayMember = "Texto";
                    cmbDistritos.ValueMember = "Valor";
                }
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
                // Se valida 
            }
        }
    }
}
