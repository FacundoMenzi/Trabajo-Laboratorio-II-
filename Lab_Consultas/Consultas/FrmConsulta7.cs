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
    public partial class FrmConsulta7 : Form
    {
        List<string> mails = new List<string>();
        public FrmConsulta7()
        {
            InitializeComponent();
        }

        private void FrmConsulta7_Load(object sender, EventArgs e)
        {
            CargarTipos();
            CenterToParent();

        }

        private bool Validar()
        {
            bool result = true;
            if (chkTipoExamen.Checked)
            {
                if (cboTipoExamenes.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe seleccionar un tipo de examen", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    result = false;
                }
            }
            return result;
        }

        private void chkTipoExamen_CheckedChanged(object sender, EventArgs e)
        {
            Habilitar();
        }

        private void Habilitar()
        {
            if (chkTipoExamen.Checked)
            {
                cboTipoExamenes.Enabled = true;
            }
            else cboTipoExamenes.Enabled = false;
        }
        private void CargarTipos()
        {
            DataTable dt = DBHelper.ObtenerInstancia().Sentencia("SP_UTN_TIPOSEXAMENES", null);
            cboTipoExamenes.DataSource = dt;
            cboTipoExamenes.DisplayMember = dt.Columns[1].ColumnName;
            cboTipoExamenes.ValueMember = dt.Columns[0].ColumnName;
            cboTipoExamenes.SelectedIndex = -1;
        }

        private void btnConsultar_Click_1(object sender, EventArgs e)
        {
            if (Validar())
            {
                dgvConsulta.Rows.Clear();
                List<Parametro> lst = new List<Parametro>();
                lst.Add(new Parametro("@anio", nudAnio.Value));

                if (chkTipoExamen.Checked)
                {
                    lst.Add(new Parametro("@tipo", cboTipoExamenes.SelectedValue));
                    lst.Add(new Parametro("@activo", 1));
                }

                DataTable dt = DBHelper.ObtenerInstancia().Sentencia("SP_CONSULTA_7", lst);
                foreach (DataRow dr in dt.Rows)
                {
                    dgvConsulta.Rows.Add(new object[] { dr[0].ToString(), dr[1].ToString(), dr[2].ToString(),
                    dr[3].ToString(),dr[4].ToString(),dr[5].ToString()});

                    mails.Add(dr[6].ToString());
                }
                if (dgvConsulta.Rows.Count == 0)
                {
                    MessageBox.Show("No se encuentran resultados para los parametros ingresados", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dgvConsulta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvConsulta.CurrentCell.ColumnIndex == 6)
            {
                Contacto c = new Contacto(mails[dgvConsulta.CurrentRow.Index],"¡Felicidades!");
                c.ShowDialog();
                c.Dispose();
            }
        }

        private void cboTipoExamenes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
