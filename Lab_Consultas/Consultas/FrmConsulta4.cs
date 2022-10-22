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
    public partial class FrmConsulta4 : Form
    {
        public FrmConsulta4()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                dgvConsulta.Rows.Clear();
                List<Parametro> lst = new List<Parametro>();
                lst.Add(new Parametro("@estado", cboEstados.SelectedValue));
                lst.Add(new Parametro("@tecnicatura", cboTecnicatura.SelectedValue));

                DataTable dt = DBHelper.ObtenerInstancia().Sentencia("SP_CONSULTA_4", lst);
                foreach (DataRow dr in dt.Rows)
                {
                    dgvConsulta.Rows.Add(new object[] { dr[0].ToString(), dr[2].ToString(), dr[3].ToString()
                ,dr[4].ToString()});
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
            if(cboEstados.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un estado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                result = false;
            }
            if(cboTecnicatura.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una tecnicatura", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                result = false;
            }
            return result;
        }

        private void FrmConsulta4_Load(object sender, EventArgs e)
        {
            CargarTecnicaturas();
            CargarEstados();
        }

        private void CargarEstados()
        {
            DataTable dt = DBHelper.ObtenerInstancia().Sentencia("SP_VER_UTNESTADOS", null);
            cboEstados.DataSource = dt;
            cboEstados.DisplayMember = dt.Columns[1].ColumnName;
            cboEstados.ValueMember = dt.Columns[0].ColumnName;
            cboEstados.SelectedIndex = -1;
        }

        private void CargarTecnicaturas()
        {
            DataTable dt = DBHelper.ObtenerInstancia().Sentencia("SP_VER_UTNTECNICATURAS", null);
            cboTecnicatura.DataSource = dt;
            cboTecnicatura.DisplayMember = dt.Columns[1].ColumnName;
            cboTecnicatura.ValueMember = dt.Columns[0].ColumnName;
            cboTecnicatura.SelectedIndex = -1;

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
