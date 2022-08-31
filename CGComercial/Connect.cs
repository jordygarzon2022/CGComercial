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
    public partial class ConnectForm : Form
    {
        public ConnectForm()
        {
            InitializeComponent();
        }

        private void lblBienvenida_Click(object sender, EventArgs e)
        {
            //InicialForm inicialForm = new InicialForm();
            //inicialForm.Cerrar();
            this.Close();
        }

        
    }
}
