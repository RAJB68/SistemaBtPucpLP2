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
            this.button1 = new System.Windows.Forms.Button();
            this.dgvConsejeros = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsejeros)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1043, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 39);
            this.button1.TabIndex = 0;
            this.button1.Text = "Seleccionar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dgvConsejeros
            // 
            this.dgvConsejeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsejeros.Location = new System.Drawing.Point(97, 181);
            this.dgvConsejeros.Name = "dgvConsejeros";
            this.dgvConsejeros.RowTemplate.Height = 33;
            this.dgvConsejeros.Size = new System.Drawing.Size(1098, 585);
            this.dgvConsejeros.TabIndex = 1;
            // 
            // frmBuscarConsejero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 922);
            this.Controls.Add(this.dgvConsejeros);
            this.Controls.Add(this.button1);
            this.Name = "frmBuscarConsejero";
            this.Text = "Buscar Consejero";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsejeros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvConsejeros;
    }
}