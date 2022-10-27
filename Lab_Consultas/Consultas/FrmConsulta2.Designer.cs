namespace WINDOWS_FORM
{
    partial class FrmConsulta2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsulta2));
            this.lblEnunciado = new System.Windows.Forms.Label();
            this.lblAñoComparar = new System.Windows.Forms.Label();
            this.nudAnio = new System.Windows.Forms.NumericUpDown();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.dgvConsulta = new System.Windows.Forms.DataGridView();
            this.ClmID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmProfesor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmAccion = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEnunciado
            // 
            this.lblEnunciado.AutoSize = true;
            this.lblEnunciado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnunciado.Location = new System.Drawing.Point(12, 9);
            this.lblEnunciado.Name = "lblEnunciado";
            this.lblEnunciado.Size = new System.Drawing.Size(478, 20);
            this.lblEnunciado.TabIndex = 1;
            this.lblEnunciado.Text = "Profesores que no tomaron exámenes en determinado año";
            // 
            // lblAñoComparar
            // 
            this.lblAñoComparar.AutoSize = true;
            this.lblAñoComparar.Location = new System.Drawing.Point(23, 42);
            this.lblAñoComparar.Name = "lblAñoComparar";
            this.lblAñoComparar.Size = new System.Drawing.Size(29, 13);
            this.lblAñoComparar.TabIndex = 10;
            this.lblAñoComparar.Text = "Año:";
            // 
            // nudAnio
            // 
            this.nudAnio.Location = new System.Drawing.Point(58, 40);
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
            this.nudAnio.Size = new System.Drawing.Size(103, 20);
            this.nudAnio.TabIndex = 9;
            this.nudAnio.Value = new decimal(new int[] {
            2022,
            0,
            0,
            0});
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Red;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(490, 348);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 19;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnLimpiar.Location = new System.Drawing.Point(409, 40);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 18;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConsultar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnConsultar.Location = new System.Drawing.Point(490, 40);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 17;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // dgvConsulta
            // 
            this.dgvConsulta.AllowUserToAddRows = false;
            this.dgvConsulta.AllowUserToDeleteRows = false;
            this.dgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsulta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClmID,
            this.ClmProfesor,
            this.ClmTel,
            this.ClmEmail,
            this.ClmAccion});
            this.dgvConsulta.Location = new System.Drawing.Point(13, 79);
            this.dgvConsulta.Name = "dgvConsulta";
            this.dgvConsulta.ReadOnly = true;
            this.dgvConsulta.RowHeadersWidth = 51;
            this.dgvConsulta.Size = new System.Drawing.Size(553, 263);
            this.dgvConsulta.TabIndex = 16;
            this.dgvConsulta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsulta_CellContentClick);
            // 
            // ClmID
            // 
            this.ClmID.HeaderText = "ID";
            this.ClmID.MinimumWidth = 6;
            this.ClmID.Name = "ClmID";
            this.ClmID.ReadOnly = true;
            this.ClmID.Visible = false;
            this.ClmID.Width = 125;
            // 
            // ClmProfesor
            // 
            this.ClmProfesor.HeaderText = "Profesor";
            this.ClmProfesor.MinimumWidth = 6;
            this.ClmProfesor.Name = "ClmProfesor";
            this.ClmProfesor.ReadOnly = true;
            this.ClmProfesor.Width = 125;
            // 
            // ClmTel
            // 
            this.ClmTel.HeaderText = "Teléfono";
            this.ClmTel.MinimumWidth = 6;
            this.ClmTel.Name = "ClmTel";
            this.ClmTel.ReadOnly = true;
            this.ClmTel.Width = 125;
            // 
            // ClmEmail
            // 
            this.ClmEmail.HeaderText = "E-Mail";
            this.ClmEmail.MinimumWidth = 6;
            this.ClmEmail.Name = "ClmEmail";
            this.ClmEmail.ReadOnly = true;
            this.ClmEmail.Width = 125;
            // 
            // ClmAccion
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.ClmAccion.DefaultCellStyle = dataGridViewCellStyle1;
            this.ClmAccion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ClmAccion.HeaderText = "Acciones";
            this.ClmAccion.MinimumWidth = 6;
            this.ClmAccion.Name = "ClmAccion";
            this.ClmAccion.ReadOnly = true;
            this.ClmAccion.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ClmAccion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ClmAccion.Text = "Contactar";
            this.ClmAccion.UseColumnTextForButtonValue = true;
            this.ClmAccion.Width = 125;
            // 
            // FrmConsulta2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(585, 383);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.dgvConsulta);
            this.Controls.Add(this.lblAñoComparar);
            this.Controls.Add(this.nudAnio);
            this.Controls.Add(this.lblEnunciado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmConsulta2";
            this.Text = "Consulta 2";
            this.Load += new System.EventHandler(this.Consulta9_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudAnio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnunciado;
        private System.Windows.Forms.Label lblAñoComparar;
        private System.Windows.Forms.NumericUpDown nudAnio;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.DataGridView dgvConsulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmProfesor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmEmail;
        private System.Windows.Forms.DataGridViewButtonColumn ClmAccion;
    }
}