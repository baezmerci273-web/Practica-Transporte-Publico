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
            btnEliminar = new Button();
            btnRegistrar = new Button();
            btnLimpiar = new Button();
            txtBuscar = new TextBox();
            dgvTabla = new DataGridView();
            cmbTipo = new ComboBox();
            checkBox1 = new CheckBox();
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
            // btnEliminar
            // 
            btnEliminar.BackColor = SystemColors.ControlLightLight;
            btnEliminar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(128, 390);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(95, 37);
            btnEliminar.TabIndex = 10;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += BtnEliminar_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = SystemColors.Highlight;
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
            btnLimpiar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.ForeColor = SystemColors.ControlLightLight;
            btnLimpiar.Location = new Point(249, 390);
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
            dgvTabla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTabla.Location = new Point(366, 86);
            dgvTabla.Name = "dgvTabla";
            dgvTabla.RowHeadersWidth = 51;
            dgvTabla.Size = new Size(422, 245);
            dgvTabla.TabIndex = 15;
            // 
            // cmbTipo
            // 
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Items.AddRange(new object[] { "Todas", "", "Activas", "", "Inactivas" });
            cmbTipo.Location = new Point(672, 34);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(103, 28);
            cmbTipo.TabIndex = 16;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(128, 348);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(101, 24);
            checkBox1.TabIndex = 17;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // frmRutas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(800, 450);
            Controls.Add(checkBox1);
            Controls.Add(cmbTipo);
            Controls.Add(dgvTabla);
            Controls.Add(txtBuscar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnRegistrar);
            Controls.Add(btnEliminar);
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

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

       

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnLimpiar_Click1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
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
        private CheckBox checkBox1;
    }
}