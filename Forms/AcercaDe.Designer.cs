namespace grupo01ProyectoFinal
{
    partial class frmAcercade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAcercade));
            this.btnSalir = new System.Windows.Forms.Button();
            this.grbCreditos = new System.Windows.Forms.GroupBox();
            this.lblCuatriAnno = new System.Windows.Forms.Label();
            this.lblCurso = new System.Windows.Forms.Label();
            this.lblAutores = new System.Windows.Forms.Label();
            this.lblTituloCreditos = new System.Windows.Forms.Label();
            this.grbManualUsuario = new System.Windows.Forms.GroupBox();
            this.btnDescargarManualUsuario = new System.Windows.Forms.Button();
            this.lblTituloManual = new System.Windows.Forms.Label();
            this.grbCreditos.SuspendLayout();
            this.grbManualUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.Location = new System.Drawing.Point(574, 382);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(97, 57);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // grbCreditos
            // 
            this.grbCreditos.Controls.Add(this.lblCuatriAnno);
            this.grbCreditos.Controls.Add(this.lblCurso);
            this.grbCreditos.Controls.Add(this.lblAutores);
            this.grbCreditos.Controls.Add(this.lblTituloCreditos);
            this.grbCreditos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbCreditos.Location = new System.Drawing.Point(12, 12);
            this.grbCreditos.Name = "grbCreditos";
            this.grbCreditos.Size = new System.Drawing.Size(662, 160);
            this.grbCreditos.TabIndex = 3;
            this.grbCreditos.TabStop = false;
            this.grbCreditos.Text = " Créditos: ";
            // 
            // lblCuatriAnno
            // 
            this.lblCuatriAnno.AutoSize = true;
            this.lblCuatriAnno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuatriAnno.Location = new System.Drawing.Point(203, 122);
            this.lblCuatriAnno.Name = "lblCuatriAnno";
            this.lblCuatriAnno.Size = new System.Drawing.Size(202, 20);
            this.lblCuatriAnno.TabIndex = 6;
            this.lblCuatriAnno.Text = "I Cuatrimestre - Abril - 2026";
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurso.Location = new System.Drawing.Point(173, 86);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(270, 20);
            this.lblCurso.TabIndex = 5;
            this.lblCurso.Text = "Curso de Sistemas Computacionales";
            // 
            // lblAutores
            // 
            this.lblAutores.AutoSize = true;
            this.lblAutores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutores.Location = new System.Drawing.Point(83, 51);
            this.lblAutores.Name = "lblAutores";
            this.lblAutores.Size = new System.Drawing.Size(479, 20);
            this.lblAutores.TabIndex = 4;
            this.lblAutores.Text = "Desarrollado por César Chacón Barrantes y Andrei Mesén Romero";
            // 
            // lblTituloCreditos
            // 
            this.lblTituloCreditos.AutoSize = true;
            this.lblTituloCreditos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCreditos.Location = new System.Drawing.Point(173, 22);
            this.lblTituloCreditos.Name = "lblTituloCreditos";
            this.lblTituloCreditos.Size = new System.Drawing.Size(270, 20);
            this.lblTituloCreditos.TabIndex = 3;
            this.lblTituloCreditos.Text = "Sistema de Votación Electrónico";
            // 
            // grbManualUsuario
            // 
            this.grbManualUsuario.Controls.Add(this.btnDescargarManualUsuario);
            this.grbManualUsuario.Controls.Add(this.lblTituloManual);
            this.grbManualUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbManualUsuario.Location = new System.Drawing.Point(12, 178);
            this.grbManualUsuario.Name = "grbManualUsuario";
            this.grbManualUsuario.Size = new System.Drawing.Size(662, 160);
            this.grbManualUsuario.TabIndex = 7;
            this.grbManualUsuario.TabStop = false;
            this.grbManualUsuario.Text = "Manual de Usuario: ";
            // 
            // btnDescargarManualUsuario
            // 
            this.btnDescargarManualUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDescargarManualUsuario.Image = ((System.Drawing.Image)(resources.GetObject("btnDescargarManualUsuario.Image")));
            this.btnDescargarManualUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDescargarManualUsuario.Location = new System.Drawing.Point(218, 82);
            this.btnDescargarManualUsuario.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnDescargarManualUsuario.Name = "btnDescargarManualUsuario";
            this.btnDescargarManualUsuario.Size = new System.Drawing.Size(155, 67);
            this.btnDescargarManualUsuario.TabIndex = 8;
            this.btnDescargarManualUsuario.Text = "&Descargar";
            this.btnDescargarManualUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDescargarManualUsuario.UseVisualStyleBackColor = true;
            this.btnDescargarManualUsuario.Click += new System.EventHandler(this.btnDescargarManualUsuario_Click);
            // 
            // lblTituloManual
            // 
            this.lblTituloManual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloManual.Location = new System.Drawing.Point(6, 34);
            this.lblTituloManual.Name = "lblTituloManual";
            this.lblTituloManual.Size = new System.Drawing.Size(653, 46);
            this.lblTituloManual.TabIndex = 3;
            this.lblTituloManual.Text = "A continuación podrá descargar un manual de usuario donde se explica paso a paso " +
    "cómo utilizar el Sistema de Votación Electrónico: ";
            // 
            // frmAcercade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 455);
            this.ControlBox = false;
            this.Controls.Add(this.grbManualUsuario);
            this.Controls.Add(this.grbCreditos);
            this.Controls.Add(this.btnSalir);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmAcercade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acerca de";
            this.Load += new System.EventHandler(this.frmAcercade_Load);
            this.grbCreditos.ResumeLayout(false);
            this.grbCreditos.PerformLayout();
            this.grbManualUsuario.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox grbCreditos;
        private System.Windows.Forms.Label lblCuatriAnno;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.Label lblAutores;
        private System.Windows.Forms.Label lblTituloCreditos;
        private System.Windows.Forms.GroupBox grbManualUsuario;
        private System.Windows.Forms.Label lblTituloManual;
        private System.Windows.Forms.Button btnDescargarManualUsuario;
    }
}