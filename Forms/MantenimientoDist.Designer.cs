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
            this.lblCodDist = new System.Windows.Forms.Label();
            this.lblNombDist = new System.Windows.Forms.Label();
            this.lblCanton = new System.Windows.Forms.Label();
            this.lblProvincia = new System.Windows.Forms.Label();
            this.txtCodDist = new System.Windows.Forms.TextBox();
            this.txtNombDist = new System.Windows.Forms.TextBox();
            this.txtCanton = new System.Windows.Forms.TextBox();
            this.txtProvincia = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CodDist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombDist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.canton = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnBuscarDist = new System.Windows.Forms.Button();
            this.lblBuscaDist = new System.Windows.Forms.Label();
            this.lblDatoDist = new System.Windows.Forms.Label();
            this.lblCodDist1 = new System.Windows.Forms.Label();
            this.txtCodDist1 = new System.Windows.Forms.TextBox();
            this.lblNombDist1 = new System.Windows.Forms.Label();
            this.txtNombDist1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodDist
            // 
            this.lblCodDist.AutoSize = true;
            this.lblCodDist.Location = new System.Drawing.Point(23, 45);
            this.lblCodDist.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodDist.Name = "lblCodDist";
            this.lblCodDist.Size = new System.Drawing.Size(78, 13);
            this.lblCodDist.TabIndex = 0;
            this.lblCodDist.Text = "Código Distrito:";
            this.lblCodDist.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblNombDist
            // 
            this.lblNombDist.AutoSize = true;
            this.lblNombDist.Location = new System.Drawing.Point(23, 72);
            this.lblNombDist.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombDist.Name = "lblNombDist";
            this.lblNombDist.Size = new System.Drawing.Size(82, 13);
            this.lblNombDist.TabIndex = 1;
            this.lblNombDist.Text = "Nombre Distrito:";
            // 
            // lblCanton
            // 
            this.lblCanton.AutoSize = true;
            this.lblCanton.Location = new System.Drawing.Point(33, 198);
            this.lblCanton.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCanton.Name = "lblCanton";
            this.lblCanton.Size = new System.Drawing.Size(41, 13);
            this.lblCanton.TabIndex = 2;
            this.lblCanton.Text = "Cantón";
            // 
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.Location = new System.Drawing.Point(33, 233);
            this.lblProvincia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(54, 13);
            this.lblProvincia.TabIndex = 3;
            this.lblProvincia.Text = "Provincia:";
            // 
            // txtCodDist
            // 
            this.txtCodDist.Location = new System.Drawing.Point(125, 43);
            this.txtCodDist.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCodDist.Name = "txtCodDist";
            this.txtCodDist.Size = new System.Drawing.Size(115, 20);
            this.txtCodDist.TabIndex = 4;
            // 
            // txtNombDist
            // 
            this.txtNombDist.Location = new System.Drawing.Point(125, 70);
            this.txtNombDist.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombDist.Name = "txtNombDist";
            this.txtNombDist.Size = new System.Drawing.Size(115, 20);
            this.txtNombDist.TabIndex = 5;
            // 
            // txtCanton
            // 
            this.txtCanton.Location = new System.Drawing.Point(125, 194);
            this.txtCanton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCanton.Name = "txtCanton";
            this.txtCanton.Size = new System.Drawing.Size(115, 20);
            this.txtCanton.TabIndex = 6;
            // 
            // txtProvincia
            // 
            this.txtProvincia.Location = new System.Drawing.Point(125, 229);
            this.txtProvincia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtProvincia.Name = "txtProvincia";
            this.txtProvincia.Size = new System.Drawing.Size(115, 20);
            this.txtProvincia.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodDist,
            this.NombDist,
            this.canton,
            this.Prov});
            this.dataGridView1.Location = new System.Drawing.Point(69, 311);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(443, 53);
            this.dataGridView1.TabIndex = 8;
            // 
            // CodDist
            // 
            this.CodDist.HeaderText = "Codigo Distrito";
            this.CodDist.MinimumWidth = 8;
            this.CodDist.Name = "CodDist";
            this.CodDist.Width = 150;
            // 
            // NombDist
            // 
            this.NombDist.HeaderText = "Nombre Distrito";
            this.NombDist.MinimumWidth = 8;
            this.NombDist.Name = "NombDist";
            this.NombDist.Width = 150;
            // 
            // canton
            // 
            this.canton.HeaderText = "Cantón";
            this.canton.MinimumWidth = 8;
            this.canton.Name = "canton";
            this.canton.Width = 150;
            // 
            // Prov
            // 
            this.Prov.HeaderText = "Provincia";
            this.Prov.MinimumWidth = 8;
            this.Prov.Name = "Prov";
            this.Prov.Width = 150;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(35, 262);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(70, 29);
            this.btnNuevo.TabIndex = 9;
            this.btnNuevo.Text = "&Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(144, 262);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(70, 29);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(249, 262);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(70, 29);
            this.btnEditar.TabIndex = 11;
            this.btnEditar.Text = "&Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(361, 262);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(70, 29);
            this.btnEliminar.TabIndex = 12;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(463, 262);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(70, 29);
            this.btnSalir.TabIndex = 13;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnBuscarDist
            // 
            this.btnBuscarDist.Location = new System.Drawing.Point(303, 32);
            this.btnBuscarDist.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBuscarDist.Name = "btnBuscarDist";
            this.btnBuscarDist.Size = new System.Drawing.Size(69, 38);
            this.btnBuscarDist.TabIndex = 14;
            this.btnBuscarDist.Text = "&Buscar";
            this.btnBuscarDist.UseVisualStyleBackColor = true;
            this.btnBuscarDist.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblBuscaDist
            // 
            this.lblBuscaDist.AutoSize = true;
            this.lblBuscaDist.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscaDist.Location = new System.Drawing.Point(23, 13);
            this.lblBuscaDist.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBuscaDist.Name = "lblBuscaDist";
            this.lblBuscaDist.Size = new System.Drawing.Size(115, 17);
            this.lblBuscaDist.TabIndex = 15;
            this.lblBuscaDist.Text = "Buscar Distrito";
            this.lblBuscaDist.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblDatoDist
            // 
            this.lblDatoDist.AutoSize = true;
            this.lblDatoDist.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatoDist.Location = new System.Drawing.Point(23, 103);
            this.lblDatoDist.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDatoDist.Name = "lblDatoDist";
            this.lblDatoDist.Size = new System.Drawing.Size(134, 17);
            this.lblDatoDist.TabIndex = 16;
            this.lblDatoDist.Text = "Datos del Distrito";
            this.lblDatoDist.Click += new System.EventHandler(this.label6_Click);
            // 
            // lblCodDist1
            // 
            this.lblCodDist1.AutoSize = true;
            this.lblCodDist1.Location = new System.Drawing.Point(33, 135);
            this.lblCodDist1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodDist1.Name = "lblCodDist1";
            this.lblCodDist1.Size = new System.Drawing.Size(78, 13);
            this.lblCodDist1.TabIndex = 17;
            this.lblCodDist1.Text = "Código Distrito:";
            // 
            // txtCodDist1
            // 
            this.txtCodDist1.Location = new System.Drawing.Point(125, 131);
            this.txtCodDist1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCodDist1.Name = "txtCodDist1";
            this.txtCodDist1.Size = new System.Drawing.Size(115, 20);
            this.txtCodDist1.TabIndex = 18;
            // 
            // lblNombDist1
            // 
            this.lblNombDist1.AutoSize = true;
            this.lblNombDist1.Location = new System.Drawing.Point(33, 166);
            this.lblNombDist1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombDist1.Name = "lblNombDist1";
            this.lblNombDist1.Size = new System.Drawing.Size(82, 13);
            this.lblNombDist1.TabIndex = 19;
            this.lblNombDist1.Text = "Nombre Distrito:";
            this.lblNombDist1.Click += new System.EventHandler(this.lblNombDist1_Click);
            // 
            // txtNombDist1
            // 
            this.txtNombDist1.Location = new System.Drawing.Point(125, 162);
            this.txtNombDist1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombDist1.Name = "txtNombDist1";
            this.txtNombDist1.Size = new System.Drawing.Size(115, 20);
            this.txtNombDist1.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 378);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 15);
            this.label1.TabIndex = 21;
            this.label1.Text = "Doble Click Para Seleccionar";
            // 
            // frmMantDist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 404);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombDist1);
            this.Controls.Add(this.lblNombDist1);
            this.Controls.Add(this.txtCodDist1);
            this.Controls.Add(this.lblCodDist1);
            this.Controls.Add(this.lblDatoDist);
            this.Controls.Add(this.lblBuscaDist);
            this.Controls.Add(this.btnBuscarDist);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtProvincia);
            this.Controls.Add(this.txtCanton);
            this.Controls.Add(this.txtNombDist);
            this.Controls.Add(this.txtCodDist);
            this.Controls.Add(this.lblProvincia);
            this.Controls.Add(this.lblCanton);
            this.Controls.Add(this.lblNombDist);
            this.Controls.Add(this.lblCodDist);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmMantDist";
            this.Text = "Mantenimiento Distrito";
            this.Load += new System.EventHandler(this.frmMantDist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodDist;
        private System.Windows.Forms.Label lblNombDist;
        private System.Windows.Forms.Label lblCanton;
        private System.Windows.Forms.Label lblProvincia;
        private System.Windows.Forms.TextBox txtCodDist;
        private System.Windows.Forms.TextBox txtNombDist;
        private System.Windows.Forms.TextBox txtCanton;
        private System.Windows.Forms.TextBox txtProvincia;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodDist;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombDist;
        private System.Windows.Forms.DataGridViewTextBoxColumn canton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prov;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnBuscarDist;
        private System.Windows.Forms.Label lblBuscaDist;
        private System.Windows.Forms.Label lblDatoDist;
        private System.Windows.Forms.Label lblCodDist1;
        private System.Windows.Forms.TextBox txtCodDist1;
        private System.Windows.Forms.Label lblNombDist1;
        private System.Windows.Forms.TextBox txtNombDist1;
        private System.Windows.Forms.Label label1;
    }
}