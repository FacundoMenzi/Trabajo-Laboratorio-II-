namespace WINDOWS_FORM
{
    partial class FrmConsulta3
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsulta3));
            this.Sentencia = new System.Windows.Forms.Label();
            this.dgvConsulta = new System.Windows.Forms.DataGridView();
            this.Clegajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Calumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cpromedio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cmateria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Caño = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cturno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.chkPromExacto = new System.Windows.Forms.CheckBox();
            this.nudPromedio = new System.Windows.Forms.NumericUpDown();
            this.lblEx = new System.Windows.Forms.Label();
            this.lblPromedio = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPromedio)).BeginInit();
            this.SuspendLayout();
            // 
            // Sentencia
            // 
            this.Sentencia.AutoSize = true;
            this.Sentencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sentencia.Location = new System.Drawing.Point(19, 9);
            this.Sentencia.Name = "Sentencia";
            this.Sentencia.Size = new System.Drawing.Size(428, 20);
            this.Sentencia.TabIndex = 0;
            this.Sentencia.Text = "Promedio de notas por alumno, materia, año y turno.\r\n";
            // 
            // dgvConsulta
            // 
            this.dgvConsulta.AllowUserToAddRows = false;
            this.dgvConsulta.AllowUserToDeleteRows = false;
            this.dgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsulta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Clegajo,
            this.Calumno,
            this.Cpromedio,
            this.Cmateria,
            this.Caño,
            this.Cturno});
            this.dgvConsulta.Location = new System.Drawing.Point(23, 90);
            this.dgvConsulta.Name = "dgvConsulta";
            this.dgvConsulta.ReadOnly = true;
            this.dgvConsulta.RowHeadersWidth = 51;
            this.dgvConsulta.Size = new System.Drawing.Size(646, 222);
            this.dgvConsulta.TabIndex = 10;
            // 
            // Clegajo
            // 
            this.Clegajo.HeaderText = "Legajo";
            this.Clegajo.MinimumWidth = 6;
            this.Clegajo.Name = "Clegajo";
            this.Clegajo.ReadOnly = true;
            // 
            // Calumno
            // 
            this.Calumno.HeaderText = "Alumno";
            this.Calumno.MinimumWidth = 6;
            this.Calumno.Name = "Calumno";
            this.Calumno.ReadOnly = true;
            this.Calumno.Width = 125;
            // 
            // Cpromedio
            // 
            this.Cpromedio.HeaderText = "Promedio";
            this.Cpromedio.MinimumWidth = 6;
            this.Cpromedio.Name = "Cpromedio";
            this.Cpromedio.ReadOnly = true;
            this.Cpromedio.Width = 65;
            // 
            // Cmateria
            // 
            this.Cmateria.HeaderText = "Materia";
            this.Cmateria.MinimumWidth = 6;
            this.Cmateria.Name = "Cmateria";
            this.Cmateria.ReadOnly = true;
            this.Cmateria.Width = 160;
            // 
            // Caño
            // 
            this.Caño.HeaderText = "Año";
            this.Caño.MinimumWidth = 6;
            this.Caño.Name = "Caño";
            this.Caño.ReadOnly = true;
            this.Caño.Width = 70;
            // 
            // Cturno
            // 
            this.Cturno.HeaderText = "Turno";
            this.Cturno.MinimumWidth = 6;
            this.Cturno.Name = "Cturno";
            this.Cturno.ReadOnly = true;
            this.Cturno.Width = 73;
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConsultar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnConsultar.Location = new System.Drawing.Point(594, 50);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 11;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Red;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(594, 318);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 13;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // chkPromExacto
            // 
            this.chkPromExacto.AutoSize = true;
            this.chkPromExacto.Location = new System.Drawing.Point(22, 51);
            this.chkPromExacto.Margin = new System.Windows.Forms.Padding(2);
            this.chkPromExacto.Name = "chkPromExacto";
            this.chkPromExacto.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkPromExacto.Size = new System.Drawing.Size(145, 17);
            this.chkPromExacto.TabIndex = 14;
            this.chkPromExacto.Text = "Habilitar promedio exacto";
            this.chkPromExacto.UseVisualStyleBackColor = true;
            this.chkPromExacto.CheckedChanged += new System.EventHandler(this.chkPromExacto_CheckedChanged);
            // 
            // nudPromedio
            // 
            this.nudPromedio.Location = new System.Drawing.Point(241, 50);
            this.nudPromedio.Margin = new System.Windows.Forms.Padding(2);
            this.nudPromedio.Name = "nudPromedio";
            this.nudPromedio.Size = new System.Drawing.Size(52, 20);
            this.nudPromedio.TabIndex = 15;
            // 
            // lblEx
            // 
            this.lblEx.AutoSize = true;
            this.lblEx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEx.Location = new System.Drawing.Point(297, 53);
            this.lblEx.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEx.Name = "lblEx";
            this.lblEx.Size = new System.Drawing.Size(18, 15);
            this.lblEx.TabIndex = 16;
            this.lblEx.Text = "%";
            // 
            // lblPromedio
            // 
            this.lblPromedio.AutoSize = true;
            this.lblPromedio.Location = new System.Drawing.Point(183, 51);
            this.lblPromedio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(54, 13);
            this.lblPromedio.TabIndex = 17;
            this.lblPromedio.Text = "Promedio:";
            // 
            // FrmConsulta3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(690, 357);
            this.Controls.Add(this.lblPromedio);
            this.Controls.Add(this.lblEx);
            this.Controls.Add(this.nudPromedio);
            this.Controls.Add(this.chkPromExacto);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.dgvConsulta);
            this.Controls.Add(this.Sentencia);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmConsulta3";
            this.Text = "Consulta 3";
            this.Load += new System.EventHandler(this.Consulta3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPromedio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Sentencia;
        private System.Windows.Forms.DataGridView dgvConsulta;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.CheckBox chkPromExacto;
        private System.Windows.Forms.NumericUpDown nudPromedio;
        private System.Windows.Forms.Label lblEx;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clegajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Calumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cpromedio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cmateria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Caño;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cturno;
    }
}

