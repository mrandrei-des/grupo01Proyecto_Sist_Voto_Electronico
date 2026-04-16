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
            this.btnIngresa = new System.Windows.Forms.Button();
            this.txtCedulaingresa = new System.Windows.Forms.TextBox();
            this.lblCedulaingresa = new System.Windows.Forms.Label();
            this.lblpassword = new System.Windows.Forms.Label();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIngresa
            // 
            this.btnIngresa.Location = new System.Drawing.Point(423, 57);
            this.btnIngresa.Name = "btnIngresa";
            this.btnIngresa.Size = new System.Drawing.Size(117, 89);
            this.btnIngresa.TabIndex = 2;
            this.btnIngresa.Text = "Ingresar";
            this.btnIngresa.UseVisualStyleBackColor = true;
            this.btnIngresa.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtCedulaingresa
            // 
            this.txtCedulaingresa.Location = new System.Drawing.Point(194, 40);
            this.txtCedulaingresa.Name = "txtCedulaingresa";
            this.txtCedulaingresa.Size = new System.Drawing.Size(158, 26);
            this.txtCedulaingresa.TabIndex = 5;
            // 
            // lblCedulaingresa
            // 
            this.lblCedulaingresa.AutoSize = true;
            this.lblCedulaingresa.Location = new System.Drawing.Point(59, 46);
            this.lblCedulaingresa.Name = "lblCedulaingresa";
            this.lblCedulaingresa.Size = new System.Drawing.Size(67, 20);
            this.lblCedulaingresa.TabIndex = 6;
            this.lblCedulaingresa.Text = "Cédula: ";
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Location = new System.Drawing.Point(59, 152);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(96, 20);
            this.lblpassword.TabIndex = 7;
            this.lblpassword.Text = "Contraseña ";
            this.lblpassword.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(194, 146);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(158, 26);
            this.txtpassword.TabIndex = 8;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(601, 57);
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
            this.ClientSize = new System.Drawing.Size(812, 234);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.lblCedulaingresa);
            this.Controls.Add(this.txtCedulaingresa);
            this.Controls.Add(this.btnIngresa);
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
    }
}