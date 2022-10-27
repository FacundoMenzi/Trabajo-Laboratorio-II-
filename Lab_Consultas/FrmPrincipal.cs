using Lab_Consultas.Consultas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WINDOWS_FORM;

namespace Lab_Consultas
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void consulta1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsulta1 consulta1 = new FrmConsulta1();
            consulta1.ShowDialog();
            consulta1.Dispose();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            
        }

        private void consulta2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsulta2 consulta2 = new FrmConsulta2();
            consulta2.ShowDialog();
            consulta2.Dispose();
        }

        private void consulta3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsulta3 consulta3 = new FrmConsulta3();
            consulta3.ShowDialog();
            consulta3.Dispose();
        }

        private void consulta4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsulta4 consulta4 = new FrmConsulta4();
            consulta4.ShowDialog();
            consulta4.Dispose();
        }

        private void consulta5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsulta5 consulta5 = new FrmConsulta5();
            consulta5.ShowDialog();
            consulta5.Dispose();
        }

        private void consulta6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsulta6 consulta6 = new FrmConsulta6();
            consulta6.ShowDialog();
            consulta6.Dispose();
        }

        private void consulta7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsulta7 consulta7 = new FrmConsulta7();
            consulta7.ShowDialog();
            consulta7.Dispose();
        }

        private void consulta8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsulta8 consulta8 = new FrmConsulta8();
            consulta8.ShowDialog();
            consulta8.Dispose();
        }

        private void relojToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReloj frmReloj = new FrmReloj();
            
            frmReloj.ShowDialog();
            frmReloj.Dispose();
            
        }
    }
}
