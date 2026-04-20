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
            this.lblBuscaDist = new System.Windows.Forms.Label();
            this.lblDatoDist = new System.Windows.Forms.Label();
            this.lblCodDist1 = new System.Windows.Forms.Label();
            this.txtCodDist1 = new System.Windows.Forms.TextBox();
            this.lblNombDist1 = new System.Windows.Forms.Label();
            this.txtNombDist1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscarDist = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodDist
            // 
            this.lblCodDist.AutoSize = true;
            this.lblCodDist.Location = new System.Drawing.Point(34, 69);
            this.lblCodDist.Name = "lblCodDist";
            this.lblCodDist.Size = new System.Drawing.Size(117, 20);
            this.lblCodDist.TabIndex = 0;
            this.lblCodDist.Text = "Código Distrito:";
            this.lblCodDist.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblNombDist
            // 
            this.lblNombDist.AutoSize = true;
            this.lblNombDist.Location = new System.Drawing.Point(34, 111);
            this.lblNombDist.Name = "lblNombDist";
            this.lblNombDist.Size = new System.Drawing.Size(123, 20);
            this.lblNombDist.TabIndex = 1;
            this.lblNombDist.Text = "Nombre Distrito:";
            // 
            // lblCanton
            // 
            this.lblCanton.AutoSize = true;
            this.lblCanton.Location = new System.Drawing.Point(50, 305);
            this.lblCanton.Name = "lblCanton";
            this.lblCanton.Size = new System.Drawing.Size(61, 20);
            this.lblCanton.TabIndex = 2;
            this.lblCanton.Text = "Cantón";
            // 
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.Location = new System.Drawing.Point(50, 358);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(76, 20);
            this.lblProvincia.TabIndex = 3;
            this.lblProvincia.Text = "Provincia:";
            // 
            // txtCodDist
            // 
            this.txtCodDist.Location = new System.Drawing.Point(188, 66);
            this.txtCodDist.Name = "txtCodDist";
            this.txtCodDist.Size = new System.Drawing.Size(170, 26);
            this.txtCodDist.TabIndex = 4;
            // 
            // txtNombDist
            // 
            this.txtNombDist.Location = new System.Drawing.Point(188, 108);
            this.txtNombDist.Name = "txtNombDist";
            this.txtNombDist.Size = new System.Drawing.Size(170, 26);
            this.txtNombDist.TabIndex = 5;
            // 
            // txtCanton
            // 
            this.txtCanton.Location = new System.Drawing.Point(188, 298);
            this.txtCanton.Name = "txtCanton";
            this.txtCanton.Size = new System.Drawing.Size(170, 26);
            this.txtCanton.TabIndex = 6;
            // 
            // txtProvincia
            // 
            this.txtProvincia.Location = new System.Drawing.Point(188, 352);
            this.txtProvincia.Name = "txtProvincia";
            this.txtProvincia.Size = new System.Drawing.Size(170, 26);
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
            this.dataGridView1.Location = new System.Drawing.Point(155, 439);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(657, 75);
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
            // lblBuscaDist
            // 
            this.lblBuscaDist.AutoSize = true;
            this.lblBuscaDist.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscaDist.Location = new System.Drawing.Point(34, 20);
            this.lblBuscaDist.Name = "lblBuscaDist";
            this.lblBuscaDist.Size = new System.Drawing.Size(152, 25);
            this.lblBuscaDist.TabIndex = 15;
            this.lblBuscaDist.Text = "Buscar Distrito";
            this.lblBuscaDist.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblDatoDist
            // 
            this.lblDatoDist.AutoSize = true;
            this.lblDatoDist.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatoDist.Location = new System.Drawing.Point(34, 158);
            this.lblDatoDist.Name = "lblDatoDist";
            this.lblDatoDist.Size = new System.Drawing.Size(176, 25);
            this.lblDatoDist.TabIndex = 16;
            this.lblDatoDist.Text = "Datos del Distrito";
            this.lblDatoDist.Click += new System.EventHandler(this.label6_Click);
            // 
            // lblCodDist1
            // 
            this.lblCodDist1.AutoSize = true;
            this.lblCodDist1.Location = new System.Drawing.Point(50, 208);
            this.lblCodDist1.Name = "lblCodDist1";
            this.lblCodDist1.Size = new System.Drawing.Size(117, 20);
            this.lblCodDist1.TabIndex = 17;
            this.lblCodDist1.Text = "Código Distrito:";
            // 
            // txtCodDist1
            // 
            this.txtCodDist1.Location = new System.Drawing.Point(188, 202);
            this.txtCodDist1.Name = "txtCodDist1";
            this.txtCodDist1.Size = new System.Drawing.Size(170, 26);
            this.txtCodDist1.TabIndex = 18;
            // 
            // lblNombDist1
            // 
            this.lblNombDist1.AutoSize = true;
            this.lblNombDist1.Location = new System.Drawing.Point(50, 255);
            this.lblNombDist1.Name = "lblNombDist1";
            this.lblNombDist1.Size = new System.Drawing.Size(123, 20);
            this.lblNombDist1.TabIndex = 19;
            this.lblNombDist1.Text = "Nombre Distrito:";
            this.lblNombDist1.Click += new System.EventHandler(this.lblNombDist1_Click);
            // 
            // txtNombDist1
            // 
            this.txtNombDist1.Location = new System.Drawing.Point(188, 249);
            this.txtNombDist1.Name = "txtNombDist1";
            this.txtNombDist1.Size = new System.Drawing.Size(170, 26);
            this.txtNombDist1.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 582);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 22);
            this.label1.TabIndex = 21;
            this.label1.Text = "Doble Click Para Seleccionar";
            // 
            // btnBuscarDist
            // 
            this.btnBuscarDist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarDist.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarDist.Image")));
            this.btnBuscarDist.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBuscarDist.Location = new System.Drawing.Point(479, 43);
            this.btnBuscarDist.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBuscarDist.Name = "btnBuscarDist";
            this.btnBuscarDist.Size = new System.Drawing.Size(133, 88);
            this.btnBuscarDist.TabIndex = 22;
            this.btnBuscarDist.Text = "&Buscar";
            this.btnBuscarDist.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBuscarDist.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalir.Location = new System.Drawing.Point(717, 323);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(132, 84);
            this.btnSalir.TabIndex = 23;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEliminar.Location = new System.Drawing.Point(467, 323);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(117, 84);
            this.btnEliminar.TabIndex = 24;
            this.btnEliminar.Text = "&Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEditar.Location = new System.Drawing.Point(717, 194);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(132, 84);
            this.btnEditar.TabIndex = 25;
            this.btnEditar.Text = "&Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGuardar.Location = new System.Drawing.Point(467, 194);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(117, 84);
            this.btnGuardar.TabIndex = 26;
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // frmMantDist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 622);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnBuscarDist);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombDist1);
            this.Controls.Add(this.lblNombDist1);
            this.Controls.Add(this.txtCodDist1);
            this.Controls.Add(this.lblCodDist1);
            this.Controls.Add(this.lblDatoDist);
            this.Controls.Add(this.lblBuscaDist);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtProvincia);
            this.Controls.Add(this.txtCanton);
            this.Controls.Add(this.txtNombDist);
            this.Controls.Add(this.txtCodDist);
            this.Controls.Add(this.lblProvincia);
            this.Controls.Add(this.lblCanton);
            this.Controls.Add(this.lblNombDist);
            this.Controls.Add(this.lblCodDist);
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
        private System.Windows.Forms.Label lblBuscaDist;
        private System.Windows.Forms.Label lblDatoDist;
        private System.Windows.Forms.Label lblCodDist1;
        private System.Windows.Forms.TextBox txtCodDist1;
        private System.Windows.Forms.Label lblNombDist1;
        private System.Windows.Forms.TextBox txtNombDist1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscarDist;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnGuardar;
    }
}