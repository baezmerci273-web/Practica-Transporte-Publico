using Practica_Transporte_Publicoui;
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
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();

        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void btnVehiculo_Click(object sender, EventArgs e)
        {

        }

        private void btnChofer_Click(object sender, EventArgs e)
        {
            frmChofercs frmChofercs = new frmChofercs();
            frmChofercs.Show();
        }

        private void btnRutas_Click(object sender, EventArgs e)
        {
            frmRutas frmRutas = new frmRutas();
            frmRutas.Show();
        }

        private void frmlogin_Load(object sender, EventArgs e)
        {

        }
    }
}
