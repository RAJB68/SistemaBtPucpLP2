namespace Vista
{
    partial class frmAdministrarAconsejados
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
            this.menuAconsejadosPrincipal = new System.Windows.Forms.MenuStrip();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vincularToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actividadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpPersonal = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtNumeroTelefono = new System.Windows.Forms.TextBox();
            this.lblNumeroTelefono = new System.Windows.Forms.Label();
            this.ftpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.txtNombreCompleto = new System.Windows.Forms.TextBox();
            this.lblNombreCompleto = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.grpPerfilUniversitario = new System.Windows.Forms.GroupBox();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.lblNumeroCiclo = new System.Windows.Forms.Label();
            this.numUDCiclo = new System.Windows.Forms.NumericUpDown();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblEspecialidad = new System.Windows.Forms.Label();
            this.lblCodigoAlumno = new System.Windows.Forms.Label();
            this.txtCodAlumno = new System.Windows.Forms.TextBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.txtEspecialidad = new System.Windows.Forms.TextBox();
            this.menuAconsejadosPrincipal.SuspendLayout();
            this.grpPersonal.SuspendLayout();
            this.grpPerfilUniversitario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDCiclo)).BeginInit();
            this.SuspendLayout();
            // 
            // menuAconsejadosPrincipal
            // 
            this.menuAconsejadosPrincipal.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuAconsejadosPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.modificarToolStripMenuItem,
            this.vincularToolStripMenuItem,
            this.actividadToolStripMenuItem});
            this.menuAconsejadosPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuAconsejadosPrincipal.Name = "menuAconsejadosPrincipal";
            this.menuAconsejadosPrincipal.Size = new System.Drawing.Size(554, 24);
            this.menuAconsejadosPrincipal.TabIndex = 0;
            this.menuAconsejadosPrincipal.Text = "menuStrip1";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.modificarToolStripMenuItem.Text = "Modificar";
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.modificarToolStripMenuItem_Click);
            // 
            // vincularToolStripMenuItem
            // 
            this.vincularToolStripMenuItem.Name = "vincularToolStripMenuItem";
            this.vincularToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.vincularToolStripMenuItem.Text = "Vincular";
            this.vincularToolStripMenuItem.Click += new System.EventHandler(this.vincularToolStripMenuItem_Click);
            // 
            // actividadToolStripMenuItem
            // 
            this.actividadToolStripMenuItem.Name = "actividadToolStripMenuItem";
            this.actividadToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.actividadToolStripMenuItem.Text = "Actividad";
            this.actividadToolStripMenuItem.Click += new System.EventHandler(this.actividadToolStripMenuItem_Click);
            // 
            // grpPersonal
            // 
            this.grpPersonal.AutoSize = true;
            this.grpPersonal.Controls.Add(this.label2);
            this.grpPersonal.Controls.Add(this.txtDireccion);
            this.grpPersonal.Controls.Add(this.txtNumeroTelefono);
            this.grpPersonal.Controls.Add(this.lblNumeroTelefono);
            this.grpPersonal.Controls.Add(this.ftpFechaNacimiento);
            this.grpPersonal.Controls.Add(this.lblFechaNacimiento);
            this.grpPersonal.Controls.Add(this.txtNombreCompleto);
            this.grpPersonal.Controls.Add(this.lblNombreCompleto);
            this.grpPersonal.Location = new System.Drawing.Point(13, 28);
            this.grpPersonal.Name = "grpPersonal";
            this.grpPersonal.Size = new System.Drawing.Size(529, 159);
            this.grpPersonal.TabIndex = 1;
            this.grpPersonal.TabStop = false;
            this.grpPersonal.Text = "Datos Personales";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Dirección:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Enabled = false;
            this.txtDireccion.Location = new System.Drawing.Point(80, 115);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(430, 20);
            this.txtDireccion.TabIndex = 8;
            // 
            // txtNumeroTelefono
            // 
            this.txtNumeroTelefono.Enabled = false;
            this.txtNumeroTelefono.Location = new System.Drawing.Point(369, 72);
            this.txtNumeroTelefono.Name = "txtNumeroTelefono";
            this.txtNumeroTelefono.Size = new System.Drawing.Size(141, 20);
            this.txtNumeroTelefono.TabIndex = 5;
            // 
            // lblNumeroTelefono
            // 
            this.lblNumeroTelefono.AutoSize = true;
            this.lblNumeroTelefono.Location = new System.Drawing.Point(256, 75);
            this.lblNumeroTelefono.Name = "lblNumeroTelefono";
            this.lblNumeroTelefono.Size = new System.Drawing.Size(107, 13);
            this.lblNumeroTelefono.TabIndex = 4;
            this.lblNumeroTelefono.Text = "Número de Telefono:";
            // 
            // ftpFechaNacimiento
            // 
            this.ftpFechaNacimiento.Enabled = false;
            this.ftpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ftpFechaNacimiento.Location = new System.Drawing.Point(141, 72);
            this.ftpFechaNacimiento.Name = "ftpFechaNacimiento";
            this.ftpFechaNacimiento.Size = new System.Drawing.Size(102, 20);
            this.ftpFechaNacimiento.TabIndex = 3;
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(19, 75);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(111, 13);
            this.lblFechaNacimiento.TabIndex = 2;
            this.lblFechaNacimiento.Text = "Fecha de Nacimiento:";
            // 
            // txtNombreCompleto
            // 
            this.txtNombreCompleto.Enabled = false;
            this.txtNombreCompleto.Location = new System.Drawing.Point(141, 27);
            this.txtNombreCompleto.Name = "txtNombreCompleto";
            this.txtNombreCompleto.Size = new System.Drawing.Size(369, 20);
            this.txtNombreCompleto.TabIndex = 1;
            // 
            // lblNombreCompleto
            // 
            this.lblNombreCompleto.AutoSize = true;
            this.lblNombreCompleto.Location = new System.Drawing.Point(19, 30);
            this.lblNombreCompleto.Name = "lblNombreCompleto";
            this.lblNombreCompleto.Size = new System.Drawing.Size(105, 13);
            this.lblNombreCompleto.TabIndex = 0;
            this.lblNombreCompleto.Text = "Nombres y Apellidos:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(386, 409);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(467, 409);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // grpPerfilUniversitario
            // 
            this.grpPerfilUniversitario.Controls.Add(this.txtEspecialidad);
            this.grpPerfilUniversitario.Controls.Add(this.lblObservaciones);
            this.grpPerfilUniversitario.Controls.Add(this.txtObservaciones);
            this.grpPerfilUniversitario.Controls.Add(this.lblNumeroCiclo);
            this.grpPerfilUniversitario.Controls.Add(this.numUDCiclo);
            this.grpPerfilUniversitario.Controls.Add(this.txtCorreo);
            this.grpPerfilUniversitario.Controls.Add(this.lblCorreo);
            this.grpPerfilUniversitario.Controls.Add(this.lblEspecialidad);
            this.grpPerfilUniversitario.Controls.Add(this.lblCodigoAlumno);
            this.grpPerfilUniversitario.Controls.Add(this.txtCodAlumno);
            this.grpPerfilUniversitario.Location = new System.Drawing.Point(13, 193);
            this.grpPerfilUniversitario.Name = "grpPerfilUniversitario";
            this.grpPerfilUniversitario.Size = new System.Drawing.Size(529, 210);
            this.grpPerfilUniversitario.TabIndex = 5;
            this.grpPerfilUniversitario.TabStop = false;
            this.grpPerfilUniversitario.Text = "Perfil Universitario";
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Location = new System.Drawing.Point(14, 110);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(76, 13);
            this.lblObservaciones.TabIndex = 13;
            this.lblObservaciones.Text = "Obervaciones:";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Enabled = false;
            this.txtObservaciones.Location = new System.Drawing.Point(98, 106);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(412, 78);
            this.txtObservaciones.TabIndex = 12;
            // 
            // lblNumeroCiclo
            // 
            this.lblNumeroCiclo.AutoSize = true;
            this.lblNumeroCiclo.Location = new System.Drawing.Point(19, 75);
            this.lblNumeroCiclo.Name = "lblNumeroCiclo";
            this.lblNumeroCiclo.Size = new System.Drawing.Size(33, 13);
            this.lblNumeroCiclo.TabIndex = 11;
            this.lblNumeroCiclo.Text = "Ciclo:";
            // 
            // numUDCiclo
            // 
            this.numUDCiclo.Location = new System.Drawing.Point(67, 73);
            this.numUDCiclo.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numUDCiclo.Name = "numUDCiclo";
            this.numUDCiclo.Size = new System.Drawing.Size(48, 20);
            this.numUDCiclo.TabIndex = 10;
            this.numUDCiclo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numUDCiclo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtCorreo
            // 
            this.txtCorreo.Enabled = false;
            this.txtCorreo.Location = new System.Drawing.Point(218, 72);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(292, 20);
            this.txtCorreo.TabIndex = 7;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(171, 75);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(41, 13);
            this.lblCorreo.TabIndex = 6;
            this.lblCorreo.Text = "Correo:";
            // 
            // lblEspecialidad
            // 
            this.lblEspecialidad.AutoSize = true;
            this.lblEspecialidad.Location = new System.Drawing.Point(235, 36);
            this.lblEspecialidad.Name = "lblEspecialidad";
            this.lblEspecialidad.Size = new System.Drawing.Size(70, 13);
            this.lblEspecialidad.TabIndex = 8;
            this.lblEspecialidad.Text = "Especialidad:";
            // 
            // lblCodigoAlumno
            // 
            this.lblCodigoAlumno.AutoSize = true;
            this.lblCodigoAlumno.Location = new System.Drawing.Point(19, 36);
            this.lblCodigoAlumno.Name = "lblCodigoAlumno";
            this.lblCodigoAlumno.Size = new System.Drawing.Size(96, 13);
            this.lblCodigoAlumno.TabIndex = 7;
            this.lblCodigoAlumno.Text = "Código de Alumno:";
            // 
            // txtCodAlumno
            // 
            this.txtCodAlumno.Enabled = false;
            this.txtCodAlumno.Location = new System.Drawing.Point(121, 32);
            this.txtCodAlumno.Name = "txtCodAlumno";
            this.txtCodAlumno.Size = new System.Drawing.Size(91, 20);
            this.txtCodAlumno.TabIndex = 0;
            this.txtCodAlumno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(13, 409);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 6;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // txtEspecialidad
            // 
            this.txtEspecialidad.Location = new System.Drawing.Point(311, 33);
            this.txtEspecialidad.Name = "txtEspecialidad";
            this.txtEspecialidad.Size = new System.Drawing.Size(199, 20);
            this.txtEspecialidad.TabIndex = 14;
            // 
            // frmAdministrarAconsejados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 441);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.grpPerfilUniversitario);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.grpPersonal);
            this.Controls.Add(this.menuAconsejadosPrincipal);
            this.MainMenuStrip = this.menuAconsejadosPrincipal;
            this.Name = "frmAdministrarAconsejados";
            this.Text = "Administración de aconsejados";
            this.menuAconsejadosPrincipal.ResumeLayout(false);
            this.menuAconsejadosPrincipal.PerformLayout();
            this.grpPersonal.ResumeLayout(false);
            this.grpPersonal.PerformLayout();
            this.grpPerfilUniversitario.ResumeLayout(false);
            this.grpPerfilUniversitario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDCiclo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuAconsejadosPrincipal;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vincularToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actividadToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpPersonal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtNumeroTelefono;
        private System.Windows.Forms.Label lblNumeroTelefono;
        private System.Windows.Forms.DateTimePicker ftpFechaNacimiento;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.TextBox txtNombreCompleto;
        private System.Windows.Forms.Label lblNombreCompleto;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox grpPerfilUniversitario;
        private System.Windows.Forms.Label lblObservaciones;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Label lblNumeroCiclo;
        private System.Windows.Forms.NumericUpDown numUDCiclo;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblEspecialidad;
        private System.Windows.Forms.Label lblCodigoAlumno;
        private System.Windows.Forms.TextBox txtCodAlumno;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.TextBox txtEspecialidad;
    }
}