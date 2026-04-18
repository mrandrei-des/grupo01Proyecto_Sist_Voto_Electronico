using System.Drawing;

namespace grupo01ProyectoFinal
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aVotacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bPresidencialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bDiputacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aIngresar = new System.Windows.Forms.ToolStripMenuItem();
            this.aMesaVotacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aMantenimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bMantPadronNacionalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bMantDistritoElectoralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aEstadisticasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bEstadisticasPorProvinciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bEstadisticasPorCandidatoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aReportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bReportePorProvinciastoolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bReportePorCandidatoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.resultadosDiputadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aAcercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aArchivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bCerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bSalirDelSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aVotacionToolStripMenuItem,
            this.aIngresar,
            this.aMesaVotacionToolStripMenuItem,
            this.aMantenimientosToolStripMenuItem,
            this.aEstadisticasToolStripMenuItem,
            this.aReportesToolStripMenuItem,
            this.aAcercaDeToolStripMenuItem,
            this.aArchivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1022, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // aVotacionToolStripMenuItem
            // 
            this.aVotacionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bPresidencialToolStripMenuItem,
            this.bDiputacionToolStripMenuItem});
            this.aVotacionToolStripMenuItem.Name = "aVotacionToolStripMenuItem";
            this.aVotacionToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.aVotacionToolStripMenuItem.Text = "Votación";
            // 
            // bPresidencialToolStripMenuItem
            // 
            this.bPresidencialToolStripMenuItem.Name = "bPresidencialToolStripMenuItem";
            this.bPresidencialToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.bPresidencialToolStripMenuItem.Text = "Presidencial";
            this.bPresidencialToolStripMenuItem.Click += new System.EventHandler(this.bPresidencialToolStripMenuItem_Click_1);
            // 
            // bDiputacionToolStripMenuItem
            // 
            this.bDiputacionToolStripMenuItem.Name = "bDiputacionToolStripMenuItem";
            this.bDiputacionToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.bDiputacionToolStripMenuItem.Text = "Diputación";
            this.bDiputacionToolStripMenuItem.Click += new System.EventHandler(this.bDiputacionToolStripMenuItem_Click_1);
            // 
            // aIngresar
            // 
            this.aIngresar.Name = "aIngresar";
            this.aIngresar.Size = new System.Drawing.Size(61, 20);
            this.aIngresar.Text = "Ingresar";
            this.aIngresar.Click += new System.EventHandler(this.aIngresar_Click);
            // 
            // aMesaVotacionToolStripMenuItem
            // 
            this.aMesaVotacionToolStripMenuItem.Name = "aMesaVotacionToolStripMenuItem";
            this.aMesaVotacionToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.aMesaVotacionToolStripMenuItem.Text = "Mesa de Votación";
            this.aMesaVotacionToolStripMenuItem.Click += new System.EventHandler(this.aMesaVotacionToolStripMenuItem_Click);
            // 
            // aMantenimientosToolStripMenuItem
            // 
            this.aMantenimientosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bMantPadronNacionalToolStripMenuItem,
            this.bMantDistritoElectoralToolStripMenuItem});
            this.aMantenimientosToolStripMenuItem.Name = "aMantenimientosToolStripMenuItem";
            this.aMantenimientosToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.aMantenimientosToolStripMenuItem.Text = "Mantenimientos";
            // 
            // bMantPadronNacionalToolStripMenuItem
            // 
            this.bMantPadronNacionalToolStripMenuItem.Name = "bMantPadronNacionalToolStripMenuItem";
            this.bMantPadronNacionalToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.bMantPadronNacionalToolStripMenuItem.Text = "Padrón Nacional";
            this.bMantPadronNacionalToolStripMenuItem.Click += new System.EventHandler(this.bMantPadronNacionalToolStripMenuItem_Click_1);
            // 
            // bMantDistritoElectoralToolStripMenuItem
            // 
            this.bMantDistritoElectoralToolStripMenuItem.Name = "bMantDistritoElectoralToolStripMenuItem";
            this.bMantDistritoElectoralToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.bMantDistritoElectoralToolStripMenuItem.Text = "Distrito Electoral";
            this.bMantDistritoElectoralToolStripMenuItem.Click += new System.EventHandler(this.bMantDistritoElectoralToolStripMenuItem_Click_1);
            // 
            // aEstadisticasToolStripMenuItem
            // 
            this.aEstadisticasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bEstadisticasPorProvinciaToolStripMenuItem,
            this.bEstadisticasPorCandidatoToolStripMenuItem});
            this.aEstadisticasToolStripMenuItem.Name = "aEstadisticasToolStripMenuItem";
            this.aEstadisticasToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.aEstadisticasToolStripMenuItem.Text = "Estadísticas";
            // 
            // bEstadisticasPorProvinciaToolStripMenuItem
            // 
            this.bEstadisticasPorProvinciaToolStripMenuItem.Name = "bEstadisticasPorProvinciaToolStripMenuItem";
            this.bEstadisticasPorProvinciaToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.bEstadisticasPorProvinciaToolStripMenuItem.Text = "Por Provincia";
            this.bEstadisticasPorProvinciaToolStripMenuItem.Click += new System.EventHandler(this.bEstadisticasPorProvinciaToolStripMenuItem_Click);
            // 
            // bEstadisticasPorCandidatoToolStripMenuItem
            // 
            this.bEstadisticasPorCandidatoToolStripMenuItem.Name = "bEstadisticasPorCandidatoToolStripMenuItem";
            this.bEstadisticasPorCandidatoToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.bEstadisticasPorCandidatoToolStripMenuItem.Text = "Por Candidato";
            this.bEstadisticasPorCandidatoToolStripMenuItem.Click += new System.EventHandler(this.bEstadisticasPorCandidatoToolStripMenuItem_Click);
            // 
            // aReportesToolStripMenuItem
            // 
            this.aReportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bReportePorProvinciastoolStripMenuItem1,
            this.bReportePorCandidatoToolStripMenuItem1,
            this.resultadosDiputadosToolStripMenuItem});
            this.aReportesToolStripMenuItem.Name = "aReportesToolStripMenuItem";
            this.aReportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.aReportesToolStripMenuItem.Text = "Reportes";
            // 
            // bReportePorProvinciastoolStripMenuItem1
            // 
            this.bReportePorProvinciastoolStripMenuItem1.Name = "bReportePorProvinciastoolStripMenuItem1";
            this.bReportePorProvinciastoolStripMenuItem1.Size = new System.Drawing.Size(188, 22);
            this.bReportePorProvinciastoolStripMenuItem1.Text = "Por Provincia";
            this.bReportePorProvinciastoolStripMenuItem1.Click += new System.EventHandler(this.bReportePorProvinciastoolStripMenuItem1_Click);
            // 
            // bReportePorCandidatoToolStripMenuItem1
            // 
            this.bReportePorCandidatoToolStripMenuItem1.Name = "bReportePorCandidatoToolStripMenuItem1";
            this.bReportePorCandidatoToolStripMenuItem1.Size = new System.Drawing.Size(188, 22);
            this.bReportePorCandidatoToolStripMenuItem1.Text = "Por Candidato";
            this.bReportePorCandidatoToolStripMenuItem1.Click += new System.EventHandler(this.bReportePorCandidatoToolStripMenuItem1_Click);
            // 
            // resultadosDiputadosToolStripMenuItem
            // 
            this.resultadosDiputadosToolStripMenuItem.Name = "resultadosDiputadosToolStripMenuItem";
            this.resultadosDiputadosToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.resultadosDiputadosToolStripMenuItem.Text = "Resultados Diputados";
            this.resultadosDiputadosToolStripMenuItem.Click += new System.EventHandler(this.resultadosDiputadosToolStripMenuItem_Click);
            // 
            // aAcercaDeToolStripMenuItem
            // 
            this.aAcercaDeToolStripMenuItem.Name = "aAcercaDeToolStripMenuItem";
            this.aAcercaDeToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.aAcercaDeToolStripMenuItem.Text = "Acerca De";
            this.aAcercaDeToolStripMenuItem.Click += new System.EventHandler(this.aAcercaDeToolStripMenuItem_Click);
            // 
            // aArchivoToolStripMenuItem
            // 
            this.aArchivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bCerrarSesionToolStripMenuItem,
            this.bSalirDelSistemaToolStripMenuItem});
            this.aArchivoToolStripMenuItem.Name = "aArchivoToolStripMenuItem";
            this.aArchivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.aArchivoToolStripMenuItem.Text = "Archivo";
            // 
            // bCerrarSesionToolStripMenuItem
            // 
            this.bCerrarSesionToolStripMenuItem.Name = "bCerrarSesionToolStripMenuItem";
            this.bCerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.bCerrarSesionToolStripMenuItem.Text = "Cerrar Sesión";
            this.bCerrarSesionToolStripMenuItem.Click += new System.EventHandler(this.bCerrarSesionToolStripMenuItem_Click);
            // 
            // bSalirDelSistemaToolStripMenuItem
            // 
            this.bSalirDelSistemaToolStripMenuItem.Name = "bSalirDelSistemaToolStripMenuItem";
            this.bSalirDelSistemaToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.bSalirDelSistemaToolStripMenuItem.Text = "Salir del Sistema";
            this.bSalirDelSistemaToolStripMenuItem.Click += new System.EventHandler(this.bSalirDelSistemaToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1022, 605);
            this.ControlBox = false;
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Voto Electrónico";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem aIngresar;
        private System.Windows.Forms.ToolStripMenuItem aVotacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aMesaVotacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aEstadisticasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aAcercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aArchivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bMantPadronNacionalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bMantDistritoElectoralToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bCerrarSesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bSalirDelSistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bEstadisticasPorProvinciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bEstadisticasPorCandidatoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bPresidencialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bDiputacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bReportePorProvinciastoolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem bReportePorCandidatoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem resultadosDiputadosToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem aReportesToolStripMenuItem;
        public System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem aMantenimientosToolStripMenuItem;
    }
}

