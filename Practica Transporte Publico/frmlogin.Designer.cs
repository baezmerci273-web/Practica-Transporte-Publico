namespace Practica_Transporte_Publicoui

{
    partial class frmlogin
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
            btnRutas = new Button();
            btnChofer = new Button();
            btnRecaudacion = new Button();
            btnVehiculo = new Button();
            lblInformacion = new Label();
            btnViaje = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(185, 36);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(439, 27);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Sistema De Gestión De Transporte Público";
            lblTitulo.Click += lblTitulo_Click;
            // 
            // btnRutas
            // 
            btnRutas.BackColor = SystemColors.ControlLightLight;
            btnRutas.Cursor = Cursors.Hand;
            btnRutas.Location = new Point(48, 156);
            btnRutas.Name = "btnRutas";
            btnRutas.Size = new Size(136, 56);
            btnRutas.TabIndex = 1;
            btnRutas.Text = "Rutas";
            btnRutas.UseVisualStyleBackColor = false;
            btnRutas.Click += btnRutas_Click;
            // 
            // btnChofer
            // 
            btnChofer.Cursor = Cursors.Hand;
            btnChofer.Location = new Point(206, 155);
            btnChofer.Name = "btnChofer";
            btnChofer.Size = new Size(136, 58);
            btnChofer.TabIndex = 2;
            btnChofer.Text = "Chofer";
            btnChofer.UseVisualStyleBackColor = true;
            btnChofer.Click += btnChofer_Click;
            // 
            // btnRecaudacion
            // 
            btnRecaudacion.Cursor = Cursors.Hand;
            btnRecaudacion.Location = new Point(359, 154);
            btnRecaudacion.Name = "btnRecaudacion";
            btnRecaudacion.Size = new Size(136, 59);
            btnRecaudacion.TabIndex = 3;
            btnRecaudacion.Text = "Recaudación";
            btnRecaudacion.UseVisualStyleBackColor = true;
            // 
            // btnVehiculo
            // 
            btnVehiculo.Cursor = Cursors.Hand;
            btnVehiculo.Location = new Point(512, 155);
            btnVehiculo.Name = "btnVehiculo";
            btnVehiculo.Size = new Size(136, 58);
            btnVehiculo.TabIndex = 4;
            btnVehiculo.Text = "Vehículo";
            btnVehiculo.UseVisualStyleBackColor = true;
            btnVehiculo.Click += btnVehiculo_Click;
            // 
            // lblInformacion
            // 
            lblInformacion.AutoSize = true;
            lblInformacion.Location = new Point(321, 88);
            lblInformacion.Name = "lblInformacion";
            lblInformacion.Size = new Size(165, 20);
            lblInformacion.TabIndex = 5;
            lblInformacion.Text = " Seleccione Un Servicio:";
            // 
            // btnViaje
            // 
            btnViaje.Location = new Point(658, 156);
            btnViaje.Name = "btnViaje";
            btnViaje.Size = new Size(136, 57);
            btnViaje.TabIndex = 6;
            btnViaje.Text = "Viaje";
            btnViaje.UseVisualStyleBackColor = true;
            // 
            // frmlogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveBorder;
            ClientSize = new Size(832, 450);
            Controls.Add(btnViaje);
            Controls.Add(lblInformacion);
            Controls.Add(btnVehiculo);
            Controls.Add(btnRecaudacion);
            Controls.Add(btnChofer);
            Controls.Add(btnRutas);
            Controls.Add(lblTitulo);
            Name = "frmlogin";
            Text = "Login Transporte Publico";
            Load += frmlogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Button btnRutas;
        private Button btnChofer;
        private Button btnRecaudacion;
        private Button btnVehiculo;
        private Label lblInformacion;
        private Button btnViaje;
    }
}