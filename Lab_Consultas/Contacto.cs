using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Consultas
{
    public partial class Contacto : Form
    {
        public Contacto(string Mail,string Titulo)
        {
            InitializeComponent();
            txtMail.Text = Mail;
            txtTitulo.Text = Titulo;
        }
        

        private void ContactoProfesor_Load(object sender, EventArgs e)
        {
            txtEmailProp.Text = "blancacarrizo@frc.utn.edu.ar";
            CenterToParent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Se ha enviado el correo a "+txtMail.Text+"!","Nuevo email", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
            {
                this.Dispose();
            }
            
        }
    }
}
