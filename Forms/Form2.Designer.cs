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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.btnIngresa = new System.Windows.Forms.Button();
            this.txtCedulaingresa = new System.Windows.Forms.TextBox();
            this.lblCedulaingresa = new System.Windows.Forms.Label();
            this.lblpassword = new System.Windows.Forms.Label();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblRegistro = new System.Windows.Forms.Label();
            this.btnRegistro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIngresa
            // 
            this.btnIngresa.Location = new System.Drawing.Point(47, 110);
            this.btnIngresa.Margin = new System.Windows.Forms.Padding(2);
            this.btnIngresa.Name = "btnIngresa";
            this.btnIngresa.Size = new System.Drawing.Size(78, 58);
            this.btnIngresa.TabIndex = 2;
            this.btnIngresa.Text = "Ingresar";
            this.btnIngresa.UseVisualStyleBackColor = true;
            this.btnIngresa.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtCedulaingresa
            // 
            this.txtCedulaingresa.Location = new System.Drawing.Point(129, 38);
            this.txtCedulaingresa.Margin = new System.Windows.Forms.Padding(2);
            this.txtCedulaingresa.Name = "txtCedulaingresa";
            this.txtCedulaingresa.Size = new System.Drawing.Size(107, 20);
            this.txtCedulaingresa.TabIndex = 5;
            // 
            // lblCedulaingresa
            // 
            this.lblCedulaingresa.AutoSize = true;
            this.lblCedulaingresa.Location = new System.Drawing.Point(39, 42);
            this.lblCedulaingresa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCedulaingresa.Name = "lblCedulaingresa";
            this.lblCedulaingresa.Size = new System.Drawing.Size(46, 13);
            this.lblCedulaingresa.TabIndex = 6;
            this.lblCedulaingresa.Text = "Cédula: ";
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Location = new System.Drawing.Point(39, 72);
            this.lblpassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(64, 13);
            this.lblpassword.TabIndex = 7;
            this.lblpassword.Text = "Contraseña ";
            this.lblpassword.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(129, 68);
            this.txtpassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(107, 20);
            this.txtpassword.TabIndex = 8;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(158, 110);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(78, 58);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblRegistro
            // 
            this.lblRegistro.AutoSize = true;
            this.lblRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistro.Location = new System.Drawing.Point(323, 42);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(337, 20);
            this.lblRegistro.TabIndex = 11;
            this.lblRegistro.Text = "¿Aún no tiene una cuenta en el sistema?";
            // 
            // btnRegistro
            // 
            this.btnRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistro.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistro.Image")));
            this.btnRegistro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistro.Location = new System.Drawing.Point(415, 72);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(152, 58);
            this.btnRegistro.TabIndex = 19;
            this.btnRegistro.Text = "&Registrarme";
            this.btnRegistro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegistro.UseVisualStyleBackColor = true;
            this.btnRegistro.Click += new System.EventHandler(this.btnRegistro_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 191);
            this.Controls.Add(this.btnRegistro);
            this.Controls.Add(this.lblRegistro);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.lblCedulaingresa);
            this.Controls.Add(this.txtCedulaingresa);
            this.Controls.Add(this.btnIngresa);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingreso e Inicio de Sesión";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnIngresa;
        private System.Windows.Forms.TextBox txtCedulaingresa;
        private System.Windows.Forms.Label lblCedulaingresa;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblRegistro;
        private System.Windows.Forms.Button btnRegistro;
    }
}