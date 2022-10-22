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
    public partial class FrmConsulta3 : Form
    {
        public FrmConsulta3()
        {
            InitializeComponent();
        }

        private void Consulta3_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            nudPromedio.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvConsulta.Rows.Clear();
            List<Parametro> lst = new List<Parametro>();
            int estado = 0;
            
            if (chkPromExacto.Checked)
            {
                estado = 1;
                lst.Add(new Parametro("@promEx", nudPromedio.Value));
            }
            lst.Add(new Parametro("@activo", estado));
                
            DataTable dt = DBHelper.ObtenerInstancia().Sentencia("SP_CONSULTA_3", lst);
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

        private void chkPromExacto_CheckedChanged(object sender, EventArgs e)
        {
            Habilitar();
        }

        private void Habilitar()
        {
            if(chkPromExacto.Checked)
            nudPromedio.Enabled = true;
            else nudPromedio.Enabled = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
