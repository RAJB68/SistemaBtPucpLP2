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
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btBuscarConsejero = new System.Windows.Forms.Button();
            this.btBuscarAconsejado = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvActividades = new System.Windows.Forms.DataGridView();
            this.btAgregarActividad = new System.Windows.Forms.Button();
            this.btModificarActividad = new System.Windows.Forms.Button();
            this.btEliminarActividad = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActividades)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(101, 40);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(343, 22);
            this.txtNombre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Código PUCP:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(135, 71);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(309, 22);
            this.txtCodigo.TabIndex = 4;
            // 
            // btBuscarConsejero
            // 
            this.btBuscarConsejero.Location = new System.Drawing.Point(462, 37);
            this.btBuscarConsejero.Name = "btBuscarConsejero";
            this.btBuscarConsejero.Size = new System.Drawing.Size(145, 28);
            this.btBuscarConsejero.TabIndex = 5;
            this.btBuscarConsejero.Text = "Buscar Consejero";
            this.btBuscarConsejero.UseVisualStyleBackColor = true;
            // 
            // btBuscarAconsejado
            // 
            this.btBuscarAconsejado.Location = new System.Drawing.Point(462, 68);
            this.btBuscarAconsejado.Name = "btBuscarAconsejado";
            this.btBuscarAconsejado.Size = new System.Drawing.Size(145, 28);
            this.btBuscarAconsejado.TabIndex = 6;
            this.btBuscarAconsejado.Text = "Buscar Aconsejado";
            this.btBuscarAconsejado.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btEliminarActividad);
            this.groupBox1.Controls.Add(this.btModificarActividad);
            this.groupBox1.Controls.Add(this.btAgregarActividad);
            this.groupBox1.Controls.Add(this.dgvActividades);
            this.groupBox1.Location = new System.Drawing.Point(13, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(621, 374);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Actividades";
            // 
            // dgvActividades
            // 
            this.dgvActividades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActividades.Location = new System.Drawing.Point(7, 22);
            this.dgvActividades.Name = "dgvActividades";
            this.dgvActividades.RowTemplate.Height = 24;
            this.dgvActividades.Size = new System.Drawing.Size(608, 309);
            this.dgvActividades.TabIndex = 0;
            // 
            // btAgregarActividad
            // 
            this.btAgregarActividad.Location = new System.Drawing.Point(7, 338);
            this.btAgregarActividad.Name = "btAgregarActividad";
            this.btAgregarActividad.Size = new System.Drawing.Size(109, 30);
            this.btAgregarActividad.TabIndex = 1;
            this.btAgregarActividad.Text = "Agregar";
            this.btAgregarActividad.UseVisualStyleBackColor = true;
            this.btAgregarActividad.Click += new System.EventHandler(this.btAgregarActividad_Click);
            // 
            // btModificarActividad
            // 
            this.btModificarActividad.Location = new System.Drawing.Point(122, 338);
            this.btModificarActividad.Name = "btModificarActividad";
            this.btModificarActividad.Size = new System.Drawing.Size(112, 30);
            this.btModificarActividad.TabIndex = 2;
            this.btModificarActividad.Text = "Modificar";
            this.btModificarActividad.UseVisualStyleBackColor = true;
            this.btModificarActividad.Click += new System.EventHandler(this.btModificarActividad_Click);
            // 
            // btEliminarActividad
            // 
            this.btEliminarActividad.Location = new System.Drawing.Point(510, 337);
            this.btEliminarActividad.Name = "btEliminarActividad";
            this.btEliminarActividad.Size = new System.Drawing.Size(105, 30);
            this.btEliminarActividad.TabIndex = 3;
            this.btEliminarActividad.Text = "Eliminar";
            this.btEliminarActividad.UseVisualStyleBackColor = true;
            // 
            // frmAdministrarActividades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 518);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btBuscarAconsejado);
            this.Controls.Add(this.btBuscarConsejero);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombre);
            this.Name = "frmAdministrarActividades";
            this.Text = "Administrar Actividades";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvActividades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btBuscarConsejero;
        private System.Windows.Forms.Button btBuscarAconsejado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btEliminarActividad;
        private System.Windows.Forms.Button btModificarActividad;
        private System.Windows.Forms.Button btAgregarActividad;
        private System.Windows.Forms.DataGridView dgvActividades;
    }
}