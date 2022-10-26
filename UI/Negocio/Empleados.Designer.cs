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
            this.txtbox_Apellido = new System.Windows.Forms.TextBox();
            this.txtbox_Nombre = new System.Windows.Forms.TextBox();
            this.labelModificar = new System.Windows.Forms.Button();
            this.labelBaja = new System.Windows.Forms.Button();
            this.labelAlta = new System.Windows.Forms.Button();
            this.labelEspecialidades = new System.Windows.Forms.Label();
            this.labelEstado = new System.Windows.Forms.Label();
            this.labelApellido = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelMostrar = new System.Windows.Forms.Button();
            this.labelBuscarUnUsuario = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbox_Sueldo = new System.Windows.Forms.TextBox();
            this.cmbBoxEmpleado = new System.Windows.Forms.ComboBox();
            this.lbl_dni = new System.Windows.Forms.Label();
            this.txtBox_DNI = new System.Windows.Forms.TextBox();
            this.cmb_Estado = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelSalir
            // 
            this.labelSalir.Location = new System.Drawing.Point(410, 442);
            this.labelSalir.Name = "labelSalir";
            this.labelSalir.Size = new System.Drawing.Size(85, 34);
            this.labelSalir.TabIndex = 45;
            this.labelSalir.Text = "Salir";
            this.labelSalir.UseVisualStyleBackColor = true;
            this.labelSalir.Click += new System.EventHandler(this.labelSalir_Click);
            // 
            // txtbox_Apellido
            // 
            this.txtbox_Apellido.Location = new System.Drawing.Point(160, 131);
            this.txtbox_Apellido.Name = "txtbox_Apellido";
            this.txtbox_Apellido.Size = new System.Drawing.Size(199, 20);
            this.txtbox_Apellido.TabIndex = 42;
            // 
            // txtbox_Nombre
            // 
            this.txtbox_Nombre.Location = new System.Drawing.Point(160, 86);
            this.txtbox_Nombre.Name = "txtbox_Nombre";
            this.txtbox_Nombre.Size = new System.Drawing.Size(199, 20);
            this.txtbox_Nombre.TabIndex = 43;
            // 
            // labelModificar
            // 
            this.labelModificar.Location = new System.Drawing.Point(244, 346);
            this.labelModificar.Name = "labelModificar";
            this.labelModificar.Size = new System.Drawing.Size(64, 23);
            this.labelModificar.TabIndex = 32;
            this.labelModificar.Text = "Modificar";
            this.labelModificar.UseVisualStyleBackColor = true;
            // 
            // labelBaja
            // 
            this.labelBaja.Location = new System.Drawing.Point(189, 346);
            this.labelBaja.Name = "labelBaja";
            this.labelBaja.Size = new System.Drawing.Size(49, 23);
            this.labelBaja.TabIndex = 31;
            this.labelBaja.Text = "Baja";
            this.labelBaja.UseVisualStyleBackColor = true;
            this.labelBaja.Click += new System.EventHandler(this.labelBaja_Click);
            // 
            // labelAlta
            // 
            this.labelAlta.Location = new System.Drawing.Point(129, 346);
            this.labelAlta.Name = "labelAlta";
            this.labelAlta.Size = new System.Drawing.Size(54, 23);
            this.labelAlta.TabIndex = 30;
            this.labelAlta.Text = "Alta";
            this.labelAlta.UseVisualStyleBackColor = true;
            this.labelAlta.Click += new System.EventHandler(this.labelAlta_Click);
            // 
            // labelEspecialidades
            // 
            this.labelEspecialidades.AutoSize = true;
            this.labelEspecialidades.Location = new System.Drawing.Point(100, 251);
            this.labelEspecialidades.Name = "labelEspecialidades";
            this.labelEspecialidades.Size = new System.Drawing.Size(43, 13);
            this.labelEspecialidades.TabIndex = 29;
            this.labelEspecialidades.Text = "Trabajo";
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.Location = new System.Drawing.Point(100, 208);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(40, 13);
            this.labelEstado.TabIndex = 22;
            this.labelEstado.Text = "Estado";
            // 
            // labelApellido
            // 
            this.labelApellido.AutoSize = true;
            this.labelApellido.Location = new System.Drawing.Point(100, 134);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(44, 13);
            this.labelApellido.TabIndex = 18;
            this.labelApellido.Text = "Apellido";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(100, 89);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(44, 13);
            this.labelNombre.TabIndex = 17;
            this.labelNombre.Text = "Nombre";
            // 
            // labelMostrar
            // 
            this.labelMostrar.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelMostrar.Location = new System.Drawing.Point(303, 39);
            this.labelMostrar.Name = "labelMostrar";
            this.labelMostrar.Size = new System.Drawing.Size(88, 23);
            this.labelMostrar.TabIndex = 16;
            this.labelMostrar.Text = "Mostrar";
            this.labelMostrar.UseVisualStyleBackColor = true;
            // 
            // labelBuscarUnUsuario
            // 
            this.labelBuscarUnUsuario.AutoSize = true;
            this.labelBuscarUnUsuario.Location = new System.Drawing.Point(48, 44);
            this.labelBuscarUnUsuario.Name = "labelBuscarUnUsuario";
            this.labelBuscarUnUsuario.Size = new System.Drawing.Size(54, 13);
            this.labelBuscarUnUsuario.TabIndex = 13;
            this.labelBuscarUnUsuario.Text = "Empleado";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(160, 248);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(199, 21);
            this.comboBox1.TabIndex = 46;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 296);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "Sueldo";
            // 
            // txtbox_Sueldo
            // 
            this.txtbox_Sueldo.Location = new System.Drawing.Point(160, 288);
            this.txtbox_Sueldo.Name = "txtbox_Sueldo";
            this.txtbox_Sueldo.Size = new System.Drawing.Size(199, 20);
            this.txtbox_Sueldo.TabIndex = 48;
            // 
            // cmbBoxEmpleado
            // 
            this.cmbBoxEmpleado.FormattingEnabled = true;
            this.cmbBoxEmpleado.Location = new System.Drawing.Point(108, 41);
            this.cmbBoxEmpleado.Name = "cmbBoxEmpleado";
            this.cmbBoxEmpleado.Size = new System.Drawing.Size(176, 21);
            this.cmbBoxEmpleado.TabIndex = 46;
            this.cmbBoxEmpleado.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lbl_dni
            // 
            this.lbl_dni.AutoSize = true;
            this.lbl_dni.Location = new System.Drawing.Point(100, 171);
            this.lbl_dni.Name = "lbl_dni";
            this.lbl_dni.Size = new System.Drawing.Size(26, 13);
            this.lbl_dni.TabIndex = 18;
            this.lbl_dni.Text = "DNI";
            // 
            // txtBox_DNI
            // 
            this.txtBox_DNI.Location = new System.Drawing.Point(160, 168);
            this.txtBox_DNI.Name = "txtBox_DNI";
            this.txtBox_DNI.Size = new System.Drawing.Size(199, 20);
            this.txtBox_DNI.TabIndex = 42;
            // 
            // cmb_Estado
            // 
            this.cmb_Estado.FormattingEnabled = true;
            this.cmb_Estado.Location = new System.Drawing.Point(160, 205);
            this.cmb_Estado.Name = "cmb_Estado";
            this.cmb_Estado.Size = new System.Drawing.Size(199, 21);
            this.cmb_Estado.TabIndex = 46;
            this.cmb_Estado.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 488);
            this.Controls.Add(this.txtbox_Sueldo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbBoxEmpleado);
            this.Controls.Add(this.cmb_Estado);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.labelSalir);
            this.Controls.Add(this.txtBox_DNI);
            this.Controls.Add(this.txtbox_Apellido);
            this.Controls.Add(this.txtbox_Nombre);
            this.Controls.Add(this.labelModificar);
            this.Controls.Add(this.labelBaja);
            this.Controls.Add(this.labelAlta);
            this.Controls.Add(this.labelEspecialidades);
            this.Controls.Add(this.lbl_dni);
            this.Controls.Add(this.labelEstado);
            this.Controls.Add(this.labelApellido);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.labelMostrar);
            this.Controls.Add(this.labelBuscarUnUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Empleados";
            this.Text = "Empleados";
            this.Load += new System.EventHandler(this.Empleados_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button labelSalir;
        private System.Windows.Forms.TextBox txtbox_Apellido;
        private System.Windows.Forms.TextBox txtbox_Nombre;
        private System.Windows.Forms.Button labelModificar;
        private System.Windows.Forms.Button labelBaja;
        private System.Windows.Forms.Button labelAlta;
        private System.Windows.Forms.Label labelEspecialidades;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Button labelMostrar;
        private System.Windows.Forms.Label labelBuscarUnUsuario;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbox_Sueldo;
        private System.Windows.Forms.ComboBox cmbBoxEmpleado;
        private System.Windows.Forms.Label lbl_dni;
        private System.Windows.Forms.TextBox txtBox_DNI;
        private System.Windows.Forms.ComboBox cmb_Estado;
    }
}