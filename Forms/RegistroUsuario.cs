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
        public frmRegistroUsuario()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
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
            MoverCmbProvincias("1");
            MoverCmbCantones("01");
            MoverCmbDistritos("001");
            txtContrasenna.Clear();
            txtCorreo.Clear();
            txtIdentificacion.Focus();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            // Valida que la identificación no esté registrada
            // Valida los datos (constraseña y correo)
            // Guarda los datos

            string numIdentificacion = txtIdentificacion.Text.Trim();
            string contrasenna = txtContrasenna.Text.Trim();
            string correoElectronico = txtCorreo.Text.Trim();

        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            string numIdentificacion = txtIdentificacion.Text.Trim();

            // Valida que la identificación no esté registrada
            // Busca los datos del usuario en la tabla de padrón nacional y distrito electoral(nombre, apellidos, provincia, cantón y distrito de votación)
            // Carga en pantalla la información

            txtNombre.Text = "";
            txtApellidos.Text = "";
            // Al mover un combo box se activa el evento de SelectedIndexChanged que hace que cargue el otro combo box
            // Mover los combos según el distrito electoral que le corresponda
            MoverCmbProvincias("1");
            MoverCmbCantones("01");
            MoverCmbDistritos("001");
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
            string[] listaProvincias = ConsultarProvincias();
            CargarCmbProvincias(listaProvincias);
            MoverCmbProvincias("1");

            //string[] listaCantones = ConsultarCantones("1");
            //CargarCmbCantones(listaCantones);
            //MoverCmbCantones("01");

            //string[] listaDistritos = ConsultarDistritos("1", "01");
            //CargarCmbDistritos(listaDistritos);
            //MoverCmbDistritos("001");
        }

        // Procesos y funciones para consultar, cargar y mover el combobox de provincias
        private string[] ConsultarProvincias()
        {
            return new string[1];
        }

        private void CargarCmbProvincias(string[] listaProvincias)
        {
            cmbProvincias.Items.Clear();
            for (int i = 0; i < listaProvincias.Length; i++) {

                if (!string.IsNullOrEmpty(listaProvincias[i]))
                {
                    //cmbProvincias.Items.Add(listaProvincias[i]);
                    // Cargar el combo box con un DataSource
                    //cmbProvincias.DataSource = listaProvincias[i];
                    //cmbProvincias.DisplayMember = "NombreProvincia";
                    //cmbProvincias.ValueMember = "CodigoProvincia";
                }
            }
        }

        private void MoverCmbProvincias(string idProvincia)
        {
            for (int i = 0; i < cmbProvincias.Items.Count; i++) {
                if (cmbProvincias.Items[i].ToString().Substring(0, 1) == idProvincia)
                {
                    cmbProvincias.SelectedIndex = i;
                    break;
                }
            }
        }

        // Procesos y funciones para consultar, cargar y mover el combobox de cantones
        private string[] ConsultarCantones(string idProvincia)
        {
            //Idealmente que la lista sea del tipo clase OpcionCombo que tenga 2 atributos: CodigoProvincia y NombreProvincia
            return new string[1];
        }

        private void CargarCmbCantones(string[] listaCantones)
        {
            cmbCantones.Items.Clear();
            for (int i = 0; i < listaCantones.Length; i++)
            {
                if (!string.IsNullOrEmpty(listaCantones[i]))
                {
                    //cmbCantones.Items.Add(listaCantones[i]);
                    // Cargar el combo box con un DataSource
                    //cmbProvincias.DataSource = listaProvincias[i];
                    //cmbProvincias.DisplayMember = "NombreProvincia";
                    //cmbProvincias.ValueMember = "CodigoProvincia";
                }
            }
        }

        private void MoverCmbCantones(string idCanton)
        {
            for (int i = 0; i < cmbCantones.Items.Count; i++)
            {
                if (cmbCantones.Items[i].ToString().Substring(0, 2) == idCanton)
                {
                    cmbCantones.SelectedIndex = i;
                    break;
                }
            }
        }

        // Procesos y funciones para consultar, cargar y mover el combobox de distritos 
        private string[] ConsultarDistritos(string idProvincia, string idCanton)
        {
            //Idealmente que la lista sea del tipo clase OpcionCombo que tenga 2 atributos: CodigoProvincia y NombreProvincia
            return new string[1];
        }

        private void CargarCmbDistritos(string[] listaDistritos)
        {
            cmbDistritos.Items.Clear();
            for (int i = 0; i < listaDistritos.Length; i++)
            {
                if (!string.IsNullOrEmpty(listaDistritos[i]))
                {
                    //cmbDistritos.Items.Add(listaDistritos[i]);
                    // Cargar el combo box con un DataSource
                    //cmbProvincias.DataSource = listaProvincias[i];
                    //cmbProvincias.DisplayMember = "NombreProvincia";
                    //cmbProvincias.ValueMember = "CodigoProvincia";
                }
            }
        }

        private void MoverCmbDistritos(string idDistrito)
        {
            for (int i = 0; i < cmbDistritos.Items.Count; i++)
            {
                if (cmbDistritos.Items[i].ToString().Substring(0, 3) == idDistrito)
                {
                    cmbDistritos.SelectedIndex = i;
                    break;
                }
            }
        }

        private void cmbProvincias_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtener el id de la provincia para cargar los cantones
            string idProvincia = cmbProvincias.SelectedItem.ToString().Substring(0, 1);
            string[] listaCantones = ConsultarCantones(idProvincia);
            CargarCmbCantones(listaCantones);
            MoverCmbCantones("01");
        }

        private void cmbCantones_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtener el id de la provincia y cantón para cargar los distritos
            string idProvincia = cmbProvincias.SelectedItem.ToString().Substring(0, 1);
            string idCanton = cmbCantones.SelectedItem.ToString().Substring(0, 2);

            string[] listaDistritos = ConsultarDistritos(idProvincia, idCanton);
            CargarCmbDistritos(listaDistritos);
            MoverCmbDistritos("001");
        }

        private void txtIdentificacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Validar que solo ingrese números o letras
            if (!char.IsLetter(e.KeyChar) || !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
