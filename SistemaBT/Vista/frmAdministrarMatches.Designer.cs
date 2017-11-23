namespace Vista
{
    partial class frmAdministrarMatches
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblBuscarConsejero = new System.Windows.Forms.Label();
            this.txtBuscarConsejero = new System.Windows.Forms.TextBox();
            this.lblPorConsejero = new System.Windows.Forms.Label();
            this.cmbBuscarConsejero = new System.Windows.Forms.ComboBox();
            this.cmbBuscarAconsejado = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscarAconsejado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvConsejeros = new System.Windows.Forms.DataGridView();
            this.dgvAconsejados = new System.Windows.Forms.DataGridView();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.btnCrearMatch = new System.Windows.Forms.Button();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.lblFechaFin = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.IdConsejero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdAconsejado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreCompletoAconsejado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsejeros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAconsejados)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.listadoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(889, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // listadoToolStripMenuItem
            // 
            this.listadoToolStripMenuItem.Name = "listadoToolStripMenuItem";
            this.listadoToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.listadoToolStripMenuItem.Text = "Listado";
            this.listadoToolStripMenuItem.Click += new System.EventHandler(this.listadoToolStripMenuItem_Click);
            // 
            // lblBuscarConsejero
            // 
            this.lblBuscarConsejero.AutoSize = true;
            this.lblBuscarConsejero.Location = new System.Drawing.Point(13, 40);
            this.lblBuscarConsejero.Name = "lblBuscarConsejero";
            this.lblBuscarConsejero.Size = new System.Drawing.Size(43, 13);
            this.lblBuscarConsejero.TabIndex = 1;
            this.lblBuscarConsejero.Text = "Buscar:";
            // 
            // txtBuscarConsejero
            // 
            this.txtBuscarConsejero.Location = new System.Drawing.Point(62, 37);
            this.txtBuscarConsejero.Name = "txtBuscarConsejero";
            this.txtBuscarConsejero.Size = new System.Drawing.Size(145, 20);
            this.txtBuscarConsejero.TabIndex = 2;
            this.txtBuscarConsejero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscarConsejero_KeyPress);
            // 
            // lblPorConsejero
            // 
            this.lblPorConsejero.AutoSize = true;
            this.lblPorConsejero.Location = new System.Drawing.Point(213, 40);
            this.lblPorConsejero.Name = "lblPorConsejero";
            this.lblPorConsejero.Size = new System.Drawing.Size(22, 13);
            this.lblPorConsejero.TabIndex = 3;
            this.lblPorConsejero.Text = "por";
            // 
            // cmbBuscarConsejero
            // 
            this.cmbBuscarConsejero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBuscarConsejero.FormattingEnabled = true;
            this.cmbBuscarConsejero.Items.AddRange(new object[] {
            "ID",
            "Nombre"});
            this.cmbBuscarConsejero.Location = new System.Drawing.Point(241, 37);
            this.cmbBuscarConsejero.Name = "cmbBuscarConsejero";
            this.cmbBuscarConsejero.Size = new System.Drawing.Size(103, 21);
            this.cmbBuscarConsejero.TabIndex = 4;
            // 
            // cmbBuscarAconsejado
            // 
            this.cmbBuscarAconsejado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBuscarAconsejado.FormattingEnabled = true;
            this.cmbBuscarAconsejado.Items.AddRange(new object[] {
            "ID",
            "Nombre"});
            this.cmbBuscarAconsejado.Location = new System.Drawing.Point(774, 37);
            this.cmbBuscarAconsejado.Name = "cmbBuscarAconsejado";
            this.cmbBuscarAconsejado.Size = new System.Drawing.Size(103, 21);
            this.cmbBuscarAconsejado.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(746, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "por";
            // 
            // txtBuscarAconsejado
            // 
            this.txtBuscarAconsejado.Location = new System.Drawing.Point(595, 37);
            this.txtBuscarAconsejado.Name = "txtBuscarAconsejado";
            this.txtBuscarAconsejado.Size = new System.Drawing.Size(145, 20);
            this.txtBuscarAconsejado.TabIndex = 6;
            this.txtBuscarAconsejado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscarAconsejado_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(546, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Buscar:";
            // 
            // dgvConsejeros
            // 
            this.dgvConsejeros.AllowUserToAddRows = false;
            this.dgvConsejeros.AllowUserToDeleteRows = false;
            this.dgvConsejeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsejeros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdConsejero,
            this.NombreCompleto});
            this.dgvConsejeros.Location = new System.Drawing.Point(16, 64);
            this.dgvConsejeros.Name = "dgvConsejeros";
            this.dgvConsejeros.ReadOnly = true;
            this.dgvConsejeros.Size = new System.Drawing.Size(328, 328);
            this.dgvConsejeros.TabIndex = 9;
            // 
            // dgvAconsejados
            // 
            this.dgvAconsejados.AllowUserToAddRows = false;
            this.dgvAconsejados.AllowUserToDeleteRows = false;
            this.dgvAconsejados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAconsejados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdAconsejado,
            this.nombreCompletoAconsejado});
            this.dgvAconsejados.Location = new System.Drawing.Point(549, 64);
            this.dgvAconsejados.Name = "dgvAconsejados";
            this.dgvAconsejados.ReadOnly = true;
            this.dgvAconsejados.Size = new System.Drawing.Size(328, 328);
            this.dgvAconsejados.TabIndex = 10;
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Enabled = false;
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicio.Location = new System.Drawing.Point(411, 107);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(73, 20);
            this.dtpFechaInicio.TabIndex = 11;
            // 
            // btnCrearMatch
            // 
            this.btnCrearMatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnCrearMatch.Location = new System.Drawing.Point(391, 169);
            this.btnCrearMatch.Name = "btnCrearMatch";
            this.btnCrearMatch.Size = new System.Drawing.Size(110, 50);
            this.btnCrearMatch.TabIndex = 12;
            this.btnCrearMatch.Text = "MATCH";
            this.btnCrearMatch.UseVisualStyleBackColor = true;
            this.btnCrearMatch.Click += new System.EventHandler(this.btnCrearMatch_Click);
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFin.Location = new System.Drawing.Point(411, 268);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(73, 20);
            this.dtpFechaFin.TabIndex = 13;
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Location = new System.Drawing.Point(407, 91);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(80, 13);
            this.lblFechaInicio.TabIndex = 14;
            this.lblFechaInicio.Text = "Fecha de Inicio";
            // 
            // lblFechaFin
            // 
            this.lblFechaFin.AutoSize = true;
            this.lblFechaFin.Location = new System.Drawing.Point(413, 291);
            this.lblFechaFin.Name = "lblFechaFin";
            this.lblFechaFin.Size = new System.Drawing.Size(69, 13);
            this.lblFechaFin.TabIndex = 15;
            this.lblFechaFin.Text = "Fecha de Fin";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(411, 369);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // IdConsejero
            // 
            this.IdConsejero.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.IdConsejero.DataPropertyName = "Codigo";
            this.IdConsejero.HeaderText = "ID del Consejero";
            this.IdConsejero.Name = "IdConsejero";
            this.IdConsejero.ReadOnly = true;
            this.IdConsejero.Width = 101;
            // 
            // NombreCompleto
            // 
            this.NombreCompleto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.NombreCompleto.DataPropertyName = "NombreCompleto";
            this.NombreCompleto.HeaderText = "Nombre del Consejero";
            this.NombreCompleto.Name = "NombreCompleto";
            this.NombreCompleto.ReadOnly = true;
            this.NombreCompleto.Width = 5;
            // 
            // IdAconsejado
            // 
            this.IdAconsejado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.IdAconsejado.DataPropertyName = "Codigo";
            this.IdAconsejado.HeaderText = "ID del Aconsejado";
            this.IdAconsejado.Name = "IdAconsejado";
            this.IdAconsejado.ReadOnly = true;
            this.IdAconsejado.Width = 109;
            // 
            // nombreCompletoAconsejado
            // 
            this.nombreCompletoAconsejado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.nombreCompletoAconsejado.DataPropertyName = "NombreCompleto";
            this.nombreCompletoAconsejado.HeaderText = "Nombre del Aconsejado";
            this.nombreCompletoAconsejado.Name = "nombreCompletoAconsejado";
            this.nombreCompletoAconsejado.ReadOnly = true;
            this.nombreCompletoAconsejado.Width = 5;
            // 
            // frmAdministrarMatches
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 404);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblFechaFin);
            this.Controls.Add(this.lblFechaInicio);
            this.Controls.Add(this.dtpFechaFin);
            this.Controls.Add(this.btnCrearMatch);
            this.Controls.Add(this.dtpFechaInicio);
            this.Controls.Add(this.dgvAconsejados);
            this.Controls.Add(this.dgvConsejeros);
            this.Controls.Add(this.cmbBuscarAconsejado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBuscarAconsejado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbBuscarConsejero);
            this.Controls.Add(this.lblPorConsejero);
            this.Controls.Add(this.txtBuscarConsejero);
            this.Controls.Add(this.lblBuscarConsejero);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmAdministrarMatches";
            this.Text = "Administración de Matches";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsejeros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAconsejados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoToolStripMenuItem;
        private System.Windows.Forms.Label lblBuscarConsejero;
        private System.Windows.Forms.TextBox txtBuscarConsejero;
        private System.Windows.Forms.Label lblPorConsejero;
        private System.Windows.Forms.ComboBox cmbBuscarConsejero;
        private System.Windows.Forms.ComboBox cmbBuscarAconsejado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscarAconsejado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvConsejeros;
        private System.Windows.Forms.DataGridView dgvAconsejados;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.Button btnCrearMatch;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.Label lblFechaFin;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdConsejero;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCompleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdAconsejado;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCompletoAconsejado;
    }
}