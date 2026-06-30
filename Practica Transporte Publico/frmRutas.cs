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
    public partial class frmRutas : Form
    {
        public frmRutas()
        {
            InitializeComponent();
        }

        private RutasBLL _bll = new RutasBLL();
       
        private List<Rutas> _todas = new List<Rutas>();  
        private int _idSeleccionado = 0;

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                Rutas r = new Rutas
                {
                    Nombre = txtNombre.Text,
                    Salida = txtSalida.Text,
                    Llegada = txtLlegada.Text,
                    DistanciaKm = Convert.ToDouble(txtDistancia.Text),
                    TieneAC = chkTieneAC.Checked,
                    Estado = true
                };

                string resultado = _bll.Registrar(r);
                MessageBox.Show(resultado);

                if (resultado.Contains("Exitosamente"))
                {
                   
                    CargarDatos(); // refresca el DataGridView
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Error: La distancia debe ser un número válido.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado: {ex.Message}");
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            AplicarFiltros();
        }

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            AplicarFiltros();
        }

        private void AplicarFiltros()
        {
            // Paso 1: filtra por texto (o toma todas si está vacío)
            List<Rutas> resultado = string.IsNullOrWhiteSpace(txtBuscar.Text)
                ? _todas
                : _bll.Buscar(_todas, txtBuscar.Text);

            // Paso 2: filtra por estado según el ComboBox
            switch (cmbTipo.SelectedItem?.ToString())
            {
                case "Activas":
                    resultado = resultado.FindAll(r => r.Estado == true);
                    
                    break;
                case "Inactivas":
                    resultado = resultado.FindAll(r => r.Estado == false);

                    break;
                    // "Todas" no filtra nada
            }

            dgvTabla.DataSource = null;
            dgvTabla.DataSource = resultado;
        }

        private void btnLimpiar_click1(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtSalida.Clear();
            txtLlegada.Clear();
            txtDistancia.Clear();
            chkTieneAC.Checked = false;
        }
        
        private void CargarDatos()
        {
            _todas=_bll.ObtenerTodos();
            dgvTabla.DataSource = null;
            dgvTabla.DataSource = _todas;
        }

        
        
        private void frmRutas_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }
    }
}
