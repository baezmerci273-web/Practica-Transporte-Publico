namespace Practica_Transporte_Publicoui

{
    partial class frmChofercs
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
            lblNombre = new Label();
            txtBuscar = new TextBox();
            txtNombre = new TextBox();
            txtCedula = new TextBox();
            lblCedula = new Label();
            lblTelefono = new Label();
            txtTelefono = new TextBox();
            txtApellido = new TextBox();
            txtLicencia = new TextBox();
            lblApellido = new Label();
            lblLicencia = new Label();
            btnLimpiar = new Button();
            btnRegistrar = new Button();
            dvgChofer = new DataGridView();
            clId = new DataGridViewTextBoxColumn();
            clNombre = new DataGridViewTextBoxColumn();
            clApellido = new DataGridViewTextBoxColumn();
            clCedula = new DataGridViewTextBoxColumn();
            clLicencia = new DataGridViewTextBoxColumn();
            clTelefono = new DataGridViewTextBoxColumn();
            clEstado = new DataGridViewButtonColumn();
            clEliminar = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dvgChofer).BeginInit();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(31, 51);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(67, 20);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre:";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(12, 12);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Buscar por Nombre, Apellido,Cédula o Licencia";
            txtBuscar.Size = new Size(450, 27);
            txtBuscar.TabIndex = 1;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(31, 74);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Ej: Pedro";
            txtNombre.Size = new Size(143, 27);
            txtNombre.TabIndex = 2;
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(31, 137);
            txtCedula.Name = "txtCedula";
            txtCedula.PlaceholderText = "Ej:000-1234567-8";
            txtCedula.Size = new Size(143, 27);
            txtCedula.TabIndex = 3;
            // 
            // lblCedula
            // 
            lblCedula.AutoSize = true;
            lblCedula.Location = new Point(31, 114);
            lblCedula.Name = "lblCedula";
            lblCedula.Size = new Size(58, 20);
            lblCedula.TabIndex = 4;
            lblCedula.Text = "Cédula:";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(31, 178);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(70, 20);
            lblTelefono.TabIndex = 5;
            lblTelefono.Text = "Teléfono:";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(31, 201);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.PlaceholderText = "000-000-0000";
            txtTelefono.Size = new Size(575, 27);
            txtTelefono.TabIndex = 6;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(291, 74);
            txtApellido.Name = "txtApellido";
            txtApellido.PlaceholderText = "Ej:Mendez";
            txtApellido.Size = new Size(142, 27);
            txtApellido.TabIndex = 7;
            // 
            // txtLicencia
            // 
            txtLicencia.Location = new Point(291, 137);
            txtLicencia.Name = "txtLicencia";
            txtLicencia.PlaceholderText = "Ej:L-12345678";
            txtLicencia.Size = new Size(142, 27);
            txtLicencia.TabIndex = 8;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(291, 51);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(69, 20);
            lblApellido.TabIndex = 9;
            lblApellido.Text = "Apellido:";
            // 
            // lblLicencia
            // 
            lblLicencia.AutoSize = true;
            lblLicencia.Location = new Point(291, 114);
            lblLicencia.Name = "lblLicencia";
            lblLicencia.Size = new Size(65, 20);
            lblLicencia.TabIndex = 10;
            lblLicencia.Text = "Licencia:";
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(378, 248);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(96, 37);
            btnLimpiar.TabIndex = 11;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = SystemColors.HotTrack;
            btnRegistrar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrar.ForeColor = SystemColors.ControlLightLight;
            btnRegistrar.Location = new Point(496, 248);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(153, 37);
            btnRegistrar.TabIndex = 12;
            btnRegistrar.Text = "Registrar Chofer";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // dvgChofer
            // 
            dvgChofer.BackgroundColor = SystemColors.ControlLight;
            dvgChofer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgChofer.Columns.AddRange(new DataGridViewColumn[] { clId, clNombre, clApellido, clCedula, clLicencia, clTelefono, clEstado, clEliminar });
            dvgChofer.Location = new Point(0, 291);
            dvgChofer.Name = "dvgChofer";
            dvgChofer.RowHeadersWidth = 51;
            dvgChofer.Size = new Size(1071, 188);
            dvgChofer.TabIndex = 13;
            // 
            // clId
            // 
            clId.DataPropertyName = "IdChofer";
            clId.HeaderText = "ID";
            clId.MinimumWidth = 6;
            clId.Name = "clId";
            clId.Width = 125;
            // 
            // clNombre
            // 
            clNombre.DataPropertyName = "Nombre";
            clNombre.HeaderText = "Nombre";
            clNombre.MinimumWidth = 6;
            clNombre.Name = "clNombre";
            clNombre.Width = 125;
            // 
            // clApellido
            // 
            clApellido.DataPropertyName = "Apellido";
            clApellido.HeaderText = "Apellido";
            clApellido.MinimumWidth = 6;
            clApellido.Name = "clApellido";
            clApellido.Width = 125;
            // 
            // clCedula
            // 
            clCedula.DataPropertyName = "Cedula";
            clCedula.HeaderText = "Cédula";
            clCedula.MinimumWidth = 6;
            clCedula.Name = "clCedula";
            clCedula.Width = 125;
            // 
            // clLicencia
            // 
            clLicencia.DataPropertyName = "Licencia";
            clLicencia.HeaderText = "Licencia";
            clLicencia.MinimumWidth = 6;
            clLicencia.Name = "clLicencia";
            clLicencia.Width = 125;
            // 
            // clTelefono
            // 
            clTelefono.DataPropertyName = "Telefono";
            clTelefono.HeaderText = "Teléfono";
            clTelefono.MinimumWidth = 6;
            clTelefono.Name = "clTelefono";
            clTelefono.Width = 125;
            // 
            // clEstado
            // 
            clEstado.DataPropertyName = "Estado";
            clEstado.HeaderText = "Estado";
            clEstado.MinimumWidth = 6;
            clEstado.Name = "clEstado";
            clEstado.Resizable = DataGridViewTriState.True;
            clEstado.SortMode = DataGridViewColumnSortMode.Automatic;
            clEstado.Width = 125;
            // 
            // clEliminar
            // 
            clEliminar.HeaderText = "Eliminar";
            clEliminar.MinimumWidth = 6;
            clEliminar.Name = "clEliminar";
            clEliminar.Resizable = DataGridViewTriState.True;
            clEliminar.SortMode = DataGridViewColumnSortMode.Automatic;
            clEliminar.UseColumnTextForButtonValue = true;
            clEliminar.Width = 125;
            // 
            // frmChofercs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuBar;
            ClientSize = new Size(804, 450);
            Controls.Add(dvgChofer);
            Controls.Add(btnRegistrar);
            Controls.Add(btnLimpiar);
            Controls.Add(lblLicencia);
            Controls.Add(lblApellido);
            Controls.Add(txtLicencia);
            Controls.Add(txtApellido);
            Controls.Add(txtTelefono);
            Controls.Add(lblTelefono);
            Controls.Add(lblCedula);
            Controls.Add(txtCedula);
            Controls.Add(txtNombre);
            Controls.Add(txtBuscar);
            Controls.Add(lblNombre);
            Name = "frmChofercs";
            Text = "Gestión de Chofer";
            Load += frmChofercs_Load;
            ((System.ComponentModel.ISupportInitialize)dvgChofer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private TextBox txtBuscar;
        private TextBox txtNombre;
        private TextBox txtCedula;
        private Label lblCedula;
        private Label lblTelefono;
        private TextBox txtTelefono;
        private TextBox txtApellido;
        private TextBox txtLicencia;
        private Label lblApellido;
        private Label lblLicencia;
        private Button btnLimpiar;
        private Button btnRegistrar;
        private DataGridView dvgChofer;
        private DataGridViewTextBoxColumn clId;
        private DataGridViewTextBoxColumn clNombre;
        private DataGridViewTextBoxColumn clApellido;
        private DataGridViewTextBoxColumn clCedula;
        private DataGridViewTextBoxColumn clLicencia;
        private DataGridViewTextBoxColumn clTelefono;
        private DataGridViewButtonColumn clEstado;
        private DataGridViewButtonColumn clEliminar;
    }
}