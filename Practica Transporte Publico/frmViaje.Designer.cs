namespace Practica_Transporte_Publicoui

{
    partial class frmViaje
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
            txtBuscar = new TextBox();
            lblRuta = new Label();
            lblChofer = new Label();
            cboChofer = new ComboBox();
            cboRuta = new ComboBox();
            cboEstado = new ComboBox();
            lblVehiculo = new Label();
            lblSalida = new Label();
            dtpHoraSalida = new DateTimePicker();
            lblLlegada = new Label();
            dptHoraLlegada = new DateTimePicker();
            lblPasajero = new Label();
            txtPasajero = new TextBox();
            cboVehiculo = new ComboBox();
            lblEstado = new Label();
            btnLimpiar = new Button();
            btnRegistrar = new Button();
            dgvViaje = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvViaje).BeginInit();
            SuspendLayout();
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(12, 12);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Buscar por estado, ruta, chofer...";
            txtBuscar.Size = new Size(675, 27);
            txtBuscar.TabIndex = 0;
            // 
            // lblRuta
            // 
            lblRuta.AutoSize = true;
            lblRuta.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRuta.ForeColor = SystemColors.ActiveCaptionText;
            lblRuta.Location = new Point(12, 54);
            lblRuta.Name = "lblRuta";
            lblRuta.Size = new Size(40, 20);
            lblRuta.TabIndex = 1;
            lblRuta.Text = "Ruta";
            // 
            // lblChofer
            // 
            lblChofer.AutoSize = true;
            lblChofer.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblChofer.Location = new Point(186, 54);
            lblChofer.Name = "lblChofer";
            lblChofer.Size = new Size(55, 20);
            lblChofer.TabIndex = 3;
            lblChofer.Text = "Chofer";
            // 
            // cboChofer
            // 
            cboChofer.FormattingEnabled = true;
            cboChofer.Location = new Point(186, 77);
            cboChofer.Name = "cboChofer";
            cboChofer.Size = new Size(148, 28);
            cboChofer.TabIndex = 4;
            // 
            // cboRuta
            // 
            cboRuta.FormattingEnabled = true;
            cboRuta.Location = new Point(12, 77);
            cboRuta.Name = "cboRuta";
            cboRuta.Size = new Size(151, 28);
            cboRuta.TabIndex = 5;
            // 
            // cboEstado
            // 
            cboEstado.FormattingEnabled = true;
            cboEstado.Location = new Point(584, 161);
            cboEstado.Name = "cboEstado";
            cboEstado.Size = new Size(151, 28);
            cboEstado.TabIndex = 6;
            // 
            // lblVehiculo
            // 
            lblVehiculo.AutoSize = true;
            lblVehiculo.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVehiculo.Location = new Point(365, 54);
            lblVehiculo.Name = "lblVehiculo";
            lblVehiculo.Size = new Size(68, 20);
            lblVehiculo.TabIndex = 7;
            lblVehiculo.Text = "Vehículo";
            // 
            // lblSalida
            // 
            lblSalida.AutoSize = true;
            lblSalida.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSalida.Location = new Point(12, 139);
            lblSalida.Name = "lblSalida";
            lblSalida.Size = new Size(88, 20);
            lblSalida.TabIndex = 8;
            lblSalida.Text = "Hora Salida";
            // 
            // dtpHoraSalida
            // 
            dtpHoraSalida.CustomFormat = "dd/MM/yyy HH:mm";
            dtpHoraSalida.Location = new Point(12, 162);
            dtpHoraSalida.Name = "dtpHoraSalida";
            dtpHoraSalida.Size = new Size(250, 27);
            dtpHoraSalida.TabIndex = 9;
            // 
            // lblLlegada
            // 
            lblLlegada.AutoSize = true;
            lblLlegada.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLlegada.Location = new Point(326, 139);
            lblLlegada.Name = "lblLlegada";
            lblLlegada.Size = new Size(100, 20);
            lblLlegada.TabIndex = 10;
            lblLlegada.Text = "Hora Llegada";
            // 
            // dptHoraLlegada
            // 
            dptHoraLlegada.CustomFormat = "dd/MM/yyy HH:mm";
            dptHoraLlegada.Location = new Point(295, 162);
            dptHoraLlegada.Name = "dptHoraLlegada";
            dptHoraLlegada.Size = new Size(250, 27);
            dptHoraLlegada.TabIndex = 11;
            // 
            // lblPasajero
            // 
            lblPasajero.AutoSize = true;
            lblPasajero.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPasajero.Location = new Point(562, 54);
            lblPasajero.Name = "lblPasajero";
            lblPasajero.Size = new Size(67, 20);
            lblPasajero.TabIndex = 12;
            lblPasajero.Text = "Pasajero";
            // 
            // txtPasajero
            // 
            txtPasajero.Location = new Point(562, 78);
            txtPasajero.Name = "txtPasajero";
            txtPasajero.PlaceholderText = "Ej:30";
            txtPasajero.Size = new Size(173, 27);
            txtPasajero.TabIndex = 13;
            // 
            // cboVehiculo
            // 
            cboVehiculo.FormattingEnabled = true;
            cboVehiculo.Location = new Point(365, 77);
            cboVehiculo.Name = "cboVehiculo";
            cboVehiculo.Size = new Size(151, 28);
            cboVehiculo.TabIndex = 14;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEstado.Location = new Point(584, 139);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(54, 20);
            lblEstado.TabIndex = 15;
            lblEstado.Text = "Estado";
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = SystemColors.ControlLight;
            btnLimpiar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.Location = new Point(6, 211);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 42);
            btnLimpiar.TabIndex = 16;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = SystemColors.HotTrack;
            btnRegistrar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrar.ForeColor = SystemColors.ControlLightLight;
            btnRegistrar.Location = new Point(130, 211);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(94, 42);
            btnRegistrar.TabIndex = 17;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // dgvViaje
            // 
            dgvViaje.BackgroundColor = SystemColors.GradientInactiveCaption;
            dgvViaje.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvViaje.Location = new Point(12, 268);
            dgvViaje.Name = "dgvViaje";
            dgvViaje.RowHeadersWidth = 51;
            dgvViaje.Size = new Size(772, 215);
            dgvViaje.TabIndex = 18;
          
            // 
            // frmViaje
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveBorder;
            ClientSize = new Size(810, 495);
            Controls.Add(dgvViaje);
            Controls.Add(btnRegistrar);
            Controls.Add(btnLimpiar);
            Controls.Add(lblEstado);
            Controls.Add(cboVehiculo);
            Controls.Add(txtPasajero);
            Controls.Add(lblPasajero);
            Controls.Add(dptHoraLlegada);
            Controls.Add(lblLlegada);
            Controls.Add(dtpHoraSalida);
            Controls.Add(lblSalida);
            Controls.Add(lblVehiculo);
            Controls.Add(cboEstado);
            Controls.Add(cboRuta);
            Controls.Add(cboChofer);
            Controls.Add(lblChofer);
            Controls.Add(lblRuta);
            Controls.Add(txtBuscar);
            Name = "frmViaje";
            Text = "Gestión de Viaje";
            Load += frmViaje_Load;
            ((System.ComponentModel.ISupportInitialize)dgvViaje).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBuscar;
        private Label lblRuta;
        private Label lblChofer;
        private ComboBox cboChofer;
        private ComboBox cboRuta;
        private ComboBox cboEstado;
        private Label lblVehiculo;
        private Label lblSalida;
        private DateTimePicker dtpHoraSalida;
        private Label lblLlegada;
        private DateTimePicker dptHoraLlegada;
        private Label lblPasajero;
        private TextBox txtPasajero;
        private ComboBox cboVehiculo;
        private Label lblEstado;
        private Button btnLimpiar;
        private Button btnRegistrar;
        private DataGridView dgvViaje;
    }
}