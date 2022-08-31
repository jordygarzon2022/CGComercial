using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CGComercial
{
    public partial class InicioUsuarioCliente : Form
    {
        public InicioUsuarioCliente()
        {
            InitializeComponent();
        }

        private void btnmujeres_Click(object sender, EventArgs e)
        {
            FormMujeres formMujeres = new FormMujeres();
            formMujeres.ShowDialog();
            this.Close();
        }

        private void btnUsuarioCliente_Click(object sender, EventArgs e)
        {
            FromRegistro fromRegistro = new FromRegistro();
            this.Visible = false;
            fromRegistro.ShowDialog();
        }

        private void btnhombres_Click(object sender, EventArgs e)
        {
            FormHombres formHombres = new FormHombres();
            formHombres.ShowDialog();
            this.Close();
        }

        private void btnpedido_Click(object sender, EventArgs e)
        {
            FormPedido formPedido = new FormPedido();
            formPedido.ShowDialog();
            this.Close();
        }

        private void btnPagos_Click(object sender, EventArgs e)
        {
            FormPago formPagos = new FormPago();
            formPagos.ShowDialog();
            this.Close();
        }
    }
}
