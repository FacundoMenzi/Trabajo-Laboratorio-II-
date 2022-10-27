namespace Lab_Consultas
{
    partial class FrmConsulta1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsulta1));
            this.lblEnunciado = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudNota1 = new System.Windows.Forms.NumericUpDown();
            this.nudNota2 = new System.Windows.Forms.NumericUpDown();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblY = new System.Windows.Forms.Label();
            this.lblAnio = new System.Windows.Forms.Label();
            this.dgvConsulta = new System.Windows.Forms.DataGridView();
            this.ClmCant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmProfesor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.nudAnio = new System.Windows.Forms.NumericUpDown();
            this.chkExtra = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudNota1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNota2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnio)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEnunciado
            // 
            this.lblEnunciado.AutoSize = true;
            this.lblEnunciado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnunciado.Location = new System.Drawing.Point(9, 7);
            this.lblEnunciado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEnunciado.Name = "lblEnunciado";
            this.lblEnunciado.Size = new System.Drawing.Size(534, 20);
            this.lblEnunciado.TabIndex = 0;
            this.lblEnunciado.Text = "Cantidad de examenes tomados por profesor en determinado año";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre profesor:";
            // 
            // nudNota1
            // 
            this.nudNota1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudNota1.Enabled = false;
            this.nudNota1.Location = new System.Drawing.Point(505, 63);
            this.nudNota1.Margin = new System.Windows.Forms.Padding(2);
            this.nudNota1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudNota1.Name = "nudNota1";
            this.nudNota1.Size = new System.Drawing.Size(42, 20);
            this.nudNota1.TabIndex = 2;
            this.nudNota1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudNota2
            // 
            this.nudNota2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudNota2.Enabled = false;
            this.nudNota2.Location = new System.Drawing.Point(569, 63);
            this.nudNota2.Margin = new System.Windows.Forms.Padding(2);
            this.nudNota2.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudNota2.Name = "nudNota2";
            this.nudNota2.Size = new System.Drawing.Size(42, 20);
            this.nudNota2.TabIndex = 3;
            this.nudNota2.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(104, 63);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(131, 20);
            this.txtNombre.TabIndex = 4;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(551, 67);
            this.lblY.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(12, 13);
            this.lblY.TabIndex = 6;
            this.lblY.Text = "y";
            // 
            // lblAnio
            // 
            this.lblAnio.AutoSize = true;
            this.lblAnio.Location = new System.Drawing.Point(245, 67);
            this.lblAnio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAnio.Name = "lblAnio";
            this.lblAnio.Size = new System.Drawing.Size(29, 13);
            this.lblAnio.TabIndex = 7;
            this.lblAnio.Text = "Año:";
            // 
            // dgvConsulta
            // 
            this.dgvConsulta.AllowUserToAddRows = false;
            this.dgvConsulta.AllowUserToDeleteRows = false;
            this.dgvConsulta.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.dgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsulta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClmCant,
            this.ClmProfesor});
            this.dgvConsulta.Location = new System.Drawing.Point(16, 91);
            this.dgvConsulta.Margin = new System.Windows.Forms.Padding(2);
            this.dgvConsulta.Name = "dgvConsulta";
            this.dgvConsulta.ReadOnly = true;
            this.dgvConsulta.RowHeadersWidth = 51;
            this.dgvConsulta.RowTemplate.Height = 24;
            this.dgvConsulta.Size = new System.Drawing.Size(595, 235);
            this.dgvConsulta.TabIndex = 9;
            // 
            // ClmCant
            // 
            this.ClmCant.HeaderText = "Cantidad de éxamenes";
            this.ClmCant.MinimumWidth = 6;
            this.ClmCant.Name = "ClmCant";
            this.ClmCant.ReadOnly = true;
            this.ClmCant.Width = 252;
            // 
            // ClmProfesor
            // 
            this.ClmProfesor.HeaderText = "Profesor";
            this.ClmProfesor.MinimumWidth = 6;
            this.ClmProfesor.Name = "ClmProfesor";
            this.ClmProfesor.ReadOnly = true;
            this.ClmProfesor.Width = 290;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Red;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(627, 306);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(70, 20);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnConsultar.Location = new System.Drawing.Point(627, 63);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(2);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(70, 20);
            this.btnConsultar.TabIndex = 11;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnEjecutar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnLimpiar.Location = new System.Drawing.Point(627, 91);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(70, 20);
            this.btnLimpiar.TabIndex = 12;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // nudAnio
            // 
            this.nudAnio.Location = new System.Drawing.Point(278, 63);
            this.nudAnio.Margin = new System.Windows.Forms.Padding(2);
            this.nudAnio.Maximum = new decimal(new int[] {
            2022,
            0,
            0,
            0});
            this.nudAnio.Minimum = new decimal(new int[] {
            2018,
            0,
            0,
            0});
            this.nudAnio.Name = "nudAnio";
            this.nudAnio.Size = new System.Drawing.Size(65, 20);
            this.nudAnio.TabIndex = 13;
            this.nudAnio.Value = new decimal(new int[] {
            2022,
            0,
            0,
            0});
            // 
            // chkExtra
            // 
            this.chkExtra.AutoSize = true;
            this.chkExtra.Location = new System.Drawing.Point(360, 65);
            this.chkExtra.Name = "chkExtra";
            this.chkExtra.Size = new System.Drawing.Size(140, 17);
            this.chkExtra.TabIndex = 14;
            this.chkExtra.Text = "Filtro por rango de notas";
            this.chkExtra.UseVisualStyleBackColor = true;
            this.chkExtra.CheckedChanged += new System.EventHandler(this.chkExtra_CheckedChanged);
            // 
            // FrmConsulta1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(706, 336);
            this.Controls.Add(this.chkExtra);
            this.Controls.Add(this.nudAnio);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgvConsulta);
            this.Controls.Add(this.lblAnio);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.nudNota2);
            this.Controls.Add(this.nudNota1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblEnunciado);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FrmConsulta1";
            this.Text = "Consulta 1";
            this.Load += new System.EventHandler(this.FrmConsultaX_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudNota1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNota2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnunciado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudNota1;
        private System.Windows.Forms.NumericUpDown nudNota2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Label lblAnio;
        private System.Windows.Forms.DataGridView dgvConsulta;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.NumericUpDown nudAnio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmCant;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmProfesor;
        private System.Windows.Forms.CheckBox chkExtra;
    }
}

