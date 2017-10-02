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
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vincularToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actividadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpPersonal = new System.Windows.Forms.GroupBox();
            this.lblNombreCompleto = new System.Windows.Forms.Label();
            this.txtNombreCompleto = new System.Windows.Forms.TextBox();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.ftpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.lblNumeroTelefono = new System.Windows.Forms.Label();
            this.txtNumeroTelefono = new System.Windows.Forms.TextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grpPerfilUniversitario = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblCodigoAlumno = new System.Windows.Forms.Label();
            this.lblEspecialidad = new System.Windows.Forms.Label();
            this.cmbEspecialidad = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lblNumeroCiclo = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.menuAconsejadosPrincipal.SuspendLayout();
            this.grpPersonal.SuspendLayout();
            this.grpPerfilUniversitario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuAconsejadosPrincipal
            // 
            this.menuAconsejadosPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.guardarToolStripMenuItem,
            this.modificarToolStripMenuItem,
            this.vincularToolStripMenuItem,
            this.actividadToolStripMenuItem});
            this.menuAconsejadosPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuAconsejadosPrincipal.Name = "menuAconsejadosPrincipal";
            this.menuAconsejadosPrincipal.Size = new System.Drawing.Size(547, 24);
            this.menuAconsejadosPrincipal.TabIndex = 0;
            this.menuAconsejadosPrincipal.Text = "menuStrip1";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Enabled = false;
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.guardarToolStripMenuItem.Text = "Guardar";
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.modificarToolStripMenuItem.Text = "Modificar";
            // 
            // vincularToolStripMenuItem
            // 
            this.vincularToolStripMenuItem.Name = "vincularToolStripMenuItem";
            this.vincularToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.vincularToolStripMenuItem.Text = "Vincular";
            // 
            // actividadToolStripMenuItem
            // 
            this.actividadToolStripMenuItem.Name = "actividadToolStripMenuItem";
            this.actividadToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.actividadToolStripMenuItem.Text = "Actividad";
            // 
            // grpPersonal
            // 
            this.grpPersonal.AutoSize = true;
            this.grpPersonal.Controls.Add(this.label2);
            this.grpPersonal.Controls.Add(this.textBox2);
            this.grpPersonal.Controls.Add(this.txtNumeroTelefono);
            this.grpPersonal.Controls.Add(this.lblNumeroTelefono);
            this.grpPersonal.Controls.Add(this.ftpFechaNacimiento);
            this.grpPersonal.Controls.Add(this.lblFechaNacimiento);
            this.grpPersonal.Controls.Add(this.txtNombreCompleto);
            this.grpPersonal.Controls.Add(this.lblNombreCompleto);
            this.grpPersonal.Location = new System.Drawing.Point(13, 28);
            this.grpPersonal.Name = "grpPersonal";
            this.grpPersonal.Size = new System.Drawing.Size(522, 159);
            this.grpPersonal.TabIndex = 1;
            this.grpPersonal.TabStop = false;
            this.grpPersonal.Text = "Datos Personales";
            // 
            // lblNombreCompleto
            // 
            this.lblNombreCompleto.AutoSize = true;
            this.lblNombreCompleto.Location = new System.Drawing.Point(19, 30);
            this.lblNombreCompleto.Name = "lblNombreCompleto";
            this.lblNombreCompleto.Size = new System.Drawing.Size(115, 13);
            this.lblNombreCompleto.TabIndex = 0;
            this.lblNombreCompleto.Text = "Nombres y Apellidos(*):";
            // 
            // txtNombreCompleto
            // 
            this.txtNombreCompleto.Enabled = false;
            this.txtNombreCompleto.Location = new System.Drawing.Point(141, 27);
            this.txtNombreCompleto.Name = "txtNombreCompleto";
            this.txtNombreCompleto.Size = new System.Drawing.Size(358, 20);
            this.txtNombreCompleto.TabIndex = 1;
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
            // ftpFechaNacimiento
            // 
            this.ftpFechaNacimiento.Enabled = false;
            this.ftpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ftpFechaNacimiento.Location = new System.Drawing.Point(141, 72);
            this.ftpFechaNacimiento.Name = "ftpFechaNacimiento";
            this.ftpFechaNacimiento.Size = new System.Drawing.Size(102, 20);
            this.ftpFechaNacimiento.TabIndex = 3;
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
            // txtNumeroTelefono
            // 
            this.txtNumeroTelefono.Enabled = false;
            this.txtNumeroTelefono.Location = new System.Drawing.Point(369, 72);
            this.txtNumeroTelefono.Name = "txtNumeroTelefono";
            this.txtNumeroTelefono.Size = new System.Drawing.Size(130, 20);
            this.txtNumeroTelefono.TabIndex = 5;
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
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(218, 72);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(281, 20);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(80, 115);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(419, 20);
            this.textBox2.TabIndex = 8;
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
            // grpPerfilUniversitario
            // 
            this.grpPerfilUniversitario.Controls.Add(this.lblObservaciones);
            this.grpPerfilUniversitario.Controls.Add(this.textBox4);
            this.grpPerfilUniversitario.Controls.Add(this.lblNumeroCiclo);
            this.grpPerfilUniversitario.Controls.Add(this.numericUpDown1);
            this.grpPerfilUniversitario.Controls.Add(this.textBox1);
            this.grpPerfilUniversitario.Controls.Add(this.lblCorreo);
            this.grpPerfilUniversitario.Controls.Add(this.cmbEspecialidad);
            this.grpPerfilUniversitario.Controls.Add(this.lblEspecialidad);
            this.grpPerfilUniversitario.Controls.Add(this.lblCodigoAlumno);
            this.grpPerfilUniversitario.Controls.Add(this.textBox3);
            this.grpPerfilUniversitario.Location = new System.Drawing.Point(13, 194);
            this.grpPerfilUniversitario.Name = "grpPerfilUniversitario";
            this.grpPerfilUniversitario.Size = new System.Drawing.Size(522, 210);
            this.grpPerfilUniversitario.TabIndex = 2;
            this.grpPerfilUniversitario.TabStop = false;
            this.grpPerfilUniversitario.Text = "Perfil Universitario";
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(121, 33);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(80, 20);
            this.textBox3.TabIndex = 0;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // lblEspecialidad
            // 
            this.lblEspecialidad.AutoSize = true;
            this.lblEspecialidad.Location = new System.Drawing.Point(225, 36);
            this.lblEspecialidad.Name = "lblEspecialidad";
            this.lblEspecialidad.Size = new System.Drawing.Size(80, 13);
            this.lblEspecialidad.TabIndex = 8;
            this.lblEspecialidad.Text = "Especialidad(*):";
            // 
            // cmbEspecialidad
            // 
            this.cmbEspecialidad.FormattingEnabled = true;
            this.cmbEspecialidad.Location = new System.Drawing.Point(311, 33);
            this.cmbEspecialidad.Name = "cmbEspecialidad";
            this.cmbEspecialidad.Size = new System.Drawing.Size(188, 21);
            this.cmbEspecialidad.TabIndex = 9;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(67, 73);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(48, 20);
            this.numericUpDown1.TabIndex = 10;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
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
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(102, 112);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(397, 78);
            this.textBox4.TabIndex = 12;
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Location = new System.Drawing.Point(19, 115);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(76, 13);
            this.lblObservaciones.TabIndex = 13;
            this.lblObservaciones.Text = "Obervaciones:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(324, 412);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(420, 412);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // frmAdministrarAconsejados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 447);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.grpPerfilUniversitario);
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
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuAconsejadosPrincipal;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vincularToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actividadToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpPersonal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TextBox txtNumeroTelefono;
        private System.Windows.Forms.Label lblNumeroTelefono;
        private System.Windows.Forms.DateTimePicker ftpFechaNacimiento;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.TextBox txtNombreCompleto;
        private System.Windows.Forms.Label lblNombreCompleto;
        private System.Windows.Forms.GroupBox grpPerfilUniversitario;
        private System.Windows.Forms.Label lblNumeroCiclo;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ComboBox cmbEspecialidad;
        private System.Windows.Forms.Label lblEspecialidad;
        private System.Windows.Forms.Label lblCodigoAlumno;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblObservaciones;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCancelar;
    }
}