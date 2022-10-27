namespace Lab_Consultas
{
    partial class Contacto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Contacto));
            this.btnEnviar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.richTxtCuerpo = new System.Windows.Forms.RichTextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblCuerpo = new System.Windows.Forms.Label();
            this.lblEmailP = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.txtEmailProp = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEnviar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnEnviar.Location = new System.Drawing.Point(300, 228);
            this.btnEnviar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(65, 24);
            this.btnEnviar.TabIndex = 0;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Red;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCancelar.Location = new System.Drawing.Point(221, 228);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(65, 24);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // richTxtCuerpo
            // 
            this.richTxtCuerpo.Location = new System.Drawing.Point(84, 126);
            this.richTxtCuerpo.Margin = new System.Windows.Forms.Padding(2);
            this.richTxtCuerpo.Name = "richTxtCuerpo";
            this.richTxtCuerpo.Size = new System.Drawing.Size(281, 97);
            this.richTxtCuerpo.TabIndex = 2;
            this.richTxtCuerpo.Text = "";
            // 
            // txtTitulo
            // 
            this.txtTitulo.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTitulo.ForeColor = System.Drawing.SystemColors.Window;
            this.txtTitulo.Location = new System.Drawing.Point(84, 98);
            this.txtTitulo.Margin = new System.Windows.Forms.Padding(2);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(281, 20);
            this.txtTitulo.TabIndex = 3;
            // 
            // txtMail
            // 
            this.txtMail.Enabled = false;
            this.txtMail.Location = new System.Drawing.Point(84, 70);
            this.txtMail.Margin = new System.Windows.Forms.Padding(2);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(281, 20);
            this.txtMail.TabIndex = 4;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(45, 102);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(35, 13);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "Título";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(5, 74);
            this.lblMail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(75, 13);
            this.lblMail.TabIndex = 6;
            this.lblMail.Text = "E-mail destino:";
            // 
            // lblCuerpo
            // 
            this.lblCuerpo.AutoSize = true;
            this.lblCuerpo.Location = new System.Drawing.Point(39, 126);
            this.lblCuerpo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCuerpo.Name = "lblCuerpo";
            this.lblCuerpo.Size = new System.Drawing.Size(41, 13);
            this.lblCuerpo.TabIndex = 7;
            this.lblCuerpo.Text = "Cuerpo";
            // 
            // lblEmailP
            // 
            this.lblEmailP.AutoSize = true;
            this.lblEmailP.Location = new System.Drawing.Point(44, 50);
            this.lblEmailP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmailP.Name = "lblEmailP";
            this.lblEmailP.Size = new System.Drawing.Size(36, 13);
            this.lblEmailP.TabIndex = 8;
            this.lblEmailP.Text = "E-Mail";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblCorreo.Location = new System.Drawing.Point(133, 9);
            this.lblCorreo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(138, 24);
            this.lblCorreo.TabIndex = 9;
            this.lblCorreo.Text = "Nuevo correo";
            // 
            // txtEmailProp
            // 
            this.txtEmailProp.Enabled = false;
            this.txtEmailProp.Location = new System.Drawing.Point(84, 46);
            this.txtEmailProp.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmailProp.Name = "txtEmailProp";
            this.txtEmailProp.Size = new System.Drawing.Size(281, 20);
            this.txtEmailProp.TabIndex = 10;
            // 
            // Contacto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(392, 259);
            this.Controls.Add(this.txtEmailProp);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.lblEmailP);
            this.Controls.Add(this.lblCuerpo);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.richTxtCuerpo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEnviar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Contacto";
            this.Text = "Contactar";
            this.Load += new System.EventHandler(this.ContactoProfesor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.RichTextBox richTxtCuerpo;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblCuerpo;
        private System.Windows.Forms.Label lblEmailP;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TextBox txtEmailProp;
    }
}