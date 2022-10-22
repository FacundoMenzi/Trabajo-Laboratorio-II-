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
            this.lblRango = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.lblAnio = new System.Windows.Forms.Label();
            this.dgvConsulta = new System.Windows.Forms.DataGridView();
            this.ClmCant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmProfesor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.nudAnio = new System.Windows.Forms.NumericUpDown();
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
            this.lblEnunciado.Location = new System.Drawing.Point(12, 9);
            this.lblEnunciado.Name = "lblEnunciado";
            this.lblEnunciado.Size = new System.Drawing.Size(822, 50);
            this.lblEnunciado.TabIndex = 0;
            this.lblEnunciado.Text = "Cantidad de examenes tomados por profesor por rango de notas, solo si la cantidad" +
    " \r\nes mayor al promedio de tomados en determinado año\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre profesor:";
            // 
            // nudNota1
            // 
            this.nudNota1.Location = new System.Drawing.Point(475, 73);
            this.nudNota1.Name = "nudNota1";
            this.nudNota1.Size = new System.Drawing.Size(41, 22);
            this.nudNota1.TabIndex = 2;
            // 
            // nudNota2
            // 
            this.nudNota2.Location = new System.Drawing.Point(542, 73);
            this.nudNota2.Name = "nudNota2";
            this.nudNota2.Size = new System.Drawing.Size(41, 22);
            this.nudNota2.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(135, 73);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(209, 22);
            this.txtNombre.TabIndex = 4;
            // 
            // lblRango
            // 
            this.lblRango.AutoSize = true;
            this.lblRango.Location = new System.Drawing.Point(363, 76);
            this.lblRango.Name = "lblRango";
            this.lblRango.Size = new System.Drawing.Size(106, 16);
            this.lblRango.TabIndex = 5;
            this.lblRango.Text = "Rango de notas:";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(522, 76);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(14, 16);
            this.lblY.TabIndex = 6;
            this.lblY.Text = "y";
            // 
            // lblAnio
            // 
            this.lblAnio.AutoSize = true;
            this.lblAnio.Location = new System.Drawing.Point(602, 76);
            this.lblAnio.Name = "lblAnio";
            this.lblAnio.Size = new System.Drawing.Size(114, 16);
            this.lblAnio.TabIndex = 7;
            this.lblAnio.Text = "Año de promedio:";
            // 
            // dgvConsulta
            // 
            this.dgvConsulta.AllowUserToAddRows = false;
            this.dgvConsulta.AllowUserToDeleteRows = false;
            this.dgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsulta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClmCant,
            this.ClmProfesor});
            this.dgvConsulta.Location = new System.Drawing.Point(16, 112);
            this.dgvConsulta.Name = "dgvConsulta";
            this.dgvConsulta.ReadOnly = true;
            this.dgvConsulta.RowHeadersWidth = 51;
            this.dgvConsulta.RowTemplate.Height = 24;
            this.dgvConsulta.Size = new System.Drawing.Size(814, 289);
            this.dgvConsulta.TabIndex = 9;
            // 
            // ClmCant
            // 
            this.ClmCant.HeaderText = "Cantidad de éxamenes";
            this.ClmCant.MinimumWidth = 6;
            this.ClmCant.Name = "ClmCant";
            this.ClmCant.ReadOnly = true;
            this.ClmCant.Width = 255;
            // 
            // ClmProfesor
            // 
            this.ClmProfesor.HeaderText = "Profesor";
            this.ClmProfesor.MinimumWidth = 6;
            this.ClmProfesor.Name = "ClmProfesor";
            this.ClmProfesor.ReadOnly = true;
            this.ClmProfesor.Width = 300;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(836, 376);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(93, 25);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(836, 71);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(93, 25);
            this.btnConsultar.TabIndex = 11;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnEjecutar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(836, 112);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(93, 25);
            this.btnLimpiar.TabIndex = 12;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // nudAnio
            // 
            this.nudAnio.Location = new System.Drawing.Point(732, 72);
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
            this.nudAnio.Size = new System.Drawing.Size(87, 22);
            this.nudAnio.TabIndex = 13;
            this.nudAnio.Value = new decimal(new int[] {
            2022,
            0,
            0,
            0});
            // 
            // FrmConsulta1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 413);
            this.Controls.Add(this.nudAnio);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgvConsulta);
            this.Controls.Add(this.lblAnio);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.lblRango);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.nudNota2);
            this.Controls.Add(this.nudNota1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblEnunciado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.Label lblRango;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Label lblAnio;
        private System.Windows.Forms.DataGridView dgvConsulta;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmCant;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmProfesor;
        private System.Windows.Forms.NumericUpDown nudAnio;
    }
}

