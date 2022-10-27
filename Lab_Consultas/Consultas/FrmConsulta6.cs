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
    public partial class FrmConsulta6 : Form
    {
        public FrmConsulta6()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                dgvConsulta.Rows.Clear();
                List<Parametro> lst = new List<Parametro>();
                lst.Add(new Parametro("@nota", nudNota.Value));
                lst.Add(new Parametro("@anio", nudAnio.Value));
                lst.Add(new Parametro("@sitH", cboSituacion.SelectedValue));

                DataTable dt = DBHelper.ObtenerInstancia().Sentencia("SP_CONSULTA_6", lst);
                foreach (DataRow dr in dt.Rows)
                {
                    dgvConsulta.Rows.Add(new object[] { dr[0].ToString(), dr[1].ToString(), dr[2].ToString()
                ,dr[3].ToString(),dr[4].ToString(),dr[5].ToString()});
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
            if (cboSituacion.SelectedIndex==-1)
            {
                MessageBox.Show("Debe seleccionar una situación habitacional", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                result = false;
            }
            if (nudNota.Value<1)
            {
                MessageBox.Show("Debe seleccionar una nota válida", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                result = false;
            }
            if (nudAnio.Value<2010)
            {
                MessageBox.Show("Debe seleccionar un año válido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                result = false;
            }
            return result;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dgvConsulta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvConsulta.CurrentCell.ColumnIndex == 6 )
            {
                Contacto c = new Contacto(dgvConsulta.CurrentRow.Cells[3].Value.ToString(),"Beca UTN");
                c.ShowDialog();
                c.Dispose();
            }
        }

        private void FrmConsulta6_Load(object sender, EventArgs e)
        {
            CargarSituaciones();
            CenterToParent();

        }

        private void CargarSituaciones()
        {
            DataTable dt = DBHelper.ObtenerInstancia().Sentencia("SP_UTN_SITHABITACIONAL", null);
            cboSituacion.DataSource = dt;
            cboSituacion.DisplayMember = dt.Columns[1].ColumnName;
            cboSituacion.ValueMember = dt.Columns[0].ColumnName;
            cboSituacion.SelectedIndex = -1;
        }

        private void cboSituacion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
