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
            this.tsmIngresar = new System.Windows.Forms.ToolStripMenuItem();
            this.aRegistroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aMesaVotacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aMantenimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bMantPadronNacionalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bMantDistritoElectoralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bMantCandidatosPoliticosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bMantPartidosPoliticosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bMantTipoEleccionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cMantPresidencialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cMantDiputacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aEstadisticasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aReportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.tsmIngresar,
            this.aRegistroToolStripMenuItem,
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
            // 
            // aVotacionToolStripMenuItem
            // 
            this.aVotacionToolStripMenuItem.Name = "aVotacionToolStripMenuItem";
            this.aVotacionToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.aVotacionToolStripMenuItem.Text = "Votación";
            this.aVotacionToolStripMenuItem.Click += new System.EventHandler(this.aVotacionToolStripMenuItem_Click);
            // 
            // tsmIngresar
            // 
            this.tsmIngresar.Name = "tsmIngresar";
            this.tsmIngresar.Size = new System.Drawing.Size(61, 20);
            this.tsmIngresar.Text = "Ingresar";
            this.tsmIngresar.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // aRegistroToolStripMenuItem
            // 
            this.aRegistroToolStripMenuItem.Name = "aRegistroToolStripMenuItem";
            this.aRegistroToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.aRegistroToolStripMenuItem.Text = "Registro";
            this.aRegistroToolStripMenuItem.Click += new System.EventHandler(this.aRegistroToolStripMenuItem_Click);
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
            this.bMantDistritoElectoralToolStripMenuItem,
            this.bMantCandidatosPoliticosToolStripMenuItem,
            this.bMantPartidosPoliticosToolStripMenuItem,
            this.bMantTipoEleccionToolStripMenuItem});
            this.aMantenimientosToolStripMenuItem.Name = "aMantenimientosToolStripMenuItem";
            this.aMantenimientosToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.aMantenimientosToolStripMenuItem.Text = "Mantenimientos";
            // 
            // bMantPadronNacionalToolStripMenuItem
            // 
            this.bMantPadronNacionalToolStripMenuItem.Name = "bMantPadronNacionalToolStripMenuItem";
            this.bMantPadronNacionalToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.bMantPadronNacionalToolStripMenuItem.Text = "Padrón Nacional";
            // 
            // bMantDistritoElectoralToolStripMenuItem
            // 
            this.bMantDistritoElectoralToolStripMenuItem.Name = "bMantDistritoElectoralToolStripMenuItem";
            this.bMantDistritoElectoralToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.bMantDistritoElectoralToolStripMenuItem.Text = "Distrito Electoral";
            // 
            // bMantCandidatosPoliticosToolStripMenuItem
            // 
            this.bMantCandidatosPoliticosToolStripMenuItem.Name = "bMantCandidatosPoliticosToolStripMenuItem";
            this.bMantCandidatosPoliticosToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.bMantCandidatosPoliticosToolStripMenuItem.Text = "Candidatos";
            // 
            // bMantPartidosPoliticosToolStripMenuItem
            // 
            this.bMantPartidosPoliticosToolStripMenuItem.Name = "bMantPartidosPoliticosToolStripMenuItem";
            this.bMantPartidosPoliticosToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.bMantPartidosPoliticosToolStripMenuItem.Text = "Partidos Políticos";
            // 
            // bMantTipoEleccionToolStripMenuItem
            // 
            this.bMantTipoEleccionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cMantPresidencialToolStripMenuItem,
            this.cMantDiputacionToolStripMenuItem});
            this.bMantTipoEleccionToolStripMenuItem.Name = "bMantTipoEleccionToolStripMenuItem";
            this.bMantTipoEleccionToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.bMantTipoEleccionToolStripMenuItem.Text = "Tipo Elección";
            // 
            // cMantPresidencialToolStripMenuItem
            // 
            this.cMantPresidencialToolStripMenuItem.Name = "cMantPresidencialToolStripMenuItem";
            this.cMantPresidencialToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.cMantPresidencialToolStripMenuItem.Text = "Presidencial";
            // 
            // cMantDiputacionToolStripMenuItem
            // 
            this.cMantDiputacionToolStripMenuItem.Name = "cMantDiputacionToolStripMenuItem";
            this.cMantDiputacionToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.cMantDiputacionToolStripMenuItem.Text = "Diputación";
            // 
            // aEstadisticasToolStripMenuItem
            // 
            this.aEstadisticasToolStripMenuItem.Name = "aEstadisticasToolStripMenuItem";
            this.aEstadisticasToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.aEstadisticasToolStripMenuItem.Text = "Estadísticas";
            // 
            // aReportesToolStripMenuItem
            // 
            this.aReportesToolStripMenuItem.Name = "aReportesToolStripMenuItem";
            this.aReportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.aReportesToolStripMenuItem.Text = "Reportes";
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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmIngresar;
        private System.Windows.Forms.ToolStripMenuItem aRegistroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aVotacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aMesaVotacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aMantenimientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aReportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aEstadisticasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aAcercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aArchivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bMantPadronNacionalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bMantDistritoElectoralToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bMantCandidatosPoliticosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bMantPartidosPoliticosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bMantTipoEleccionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cMantPresidencialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cMantDiputacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bCerrarSesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bSalirDelSistemaToolStripMenuItem;
    }
}

