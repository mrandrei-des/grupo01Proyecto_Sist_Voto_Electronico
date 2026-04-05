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

namespace grupo01ProyectoFinal.Forms
{
    public partial class frmMantPadronNacional : Form
    {
        DataSet ds = new DataSet();
        public frmMantPadronNacional()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            frmPrincipal formPrincipal = new frmPrincipal();
            formPrincipal.Show();
            this.Close();
        }

        private void frmMantPadronNacional_Load(object sender, EventArgs e)
        {
            CargarCmbProvincias();
            txtIdentificacion.Focus();
        }

        private void cmbProvincias_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtIdentificacion.Clear();
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            ConsultarPadronNacional();
        }        

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }        

        private void txtIdentificacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Validar que solo ingrese números o letras
            if (!char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void ConsultarPadronNacional()
        {
            try
            {
                string identificacionBuscar = txtIdentificacion.Text;
                string provinciaBuscar = cmbProvincias.SelectedValue.ToString();
                DataTable dtPadron = new DataTable();
                PadronNacional objPadron = new PadronNacional();

                if (!string.IsNullOrEmpty(identificacionBuscar))
                {
                    // Busca la información por cédula
                    objPadron.Cedula = identificacionBuscar;
                    dtPadron = objPadron.Listar_x_Cedula();
                }
                else
                {
                    // Busca la información por provincia
                    dtPadron = objPadron.Listar_x_Provincia(provinciaBuscar);
                }

                if (dtPadron.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontraron registros en el padrón nacional.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }else
                {
                    dgvPadronNacional.DataSource = dtPadron.DefaultView;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un problema al momento de consultar en el padrón nacional. [001][" + ex.Message + "]", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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

        private void Limpiar()
        {
            txtIdentificacion.Clear();
            cmbProvincias.SelectedIndex = 0;
            txtIdentificacion.Focus();
            ds.Clear();
            dgvPadronNacional.DataSource = ds;
        }
    }

}
