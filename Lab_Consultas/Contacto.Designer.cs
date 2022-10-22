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
            this.btnEnviar.Location = new System.Drawing.Point(398, 280);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(87, 29);
            this.btnEnviar.TabIndex = 0;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(295, 280);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(87, 29);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // richTxtCuerpo
            // 
            this.richTxtCuerpo.Location = new System.Drawing.Point(112, 155);
            this.richTxtCuerpo.Name = "richTxtCuerpo";
            this.richTxtCuerpo.Size = new System.Drawing.Size(373, 119);
            this.richTxtCuerpo.TabIndex = 2;
            this.richTxtCuerpo.Text = "";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(113, 121);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(372, 22);
            this.txtTitulo.TabIndex = 3;
            // 
            // txtMail
            // 
            this.txtMail.Enabled = false;
            this.txtMail.Location = new System.Drawing.Point(112, 84);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(372, 22);
            this.txtMail.TabIndex = 4;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(63, 124);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(40, 16);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "Titulo";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(8, 87);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(95, 16);
            this.lblMail.TabIndex = 6;
            this.lblMail.Text = "E-mail destino:";
            // 
            // lblCuerpo
            // 
            this.lblCuerpo.AutoSize = true;
            this.lblCuerpo.Location = new System.Drawing.Point(52, 155);
            this.lblCuerpo.Name = "lblCuerpo";
            this.lblCuerpo.Size = new System.Drawing.Size(51, 16);
            this.lblCuerpo.TabIndex = 7;
            this.lblCuerpo.Text = "Cuerpo";
            // 
            // lblEmailP
            // 
            this.lblEmailP.AutoSize = true;
            this.lblEmailP.Location = new System.Drawing.Point(58, 59);
            this.lblEmailP.Name = "lblEmailP";
            this.lblEmailP.Size = new System.Drawing.Size(45, 16);
            this.lblEmailP.TabIndex = 8;
            this.lblEmailP.Text = "E-Mail";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.Location = new System.Drawing.Point(191, 9);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(154, 26);
            this.lblCorreo.TabIndex = 9;
            this.lblCorreo.Text = "Nuevo correo";
            // 
            // txtEmailProp
            // 
            this.txtEmailProp.Enabled = false;
            this.txtEmailProp.Location = new System.Drawing.Point(113, 56);
            this.txtEmailProp.Name = "txtEmailProp";
            this.txtEmailProp.Size = new System.Drawing.Size(372, 22);
            this.txtEmailProp.TabIndex = 10;
            // 
            // Contacto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 319);
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