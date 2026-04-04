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
            CargarComboProvincia();
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
                //string codigoProvincia = cmbProvincias.Text;
                string provinciaBuscar = cmbProvincias.SelectedValue.ToString();
                string cmd = "";


                if (!string.IsNullOrEmpty(identificacionBuscar))
                {
                    // Busca la información por cédula
                    cmd = string.Format("EXEC sp_Consulta_PadronNacional_x_Cedula '{0}'", identificacionBuscar);
                }
                else
                {
                    // Busca la información por provincia
                    cmd = string.Format("EXEC sp_Consulta_PadronNacional_x_Provincia '{0}'", provinciaBuscar);
                }

                ds = Utilidades.Ejecutar(cmd);

                if (ds.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("No se encontraron registros en el padrón nacional.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }else
                {
                    dgvPadronNacional.DataSource = ds.Tables[0].DefaultView;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un problema al momento de consultar en el padrón nacional. [001][" + ex.Message + "]", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void CargarComboProvincia()
        {
            CargarCmbProvincias();
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
