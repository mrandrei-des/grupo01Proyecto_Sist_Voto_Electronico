namespace grupo01ProyectoFinal.Forms
{
    partial class frmShowReporteCandidato
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
            this.sp_Reporte_Resultados_Presidente_x_PartidoTableAdapter1 = new grupo01ProyectoFinal.DataSet_Reportes.DataSetReporteCandidatoTableAdapters.sp_Reporte_Resultados_Presidente_x_PartidoTableAdapter();
            this.dataSetReporteCandidato1 = new grupo01ProyectoFinal.DataSet_Reportes.DataSetReporteCandidato();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetReporteCandidato1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "grupo01ProyectoFinal.Reportes.ReporteCandidato.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 663);
            this.reportViewer1.TabIndex = 0;
            // 
            // sp_Reporte_Resultados_Presidente_x_PartidoTableAdapter1
            // 
            this.sp_Reporte_Resultados_Presidente_x_PartidoTableAdapter1.ClearBeforeFill = true;
            // 
            // dataSetReporteCandidato1
            // 
            this.dataSetReporteCandidato1.DataSetName = "DataSetReporteCandidato";
            this.dataSetReporteCandidato1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frmShowReporteCandidato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 663);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmShowReporteCandidato";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte Resultados por Candidato";
            this.Load += new System.EventHandler(this.frmShowReporteCandidato_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetReporteCandidato1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataSet_Reportes.DataSetReporteCandidatoTableAdapters.sp_Reporte_Resultados_Presidente_x_PartidoTableAdapter sp_Reporte_Resultados_Presidente_x_PartidoTableAdapter1;
        private DataSet_Reportes.DataSetReporteCandidato dataSetReporteCandidato1;
    }
}