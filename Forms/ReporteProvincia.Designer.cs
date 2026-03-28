namespace grupo01ProyectoFinal.Forms
{
    partial class frmReporteProvincia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporteProvincia));
            this.grbFiltros = new System.Windows.Forms.GroupBox();
            this.rdoTipoVotacionDiputacion = new System.Windows.Forms.RadioButton();
            this.lblTipoVotacion = new System.Windows.Forms.Label();
            this.rdoTipoVotacionPresidente = new System.Windows.Forms.RadioButton();
            this.cmbProvincias = new System.Windows.Forms.ComboBox();
            this.lblProvincia = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.grbFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbFiltros
            // 
            this.grbFiltros.Controls.Add(this.rdoTipoVotacionDiputacion);
            this.grbFiltros.Controls.Add(this.lblTipoVotacion);
            this.grbFiltros.Controls.Add(this.rdoTipoVotacionPresidente);
            this.grbFiltros.Controls.Add(this.cmbProvincias);
            this.grbFiltros.Controls.Add(this.lblProvincia);
            this.grbFiltros.Location = new System.Drawing.Point(18, 18);
            this.grbFiltros.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbFiltros.Name = "grbFiltros";
            this.grbFiltros.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbFiltros.Size = new System.Drawing.Size(721, 125);
            this.grbFiltros.TabIndex = 11;
            this.grbFiltros.TabStop = false;
            this.grbFiltros.Text = " Filtros: ";
            // 
            // rdoTipoVotacionDiputacion
            // 
            this.rdoTipoVotacionDiputacion.AutoSize = true;
            this.rdoTipoVotacionDiputacion.Location = new System.Drawing.Point(435, 27);
            this.rdoTipoVotacionDiputacion.Name = "rdoTipoVotacionDiputacion";
            this.rdoTipoVotacionDiputacion.Size = new System.Drawing.Size(100, 24);
            this.rdoTipoVotacionDiputacion.TabIndex = 15;
            this.rdoTipoVotacionDiputacion.Text = "Diputados";
            this.rdoTipoVotacionDiputacion.UseVisualStyleBackColor = true;
            // 
            // lblTipoVotacion
            // 
            this.lblTipoVotacion.AutoSize = true;
            this.lblTipoVotacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoVotacion.Location = new System.Drawing.Point(98, 29);
            this.lblTipoVotacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoVotacion.Name = "lblTipoVotacion";
            this.lblTipoVotacion.Size = new System.Drawing.Size(154, 20);
            this.lblTipoVotacion.TabIndex = 14;
            this.lblTipoVotacion.Text = "Tipo de Votación: ";
            // 
            // rdoTipoVotacionPresidente
            // 
            this.rdoTipoVotacionPresidente.AutoSize = true;
            this.rdoTipoVotacionPresidente.Checked = true;
            this.rdoTipoVotacionPresidente.Location = new System.Drawing.Point(276, 27);
            this.rdoTipoVotacionPresidente.Name = "rdoTipoVotacionPresidente";
            this.rdoTipoVotacionPresidente.Size = new System.Drawing.Size(103, 24);
            this.rdoTipoVotacionPresidente.TabIndex = 13;
            this.rdoTipoVotacionPresidente.TabStop = true;
            this.rdoTipoVotacionPresidente.Text = "Presidente";
            this.rdoTipoVotacionPresidente.UseVisualStyleBackColor = true;
            // 
            // cmbProvincias
            // 
            this.cmbProvincias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProvincias.FormattingEnabled = true;
            this.cmbProvincias.Location = new System.Drawing.Point(259, 71);
            this.cmbProvincias.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbProvincias.Name = "cmbProvincias";
            this.cmbProvincias.Size = new System.Drawing.Size(313, 28);
            this.cmbProvincias.TabIndex = 12;
            // 
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProvincia.Location = new System.Drawing.Point(98, 74);
            this.lblProvincia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(91, 20);
            this.lblProvincia.TabIndex = 6;
            this.lblProvincia.Text = "Provincia: ";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.Image")));
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLimpiar.Location = new System.Drawing.Point(342, 327);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(105, 79);
            this.btnLimpiar.TabIndex = 13;
            this.btnLimpiar.Text = "&Limpiar";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalir.Location = new System.Drawing.Point(453, 327);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(105, 79);
            this.btnSalir.TabIndex = 12;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGenerar
            // 
            this.btnGenerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.Image = ((System.Drawing.Image)(resources.GetObject("btnGenerar.Image")));
            this.btnGenerar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGenerar.Location = new System.Drawing.Point(231, 327);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(105, 79);
            this.btnGenerar.TabIndex = 14;
            this.btnGenerar.Text = "&Generar";
            this.btnGenerar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(342, 327);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 79);
            this.button1.TabIndex = 13;
            this.button1.Text = "&Limpiar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(231, 327);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 79);
            this.button2.TabIndex = 14;
            this.button2.Text = "&Generar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // frmReporteProvincia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 455);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.grbFiltros);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmReporteProvincia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte por Provincia";
            this.Load += new System.EventHandler(this.frmReporteProvincia_Load);
            this.grbFiltros.ResumeLayout(false);
            this.grbFiltros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbFiltros;
        private System.Windows.Forms.ComboBox cmbProvincias;
        private System.Windows.Forms.Label lblProvincia;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.RadioButton rdoTipoVotacionPresidente;
        private System.Windows.Forms.RadioButton rdoTipoVotacionDiputacion;
        private System.Windows.Forms.Label lblTipoVotacion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}