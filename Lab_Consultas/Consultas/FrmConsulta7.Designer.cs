namespace Lab_Consultas.Consultas
{
    partial class FrmConsulta7
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsulta7));
            this.lblEnunciado = new System.Windows.Forms.Label();
            this.lblExtra = new System.Windows.Forms.Label();
            this.chkTipoExamen = new System.Windows.Forms.CheckBox();
            this.nudAnio = new System.Windows.Forms.NumericUpDown();
            this.cboTipoExamenes = new System.Windows.Forms.ComboBox();
            this.lblAnio = new System.Windows.Forms.Label();
            this.dgvConsulta = new System.Windows.Forms.DataGridView();
            this.CAlumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CEdad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNotaPromedio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ccant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLegajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Alumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CAcciones = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEnunciado
            // 
            this.lblEnunciado.AutoSize = true;
            this.lblEnunciado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnunciado.Location = new System.Drawing.Point(16, 9);
            this.lblEnunciado.Name = "lblEnunciado";
            this.lblEnunciado.Size = new System.Drawing.Size(503, 60);
            this.lblEnunciado.TabIndex = 2;
            this.lblEnunciado.Text = "Examenes de este año cuya nota superó el promedio general \r\nde notas de su mismo " +
    "tipo de examen, en un año a elección.\r\n\r\n";
            // 
            // lblExtra
            // 
            this.lblExtra.AutoSize = true;
            this.lblExtra.Location = new System.Drawing.Point(143, 57);
            this.lblExtra.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblExtra.Name = "lblExtra";
            this.lblExtra.Size = new System.Drawing.Size(34, 13);
            this.lblExtra.TabIndex = 16;
            this.lblExtra.Text = "Extra:\r\n";
            // 
            // chkTipoExamen
            // 
            this.chkTipoExamen.AutoSize = true;
            this.chkTipoExamen.Location = new System.Drawing.Point(145, 74);
            this.chkTipoExamen.Margin = new System.Windows.Forms.Padding(2);
            this.chkTipoExamen.Name = "chkTipoExamen";
            this.chkTipoExamen.Size = new System.Drawing.Size(183, 17);
            this.chkTipoExamen.TabIndex = 15;
            this.chkTipoExamen.Text = "Elegir tipo de examen específico.\r\n";
            this.chkTipoExamen.UseVisualStyleBackColor = true;
            this.chkTipoExamen.CheckedChanged += new System.EventHandler(this.chkTipoExamen_CheckedChanged);
            // 
            // nudAnio
            // 
            this.nudAnio.Location = new System.Drawing.Point(20, 71);
            this.nudAnio.Margin = new System.Windows.Forms.Padding(2);
            this.nudAnio.Maximum = new decimal(new int[] {
            2022,
            0,
            0,
            0});
            this.nudAnio.Minimum = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            this.nudAnio.Name = "nudAnio";
            this.nudAnio.Size = new System.Drawing.Size(74, 20);
            this.nudAnio.TabIndex = 14;
            this.nudAnio.Value = new decimal(new int[] {
            2022,
            0,
            0,
            0});
            // 
            // cboTipoExamenes
            // 
            this.cboTipoExamenes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoExamenes.Enabled = false;
            this.cboTipoExamenes.FormattingEnabled = true;
            this.cboTipoExamenes.Location = new System.Drawing.Point(332, 71);
            this.cboTipoExamenes.Margin = new System.Windows.Forms.Padding(2);
            this.cboTipoExamenes.Name = "cboTipoExamenes";
            this.cboTipoExamenes.Size = new System.Drawing.Size(122, 21);
            this.cboTipoExamenes.TabIndex = 18;
            this.cboTipoExamenes.SelectedIndexChanged += new System.EventHandler(this.cboTipoExamenes_SelectedIndexChanged);
            // 
            // lblAnio
            // 
            this.lblAnio.AutoSize = true;
            this.lblAnio.Location = new System.Drawing.Point(17, 55);
            this.lblAnio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAnio.Name = "lblAnio";
            this.lblAnio.Size = new System.Drawing.Size(29, 13);
            this.lblAnio.TabIndex = 17;
            this.lblAnio.Text = "Año:";
            // 
            // dgvConsulta
            // 
            this.dgvConsulta.AllowUserToAddRows = false;
            this.dgvConsulta.AllowUserToDeleteRows = false;
            this.dgvConsulta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvConsulta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsulta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CAlumno,
            this.CEdad,
            this.CNotaPromedio,
            this.Ccant,
            this.CLegajo,
            this.Alumno,
            this.CAcciones});
            this.dgvConsulta.Location = new System.Drawing.Point(20, 105);
            this.dgvConsulta.Margin = new System.Windows.Forms.Padding(2);
            this.dgvConsulta.Name = "dgvConsulta";
            this.dgvConsulta.ReadOnly = true;
            this.dgvConsulta.RowHeadersWidth = 51;
            this.dgvConsulta.RowTemplate.Height = 24;
            this.dgvConsulta.Size = new System.Drawing.Size(769, 276);
            this.dgvConsulta.TabIndex = 19;
            this.dgvConsulta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsulta_CellContentClick);
            // 
            // CAlumno
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CAlumno.DefaultCellStyle = dataGridViewCellStyle2;
            this.CAlumno.HeaderText = "Materia";
            this.CAlumno.MinimumWidth = 6;
            this.CAlumno.Name = "CAlumno";
            this.CAlumno.ReadOnly = true;
            this.CAlumno.Width = 160;
            // 
            // CEdad
            // 
            this.CEdad.HeaderText = "Examen";
            this.CEdad.MinimumWidth = 6;
            this.CEdad.Name = "CEdad";
            this.CEdad.ReadOnly = true;
            this.CEdad.Width = 120;
            // 
            // CNotaPromedio
            // 
            this.CNotaPromedio.FillWeight = 90F;
            this.CNotaPromedio.HeaderText = "Tipo";
            this.CNotaPromedio.MinimumWidth = 6;
            this.CNotaPromedio.Name = "CNotaPromedio";
            this.CNotaPromedio.ReadOnly = true;
            this.CNotaPromedio.Width = 90;
            // 
            // Ccant
            // 
            this.Ccant.HeaderText = "Nota";
            this.Ccant.MinimumWidth = 6;
            this.Ccant.Name = "Ccant";
            this.Ccant.ReadOnly = true;
            this.Ccant.Width = 50;
            // 
            // CLegajo
            // 
            this.CLegajo.HeaderText = "Legajo";
            this.CLegajo.MinimumWidth = 6;
            this.CLegajo.Name = "CLegajo";
            this.CLegajo.ReadOnly = true;
            this.CLegajo.Width = 70;
            // 
            // Alumno
            // 
            this.Alumno.HeaderText = "Alumno";
            this.Alumno.Name = "Alumno";
            this.Alumno.ReadOnly = true;
            // 
            // CAcciones
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            this.CAcciones.DefaultCellStyle = dataGridViewCellStyle3;
            this.CAcciones.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CAcciones.HeaderText = "Acciones";
            this.CAcciones.MinimumWidth = 6;
            this.CAcciones.Name = "CAcciones";
            this.CAcciones.ReadOnly = true;
            this.CAcciones.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CAcciones.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.CAcciones.Text = "Contactar";
            this.CAcciones.UseColumnTextForButtonValue = true;
            this.CAcciones.Width = 115;
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConsultar.ForeColor = System.Drawing.Color.White;
            this.btnConsultar.Location = new System.Drawing.Point(716, 71);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(2);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(73, 30);
            this.btnConsultar.TabIndex = 20;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click_1);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Red;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(716, 385);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(73, 30);
            this.btnSalir.TabIndex = 21;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmConsulta7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(807, 428);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.dgvConsulta);
            this.Controls.Add(this.cboTipoExamenes);
            this.Controls.Add(this.lblAnio);
            this.Controls.Add(this.lblExtra);
            this.Controls.Add(this.chkTipoExamen);
            this.Controls.Add(this.nudAnio);
            this.Controls.Add(this.lblEnunciado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmConsulta7";
            this.Text = "Consulta 7";
            this.Load += new System.EventHandler(this.FrmConsulta7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudAnio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnunciado;
        private System.Windows.Forms.Label lblExtra;
        private System.Windows.Forms.CheckBox chkTipoExamen;
        private System.Windows.Forms.NumericUpDown nudAnio;
        private System.Windows.Forms.ComboBox cboTipoExamenes;
        private System.Windows.Forms.Label lblAnio;
        private System.Windows.Forms.DataGridView dgvConsulta;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn CAlumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn CEdad;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNotaPromedio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ccant;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLegajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Alumno;
        private System.Windows.Forms.DataGridViewButtonColumn CAcciones;
    }
}