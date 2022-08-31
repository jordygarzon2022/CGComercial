using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CGComercial
{
    public partial class InicialForm : Form
    {
        public InicialForm()
        {
            InitializeComponent();
        }



        private void btnadmin_Click(object sender, EventArgs e)
        {
            ConnectForm connectForm = new ConnectForm();    
            connectForm.ShowDialog();
            //this.Close();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            ConnectForm connectForm = new ConnectForm();
            connectForm.ShowDialog();
            InicioUsuarioCliente clienteCliente = new InicioUsuarioCliente();
            this.Visible = false;
            clienteCliente.ShowDialog();
        }
    }
}
