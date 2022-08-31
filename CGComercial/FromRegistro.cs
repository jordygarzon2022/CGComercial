using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CGComercial
{
    public partial class FromRegistro : Form
    {
        

        public FromRegistro()
        {
            InitializeComponent();
        }

      
        private void btnBuscarUsuario_Click(object sender, EventArgs e)
        {
            
            string numeroDocumento = tbxNumDoc.Text.ToString();
            ObjectsDatabase.numeroDocumento = numeroDocumento;
            Connecting connection = new Connecting();
            connection.ConsultaDoc();
            

            int con = Convert.ToInt32(null);

            if (con > 0) 
            {
                MessageBox.Show("Usuario ya se encuentra registrado");
                pnlinfo.Visible = false;
            }
            else
            {
                pnlinfo.Visible = true;
                tbxNumDoc.BackColor = Color.White;
            }
        }

        private void btncheck_Click(object sender, EventArgs e)
        {
            ObjectsDatabase db = new ObjectsDatabase();
            ObjectsDatabase.documentType=cmbboxDocumentType.Text;
            ObjectsDatabase.fistName=txtboxfistname.Text;
            ObjectsDatabase.secondName=txtboxsecondname.Text;
            ObjectsDatabase.lastNate=txtboxlastname.Text;
            ObjectsDatabase.secondLastName=txtboxsecondname.Text;
            ObjectsDatabase.birthday = datenacimiento.Text;
            if (checkfem.Checked)
            {
                checkMasculino.Visible = false;
                checkOtro.Visible = false;
                ObjectsDatabase.genero = "F";
            }
            else if (checkMasculino.Checked)
            {
                checkfem.Visible = false;
                checkOtro.Visible = false;
                ObjectsDatabase.genero = "M";
            }
            else if (checkOtro.Checked)
            {
                checkfem.Visible=false;
                checkMasculino.Visible=false;
                ObjectsDatabase.genero="O";
            }

            ObjectsDatabase.city=txtboxCity.Text;
            ObjectsDatabase.barrio = txtboxBarrio.Text;
            ObjectsDatabase.adress=txtboxadress.Text;
            ObjectsDatabase.telefono = txtboxtelefono.Text;
            ObjectsDatabase.email=txtboxemail.Text;
            int estado = 10;
            DateTime FechaCreacion = DateTime.Now;
            ObjectsDatabase.user=txtboxuser.Text;
            ObjectsDatabase.password=txtboxpass.Text;

            //Connecting connecting = new Connecting();
            //connecting.Open();
            string numeroDocumento = tbxNumDoc.Text.ToString();
            //SqlCommand consultaDoc = new SqlCommand($"INSERT INTO dbo.person_cg_general(person_id_doc_num,person_document_type,person_firstname,person_secondname,person_firstlastname,person_secondlastname,person_birthday,person_gen,person_ciudad,person_barrio,person_direccion,person_email,person_telefono,person_estado,person_fecha_crreacion) VALUES ('{numeroDocumento}','')");
            //consultaDoc.ExecuteNonQuery();

        }
    }
}
