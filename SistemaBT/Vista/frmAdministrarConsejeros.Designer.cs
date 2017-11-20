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
            this.txtEspecialidad = new System.Windows.Forms.TextBox();
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
            this.actividadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtGradoConsej = new System.Windows.Forms.TextBox();
            this.txtObsConsej = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCargoConsej = new System.Windows.Forms.TextBox();
            this.txtEmpresaConsej = new System.Windows.Forms.TextBox();
            this.txtSectorConsej = new System.Windows.Forms.TextBox();
            this.txtAreasIntConsej = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCorreoConsej = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelarConsejero = new System.Windows.Forms.Button();
            this.btnAgregarConsejero = new System.Windows.Forms.Button();
            this.btnEliminarConsejero = new System.Windows.Forms.Button();
            this.grpPerfilUniversitario.SuspendLayout();
            this.grpPersonal.SuspendLayout();
            this.menuAconsejadosPrincipal.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpPerfilUniversitario
            // 
            this.grpPerfilUniversitario.Controls.Add(this.txtEspecialidad);
            this.grpPerfilUniversitario.Controls.Add(this.lblEspecialidad);
            this.grpPerfilUniversitario.Controls.Add(this.lblCodigoAlumno);
            this.grpPerfilUniversitario.Controls.Add(this.txtCodigoConsej);
            this.grpPerfilUniversitario.Location = new System.Drawing.Point(10, 262);
            this.grpPerfilUniversitario.Margin = new System.Windows.Forms.Padding(4);
            this.grpPerfilUniversitario.Name = "grpPerfilUniversitario";
            this.grpPerfilUniversitario.Padding = new System.Windows.Forms.Padding(4);
            this.grpPerfilUniversitario.Size = new System.Drawing.Size(696, 91);
            this.grpPerfilUniversitario.TabIndex = 3;
            this.grpPerfilUniversitario.TabStop = false;
            this.grpPerfilUniversitario.Text = "Perfil Universitario";
            // 
            // txtEspecialidad
            // 
            this.txtEspecialidad.Enabled = false;
            this.txtEspecialidad.Location = new System.Drawing.Point(414, 41);
            this.txtEspecialidad.Name = "txtEspecialidad";
            this.txtEspecialidad.Size = new System.Drawing.Size(253, 22);
            this.txtEspecialidad.TabIndex = 9;
            // 
            // lblEspecialidad
            // 
            this.lblEspecialidad.AutoSize = true;
            this.lblEspecialidad.Location = new System.Drawing.Point(300, 44);
            this.lblEspecialidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEspecialidad.Name = "lblEspecialidad";
            this.lblEspecialidad.Size = new System.Drawing.Size(107, 17);
            this.lblEspecialidad.TabIndex = 8;
            this.lblEspecialidad.Text = "Especialidad(*):";
            // 
            // lblCodigoAlumno
            // 
            this.lblCodigoAlumno.AutoSize = true;
            this.lblCodigoAlumno.Location = new System.Drawing.Point(18, 42);
            this.lblCodigoAlumno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigoAlumno.Name = "lblCodigoAlumno";
            this.lblCodigoAlumno.Size = new System.Drawing.Size(142, 17);
            this.lblCodigoAlumno.TabIndex = 7;
            this.lblCodigoAlumno.Text = "Código de Alumno(*):";
            // 
            // txtCodigoConsej
            // 
            this.txtCodigoConsej.Enabled = false;
            this.txtCodigoConsej.Location = new System.Drawing.Point(161, 40);
            this.txtCodigoConsej.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigoConsej.Name = "txtCodigoConsej";
            this.txtCodigoConsej.Size = new System.Drawing.Size(105, 22);
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
            this.grpPersonal.Location = new System.Drawing.Point(13, 32);
            this.grpPersonal.Margin = new System.Windows.Forms.Padding(4);
            this.grpPersonal.Name = "grpPersonal";
            this.grpPersonal.Padding = new System.Windows.Forms.Padding(4);
            this.grpPersonal.Size = new System.Drawing.Size(696, 196);
            this.grpPersonal.TabIndex = 14;
            this.grpPersonal.TabStop = false;
            this.grpPersonal.Text = "Datos Personales";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 145);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Dirección:";
            // 
            // txtDireccConsej
            // 
            this.txtDireccConsej.Enabled = false;
            this.txtDireccConsej.Location = new System.Drawing.Point(107, 141);
            this.txtDireccConsej.Margin = new System.Windows.Forms.Padding(4);
            this.txtDireccConsej.Name = "txtDireccConsej";
            this.txtDireccConsej.Size = new System.Drawing.Size(557, 22);
            this.txtDireccConsej.TabIndex = 8;
            // 
            // txtTelefConsej
            // 
            this.txtTelefConsej.Enabled = false;
            this.txtTelefConsej.Location = new System.Drawing.Point(492, 88);
            this.txtTelefConsej.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefConsej.Name = "txtTelefConsej";
            this.txtTelefConsej.Size = new System.Drawing.Size(172, 22);
            this.txtTelefConsej.TabIndex = 5;
            // 
            // lblNumeroTelefono
            // 
            this.lblNumeroTelefono.AutoSize = true;
            this.lblNumeroTelefono.Location = new System.Drawing.Point(341, 92);
            this.lblNumeroTelefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumeroTelefono.Name = "lblNumeroTelefono";
            this.lblNumeroTelefono.Size = new System.Drawing.Size(142, 17);
            this.lblNumeroTelefono.TabIndex = 4;
            this.lblNumeroTelefono.Text = "Número de Telefono:";
            // 
            // dtpFechaNacConsej
            // 
            this.dtpFechaNacConsej.CustomFormat = "";
            this.dtpFechaNacConsej.Enabled = false;
            this.dtpFechaNacConsej.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNacConsej.Location = new System.Drawing.Point(188, 88);
            this.dtpFechaNacConsej.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaNacConsej.Name = "dtpFechaNacConsej";
            this.dtpFechaNacConsej.Size = new System.Drawing.Size(135, 22);
            this.dtpFechaNacConsej.TabIndex = 3;
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
            // txtNombreConsejero
            // 
            this.txtNombreConsejero.Enabled = false;
            this.txtNombreConsejero.Location = new System.Drawing.Point(188, 33);
            this.txtNombreConsejero.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreConsejero.Name = "txtNombreConsejero";
            this.txtNombreConsejero.Size = new System.Drawing.Size(476, 22);
            this.txtNombreConsejero.TabIndex = 1;
            // 
            // lblNombreCompleto
            // 
            this.lblNombreCompleto.AutoSize = true;
            this.lblNombreCompleto.Location = new System.Drawing.Point(25, 37);
            this.lblNombreCompleto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreCompleto.Name = "lblNombreCompleto";
            this.lblNombreCompleto.Size = new System.Drawing.Size(156, 17);
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
            this.actividadToolStripMenuItem});
            this.menuAconsejadosPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuAconsejadosPrincipal.Name = "menuAconsejadosPrincipal";
            this.menuAconsejadosPrincipal.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuAconsejadosPrincipal.Size = new System.Drawing.Size(744, 30);
            this.menuAconsejadosPrincipal.TabIndex = 15;
            this.menuAconsejadosPrincipal.Text = "menuStrip1";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Enabled = false;
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.modificarToolStripMenuItem.Text = "Modificar";
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.modificarToolStripMenuItem_Click);
            // 
            // actividadToolStripMenuItem
            // 
            this.actividadToolStripMenuItem.Name = "actividadToolStripMenuItem";
            this.actividadToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.actividadToolStripMenuItem.Text = "Actividad";
            this.actividadToolStripMenuItem.Click += new System.EventHandler(this.actividadToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtGradoConsej);
            this.groupBox1.Controls.Add(this.txtObsConsej);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtCargoConsej);
            this.groupBox1.Controls.Add(this.txtEmpresaConsej);
            this.groupBox1.Controls.Add(this.txtSectorConsej);
            this.groupBox1.Controls.Add(this.txtAreasIntConsej);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtCorreoConsej);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(15, 369);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(696, 396);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Perfil Profesional";
            // 
            // txtGradoConsej
            // 
            this.txtGradoConsej.Enabled = false;
            this.txtGradoConsej.Location = new System.Drawing.Point(121, 47);
            this.txtGradoConsej.Name = "txtGradoConsej";
            this.txtGradoConsej.Size = new System.Drawing.Size(140, 22);
            this.txtGradoConsej.TabIndex = 19;
            // 
            // txtObsConsej
            // 
            this.txtObsConsej.Enabled = false;
            this.txtObsConsej.Location = new System.Drawing.Point(186, 292);
            this.txtObsConsej.Margin = new System.Windows.Forms.Padding(4);
            this.txtObsConsej.Multiline = true;
            this.txtObsConsej.Name = "txtObsConsej";
            this.txtObsConsej.Size = new System.Drawing.Size(451, 83);
            this.txtObsConsej.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(54, 295);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Observaciones";
            // 
            // txtCargoConsej
            // 
            this.txtCargoConsej.Enabled = false;
            this.txtCargoConsej.Location = new System.Drawing.Point(409, 92);
            this.txtCargoConsej.Margin = new System.Windows.Forms.Padding(4);
            this.txtCargoConsej.Name = "txtCargoConsej";
            this.txtCargoConsej.Size = new System.Drawing.Size(105, 22);
            this.txtCargoConsej.TabIndex = 16;
            this.txtCargoConsej.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEmpresaConsej
            // 
            this.txtEmpresaConsej.Enabled = false;
            this.txtEmpresaConsej.Location = new System.Drawing.Point(409, 45);
            this.txtEmpresaConsej.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmpresaConsej.Name = "txtEmpresaConsej";
            this.txtEmpresaConsej.Size = new System.Drawing.Size(105, 22);
            this.txtEmpresaConsej.TabIndex = 15;
            this.txtEmpresaConsej.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSectorConsej
            // 
            this.txtSectorConsej.Enabled = false;
            this.txtSectorConsej.Location = new System.Drawing.Point(121, 92);
            this.txtSectorConsej.Margin = new System.Windows.Forms.Padding(4);
            this.txtSectorConsej.Name = "txtSectorConsej";
            this.txtSectorConsej.Size = new System.Drawing.Size(140, 22);
            this.txtSectorConsej.TabIndex = 10;
            this.txtSectorConsej.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAreasIntConsej
            // 
            this.txtAreasIntConsej.Enabled = false;
            this.txtAreasIntConsej.Location = new System.Drawing.Point(186, 185);
            this.txtAreasIntConsej.Margin = new System.Windows.Forms.Padding(4);
            this.txtAreasIntConsej.Multiline = true;
            this.txtAreasIntConsej.Name = "txtAreasIntConsej";
            this.txtAreasIntConsej.Size = new System.Drawing.Size(451, 83);
            this.txtAreasIntConsej.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(54, 187);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Areas de interes:";
            // 
            // txtCorreoConsej
            // 
            this.txtCorreoConsej.Enabled = false;
            this.txtCorreoConsej.Location = new System.Drawing.Point(121, 137);
            this.txtCorreoConsej.Margin = new System.Windows.Forms.Padding(4);
            this.txtCorreoConsej.Name = "txtCorreoConsej";
            this.txtCorreoConsej.Size = new System.Drawing.Size(393, 22);
            this.txtCorreoConsej.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 141);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Correo:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(325, 92);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Cargo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 92);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Sector:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(325, 47);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Empresa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Grado:";
            // 
            // btnCancelarConsejero
            // 
            this.btnCancelarConsejero.Location = new System.Drawing.Point(606, 788);
            this.btnCancelarConsejero.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelarConsejero.Name = "btnCancelarConsejero";
            this.btnCancelarConsejero.Size = new System.Drawing.Size(100, 28);
            this.btnCancelarConsejero.TabIndex = 18;
            this.btnCancelarConsejero.Text = "Cancelar";
            this.btnCancelarConsejero.UseVisualStyleBackColor = true;
            this.btnCancelarConsejero.Click += new System.EventHandler(this.btnCancelarConsejero_Click_1);
            // 
            // btnAgregarConsejero
            // 
            this.btnAgregarConsejero.Location = new System.Drawing.Point(476, 788);
            this.btnAgregarConsejero.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarConsejero.Name = "btnAgregarConsejero";
            this.btnAgregarConsejero.Size = new System.Drawing.Size(100, 28);
            this.btnAgregarConsejero.TabIndex = 17;
            this.btnAgregarConsejero.Text = "Agregar";
            this.btnAgregarConsejero.UseVisualStyleBackColor = true;
            this.btnAgregarConsejero.Click += new System.EventHandler(this.btnAgregarConsejero_Click);
            // 
            // btnEliminarConsejero
            // 
            this.btnEliminarConsejero.Enabled = false;
            this.btnEliminarConsejero.Location = new System.Drawing.Point(41, 784);
            this.btnEliminarConsejero.Name = "btnEliminarConsejero";
            this.btnEliminarConsejero.Size = new System.Drawing.Size(93, 37);
            this.btnEliminarConsejero.TabIndex = 19;
            this.btnEliminarConsejero.Text = "Eliminar";
            this.btnEliminarConsejero.UseVisualStyleBackColor = true;
            this.btnEliminarConsejero.Click += new System.EventHandler(this.btnEliminarConsejero_Click);
            // 
            // frmAdministrarConsejeros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 869);
            this.Controls.Add(this.btnEliminarConsejero);
            this.Controls.Add(this.btnCancelarConsejero);
            this.Controls.Add(this.btnAgregarConsejero);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuAconsejadosPrincipal);
            this.Controls.Add(this.grpPersonal);
            this.Controls.Add(this.grpPerfilUniversitario);
            this.Name = "frmAdministrarConsejeros";
            this.Text = "Administrar Consejeros";
            this.Load += new System.EventHandler(this.frmAdministrarConsejeros_Load);
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
        private System.Windows.Forms.TextBox txtAreasIntConsej;
        private System.Windows.Forms.TextBox txtObsConsej;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCancelarConsejero;
        private System.Windows.Forms.Button btnAgregarConsejero;
        private System.Windows.Forms.TextBox txtEspecialidad;
        private System.Windows.Forms.TextBox txtGradoConsej;
        private System.Windows.Forms.Button btnEliminarConsejero;
    }
}