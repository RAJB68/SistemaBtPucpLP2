namespace Vista
{
    partial class Principal
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
            this.btnAdminConsejeros = new System.Windows.Forms.Button();
            this.btnAdminAconsejados = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdminConsejeros
            // 
            this.btnAdminConsejeros.Location = new System.Drawing.Point(344, 337);
            this.btnAdminConsejeros.Name = "btnAdminConsejeros";
            this.btnAdminConsejeros.Size = new System.Drawing.Size(159, 94);
            this.btnAdminConsejeros.TabIndex = 0;
            this.btnAdminConsejeros.Text = "Administrar Consejeros";
            this.btnAdminConsejeros.UseVisualStyleBackColor = true;
            this.btnAdminConsejeros.Click += new System.EventHandler(this.btnAdminConsejeros_Click);
            // 
            // btnAdminAconsejados
            // 
            this.btnAdminAconsejados.Location = new System.Drawing.Point(719, 346);
            this.btnAdminAconsejados.Name = "btnAdminAconsejados";
            this.btnAdminAconsejados.Size = new System.Drawing.Size(159, 94);
            this.btnAdminAconsejados.TabIndex = 1;
            this.btnAdminAconsejados.Text = "Administrar Aconsejados";
            this.btnAdminAconsejados.UseVisualStyleBackColor = true;
            this.btnAdminAconsejados.Click += new System.EventHandler(this.btnAdminAconsejados_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 940);
            this.Controls.Add(this.btnAdminAconsejados);
            this.Controls.Add(this.btnAdminConsejeros);
            this.Name = "Principal";
            this.Text = "SIstemas De Consejerias - Bolsa de Trabajo PUCP";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdminConsejeros;
        private System.Windows.Forms.Button btnAdminAconsejados;
    }
}

