using grupo01ProyectoFinal.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace grupo01ProyectoFinal
{
    public partial class frmMantDist : Form
    {
        public string CedulaUsuario = string.Empty;
        private DataSet dsConsulta = new DataSet();

        public frmMantDist()
        {
            InitializeComponent();
        }        

        private void frmMantDist_Load(object sender, EventArgs e)
        {
            CargarComboBoxes();
        }

        private void CargarComboBoxes()
        {
            CargarCmbProvincias();
            CargarCmbCantones("1");
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
                cmbProvincias.SelectedIndex = 0;
            }
        }

        private void CargarCmbCantones(string codigoProvincia)
        {
            Canton objCanton = new Canton();
            objCanton.CodProvincia = codigoProvincia;
            DataTable dtCantones = objCanton.Listar();
            if (dtCantones.Rows.Count > 0)
            {
                cmbCantones.DataSource = dtCantones;
                cmbCantones.DisplayMember = "Texto";
                cmbCantones.ValueMember = "Valor";
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            frmPrincipal formPrincipal = new frmPrincipal();
            formPrincipal.cedulaUsuarioLoggeado = CedulaUsuario;
            formPrincipal.Show();
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            txtCodigoDist.Clear();
            cmbProvincias.SelectedIndex = 0;
            CargarCmbCantones("1");
            txtCodigoDist.Focus();
            dsConsulta.Clear();
            dgvCodigoElectoral.DataSource = dsConsulta;
        }

        private void txtCodigoDist_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Validar que solo ingrese números y máximo 6
            if (!char.IsDigit(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Enter))
            {
                e.Handled = true;
            }
            
            if((e.KeyChar == (char)Keys.Back))
            {
                e.Handled = false;
            }else
            {
                if (txtCodigoDist.Text.Trim().Length >= 6)
                {
                    e.Handled= true;
                }
            }

            if((e.KeyChar == (char)Keys.Enter))
            {
                ConsultaDistritoElectoral(txtCodigoDist.Text.Trim(), "", "");
                cmbProvincias.SelectedIndex = 0;
                cmbCantones.SelectedIndex = 0;
            }
        }

        private void ConsultaDistritoElectoral(string codigoElectoral = "", string provinciaBuscar = "", string cantonBuscar = "")
        {
            try
            {
                DataTable dtDistritos = new DataTable();
                DistritoElectoral objDistrito = new DistritoElectoral();
                objDistrito.CodigoElectoral = codigoElectoral;
                objDistrito.CodigoProvincia = provinciaBuscar;
                objDistrito.CodigoCanton = cantonBuscar;

                if (!string.IsNullOrEmpty(codigoElectoral))
                {
                    // Busca la información por código de distrito
                    dtDistritos = objDistrito.Consultar_x_CodigoElectoral();
                }
                else if(!string.IsNullOrEmpty(provinciaBuscar) && string.IsNullOrEmpty(cantonBuscar))
                {
                    // Busca la información por solo provincia
                    dtDistritos = objDistrito.Consultar_x_Provincia();
                }
                else
                {
                    // Busca la información por provincia y cantón
                    dtDistritos = objDistrito.Consultar_x_Canton();
                }

                if (dtDistritos.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontraron registros en el Distrito Electoral.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    dgvCodigoElectoral.DataSource = dtDistritos.DefaultView;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un problema al momento de consultar en el Distrito Electoral. [001][" + ex.Message + "]", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cmbProvincias_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string codigoProvincia = cmbProvincias.SelectedValue.ToString();
            CargarCmbCantones(codigoProvincia);
            ConsultaDistritoElectoral("", codigoProvincia, "");
            txtCodigoDist.Clear();
        }

        private void cmbCantones_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string codigoProvincia = cmbProvincias.SelectedValue.ToString();
            string codigoCanton = cmbCantones.SelectedValue.ToString();
            ConsultaDistritoElectoral("", codigoProvincia, codigoCanton);
            txtCodigoDist.Clear();
        }
    }
}
