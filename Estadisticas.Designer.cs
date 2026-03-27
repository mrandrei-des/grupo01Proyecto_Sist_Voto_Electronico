namespace grupo01ProyectoFinal
{
    partial class Estadisticas
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.btnProvPantalla = new System.Windows.Forms.Button();
            this.btnProvImprimir = new System.Windows.Forms.Button();
            this.btnCandImprimir = new System.Windows.Forms.Button();
            this.btnCandPantalla = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccionar Provincia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(315, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "Seleccionar Candidato";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "San José",
            "Alajuela",
            "Heredia",
            "Cartago",
            "Guanacaste",
            "Puntarenas",
            "Limón"});
            this.comboBox1.Location = new System.Drawing.Point(343, 72);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(152, 28);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(343, 241);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(152, 28);
            this.comboBox2.TabIndex = 3;
            // 
            // btnProvPantalla
            // 
            this.btnProvPantalla.Location = new System.Drawing.Point(35, 118);
            this.btnProvPantalla.Name = "btnProvPantalla";
            this.btnProvPantalla.Size = new System.Drawing.Size(109, 84);
            this.btnProvPantalla.TabIndex = 4;
            this.btnProvPantalla.Text = "En pantalla";
            this.btnProvPantalla.UseVisualStyleBackColor = true;
            // 
            // btnProvImprimir
            // 
            this.btnProvImprimir.Location = new System.Drawing.Point(343, 118);
            this.btnProvImprimir.Name = "btnProvImprimir";
            this.btnProvImprimir.Size = new System.Drawing.Size(109, 84);
            this.btnProvImprimir.TabIndex = 5;
            this.btnProvImprimir.Text = "En impresora";
            this.btnProvImprimir.UseVisualStyleBackColor = true;
            // 
            // btnCandImprimir
            // 
            this.btnCandImprimir.Location = new System.Drawing.Point(343, 313);
            this.btnCandImprimir.Name = "btnCandImprimir";
            this.btnCandImprimir.Size = new System.Drawing.Size(109, 84);
            this.btnCandImprimir.TabIndex = 6;
            this.btnCandImprimir.Text = "En impresora";
            this.btnCandImprimir.UseVisualStyleBackColor = true;
            // 
            // btnCandPantalla
            // 
            this.btnCandPantalla.Location = new System.Drawing.Point(35, 313);
            this.btnCandPantalla.Name = "btnCandPantalla";
            this.btnCandPantalla.Size = new System.Drawing.Size(109, 84);
            this.btnCandPantalla.TabIndex = 7;
            this.btnCandPantalla.Text = "En Pantalla";
            this.btnCandPantalla.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(654, 44);
            this.label3.TabIndex = 8;
            this.label3.Text = "Generar Estadística en Tiempo Real";
            // 
            // Estadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCandPantalla);
            this.Controls.Add(this.btnCandImprimir);
            this.Controls.Add(this.btnProvImprimir);
            this.Controls.Add(this.btnProvPantalla);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Estadisticas";
            this.Text = "Estad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button btnProvPantalla;
        private System.Windows.Forms.Button btnProvImprimir;
        private System.Windows.Forms.Button btnCandImprimir;
        private System.Windows.Forms.Button btnCandPantalla;
        private System.Windows.Forms.Label label3;
    }
}