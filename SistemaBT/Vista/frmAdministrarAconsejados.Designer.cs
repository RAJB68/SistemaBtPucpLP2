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
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
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
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lblNumeroCiclo = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.cmbEspecialidad = new System.Windows.Forms.ComboBox();
            this.lblEspecialidad = new System.Windows.Forms.Label();
            this.lblCodigoAlumno = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.menuAconsejadosPrincipal.SuspendLayout();
            this.grpPersonal.SuspendLayout();
            this.grpPerfilUniversitario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
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
            this.menuAconsejadosPrincipal.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuAconsejadosPrincipal.Size = new System.Drawing.Size(739, 30);
            this.menuAconsejadosPrincipal.TabIndex = 0;
            this.menuAconsejadosPrincipal.Text = "menuStrip1";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Enabled = false;
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.guardarToolStripMenuItem.Text = "Guardar";
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.modificarToolStripMenuItem.Text = "Modificar";
            // 
            // vincularToolStripMenuItem
            // 
            this.vincularToolStripMenuItem.Name = "vincularToolStripMenuItem";
            this.vincularToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.vincularToolStripMenuItem.Text = "Vincular";
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
            this.grpPersonal.Controls.Add(this.textBox2);
            this.grpPersonal.Controls.Add(this.txtNumeroTelefono);
            this.grpPersonal.Controls.Add(this.lblNumeroTelefono);
            this.grpPersonal.Controls.Add(this.ftpFechaNacimiento);
            this.grpPersonal.Controls.Add(this.lblFechaNacimiento);
            this.grpPersonal.Controls.Add(this.txtNombreCompleto);
            this.grpPersonal.Controls.Add(this.lblNombreCompleto);
            this.grpPersonal.Location = new System.Drawing.Point(17, 35);
            this.grpPersonal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpPersonal.Name = "grpPersonal";
            this.grpPersonal.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpPersonal.Size = new System.Drawing.Size(696, 196);
            this.grpPersonal.TabIndex = 1;
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
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(107, 141);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(557, 22);
            this.textBox2.TabIndex = 8;
            // 
            // txtNumeroTelefono
            // 
            this.txtNumeroTelefono.Enabled = false;
            this.txtNumeroTelefono.Location = new System.Drawing.Point(492, 88);
            this.txtNumeroTelefono.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNumeroTelefono.Name = "txtNumeroTelefono";
            this.txtNumeroTelefono.Size = new System.Drawing.Size(172, 22);
            this.txtNumeroTelefono.TabIndex = 5;
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
            // ftpFechaNacimiento
            // 
            this.ftpFechaNacimiento.Enabled = false;
            this.ftpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ftpFechaNacimiento.Location = new System.Drawing.Point(188, 88);
            this.ftpFechaNacimiento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.txtNombreCompleto.Location = new System.Drawing.Point(188, 33);
            this.txtNombreCompleto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombreCompleto.Name = "txtNombreCompleto";
            this.txtNombreCompleto.Size = new System.Drawing.Size(476, 22);
            this.txtNombreCompleto.TabIndex = 1;
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
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(461, 641);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(100, 28);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(591, 641);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 28);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
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
            this.grpPerfilUniversitario.Location = new System.Drawing.Point(17, 238);
            this.grpPerfilUniversitario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpPerfilUniversitario.Name = "grpPerfilUniversitario";
            this.grpPerfilUniversitario.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpPerfilUniversitario.Size = new System.Drawing.Size(696, 259);
            this.grpPerfilUniversitario.TabIndex = 5;
            this.grpPerfilUniversitario.TabStop = false;
            this.grpPerfilUniversitario.Text = "Perfil Universitario";
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Location = new System.Drawing.Point(19, 135);
            this.lblObservaciones.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(100, 17);
            this.lblObservaciones.TabIndex = 13;
            this.lblObservaciones.Text = "Obervaciones:";
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(130, 131);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(528, 95);
            this.textBox4.TabIndex = 12;
            // 
            // lblNumeroCiclo
            // 
            this.lblNumeroCiclo.AutoSize = true;
            this.lblNumeroCiclo.Location = new System.Drawing.Point(25, 92);
            this.lblNumeroCiclo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumeroCiclo.Name = "lblNumeroCiclo";
            this.lblNumeroCiclo.Size = new System.Drawing.Size(42, 17);
            this.lblNumeroCiclo.TabIndex = 11;
            this.lblNumeroCiclo.Text = "Ciclo:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(89, 90);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(64, 22);
            this.numericUpDown1.TabIndex = 10;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(291, 88);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(373, 22);
            this.textBox1.TabIndex = 7;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(228, 92);
            this.lblCorreo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(55, 17);
            this.lblCorreo.TabIndex = 6;
            this.lblCorreo.Text = "Correo:";
            // 
            // cmbEspecialidad
            // 
            this.cmbEspecialidad.Enabled = false;
            this.cmbEspecialidad.FormattingEnabled = true;
            this.cmbEspecialidad.Location = new System.Drawing.Point(415, 40);
            this.cmbEspecialidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbEspecialidad.Name = "cmbEspecialidad";
            this.cmbEspecialidad.Size = new System.Drawing.Size(249, 24);
            this.cmbEspecialidad.TabIndex = 9;
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
            this.lblCodigoAlumno.Location = new System.Drawing.Point(25, 44);
            this.lblCodigoAlumno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigoAlumno.Name = "lblCodigoAlumno";
            this.lblCodigoAlumno.Size = new System.Drawing.Size(127, 17);
            this.lblCodigoAlumno.TabIndex = 7;
            this.lblCodigoAlumno.Text = "Código de Alumno:";
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(161, 40);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(105, 22);
            this.textBox3.TabIndex = 0;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmAdministrarAconsejados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 669);
            this.Controls.Add(this.grpPerfilUniversitario);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.grpPersonal);
            this.Controls.Add(this.menuAconsejadosPrincipal);
            this.MainMenuStrip = this.menuAconsejadosPrincipal;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label lblNumeroCiclo;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.ComboBox cmbEspecialidad;
        private System.Windows.Forms.Label lblEspecialidad;
        private System.Windows.Forms.Label lblCodigoAlumno;
        private System.Windows.Forms.TextBox textBox3;
    }
}