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
            this.lblEnunciado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblEnunciado.Location = new System.Drawing.Point(13, 21);
            this.lblEnunciado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnunciado.Name = "lblEnunciado";
            this.lblEnunciado.Size = new System.Drawing.Size(675, 58);
            this.lblEnunciado.TabIndex = 1;
            this.lblEnunciado.Text = "Profesores que no tomaron exámenes en determinado año\r\n\r\n";
            // 
            // lblAñoComparar
            // 
            this.lblAñoComparar.AutoSize = true;
            this.lblAñoComparar.Location = new System.Drawing.Point(15, 78);
            this.lblAñoComparar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAñoComparar.Name = "lblAñoComparar";
            this.lblAñoComparar.Size = new System.Drawing.Size(34, 16);
            this.lblAñoComparar.TabIndex = 10;
            this.lblAñoComparar.Text = "Año:";
            // 
            // nudAnio
            // 
            this.nudAnio.Location = new System.Drawing.Point(57, 76);
            this.nudAnio.Margin = new System.Windows.Forms.Padding(4);
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
            this.nudAnio.Size = new System.Drawing.Size(137, 22);
            this.nudAnio.TabIndex = 9;
            this.nudAnio.Value = new decimal(new int[] {
            2022,
            0,
            0,
            0});
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(654, 385);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(100, 28);
            this.btnSalir.TabIndex = 19;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.SystemColors.Control;
            this.btnLimpiar.Location = new System.Drawing.Point(546, 72);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(100, 28);
            this.btnLimpiar.TabIndex = 18;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(654, 72);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(4);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(100, 28);
            this.btnConsultar.TabIndex = 17;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
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
            this.dgvConsulta.Location = new System.Drawing.Point(17, 108);
            this.dgvConsulta.Margin = new System.Windows.Forms.Padding(4);
            this.dgvConsulta.Name = "dgvConsulta";
            this.dgvConsulta.ReadOnly = true;
            this.dgvConsulta.RowHeadersWidth = 51;
            this.dgvConsulta.Size = new System.Drawing.Size(737, 269);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 426);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.dgvConsulta);
            this.Controls.Add(this.lblAñoComparar);
            this.Controls.Add(this.nudAnio);
            this.Controls.Add(this.lblEnunciado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
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