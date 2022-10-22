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
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.chkPromExacto = new System.Windows.Forms.CheckBox();
            this.nudPromedio = new System.Windows.Forms.NumericUpDown();
            this.lblEx = new System.Windows.Forms.Label();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.Clegajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Calumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cpromedio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cmateria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Caño = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cturno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPromedio)).BeginInit();
            this.SuspendLayout();
            // 
            // Sentencia
            // 
            this.Sentencia.AutoSize = true;
            this.Sentencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sentencia.Location = new System.Drawing.Point(13, 20);
            this.Sentencia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Sentencia.Name = "Sentencia";
            this.Sentencia.Size = new System.Drawing.Size(656, 29);
            this.Sentencia.TabIndex = 0;
            this.Sentencia.Text = "Ver promedio de notas por alumno, materia , año y turno ";
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
            this.dgvConsulta.Location = new System.Drawing.Point(31, 111);
            this.dgvConsulta.Margin = new System.Windows.Forms.Padding(4);
            this.dgvConsulta.Name = "dgvConsulta";
            this.dgvConsulta.ReadOnly = true;
            this.dgvConsulta.RowHeadersWidth = 51;
            this.dgvConsulta.Size = new System.Drawing.Size(861, 273);
            this.dgvConsulta.TabIndex = 10;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(792, 62);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(4);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(100, 28);
            this.btnConsultar.TabIndex = 11;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(792, 392);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(100, 28);
            this.btnSalir.TabIndex = 13;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // chkPromExacto
            // 
            this.chkPromExacto.AutoSize = true;
            this.chkPromExacto.Location = new System.Drawing.Point(31, 66);
            this.chkPromExacto.Name = "chkPromExacto";
            this.chkPromExacto.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkPromExacto.Size = new System.Drawing.Size(183, 20);
            this.chkPromExacto.TabIndex = 14;
            this.chkPromExacto.Text = "Habilitar promedio exacto";
            this.chkPromExacto.UseVisualStyleBackColor = true;
            this.chkPromExacto.CheckedChanged += new System.EventHandler(this.chkPromExacto_CheckedChanged);
            // 
            // nudPromedio
            // 
            this.nudPromedio.Location = new System.Drawing.Point(323, 65);
            this.nudPromedio.Name = "nudPromedio";
            this.nudPromedio.Size = new System.Drawing.Size(70, 22);
            this.nudPromedio.TabIndex = 15;
            // 
            // lblEx
            // 
            this.lblEx.AutoSize = true;
            this.lblEx.Location = new System.Drawing.Point(399, 68);
            this.lblEx.Name = "lblEx";
            this.lblEx.Size = new System.Drawing.Size(19, 16);
            this.lblEx.TabIndex = 16;
            this.lblEx.Text = "%";
            // 
            // lblPromedio
            // 
            this.lblPromedio.AutoSize = true;
            this.lblPromedio.Location = new System.Drawing.Point(248, 68);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(69, 16);
            this.lblPromedio.TabIndex = 17;
            this.lblPromedio.Text = "Promedio:";
            // 
            // Clegajo
            // 
            this.Clegajo.HeaderText = "Legajo";
            this.Clegajo.MinimumWidth = 6;
            this.Clegajo.Name = "Clegajo";
            this.Clegajo.ReadOnly = true;
            this.Clegajo.Width = 125;
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
            this.Cpromedio.Width = 75;
            // 
            // Cmateria
            // 
            this.Cmateria.HeaderText = "Materia";
            this.Cmateria.MinimumWidth = 6;
            this.Cmateria.Name = "Cmateria";
            this.Cmateria.ReadOnly = true;
            this.Cmateria.Width = 125;
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
            this.Cturno.Width = 70;
            // 
            // FrmConsulta3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 439);
            this.Controls.Add(this.lblPromedio);
            this.Controls.Add(this.lblEx);
            this.Controls.Add(this.nudPromedio);
            this.Controls.Add(this.chkPromExacto);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.dgvConsulta);
            this.Controls.Add(this.Sentencia);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
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

