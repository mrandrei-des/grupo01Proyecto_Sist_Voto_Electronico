namespace grupo01ProyectoFinal
{
    partial class frmRegistroUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistroUsuario));
            this.grbInfoUsuario = new System.Windows.Forms.GroupBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtIdentificacion = new System.Windows.Forms.TextBox();
            this.lblIdentificacion = new System.Windows.Forms.Label();
            this.grbLugarVotacion = new System.Windows.Forms.GroupBox();
            this.cmbDistritos = new System.Windows.Forms.ComboBox();
            this.cmbCantones = new System.Windows.Forms.ComboBox();
            this.cmbProvincias = new System.Windows.Forms.ComboBox();
            this.lblDistrito = new System.Windows.Forms.Label();
            this.lblCanton = new System.Windows.Forms.Label();
            this.lblProvincia = new System.Windows.Forms.Label();
            this.grbDatosAcceso = new System.Windows.Forms.GroupBox();
            this.lblMsjCorreo = new System.Windows.Forms.Label();
            this.lblInfoCorreo = new System.Windows.Forms.Label();
            this.lblMsjContrasenna = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtContrasenna = new System.Windows.Forms.TextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblContrasena = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnRegistro = new System.Windows.Forms.Button();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.grbInfoUsuario.SuspendLayout();
            this.grbLugarVotacion.SuspendLayout();
            this.grbDatosAcceso.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbInfoUsuario
            // 
            this.grbInfoUsuario.Controls.Add(this.txtApellidos);
            this.grbInfoUsuario.Controls.Add(this.lblApellidos);
            this.grbInfoUsuario.Controls.Add(this.txtNombre);
            this.grbInfoUsuario.Controls.Add(this.lblNombre);
            this.grbInfoUsuario.Location = new System.Drawing.Point(12, 102);
            this.grbInfoUsuario.Name = "grbInfoUsuario";
            this.grbInfoUsuario.Size = new System.Drawing.Size(983, 80);
            this.grbInfoUsuario.TabIndex = 2;
            this.grbInfoUsuario.TabStop = false;
            this.grbInfoUsuario.Text = " Información del Usuario: ";
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(444, 34);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.ReadOnly = true;
            this.txtApellidos.Size = new System.Drawing.Size(324, 26);
            this.txtApellidos.TabIndex = 9;
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidos.Location = new System.Drawing.Point(346, 37);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(92, 20);
            this.lblApellidos.TabIndex = 8;
            this.lblApellidos.Text = "Apellidos: ";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(130, 31);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(210, 26);
            this.txtNombre.TabIndex = 7;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(37, 34);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(81, 20);
            this.lblNombre.TabIndex = 6;
            this.lblNombre.Text = "Nombre: ";
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.Location = new System.Drawing.Point(511, 39);
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.Size = new System.Drawing.Size(210, 26);
            this.txtIdentificacion.TabIndex = 3;
            // 
            // lblIdentificacion
            // 
            this.lblIdentificacion.AutoSize = true;
            this.lblIdentificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdentificacion.Location = new System.Drawing.Point(311, 42);
            this.lblIdentificacion.Name = "lblIdentificacion";
            this.lblIdentificacion.Size = new System.Drawing.Size(194, 20);
            this.lblIdentificacion.TabIndex = 2;
            this.lblIdentificacion.Text = "Número Identificación: ";
            // 
            // grbLugarVotacion
            // 
            this.grbLugarVotacion.Controls.Add(this.cmbDistritos);
            this.grbLugarVotacion.Controls.Add(this.cmbCantones);
            this.grbLugarVotacion.Controls.Add(this.cmbProvincias);
            this.grbLugarVotacion.Controls.Add(this.lblDistrito);
            this.grbLugarVotacion.Controls.Add(this.lblCanton);
            this.grbLugarVotacion.Controls.Add(this.lblProvincia);
            this.grbLugarVotacion.Location = new System.Drawing.Point(12, 200);
            this.grbLugarVotacion.Name = "grbLugarVotacion";
            this.grbLugarVotacion.Size = new System.Drawing.Size(983, 84);
            this.grbLugarVotacion.TabIndex = 10;
            this.grbLugarVotacion.TabStop = false;
            this.grbLugarVotacion.Text = " Lugar de Votación: ";
            // 
            // cmbDistritos
            // 
            this.cmbDistritos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDistritos.Enabled = false;
            this.cmbDistritos.FormattingEnabled = true;
            this.cmbDistritos.Location = new System.Drawing.Point(747, 35);
            this.cmbDistritos.Name = "cmbDistritos";
            this.cmbDistritos.Size = new System.Drawing.Size(210, 28);
            this.cmbDistritos.TabIndex = 14;
            // 
            // cmbCantones
            // 
            this.cmbCantones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCantones.Enabled = false;
            this.cmbCantones.FormattingEnabled = true;
            this.cmbCantones.Location = new System.Drawing.Point(429, 35);
            this.cmbCantones.Name = "cmbCantones";
            this.cmbCantones.Size = new System.Drawing.Size(210, 28);
            this.cmbCantones.TabIndex = 13;
            this.cmbCantones.SelectedIndexChanged += new System.EventHandler(this.cmbCantones_SelectedIndexChanged);
            // 
            // cmbProvincias
            // 
            this.cmbProvincias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProvincias.Enabled = false;
            this.cmbProvincias.FormattingEnabled = true;
            this.cmbProvincias.Location = new System.Drawing.Point(130, 35);
            this.cmbProvincias.Name = "cmbProvincias";
            this.cmbProvincias.Size = new System.Drawing.Size(210, 28);
            this.cmbProvincias.TabIndex = 12;
            this.cmbProvincias.SelectedIndexChanged += new System.EventHandler(this.cmbProvincias_SelectedIndexChanged);
            // 
            // lblDistrito
            // 
            this.lblDistrito.AutoSize = true;
            this.lblDistrito.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistrito.Location = new System.Drawing.Point(664, 38);
            this.lblDistrito.Name = "lblDistrito";
            this.lblDistrito.Size = new System.Drawing.Size(77, 20);
            this.lblDistrito.TabIndex = 10;
            this.lblDistrito.Text = "Distrito: ";
            // 
            // lblCanton
            // 
            this.lblCanton.AutoSize = true;
            this.lblCanton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCanton.Location = new System.Drawing.Point(346, 38);
            this.lblCanton.Name = "lblCanton";
            this.lblCanton.Size = new System.Drawing.Size(77, 20);
            this.lblCanton.TabIndex = 8;
            this.lblCanton.Text = "Cantón: ";
            // 
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProvincia.Location = new System.Drawing.Point(33, 38);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(91, 20);
            this.lblProvincia.TabIndex = 6;
            this.lblProvincia.Text = "Provincia: ";
            // 
            // grbDatosAcceso
            // 
            this.grbDatosAcceso.Controls.Add(this.lblMsjCorreo);
            this.grbDatosAcceso.Controls.Add(this.lblInfoCorreo);
            this.grbDatosAcceso.Controls.Add(this.lblMsjContrasenna);
            this.grbDatosAcceso.Controls.Add(this.txtCorreo);
            this.grbDatosAcceso.Controls.Add(this.txtContrasenna);
            this.grbDatosAcceso.Controls.Add(this.lblCorreo);
            this.grbDatosAcceso.Controls.Add(this.lblContrasena);
            this.grbDatosAcceso.Location = new System.Drawing.Point(12, 299);
            this.grbDatosAcceso.Name = "grbDatosAcceso";
            this.grbDatosAcceso.Size = new System.Drawing.Size(983, 156);
            this.grbDatosAcceso.TabIndex = 15;
            this.grbDatosAcceso.TabStop = false;
            this.grbDatosAcceso.Text = " Datos para acceso: ";
            // 
            // lblMsjCorreo
            // 
            this.lblMsjCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsjCorreo.Location = new System.Drawing.Point(372, 80);
            this.lblMsjCorreo.Name = "lblMsjCorreo";
            this.lblMsjCorreo.Size = new System.Drawing.Size(586, 26);
            this.lblMsjCorreo.TabIndex = 14;
            this.lblMsjCorreo.Text = "*El correo debe contener solo valores alfanuméricos (letras y números)*";
            // 
            // lblInfoCorreo
            // 
            this.lblInfoCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoCorreo.Location = new System.Drawing.Point(38, 119);
            this.lblInfoCorreo.Name = "lblInfoCorreo";
            this.lblInfoCorreo.Size = new System.Drawing.Size(465, 26);
            this.lblInfoCorreo.TabIndex = 13;
            this.lblInfoCorreo.Text = "Para la entrega de información y notificaciones sobre las votaciones.";
            // 
            // lblMsjContrasenna
            // 
            this.lblMsjContrasenna.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsjContrasenna.Location = new System.Drawing.Point(371, 35);
            this.lblMsjContrasenna.Name = "lblMsjContrasenna";
            this.lblMsjContrasenna.Size = new System.Drawing.Size(586, 39);
            this.lblMsjContrasenna.TabIndex = 12;
            this.lblMsjContrasenna.Text = "*La contraseña debe tener como mínimo 8 caracteres y máximo 15. Debe incluir letr" +
    "as y números.*";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(151, 80);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(210, 26);
            this.txtCorreo.TabIndex = 11;
            // 
            // txtContrasenna
            // 
            this.txtContrasenna.Location = new System.Drawing.Point(151, 35);
            this.txtContrasenna.Name = "txtContrasenna";
            this.txtContrasenna.Size = new System.Drawing.Size(210, 26);
            this.txtContrasenna.TabIndex = 10;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.Location = new System.Drawing.Point(33, 83);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(68, 20);
            this.lblCorreo.TabIndex = 8;
            this.lblCorreo.Text = "Correo:";
            // 
            // lblContrasena
            // 
            this.lblContrasena.AutoSize = true;
            this.lblContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContrasena.Location = new System.Drawing.Point(33, 38);
            this.lblContrasena.Name = "lblContrasena";
            this.lblContrasena.Size = new System.Drawing.Size(112, 20);
            this.lblContrasena.TabIndex = 6;
            this.lblContrasena.Text = "Contraseña: ";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.Image")));
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLimpiar.Location = new System.Drawing.Point(476, 493);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(105, 79);
            this.btnLimpiar.TabIndex = 17;
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
            this.btnSalir.Location = new System.Drawing.Point(629, 493);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(105, 79);
            this.btnSalir.TabIndex = 16;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnRegistro
            // 
            this.btnRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistro.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistro.Image")));
            this.btnRegistro.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRegistro.Location = new System.Drawing.Point(330, 493);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(105, 79);
            this.btnRegistro.TabIndex = 18;
            this.btnRegistro.Text = "&Registrarme";
            this.btnRegistro.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRegistro.UseVisualStyleBackColor = true;
            this.btnRegistro.Click += new System.EventHandler(this.btnRegistro_Click);
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefrescar.Image = ((System.Drawing.Image)(resources.GetObject("btnRefrescar.Image")));
            this.btnRefrescar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRefrescar.Location = new System.Drawing.Point(746, 12);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(105, 79);
            this.btnRefrescar.TabIndex = 19;
            this.btnRefrescar.Text = "&Refrescar";
            this.btnRefrescar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRefrescar.UseVisualStyleBackColor = true;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // frmRegistroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 600);
            this.ControlBox = false;
            this.Controls.Add(this.btnRefrescar);
            this.Controls.Add(this.btnRegistro);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.grbDatosAcceso);
            this.Controls.Add(this.grbLugarVotacion);
            this.Controls.Add(this.txtIdentificacion);
            this.Controls.Add(this.grbInfoUsuario);
            this.Controls.Add(this.lblIdentificacion);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmRegistroUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro Usuario";
            this.Load += new System.EventHandler(this.frmRegistroUsuario_Load);
            this.grbInfoUsuario.ResumeLayout(false);
            this.grbInfoUsuario.PerformLayout();
            this.grbLugarVotacion.ResumeLayout(false);
            this.grbLugarVotacion.PerformLayout();
            this.grbDatosAcceso.ResumeLayout(false);
            this.grbDatosAcceso.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbInfoUsuario;
        private System.Windows.Forms.TextBox txtIdentificacion;
        private System.Windows.Forms.Label lblIdentificacion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.GroupBox grbLugarVotacion;
        private System.Windows.Forms.ComboBox cmbProvincias;
        private System.Windows.Forms.Label lblDistrito;
        private System.Windows.Forms.Label lblCanton;
        private System.Windows.Forms.Label lblProvincia;
        private System.Windows.Forms.ComboBox cmbDistritos;
        private System.Windows.Forms.ComboBox cmbCantones;
        private System.Windows.Forms.GroupBox grbDatosAcceso;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtContrasenna;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblContrasena;
        private System.Windows.Forms.Label lblMsjContrasenna;
        private System.Windows.Forms.Label lblInfoCorreo;
        private System.Windows.Forms.Label lblMsjCorreo;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnRegistro;
        private System.Windows.Forms.Button btnRefrescar;
    }
}