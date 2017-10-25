namespace Vista
{
    partial class frmBuscarConsejero
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
            this.btnSeleccionarConsejero = new System.Windows.Forms.Button();
            this.dgvConsejeros = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsejeros)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSeleccionarConsejero
            // 
            this.btnSeleccionarConsejero.Location = new System.Drawing.Point(695, 38);
            this.btnSeleccionarConsejero.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSeleccionarConsejero.Name = "btnSeleccionarConsejero";
            this.btnSeleccionarConsejero.Size = new System.Drawing.Size(91, 25);
            this.btnSeleccionarConsejero.TabIndex = 0;
            this.btnSeleccionarConsejero.Text = "Seleccionar";
            this.btnSeleccionarConsejero.UseVisualStyleBackColor = true;
            this.btnSeleccionarConsejero.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvConsejeros
            // 
            this.dgvConsejeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsejeros.Location = new System.Drawing.Point(65, 116);
            this.dgvConsejeros.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvConsejeros.Name = "dgvConsejeros";
            this.dgvConsejeros.RowTemplate.Height = 33;
            this.dgvConsejeros.Size = new System.Drawing.Size(732, 374);
            this.dgvConsejeros.TabIndex = 1;
            // 
            // frmBuscarConsejero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 590);
            this.Controls.Add(this.dgvConsejeros);
            this.Controls.Add(this.btnSeleccionarConsejero);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmBuscarConsejero";
            this.Text = "Buscar Consejero";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsejeros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSeleccionarConsejero;
        private System.Windows.Forms.DataGridView dgvConsejeros;
    }
}