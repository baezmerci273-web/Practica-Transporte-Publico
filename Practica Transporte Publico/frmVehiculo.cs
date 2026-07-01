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
                dgvTabla.DataSource = _todas;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ERROR REAL: {ex.Message}\n\nStackTrace: {ex.StackTrace}");
            }
        }
        

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            dgvTabla.DataSource = string.IsNullOrWhiteSpace(txtBuscar.Text)
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
                Placa = txtPlaca.Text,
                Marca = txtMarca.Text,
                Modelo = txtModelo.Text,
                Anio = anio,
                Capacidad = capacidad,
                Estado = true,
                Tipo = tipoSeleccionado,
                Tarifa = tipo.CalcularTarifa()
            };

            string resultado = _bll.Registrar(v);
            MessageBox.Show(resultado);

            if (resultado.StartsWith("Vehiculo Registrado"))
            {
                CargarDatos();
                btnLimpiar_Click(sender, e);
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
        }

        private void dgvTabla_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var v = (Vehiculo)dgvTabla.Rows[e.RowIndex].DataBoundItem;
            if (v == null) return;

            if (dgvTabla.Columns[e.ColumnIndex].Name == "clEstado")
            {
                e.Value = v.Estado ? "Desactivar" : "Activar";
            }
        }

        private void dgvTabla_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            var col = dgvTabla.Columns[e.ColumnIndex];
            var v = (Vehiculo)dgvTabla.Rows[e.RowIndex].DataBoundItem;
            if (v == null) return;

            if (col.Name == "clEstado")
            {
                string resultado = _bll.CambiarEstado(v.IdVehiculo, !v.Estado);
                MessageBox.Show(resultado);
                CargarDatos();
            }
            else if (col.Name == "clEliminar")
            {
                string resultado = _bll.Eliminar(v.IdVehiculo);
                MessageBox.Show(resultado);
                CargarDatos();
            }
        }

        private void dgvTabla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}


 
    

