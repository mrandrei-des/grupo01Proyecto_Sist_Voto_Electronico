namespace grupo01ProyectoFinal
{
    partial class frmLogin
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
            this.lblCedula = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.btnIngresa = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.lsvconsulta = new System.Windows.Forms.ListView();
            this.clhNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhApellidoI = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhApellidoII = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtCedulaingresa = new System.Windows.Forms.TextBox();
            this.lblCedulaingresa = new System.Windows.Forms.Label();
            this.lblpassword = new System.Windows.Forms.Label();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Location = new System.Drawing.Point(56, 77);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(138, 20);
            this.lblCedula.TabIndex = 0;
            this.lblCedula.Text = "Número de cédula";
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(250, 71);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(198, 26);
            this.txtCedula.TabIndex = 1;
            // 
            // btnIngresa
            // 
            this.btnIngresa.Location = new System.Drawing.Point(411, 291);
            this.btnIngresa.Name = "btnIngresa";
            this.btnIngresa.Size = new System.Drawing.Size(117, 89);
            this.btnIngresa.TabIndex = 2;
            this.btnIngresa.Text = "Ingresar";
            this.btnIngresa.UseVisualStyleBackColor = true;
            this.btnIngresa.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(586, 23);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(114, 74);
            this.btnConsultar.TabIndex = 3;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // lsvconsulta
            // 
            this.lsvconsulta.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clhNombre,
            this.clhApellidoI,
            this.clhApellidoII});
            this.lsvconsulta.FullRowSelect = true;
            this.lsvconsulta.GridLines = true;
            this.lsvconsulta.HideSelection = false;
            this.lsvconsulta.Location = new System.Drawing.Point(60, 129);
            this.lsvconsulta.Name = "lsvconsulta";
            this.lsvconsulta.Size = new System.Drawing.Size(640, 106);
            this.lsvconsulta.TabIndex = 4;
            this.lsvconsulta.UseCompatibleStateImageBehavior = false;
            // 
            // clhNombre
            // 
            this.clhNombre.Text = "Nombre";
            // 
            // clhApellidoI
            // 
            this.clhApellidoI.Text = "Apellido I";
            // 
            // clhApellidoII
            // 
            this.clhApellidoII.Text = "Apellido II";
            // 
            // txtCedulaingresa
            // 
            this.txtCedulaingresa.Location = new System.Drawing.Point(194, 275);
            this.txtCedulaingresa.Name = "txtCedulaingresa";
            this.txtCedulaingresa.Size = new System.Drawing.Size(158, 26);
            this.txtCedulaingresa.TabIndex = 5;
            // 
            // lblCedulaingresa
            // 
            this.lblCedulaingresa.AutoSize = true;
            this.lblCedulaingresa.Location = new System.Drawing.Point(74, 291);
            this.lblCedulaingresa.Name = "lblCedulaingresa";
            this.lblCedulaingresa.Size = new System.Drawing.Size(67, 20);
            this.lblCedulaingresa.TabIndex = 6;
            this.lblCedulaingresa.Text = "Cédula: ";
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Location = new System.Drawing.Point(74, 369);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(96, 20);
            this.lblpassword.TabIndex = 7;
            this.lblpassword.Text = "Contraseña ";
            this.lblpassword.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(194, 365);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(158, 26);
            this.txtpassword.TabIndex = 8;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(586, 291);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(117, 89);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 500);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.lblCedulaingresa);
            this.Controls.Add(this.txtCedulaingresa);
            this.Controls.Add(this.lsvconsulta);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnIngresa);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.lblCedula);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingreso e Inicio de Sesión";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Button btnIngresa;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.ListView lsvconsulta;
        private System.Windows.Forms.ColumnHeader clhNombre;
        private System.Windows.Forms.ColumnHeader clhApellidoI;
        private System.Windows.Forms.ColumnHeader clhApellidoII;
        private System.Windows.Forms.TextBox txtCedulaingresa;
        private System.Windows.Forms.Label lblCedulaingresa;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Button btnSalir;
    }
}