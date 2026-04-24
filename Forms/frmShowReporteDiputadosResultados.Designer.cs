namespace grupo01ProyectoFinal.Forms
{
    partial class frmShowReporteDiputadosResultados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataSetResultadosDiputados1 = new grupo01ProyectoFinal.DataSet_Reportes.DataSetResultadosDiputados();
            this.sp_Consulta_Resultados_Diputados_x_ProvinciaTableAdapter1 = new grupo01ProyectoFinal.DataSet_Reportes.DataSetResultadosDiputadosTableAdapters.sp_Consulta_Resultados_Diputados_x_ProvinciaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetResultadosDiputados1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "grupo01ProyectoFinal.Reportes.ReporteResultadosDiputados.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 739);
            this.reportViewer1.TabIndex = 0;
            // 
            // dataSetResultadosDiputados1
            // 
            this.dataSetResultadosDiputados1.DataSetName = "DataSetResultadosDiputados";
            this.dataSetResultadosDiputados1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sp_Consulta_Resultados_Diputados_x_ProvinciaTableAdapter1
            // 
            this.sp_Consulta_Resultados_Diputados_x_ProvinciaTableAdapter1.ClearBeforeFill = true;
            // 
            // frmShowReporteDiputadosResultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 739);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmShowReporteDiputadosResultados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte Diputados Resultados";
            this.Load += new System.EventHandler(this.frmShowReporteDiputadosResultados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetResultadosDiputados1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataSet_Reportes.DataSetResultadosDiputados dataSetResultadosDiputados1;
        private DataSet_Reportes.DataSetResultadosDiputadosTableAdapters.sp_Consulta_Resultados_Diputados_x_ProvinciaTableAdapter sp_Consulta_Resultados_Diputados_x_ProvinciaTableAdapter1;
    }
}