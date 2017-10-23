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
            ((System.ComponentModel.ISupportInitialize)(this.dgvAconsejados)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAconsejados
            // 
            this.dgvAconsejados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAconsejados.Location = new System.Drawing.Point(13, 66);
            this.dgvAconsejados.Name = "dgvAconsejados";
            this.dgvAconsejados.Size = new System.Drawing.Size(570, 331);
            this.dgvAconsejados.TabIndex = 0;
            // 
            // btnSeleccionarAconsejado
            // 
            this.btnSeleccionarAconsejado.Location = new System.Drawing.Point(507, 37);
            this.btnSeleccionarAconsejado.Name = "btnSeleccionarAconsejado";
            this.btnSeleccionarAconsejado.Size = new System.Drawing.Size(75, 23);
            this.btnSeleccionarAconsejado.TabIndex = 1;
            this.btnSeleccionarAconsejado.Text = "Seleccionar";
            this.btnSeleccionarAconsejado.UseVisualStyleBackColor = true;
            this.btnSeleccionarAconsejado.Click += new System.EventHandler(this.btnSeleccionarAconsejado_Click);
            // 
            // frmBuscarAconsejado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 409);
            this.Controls.Add(this.btnSeleccionarAconsejado);
            this.Controls.Add(this.dgvAconsejados);
            this.Name = "frmBuscarAconsejado";
            this.Text = "Búsqueda de Aconsejados";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAconsejados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAconsejados;
        private System.Windows.Forms.Button btnSeleccionarAconsejado;
    }
}