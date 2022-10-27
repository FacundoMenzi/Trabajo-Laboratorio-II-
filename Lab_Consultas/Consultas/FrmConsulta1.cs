using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace Lab_Consultas
{
    public partial class FrmConsulta1 : Form
    {
        
        public FrmConsulta1()
        {
            InitializeComponent();
        }

        private void FrmConsultaX_Load(object sender, EventArgs e)
        {
            CenterToParent();
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                dgvConsulta.Rows.Clear();
                List<Parametro> lst = new List<Parametro>();
                lst.Add(new Parametro("@anio", nudAnio.Value));
                lst.Add(new Parametro("@nombre", txtNombre.Text));
                if(chkExtra.Checked)
                {
                    lst.Add(new Parametro("accion", 1));
                    lst.Add(new Parametro("nota1", nudNota1.Value));
                    lst.Add(new Parametro("nota2", nudNota2.Value));
                }
                

                DataTable dt = DBHelper.ObtenerInstancia().Sentencia("SP_CONSULTA_1", lst);
                foreach (DataRow dr in dt.Rows)
                {
                    dgvConsulta.Rows.Add(new object[] { dr[0].ToString(), dr[1].ToString() });
                }
                if(dgvConsulta.Rows.Count == 0)
                {
                    MessageBox.Show("No se encuentran resultados para los parametros ingresados", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            
        }

        private bool Validar()
        {
            bool result = true;
            /*if (txtNombre.Text == "")
            {
                MessageBox.Show("Ingrese un nombre válido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                result = false;
            }*/
            if (nudNota1.Value<1 | nudNota1.Value>10)
            {
                MessageBox.Show("La nota 1 es inválida" , "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                result = false;
            }
            if (nudNota2.Value < 1 | nudNota2.Value > 10)
            {
                MessageBox.Show("La nota 2 es inválida", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                result = false;
            }
            return result;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            nudNota1.Value = 1;
            nudNota2.Value = 10;
            nudAnio.Value = 2022;
            dgvConsulta.Rows.Clear();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void chkExtra_CheckedChanged(object sender, EventArgs e)
        {
            if(chkExtra.Checked)
            {
                nudNota1.Enabled=true;
                nudNota2.Enabled=true;
            }
            else
            {
                nudNota1.Enabled = false;
                nudNota2.Enabled = false;
            }
        }
    }
}
