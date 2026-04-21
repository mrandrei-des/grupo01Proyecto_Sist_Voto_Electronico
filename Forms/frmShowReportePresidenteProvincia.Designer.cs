namespace grupo01ProyectoFinal.Forms
{
    partial class frmShowReportePresidenteProvincia
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
            this.dataSetReporteProvincia1 = new grupo01ProyectoFinal.DataSet_Reportes.DataSetReporteProvincia();
            this.sp_Reporte_Resultados_Presidente_x_ProvinciaTableAdapter1 = new grupo01ProyectoFinal.DataSet_Reportes.DataSetReporteProvinciaTableAdapters.sp_Reporte_Resultados_Presidente_x_ProvinciaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetReporteProvincia1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "grupo01ProyectoFinal.Reportes.ReportePresidenteProvincia.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 749);
            this.reportViewer1.TabIndex = 0;
            // 
            // dataSetReporteProvincia1
            // 
            this.dataSetReporteProvincia1.DataSetName = "DataSetReporteProvincia";
            this.dataSetReporteProvincia1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sp_Reporte_Resultados_Presidente_x_ProvinciaTableAdapter1
            // 
            this.sp_Reporte_Resultados_Presidente_x_ProvinciaTableAdapter1.ClearBeforeFill = true;
            // 
            // frmShowReportePresidenteProvincia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 749);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmShowReportePresidenteProvincia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte Presidente por Provincia";
            this.Load += new System.EventHandler(this.frmShowReportePresidenteProvincia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetReporteProvincia1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataSet_Reportes.DataSetReporteProvincia dataSetReporteProvincia1;
        private DataSet_Reportes.DataSetReporteProvinciaTableAdapters.sp_Reporte_Resultados_Presidente_x_ProvinciaTableAdapter sp_Reporte_Resultados_Presidente_x_ProvinciaTableAdapter1;
    }
}