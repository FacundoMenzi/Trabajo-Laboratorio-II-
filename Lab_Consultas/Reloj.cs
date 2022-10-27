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
    public partial class FrmReloj : Form
    {
        public FrmReloj()
        {
            InitializeComponent();
            lblReloj.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblReloj.Text = DateTime.Now.ToLongTimeString();
        }

        private void FrmReloj_Load(object sender, EventArgs e)
        {
            CenterToParent();
            
        }
    }
}
