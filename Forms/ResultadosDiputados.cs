using grupo01ProyectoFinal.Clases;
using mylibreria2026;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace grupo01ProyectoFinal.Forms
{
    public partial class frmResultadosDiputados : Form
    {
        public frmResultadosDiputados()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            try
            {
                double Cociente = 0, Subcociente = 0, Dividendo = 0;
                int DiputadosxProvincia = 0, DiputadosxResidual = 0, DiputadosAsignadosCociente = 0, DiputadosAsignadosCocienteTotal = 0;
                string codProvincia = cmbProvincias.SelectedValue.ToString();

                // 1. Consulta de cantidad de diputados por provincia
                Diputados_x_Provincia objDip_x_Provincia = new Diputados_x_Provincia();
                objDip_x_Provincia.CodProvincia = codProvincia;
                DiputadosxProvincia = objDip_x_Provincia.ConsultaCantidadDiputados_x_Provincia();

                // 2. Consulta de votos emitidos por partido excluyendo votos NULOS y en BLANCO
                DataSet ds = new DataSet();
                string cmd = "EXEC sp_Consulta_Resultados_CantidadVotosEmitidos";
                ds = Utilidades.Ejecutar(cmd);
                DataTable dt = ds.Tables[0];

                dgvVotosValidos.Rows.Clear();
                dgvVotosValidos.Columns.Clear();
                dgvVotosValidos.DataSource = dt;

                // 3. Cálculo del dividendo, sumatoria de votos válidos
                for (int i = 0; i < dt.Rows.Count; i++) {
                    Dividendo = Dividendo + Convert.ToInt32(dt.Rows[i]["CantidadVotosEmitidos"]);
                }

                // 4. Cálculo del Cociente
                Cociente = Math.Round(Dividendo / DiputadosxProvincia, 3);

                // 5. Cálculo del Subcociente
                Subcociente = Math.Round(Cociente / 2, 3);

                txtDividendo.Text = Dividendo.ToString();
                txtDiputados.Text = DiputadosxProvincia.ToString();
                txtCociente.Text = Cociente.ToString();
                txtSubcociente.Text = Subcociente.ToString();

                // 6. Eliminación de partidos con votos emitidos menores al subcociente
                DataTable dtResultadosSubcociente = dt.Clone();

                for (int i = 0;i < dt.Rows.Count;i++)
                {
                    DataRow dataRow = dt.NewRow();
                    dataRow = dt.Rows[i];

                    if (Convert.ToDouble(dataRow["CantidadVotosEmitidos"].ToString()) >= Subcociente)
                    {
                        dtResultadosSubcociente.ImportRow(dataRow);
                    }
                }

                dgvSubcociente.DataSource = dtResultadosSubcociente;

                // 7. Asignación de curules por cociente
                DiputadosxResidual = 0;
                DataTable dtAsignacionCociente = new DataTable();
                dtAsignacionCociente.Columns.Add("CodigoPartido");
                dtAsignacionCociente.Columns.Add("Descripcion");
                dtAsignacionCociente.Columns.Add("CantidadVotosEmitidos");
                dtAsignacionCociente.Columns.Add("CifraCociente");
                dtAsignacionCociente.Columns.Add("CalculoCociente");
                dtAsignacionCociente.Columns.Add("DiputadosxCalculo");

                for (int i = 0; i < dtResultadosSubcociente.Rows.Count; i++) {
                    DataRow filaSubcociente = dtResultadosSubcociente.NewRow();
                    filaSubcociente = dtResultadosSubcociente.Rows[i];
                    DataRow filaCalculo = dtAsignacionCociente.NewRow();

                    filaCalculo["CodigoPartido"] = filaSubcociente[0];
                    filaCalculo["Descripcion"] = filaSubcociente[1];
                    filaCalculo["CantidadVotosEmitidos"] = filaSubcociente[2];
                    filaCalculo["CifraCociente"] = Cociente;
                    filaCalculo["CalculoCociente"] = Math.Round(Convert.ToInt32(filaSubcociente[2].ToString()) / Cociente, 3);

                    DiputadosAsignadosCociente = Convert.ToInt32(Math.Round(Convert.ToInt32(filaSubcociente[2].ToString()) / Cociente, 0));
                    DiputadosAsignadosCocienteTotal = DiputadosAsignadosCocienteTotal + DiputadosAsignadosCociente;

                    filaCalculo["DiputadosxCalculo"] = DiputadosAsignadosCociente;

                    dtAsignacionCociente.Rows.Add(filaCalculo);
                }

                dgvAsignacionCociente.DataSource= dtAsignacionCociente;
                txtDiputadosAsignados.Text = DiputadosAsignadosCocienteTotal.ToString();
                DiputadosxResidual = DiputadosxProvincia - DiputadosAsignadosCocienteTotal;
                txtDiputadosxAsignar.Text = DiputadosxResidual.ToString();

                DataTable dtCalculoResiduo = new DataTable();
                dtCalculoResiduo.Columns.Add("PartidoPolitico");
                dtCalculoResiduo.Columns.Add("CantidadVotosEmitidos");
                dtCalculoResiduo.Columns.Add("CifraCociente");
                dtCalculoResiduo.Columns.Add("CifraResidual");
                dtCalculoResiduo.Columns.Add("EscanosCociente");

                DataTable dtAsignacionResiduo = new DataTable();
                dtAsignacionResiduo.Columns.Add("PartidoPolitico");
                dtAsignacionResiduo.Columns.Add("CantidadVotosEmitidos");
                dtAsignacionResiduo.Columns.Add("CifraCociente");
                dtAsignacionResiduo.Columns.Add("CifraResidual");
                dtAsignacionResiduo.Columns.Add("EscanosResidual");

                if (DiputadosxResidual > 0)
                {
                    // 8.1 Cálculo de cifras residuales

                    for (int i = 0; i < dtAsignacionCociente.Rows.Count; i++)
                    {
                        DataRow filaAsignaCociente = dtAsignacionCociente.NewRow();
                        filaAsignaCociente = dtAsignacionCociente.Rows[i];

                        DataRow filaCifra = dtCalculoResiduo.NewRow();
                        filaCifra["PartidoPolitico"] = filaAsignaCociente[0];
                        filaCifra["CantidadVotosEmitidos"] = filaAsignaCociente[2];

                        if(Convert.ToInt32(filaAsignaCociente[5].ToString()) > 0)
                        {
                            int cantVotosEmitidos = Convert.ToInt32(filaAsignaCociente[2].ToString());
                            double cifraCociente = Convert.ToDouble(filaAsignaCociente[3].ToString());
                            int cantCociente = Convert.ToInt32(filaAsignaCociente[5].ToString());

                            filaCifra["CifraCociente"] = (cantCociente * cifraCociente);
                            filaCifra["CifraResidual"] = (cantVotosEmitidos - (cantCociente * cifraCociente));
                        }
                        else {
                            filaCifra["CifraCociente"] = 0;
                            filaCifra["CifraResidual"] = Convert.ToInt32(filaAsignaCociente[2].ToString());
                        }                        

                        filaCifra["EscanosCociente"] = filaAsignaCociente[5];

                        dtCalculoResiduo.Rows.Add(filaCifra);
                    }

                    // 8.2 Ordenamiento cálculos de residuos
                    DataView dv = new DataView(dtCalculoResiduo);
                    dv.Sort = "CifraResidual DESC";

                    DataTable dtOrdenado = dv.ToTable();
                    dgvCalculoResiduo.DataSource = dtCalculoResiduo;

                    for (int i = 0; i < dtOrdenado.Rows.Count; i++)
                    {
                        DataRow filaCalResiduo = dtOrdenado.NewRow();
                        filaCalResiduo = dtOrdenado.Rows[i];

                        DataRow filaNewResiduo = dtAsignacionResiduo.NewRow();
                        filaNewResiduo["PartidoPolitico"] = filaCalResiduo[0];
                        filaNewResiduo["CantidadVotosEmitidos"] = filaCalResiduo[1];
                        filaNewResiduo["CifraCociente"] = filaCalResiduo[2];
                        filaNewResiduo["CifraResidual"] = filaCalResiduo[3];
                        filaNewResiduo["EscanosResidual"] = 0;
                        dtAsignacionResiduo.Rows.Add(filaNewResiduo);
                    }

                    while (DiputadosxResidual > 0)
                    {
                        for (int i = 0; i < dtAsignacionResiduo.Rows.Count; i++) {
                            
                            if(DiputadosxResidual == 0)
                            {
                                break;
                            }
                            dtAsignacionResiduo.Rows[i]["EscanosResidual"] =  Convert.ToInt32(dtAsignacionResiduo.Rows[i]["EscanosResidual"]) + 1;
                            DiputadosxResidual = DiputadosxResidual - 1;
                        }
                    }

                    dgvAsignacionResiduo.DataSource = dtAsignacionResiduo;
                }

                DataTable dtResultadosFinales = new DataTable();
                dtResultadosFinales.Columns.Add("PartidoPolitico");
                dtResultadosFinales.Columns.Add("CantidadVotosEmitidos");
                dtResultadosFinales.Columns.Add("EscanosCociente");
                dtResultadosFinales.Columns.Add("EscanosResiduo");
                dtResultadosFinales.Columns.Add("TotalEscanos");

                // Obtener datos de la asignación por cociente
                for (int i = 0; i < dtAsignacionCociente.Rows.Count; i++) {
                    DataRow filaCociente = dtAsignacionCociente.NewRow();
                    filaCociente = dtAsignacionCociente.Rows[i];

                    DataRow filaResultado = dtResultadosFinales.NewRow();
                    filaResultado["PartidoPolitico"] = filaCociente[0];
                    filaResultado["CantidadVotosEmitidos"] = Convert.ToInt32(filaCociente[2].ToString());
                    filaResultado["EscanosCociente"] = Convert.ToInt32(filaCociente[5].ToString());
                    filaResultado["EscanosResiduo"] = 0;
                    filaResultado["TotalEscanos"] = Convert.ToInt32(filaCociente[5].ToString());

                    dtResultadosFinales.Rows.Add(filaResultado);
                }

                if(dtAsignacionResiduo.Rows.Count > 0)
                {
                    // Obtener datos de la asignación por residuo

                    for (int i = 0; i < dtAsignacionResiduo.Rows.Count; i++)
                    {
                        DataRow filaResiduo = dtAsignacionResiduo.NewRow();
                        filaResiduo = dtAsignacionResiduo.Rows[i];

                        for (int j = 0; j < dtResultadosFinales.Rows.Count; j++) {
                            if (filaResiduo[0].ToString() == dtResultadosFinales.Rows[j]["PartidoPolitico"].ToString())
                            {
                                int totalEscanos = Convert.ToInt32(dtResultadosFinales.Rows[j]["TotalEscanos"].ToString());  
                                int escanosResiduo = Convert.ToInt32(filaResiduo[4].ToString());

                                dtResultadosFinales.Rows[j]["EscanosResiduo"] = escanosResiduo;
                                dtResultadosFinales.Rows[j]["TotalEscanos"] = totalEscanos + escanosResiduo;
                                break;
                            }
                        }
                    }
                }

                dgvResultadosMomentaneos.DataSource = dtResultadosFinales;
            }
            catch (Exception ex) {
                MessageBox.Show("Ha ocurrido un error durante el cálculo de los curules por partido político. [" + ex.Message + "]", "Cálculo Curules", MessageBoxButtons.OK, MessageBoxIcon.Hand);
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

        private void frmResultadosDiputados_Load(object sender, EventArgs e)
        {
            CargarCmbProvincias();
        }
    }
}
