using Datos;
using Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;

namespace Practica_Transporte_Publicoui

{
    public partial class frmViaje : Form
    {
        private readonly ViajeBLL _bll = new ViajeBLL();
        private readonly RutasBLL _rutaBLL = new RutasBLL();
        private readonly ChoferBLL _choferBLL = new ChoferBLL();
        private readonly VehiculoBLL _vehiculoBLL = new VehiculoBLL();
        private List<Viaje> _todas = new List<Viaje>();

  
        private List<Rutas> _rutas = new List<Rutas>();
        private List<chofer> _choferes = new List<chofer>();
        private List<Vehiculo> _vehiculo = new List<Vehiculo>();
        public frmViaje()
        {
            InitializeComponent();
            txtBuscar.TextChanged += txtBuscar_TextChanged;

            cboEstado.Items.Add("Pendiente");
            cboEstado.Items.Add("En curso");
            cboEstado.Items.Add("Finalizado");
            cboEstado.Items.Add("Cancelado");

            ConfigurarComboBuscable(cboRuta);
            ConfigurarComboBuscable(cboChofer);
            ConfigurarComboBuscable(cboVehiculo);

            dtpHoraSalida.Format = DateTimePickerFormat.Custom;
            dtpHoraSalida.CustomFormat = "dd/MM/yyyy HH:mm";
            dptHoraLlegada.Format = DateTimePickerFormat.Custom;
            dptHoraLlegada.CustomFormat = "dd/MM/yyyy HH:mm";

            dgvViaje.AutoGenerateColumns = true;
            dgvViaje.DataBindingComplete += DgvViaje_DataBindingComplete;
            dgvViaje.CellFormatting += DgvViaje_CellFormatting;





        }
        private void ConfigurarComboBuscable(ComboBox combo)
        {
            combo.DropDownStyle = ComboBoxStyle.DropDown;
            combo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            combo.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void frmViaje_Load(object sender, EventArgs e)
            {
            CargarCombos();
            CargarDatos();
            btnLimpiar_Click(sender, e);
        }
        private void CargarCombos()
        {
            try
            {
                cboRuta.DataSource = _rutaBLL.ObtenerTodos();
                _rutas = _rutaBLL.ObtenerTodos();
                cboRuta.DataSource = _rutas;
                cboRuta.DisplayMember = "Nombre";
                cboRuta.ValueMember = "IdRutas";
                cboRuta.SelectedIndex = -1;

                cboChofer.DataSource = _choferBLL.ObtenerTodos();
                _choferes = _choferBLL.ObtenerTodos();
                cboChofer.DataSource = _choferes;
                cboChofer.DisplayMember = "NombreCompleto";
                cboChofer.ValueMember = "IdChofer";
                cboChofer.SelectedIndex = -1;
                cboChofer.Format += CboChofer_Format;

                cboVehiculo.DataSource = _vehiculoBLL.ObtenerTodos();
                _vehiculo = _vehiculoBLL.ObtenerTodos();
                cboVehiculo.DataSource = _vehiculo;
                cboVehiculo.DisplayMember = "Placa";
                cboVehiculo.ValueMember = "IdVehiculo";
                cboVehiculo.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar combos: {ex.Message}");
            }
        }

        private void CboChofer_Format(object sender, ListControlConvertEventArgs e)
        {
            var choferItem = (chofer)e.ListItem;
            e.Value = $"{choferItem.Nombre} {choferItem.Apellido}";
        }

        private void CargarDatos()
        {
            try
            {
                _todas = _bll.ObtenerTodos2();
                dgvViaje.DataSource = null;
                dgvViaje.DataSource = _todas;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ERROR REAL: {ex.Message}\n\nStackTrace: {ex.StackTrace}");
            }
        }

        private void DgvViaje_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (dgvViaje.Columns["IdViaje"] != null)
                dgvViaje.Columns["IdViaje"].HeaderText = "ID";
            if (dgvViaje.Columns["IdRutas"] != null)
                dgvViaje.Columns["IdRutas"].HeaderText = "Ruta";
            if (dgvViaje.Columns["IdChofer"] != null)
                dgvViaje.Columns["IdChofer"].HeaderText = "Chofer";
            if (dgvViaje.Columns["IdVehiculo"] != null)
                dgvViaje.Columns["IdVehiculo"].HeaderText = "Vehículo";
            if (dgvViaje.Columns["HoraSalida"] != null)
                dgvViaje.Columns["HoraSalida"].HeaderText = "Salida";
            if (dgvViaje.Columns["HoraLlegada"] != null)
                dgvViaje.Columns["HoraLlegada"].HeaderText = "Llegada";
            if (dgvViaje.Columns["CantidadPasajeros"] != null)
                dgvViaje.Columns["CantidadPasajeros"].HeaderText = "Pasajeros";
            if (dgvViaje.Columns["Estado"] != null)
                dgvViaje.Columns["Estado"].HeaderText = "Estado";

            if (dgvViaje.Columns["Rutas"] != null)
                dgvViaje.Columns["Rutas"].Visible = false;
            if (dgvViaje.Columns["Chofer"] != null)
                dgvViaje.Columns["Chofer"].Visible = false;
            if (dgvViaje.Columns["Vehiculo"] != null)
                dgvViaje.Columns["Vehiculo"].Visible = false;

            if (!dgvViaje.Columns.Contains("colEliminar"))
            {
                var btnCol = new DataGridViewButtonColumn
                {
                    Name = "colEliminar",
                    HeaderText = "Eliminar",
                    Text = "Eliminar",
                    UseColumnTextForButtonValue = true
                };
                dgvViaje.Columns.Add(btnCol);
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            dgvViaje.DataSource = string.IsNullOrWhiteSpace(txtBuscar.Text)
                ? _todas
                : _bll.Buscar(_todas, txtBuscar.Text);
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (cboRuta.SelectedValue == null)
            {
                MessageBox.Show("Selecciona una ruta.");
                return;
            }
            if (cboChofer.SelectedValue == null)
            {
                MessageBox.Show("Selecciona un chofer válido de la lista.");
                return;
            }
            if (cboVehiculo.SelectedValue == null)
            {
                MessageBox.Show("Selecciona un vehículo.");
                return;
            }
            if (!int.TryParse(txtPasajero.Text, out int cantidadPasajeros) || cantidadPasajeros < 0)
            {
                MessageBox.Show("Cantidad de pasajeros inválida.");
                return;
            }
            if (cboEstado.SelectedItem == null)
            {
                MessageBox.Show("Selecciona un estado.");
                return;
            }

            var viaje = new Viaje
            {
                IdRutas = (int)cboRuta.SelectedValue,
                IdVehiculo = (int)cboVehiculo.SelectedValue,
                HoraSalida = dtpHoraSalida.Value,
                HoraLlegada = dptHoraLlegada.Value,
                Estado = cboEstado.SelectedItem.ToString(),
                CantidadPasajeros = cantidadPasajeros
            };

            string resultadoChofer = _bll.AsignarChofer(viaje, _choferes, (int)cboChofer.SelectedValue);
            if (resultadoChofer.StartsWith("Error"))
            {
                MessageBox.Show(resultadoChofer);
                return;
            }

            string resultado = _bll.Registrar(viaje);
            MessageBox.Show(resultado);

            if (resultado.StartsWith("Viaje Registrado"))
            {
                CargarDatos();
                btnLimpiar_Click(sender, e);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cboRuta.SelectedIndex = -1;
            cboChofer.SelectedIndex = -1;
            cboVehiculo.SelectedIndex = -1;
            txtPasajero.Clear();
            cboEstado.SelectedIndex = -1;
            dtpHoraSalida.Value = DateTime.Now.AddHours(1);
            dptHoraLlegada.Value = DateTime.Now.AddHours(2);
        }

        private void dgvViaje_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            var col = dgvViaje.Columns[e.ColumnIndex];
            var v = (Viaje)dgvViaje.Rows[e.RowIndex].DataBoundItem;
            if (v == null) return;

            if (col.Name == "colEliminar")
            {
                string resultado = _bll.Eliminar(v.IdViaje);
                MessageBox.Show(resultado);
                CargarDatos();
            }
        }

        private void DgvViaje_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.Value == null) return;

            string columnName = dgvViaje.Columns[e.ColumnIndex].Name;

            if (columnName == "IdRutas")
            {
                var ruta = _rutas.FirstOrDefault(r => r.IdRutas == (int)e.Value);
                e.Value = ruta != null ? ruta.Nombre : "Desconocida";
                e.FormattingApplied = true;
            }
            else if (columnName == "IdChofer")
            {
                var chofer = _choferes.FirstOrDefault(c => c.IdChofer == (int)e.Value);
                e.Value = chofer != null ? $"{chofer.Nombre} {chofer.Apellido}" : "Desconocido";
                e.FormattingApplied = true;
            }
            else if (columnName == "IdVehiculo")
            {
                var vehiculo = _vehiculo.FirstOrDefault(v => v.IdVehiculo == (int)e.Value);
                e.Value = vehiculo != null ? vehiculo.Placa : "Desconocido";
                e.FormattingApplied = true;
            }
        }

    }
}


