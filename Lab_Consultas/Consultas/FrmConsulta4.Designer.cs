namespace Lab_Consultas.Consultas
{
    partial class FrmConsulta4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsulta4));
            this.lblConsulta = new System.Windows.Forms.Label();
            this.dgvConsulta = new System.Windows.Forms.DataGridView();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cboEstados = new System.Windows.Forms.ComboBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblTecnicatura = new System.Windows.Forms.Label();
            this.cboTecnicatura = new System.Windows.Forms.ComboBox();
            this.ClmCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmMateria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmTurno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmAnio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // lblConsulta
            // 
            this.lblConsulta.AutoSize = true;
            this.lblConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsulta.Location = new System.Drawing.Point(12, 9);
            this.lblConsulta.Name = "lblConsulta";
            this.lblConsulta.Size = new System.Drawing.Size(734, 52);
            this.lblConsulta.TabIndex = 0;
            this.lblConsulta.Text = "Cantidad de alumnos, por materia, curso y año de cursado de la\r\ntecnicatura a ele" +
    "cción, que estén en determinado estado académico\r\n";
            // 
            // dgvConsulta
            // 
            this.dgvConsulta.AllowUserToAddRows = false;
            this.dgvConsulta.AllowUserToDeleteRows = false;
            this.dgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsulta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClmCantidad,
            this.ClmMateria,
            this.ClmTurno,
            this.ClmAnio});
            this.dgvConsulta.Location = new System.Drawing.Point(46, 143);
            this.dgvConsulta.Name = "dgvConsulta";
            this.dgvConsulta.ReadOnly = true;
            this.dgvConsulta.RowHeadersWidth = 51;
            this.dgvConsulta.RowTemplate.Height = 24;
            this.dgvConsulta.Size = new System.Drawing.Size(742, 225);
            this.dgvConsulta.TabIndex = 1;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(325, 101);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(125, 16);
            this.lblEstado.TabIndex = 2;
            this.lblEstado.Text = "Estado Académico:";
            // 
            // cboEstados
            // 
            this.cboEstados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstados.FormattingEnabled = true;
            this.cboEstados.Location = new System.Drawing.Point(464, 97);
            this.cboEstados.Name = "cboEstados";
            this.cboEstados.Size = new System.Drawing.Size(163, 24);
            this.cboEstados.TabIndex = 3;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(713, 98);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 4;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(713, 385);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblTecnicatura
            // 
            this.lblTecnicatura.AutoSize = true;
            this.lblTecnicatura.Location = new System.Drawing.Point(43, 101);
            this.lblTecnicatura.Name = "lblTecnicatura";
            this.lblTecnicatura.Size = new System.Drawing.Size(81, 16);
            this.lblTecnicatura.TabIndex = 6;
            this.lblTecnicatura.Text = "Tecnicatura:";
            // 
            // cboTecnicatura
            // 
            this.cboTecnicatura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTecnicatura.FormattingEnabled = true;
            this.cboTecnicatura.Location = new System.Drawing.Point(130, 97);
            this.cboTecnicatura.Name = "cboTecnicatura";
            this.cboTecnicatura.Size = new System.Drawing.Size(163, 24);
            this.cboTecnicatura.TabIndex = 7;
            // 
            // ClmCantidad
            // 
            this.ClmCantidad.HeaderText = "Cantidad";
            this.ClmCantidad.MinimumWidth = 6;
            this.ClmCantidad.Name = "ClmCantidad";
            this.ClmCantidad.ReadOnly = true;
            this.ClmCantidad.Width = 80;
            // 
            // ClmMateria
            // 
            this.ClmMateria.HeaderText = "Materia";
            this.ClmMateria.MinimumWidth = 6;
            this.ClmMateria.Name = "ClmMateria";
            this.ClmMateria.ReadOnly = true;
            this.ClmMateria.Width = 125;
            // 
            // ClmTurno
            // 
            this.ClmTurno.HeaderText = "Turno";
            this.ClmTurno.MinimumWidth = 6;
            this.ClmTurno.Name = "ClmTurno";
            this.ClmTurno.ReadOnly = true;
            this.ClmTurno.Width = 125;
            // 
            // ClmAnio
            // 
            this.ClmAnio.HeaderText = "Año de cursado";
            this.ClmAnio.MinimumWidth = 6;
            this.ClmAnio.Name = "ClmAnio";
            this.ClmAnio.ReadOnly = true;
            this.ClmAnio.Width = 150;
            // 
            // FrmConsulta4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 419);
            this.Controls.Add(this.cboTecnicatura);
            this.Controls.Add(this.lblTecnicatura);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.cboEstados);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.dgvConsulta);
            this.Controls.Add(this.lblConsulta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmConsulta4";
            this.Text = "Consulta 4";
            this.Load += new System.EventHandler(this.FrmConsulta4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConsulta;
        private System.Windows.Forms.DataGridView dgvConsulta;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cboEstados;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblTecnicatura;
        private System.Windows.Forms.ComboBox cboTecnicatura;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmMateria;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmTurno;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmAnio;
    }
}