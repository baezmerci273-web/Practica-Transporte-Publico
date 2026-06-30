namespace Practica_Transporte_Publicoui

{
    partial class frmRutas
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
            lblTitulo = new Label();
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblSalida = new Label();
            txtSalida = new TextBox();
            lblLlegada = new Label();
            txtLlegada = new TextBox();
            lblDistancia = new Label();
            txtDistancia = new TextBox();
            chkTieneAC = new CheckBox();
            btnRegistrar = new Button();
            btnLimpiar = new Button();
            txtBuscar = new TextBox();
            dgvTabla = new DataGridView();
            colid = new DataGridViewTextBoxColumn();
            colNombre = new DataGridViewTextBoxColumn();
            colSalida = new DataGridViewTextBoxColumn();
            colLlegada = new DataGridViewTextBoxColumn();
            colDistancia = new DataGridViewTextBoxColumn();
            clFecha = new DataGridViewTextBoxColumn();
            colTieneAC = new DataGridViewTextBoxColumn();
            colEliminar = new DataGridViewButtonColumn();
            ColEstado = new DataGridViewButtonColumn();
            chkActivas = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dgvTabla).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(12, 18);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(125, 20);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Datos De La Ruta";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(12, 63);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(67, 20);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(12, 86);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Ruta: Higuey - Punta Cana";
            txtNombre.Size = new Size(293, 27);
            txtNombre.TabIndex = 2;
            // 
            // lblSalida
            // 
            lblSalida.AutoSize = true;
            lblSalida.Location = new Point(12, 132);
            lblSalida.Name = "lblSalida";
            lblSalida.Size = new Size(53, 20);
            lblSalida.TabIndex = 3;
            lblSalida.Text = "Salida:";
            // 
            // txtSalida
            // 
            txtSalida.Location = new Point(12, 155);
            txtSalida.Name = "txtSalida";
            txtSalida.PlaceholderText = "Ej: Higuey";
            txtSalida.Size = new Size(293, 27);
            txtSalida.TabIndex = 4;
            // 
            // lblLlegada
            // 
            lblLlegada.AutoSize = true;
            lblLlegada.Location = new Point(12, 204);
            lblLlegada.Name = "lblLlegada";
            lblLlegada.Size = new Size(65, 20);
            lblLlegada.TabIndex = 5;
            lblLlegada.Text = "Llegada:";
            // 
            // txtLlegada
            // 
            txtLlegada.Location = new Point(12, 227);
            txtLlegada.Name = "txtLlegada";
            txtLlegada.PlaceholderText = "Ej:Punta Cana";
            txtLlegada.Size = new Size(293, 27);
            txtLlegada.TabIndex = 6;
            // 
            // lblDistancia
            // 
            lblDistancia.AutoSize = true;
            lblDistancia.Location = new Point(12, 281);
            lblDistancia.Name = "lblDistancia";
            lblDistancia.Size = new Size(106, 20);
            lblDistancia.TabIndex = 7;
            lblDistancia.Text = "Distancia (KM)";
            // 
            // txtDistancia
            // 
            txtDistancia.Location = new Point(12, 304);
            txtDistancia.Name = "txtDistancia";
            txtDistancia.PlaceholderText = "Ej:0";
            txtDistancia.Size = new Size(293, 27);
            txtDistancia.TabIndex = 8;
            // 
            // chkTieneAC
            // 
            chkTieneAC.AutoSize = true;
            chkTieneAC.BackColor = Color.Transparent;
            chkTieneAC.FlatStyle = FlatStyle.Popup;
            chkTieneAC.Location = new Point(12, 347);
            chkTieneAC.Name = "chkTieneAC";
            chkTieneAC.Size = new Size(87, 24);
            chkTieneAC.TabIndex = 9;
            chkTieneAC.Text = "Tiene AC";
            chkTieneAC.UseVisualStyleBackColor = false;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = SystemColors.Highlight;
            btnRegistrar.Cursor = Cursors.Hand;
            btnRegistrar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrar.ForeColor = SystemColors.ControlLightLight;
            btnRegistrar.ImageAlign = ContentAlignment.BottomCenter;
            btnRegistrar.Location = new Point(12, 390);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(96, 37);
            btnRegistrar.TabIndex = 11;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = SystemColors.ActiveBorder;
            btnLimpiar.BackgroundImageLayout = ImageLayout.Center;
            btnLimpiar.Cursor = Cursors.Hand;
            btnLimpiar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.ForeColor = SystemColors.ControlLightLight;
            btnLimpiar.Location = new Point(144, 390);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(98, 37);
            btnLimpiar.TabIndex = 12;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += BtnLimpiar_Click1;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(463, 34);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Buscar Ruta...";
            txtBuscar.Size = new Size(194, 27);
            txtBuscar.TabIndex = 13;
            // 
            // dgvTabla
            // 
            dgvTabla.BackgroundColor = SystemColors.Window;
            dgvTabla.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dgvTabla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTabla.Columns.AddRange(new DataGridViewColumn[] { colid, colNombre, colSalida, colLlegada, colDistancia, clFecha, colTieneAC, colEliminar, ColEstado });
            dgvTabla.Cursor = Cursors.Hand;
            dgvTabla.GridColor = SystemColors.Menu;
            dgvTabla.Location = new Point(400, 99);
            dgvTabla.Name = "dgvTabla";
            dgvTabla.RowHeadersWidth = 51;
            dgvTabla.Size = new Size(1041, 221);
            dgvTabla.TabIndex = 15;
            // 
            // colid
            // 
            colid.DataPropertyName = "IdRutas";
            colid.HeaderText = "ID";
            colid.MinimumWidth = 6;
            colid.Name = "colid";
            colid.Width = 125;
            // 
            // colNombre
            // 
            colNombre.DataPropertyName = "Nombre";
            colNombre.HeaderText = "Nombre";
            colNombre.MinimumWidth = 6;
            colNombre.Name = "colNombre";
            colNombre.Width = 125;
            // 
            // colSalida
            // 
            colSalida.DataPropertyName = "Salida";
            colSalida.HeaderText = "Salida";
            colSalida.MinimumWidth = 6;
            colSalida.Name = "colSalida";
            colSalida.Width = 125;
            // 
            // colLlegada
            // 
            colLlegada.DataPropertyName = "Llegada";
            colLlegada.HeaderText = "Llegada";
            colLlegada.MinimumWidth = 6;
            colLlegada.Name = "colLlegada";
            colLlegada.Width = 125;
            // 
            // colDistancia
            // 
            colDistancia.DataPropertyName = "DistanciaKM";
            colDistancia.HeaderText = "Distancia(KM)";
            colDistancia.MinimumWidth = 6;
            colDistancia.Name = "colDistancia";
            colDistancia.Width = 125;
            // 
            // clFecha
            // 
            clFecha.DataPropertyName = "Fecha";
            clFecha.HeaderText = "Fecha";
            clFecha.MinimumWidth = 6;
            clFecha.Name = "clFecha";
            clFecha.Width = 125;
            // 
            // colTieneAC
            // 
            colTieneAC.DataPropertyName = "TieneAC";
            colTieneAC.HeaderText = "TieneAC";
            colTieneAC.MinimumWidth = 6;
            colTieneAC.Name = "colTieneAC";
            colTieneAC.Width = 125;
            // 
            // colEliminar
            // 
            colEliminar.HeaderText = "Eliminar";
            colEliminar.MinimumWidth = 6;
            colEliminar.Name = "colEliminar";
            colEliminar.Resizable = DataGridViewTriState.True;
            colEliminar.SortMode = DataGridViewColumnSortMode.Automatic;
            colEliminar.Text = "Eliminar";
            colEliminar.UseColumnTextForButtonValue = true;
            colEliminar.Width = 125;
            // 
            // ColEstado
            // 
            ColEstado.DataPropertyName = "Estado";
            ColEstado.HeaderText = "Estado";
            ColEstado.MinimumWidth = 6;
            ColEstado.Name = "ColEstado";
            ColEstado.Resizable = DataGridViewTriState.True;
            ColEstado.SortMode = DataGridViewColumnSortMode.Automatic;
            ColEstado.Text = "Cambiar";
            ColEstado.Width = 125;
            // 
            // chkActivas
            // 
            chkActivas.AutoSize = true;
            chkActivas.Location = new Point(674, 36);
            chkActivas.Name = "chkActivas";
            chkActivas.Size = new Size(112, 24);
            chkActivas.TabIndex = 17;
            chkActivas.Text = "Solo Activas";
            chkActivas.UseVisualStyleBackColor = true;
            // 
            // frmRutas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuBar;
            ClientSize = new Size(800, 450);
            Controls.Add(chkActivas);
            Controls.Add(dgvTabla);
            Controls.Add(txtBuscar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnRegistrar);
            Controls.Add(chkTieneAC);
            Controls.Add(txtDistancia);
            Controls.Add(lblDistancia);
            Controls.Add(txtLlegada);
            Controls.Add(lblLlegada);
            Controls.Add(txtSalida);
            Controls.Add(lblSalida);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(lblTitulo);
            Name = "frmRutas";
            Text = "Gestión de Rutas";
            Load += frmRutas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTabla).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }











        #endregion

        private Label lblTitulo;
        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblSalida;
        private TextBox txtSalida;
        private Label lblLlegada;
        private TextBox txtLlegada;
        private Label lblDistancia;
        private TextBox txtDistancia;
        private CheckBox chkTieneAC;
        private Button btnEliminar;
        private Button btnRegistrar;
        private Button btnLimpiar;
        private TextBox txtBuscar;
        private DataGridView dgvTabla;
        private ComboBox cmbTipo;
        private CheckBox chkActivas;
        private DataGridViewTextBoxColumn colid;
        private DataGridViewTextBoxColumn colNombre;
        private DataGridViewTextBoxColumn colSalida;
        private DataGridViewTextBoxColumn colLlegada;
        private DataGridViewTextBoxColumn colDistancia;
        private DataGridViewTextBoxColumn clFecha;
        private DataGridViewTextBoxColumn colTieneAC;
        private DataGridViewButtonColumn colEliminar;
        private DataGridViewButtonColumn ColEstado;
    }
}