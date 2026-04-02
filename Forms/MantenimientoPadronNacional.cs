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
        public frmMantPadronNacional()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMantPadronNacional_Load(object sender, EventArgs e)
        {
            CargarComboProvincia();
            CargarDataGridView();
            txtIdentificacion.Focus();
        }

        private void CargarDataGridView()
        {
            // Cargar el DataGridView con la información del padrón nacional
        }

        private void CargarComboProvincia()
        {
            //Idealmente que la lista sea del tipo OpcionCombo que tenga 2 atributos: CodigoProvincia y NombreProvincia
            string[] listaProvincias = ConsultarProvincias();
            CargarCmbProvincias(listaProvincias);
        }

        // Procesos y funciones para consultar, cargar y mover el combobox de provincias
        private string[] ConsultarProvincias()
        {
            return new string[1];
        }

        private void CargarCmbProvincias(string[] listaProvincias)
        {
            cmbProvincias.Items.Clear();
            for (int i = 0; i < listaProvincias.Length; i++)
            {

                if (!string.IsNullOrEmpty(listaProvincias[i]))
                {
                    // Cargar el combo box con un DataSource
                    //cmbProvincias.DataSource = listaProvincias[i];
                    //cmbProvincias.DisplayMember = "NombreProvincia";
                    //cmbProvincias.ValueMember = "CodigoProvincia";
                }
            }
        }

        private void cmbProvincias_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtIdentificacion.Clear();
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            string identificacionBuscar = txtIdentificacion.Text;
            //string provinciaBuscar = cmbProvincias.SelectedValue;

            if(!string.IsNullOrEmpty(identificacionBuscar))
            {
                // Busca la información por cédula
            }else
            {
                // Busca la información por provincia
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            txtIdentificacion.Clear();
            //cmbProvincias.SelectedIndex = 0;
            txtIdentificacion.Focus();
            //dgvPadronNacional.DataSource = null;
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
