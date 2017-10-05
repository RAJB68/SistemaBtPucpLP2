namespace Vista
{
    partial class frmAgregarActividad
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
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.tabActividad = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpFechaProg = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtLugar = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.tabActividad.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(119, 40);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(532, 22);
            this.txtCodigo.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Código PUCP:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(84, 12);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(567, 22);
            this.txtNombre.TabIndex = 5;
            // 
            // tabActividad
            // 
            this.tabActividad.Controls.Add(this.tabPage1);
            this.tabActividad.Controls.Add(this.tabPage2);
            this.tabActividad.Location = new System.Drawing.Point(12, 215);
            this.tabActividad.Name = "tabActividad";
            this.tabActividad.SelectedIndex = 0;
            this.tabActividad.Size = new System.Drawing.Size(643, 272);
            this.tabActividad.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.txtLugar);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(635, 243);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cumpleaños";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBox3);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(635, 243);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Presentacion";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Titulo de la Actividad:";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(166, 71);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(485, 22);
            this.txtTitulo.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Fecha Programada:";
            // 
            // dtpFechaProg
            // 
            this.dtpFechaProg.Location = new System.Drawing.Point(167, 104);
            this.dtpFechaProg.Name = "dtpFechaProg";
            this.dtpFechaProg.Size = new System.Drawing.Size(200, 22);
            this.dtpFechaProg.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(373, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Estado:";
            // 
            // cbEstado
            // 
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Location = new System.Drawing.Point(435, 104);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(216, 24);
            this.cbEstado.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Descripcion:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(112, 138);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(539, 71);
            this.textBox1.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Lugar de Celebración:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "Dedicatoria:";
            // 
            // txtLugar
            // 
            this.txtLugar.Location = new System.Drawing.Point(162, 43);
            this.txtLugar.Name = "txtLugar";
            this.txtLugar.Size = new System.Drawing.Size(467, 22);
            this.txtLugar.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(162, 113);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(467, 124);
            this.textBox2.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(198, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Resultado de la Presentacion:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(212, 100);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(417, 68);
            this.textBox3.TabIndex = 1;
            // 
            // frmAgregarActividad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 499);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpFechaProg);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tabActividad);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombre);
            this.Name = "frmAgregarActividad";
            this.RightToLeftLayout = true;
            this.Text = "Agregar una Actividad";
            this.tabActividad.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TabControl tabActividad;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpFechaProg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtLugar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label9;
    }
}