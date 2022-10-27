using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Consultas.Consultas
{
    public partial class FrmConsulta8 : Form
    {
        public FrmConsulta8()
        {
            InitializeComponent();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvConsulta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                dgvConsulta.Rows.Clear();
                List<Parametro> lst = new List<Parametro>();
                lst.Add(new Parametro("@nombre", txtNombre.Text));
                if (rbtPrimer.Checked == true)
                { lst.Add(new Parametro("@cuatrimestre", 1)); }
                else  
                { lst.Add(new Parametro("@cuatrimestre", 2)); }

                DataTable dt = DBHelper.ObtenerInstancia().Sentencia("SP_CONSULTA_8", lst);
                foreach (DataRow dr in dt.Rows)
                {
                    dgvConsulta.Rows.Add(new object[] { dr[0].ToString(), dr[1].ToString(),dr[2].ToString(),dr[3].ToString()});
                }
                if (dgvConsulta.Rows.Count == 0)
                {
                    MessageBox.Show("No se encuentran resultados para los parametros ingresados", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private bool Validar()
        {
            bool result = true;
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Ingrese un nombre válido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                result = false;
            }
            if (rbtPrimer.Checked==false & rbtSegundo.Checked == false)
            {
                 MessageBox.Show("Ingrese un cuatrimestre", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
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
            rbtPrimer.Checked = false;
            rbtSegundo.Checked = false;
            dgvConsulta.Rows.Clear();
        }

        private void FrmConsulta8_Load(object sender, EventArgs e)
        {
            CenterToParent();
        }
    }
}
