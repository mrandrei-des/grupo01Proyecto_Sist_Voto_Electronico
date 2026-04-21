namespace grupo01ProyectoFinal.Forms
{
    partial class frmShowEstadisticasPresidencialProvincia
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
            this.sp_Reporte_Resultados_Presidente_x_ProvinciaTableAdapter1 = new grupo01ProyectoFinal.DataSet_Reportes.DataSetReporteProvinciaTableAdapters.sp_Reporte_Resultados_Presidente_x_ProvinciaTableAdapter();
            this.dataSetReporteProvincia1 = new grupo01ProyectoFinal.DataSet_Reportes.DataSetReporteProvincia();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetReporteProvincia1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "grupo01ProyectoFinal.Reportes.EstadisticasPresidenteProvincia.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 843);
            this.reportViewer1.TabIndex = 0;
            // 
            // sp_Reporte_Resultados_Presidente_x_ProvinciaTableAdapter1
            // 
            this.sp_Reporte_Resultados_Presidente_x_ProvinciaTableAdapter1.ClearBeforeFill = true;
            // 
            // dataSetReporteProvincia1
            // 
            this.dataSetReporteProvincia1.DataSetName = "DataSetReporteProvincia";
            this.dataSetReporteProvincia1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frmShowEstadisticasPresidencialProvincia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 843);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmShowEstadisticasPresidencialProvincia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estadísticas Votaciones Presidencial por Provincia";
            this.Load += new System.EventHandler(this.frmShowReportePresidencialProvincia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetReporteProvincia1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataSet_Reportes.DataSetReporteProvinciaTableAdapters.sp_Reporte_Resultados_Presidente_x_ProvinciaTableAdapter sp_Reporte_Resultados_Presidente_x_ProvinciaTableAdapter1;
        private DataSet_Reportes.DataSetReporteProvincia dataSetReporteProvincia1;
    }
}