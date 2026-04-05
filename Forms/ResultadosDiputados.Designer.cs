namespace grupo01ProyectoFinal.Forms
{
    partial class frmResultadosDiputados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmResultadosDiputados));
            this.dgvVotosValidos = new System.Windows.Forms.DataGridView();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblDividendo = new System.Windows.Forms.Label();
            this.txtDividendo = new System.Windows.Forms.TextBox();
            this.txtCociente = new System.Windows.Forms.TextBox();
            this.lblCociente = new System.Windows.Forms.Label();
            this.txtSubcociente = new System.Windows.Forms.TextBox();
            this.lblSubcociente = new System.Windows.Forms.Label();
            this.txtDiputados = new System.Windows.Forms.TextBox();
            this.lblDiputados = new System.Windows.Forms.Label();
            this.cmbProvincias = new System.Windows.Forms.ComboBox();
            this.lblProvincia = new System.Windows.Forms.Label();
            this.dgvSubcociente = new System.Windows.Forms.DataGridView();
            this.dgvAsignacionCociente = new System.Windows.Forms.DataGridView();
            this.lblVotosEmitidos = new System.Windows.Forms.Label();
            this.lblCalculoSubcociente = new System.Windows.Forms.Label();
            this.lblAsignacionCociente = new System.Windows.Forms.Label();
            this.txtDiputadosAsignados = new System.Windows.Forms.TextBox();
            this.lblDiputadosAsignados = new System.Windows.Forms.Label();
            this.txtDiputadosxAsignar = new System.Windows.Forms.TextBox();
            this.lblDiputadosxAsignar = new System.Windows.Forms.Label();
            this.lblCalculoResiduo = new System.Windows.Forms.Label();
            this.dgvCalculoResiduo = new System.Windows.Forms.DataGridView();
            this.lblAsignacionResiduo = new System.Windows.Forms.Label();
            this.dgvAsignacionResiduo = new System.Windows.Forms.DataGridView();
            this.lblDeclaracionEleccion = new System.Windows.Forms.Label();
            this.dgvResultadosMomentaneos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVotosValidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubcociente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsignacionCociente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalculoResiduo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsignacionResiduo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultadosMomentaneos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVotosValidos
            // 
            this.dgvVotosValidos.AllowUserToAddRows = false;
            this.dgvVotosValidos.AllowUserToDeleteRows = false;
            this.dgvVotosValidos.AllowUserToResizeRows = false;
            this.dgvVotosValidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvVotosValidos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvVotosValidos.BackgroundColor = System.Drawing.Color.White;
            this.dgvVotosValidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVotosValidos.Location = new System.Drawing.Point(22, 73);
            this.dgvVotosValidos.MultiSelect = false;
            this.dgvVotosValidos.Name = "dgvVotosValidos";
            this.dgvVotosValidos.ReadOnly = true;
            this.dgvVotosValidos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvVotosValidos.RowHeadersVisible = false;
            this.dgvVotosValidos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvVotosValidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVotosValidos.Size = new System.Drawing.Size(410, 158);
            this.dgvVotosValidos.TabIndex = 28;
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefrescar.Image = ((System.Drawing.Image)(resources.GetObject("btnRefrescar.Image")));
            this.btnRefrescar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRefrescar.Location = new System.Drawing.Point(885, 39);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(105, 79);
            this.btnRefrescar.TabIndex = 27;
            this.btnRefrescar.Text = "&Refrescar";
            this.btnRefrescar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRefrescar.UseVisualStyleBackColor = true;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalir.Location = new System.Drawing.Point(885, 124);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(105, 79);
            this.btnSalir.TabIndex = 29;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblDividendo
            // 
            this.lblDividendo.AutoSize = true;
            this.lblDividendo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDividendo.Location = new System.Drawing.Point(447, 112);
            this.lblDividendo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDividendo.Name = "lblDividendo";
            this.lblDividendo.Size = new System.Drawing.Size(93, 20);
            this.lblDividendo.TabIndex = 168;
            this.lblDividendo.Text = "Dividendo:";
            // 
            // txtDividendo
            // 
            this.txtDividendo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDividendo.Location = new System.Drawing.Point(656, 109);
            this.txtDividendo.Name = "txtDividendo";
            this.txtDividendo.ReadOnly = true;
            this.txtDividendo.Size = new System.Drawing.Size(101, 26);
            this.txtDividendo.TabIndex = 169;
            // 
            // txtCociente
            // 
            this.txtCociente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCociente.Location = new System.Drawing.Point(656, 173);
            this.txtCociente.Name = "txtCociente";
            this.txtCociente.ReadOnly = true;
            this.txtCociente.Size = new System.Drawing.Size(101, 26);
            this.txtCociente.TabIndex = 171;
            // 
            // lblCociente
            // 
            this.lblCociente.AutoSize = true;
            this.lblCociente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCociente.Location = new System.Drawing.Point(447, 176);
            this.lblCociente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCociente.Name = "lblCociente";
            this.lblCociente.Size = new System.Drawing.Size(85, 20);
            this.lblCociente.TabIndex = 170;
            this.lblCociente.Text = "Cociente:";
            // 
            // txtSubcociente
            // 
            this.txtSubcociente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubcociente.Location = new System.Drawing.Point(656, 205);
            this.txtSubcociente.Name = "txtSubcociente";
            this.txtSubcociente.ReadOnly = true;
            this.txtSubcociente.Size = new System.Drawing.Size(101, 26);
            this.txtSubcociente.TabIndex = 173;
            // 
            // lblSubcociente
            // 
            this.lblSubcociente.AutoSize = true;
            this.lblSubcociente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubcociente.Location = new System.Drawing.Point(447, 208);
            this.lblSubcociente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSubcociente.Name = "lblSubcociente";
            this.lblSubcociente.Size = new System.Drawing.Size(114, 20);
            this.lblSubcociente.TabIndex = 172;
            this.lblSubcociente.Text = "Subcociente:";
            // 
            // txtDiputados
            // 
            this.txtDiputados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiputados.Location = new System.Drawing.Point(656, 141);
            this.txtDiputados.Name = "txtDiputados";
            this.txtDiputados.ReadOnly = true;
            this.txtDiputados.Size = new System.Drawing.Size(101, 26);
            this.txtDiputados.TabIndex = 175;
            // 
            // lblDiputados
            // 
            this.lblDiputados.AutoSize = true;
            this.lblDiputados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiputados.Location = new System.Drawing.Point(447, 144);
            this.lblDiputados.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDiputados.Name = "lblDiputados";
            this.lblDiputados.Size = new System.Drawing.Size(204, 20);
            this.lblDiputados.TabIndex = 174;
            this.lblDiputados.Text = "Diputados por Provincia:";
            // 
            // cmbProvincias
            // 
            this.cmbProvincias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProvincias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProvincias.FormattingEnabled = true;
            this.cmbProvincias.Location = new System.Drawing.Point(525, 27);
            this.cmbProvincias.Name = "cmbProvincias";
            this.cmbProvincias.Size = new System.Drawing.Size(232, 28);
            this.cmbProvincias.TabIndex = 177;
            // 
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProvincia.Location = new System.Drawing.Point(428, 30);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(91, 20);
            this.lblProvincia.TabIndex = 176;
            this.lblProvincia.Text = "Provincia: ";
            // 
            // dgvSubcociente
            // 
            this.dgvSubcociente.AllowUserToAddRows = false;
            this.dgvSubcociente.AllowUserToDeleteRows = false;
            this.dgvSubcociente.AllowUserToResizeRows = false;
            this.dgvSubcociente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvSubcociente.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSubcociente.BackgroundColor = System.Drawing.Color.White;
            this.dgvSubcociente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubcociente.Location = new System.Drawing.Point(22, 268);
            this.dgvSubcociente.MultiSelect = false;
            this.dgvSubcociente.Name = "dgvSubcociente";
            this.dgvSubcociente.ReadOnly = true;
            this.dgvSubcociente.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvSubcociente.RowHeadersVisible = false;
            this.dgvSubcociente.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvSubcociente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSubcociente.Size = new System.Drawing.Size(410, 130);
            this.dgvSubcociente.TabIndex = 178;
            // 
            // dgvAsignacionCociente
            // 
            this.dgvAsignacionCociente.AllowUserToAddRows = false;
            this.dgvAsignacionCociente.AllowUserToDeleteRows = false;
            this.dgvAsignacionCociente.AllowUserToResizeRows = false;
            this.dgvAsignacionCociente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvAsignacionCociente.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAsignacionCociente.BackgroundColor = System.Drawing.Color.White;
            this.dgvAsignacionCociente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsignacionCociente.Location = new System.Drawing.Point(451, 268);
            this.dgvAsignacionCociente.MultiSelect = false;
            this.dgvAsignacionCociente.Name = "dgvAsignacionCociente";
            this.dgvAsignacionCociente.ReadOnly = true;
            this.dgvAsignacionCociente.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvAsignacionCociente.RowHeadersVisible = false;
            this.dgvAsignacionCociente.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvAsignacionCociente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAsignacionCociente.Size = new System.Drawing.Size(735, 130);
            this.dgvAsignacionCociente.TabIndex = 179;
            // 
            // lblVotosEmitidos
            // 
            this.lblVotosEmitidos.AutoSize = true;
            this.lblVotosEmitidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVotosEmitidos.Location = new System.Drawing.Point(18, 50);
            this.lblVotosEmitidos.Name = "lblVotosEmitidos";
            this.lblVotosEmitidos.Size = new System.Drawing.Size(194, 20);
            this.lblVotosEmitidos.TabIndex = 180;
            this.lblVotosEmitidos.Text = "Votos Válidos Emitidos";
            // 
            // lblCalculoSubcociente
            // 
            this.lblCalculoSubcociente.AutoSize = true;
            this.lblCalculoSubcociente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalculoSubcociente.Location = new System.Drawing.Point(18, 245);
            this.lblCalculoSubcociente.Name = "lblCalculoSubcociente";
            this.lblCalculoSubcociente.Size = new System.Drawing.Size(202, 20);
            this.lblCalculoSubcociente.TabIndex = 181;
            this.lblCalculoSubcociente.Text = "Cálculo del Subcociente";
            // 
            // lblAsignacionCociente
            // 
            this.lblAsignacionCociente.AutoSize = true;
            this.lblAsignacionCociente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsignacionCociente.Location = new System.Drawing.Point(449, 245);
            this.lblAsignacionCociente.Name = "lblAsignacionCociente";
            this.lblAsignacionCociente.Size = new System.Drawing.Size(173, 20);
            this.lblAsignacionCociente.TabIndex = 182;
            this.lblAsignacionCociente.Text = "Asignación Cociente";
            // 
            // txtDiputadosAsignados
            // 
            this.txtDiputadosAsignados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiputadosAsignados.Location = new System.Drawing.Point(1195, 291);
            this.txtDiputadosAsignados.Name = "txtDiputadosAsignados";
            this.txtDiputadosAsignados.ReadOnly = true;
            this.txtDiputadosAsignados.Size = new System.Drawing.Size(101, 26);
            this.txtDiputadosAsignados.TabIndex = 184;
            // 
            // lblDiputadosAsignados
            // 
            this.lblDiputadosAsignados.AutoSize = true;
            this.lblDiputadosAsignados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiputadosAsignados.Location = new System.Drawing.Point(1191, 268);
            this.lblDiputadosAsignados.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDiputadosAsignados.Name = "lblDiputadosAsignados";
            this.lblDiputadosAsignados.Size = new System.Drawing.Size(185, 20);
            this.lblDiputadosAsignados.TabIndex = 183;
            this.lblDiputadosAsignados.Text = "Diputados Asignados:";
            // 
            // txtDiputadosxAsignar
            // 
            this.txtDiputadosxAsignar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiputadosxAsignar.Location = new System.Drawing.Point(1195, 364);
            this.txtDiputadosxAsignar.Name = "txtDiputadosxAsignar";
            this.txtDiputadosxAsignar.ReadOnly = true;
            this.txtDiputadosxAsignar.Size = new System.Drawing.Size(101, 26);
            this.txtDiputadosxAsignar.TabIndex = 186;
            // 
            // lblDiputadosxAsignar
            // 
            this.lblDiputadosxAsignar.AutoSize = true;
            this.lblDiputadosxAsignar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiputadosxAsignar.Location = new System.Drawing.Point(1191, 341);
            this.lblDiputadosxAsignar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDiputadosxAsignar.Name = "lblDiputadosxAsignar";
            this.lblDiputadosxAsignar.Size = new System.Drawing.Size(175, 20);
            this.lblDiputadosxAsignar.TabIndex = 185;
            this.lblDiputadosxAsignar.Text = "Diputados x Asignar:";
            // 
            // lblCalculoResiduo
            // 
            this.lblCalculoResiduo.AutoSize = true;
            this.lblCalculoResiduo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalculoResiduo.Location = new System.Drawing.Point(20, 408);
            this.lblCalculoResiduo.Name = "lblCalculoResiduo";
            this.lblCalculoResiduo.Size = new System.Drawing.Size(164, 20);
            this.lblCalculoResiduo.TabIndex = 188;
            this.lblCalculoResiduo.Text = "Cálculo de Residuo";
            // 
            // dgvCalculoResiduo
            // 
            this.dgvCalculoResiduo.AllowUserToAddRows = false;
            this.dgvCalculoResiduo.AllowUserToDeleteRows = false;
            this.dgvCalculoResiduo.AllowUserToResizeRows = false;
            this.dgvCalculoResiduo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvCalculoResiduo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCalculoResiduo.BackgroundColor = System.Drawing.Color.White;
            this.dgvCalculoResiduo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCalculoResiduo.Location = new System.Drawing.Point(22, 431);
            this.dgvCalculoResiduo.MultiSelect = false;
            this.dgvCalculoResiduo.Name = "dgvCalculoResiduo";
            this.dgvCalculoResiduo.ReadOnly = true;
            this.dgvCalculoResiduo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvCalculoResiduo.RowHeadersVisible = false;
            this.dgvCalculoResiduo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvCalculoResiduo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCalculoResiduo.Size = new System.Drawing.Size(735, 122);
            this.dgvCalculoResiduo.TabIndex = 187;
            // 
            // lblAsignacionResiduo
            // 
            this.lblAsignacionResiduo.AutoSize = true;
            this.lblAsignacionResiduo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsignacionResiduo.Location = new System.Drawing.Point(762, 408);
            this.lblAsignacionResiduo.Name = "lblAsignacionResiduo";
            this.lblAsignacionResiduo.Size = new System.Drawing.Size(168, 20);
            this.lblAsignacionResiduo.TabIndex = 190;
            this.lblAsignacionResiduo.Text = "Asignación Residuo";
            // 
            // dgvAsignacionResiduo
            // 
            this.dgvAsignacionResiduo.AllowUserToAddRows = false;
            this.dgvAsignacionResiduo.AllowUserToDeleteRows = false;
            this.dgvAsignacionResiduo.AllowUserToResizeRows = false;
            this.dgvAsignacionResiduo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvAsignacionResiduo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAsignacionResiduo.BackgroundColor = System.Drawing.Color.White;
            this.dgvAsignacionResiduo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsignacionResiduo.Location = new System.Drawing.Point(764, 431);
            this.dgvAsignacionResiduo.MultiSelect = false;
            this.dgvAsignacionResiduo.Name = "dgvAsignacionResiduo";
            this.dgvAsignacionResiduo.ReadOnly = true;
            this.dgvAsignacionResiduo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvAsignacionResiduo.RowHeadersVisible = false;
            this.dgvAsignacionResiduo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvAsignacionResiduo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAsignacionResiduo.Size = new System.Drawing.Size(735, 122);
            this.dgvAsignacionResiduo.TabIndex = 189;
            // 
            // lblDeclaracionEleccion
            // 
            this.lblDeclaracionEleccion.AutoSize = true;
            this.lblDeclaracionEleccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeclaracionEleccion.Location = new System.Drawing.Point(22, 568);
            this.lblDeclaracionEleccion.Name = "lblDeclaracionEleccion";
            this.lblDeclaracionEleccion.Size = new System.Drawing.Size(281, 20);
            this.lblDeclaracionEleccion.TabIndex = 192;
            this.lblDeclaracionEleccion.Text = "Resultados Finales Momentaneos";
            // 
            // dgvResultadosMomentaneos
            // 
            this.dgvResultadosMomentaneos.AllowUserToAddRows = false;
            this.dgvResultadosMomentaneos.AllowUserToDeleteRows = false;
            this.dgvResultadosMomentaneos.AllowUserToResizeRows = false;
            this.dgvResultadosMomentaneos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvResultadosMomentaneos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvResultadosMomentaneos.BackgroundColor = System.Drawing.Color.White;
            this.dgvResultadosMomentaneos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultadosMomentaneos.Location = new System.Drawing.Point(24, 591);
            this.dgvResultadosMomentaneos.MultiSelect = false;
            this.dgvResultadosMomentaneos.Name = "dgvResultadosMomentaneos";
            this.dgvResultadosMomentaneos.ReadOnly = true;
            this.dgvResultadosMomentaneos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvResultadosMomentaneos.RowHeadersVisible = false;
            this.dgvResultadosMomentaneos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvResultadosMomentaneos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResultadosMomentaneos.Size = new System.Drawing.Size(1080, 122);
            this.dgvResultadosMomentaneos.TabIndex = 191;
            // 
            // frmResultadosDiputados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1521, 734);
            this.Controls.Add(this.lblDeclaracionEleccion);
            this.Controls.Add(this.dgvResultadosMomentaneos);
            this.Controls.Add(this.lblAsignacionResiduo);
            this.Controls.Add(this.dgvAsignacionResiduo);
            this.Controls.Add(this.lblCalculoResiduo);
            this.Controls.Add(this.dgvCalculoResiduo);
            this.Controls.Add(this.txtDiputadosxAsignar);
            this.Controls.Add(this.lblDiputadosxAsignar);
            this.Controls.Add(this.txtDiputadosAsignados);
            this.Controls.Add(this.lblDiputadosAsignados);
            this.Controls.Add(this.lblAsignacionCociente);
            this.Controls.Add(this.lblCalculoSubcociente);
            this.Controls.Add(this.lblVotosEmitidos);
            this.Controls.Add(this.dgvAsignacionCociente);
            this.Controls.Add(this.dgvSubcociente);
            this.Controls.Add(this.cmbProvincias);
            this.Controls.Add(this.lblProvincia);
            this.Controls.Add(this.txtDiputados);
            this.Controls.Add(this.lblDiputados);
            this.Controls.Add(this.txtSubcociente);
            this.Controls.Add(this.lblSubcociente);
            this.Controls.Add(this.txtCociente);
            this.Controls.Add(this.lblCociente);
            this.Controls.Add(this.txtDividendo);
            this.Controls.Add(this.lblDividendo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgvVotosValidos);
            this.Controls.Add(this.btnRefrescar);
            this.Name = "frmResultadosDiputados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resultados Diputados";
            this.Load += new System.EventHandler(this.frmResultadosDiputados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVotosValidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubcociente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsignacionCociente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalculoResiduo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsignacionResiduo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultadosMomentaneos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVotosValidos;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblDividendo;
        private System.Windows.Forms.TextBox txtDividendo;
        private System.Windows.Forms.TextBox txtCociente;
        private System.Windows.Forms.Label lblCociente;
        private System.Windows.Forms.TextBox txtSubcociente;
        private System.Windows.Forms.Label lblSubcociente;
        private System.Windows.Forms.TextBox txtDiputados;
        private System.Windows.Forms.Label lblDiputados;
        private System.Windows.Forms.ComboBox cmbProvincias;
        private System.Windows.Forms.Label lblProvincia;
        private System.Windows.Forms.DataGridView dgvSubcociente;
        private System.Windows.Forms.DataGridView dgvAsignacionCociente;
        private System.Windows.Forms.Label lblVotosEmitidos;
        private System.Windows.Forms.Label lblCalculoSubcociente;
        private System.Windows.Forms.Label lblAsignacionCociente;
        private System.Windows.Forms.TextBox txtDiputadosAsignados;
        private System.Windows.Forms.Label lblDiputadosAsignados;
        private System.Windows.Forms.TextBox txtDiputadosxAsignar;
        private System.Windows.Forms.Label lblDiputadosxAsignar;
        private System.Windows.Forms.Label lblCalculoResiduo;
        private System.Windows.Forms.DataGridView dgvCalculoResiduo;
        private System.Windows.Forms.Label lblAsignacionResiduo;
        private System.Windows.Forms.DataGridView dgvAsignacionResiduo;
        private System.Windows.Forms.Label lblDeclaracionEleccion;
        private System.Windows.Forms.DataGridView dgvResultadosMomentaneos;
    }
}