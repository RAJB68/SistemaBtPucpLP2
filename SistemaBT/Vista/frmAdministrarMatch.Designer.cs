namespace Vista
{
    partial class frmAdministrarMatch
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idConsejero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreConsejero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idAconsejado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreCompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCrearMatch = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.lblFechaFin = new System.Windows.Forms.Label();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.lblBuscar1 = new System.Windows.Forms.Label();
            this.lblBuscar2 = new System.Windows.Forms.Label();
            this.txtBuscarConsejero = new System.Windows.Forms.TextBox();
            this.txtBuscarAconsejado = new System.Windows.Forms.TextBox();
            this.lblPor1 = new System.Windows.Forms.Label();
            this.cmbBuscarConsejero = new System.Windows.Forms.ComboBox();
            this.cmbBuscarAconsejado = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idConsejero,
            this.NombreConsejero});
            this.dataGridView1.Location = new System.Drawing.Point(12, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(280, 266);
            this.dataGridView1.TabIndex = 0;
            // 
            // idConsejero
            // 
            this.idConsejero.DataPropertyName = "IdConsejero";
            this.idConsejero.HeaderText = "ID de Consejero";
            this.idConsejero.Name = "idConsejero";
            this.idConsejero.ReadOnly = true;
            // 
            // NombreConsejero
            // 
            this.NombreConsejero.DataPropertyName = "NombreCompleto";
            this.NombreConsejero.HeaderText = "Nombre del Consejero";
            this.NombreConsejero.Name = "NombreConsejero";
            this.NombreConsejero.ReadOnly = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idAconsejado,
            this.nombreCompleto});
            this.dataGridView2.Location = new System.Drawing.Point(487, 61);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(280, 266);
            this.dataGridView2.TabIndex = 1;
            // 
            // idAconsejado
            // 
            this.idAconsejado.DataPropertyName = "IdAconsejado";
            this.idAconsejado.HeaderText = "ID del Aconsejado";
            this.idAconsejado.Name = "idAconsejado";
            this.idAconsejado.ReadOnly = true;
            // 
            // nombreCompleto
            // 
            this.nombreCompleto.DataPropertyName = "NombreCompleto";
            this.nombreCompleto.HeaderText = "Nombre del Aconsejado";
            this.nombreCompleto.Name = "nombreCompleto";
            this.nombreCompleto.ReadOnly = true;
            // 
            // btnCrearMatch
            // 
            this.btnCrearMatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnCrearMatch.Location = new System.Drawing.Point(329, 128);
            this.btnCrearMatch.Name = "btnCrearMatch";
            this.btnCrearMatch.Size = new System.Drawing.Size(124, 48);
            this.btnCrearMatch.TabIndex = 2;
            this.btnCrearMatch.Text = "Match";
            this.btnCrearMatch.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.listadoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(779, 24);
            this.menuStrip1.TabIndex = 3;
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
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Enabled = false;
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicio.Location = new System.Drawing.Point(348, 77);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(88, 20);
            this.dtpFechaInicio.TabIndex = 4;
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Location = new System.Drawing.Point(352, 61);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(80, 13);
            this.lblFechaInicio.TabIndex = 5;
            this.lblFechaInicio.Text = "Fecha de Inicio";
            // 
            // lblFechaFin
            // 
            this.lblFechaFin.AutoSize = true;
            this.lblFechaFin.Location = new System.Drawing.Point(357, 206);
            this.lblFechaFin.Name = "lblFechaFin";
            this.lblFechaFin.Size = new System.Drawing.Size(69, 13);
            this.lblFechaFin.TabIndex = 6;
            this.lblFechaFin.Text = "Fecha de Fin";
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFin.Location = new System.Drawing.Point(348, 222);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(88, 20);
            this.dtpFechaFin.TabIndex = 7;
            // 
            // lblBuscar1
            // 
            this.lblBuscar1.AutoSize = true;
            this.lblBuscar1.Location = new System.Drawing.Point(12, 37);
            this.lblBuscar1.Name = "lblBuscar1";
            this.lblBuscar1.Size = new System.Drawing.Size(43, 13);
            this.lblBuscar1.TabIndex = 8;
            this.lblBuscar1.Text = "Buscar:";
            // 
            // lblBuscar2
            // 
            this.lblBuscar2.AutoSize = true;
            this.lblBuscar2.Location = new System.Drawing.Point(490, 37);
            this.lblBuscar2.Name = "lblBuscar2";
            this.lblBuscar2.Size = new System.Drawing.Size(43, 13);
            this.lblBuscar2.TabIndex = 9;
            this.lblBuscar2.Text = "Buscar:";
            // 
            // txtBuscarConsejero
            // 
            this.txtBuscarConsejero.Location = new System.Drawing.Point(61, 34);
            this.txtBuscarConsejero.Name = "txtBuscarConsejero";
            this.txtBuscarConsejero.Size = new System.Drawing.Size(113, 20);
            this.txtBuscarConsejero.TabIndex = 10;
            this.txtBuscarConsejero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscarConsejero_KeyPress);
            // 
            // txtBuscarAconsejado
            // 
            this.txtBuscarAconsejado.Location = new System.Drawing.Point(539, 34);
            this.txtBuscarAconsejado.Name = "txtBuscarAconsejado";
            this.txtBuscarAconsejado.Size = new System.Drawing.Size(113, 20);
            this.txtBuscarAconsejado.TabIndex = 11;
            // 
            // lblPor1
            // 
            this.lblPor1.AutoSize = true;
            this.lblPor1.Location = new System.Drawing.Point(180, 37);
            this.lblPor1.Name = "lblPor1";
            this.lblPor1.Size = new System.Drawing.Size(22, 13);
            this.lblPor1.TabIndex = 12;
            this.lblPor1.Text = "por";
            // 
            // cmbBuscarConsejero
            // 
            this.cmbBuscarConsejero.FormattingEnabled = true;
            this.cmbBuscarConsejero.Items.AddRange(new object[] {
            "ID",
            "Nombre"});
            this.cmbBuscarConsejero.Location = new System.Drawing.Point(208, 34);
            this.cmbBuscarConsejero.Name = "cmbBuscarConsejero";
            this.cmbBuscarConsejero.Size = new System.Drawing.Size(84, 21);
            this.cmbBuscarConsejero.TabIndex = 13;
            // 
            // cmbBuscarAconsejado
            // 
            this.cmbBuscarAconsejado.FormattingEnabled = true;
            this.cmbBuscarAconsejado.Items.AddRange(new object[] {
            "ID",
            "Nombre"});
            this.cmbBuscarAconsejado.Location = new System.Drawing.Point(683, 34);
            this.cmbBuscarAconsejado.Name = "cmbBuscarAconsejado";
            this.cmbBuscarAconsejado.Size = new System.Drawing.Size(84, 21);
            this.cmbBuscarAconsejado.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(656, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "por";
            // 
            // frmAdministrarMatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 339);
            this.Controls.Add(this.cmbBuscarAconsejado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbBuscarConsejero);
            this.Controls.Add(this.lblPor1);
            this.Controls.Add(this.txtBuscarAconsejado);
            this.Controls.Add(this.txtBuscarConsejero);
            this.Controls.Add(this.lblBuscar2);
            this.Controls.Add(this.lblBuscar1);
            this.Controls.Add(this.dtpFechaFin);
            this.Controls.Add(this.lblFechaFin);
            this.Controls.Add(this.lblFechaInicio);
            this.Controls.Add(this.dtpFechaInicio);
            this.Controls.Add(this.btnCrearMatch);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmAdministrarMatch";
            this.Text = "frmAdministrarMatch";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idConsejero;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreConsejero;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAconsejado;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCompleto;
        private System.Windows.Forms.Button btnCrearMatch;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.Label lblFechaFin;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.Label lblBuscar1;
        private System.Windows.Forms.Label lblBuscar2;
        private System.Windows.Forms.TextBox txtBuscarConsejero;
        private System.Windows.Forms.TextBox txtBuscarAconsejado;
        private System.Windows.Forms.Label lblPor1;
        private System.Windows.Forms.ComboBox cmbBuscarConsejero;
        private System.Windows.Forms.ComboBox cmbBuscarAconsejado;
        private System.Windows.Forms.Label label1;
    }
}