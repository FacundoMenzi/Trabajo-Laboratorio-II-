using Lab_Consultas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WINDOWS_FORM
{
    public partial class FrmConsulta2 : Form
    {
        public FrmConsulta2()
        {
            InitializeComponent();
        }

        private void Consulta9_Load(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            nudAnio.Value = 2022;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {

                dgvConsulta.Rows.Clear();
                List<Parametro> lst = new List<Parametro>();
                lst.Add(new Parametro("@anio", nudAnio.Value));

                DataTable dt = DBHelper.ObtenerInstancia().Sentencia("SP_CONSULTA_2", lst);
                foreach (DataRow dr in dt.Rows)
                {
                    dgvConsulta.Rows.Add(new object[] { dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString() });
                }
                if (dgvConsulta.Rows.Count == 0)
                {
                    MessageBox.Show("No se encuentran resultados para los parametros ingresados", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

        }

        private void dgvConsulta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvConsulta.CurrentCell.ColumnIndex == 4)
            {
                Contacto c = new Contacto(dgvConsulta.CurrentRow.Cells[3].Value.ToString(),"Exámenes "+nudAnio.Value);
                c.ShowDialog();
                
                c.Dispose();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
