namespace grupo01ProyectoFinal
{
    partial class frmMantDist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMantDist));
            this.btnSalir = new System.Windows.Forms.Button();
            this.grbConsultaDistritoElecto = new System.Windows.Forms.GroupBox();
            this.lblProvincia = new System.Windows.Forms.Label();
            this.lblCanton = new System.Windows.Forms.Label();
            this.lblCodigoDist = new System.Windows.Forms.Label();
            this.txtCodigoDist = new System.Windows.Forms.TextBox();
            this.cmbProvincias = new System.Windows.Forms.ComboBox();
            this.cmbCantones = new System.Windows.Forms.ComboBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.dgvCodigoElectoral = new System.Windows.Forms.DataGridView();
            this.grbConsultaDistritoElecto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCodigoElectoral)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalir.Location = new System.Drawing.Point(827, 531);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(105, 79);
            this.btnSalir.TabIndex = 23;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // grbConsultaDistritoElecto
            // 
            this.grbConsultaDistritoElecto.Controls.Add(this.dgvCodigoElectoral);
            this.grbConsultaDistritoElecto.Controls.Add(this.cmbCantones);
            this.grbConsultaDistritoElecto.Controls.Add(this.cmbProvincias);
            this.grbConsultaDistritoElecto.Controls.Add(this.txtCodigoDist);
            this.grbConsultaDistritoElecto.Controls.Add(this.lblProvincia);
            this.grbConsultaDistritoElecto.Controls.Add(this.lblCanton);
            this.grbConsultaDistritoElecto.Controls.Add(this.lblCodigoDist);
            this.grbConsultaDistritoElecto.Location = new System.Drawing.Point(12, 12);
            this.grbConsultaDistritoElecto.Name = "grbConsultaDistritoElecto";
            this.grbConsultaDistritoElecto.Size = new System.Drawing.Size(921, 513);
            this.grbConsultaDistritoElecto.TabIndex = 24;
            this.grbConsultaDistritoElecto.TabStop = false;
            this.grbConsultaDistritoElecto.Text = " Consulta Distrito Electoral: ";
            // 
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProvincia.Location = new System.Drawing.Point(282, 40);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(86, 20);
            this.lblProvincia.TabIndex = 6;
            this.lblProvincia.Text = "Provincia:";
            // 
            // lblCanton
            // 
            this.lblCanton.AutoSize = true;
            this.lblCanton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCanton.Location = new System.Drawing.Point(638, 40);
            this.lblCanton.Name = "lblCanton";
            this.lblCanton.Size = new System.Drawing.Size(72, 20);
            this.lblCanton.TabIndex = 5;
            this.lblCanton.Text = "Cantón:";
            // 
            // lblCodigoDist
            // 
            this.lblCodigoDist.AutoSize = true;
            this.lblCodigoDist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoDist.Location = new System.Drawing.Point(14, 40);
            this.lblCodigoDist.Name = "lblCodigoDist";
            this.lblCodigoDist.Size = new System.Drawing.Size(133, 20);
            this.lblCodigoDist.TabIndex = 4;
            this.lblCodigoDist.Text = "Código Distrito:";
            // 
            // txtCodigoDist
            // 
            this.txtCodigoDist.Location = new System.Drawing.Point(148, 37);
            this.txtCodigoDist.Name = "txtCodigoDist";
            this.txtCodigoDist.Size = new System.Drawing.Size(113, 26);
            this.txtCodigoDist.TabIndex = 7;
            this.txtCodigoDist.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoDist_KeyPress);
            // 
            // cmbProvincias
            // 
            this.cmbProvincias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProvincias.FormattingEnabled = true;
            this.cmbProvincias.Location = new System.Drawing.Point(374, 37);
            this.cmbProvincias.Name = "cmbProvincias";
            this.cmbProvincias.Size = new System.Drawing.Size(232, 28);
            this.cmbProvincias.TabIndex = 29;
            this.cmbProvincias.SelectionChangeCommitted += new System.EventHandler(this.cmbProvincias_SelectionChangeCommitted);
            // 
            // cmbCantones
            // 
            this.cmbCantones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCantones.FormattingEnabled = true;
            this.cmbCantones.Location = new System.Drawing.Point(716, 37);
            this.cmbCantones.Name = "cmbCantones";
            this.cmbCantones.Size = new System.Drawing.Size(182, 28);
            this.cmbCantones.TabIndex = 30;
            this.cmbCantones.SelectionChangeCommitted += new System.EventHandler(this.cmbCantones_SelectionChangeCommitted);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.Image")));
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLimpiar.Location = new System.Drawing.Point(715, 531);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(105, 79);
            this.btnLimpiar.TabIndex = 28;
            this.btnLimpiar.Text = "&Limpiar";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // dgvCodigoElectoral
            // 
            this.dgvCodigoElectoral.AllowUserToAddRows = false;
            this.dgvCodigoElectoral.AllowUserToDeleteRows = false;
            this.dgvCodigoElectoral.AllowUserToResizeRows = false;
            this.dgvCodigoElectoral.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvCodigoElectoral.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCodigoElectoral.BackgroundColor = System.Drawing.Color.White;
            this.dgvCodigoElectoral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCodigoElectoral.Location = new System.Drawing.Point(18, 82);
            this.dgvCodigoElectoral.MultiSelect = false;
            this.dgvCodigoElectoral.Name = "dgvCodigoElectoral";
            this.dgvCodigoElectoral.ReadOnly = true;
            this.dgvCodigoElectoral.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvCodigoElectoral.RowHeadersVisible = false;
            this.dgvCodigoElectoral.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvCodigoElectoral.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCodigoElectoral.Size = new System.Drawing.Size(880, 425);
            this.dgvCodigoElectoral.TabIndex = 31;
            // 
            // frmMantDist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 622);
            this.ControlBox = false;
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.grbConsultaDistritoElecto);
            this.Controls.Add(this.btnSalir);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmMantDist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento Distrito";
            this.Load += new System.EventHandler(this.frmMantDist_Load);
            this.grbConsultaDistritoElecto.ResumeLayout(false);
            this.grbConsultaDistritoElecto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCodigoElectoral)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox grbConsultaDistritoElecto;
        private System.Windows.Forms.TextBox txtCodigoDist;
        private System.Windows.Forms.Label lblProvincia;
        private System.Windows.Forms.Label lblCanton;
        private System.Windows.Forms.Label lblCodigoDist;
        private System.Windows.Forms.ComboBox cmbCantones;
        private System.Windows.Forms.ComboBox cmbProvincias;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DataGridView dgvCodigoElectoral;
    }
}