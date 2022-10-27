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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.CLegajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CAlumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CEdad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNotaPromedio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ccant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CAcciones = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.chkPromedioExtra = new System.Windows.Forms.CheckBox();
            this.lblExtra = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdad1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdad2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPromedio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEnunciado
            // 
            this.lblEnunciado.AutoSize = true;
            this.lblEnunciado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnunciado.Location = new System.Drawing.Point(15, 9);
            this.lblEnunciado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEnunciado.Name = "lblEnunciado";
            this.lblEnunciado.Size = new System.Drawing.Size(676, 40);
            this.lblEnunciado.TabIndex = 0;
            this.lblEnunciado.Text = "Promedio de notas y cantidad de examenes de determinado tipo, rendidos por cada\r\n" +
    "alumno cuya edad esté dentro del rango asignado";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(19, 58);
            this.lblTipo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(86, 13);
            this.lblTipo.TabIndex = 1;
            this.lblTipo.Text = "Tipo de examen:";
            // 
            // nudEdad1
            // 
            this.nudEdad1.Location = new System.Drawing.Point(161, 74);
            this.nudEdad1.Margin = new System.Windows.Forms.Padding(2);
            this.nudEdad1.Name = "nudEdad1";
            this.nudEdad1.Size = new System.Drawing.Size(41, 20);
            this.nudEdad1.TabIndex = 2;
            this.nudEdad1.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // cboTipoExamenes
            // 
            this.cboTipoExamenes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoExamenes.FormattingEnabled = true;
            this.cboTipoExamenes.Location = new System.Drawing.Point(22, 74);
            this.cboTipoExamenes.Margin = new System.Windows.Forms.Padding(2);
            this.cboTipoExamenes.Name = "cboTipoExamenes";
            this.cboTipoExamenes.Size = new System.Drawing.Size(122, 21);
            this.cboTipoExamenes.TabIndex = 3;
            this.cboTipoExamenes.SelectedIndexChanged += new System.EventHandler(this.cboTipoExamenes_SelectedIndexChanged);
            // 
            // nudEdad2
            // 
            this.nudEdad2.Location = new System.Drawing.Point(225, 74);
            this.nudEdad2.Margin = new System.Windows.Forms.Padding(2);
            this.nudEdad2.Name = "nudEdad2";
            this.nudEdad2.Size = new System.Drawing.Size(41, 20);
            this.nudEdad2.TabIndex = 4;
            this.nudEdad2.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            // 
            // nudPromedio
            // 
            this.nudPromedio.Enabled = false;
            this.nudPromedio.Location = new System.Drawing.Point(513, 74);
            this.nudPromedio.Margin = new System.Windows.Forms.Padding(2);
            this.nudPromedio.Name = "nudPromedio";
            this.nudPromedio.Size = new System.Drawing.Size(45, 20);
            this.nudPromedio.TabIndex = 5;
            // 
            // lblRangoEdad
            // 
            this.lblRangoEdad.AutoSize = true;
            this.lblRangoEdad.Location = new System.Drawing.Point(159, 58);
            this.lblRangoEdad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRangoEdad.Name = "lblRangoEdad";
            this.lblRangoEdad.Size = new System.Drawing.Size(138, 13);
            this.lblRangoEdad.TabIndex = 6;
            this.lblRangoEdad.Text = "Rango de edad del alumno:";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(210, 77);
            this.lblY.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(12, 13);
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
            this.dgvConsulta.Location = new System.Drawing.Point(19, 107);
            this.dgvConsulta.Margin = new System.Windows.Forms.Padding(2);
            this.dgvConsulta.Name = "dgvConsulta";
            this.dgvConsulta.ReadOnly = true;
            this.dgvConsulta.RowHeadersWidth = 51;
            this.dgvConsulta.RowTemplate.Height = 24;
            this.dgvConsulta.Size = new System.Drawing.Size(664, 200);
            this.dgvConsulta.TabIndex = 9;
            this.dgvConsulta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsulta_CellContentClick);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.CAcciones.DefaultCellStyle = dataGridViewCellStyle1;
            this.CAcciones.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CAcciones.HeaderText = "Acciones";
            this.CAcciones.MinimumWidth = 6;
            this.CAcciones.Name = "CAcciones";
            this.CAcciones.ReadOnly = true;
            this.CAcciones.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CAcciones.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.CAcciones.Text = "Contactar";
            this.CAcciones.UseColumnTextForButtonValue = true;
            this.CAcciones.Width = 110;
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConsultar.ForeColor = System.Drawing.Color.White;
            this.btnConsultar.Location = new System.Drawing.Point(610, 65);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(2);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(73, 29);
            this.btnConsultar.TabIndex = 10;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Red;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(610, 312);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(73, 29);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // chkPromedioExtra
            // 
            this.chkPromedioExtra.AutoSize = true;
            this.chkPromedioExtra.Location = new System.Drawing.Point(306, 75);
            this.chkPromedioExtra.Margin = new System.Windows.Forms.Padding(2);
            this.chkPromedioExtra.Name = "chkPromedioExtra";
            this.chkPromedioExtra.Size = new System.Drawing.Size(200, 17);
            this.chkPromedioExtra.TabIndex = 12;
            this.chkPromedioExtra.Text = "Sólo los que superen el promedio de:";
            this.chkPromedioExtra.UseVisualStyleBackColor = true;
            this.chkPromedioExtra.CheckedChanged += new System.EventHandler(this.chkAnio_CheckedChanged);
            // 
            // lblExtra
            // 
            this.lblExtra.AutoSize = true;
            this.lblExtra.Location = new System.Drawing.Point(304, 58);
            this.lblExtra.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblExtra.Name = "lblExtra";
            this.lblExtra.Size = new System.Drawing.Size(34, 13);
            this.lblExtra.TabIndex = 13;
            this.lblExtra.Text = "Extra:\r\n";
            // 
            // FrmConsulta5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(706, 352);
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
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