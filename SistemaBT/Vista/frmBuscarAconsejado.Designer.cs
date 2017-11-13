namespace Vista
{
    partial class frmBuscarAconsejado
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
            this.dgvAconsejados = new System.Windows.Forms.DataGridView();
            this.btnSeleccionarAconsejado = new System.Windows.Forms.Button();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Especialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ciclo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAconsejados)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAconsejados
            // 
            this.dgvAconsejados.AllowUserToAddRows = false;
            this.dgvAconsejados.AllowUserToDeleteRows = false;
            this.dgvAconsejados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAconsejados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.NombreCompleto,
            this.FechaNacimiento,
            this.Correo,
            this.Especialidad,
            this.Ciclo,
            this.Estado});
            this.dgvAconsejados.Location = new System.Drawing.Point(13, 41);
            this.dgvAconsejados.Name = "dgvAconsejados";
            this.dgvAconsejados.ReadOnly = true;
            this.dgvAconsejados.Size = new System.Drawing.Size(570, 336);
            this.dgvAconsejados.TabIndex = 0;
            // 
            // btnSeleccionarAconsejado
            // 
            this.btnSeleccionarAconsejado.Location = new System.Drawing.Point(508, 12);
            this.btnSeleccionarAconsejado.Name = "btnSeleccionarAconsejado";
            this.btnSeleccionarAconsejado.Size = new System.Drawing.Size(75, 23);
            this.btnSeleccionarAconsejado.TabIndex = 1;
            this.btnSeleccionarAconsejado.Text = "Seleccionar";
            this.btnSeleccionarAconsejado.UseVisualStyleBackColor = true;
            this.btnSeleccionarAconsejado.Click += new System.EventHandler(this.btnSeleccionarAconsejado_Click);
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Codigo";
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // NombreCompleto
            // 
            this.NombreCompleto.DataPropertyName = "NombreCompleto";
            this.NombreCompleto.HeaderText = "Nombre";
            this.NombreCompleto.Name = "NombreCompleto";
            this.NombreCompleto.ReadOnly = true;
            // 
            // FechaNacimiento
            // 
            this.FechaNacimiento.DataPropertyName = "FechaNacimiento";
            this.FechaNacimiento.HeaderText = "Fecha de Nacimiento";
            this.FechaNacimiento.Name = "FechaNacimiento";
            this.FechaNacimiento.ReadOnly = true;
            // 
            // Correo
            // 
            this.Correo.DataPropertyName = "Correo";
            this.Correo.HeaderText = "Correo";
            this.Correo.Name = "Correo";
            this.Correo.ReadOnly = true;
            // 
            // Especialidad
            // 
            this.Especialidad.DataPropertyName = "Especialidad";
            this.Especialidad.HeaderText = "Especialidad";
            this.Especialidad.Name = "Especialidad";
            this.Especialidad.ReadOnly = true;
            // 
            // Ciclo
            // 
            this.Ciclo.DataPropertyName = "Ciclo";
            this.Ciclo.HeaderText = "Ciclo";
            this.Ciclo.Name = "Ciclo";
            this.Ciclo.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // frmBuscarAconsejado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 389);
            this.Controls.Add(this.btnSeleccionarAconsejado);
            this.Controls.Add(this.dgvAconsejados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmBuscarAconsejado";
            this.Text = "Búsqueda de Aconsejados";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAconsejados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAconsejados;
        private System.Windows.Forms.Button btnSeleccionarAconsejado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCompleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Especialidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ciclo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}