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
            this.establecerMatchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verMatchesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.radInhabilitado = new System.Windows.Forms.RadioButton();
            this.radHabilitado = new System.Windows.Forms.RadioButton();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtEspecialidad = new System.Windows.Forms.TextBox();
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
            this.btnEliminar = new System.Windows.Forms.Button();
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
            this.menuAconsejadosPrincipal.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuAconsejadosPrincipal.Size = new System.Drawing.Size(739, 28);
            this.menuAconsejadosPrincipal.TabIndex = 0;
            this.menuAconsejadosPrincipal.Text = "menuStrip1";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.modificarToolStripMenuItem.Text = "Modificar";
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.modificarToolStripMenuItem_Click);
            // 
            // vincularToolStripMenuItem
            // 
            this.vincularToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.establecerMatchToolStripMenuItem,
            this.verMatchesToolStripMenuItem});
            this.vincularToolStripMenuItem.Name = "vincularToolStripMenuItem";
            this.vincularToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.vincularToolStripMenuItem.Text = "Vincular";
            this.vincularToolStripMenuItem.Click += new System.EventHandler(this.vincularToolStripMenuItem_Click);
            // 
            // establecerMatchToolStripMenuItem
            // 
            this.establecerMatchToolStripMenuItem.Name = "establecerMatchToolStripMenuItem";
            this.establecerMatchToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.establecerMatchToolStripMenuItem.Text = "Establecer Match";
            this.establecerMatchToolStripMenuItem.Click += new System.EventHandler(this.establecerMatchToolStripMenuItem_Click);
            // 
            // verMatchesToolStripMenuItem
            // 
            this.verMatchesToolStripMenuItem.Name = "verMatchesToolStripMenuItem";
            this.verMatchesToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.verMatchesToolStripMenuItem.Text = "Ver Matches";
            this.verMatchesToolStripMenuItem.Click += new System.EventHandler(this.verMatchesToolStripMenuItem_Click);
            // 
            // actividadToolStripMenuItem
            // 
            this.actividadToolStripMenuItem.Name = "actividadToolStripMenuItem";
            this.actividadToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
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
            this.grpPersonal.Location = new System.Drawing.Point(17, 34);
            this.grpPersonal.Margin = new System.Windows.Forms.Padding(4);
            this.grpPersonal.Name = "grpPersonal";
            this.grpPersonal.Padding = new System.Windows.Forms.Padding(4);
            this.grpPersonal.Size = new System.Drawing.Size(705, 361);
            this.grpPersonal.TabIndex = 1;
            this.grpPersonal.TabStop = false;
            this.grpPersonal.Text = "Datos Personales";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 175);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Dirección:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Enabled = false;
            this.txtDireccion.Location = new System.Drawing.Point(188, 172);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(491, 93);
            this.txtDireccion.TabIndex = 8;
            // 
            // txtNumeroTelefono
            // 
            this.txtNumeroTelefono.Enabled = false;
            this.txtNumeroTelefono.Location = new System.Drawing.Point(188, 135);
            this.txtNumeroTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumeroTelefono.Name = "txtNumeroTelefono";
            this.txtNumeroTelefono.Size = new System.Drawing.Size(187, 22);
            this.txtNumeroTelefono.TabIndex = 5;
            // 
            // lblNumeroTelefono
            // 
            this.lblNumeroTelefono.AutoSize = true;
            this.lblNumeroTelefono.Location = new System.Drawing.Point(24, 135);
            this.lblNumeroTelefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumeroTelefono.Name = "lblNumeroTelefono";
            this.lblNumeroTelefono.Size = new System.Drawing.Size(142, 17);
            this.lblNumeroTelefono.TabIndex = 4;
            this.lblNumeroTelefono.Text = "Número de Telefono:";
            // 
            // ftpFechaNacimiento
            // 
            this.ftpFechaNacimiento.Enabled = false;
            this.ftpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ftpFechaNacimiento.Location = new System.Drawing.Point(188, 89);
            this.ftpFechaNacimiento.Margin = new System.Windows.Forms.Padding(4);
            this.ftpFechaNacimiento.Name = "ftpFechaNacimiento";
            this.ftpFechaNacimiento.Size = new System.Drawing.Size(135, 22);
            this.ftpFechaNacimiento.TabIndex = 3;
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(25, 92);
            this.lblFechaNacimiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(145, 17);
            this.lblFechaNacimiento.TabIndex = 2;
            this.lblFechaNacimiento.Text = "Fecha de Nacimiento:";
            // 
            // txtNombreCompleto
            // 
            this.txtNombreCompleto.Enabled = false;
            this.txtNombreCompleto.Location = new System.Drawing.Point(188, 49);
            this.txtNombreCompleto.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreCompleto.Name = "txtNombreCompleto";
            this.txtNombreCompleto.Size = new System.Drawing.Size(491, 22);
            this.txtNombreCompleto.TabIndex = 1;
            // 
            // lblNombreCompleto
            // 
            this.lblNombreCompleto.AutoSize = true;
            this.lblNombreCompleto.Location = new System.Drawing.Point(25, 53);
            this.lblNombreCompleto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreCompleto.Name = "lblNombreCompleto";
            this.lblNombreCompleto.Size = new System.Drawing.Size(141, 17);
            this.lblNombreCompleto.TabIndex = 0;
            this.lblNombreCompleto.Text = "Nombres y Apellidos:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(515, 832);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(100, 28);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(623, 832);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 28);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // grpPerfilUniversitario
            // 
            this.grpPerfilUniversitario.Controls.Add(this.radInhabilitado);
            this.grpPerfilUniversitario.Controls.Add(this.radHabilitado);
            this.grpPerfilUniversitario.Controls.Add(this.lblEstado);
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
            this.grpPerfilUniversitario.Location = new System.Drawing.Point(17, 403);
            this.grpPerfilUniversitario.Margin = new System.Windows.Forms.Padding(4);
            this.grpPerfilUniversitario.Name = "grpPerfilUniversitario";
            this.grpPerfilUniversitario.Padding = new System.Windows.Forms.Padding(4);
            this.grpPerfilUniversitario.Size = new System.Drawing.Size(705, 421);
            this.grpPerfilUniversitario.TabIndex = 5;
            this.grpPerfilUniversitario.TabStop = false;
            this.grpPerfilUniversitario.Text = "Perfil Universitario";
            // 
            // radInhabilitado
            // 
            this.radInhabilitado.AutoSize = true;
            this.radInhabilitado.Location = new System.Drawing.Point(252, 382);
            this.radInhabilitado.Margin = new System.Windows.Forms.Padding(4);
            this.radInhabilitado.Name = "radInhabilitado";
            this.radInhabilitado.Size = new System.Drawing.Size(101, 21);
            this.radInhabilitado.TabIndex = 17;
            this.radInhabilitado.TabStop = true;
            this.radInhabilitado.Text = "Inhabilitado";
            this.radInhabilitado.UseVisualStyleBackColor = true;
            // 
            // radHabilitado
            // 
            this.radHabilitado.AutoSize = true;
            this.radHabilitado.Location = new System.Drawing.Point(131, 382);
            this.radHabilitado.Margin = new System.Windows.Forms.Padding(4);
            this.radHabilitado.Name = "radHabilitado";
            this.radHabilitado.Size = new System.Drawing.Size(92, 21);
            this.radHabilitado.TabIndex = 16;
            this.radHabilitado.TabStop = true;
            this.radHabilitado.Text = "Habilitado";
            this.radHabilitado.UseVisualStyleBackColor = true;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(19, 385);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(56, 17);
            this.lblEstado.TabIndex = 15;
            this.lblEstado.Text = "Estado:";
            // 
            // txtEspecialidad
            // 
            this.txtEspecialidad.Location = new System.Drawing.Point(131, 142);
            this.txtEspecialidad.Margin = new System.Windows.Forms.Padding(4);
            this.txtEspecialidad.Name = "txtEspecialidad";
            this.txtEspecialidad.Size = new System.Drawing.Size(264, 22);
            this.txtEspecialidad.TabIndex = 14;
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Location = new System.Drawing.Point(19, 235);
            this.lblObservaciones.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(100, 17);
            this.lblObservaciones.TabIndex = 13;
            this.lblObservaciones.Text = "Obervaciones:";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Enabled = false;
            this.txtObservaciones.Location = new System.Drawing.Point(131, 232);
            this.txtObservaciones.Margin = new System.Windows.Forms.Padding(4);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(548, 142);
            this.txtObservaciones.TabIndex = 12;
            // 
            // lblNumeroCiclo
            // 
            this.lblNumeroCiclo.AutoSize = true;
            this.lblNumeroCiclo.Location = new System.Drawing.Point(67, 174);
            this.lblNumeroCiclo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumeroCiclo.Name = "lblNumeroCiclo";
            this.lblNumeroCiclo.Size = new System.Drawing.Size(42, 17);
            this.lblNumeroCiclo.TabIndex = 11;
            this.lblNumeroCiclo.Text = "Ciclo:";
            // 
            // numUDCiclo
            // 
            this.numUDCiclo.Location = new System.Drawing.Point(131, 172);
            this.numUDCiclo.Margin = new System.Windows.Forms.Padding(4);
            this.numUDCiclo.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numUDCiclo.Name = "numUDCiclo";
            this.numUDCiclo.Size = new System.Drawing.Size(64, 22);
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
            this.txtCorreo.Location = new System.Drawing.Point(131, 202);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(388, 22);
            this.txtCorreo.TabIndex = 7;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(68, 205);
            this.lblCorreo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(55, 17);
            this.lblCorreo.TabIndex = 6;
            this.lblCorreo.Text = "Correo:";
            // 
            // lblEspecialidad
            // 
            this.lblEspecialidad.AutoSize = true;
            this.lblEspecialidad.Location = new System.Drawing.Point(29, 145);
            this.lblEspecialidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEspecialidad.Name = "lblEspecialidad";
            this.lblEspecialidad.Size = new System.Drawing.Size(92, 17);
            this.lblEspecialidad.TabIndex = 8;
            this.lblEspecialidad.Text = "Especialidad:";
            // 
            // lblCodigoAlumno
            // 
            this.lblCodigoAlumno.AutoSize = true;
            this.lblCodigoAlumno.Location = new System.Drawing.Point(25, 44);
            this.lblCodigoAlumno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigoAlumno.Name = "lblCodigoAlumno";
            this.lblCodigoAlumno.Size = new System.Drawing.Size(127, 17);
            this.lblCodigoAlumno.TabIndex = 7;
            this.lblCodigoAlumno.Text = "Código de Alumno:";
            this.lblCodigoAlumno.Click += new System.EventHandler(this.lblCodigoAlumno_Click);
            // 
            // txtCodAlumno
            // 
            this.txtCodAlumno.Enabled = false;
            this.txtCodAlumno.Location = new System.Drawing.Point(161, 39);
            this.txtCodAlumno.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodAlumno.Name = "txtCodAlumno";
            this.txtCodAlumno.Size = new System.Drawing.Size(120, 22);
            this.txtCodAlumno.TabIndex = 0;
            this.txtCodAlumno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCodAlumno.TextChanged += new System.EventHandler(this.txtCodAlumno_TextChanged);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(17, 832);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(100, 28);
            this.btnModificar.TabIndex = 6;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(124, 832);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 28);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // frmAdministrarAconsejados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(739, 873);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.grpPerfilUniversitario);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.grpPersonal);
            this.Controls.Add(this.menuAconsejadosPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(160, 0);
            this.MainMenuStrip = this.menuAconsejadosPrincipal;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAdministrarAconsejados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
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
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.RadioButton radInhabilitado;
        private System.Windows.Forms.RadioButton radHabilitado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ToolStripMenuItem establecerMatchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verMatchesToolStripMenuItem;
    }
}