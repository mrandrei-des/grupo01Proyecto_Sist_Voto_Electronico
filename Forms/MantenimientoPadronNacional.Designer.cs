namespace grupo01ProyectoFinal.Forms
{
    partial class frmMantPadronNacional
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMantPadronNacional));
            this.grbPadronNacional = new System.Windows.Forms.GroupBox();
            this.cmbProvincias = new System.Windows.Forms.ComboBox();
            this.lblProvincia = new System.Windows.Forms.Label();
            this.dgvPadronNacional = new System.Windows.Forms.DataGridView();
            this.dgvcNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcApellido1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcApellido2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcFechaVencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.txtIdentificacion = new System.Windows.Forms.TextBox();
            this.lblIdentificacion = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.grbPadronNacional.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPadronNacional)).BeginInit();
            this.SuspendLayout();
            // 
            // grbPadronNacional
            // 
            this.grbPadronNacional.Controls.Add(this.cmbProvincias);
            this.grbPadronNacional.Controls.Add(this.lblProvincia);
            this.grbPadronNacional.Controls.Add(this.dgvPadronNacional);
            this.grbPadronNacional.Controls.Add(this.btnRefrescar);
            this.grbPadronNacional.Controls.Add(this.txtIdentificacion);
            this.grbPadronNacional.Controls.Add(this.lblIdentificacion);
            this.grbPadronNacional.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbPadronNacional.Location = new System.Drawing.Point(22, 24);
            this.grbPadronNacional.Name = "grbPadronNacional";
            this.grbPadronNacional.Size = new System.Drawing.Size(930, 454);
            this.grbPadronNacional.TabIndex = 23;
            this.grbPadronNacional.TabStop = false;
            this.grbPadronNacional.Text = " Consulta en Padrón Nacional: ";
            // 
            // cmbProvincias
            // 
            this.cmbProvincias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProvincias.FormattingEnabled = true;
            this.cmbProvincias.Location = new System.Drawing.Point(568, 54);
            this.cmbProvincias.Name = "cmbProvincias";
            this.cmbProvincias.Size = new System.Drawing.Size(232, 28);
            this.cmbProvincias.TabIndex = 28;
            this.cmbProvincias.SelectedIndexChanged += new System.EventHandler(this.cmbProvincias_SelectedIndexChanged);
            // 
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProvincia.Location = new System.Drawing.Point(471, 57);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(91, 20);
            this.lblProvincia.TabIndex = 27;
            this.lblProvincia.Text = "Provincia: ";
            // 
            // dgvPadronNacional
            // 
            this.dgvPadronNacional.AllowUserToAddRows = false;
            this.dgvPadronNacional.AllowUserToDeleteRows = false;
            this.dgvPadronNacional.AllowUserToResizeRows = false;
            this.dgvPadronNacional.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPadronNacional.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPadronNacional.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvcNombre,
            this.dgvcApellido1,
            this.dgvcApellido2,
            this.dgvcFechaVencimiento});
            this.dgvPadronNacional.Location = new System.Drawing.Point(0, 123);
            this.dgvPadronNacional.Name = "dgvPadronNacional";
            this.dgvPadronNacional.ReadOnly = true;
            this.dgvPadronNacional.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPadronNacional.Size = new System.Drawing.Size(924, 325);
            this.dgvPadronNacional.TabIndex = 26;
            // 
            // dgvcNombre
            // 
            this.dgvcNombre.HeaderText = "Nombre";
            this.dgvcNombre.Name = "dgvcNombre";
            this.dgvcNombre.ReadOnly = true;
            this.dgvcNombre.Width = 210;
            // 
            // dgvcApellido1
            // 
            this.dgvcApellido1.HeaderText = "Primer Apellido";
            this.dgvcApellido1.Name = "dgvcApellido1";
            this.dgvcApellido1.ReadOnly = true;
            this.dgvcApellido1.Width = 250;
            // 
            // dgvcApellido2
            // 
            this.dgvcApellido2.HeaderText = "Segundo Apellido";
            this.dgvcApellido2.Name = "dgvcApellido2";
            this.dgvcApellido2.ReadOnly = true;
            this.dgvcApellido2.Width = 250;
            // 
            // dgvcFechaVencimiento
            // 
            this.dgvcFechaVencimiento.HeaderText = "Fecha Vencimiento Cédula";
            this.dgvcFechaVencimiento.Name = "dgvcFechaVencimiento";
            this.dgvcFechaVencimiento.ReadOnly = true;
            this.dgvcFechaVencimiento.Width = 200;
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefrescar.Image = ((System.Drawing.Image)(resources.GetObject("btnRefrescar.Image")));
            this.btnRefrescar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRefrescar.Location = new System.Drawing.Point(819, 25);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(105, 79);
            this.btnRefrescar.TabIndex = 25;
            this.btnRefrescar.Text = "&Refrescar";
            this.btnRefrescar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRefrescar.UseVisualStyleBackColor = true;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.Location = new System.Drawing.Point(226, 54);
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.Size = new System.Drawing.Size(210, 26);
            this.txtIdentificacion.TabIndex = 24;
            this.txtIdentificacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdentificacion_KeyPress);
            // 
            // lblIdentificacion
            // 
            this.lblIdentificacion.AutoSize = true;
            this.lblIdentificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdentificacion.Location = new System.Drawing.Point(26, 54);
            this.lblIdentificacion.Name = "lblIdentificacion";
            this.lblIdentificacion.Size = new System.Drawing.Size(194, 20);
            this.lblIdentificacion.TabIndex = 23;
            this.lblIdentificacion.Text = "Número Identificación: ";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.Image")));
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLimpiar.Location = new System.Drawing.Point(353, 501);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(105, 79);
            this.btnLimpiar.TabIndex = 27;
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
            this.btnSalir.Location = new System.Drawing.Point(528, 501);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(105, 79);
            this.btnSalir.TabIndex = 26;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmMantPadronNacional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 592);
            this.ControlBox = false;
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.grbPadronNacional);
            this.Name = "frmMantPadronNacional";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento Padrón Nacional";
            this.Load += new System.EventHandler(this.frmMantPadronNacional_Load);
            this.grbPadronNacional.ResumeLayout(false);
            this.grbPadronNacional.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPadronNacional)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grbPadronNacional;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.TextBox txtIdentificacion;
        private System.Windows.Forms.Label lblIdentificacion;
        private System.Windows.Forms.DataGridView dgvPadronNacional;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcApellido1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcApellido2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcFechaVencimiento;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ComboBox cmbProvincias;
        private System.Windows.Forms.Label lblProvincia;
    }
}