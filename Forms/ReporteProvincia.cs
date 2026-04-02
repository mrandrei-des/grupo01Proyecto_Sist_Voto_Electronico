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
    public partial class frmReporteProvincia : Form
    {
        public frmReporteProvincia()
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
            Limpiar();
        }

        private void Limpiar()
        {
            //cmbProvincias.SelectedIndex = 0;
            rdoTipoVotacionPresidente.Checked = true;
        }

        private void CargarComboProvincias()
        {
            //Idealmente que la lista sea del tipo clase OpcionCombo que tenga 2 atributos: CodigoProvincia y NombreProvincia
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
                    //cmbProvincias.Items.Add(listaProvincias[i]);
                    // Cargar el combo box con un DataSource
                    //cmbProvincias.DataSource = listaProvincias[i];
                    //cmbProvincias.DisplayMember = "NombreProvincia";
                    //cmbProvincias.ValueMember = "CodigoProvincia";
                }
            }
        }

        private void frmReporteProvincia_Load(object sender, EventArgs e)
        {
            CargarComboProvincias();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            string codigoProvincia = ""; //cmbProvincias.SelectedValue.ToString();
            string tipoVotacion = "Diputado";

            if(rdoTipoVotacionPresidente.Checked)
            {
                tipoVotacion = "Presidente";
            }

            GenerarReporteProvincia(tipoVotacion, codigoProvincia);
        }

        private void GenerarReporteProvincia(string tipoVotacion, string codigoProvincia)
        {
            //Consulta la base de datos para obtener el número de votantes por cada provincia
            //Hay que estudiar la posibilida de traer la cantidad de votos por cada partido político
        }
    }
}
