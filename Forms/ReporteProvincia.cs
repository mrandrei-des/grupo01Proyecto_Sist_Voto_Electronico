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
            rdoTipoVotacionPresidente.Checked = true;
            cmbProvincias.SelectedIndex = 0;
        }

        private void CargarComboProvincias()
        {
            string cmd = "SELECT CodigoProvincia as Valor, Descripcion as Texto FROM Provincias ORDER BY CodigoProvincia ASC";
            DataSet ds = new DataSet();

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
