namespace Practica_Transporte_Publicoui

{
    partial class frmVehiculo
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
            components = new System.ComponentModel.Container();
            txtBuscar = new TextBox();
            lblPlaca = new Label();
            txtPlaca = new TextBox();
            txtMarca = new TextBox();
            lblMarca = new Label();
            lblModelo = new Label();
            txtModelo = new TextBox();
            txtAnio = new TextBox();
            txtCapacidad = new TextBox();
            lblanio = new Label();
            lblCapacidad = new Label();
            lblTipo = new Label();
            cboTipo = new ComboBox();
            vehiculoBindingSource = new BindingSource(components);
            btnRegistrar = new Button();
            btnLimpiar = new Button();
            dgvVehiculo = new DataGridView();
            clId = new DataGridViewTextBoxColumn();
            clPlaca = new DataGridViewTextBoxColumn();
            clModelo = new DataGridViewTextBoxColumn();
            clAnio = new DataGridViewTextBoxColumn();
            clCapacidad = new DataGridViewTextBoxColumn();
            clEstado = new DataGridViewButtonColumn();
            clTipo = new DataGridViewTextBoxColumn();
            clTarifa = new DataGridViewTextBoxColumn();
            clEliminar = new DataGridViewButtonColumn();
            clEditar = new DataGridViewButtonColumn();
            lblTarifa = new Label();
            txtTarifa = new TextBox();
            cboTipoTarifa = new ComboBox();
            lblTarifaTipo = new Label();
            btntarifa = new Button();
            ((System.ComponentModel.ISupportInitialize)vehiculoBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvVehiculo).BeginInit();
            SuspendLayout();
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(12, 24);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Buscar por placa, marca, modelo...";
            txtBuscar.Size = new Size(490, 27);
            txtBuscar.TabIndex = 0;
            // 
            // lblPlaca
            // 
            lblPlaca.AutoSize = true;
            lblPlaca.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPlaca.Location = new Point(12, 67);
            lblPlaca.Name = "lblPlaca";
            lblPlaca.Size = new Size(45, 20);
            lblPlaca.TabIndex = 1;
            lblPlaca.Text = "Placa";
            // 
            // txtPlaca
            // 
            txtPlaca.Location = new Point(12, 90);
            txtPlaca.Name = "txtPlaca";
            txtPlaca.PlaceholderText = "Ej:A123445";
            txtPlaca.Size = new Size(176, 27);
            txtPlaca.TabIndex = 2;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(269, 90);
            txtMarca.Name = "txtMarca";
            txtMarca.PlaceholderText = "Ej:Marca X";
            txtMarca.Size = new Size(176, 27);
            txtMarca.TabIndex = 3;
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMarca.Location = new Point(269, 67);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(52, 20);
            lblMarca.TabIndex = 4;
            lblMarca.Text = "Marca";
            // 
            // lblModelo
            // 
            lblModelo.AutoSize = true;
            lblModelo.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblModelo.Location = new Point(496, 67);
            lblModelo.Name = "lblModelo";
            lblModelo.Size = new Size(62, 20);
            lblModelo.TabIndex = 5;
            lblModelo.Text = "Modelo";
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(496, 94);
            txtModelo.Name = "txtModelo";
            txtModelo.PlaceholderText = "Ej: modelo x";
            txtModelo.Size = new Size(176, 27);
            txtModelo.TabIndex = 6;
            // 
            // txtAnio
            // 
            txtAnio.Location = new Point(12, 170);
            txtAnio.Name = "txtAnio";
            txtAnio.PlaceholderText = "Ej:2020";
            txtAnio.Size = new Size(176, 27);
            txtAnio.TabIndex = 7;
            // 
            // txtCapacidad
            // 
            txtCapacidad.Location = new Point(269, 170);
            txtCapacidad.Name = "txtCapacidad";
            txtCapacidad.PlaceholderText = "Ej: 0";
            txtCapacidad.Size = new Size(176, 27);
            txtCapacidad.TabIndex = 8;
            // 
            // lblanio
            // 
            lblanio.AutoSize = true;
            lblanio.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblanio.Location = new Point(12, 147);
            lblanio.Name = "lblanio";
            lblanio.Size = new Size(37, 20);
            lblanio.TabIndex = 10;
            lblanio.Text = "Año";
            // 
            // lblCapacidad
            // 
            lblCapacidad.AutoSize = true;
            lblCapacidad.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCapacidad.Location = new Point(271, 147);
            lblCapacidad.Name = "lblCapacidad";
            lblCapacidad.Size = new Size(80, 20);
            lblCapacidad.TabIndex = 11;
            lblCapacidad.Text = "Capacidad";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTipo.Location = new Point(496, 147);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(39, 20);
            lblTipo.TabIndex = 12;
            lblTipo.Text = "Tipo";
            // 
            // cboTipo
            // 
            cboTipo.FormattingEnabled = true;
            cboTipo.Location = new Point(496, 170);
            cboTipo.Name = "cboTipo";
            cboTipo.Size = new Size(176, 28);
            cboTipo.TabIndex = 13;
            // 
            // vehiculoBindingSource
            // 
            vehiculoBindingSource.DataSource = typeof(Datos.Vehiculo);
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = SystemColors.HotTrack;
            btnRegistrar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrar.ForeColor = SystemColors.ControlLightLight;
            btnRegistrar.Location = new Point(587, 208);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(94, 40);
            btnRegistrar.TabIndex = 15;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = SystemColors.MenuBar;
            btnLimpiar.Location = new Point(470, 208);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(97, 40);
            btnLimpiar.TabIndex = 16;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // dgvVehiculo
            // 
            dgvVehiculo.BackgroundColor = SystemColors.InactiveBorder;
            dgvVehiculo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVehiculo.Columns.AddRange(new DataGridViewColumn[] { clId, clPlaca, clModelo, clAnio, clCapacidad, clEstado, clTipo, clTarifa, clEliminar, clEditar });
            dgvVehiculo.GridColor = SystemColors.Window;
            dgvVehiculo.Location = new Point(12, 288);
            dgvVehiculo.Name = "dgvVehiculo";
            dgvVehiculo.RowHeadersWidth = 51;
            dgvVehiculo.Size = new Size(1056, 188);
            dgvVehiculo.TabIndex = 14;
            dgvVehiculo.CellContentClick += dgvVehiculo_CellContentClick;
            dgvVehiculo.CellFormatting += dgvVehiculo_CellFormatting;
            // 
            // clId
            // 
            clId.DataPropertyName = "idvehiculo";
            clId.HeaderText = "ID";
            clId.MinimumWidth = 6;
            clId.Name = "clId";
            clId.Width = 125;
            // 
            // clPlaca
            // 
            clPlaca.DataPropertyName = "placa";
            clPlaca.HeaderText = "Placa";
            clPlaca.MinimumWidth = 6;
            clPlaca.Name = "clPlaca";
            clPlaca.Width = 125;
            // 
            // clModelo
            // 
            clModelo.DataPropertyName = "modelo";
            clModelo.HeaderText = "Modelo";
            clModelo.MinimumWidth = 6;
            clModelo.Name = "clModelo";
            clModelo.Width = 125;
            // 
            // clAnio
            // 
            clAnio.DataPropertyName = "anio";
            clAnio.HeaderText = "Año";
            clAnio.MinimumWidth = 6;
            clAnio.Name = "clAnio";
            clAnio.Width = 125;
            // 
            // clCapacidad
            // 
            clCapacidad.DataPropertyName = "capacidad";
            clCapacidad.HeaderText = "Capacidad";
            clCapacidad.MinimumWidth = 6;
            clCapacidad.Name = "clCapacidad";
            clCapacidad.Width = 125;
            // 
            // clEstado
            // 
            clEstado.DataPropertyName = "estado";
            clEstado.HeaderText = "Estado";
            clEstado.MinimumWidth = 6;
            clEstado.Name = "clEstado";
            clEstado.Resizable = DataGridViewTriState.True;
            clEstado.SortMode = DataGridViewColumnSortMode.Automatic;
            clEstado.UseColumnTextForButtonValue = true;
            clEstado.Width = 125;
            // 
            // clTipo
            // 
            clTipo.DataPropertyName = "tipo";
            clTipo.HeaderText = "Tipo";
            clTipo.MinimumWidth = 6;
            clTipo.Name = "clTipo";
            clTipo.Width = 125;
            // 
            // clTarifa
            // 
            clTarifa.DataPropertyName = "tarifa";
            clTarifa.HeaderText = "Tarifa";
            clTarifa.MinimumWidth = 6;
            clTarifa.Name = "clTarifa";
            clTarifa.Width = 125;
            // 
            // clEliminar
            // 
            clEliminar.HeaderText = "Eliminar";
            clEliminar.MinimumWidth = 6;
            clEliminar.Name = "clEliminar";
            clEliminar.Text = "Eliminar";
            clEliminar.UseColumnTextForButtonValue = true;
            clEliminar.Width = 125;
            // 
            // clEditar
            // 
            clEditar.HeaderText = "Editar";
            clEditar.MinimumWidth = 6;
            clEditar.Name = "clEditar";
            clEditar.Text = "Editar";
            clEditar.UseColumnTextForButtonValue = true;
            clEditar.Width = 125;
            // 
            // lblTarifa
            // 
            lblTarifa.AutoSize = true;
            lblTarifa.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTarifa.Location = new Point(740, 67);
            lblTarifa.Name = "lblTarifa";
            lblTarifa.Size = new Size(91, 20);
            lblTarifa.TabIndex = 17;
            lblTarifa.Text = "Editar Tarifa";
            lblTarifa.Click += lblTarifa_Click;
            // 
            // txtTarifa
            // 
            txtTarifa.Location = new Point(740, 90);
            txtTarifa.Name = "txtTarifa";
            txtTarifa.Size = new Size(176, 27);
            txtTarifa.TabIndex = 18;
            txtTarifa.TextChanged += txtTarifa_TextChanged;
            // 
            // comboBox1
            // 
            cboTipoTarifa.FormattingEnabled = true;
            cboTipoTarifa.Location = new Point(948, 89);
            cboTipoTarifa.Name = "comboBox1";
            cboTipoTarifa.Size = new Size(140, 28);
            cboTipoTarifa.TabIndex = 19;
            // 
            // lblTarifaTipo
            // 
            lblTarifaTipo.AutoSize = true;
            lblTarifaTipo.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTarifaTipo.Location = new Point(948, 66);
            lblTarifaTipo.Name = "lblTarifaTipo";
            lblTarifaTipo.Size = new Size(116, 20);
            lblTarifaTipo.TabIndex = 20;
            lblTarifaTipo.Text = "Tipo para Tarifa";
            lblTarifaTipo.Click += lblTarifaTipo_Click;
            // 
            
            // 
            // btntarifa
            // 
            btntarifa.BackColor = SystemColors.HotTrack;
            btntarifa.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btntarifa.ForeColor = SystemColors.ControlLightLight;
            btntarifa.Location = new Point(740, 134);
            btntarifa.Name = "btntarifa";
            btntarifa.Size = new Size(129, 46);
            btntarifa.TabIndex = 23;
            btntarifa.Text = "Guardar Tarifa";
            btntarifa.UseVisualStyleBackColor = false;
            btntarifa.Click += btntarifa_Click;
            // 
            // frmVehiculo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveBorder;
            ClientSize = new Size(1110, 528);
            Controls.Add(btntarifa);
           
            Controls.Add(lblTarifaTipo);
            Controls.Add(cboTipoTarifa);
            Controls.Add(txtTarifa);
            Controls.Add(lblTarifa);
            Controls.Add(btnLimpiar);
            Controls.Add(btnRegistrar);
            Controls.Add(dgvVehiculo);
            Controls.Add(cboTipo);
            Controls.Add(lblTipo);
            Controls.Add(lblCapacidad);
            Controls.Add(lblanio);
            Controls.Add(txtCapacidad);
            Controls.Add(txtAnio);
            Controls.Add(txtModelo);
            Controls.Add(lblModelo);
            Controls.Add(lblMarca);
            Controls.Add(txtMarca);
            Controls.Add(txtPlaca);
            Controls.Add(lblPlaca);
            Controls.Add(txtBuscar);
            Name = "frmVehiculo";
            Text = "Gestion de Vehiculo";
            Load += frmVehiculo_Load;
            ((System.ComponentModel.ISupportInitialize)vehiculoBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvVehiculo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private TextBox txtBuscar;
        private Label lblPlaca;
        private TextBox txtPlaca;
        private TextBox txtMarca;
        private Label lblMarca;
        private Label lblModelo;
        private TextBox txtModelo;
        private TextBox txtAnio;
        private TextBox txtCapacidad;
        private Label lblanio;
        private Label lblCapacidad;
        private Label lblTipo;
        private ComboBox cboTipo;
        private BindingSource vehiculoBindingSource;
        private DataGridView dgvVehiculo;
        private Button btnRegistrar;
        private Button btnLimpiar;
        private DataGridViewTextBoxColumn clId;
        private DataGridViewTextBoxColumn clPlaca;
        private DataGridViewTextBoxColumn clModelo;
        private DataGridViewTextBoxColumn clAnio;
        private DataGridViewTextBoxColumn clCapacidad;
        private DataGridViewButtonColumn clEstado;
        private DataGridViewTextBoxColumn clTipo;
        private DataGridViewTextBoxColumn clTarifa;
        private DataGridViewButtonColumn clEliminar;
        private DataGridViewButtonColumn clEditar;
        private Label lblTarifa;
        private TextBox txtTarifa;
        private ComboBox cboTipoTarifa;
        private Label lblTarifaTipo;
       
        private Button btntarifa;
    }
}