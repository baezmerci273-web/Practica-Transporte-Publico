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

namespace Practica_Transporte_Publicoui

{
    public partial class frmVehiculo : Form
    {
        private readonly VehiculoBLL _bll = new VehiculoBLL();
        private List<Vehiculo> _todas = new List<Vehiculo>();


        public frmVehiculo()
        {
            InitializeComponent();
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            cboTipo.Items.Add("Guagua");
            cboTipo.Items.Add("Voladorcito");

            cboTipoTarifa.Items.Add("Guagua");
            cboTipoTarifa.Items.Add("Voladorcito");

        }

        private void frmVehiculo_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            try
            {
                _todas = _bll.ObtenerTodos();
                dgvVehiculo.DataSource = _todas;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ERROR REAL: {ex.Message}\n\nStackTrace: {ex.StackTrace}");
            }
        }


        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            dgvVehiculo.DataSource = string.IsNullOrWhiteSpace(txtBuscar.Text)
                ? _todas
                : _bll.Buscar(_todas, txtBuscar.Text);
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtAnio.Text, out int anio))
            {
                MessageBox.Show("Año inválido.");
                return;
            }
            if (!int.TryParse(txtCapacidad.Text, out int capacidad))
            {
                MessageBox.Show("Capacidad inválida.");
                return;
            }
            if (cboTipo.SelectedItem == null)
            {
                MessageBox.Show("Selecciona un tipo de vehículo.");
                return;
            }

            string tipoSeleccionado = cboTipo.SelectedItem.ToString();

            VehiculoBLL.VehiculoTransporteBLL tipo = tipoSeleccionado switch
            {

                "Guagua" => new VehiculoBLL.Guagua(),
                "Voladorcito" => new VehiculoBLL.Voladorcito(),
                _ => null
            };

            if (tipo == null)
            {
                MessageBox.Show("Tipo no reconocido.");
                return;
            }

            var v = new Vehiculo
            {
                IdVehiculo = _idEditando,
                Placa = txtPlaca.Text,
                Marca = txtMarca.Text,
                Modelo = txtModelo.Text,
                Anio = anio,
                Capacidad = capacidad,
                Estado = true,
                Tipo = tipoSeleccionado,
                Tarifa = tipo.CalcularTarifa()
            };

            string resultado = _idEditando == 0
         ? _bll.Registrar(v)
         : _bll.Editar(v);

            MessageBox.Show(resultado);

            if (resultado.StartsWith("Vehiculo Registrado") || resultado.StartsWith("Vehículo actualizado"))
            {
                CargarDatos();
                btnLimpiar_Click(sender, e);
                _idEditando = 0;
                btnRegistrar.Text = "Registrar";
            }
        }




        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtPlaca.Clear();
            txtMarca.Clear();
            txtModelo.Clear();
            txtAnio.Clear();
            txtCapacidad.Clear();
            cboTipo.SelectedIndex = -1;
            _idEditando = 0;
            btnRegistrar.Text = "Registrar";
        }

        private void dgvVehiculo_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var v = (Vehiculo)dgvVehiculo.Rows[e.RowIndex].DataBoundItem;
            if (v == null) return;

            if (dgvVehiculo.Columns[e.ColumnIndex].Name == "clEstado")
            {
                e.Value = v.Estado ? "Desactivar" : "Activar";
            }
        }
        private int _idEditando = 0;



        private void CargarParaEditar(Vehiculo v)
        {
            _idEditando = v.IdVehiculo;
            txtPlaca.Text = v.Placa;
            txtMarca.Text = v.Marca;
            txtModelo.Text = v.Modelo;
            txtAnio.Text = v.Anio.ToString();
            txtCapacidad.Text = v.Capacidad.ToString();
            cboTipo.SelectedItem = v.Tipo;

            btnRegistrar.Text = "Actualizar";
        }


        private void dgvVehiculo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            var col = dgvVehiculo.Columns[e.ColumnIndex];
            var v = (Vehiculo)dgvVehiculo.Rows[e.RowIndex].DataBoundItem;
            if (v == null) return;

            if (col.Name == "clEstado")
            {
                string resultado = _bll.CambiarEstado(v.IdVehiculo, !v.Estado);
                MessageBox.Show(resultado);
                CargarDatos();
            }
            if (col.Name == "clEliminar")
            {
                string resultado = _bll.Eliminar(v.IdVehiculo);
                MessageBox.Show(resultado);
                CargarDatos();

            }
            else if (col.Name == "clEditar")
            {
                CargarParaEditar(v);
            }
        }

        private void txtTarifa_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTarifa_Click(object sender, EventArgs e)
        {

        }

        private void lblTarifaTipo_Click(object sender, EventArgs e)
        {

        }

        private void btntarifa_Click(object sender, EventArgs e)
        {
            if (cboTipoTarifa.SelectedItem == null)
            {
                MessageBox.Show("Selecciona un tipo de vehículo.");
                return;
            }

            if (!double.TryParse(txtTarifa.Text, out double nuevaTarifa) || nuevaTarifa <= 0)
            {
                MessageBox.Show("Ingresa un precio válido.");
                return;
            }

            string tipoSeleccionado = cboTipoTarifa.SelectedItem.ToString();

            switch (tipoSeleccionado)
            {
                case "Guagua":
                    VehiculoBLL.Guagua.TarifaBase = nuevaTarifa;
                    break;
                case "Voladorcito":
                    VehiculoBLL.Voladorcito.TarifaBase = nuevaTarifa;
                    break;
            }
            MessageBox.Show($"Tarifa de {tipoSeleccionado} actualizada a RD${nuevaTarifa}. Los próximos vehículos usarán este precio.");
            txtTarifa.Clear();
            cboTipoTarifa.SelectedIndex = -1;
        }
    }
}


 
    

