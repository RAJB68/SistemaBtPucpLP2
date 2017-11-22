namespace Vista
{
    partial class frmAdministrarActividades
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btBuscarConsejero = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btEliminarActividad = new System.Windows.Forms.Button();
            this.btModificarActividad = new System.Windows.Forms.Button();
            this.btAgregarActividad = new System.Windows.Forms.Button();
            this.dgvActividades = new System.Windows.Forms.DataGridView();
            this.btActualizar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaProgramada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActividades)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(74, 28);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(375, 22);
            this.txtNombre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre:";
            // 
            // btBuscarConsejero
            // 
            this.btBuscarConsejero.Location = new System.Drawing.Point(468, 25);
            this.btBuscarConsejero.Name = "btBuscarConsejero";
            this.btBuscarConsejero.Size = new System.Drawing.Size(145, 28);
            this.btBuscarConsejero.TabIndex = 5;
            this.btBuscarConsejero.Text = "Buscar";
            this.btBuscarConsejero.UseVisualStyleBackColor = true;
            this.btBuscarConsejero.Click += new System.EventHandler(this.btBuscarConsejero_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btEliminarActividad);
            this.groupBox1.Controls.Add(this.btModificarActividad);
            this.groupBox1.Controls.Add(this.btAgregarActividad);
            this.groupBox1.Controls.Add(this.dgvActividades);
            this.groupBox1.Location = new System.Drawing.Point(13, 171);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(621, 690);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Actividades";
            // 
            // btEliminarActividad
            // 
            this.btEliminarActividad.Location = new System.Drawing.Point(508, 653);
            this.btEliminarActividad.Name = "btEliminarActividad";
            this.btEliminarActividad.Size = new System.Drawing.Size(105, 30);
            this.btEliminarActividad.TabIndex = 3;
            this.btEliminarActividad.Text = "Eliminar";
            this.btEliminarActividad.UseVisualStyleBackColor = true;
            this.btEliminarActividad.Click += new System.EventHandler(this.btEliminarActividad_Click);
            // 
            // btModificarActividad
            // 
            this.btModificarActividad.Location = new System.Drawing.Point(120, 654);
            this.btModificarActividad.Name = "btModificarActividad";
            this.btModificarActividad.Size = new System.Drawing.Size(112, 30);
            this.btModificarActividad.TabIndex = 2;
            this.btModificarActividad.Text = "Modificar";
            this.btModificarActividad.UseVisualStyleBackColor = true;
            this.btModificarActividad.Click += new System.EventHandler(this.btModificarActividad_Click);
            // 
            // btAgregarActividad
            // 
            this.btAgregarActividad.Location = new System.Drawing.Point(5, 654);
            this.btAgregarActividad.Name = "btAgregarActividad";
            this.btAgregarActividad.Size = new System.Drawing.Size(109, 30);
            this.btAgregarActividad.TabIndex = 1;
            this.btAgregarActividad.Text = "Agregar";
            this.btAgregarActividad.UseVisualStyleBackColor = true;
            this.btAgregarActividad.Click += new System.EventHandler(this.btAgregarActividad_Click);
            // 
            // dgvActividades
            // 
            this.dgvActividades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActividades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Titulo,
            this.Descripcion,
            this.FechaProgramada});
            this.dgvActividades.Location = new System.Drawing.Point(7, 22);
            this.dgvActividades.Name = "dgvActividades";
            this.dgvActividades.ReadOnly = true;
            this.dgvActividades.RowTemplate.Height = 24;
            this.dgvActividades.Size = new System.Drawing.Size(608, 625);
            this.dgvActividades.TabIndex = 0;
            // 
            // btActualizar
            // 
            this.btActualizar.Location = new System.Drawing.Point(482, 137);
            this.btActualizar.Name = "btActualizar";
            this.btActualizar.Size = new System.Drawing.Size(144, 28);
            this.btActualizar.TabIndex = 8;
            this.btActualizar.Text = "Actualizar Tabla";
            this.btActualizar.UseVisualStyleBackColor = true;
            this.btActualizar.Click += new System.EventHandler(this.btActualizar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtNombre);
            this.groupBox2.Controls.Add(this.btBuscarConsejero);
            this.groupBox2.Location = new System.Drawing.Point(13, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(621, 74);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscar Consejero";
            // 
            // Titulo
            // 
            this.Titulo.DataPropertyName = "Titulo";
            this.Titulo.HeaderText = "Titulo";
            this.Titulo.MinimumWidth = 180;
            this.Titulo.Name = "Titulo";
            this.Titulo.ReadOnly = true;
            this.Titulo.Width = 180;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.MinimumWidth = 150;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 150;
            // 
            // FechaProgramada
            // 
            this.FechaProgramada.DataPropertyName = "FechaProgramada";
            this.FechaProgramada.HeaderText = "Fecha Programada";
            this.FechaProgramada.MinimumWidth = 90;
            this.FechaProgramada.Name = "FechaProgramada";
            this.FechaProgramada.ReadOnly = true;
            this.FechaProgramada.Width = 90;
            // 
            // frmAdministrarActividades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(646, 873);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btActualizar);
            this.Controls.Add(this.groupBox1);
            this.Location = new System.Drawing.Point(160, 0);
            this.Name = "frmAdministrarActividades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Administrar Actividades";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvActividades)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btBuscarConsejero;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btEliminarActividad;
        private System.Windows.Forms.Button btModificarActividad;
        private System.Windows.Forms.Button btAgregarActividad;
        private System.Windows.Forms.DataGridView dgvActividades;
        private System.Windows.Forms.Button btActualizar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaProgramada;
    }
}