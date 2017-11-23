namespace Vista
{
    partial class frmMostrarMatches
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
            this.dgvMatches = new System.Windows.Forms.DataGridView();
            this.idMatch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreConsejero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaAsig = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnFinMatch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatches)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMatches
            // 
            this.dgvMatches.AllowUserToAddRows = false;
            this.dgvMatches.AllowUserToDeleteRows = false;
            this.dgvMatches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatches.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMatch,
            this.nombreConsejero,
            this.fechaAsig,
            this.fechaFin,
            this.estado});
            this.dgvMatches.Location = new System.Drawing.Point(15, 12);
            this.dgvMatches.Name = "dgvMatches";
            this.dgvMatches.ReadOnly = true;
            this.dgvMatches.Size = new System.Drawing.Size(484, 327);
            this.dgvMatches.TabIndex = 3;
            // 
            // idMatch
            // 
            this.idMatch.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idMatch.DataPropertyName = "IdMatch";
            this.idMatch.HeaderText = "ID Match";
            this.idMatch.Name = "idMatch";
            this.idMatch.ReadOnly = true;
            this.idMatch.Width = 70;
            // 
            // nombreConsejero
            // 
            this.nombreConsejero.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nombreConsejero.DataPropertyName = "IdConsejero";
            this.nombreConsejero.HeaderText = "ID del Consejero";
            this.nombreConsejero.Name = "nombreConsejero";
            this.nombreConsejero.ReadOnly = true;
            this.nombreConsejero.Width = 101;
            // 
            // fechaAsig
            // 
            this.fechaAsig.DataPropertyName = "FechaAsignacion";
            this.fechaAsig.HeaderText = "Fecha de Asignación";
            this.fechaAsig.Name = "fechaAsig";
            this.fechaAsig.ReadOnly = true;
            // 
            // fechaFin
            // 
            this.fechaFin.DataPropertyName = "FechaFin";
            this.fechaFin.HeaderText = "Fecha de Fin";
            this.fechaFin.Name = "fechaFin";
            this.fechaFin.ReadOnly = true;
            // 
            // estado
            // 
            this.estado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.estado.DataPropertyName = "Estado";
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            this.estado.Width = 65;
            // 
            // btnFinMatch
            // 
            this.btnFinMatch.Location = new System.Drawing.Point(394, 348);
            this.btnFinMatch.Name = "btnFinMatch";
            this.btnFinMatch.Size = new System.Drawing.Size(105, 23);
            this.btnFinMatch.TabIndex = 4;
            this.btnFinMatch.Text = "Finalizar Match";
            this.btnFinMatch.UseVisualStyleBackColor = true;
            this.btnFinMatch.Click += new System.EventHandler(this.btnFinMatch_Click);
            // 
            // frmMostrarMatches
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 383);
            this.Controls.Add(this.btnFinMatch);
            this.Controls.Add(this.dgvMatches);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmMostrarMatches";
            this.Text = "Mostrar Matches";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatches)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvMatches;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMatch;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreConsejero;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaAsig;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.Button btnFinMatch;
    }
}