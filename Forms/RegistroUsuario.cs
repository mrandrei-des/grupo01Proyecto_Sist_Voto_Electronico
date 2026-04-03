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
using mylibreria2026;

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

            MoverCmbProvincias("5");

            //string[] listaCantones = ConsultarCantones("1");
            //CargarCmbCantones(listaCantones);
            //MoverCmbCantones("01");

            //string[] listaDistritos = ConsultarDistritos("1", "01");
            //CargarCmbDistritos(listaDistritos);
            //MoverCmbDistritos("001");
        }

        private void CargarCmbProvincias()
        {
            cmbProvincias.Items.Clear();

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
            //for (int i = 0; i < cmbProvincias.Items.Count; i++)
            //{
            //    if (cmbProvincias.Items[i] == codigoProvincia)
            //    {
            //        cmbProvincias.SelectedIndex = i;
            //        break;
            //    }
            //}
        }

        private void CargarCmbCantones()
        {

            string CodigoProvincia = cmbProvincias.SelectedValue.ToString();

            cmbCantones.Items.Clear();

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

        private void CargarCmbDistritos()
        {
            string CodigoProvincia = cmbProvincias.SelectedValue.ToString();
            string CodigoCanton = cmbCantones.SelectedValue.ToString();

            cmbDistritos.Items.Clear();

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

        private void cmbProvincias_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtener el id de la provincia para cargar los cantones
            string idProvincia = cmbProvincias.SelectedItem.ToString();
            CargarCmbCantones();
        }

        private void cmbCantones_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtener el id de la provincia y cantón para cargar los distritos
            string idProvincia = cmbProvincias.SelectedValue.ToString();
            string idCanton = cmbCantones.SelectedValue.ToString();
            CargarCmbDistritos();
        }

        private void txtIdentificacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Validar que solo ingrese números o letras
            if (!char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
