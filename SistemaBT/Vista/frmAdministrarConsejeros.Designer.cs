namespace Vista
{
    partial class frmAdministrarConsejeros
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
            this.grpPerfilUniversitario = new System.Windows.Forms.GroupBox();
            this.cmbEspecialidadConsej = new System.Windows.Forms.ComboBox();
            this.lblEspecialidad = new System.Windows.Forms.Label();
            this.lblCodigoAlumno = new System.Windows.Forms.Label();
            this.txtCodigoConsej = new System.Windows.Forms.TextBox();
            this.grpPersonal = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDireccConsej = new System.Windows.Forms.TextBox();
            this.txtTelefConsej = new System.Windows.Forms.TextBox();
            this.lblNumeroTelefono = new System.Windows.Forms.Label();
            this.dtpFechaNacConsej = new System.Windows.Forms.DateTimePicker();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.txtNombreConsejero = new System.Windows.Forms.TextBox();
            this.lblNombreCompleto = new System.Windows.Forms.Label();
            this.menuAconsejadosPrincipal = new System.Windows.Forms.MenuStrip();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vincularToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actividadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCorreoConsej = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAreasIntConsej = new System.Windows.Forms.TextBox();
            this.cmbGradoCcnsej = new System.Windows.Forms.ComboBox();
            this.txtSectorConsej = new System.Windows.Forms.TextBox();
            this.txtEmpresaConsej = new System.Windows.Forms.TextBox();
            this.txtCargoConsej = new System.Windows.Forms.TextBox();
            this.txtObsConsej = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCancelarConsejero = new System.Windows.Forms.Button();
            this.btnAgregarConsejero = new System.Windows.Forms.Button();
            this.grpPerfilUniversitario.SuspendLayout();
            this.grpPersonal.SuspendLayout();
            this.menuAconsejadosPrincipal.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpPerfilUniversitario
            // 
            this.grpPerfilUniversitario.Controls.Add(this.cmbEspecialidadConsej);
            this.grpPerfilUniversitario.Controls.Add(this.lblEspecialidad);
            this.grpPerfilUniversitario.Controls.Add(this.lblCodigoAlumno);
            this.grpPerfilUniversitario.Controls.Add(this.txtCodigoConsej);
            this.grpPerfilUniversitario.Location = new System.Drawing.Point(15, 409);
            this.grpPerfilUniversitario.Margin = new System.Windows.Forms.Padding(6);
            this.grpPerfilUniversitario.Name = "grpPerfilUniversitario";
            this.grpPerfilUniversitario.Padding = new System.Windows.Forms.Padding(6);
            this.grpPerfilUniversitario.Size = new System.Drawing.Size(1044, 142);
            this.grpPerfilUniversitario.TabIndex = 3;
            this.grpPerfilUniversitario.TabStop = false;
            this.grpPerfilUniversitario.Text = "Perfil Universitario";
            // 
            // cmbEspecialidadConsej
            // 
            this.cmbEspecialidadConsej.Enabled = false;
            this.cmbEspecialidadConsej.FormattingEnabled = true;
            this.cmbEspecialidadConsej.Location = new System.Drawing.Point(622, 63);
            this.cmbEspecialidadConsej.Margin = new System.Windows.Forms.Padding(6);
            this.cmbEspecialidadConsej.Name = "cmbEspecialidadConsej";
            this.cmbEspecialidadConsej.Size = new System.Drawing.Size(372, 33);
            this.cmbEspecialidadConsej.TabIndex = 9;
            // 
            // lblEspecialidad
            // 
            this.lblEspecialidad.AutoSize = true;
            this.lblEspecialidad.Location = new System.Drawing.Point(450, 69);
            this.lblEspecialidad.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblEspecialidad.Name = "lblEspecialidad";
            this.lblEspecialidad.Size = new System.Drawing.Size(163, 25);
            this.lblEspecialidad.TabIndex = 8;
            this.lblEspecialidad.Text = "Especialidad(*):";
            // 
            // lblCodigoAlumno
            // 
            this.lblCodigoAlumno.AutoSize = true;
            this.lblCodigoAlumno.Location = new System.Drawing.Point(38, 69);
            this.lblCodigoAlumno.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCodigoAlumno.Name = "lblCodigoAlumno";
            this.lblCodigoAlumno.Size = new System.Drawing.Size(194, 25);
            this.lblCodigoAlumno.TabIndex = 7;
            this.lblCodigoAlumno.Text = "Código de Alumno:";
            // 
            // txtCodigoConsej
            // 
            this.txtCodigoConsej.Enabled = false;
            this.txtCodigoConsej.Location = new System.Drawing.Point(242, 63);
            this.txtCodigoConsej.Margin = new System.Windows.Forms.Padding(6);
            this.txtCodigoConsej.Name = "txtCodigoConsej";
            this.txtCodigoConsej.Size = new System.Drawing.Size(156, 31);
            this.txtCodigoConsej.TabIndex = 0;
            this.txtCodigoConsej.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // grpPersonal
            // 
            this.grpPersonal.AutoSize = true;
            this.grpPersonal.Controls.Add(this.label2);
            this.grpPersonal.Controls.Add(this.txtDireccConsej);
            this.grpPersonal.Controls.Add(this.txtTelefConsej);
            this.grpPersonal.Controls.Add(this.lblNumeroTelefono);
            this.grpPersonal.Controls.Add(this.dtpFechaNacConsej);
            this.grpPersonal.Controls.Add(this.lblFechaNacimiento);
            this.grpPersonal.Controls.Add(this.txtNombreConsejero);
            this.grpPersonal.Controls.Add(this.lblNombreCompleto);
            this.grpPersonal.Location = new System.Drawing.Point(20, 50);
            this.grpPersonal.Margin = new System.Windows.Forms.Padding(6);
            this.grpPersonal.Name = "grpPersonal";
            this.grpPersonal.Padding = new System.Windows.Forms.Padding(6);
            this.grpPersonal.Size = new System.Drawing.Size(1044, 306);
            this.grpPersonal.TabIndex = 14;
            this.grpPersonal.TabStop = false;
            this.grpPersonal.Text = "Datos Personales";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 227);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Dirección:";
            // 
            // txtDireccConsej
            // 
            this.txtDireccConsej.Enabled = false;
            this.txtDireccConsej.Location = new System.Drawing.Point(160, 221);
            this.txtDireccConsej.Margin = new System.Windows.Forms.Padding(6);
            this.txtDireccConsej.Name = "txtDireccConsej";
            this.txtDireccConsej.Size = new System.Drawing.Size(834, 31);
            this.txtDireccConsej.TabIndex = 8;
            // 
            // txtTelefConsej
            // 
            this.txtTelefConsej.Enabled = false;
            this.txtTelefConsej.Location = new System.Drawing.Point(738, 138);
            this.txtTelefConsej.Margin = new System.Windows.Forms.Padding(6);
            this.txtTelefConsej.Name = "txtTelefConsej";
            this.txtTelefConsej.Size = new System.Drawing.Size(256, 31);
            this.txtTelefConsej.TabIndex = 5;
            // 
            // lblNumeroTelefono
            // 
            this.lblNumeroTelefono.AutoSize = true;
            this.lblNumeroTelefono.Location = new System.Drawing.Point(512, 144);
            this.lblNumeroTelefono.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNumeroTelefono.Name = "lblNumeroTelefono";
            this.lblNumeroTelefono.Size = new System.Drawing.Size(213, 25);
            this.lblNumeroTelefono.TabIndex = 4;
            this.lblNumeroTelefono.Text = "Número de Telefono:";
            // 
            // dtpFechaNacConsej
            // 
            this.dtpFechaNacConsej.Enabled = false;
            this.dtpFechaNacConsej.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNacConsej.Location = new System.Drawing.Point(282, 138);
            this.dtpFechaNacConsej.Margin = new System.Windows.Forms.Padding(6);
            this.dtpFechaNacConsej.Name = "dtpFechaNacConsej";
            this.dtpFechaNacConsej.Size = new System.Drawing.Size(200, 31);
            this.dtpFechaNacConsej.TabIndex = 3;
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(38, 144);
            this.lblFechaNacimiento.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(221, 25);
            this.lblFechaNacimiento.TabIndex = 2;
            this.lblFechaNacimiento.Text = "Fecha de Nacimiento:";
            // 
            // txtNombreConsejero
            // 
            this.txtNombreConsejero.Enabled = false;
            this.txtNombreConsejero.Location = new System.Drawing.Point(282, 52);
            this.txtNombreConsejero.Margin = new System.Windows.Forms.Padding(6);
            this.txtNombreConsejero.Name = "txtNombreConsejero";
            this.txtNombreConsejero.Size = new System.Drawing.Size(712, 31);
            this.txtNombreConsejero.TabIndex = 1;
            // 
            // lblNombreCompleto
            // 
            this.lblNombreCompleto.AutoSize = true;
            this.lblNombreCompleto.Location = new System.Drawing.Point(38, 58);
            this.lblNombreCompleto.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNombreCompleto.Name = "lblNombreCompleto";
            this.lblNombreCompleto.Size = new System.Drawing.Size(237, 25);
            this.lblNombreCompleto.TabIndex = 0;
            this.lblNombreCompleto.Text = "Nombres y Apellidos(*):";
            // 
            // menuAconsejadosPrincipal
            // 
            this.menuAconsejadosPrincipal.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuAconsejadosPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.guardarToolStripMenuItem,
            this.modificarToolStripMenuItem,
            this.vincularToolStripMenuItem,
            this.actividadToolStripMenuItem});
            this.menuAconsejadosPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuAconsejadosPrincipal.Name = "menuAconsejadosPrincipal";
            this.menuAconsejadosPrincipal.Padding = new System.Windows.Forms.Padding(12, 4, 0, 4);
            this.menuAconsejadosPrincipal.Size = new System.Drawing.Size(1106, 44);
            this.menuAconsejadosPrincipal.TabIndex = 15;
            this.menuAconsejadosPrincipal.Text = "menuStrip1";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(98, 36);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Enabled = false;
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(111, 36);
            this.guardarToolStripMenuItem.Text = "Guardar";
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(128, 36);
            this.modificarToolStripMenuItem.Text = "Modificar";
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.modificarToolStripMenuItem_Click);
            // 
            // vincularToolStripMenuItem
            // 
            this.vincularToolStripMenuItem.Name = "vincularToolStripMenuItem";
            this.vincularToolStripMenuItem.Size = new System.Drawing.Size(113, 36);
            this.vincularToolStripMenuItem.Text = "Vincular";
            // 
            // actividadToolStripMenuItem
            // 
            this.actividadToolStripMenuItem.Name = "actividadToolStripMenuItem";
            this.actividadToolStripMenuItem.Size = new System.Drawing.Size(125, 36);
            this.actividadToolStripMenuItem.Text = "Actividad";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtObsConsej);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtCargoConsej);
            this.groupBox1.Controls.Add(this.txtEmpresaConsej);
            this.groupBox1.Controls.Add(this.txtSectorConsej);
            this.groupBox1.Controls.Add(this.cmbGradoCcnsej);
            this.groupBox1.Controls.Add(this.txtAreasIntConsej);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtCorreoConsej);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(23, 577);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1044, 619);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Perfil Profesional";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(487, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Cargo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Sector:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(487, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Empresa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Grado:";
            // 
            // txtCorreoConsej
            // 
            this.txtCorreoConsej.Enabled = false;
            this.txtCorreoConsej.Location = new System.Drawing.Point(181, 214);
            this.txtCorreoConsej.Margin = new System.Windows.Forms.Padding(6);
            this.txtCorreoConsej.Name = "txtCorreoConsej";
            this.txtCorreoConsej.Size = new System.Drawing.Size(558, 31);
            this.txtCorreoConsej.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(75, 220);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Correo:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(81, 292);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(175, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "Areas de interes:";
            // 
            // txtAreasIntConsej
            // 
            this.txtAreasIntConsej.Enabled = false;
            this.txtAreasIntConsej.Location = new System.Drawing.Point(279, 289);
            this.txtAreasIntConsej.Margin = new System.Windows.Forms.Padding(6);
            this.txtAreasIntConsej.Multiline = true;
            this.txtAreasIntConsej.Name = "txtAreasIntConsej";
            this.txtAreasIntConsej.Size = new System.Drawing.Size(674, 128);
            this.txtAreasIntConsej.TabIndex = 13;
            // 
            // cmbGradoCcnsej
            // 
            this.cmbGradoCcnsej.Enabled = false;
            this.cmbGradoCcnsej.FormattingEnabled = true;
            this.cmbGradoCcnsej.Location = new System.Drawing.Point(213, 64);
            this.cmbGradoCcnsej.Name = "cmbGradoCcnsej";
            this.cmbGradoCcnsej.Size = new System.Drawing.Size(212, 33);
            this.cmbGradoCcnsej.TabIndex = 14;
            // 
            // txtSectorConsej
            // 
            this.txtSectorConsej.Enabled = false;
            this.txtSectorConsej.Location = new System.Drawing.Point(213, 143);
            this.txtSectorConsej.Margin = new System.Windows.Forms.Padding(6);
            this.txtSectorConsej.Name = "txtSectorConsej";
            this.txtSectorConsej.Size = new System.Drawing.Size(156, 31);
            this.txtSectorConsej.TabIndex = 10;
            this.txtSectorConsej.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEmpresaConsej
            // 
            this.txtEmpresaConsej.Enabled = false;
            this.txtEmpresaConsej.Location = new System.Drawing.Point(614, 70);
            this.txtEmpresaConsej.Margin = new System.Windows.Forms.Padding(6);
            this.txtEmpresaConsej.Name = "txtEmpresaConsej";
            this.txtEmpresaConsej.Size = new System.Drawing.Size(156, 31);
            this.txtEmpresaConsej.TabIndex = 15;
            this.txtEmpresaConsej.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCargoConsej
            // 
            this.txtCargoConsej.Enabled = false;
            this.txtCargoConsej.Location = new System.Drawing.Point(614, 143);
            this.txtCargoConsej.Margin = new System.Windows.Forms.Padding(6);
            this.txtCargoConsej.Name = "txtCargoConsej";
            this.txtCargoConsej.Size = new System.Drawing.Size(156, 31);
            this.txtCargoConsej.TabIndex = 16;
            this.txtCargoConsej.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtObsConsej
            // 
            this.txtObsConsej.Enabled = false;
            this.txtObsConsej.Location = new System.Drawing.Point(279, 457);
            this.txtObsConsej.Margin = new System.Windows.Forms.Padding(6);
            this.txtObsConsej.Multiline = true;
            this.txtObsConsej.Name = "txtObsConsej";
            this.txtObsConsej.Size = new System.Drawing.Size(674, 128);
            this.txtObsConsej.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(81, 461);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(156, 25);
            this.label8.TabIndex = 17;
            this.label8.Text = "Observaciones";
            // 
            // btnCancelarConsejero
            // 
            this.btnCancelarConsejero.Location = new System.Drawing.Point(909, 1231);
            this.btnCancelarConsejero.Margin = new System.Windows.Forms.Padding(6);
            this.btnCancelarConsejero.Name = "btnCancelarConsejero";
            this.btnCancelarConsejero.Size = new System.Drawing.Size(150, 44);
            this.btnCancelarConsejero.TabIndex = 18;
            this.btnCancelarConsejero.Text = "Cancelar";
            this.btnCancelarConsejero.UseVisualStyleBackColor = true;
            // 
            // btnAgregarConsejero
            // 
            this.btnAgregarConsejero.Location = new System.Drawing.Point(714, 1231);
            this.btnAgregarConsejero.Margin = new System.Windows.Forms.Padding(6);
            this.btnAgregarConsejero.Name = "btnAgregarConsejero";
            this.btnAgregarConsejero.Size = new System.Drawing.Size(150, 44);
            this.btnAgregarConsejero.TabIndex = 17;
            this.btnAgregarConsejero.Text = "Agregar";
            this.btnAgregarConsejero.UseVisualStyleBackColor = true;
            // 
            // frmAdministrarConsejeros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 1309);
            this.Controls.Add(this.btnCancelarConsejero);
            this.Controls.Add(this.btnAgregarConsejero);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuAconsejadosPrincipal);
            this.Controls.Add(this.grpPersonal);
            this.Controls.Add(this.grpPerfilUniversitario);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmAdministrarConsejeros";
            this.Text = "Administrar Consejeros";
            this.grpPerfilUniversitario.ResumeLayout(false);
            this.grpPerfilUniversitario.PerformLayout();
            this.grpPersonal.ResumeLayout(false);
            this.grpPersonal.PerformLayout();
            this.menuAconsejadosPrincipal.ResumeLayout(false);
            this.menuAconsejadosPrincipal.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPerfilUniversitario;
        private System.Windows.Forms.ComboBox cmbEspecialidadConsej;
        private System.Windows.Forms.Label lblEspecialidad;
        private System.Windows.Forms.Label lblCodigoAlumno;
        private System.Windows.Forms.TextBox txtCodigoConsej;
        private System.Windows.Forms.GroupBox grpPersonal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDireccConsej;
        private System.Windows.Forms.TextBox txtTelefConsej;
        private System.Windows.Forms.Label lblNumeroTelefono;
        private System.Windows.Forms.DateTimePicker dtpFechaNacConsej;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.TextBox txtNombreConsejero;
        private System.Windows.Forms.Label lblNombreCompleto;
        private System.Windows.Forms.MenuStrip menuAconsejadosPrincipal;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vincularToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actividadToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCorreoConsej;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCargoConsej;
        private System.Windows.Forms.TextBox txtEmpresaConsej;
        private System.Windows.Forms.TextBox txtSectorConsej;
        private System.Windows.Forms.ComboBox cmbGradoCcnsej;
        private System.Windows.Forms.TextBox txtAreasIntConsej;
        private System.Windows.Forms.TextBox txtObsConsej;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCancelarConsejero;
        private System.Windows.Forms.Button btnAgregarConsejero;
    }
}