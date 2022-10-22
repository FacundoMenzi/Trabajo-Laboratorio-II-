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
    public partial class FrmConsulta5 : Form
    {
        List<string> mails=new List<string>();
        public FrmConsulta5()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                dgvConsulta.Rows.Clear();
                List<Parametro> lst = new List<Parametro>();
                lst.Add(new Parametro("@tipo", cboTipoExamenes.SelectedValue));
                lst.Add(new Parametro("@edad1", nudEdad1.Value));
                lst.Add(new Parametro("@edad2", nudEdad2.Value));
                if (chkPromedioExtra.Checked)
                {
                    lst.Add(new Parametro("@promedio", nudPromedio.Value));
                    lst.Add(new Parametro("@accion", 1));
                }

                DataTable dt = DBHelper.ObtenerInstancia().Sentencia("SP_CONSULTA_5", lst);
                foreach (DataRow dr in dt.Rows)
                {
                    dgvConsulta.Rows.Add(new object[] { dr[0].ToString(), dr[1].ToString(), dr[2].ToString()
                ,dr[3].ToString(),dr[4].ToString()});
                    mails.Add(dr[5].ToString());
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
            if (cboTipoExamenes.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un estado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                result = false;
            }
            if (nudEdad1.Value<1 | nudEdad2.Value<1)
            {
                MessageBox.Show("Debe seleccionar edades válidas", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                result = false;
            }
            if(chkPromedioExtra.Checked & nudPromedio.Value < 1)
            {
                MessageBox.Show("Debe seleccionar un promedio válido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                result = false;
            }
            return result;
        }

        private void FrmConsulta_5_Load(object sender, EventArgs e)
        {
            CargarTipos();
        }

        private void CargarTipos()
        {
            DataTable dt = DBHelper.ObtenerInstancia().Sentencia("SP_UTN_TIPOSEXAMENES", null);
            cboTipoExamenes.DataSource = dt;
            cboTipoExamenes.DisplayMember = dt.Columns[1].ColumnName;
            cboTipoExamenes.ValueMember = dt.Columns[0].ColumnName;
            cboTipoExamenes.SelectedIndex = -1;
        }

        private void chkAnio_CheckedChanged(object sender, EventArgs e)
        {
            Habilitar();
        }

        private void Habilitar()
        {
            if (chkPromedioExtra.Checked)
            {
                nudPromedio.Enabled = true;
            }
            else nudPromedio.Enabled = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dgvConsulta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvConsulta.CurrentCell.ColumnIndex == 5)
            {
                Contacto c = new Contacto(mails[dgvConsulta.CurrentRow.Index],cboTipoExamenes.Text+" Promedios");
                c.ShowDialog();
                c.Dispose();
            }
        }
    }
}
