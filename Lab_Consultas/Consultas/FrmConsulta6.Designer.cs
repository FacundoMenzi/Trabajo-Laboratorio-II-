namespace Lab_Consultas.Consultas
{
    partial class FrmConsulta6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsulta6));
            this.lblEnunciado = new System.Windows.Forms.Label();
            this.lblNota = new System.Windows.Forms.Label();
            this.nudNota = new System.Windows.Forms.NumericUpDown();
            this.nudAnio = new System.Windows.Forms.NumericUpDown();
            this.lblAnio = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dgvConsulta = new System.Windows.Forms.DataGridView();
            this.cboSituacion = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CLegajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CAlumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CBarrio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cemail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Csit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cestado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cacciones = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.nudNota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEnunciado
            // 
            this.lblEnunciado.AutoSize = true;
            this.lblEnunciado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnunciado.Location = new System.Drawing.Point(18, 9);
            this.lblEnunciado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEnunciado.Name = "lblEnunciado";
            this.lblEnunciado.Size = new System.Drawing.Size(536, 40);
            this.lblEnunciado.TabIndex = 0;
            this.lblEnunciado.Text = "Datos de los alumnos en cierta situacion habitacional, \r\nlos cuales tienen alguna" +
    " nota mayor a la elegida dentro de un año\r\n";
            // 
            // lblNota
            // 
            this.lblNota.AutoSize = true;
            this.lblNota.Location = new System.Drawing.Point(288, 66);
            this.lblNota.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNota.Name = "lblNota";
            this.lblNota.Size = new System.Drawing.Size(33, 13);
            this.lblNota.TabIndex = 1;
            this.lblNota.Text = "Nota:";
            // 
            // nudNota
            // 
            this.nudNota.Location = new System.Drawing.Point(322, 63);
            this.nudNota.Margin = new System.Windows.Forms.Padding(2);
            this.nudNota.Name = "nudNota";
            this.nudNota.Size = new System.Drawing.Size(57, 20);
            this.nudNota.TabIndex = 2;
            // 
            // nudAnio
            // 
            this.nudAnio.Location = new System.Drawing.Point(503, 63);
            this.nudAnio.Margin = new System.Windows.Forms.Padding(2);
            this.nudAnio.Maximum = new decimal(new int[] {
            2022,
            0,
            0,
            0});
            this.nudAnio.Minimum = new decimal(new int[] {
            2019,
            0,
            0,
            0});
            this.nudAnio.Name = "nudAnio";
            this.nudAnio.Size = new System.Drawing.Size(90, 20);
            this.nudAnio.TabIndex = 3;
            this.nudAnio.Value = new decimal(new int[] {
            2022,
            0,
            0,
            0});
            // 
            // lblAnio
            // 
            this.lblAnio.AutoSize = true;
            this.lblAnio.Location = new System.Drawing.Point(418, 66);
            this.lblAnio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAnio.Name = "lblAnio";
            this.lblAnio.Size = new System.Drawing.Size(80, 13);
            this.lblAnio.TabIndex = 4;
            this.lblAnio.Text = "Dentro del año:";
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConsultar.ForeColor = System.Drawing.Color.White;
            this.btnConsultar.Location = new System.Drawing.Point(720, 56);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(2);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(81, 31);
            this.btnConsultar.TabIndex = 5;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Red;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(720, 362);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(81, 31);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dgvConsulta
            // 
            this.dgvConsulta.AllowUserToAddRows = false;
            this.dgvConsulta.AllowUserToDeleteRows = false;
            this.dgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsulta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CLegajo,
            this.CAlumno,
            this.CBarrio,
            this.Cemail,
            this.Csit,
            this.Cestado,
            this.Cacciones});
            this.dgvConsulta.Location = new System.Drawing.Point(10, 98);
            this.dgvConsulta.Margin = new System.Windows.Forms.Padding(2);
            this.dgvConsulta.Name = "dgvConsulta";
            this.dgvConsulta.ReadOnly = true;
            this.dgvConsulta.RowHeadersWidth = 51;
            this.dgvConsulta.RowTemplate.Height = 24;
            this.dgvConsulta.Size = new System.Drawing.Size(791, 259);
            this.dgvConsulta.TabIndex = 7;
            this.dgvConsulta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsulta_CellContentClick);
            // 
            // cboSituacion
            // 
            this.cboSituacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSituacion.FormattingEnabled = true;
            this.cboSituacion.Location = new System.Drawing.Point(139, 62);
            this.cboSituacion.Margin = new System.Windows.Forms.Padding(2);
            this.cboSituacion.Name = "cboSituacion";
            this.cboSituacion.Size = new System.Drawing.Size(126, 21);
            this.cboSituacion.TabIndex = 8;
            this.cboSituacion.SelectedIndexChanged += new System.EventHandler(this.cboSituacion_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Situacion Habitacional:";
            // 
            // CLegajo
            // 
            this.CLegajo.HeaderText = "Legajo";
            this.CLegajo.MinimumWidth = 6;
            this.CLegajo.Name = "CLegajo";
            this.CLegajo.ReadOnly = true;
            this.CLegajo.Width = 60;
            // 
            // CAlumno
            // 
            this.CAlumno.HeaderText = "Alumno";
            this.CAlumno.MinimumWidth = 6;
            this.CAlumno.Name = "CAlumno";
            this.CAlumno.ReadOnly = true;
            this.CAlumno.Width = 125;
            // 
            // CBarrio
            // 
            this.CBarrio.HeaderText = "Barrio";
            this.CBarrio.MinimumWidth = 6;
            this.CBarrio.Name = "CBarrio";
            this.CBarrio.ReadOnly = true;
            this.CBarrio.Width = 125;
            // 
            // Cemail
            // 
            this.Cemail.HeaderText = "E-Mail";
            this.Cemail.MinimumWidth = 6;
            this.Cemail.Name = "Cemail";
            this.Cemail.ReadOnly = true;
            this.Cemail.Width = 125;
            // 
            // Csit
            // 
            this.Csit.HeaderText = "Situación Habitacional";
            this.Csit.MinimumWidth = 6;
            this.Csit.Name = "Csit";
            this.Csit.ReadOnly = true;
            // 
            // Cestado
            // 
            this.Cestado.HeaderText = "Estado Civil";
            this.Cestado.MinimumWidth = 6;
            this.Cestado.Name = "Cestado";
            this.Cestado.ReadOnly = true;
            this.Cestado.Width = 80;
            // 
            // Cacciones
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.Cacciones.DefaultCellStyle = dataGridViewCellStyle1;
            this.Cacciones.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cacciones.HeaderText = "Acciones";
            this.Cacciones.MinimumWidth = 6;
            this.Cacciones.Name = "Cacciones";
            this.Cacciones.ReadOnly = true;
            this.Cacciones.Text = "Contactar";
            this.Cacciones.UseColumnTextForButtonValue = true;
            this.Cacciones.Width = 122;
            // 
            // FrmConsulta6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(824, 410);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboSituacion);
            this.Controls.Add(this.dgvConsulta);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.lblAnio);
            this.Controls.Add(this.nudAnio);
            this.Controls.Add(this.nudNota);
            this.Controls.Add(this.lblNota);
            this.Controls.Add(this.lblEnunciado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FrmConsulta6";
            this.Text = "Consulta 6";
            this.Load += new System.EventHandler(this.FrmConsulta6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudNota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnunciado;
        private System.Windows.Forms.Label lblNota;
        private System.Windows.Forms.NumericUpDown nudNota;
        private System.Windows.Forms.NumericUpDown nudAnio;
        private System.Windows.Forms.Label lblAnio;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dgvConsulta;
        private System.Windows.Forms.ComboBox cboSituacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLegajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CAlumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn CBarrio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cemail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Csit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cestado;
        private System.Windows.Forms.DataGridViewButtonColumn Cacciones;
    }
}