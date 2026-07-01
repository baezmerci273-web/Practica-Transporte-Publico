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
    public partial class frmChofercs : Form
    {
        public frmChofercs()
        {
            InitializeComponent();

            
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            dvgChofer.CellClick += dvgChofer_CellClick;
            dvgChofer.CellFormatting += dvgChofer_CellFormatting;

            txtNombre.KeyPress += SoloTexto_KeyPress;
            txtApellido.KeyPress += SoloTexto_KeyPress;
            txtCedula.KeyPress += Cedula_KeyPress;
        }
     
   
        
       
            private readonly ChoferBLL _bll = new ChoferBLL();
            private List<chofer> _todas = new List<chofer>();

           private void frmChofercs_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

       

        private void Cedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite dígitos, guión, y teclas de control 
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '-' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void CargarDatos()
            {
                _todas = _bll.ObtenerTodos();
                dvgChofer.DataSource = _todas;
            }

            private void txtBuscar_TextChanged(object sender, EventArgs e)
            {
                dvgChofer.DataSource = string.IsNullOrWhiteSpace(txtBuscar.Text)
                    ? _todas
                    : _bll.Buscar(_todas, txtBuscar.Text);
            }

            private void btnRegistrar_Click(object sender, EventArgs e)
            {
                var c = new chofer
                {
                    Nombre = txtNombre.Text,
                    Apellido = txtApellido.Text,
                    Cedula = txtCedula.Text,
                    Licencia = txtLicencia.Text,
                    Telefono = txtTelefono.Text,
                    Estado = true
                };

                string resultado = _bll.Registrar(c);
                MessageBox.Show(resultado);

                if (resultado.StartsWith("Chofer Registrado"))
                {
                    CargarDatos();
                    btnLimpiar_Click(sender, e);
                }
            }

            private void btnLimpiar_Click(object sender, EventArgs e)
            {
                txtNombre.Clear();
                txtApellido.Clear();
                txtCedula.Clear();
                txtLicencia.Clear();
                txtTelefono.Clear();
            }

            private void dvgChofer_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
            {
                if (e.RowIndex < 0) return;

                var c = (chofer)dvgChofer.Rows[e.RowIndex].DataBoundItem;
                if (c == null) return;

                if (dvgChofer.Columns[e.ColumnIndex].Name == "clEstado")
                {
                    e.Value = c.Estado ? "Desactivar" : "Activar";
                }
            }

            private void dvgChofer_CellClick(object sender, DataGridViewCellEventArgs e)
            {
                if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

                var col = dvgChofer.Columns[e.ColumnIndex];
                var c = (chofer)dvgChofer.Rows[e.RowIndex].DataBoundItem;
                if (c == null) return;

                if (col.Name == "clEstado")
                {
                    string resultado = _bll.CambiarEstado(c.IdChofer, !c.Estado);
                    MessageBox.Show(resultado);
                    CargarDatos();
                }
                else if (col.Name == "clEliminar")
                {
                    string resultado = _bll.Eliminar(c.IdChofer);
                    MessageBox.Show(resultado);
                    CargarDatos();
                }
            }

            private void SoloTexto_KeyPress(object sender, KeyPressEventArgs e)
            {
                if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }
    }

