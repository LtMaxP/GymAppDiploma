namespace UI
{
    partial class Clientes
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
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.textBox_Buscar = new System.Windows.Forms.TextBox();
            this.labelBuscarUnUsuario = new System.Windows.Forms.Label();
            this.listView = new System.Windows.Forms.ListView();
            this.btn_Mostrar = new System.Windows.Forms.Button();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelApellido = new System.Windows.Forms.Label();
            this.labelDNI = new System.Windows.Forms.Label();
            this.labelCalle = new System.Windows.Forms.Label();
            this.labelNumero = new System.Windows.Forms.Label();
            this.labelSucursal = new System.Windows.Forms.Label();
            this.labelEstado = new System.Windows.Forms.Label();
            this.labelCodPostal = new System.Windows.Forms.Label();
            this.labelTelefono = new System.Windows.Forms.Label();
            this.labelFecha = new System.Windows.Forms.Label();
            this.labelRutina = new System.Windows.Forms.Label();
            this.labelEmpleadoACargo = new System.Windows.Forms.Label();
            this.btn_Alta = new System.Windows.Forms.Button();
            this.btn_Baja = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.textBox_Nombre = new System.Windows.Forms.TextBox();
            this.textBox_Apellido = new System.Windows.Forms.TextBox();
            this.textBox_Dni = new System.Windows.Forms.TextBox();
            this.textBox_Calle = new System.Windows.Forms.TextBox();
            this.textBox_Numero = new System.Windows.Forms.TextBox();
            this.textBox_Sucursal = new System.Windows.Forms.TextBox();
            this.textBox_Telefono = new System.Windows.Forms.TextBox();
            this.textBox_CodPost = new System.Windows.Forms.TextBox();
            this.textBox_Estado = new System.Windows.Forms.TextBox();
            this.textBox_Profesor = new System.Windows.Forms.TextBox();
            this.labelSalir = new System.Windows.Forms.Button();
            this.listRutina = new System.Windows.Forms.ListView();
            this.labelPeso = new System.Windows.Forms.Label();
            this.textBox_Peso = new System.Windows.Forms.TextBox();
            this.fechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Apellido = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Dni = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Location = new System.Drawing.Point(310, 16);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_Buscar.TabIndex = 0;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // textBox_Buscar
            // 
            this.textBox_Buscar.Location = new System.Drawing.Point(127, 18);
            this.textBox_Buscar.Name = "textBox_Buscar";
            this.textBox_Buscar.Size = new System.Drawing.Size(167, 20);
            this.textBox_Buscar.TabIndex = 1;
            // 
            // labelBuscarUnUsuario
            // 
            this.labelBuscarUnUsuario.AutoSize = true;
            this.labelBuscarUnUsuario.Location = new System.Drawing.Point(13, 21);
            this.labelBuscarUnUsuario.Name = "labelBuscarUnUsuario";
            this.labelBuscarUnUsuario.Size = new System.Drawing.Size(96, 13);
            this.labelBuscarUnUsuario.TabIndex = 2;
            this.labelBuscarUnUsuario.Text = "Nombre del Cliente";
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Nombre,
            this.Apellido,
            this.Dni});
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(16, 70);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(228, 231);
            this.listView.TabIndex = 3;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // btn_Mostrar
            // 
            this.btn_Mostrar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_Mostrar.Location = new System.Drawing.Point(95, 307);
            this.btn_Mostrar.Name = "btn_Mostrar";
            this.btn_Mostrar.Size = new System.Drawing.Size(75, 23);
            this.btn_Mostrar.TabIndex = 4;
            this.btn_Mostrar.Text = "Mostrar";
            this.btn_Mostrar.UseVisualStyleBackColor = true;
            this.btn_Mostrar.Click += new System.EventHandler(this.labelMostrar_Click);
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(261, 77);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(44, 13);
            this.labelNombre.TabIndex = 5;
            this.labelNombre.Text = "Nombre";
            // 
            // labelApellido
            // 
            this.labelApellido.AutoSize = true;
            this.labelApellido.Location = new System.Drawing.Point(262, 104);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(44, 13);
            this.labelApellido.TabIndex = 5;
            this.labelApellido.Text = "Apellido";
            // 
            // labelDNI
            // 
            this.labelDNI.AutoSize = true;
            this.labelDNI.Location = new System.Drawing.Point(261, 133);
            this.labelDNI.Name = "labelDNI";
            this.labelDNI.Size = new System.Drawing.Size(26, 13);
            this.labelDNI.TabIndex = 5;
            this.labelDNI.Text = "DNI";
            // 
            // labelCalle
            // 
            this.labelCalle.AutoSize = true;
            this.labelCalle.Location = new System.Drawing.Point(261, 162);
            this.labelCalle.Name = "labelCalle";
            this.labelCalle.Size = new System.Drawing.Size(30, 13);
            this.labelCalle.TabIndex = 5;
            this.labelCalle.Text = "Calle";
            // 
            // labelNumero
            // 
            this.labelNumero.AutoSize = true;
            this.labelNumero.Location = new System.Drawing.Point(261, 189);
            this.labelNumero.Name = "labelNumero";
            this.labelNumero.Size = new System.Drawing.Size(44, 13);
            this.labelNumero.TabIndex = 5;
            this.labelNumero.Text = "Numero";
            // 
            // labelSucursal
            // 
            this.labelSucursal.AutoSize = true;
            this.labelSucursal.Location = new System.Drawing.Point(557, 162);
            this.labelSucursal.Name = "labelSucursal";
            this.labelSucursal.Size = new System.Drawing.Size(48, 13);
            this.labelSucursal.TabIndex = 5;
            this.labelSucursal.Text = "Sucursal";
            this.labelSucursal.Click += new System.EventHandler(this.label9_Click);
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.Location = new System.Drawing.Point(557, 76);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(40, 13);
            this.labelEstado.TabIndex = 5;
            this.labelEstado.Text = "Estado";
            // 
            // labelCodPostal
            // 
            this.labelCodPostal.AutoSize = true;
            this.labelCodPostal.Location = new System.Drawing.Point(261, 216);
            this.labelCodPostal.Name = "labelCodPostal";
            this.labelCodPostal.Size = new System.Drawing.Size(55, 13);
            this.labelCodPostal.TabIndex = 5;
            this.labelCodPostal.Text = "CodPostal";
            // 
            // labelTelefono
            // 
            this.labelTelefono.AutoSize = true;
            this.labelTelefono.Location = new System.Drawing.Point(261, 241);
            this.labelTelefono.Name = "labelTelefono";
            this.labelTelefono.Size = new System.Drawing.Size(49, 13);
            this.labelTelefono.TabIndex = 5;
            this.labelTelefono.Text = "Telefono";
            this.labelTelefono.Click += new System.EventHandler(this.label9_Click);
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Location = new System.Drawing.Point(262, 267);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(108, 13);
            this.labelFecha.TabIndex = 5;
            this.labelFecha.Text = "Fecha de Nacimiento";
            this.labelFecha.Click += new System.EventHandler(this.label9_Click);
            // 
            // labelRutina
            // 
            this.labelRutina.AutoSize = true;
            this.labelRutina.Location = new System.Drawing.Point(592, 212);
            this.labelRutina.Name = "labelRutina";
            this.labelRutina.Size = new System.Drawing.Size(71, 13);
            this.labelRutina.TabIndex = 5;
            this.labelRutina.Text = "Rutina Actual";
            this.labelRutina.Click += new System.EventHandler(this.label9_Click);
            // 
            // labelEmpleadoACargo
            // 
            this.labelEmpleadoACargo.AutoSize = true;
            this.labelEmpleadoACargo.Location = new System.Drawing.Point(558, 188);
            this.labelEmpleadoACargo.Name = "labelEmpleadoACargo";
            this.labelEmpleadoACargo.Size = new System.Drawing.Size(46, 13);
            this.labelEmpleadoACargo.TabIndex = 5;
            this.labelEmpleadoACargo.Text = "Profesor";
            this.labelEmpleadoACargo.Click += new System.EventHandler(this.label9_Click);
            // 
            // btn_Alta
            // 
            this.btn_Alta.Location = new System.Drawing.Point(577, 344);
            this.btn_Alta.Name = "btn_Alta";
            this.btn_Alta.Size = new System.Drawing.Size(52, 23);
            this.btn_Alta.TabIndex = 6;
            this.btn_Alta.Text = "Alta";
            this.btn_Alta.UseVisualStyleBackColor = true;
            this.btn_Alta.Click += new System.EventHandler(this.labelAlta_Click);
            // 
            // btn_Baja
            // 
            this.btn_Baja.Location = new System.Drawing.Point(635, 344);
            this.btn_Baja.Name = "btn_Baja";
            this.btn_Baja.Size = new System.Drawing.Size(52, 23);
            this.btn_Baja.TabIndex = 7;
            this.btn_Baja.Text = "Baja";
            this.btn_Baja.UseVisualStyleBackColor = true;
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Location = new System.Drawing.Point(693, 344);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(59, 23);
            this.btn_Modificar.TabIndex = 8;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = true;
            // 
            // textBox_Nombre
            // 
            this.textBox_Nombre.Location = new System.Drawing.Point(393, 74);
            this.textBox_Nombre.Name = "textBox_Nombre";
            this.textBox_Nombre.Size = new System.Drawing.Size(100, 20);
            this.textBox_Nombre.TabIndex = 9;
            this.textBox_Nombre.TextChanged += new System.EventHandler(this.textBox_Nombre_TextChanged);
            // 
            // textBox_Apellido
            // 
            this.textBox_Apellido.Location = new System.Drawing.Point(393, 101);
            this.textBox_Apellido.Name = "textBox_Apellido";
            this.textBox_Apellido.Size = new System.Drawing.Size(100, 20);
            this.textBox_Apellido.TabIndex = 9;
            // 
            // textBox_Dni
            // 
            this.textBox_Dni.Location = new System.Drawing.Point(393, 130);
            this.textBox_Dni.Name = "textBox_Dni";
            this.textBox_Dni.Size = new System.Drawing.Size(100, 20);
            this.textBox_Dni.TabIndex = 9;
            // 
            // textBox_Calle
            // 
            this.textBox_Calle.Location = new System.Drawing.Point(393, 159);
            this.textBox_Calle.Name = "textBox_Calle";
            this.textBox_Calle.Size = new System.Drawing.Size(100, 20);
            this.textBox_Calle.TabIndex = 9;
            // 
            // textBox_Numero
            // 
            this.textBox_Numero.Location = new System.Drawing.Point(393, 186);
            this.textBox_Numero.Name = "textBox_Numero";
            this.textBox_Numero.Size = new System.Drawing.Size(100, 20);
            this.textBox_Numero.TabIndex = 9;
            // 
            // textBox_Sucursal
            // 
            this.textBox_Sucursal.Location = new System.Drawing.Point(646, 155);
            this.textBox_Sucursal.Name = "textBox_Sucursal";
            this.textBox_Sucursal.Size = new System.Drawing.Size(106, 20);
            this.textBox_Sucursal.TabIndex = 9;
            // 
            // textBox_Telefono
            // 
            this.textBox_Telefono.Location = new System.Drawing.Point(393, 238);
            this.textBox_Telefono.Name = "textBox_Telefono";
            this.textBox_Telefono.Size = new System.Drawing.Size(100, 20);
            this.textBox_Telefono.TabIndex = 9;
            // 
            // textBox_CodPost
            // 
            this.textBox_CodPost.Location = new System.Drawing.Point(393, 212);
            this.textBox_CodPost.Name = "textBox_CodPost";
            this.textBox_CodPost.Size = new System.Drawing.Size(100, 20);
            this.textBox_CodPost.TabIndex = 9;
            // 
            // textBox_Estado
            // 
            this.textBox_Estado.Location = new System.Drawing.Point(646, 47);
            this.textBox_Estado.Name = "textBox_Estado";
            this.textBox_Estado.Size = new System.Drawing.Size(106, 20);
            this.textBox_Estado.TabIndex = 9;
            // 
            // textBox_Profesor
            // 
            this.textBox_Profesor.Location = new System.Drawing.Point(646, 185);
            this.textBox_Profesor.Name = "textBox_Profesor";
            this.textBox_Profesor.Size = new System.Drawing.Size(106, 20);
            this.textBox_Profesor.TabIndex = 9;
            // 
            // labelSalir
            // 
            this.labelSalir.Location = new System.Drawing.Point(670, 410);
            this.labelSalir.Name = "labelSalir";
            this.labelSalir.Size = new System.Drawing.Size(82, 28);
            this.labelSalir.TabIndex = 10;
            this.labelSalir.Text = "Salir";
            this.labelSalir.UseVisualStyleBackColor = true;
            this.labelSalir.Click += new System.EventHandler(this.button6_Click);
            // 
            // listRutina
            // 
            this.listRutina.HideSelection = false;
            this.listRutina.Location = new System.Drawing.Point(514, 234);
            this.listRutina.Name = "listRutina";
            this.listRutina.Size = new System.Drawing.Size(246, 73);
            this.listRutina.TabIndex = 3;
            this.listRutina.UseCompatibleStateImageBehavior = false;
            // 
            // labelPeso
            // 
            this.labelPeso.AutoSize = true;
            this.labelPeso.Location = new System.Drawing.Point(262, 292);
            this.labelPeso.Name = "labelPeso";
            this.labelPeso.Size = new System.Drawing.Size(47, 13);
            this.labelPeso.TabIndex = 5;
            this.labelPeso.Text = "Peso Kg";
            this.labelPeso.Click += new System.EventHandler(this.label9_Click);
            // 
            // textBox_Peso
            // 
            this.textBox_Peso.Location = new System.Drawing.Point(393, 289);
            this.textBox_Peso.Name = "textBox_Peso";
            this.textBox_Peso.Size = new System.Drawing.Size(100, 20);
            this.textBox_Peso.TabIndex = 9;
            // 
            // fechaNacimiento
            // 
            this.fechaNacimiento.Cursor = System.Windows.Forms.Cursors.PanSE;
            this.fechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaNacimiento.ImeMode = System.Windows.Forms.ImeMode.On;
            this.fechaNacimiento.Location = new System.Drawing.Point(393, 264);
            this.fechaNacimiento.MinDate = new System.DateTime(1889, 1, 1, 0, 0, 0, 0);
            this.fechaNacimiento.Name = "fechaNacimiento";
            this.fechaNacimiento.Size = new System.Drawing.Size(100, 20);
            this.fechaNacimiento.TabIndex = 11;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Alta",
            "Baja"});
            this.comboBox1.Location = new System.Drawing.Point(646, 73);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(110, 21);
            this.comboBox1.TabIndex = 12;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 35;
            // 
            // Nombre
            // 
            this.Nombre.Text = "Nombre";
            // 
            // Apellido
            // 
            this.Apellido.Text = "Apellido";
            this.Apellido.Width = 69;
            // 
            // Dni
            // 
            this.Dni.Text = "Dni";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Alta",
            "Baja"});
            this.comboBox2.Location = new System.Drawing.Point(646, 104);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(110, 21);
            this.comboBox2.TabIndex = 12;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Alta",
            "Baja"});
            this.comboBox3.Location = new System.Drawing.Point(646, 129);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(110, 21);
            this.comboBox3.TabIndex = 12;
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.fechaNacimiento);
            this.Controls.Add(this.labelSalir);
            this.Controls.Add(this.textBox_Profesor);
            this.Controls.Add(this.textBox_Estado);
            this.Controls.Add(this.textBox_Sucursal);
            this.Controls.Add(this.textBox_CodPost);
            this.Controls.Add(this.textBox_Peso);
            this.Controls.Add(this.textBox_Calle);
            this.Controls.Add(this.textBox_Telefono);
            this.Controls.Add(this.textBox_Dni);
            this.Controls.Add(this.textBox_Numero);
            this.Controls.Add(this.textBox_Apellido);
            this.Controls.Add(this.textBox_Nombre);
            this.Controls.Add(this.btn_Modificar);
            this.Controls.Add(this.btn_Baja);
            this.Controls.Add(this.btn_Alta);
            this.Controls.Add(this.labelEmpleadoACargo);
            this.Controls.Add(this.labelRutina);
            this.Controls.Add(this.labelPeso);
            this.Controls.Add(this.labelFecha);
            this.Controls.Add(this.labelTelefono);
            this.Controls.Add(this.labelCodPostal);
            this.Controls.Add(this.labelSucursal);
            this.Controls.Add(this.labelEstado);
            this.Controls.Add(this.labelNumero);
            this.Controls.Add(this.labelCalle);
            this.Controls.Add(this.labelDNI);
            this.Controls.Add(this.labelApellido);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.btn_Mostrar);
            this.Controls.Add(this.listRutina);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.labelBuscarUnUsuario);
            this.Controls.Add(this.textBox_Buscar);
            this.Controls.Add(this.btn_Buscar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Clientes";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.Clientes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.TextBox textBox_Buscar;
        private System.Windows.Forms.Label labelBuscarUnUsuario;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.Button btn_Mostrar;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.Label labelDNI;
        private System.Windows.Forms.Label labelCalle;
        private System.Windows.Forms.Label labelNumero;
        private System.Windows.Forms.Label labelSucursal;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.Label labelCodPostal;
        private System.Windows.Forms.Label labelTelefono;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.Label labelRutina;
        private System.Windows.Forms.Label labelEmpleadoACargo;
        private System.Windows.Forms.Button btn_Alta;
        private System.Windows.Forms.Button btn_Baja;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.TextBox textBox_Nombre;
        private System.Windows.Forms.TextBox textBox_Apellido;
        private System.Windows.Forms.TextBox textBox_Dni;
        private System.Windows.Forms.TextBox textBox_Calle;
        private System.Windows.Forms.TextBox textBox_Numero;
        private System.Windows.Forms.TextBox textBox_Sucursal;
        private System.Windows.Forms.TextBox textBox_Telefono;
        private System.Windows.Forms.TextBox textBox_CodPost;
        private System.Windows.Forms.TextBox textBox_Estado;
        private System.Windows.Forms.TextBox textBox_Profesor;
        private System.Windows.Forms.Button labelSalir;
        private System.Windows.Forms.ListView listRutina;
        private System.Windows.Forms.Label labelPeso;
        private System.Windows.Forms.TextBox textBox_Peso;
        private System.Windows.Forms.DateTimePicker fechaNacimiento;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Nombre;
        private System.Windows.Forms.ColumnHeader Apellido;
        private System.Windows.Forms.ColumnHeader Dni;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
    }
}