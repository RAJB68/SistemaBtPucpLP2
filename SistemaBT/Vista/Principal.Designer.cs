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
            this.btAdminActividades = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdminConsejeros
            // 
            this.btnAdminConsejeros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminConsejeros.Location = new System.Drawing.Point(208, 404);
            this.btnAdminConsejeros.Name = "btnAdminConsejeros";
            this.btnAdminConsejeros.Size = new System.Drawing.Size(222, 134);
            this.btnAdminConsejeros.TabIndex = 0;
            this.btnAdminConsejeros.Text = "Administrar Consejeros";
            this.btnAdminConsejeros.UseVisualStyleBackColor = true;
            this.btnAdminConsejeros.Click += new System.EventHandler(this.btnAdminConsejeros_Click);
            // 
            // btnAdminAconsejados
            // 
            this.btnAdminAconsejados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminAconsejados.Location = new System.Drawing.Point(687, 403);
            this.btnAdminAconsejados.Name = "btnAdminAconsejados";
            this.btnAdminAconsejados.Size = new System.Drawing.Size(264, 137);
            this.btnAdminAconsejados.TabIndex = 1;
            this.btnAdminAconsejados.Text = "Administrar Aconsejados";
            this.btnAdminAconsejados.UseVisualStyleBackColor = true;
            this.btnAdminAconsejados.Click += new System.EventHandler(this.btnAdminAconsejados_Click);
            // 
            // btAdminActividades
            // 
            this.btAdminActividades.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdminActividades.Location = new System.Drawing.Point(457, 404);
            this.btAdminActividades.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btAdminActividades.Name = "btAdminActividades";
            this.btAdminActividades.Size = new System.Drawing.Size(205, 134);
            this.btAdminActividades.TabIndex = 2;
            this.btAdminActividades.Text = "Administrar Actividades";
            this.btAdminActividades.UseVisualStyleBackColor = true;
            this.btAdminActividades.Click += new System.EventHandler(this.btAdminActividades_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(213, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(415, 42);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bolsa de Trabajo PUCP";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 941);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btAdminActividades);
            this.Controls.Add(this.btnAdminAconsejados);
            this.Controls.Add(this.btnAdminConsejeros);
            this.Name = "Principal";
            this.Text = "SIstemas De Consejerias - Bolsa de Trabajo PUCP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdminConsejeros;
        private System.Windows.Forms.Button btnAdminAconsejados;
        private System.Windows.Forms.Button btAdminActividades;
        private System.Windows.Forms.Label label1;
    }
}

