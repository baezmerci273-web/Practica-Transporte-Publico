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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Practica_Transporte_Publicoui

{
    public partial class frmRutas : Form
    {
        public frmRutas()
        {
            InitializeComponent();
            
            dgvTabla.CellFormatting += dgvTabla_CellFormatting;
            dgvTabla.CellClick += dgvTabla_CellClick;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            chkActivas.CheckedChanged += chkActivas_CheckedChanged;
        }

       
        
            private readonly RutasBLL _bll = new RutasBLL();
            private List<Rutas> _todas = new List<Rutas>();


        private void frmRutas_Load(object sender, EventArgs e) 
        {
            CargarDatos();
        }

     
        private void CargarDatos()
        {
            _todas = _bll.ObtenerTodos();
            dgvTabla.DataSource =  _todas;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
            {
                if (string.IsNullOrWhiteSpace(txtBuscar.Text))
                    dgvTabla.DataSource = chkActivas.Checked ? _bll.ObtenerActivas() : _todas;
                else
                    dgvTabla.DataSource = _bll.Buscar(_todas, txtBuscar.Text);
            }

            private void chkActivas_CheckedChanged(object sender, EventArgs e)
            {
                dgvTabla.DataSource = chkActivas.Checked
                    ? _bll.ObtenerActivas()
                    : _todas;
            }

            private void btnRegistrar_Click(object sender, EventArgs e)
            {
                if (!int.TryParse(txtDistancia.Text, out int distancia))
                {
                    MessageBox.Show("Distancia inválida.");
                    return;
                }

                var ruta = new Rutas
                {
                    Nombre = txtNombre.Text,
                    Salida = txtSalida.Text,
                    Llegada = txtLlegada.Text,
                    DistanciaKm = distancia,
                    Estado = true,
                    TieneAC = chkTieneAC.Checked
                };

                string resultado = _bll.Registrar(ruta);
                MessageBox.Show(resultado);

                if (resultado.StartsWith("Ruta"))
                {
                    CargarDatos();
                    BtnLimpiar_Click1(sender, e);
                }
            }

            private void btnEliminar_Click(object sender, EventArgs e)
            {
                if (dgvTabla.CurrentRow == null)
                {
                    MessageBox.Show("Selecciona una ruta primero.");
                    return;
                }

                var ruta = (Rutas)dgvTabla.CurrentRow.DataBoundItem;
                string resultado = _bll.Eliminar(ruta.IdRutas);
                MessageBox.Show(resultado);
                CargarDatos();
            }
        private void BtnLimpiar_Click1(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtSalida.Clear();
            txtLlegada.Clear();
            txtDistancia.Clear();
            chkTieneAC.Checked = false;
        }
       

            private void dgvTabla_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
            {
                if (e.RowIndex < 0) return;

                var ruta = (Rutas)dgvTabla.Rows[e.RowIndex].DataBoundItem;
                if (ruta == null) return;

                if (dgvTabla.Columns[e.ColumnIndex].Name == "ColEstado")
                {
                    e.Value = ruta.Estado ? "Desactivar" : "Activar";
                }
                else if (dgvTabla.Columns[e.ColumnIndex].Name == "colTieneAC")
                {
                    e.Value = ruta.TieneAC ? "Sí" : "No";
                }
            }

        private void dgvTabla_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            var col = dgvTabla.Columns[e.ColumnIndex];
            var ruta = (Rutas)dgvTabla.Rows[e.RowIndex].DataBoundItem;

            if (ruta == null) return; // por si la fila aún no tiene datos enlazados

            if (col.Name == "ColEstado")
            {
                string resultado = _bll.CambiarEstado(ruta.IdRutas, !ruta.Estado);
                MessageBox.Show(resultado);
                CargarDatos();
            }
            else if (col.Name == "colEliminar")
            {
                string resultado = _bll.Eliminar(ruta.IdRutas);
                MessageBox.Show(resultado);
                CargarDatos();
            }
        }


    }
    }


