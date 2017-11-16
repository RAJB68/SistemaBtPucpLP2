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
            this.cmbAconsejados = new System.Windows.Forms.ComboBox();
            this.lblNombreAconsejado = new System.Windows.Forms.Label();
            this.btnBuscarMatches = new System.Windows.Forms.Button();
            this.dgvMatches = new System.Windows.Forms.DataGridView();
            this.idMatch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreConsejero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaAsig = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatches)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbAconsejados
            // 
            this.cmbAconsejados.FormattingEnabled = true;
            this.cmbAconsejados.Location = new System.Drawing.Point(141, 25);
            this.cmbAconsejados.Name = "cmbAconsejados";
            this.cmbAconsejados.Size = new System.Drawing.Size(284, 21);
            this.cmbAconsejados.TabIndex = 0;
            // 
            // lblNombreAconsejado
            // 
            this.lblNombreAconsejado.AutoSize = true;
            this.lblNombreAconsejado.Location = new System.Drawing.Point(12, 28);
            this.lblNombreAconsejado.Name = "lblNombreAconsejado";
            this.lblNombreAconsejado.Size = new System.Drawing.Size(123, 13);
            this.lblNombreAconsejado.TabIndex = 1;
            this.lblNombreAconsejado.Text = "Nombre del Aconsejado:";
            // 
            // btnBuscarMatches
            // 
            this.btnBuscarMatches.Location = new System.Drawing.Point(471, 23);
            this.btnBuscarMatches.Name = "btnBuscarMatches";
            this.btnBuscarMatches.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarMatches.TabIndex = 2;
            this.btnBuscarMatches.Text = "Buscar";
            this.btnBuscarMatches.UseVisualStyleBackColor = true;
            this.btnBuscarMatches.Click += new System.EventHandler(this.btnBuscarMatches_Click);
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
            this.dgvMatches.Location = new System.Drawing.Point(15, 64);
            this.dgvMatches.Name = "dgvMatches";
            this.dgvMatches.ReadOnly = true;
            this.dgvMatches.Size = new System.Drawing.Size(531, 275);
            this.dgvMatches.TabIndex = 3;
            // 
            // idMatch
            // 
            this.idMatch.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idMatch.DataPropertyName = "IdMatch";
            this.idMatch.HeaderText = "ID Match";
            this.idMatch.Name = "idMatch";
            this.idMatch.ReadOnly = true;
            this.idMatch.Width = 76;
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
            // frmMostrarMatches
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 351);
            this.Controls.Add(this.dgvMatches);
            this.Controls.Add(this.btnBuscarMatches);
            this.Controls.Add(this.lblNombreAconsejado);
            this.Controls.Add(this.cmbAconsejados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmMostrarMatches";
            this.Text = "frmMostrarMatches";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatches)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbAconsejados;
        private System.Windows.Forms.Label lblNombreAconsejado;
        private System.Windows.Forms.Button btnBuscarMatches;
        private System.Windows.Forms.DataGridView dgvMatches;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMatch;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreConsejero;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaAsig;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
    }
}