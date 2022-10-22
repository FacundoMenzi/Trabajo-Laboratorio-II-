namespace Lab_Consultas.Consultas
{
    partial class FrmConsulta5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsulta5));
            this.lblEnunciado = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.nudEdad1 = new System.Windows.Forms.NumericUpDown();
            this.cboTipoExamenes = new System.Windows.Forms.ComboBox();
            this.nudEdad2 = new System.Windows.Forms.NumericUpDown();
            this.nudPromedio = new System.Windows.Forms.NumericUpDown();
            this.lblRangoEdad = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.dgvConsulta = new System.Windows.Forms.DataGridView();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.chkPromedioExtra = new System.Windows.Forms.CheckBox();
            this.lblExtra = new System.Windows.Forms.Label();
            this.CLegajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CAlumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CEdad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNotaPromedio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ccant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CAcciones = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdad1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdad2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPromedio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEnunciado
            // 
            this.lblEnunciado.AutoSize = true;
            this.lblEnunciado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnunciado.Location = new System.Drawing.Point(24, 22);
            this.lblEnunciado.Name = "lblEnunciado";
            this.lblEnunciado.Size = new System.Drawing.Size(708, 40);
            this.lblEnunciado.TabIndex = 0;
            this.lblEnunciado.Text = "Promedio de notas y cantidad de examenes de determinado tipo, rendidos por cada\r\n" +
    "alumno cuya edad esté dentro del rango asignado";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(22, 84);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(108, 16);
            this.lblTipo.TabIndex = 1;
            this.lblTipo.Text = "Tipo de examen:";
            // 
            // nudEdad1
            // 
            this.nudEdad1.Location = new System.Drawing.Point(211, 104);
            this.nudEdad1.Name = "nudEdad1";
            this.nudEdad1.Size = new System.Drawing.Size(55, 22);
            this.nudEdad1.TabIndex = 2;
            // 
            // cboTipoExamenes
            // 
            this.cboTipoExamenes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoExamenes.FormattingEnabled = true;
            this.cboTipoExamenes.Location = new System.Drawing.Point(25, 103);
            this.cboTipoExamenes.Name = "cboTipoExamenes";
            this.cboTipoExamenes.Size = new System.Drawing.Size(161, 24);
            this.cboTipoExamenes.TabIndex = 3;
            // 
            // nudEdad2
            // 
            this.nudEdad2.Location = new System.Drawing.Point(296, 104);
            this.nudEdad2.Name = "nudEdad2";
            this.nudEdad2.Size = new System.Drawing.Size(55, 22);
            this.nudEdad2.TabIndex = 4;
            // 
            // nudPromedio
            // 
            this.nudPromedio.Enabled = false;
            this.nudPromedio.Location = new System.Drawing.Point(680, 104);
            this.nudPromedio.Name = "nudPromedio";
            this.nudPromedio.Size = new System.Drawing.Size(60, 22);
            this.nudPromedio.TabIndex = 5;
            // 
            // lblRangoEdad
            // 
            this.lblRangoEdad.AutoSize = true;
            this.lblRangoEdad.Location = new System.Drawing.Point(208, 84);
            this.lblRangoEdad.Name = "lblRangoEdad";
            this.lblRangoEdad.Size = new System.Drawing.Size(174, 16);
            this.lblRangoEdad.TabIndex = 6;
            this.lblRangoEdad.Text = "Rango de edad del alumno:";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(276, 107);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(14, 16);
            this.lblY.TabIndex = 7;
            this.lblY.Text = "y\r\n";
            // 
            // dgvConsulta
            // 
            this.dgvConsulta.AllowUserToAddRows = false;
            this.dgvConsulta.AllowUserToDeleteRows = false;
            this.dgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsulta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CLegajo,
            this.CAlumno,
            this.CEdad,
            this.CNotaPromedio,
            this.Ccant,
            this.CAcciones});
            this.dgvConsulta.Location = new System.Drawing.Point(25, 132);
            this.dgvConsulta.Name = "dgvConsulta";
            this.dgvConsulta.ReadOnly = true;
            this.dgvConsulta.RowHeadersWidth = 51;
            this.dgvConsulta.RowTemplate.Height = 24;
            this.dgvConsulta.Size = new System.Drawing.Size(886, 246);
            this.dgvConsulta.TabIndex = 9;
            this.dgvConsulta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsulta_CellContentClick);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(825, 104);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(86, 23);
            this.btnConsultar.TabIndex = 10;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(814, 384);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(97, 37);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // chkPromedioExtra
            // 
            this.chkPromedioExtra.AutoSize = true;
            this.chkPromedioExtra.Location = new System.Drawing.Point(404, 105);
            this.chkPromedioExtra.Name = "chkPromedioExtra";
            this.chkPromedioExtra.Size = new System.Drawing.Size(253, 20);
            this.chkPromedioExtra.TabIndex = 12;
            this.chkPromedioExtra.Text = "Sólo los que superen el promedio de:";
            this.chkPromedioExtra.UseVisualStyleBackColor = true;
            this.chkPromedioExtra.CheckedChanged += new System.EventHandler(this.chkAnio_CheckedChanged);
            // 
            // lblExtra
            // 
            this.lblExtra.AutoSize = true;
            this.lblExtra.Location = new System.Drawing.Point(401, 84);
            this.lblExtra.Name = "lblExtra";
            this.lblExtra.Size = new System.Drawing.Size(40, 16);
            this.lblExtra.TabIndex = 13;
            this.lblExtra.Text = "Extra:\r\n";
            // 
            // CLegajo
            // 
            this.CLegajo.HeaderText = "Legajo";
            this.CLegajo.MinimumWidth = 6;
            this.CLegajo.Name = "CLegajo";
            this.CLegajo.ReadOnly = true;
            // 
            // CAlumno
            // 
            this.CAlumno.HeaderText = "Alumno";
            this.CAlumno.MinimumWidth = 6;
            this.CAlumno.Name = "CAlumno";
            this.CAlumno.ReadOnly = true;
            this.CAlumno.Width = 125;
            // 
            // CEdad
            // 
            this.CEdad.HeaderText = "Edad";
            this.CEdad.MinimumWidth = 6;
            this.CEdad.Name = "CEdad";
            this.CEdad.ReadOnly = true;
            this.CEdad.Width = 50;
            // 
            // CNotaPromedio
            // 
            this.CNotaPromedio.HeaderText = "Nota Promedio";
            this.CNotaPromedio.MinimumWidth = 6;
            this.CNotaPromedio.Name = "CNotaPromedio";
            this.CNotaPromedio.ReadOnly = true;
            this.CNotaPromedio.Width = 125;
            // 
            // Ccant
            // 
            this.Ccant.HeaderText = "Exámenes rendidos";
            this.Ccant.MinimumWidth = 6;
            this.Ccant.Name = "Ccant";
            this.Ccant.ReadOnly = true;
            // 
            // CAcciones
            // 
            this.CAcciones.HeaderText = "Acciones";
            this.CAcciones.MinimumWidth = 6;
            this.CAcciones.Name = "CAcciones";
            this.CAcciones.ReadOnly = true;
            this.CAcciones.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CAcciones.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.CAcciones.Text = "Contactar";
            this.CAcciones.UseColumnTextForButtonValue = true;
            this.CAcciones.Width = 105;
            // 
            // FrmConsulta5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 433);
            this.Controls.Add(this.lblExtra);
            this.Controls.Add(this.chkPromedioExtra);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.dgvConsulta);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.lblRangoEdad);
            this.Controls.Add(this.nudPromedio);
            this.Controls.Add(this.nudEdad2);
            this.Controls.Add(this.cboTipoExamenes);
            this.Controls.Add(this.nudEdad1);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblEnunciado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmConsulta5";
            this.Text = "Consulta 5";
            this.Load += new System.EventHandler(this.FrmConsulta_5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudEdad1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdad2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPromedio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnunciado;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.NumericUpDown nudEdad1;
        private System.Windows.Forms.ComboBox cboTipoExamenes;
        private System.Windows.Forms.NumericUpDown nudEdad2;
        private System.Windows.Forms.NumericUpDown nudPromedio;
        private System.Windows.Forms.Label lblRangoEdad;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.DataGridView dgvConsulta;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.CheckBox chkPromedioExtra;
        private System.Windows.Forms.Label lblExtra;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLegajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CAlumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn CEdad;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNotaPromedio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ccant;
        private System.Windows.Forms.DataGridViewButtonColumn CAcciones;
    }
}