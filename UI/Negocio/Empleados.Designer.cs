namespace UI
{
    partial class Empleados
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
            this.labelSalir = new System.Windows.Forms.Button();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelModificar = new System.Windows.Forms.Button();
            this.labelBaja = new System.Windows.Forms.Button();
            this.labelAlta = new System.Windows.Forms.Button();
            this.labelEspecialidades = new System.Windows.Forms.Label();
            this.labelEstado = new System.Windows.Forms.Label();
            this.labelApellido = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelMostrar = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.labelBuscarUnUsuario = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelBuscar = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelSalir
            // 
            this.labelSalir.Location = new System.Drawing.Point(473, 419);
            this.labelSalir.Name = "labelSalir";
            this.labelSalir.Size = new System.Drawing.Size(85, 34);
            this.labelSalir.TabIndex = 45;
            this.labelSalir.Text = "Salir";
            this.labelSalir.UseVisualStyleBackColor = true;
            this.labelSalir.Click += new System.EventHandler(this.labelSalir_Click);
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(275, 216);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(148, 20);
            this.textBox14.TabIndex = 34;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(275, 169);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(148, 20);
            this.textBox3.TabIndex = 42;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(275, 124);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(148, 20);
            this.textBox2.TabIndex = 43;
            // 
            // labelModificar
            // 
            this.labelModificar.Location = new System.Drawing.Point(359, 357);
            this.labelModificar.Name = "labelModificar";
            this.labelModificar.Size = new System.Drawing.Size(64, 23);
            this.labelModificar.TabIndex = 32;
            this.labelModificar.Text = "Modificar";
            this.labelModificar.UseVisualStyleBackColor = true;
            // 
            // labelBaja
            // 
            this.labelBaja.Location = new System.Drawing.Point(304, 357);
            this.labelBaja.Name = "labelBaja";
            this.labelBaja.Size = new System.Drawing.Size(49, 23);
            this.labelBaja.TabIndex = 31;
            this.labelBaja.Text = "Baja";
            this.labelBaja.UseVisualStyleBackColor = true;
            // 
            // labelAlta
            // 
            this.labelAlta.Location = new System.Drawing.Point(244, 357);
            this.labelAlta.Name = "labelAlta";
            this.labelAlta.Size = new System.Drawing.Size(54, 23);
            this.labelAlta.TabIndex = 30;
            this.labelAlta.Text = "Alta";
            this.labelAlta.UseVisualStyleBackColor = true;
            // 
            // labelEspecialidades
            // 
            this.labelEspecialidades.AutoSize = true;
            this.labelEspecialidades.Location = new System.Drawing.Point(215, 262);
            this.labelEspecialidades.Name = "labelEspecialidades";
            this.labelEspecialidades.Size = new System.Drawing.Size(43, 13);
            this.labelEspecialidades.TabIndex = 29;
            this.labelEspecialidades.Text = "Trabajo";
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.Location = new System.Drawing.Point(215, 219);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(40, 13);
            this.labelEstado.TabIndex = 22;
            this.labelEstado.Text = "Estado";
            // 
            // labelApellido
            // 
            this.labelApellido.AutoSize = true;
            this.labelApellido.Location = new System.Drawing.Point(215, 172);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(44, 13);
            this.labelApellido.TabIndex = 18;
            this.labelApellido.Text = "Apellido";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(215, 127);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(44, 13);
            this.labelNombre.TabIndex = 17;
            this.labelNombre.Text = "Nombre";
            // 
            // labelMostrar
            // 
            this.labelMostrar.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelMostrar.Location = new System.Drawing.Point(23, 357);
            this.labelMostrar.Name = "labelMostrar";
            this.labelMostrar.Size = new System.Drawing.Size(106, 23);
            this.labelMostrar.TabIndex = 16;
            this.labelMostrar.Text = "Mostrar datos -->";
            this.labelMostrar.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 86);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(151, 253);
            this.listView1.TabIndex = 14;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // labelBuscarUnUsuario
            // 
            this.labelBuscarUnUsuario.AutoSize = true;
            this.labelBuscarUnUsuario.Location = new System.Drawing.Point(39, 44);
            this.labelBuscarUnUsuario.Name = "labelBuscarUnUsuario";
            this.labelBuscarUnUsuario.Size = new System.Drawing.Size(100, 13);
            this.labelBuscarUnUsuario.TabIndex = 13;
            this.labelBuscarUnUsuario.Text = "Nombre del Usuario";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(153, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(167, 20);
            this.textBox1.TabIndex = 12;
            // 
            // labelBuscar
            // 
            this.labelBuscar.Location = new System.Drawing.Point(336, 39);
            this.labelBuscar.Name = "labelBuscar";
            this.labelBuscar.Size = new System.Drawing.Size(75, 23);
            this.labelBuscar.TabIndex = 11;
            this.labelBuscar.Text = "Buscar";
            this.labelBuscar.UseVisualStyleBackColor = true;
            this.labelBuscar.Click += new System.EventHandler(this.labelBuscar_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(275, 259);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(148, 21);
            this.comboBox1.TabIndex = 46;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(215, 307);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "Sueldo";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(275, 299);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(148, 20);
            this.textBox4.TabIndex = 48;
            // 
            // Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 474);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.labelSalir);
            this.Controls.Add(this.textBox14);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.labelModificar);
            this.Controls.Add(this.labelBaja);
            this.Controls.Add(this.labelAlta);
            this.Controls.Add(this.labelEspecialidades);
            this.Controls.Add(this.labelEstado);
            this.Controls.Add(this.labelApellido);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.labelMostrar);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.labelBuscarUnUsuario);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelBuscar);
            this.Name = "Empleados";
            this.Text = "Empleados";
            this.Load += new System.EventHandler(this.Empleados_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button labelSalir;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button labelModificar;
        private System.Windows.Forms.Button labelBaja;
        private System.Windows.Forms.Button labelAlta;
        private System.Windows.Forms.Label labelEspecialidades;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Button labelMostrar;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label labelBuscarUnUsuario;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button labelBuscar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox4;
    }
}