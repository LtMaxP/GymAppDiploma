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
            this.components = new System.ComponentModel.Container();
            this.labelBuscar = new System.Windows.Forms.Button();
            this.textBox_Buscar = new System.Windows.Forms.TextBox();
            this.labelBuscarUnUsuario = new System.Windows.Forms.Label();
            this.listView = new System.Windows.Forms.ListView();
            this.Select = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dni = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.apellido = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelMostrar = new System.Windows.Forms.Button();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelApellido = new System.Windows.Forms.Label();
            this.labelDNI = new System.Windows.Forms.Label();
            this.labelCalle = new System.Windows.Forms.Label();
            this.labelNumero = new System.Windows.Forms.Label();
            this.labelEstado = new System.Windows.Forms.Label();
            this.labelCodPostal = new System.Windows.Forms.Label();
            this.labelTelefono = new System.Windows.Forms.Label();
            this.labelFecha = new System.Windows.Forms.Label();
            this.labelMembres = new System.Windows.Forms.Label();
            this.labelAlta = new System.Windows.Forms.Button();
            this.labelBaja = new System.Windows.Forms.Button();
            this.labelModificar = new System.Windows.Forms.Button();
            this.textBox_Nombre = new System.Windows.Forms.TextBox();
            this.textBox_Apellido = new System.Windows.Forms.TextBox();
            this.textBox_Dni = new System.Windows.Forms.TextBox();
            this.textBox_Calle = new System.Windows.Forms.TextBox();
            this.textBox_Numero = new System.Windows.Forms.TextBox();
            this.textBox_Telefono = new System.Windows.Forms.TextBox();
            this.textBox_CodPost = new System.Windows.Forms.TextBox();
            this.labelSalir = new System.Windows.Forms.Button();
            this.labelPeso = new System.Windows.Forms.Label();
            this.textBox_Peso = new System.Windows.Forms.TextBox();
            this.fechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.comboBox_estado = new System.Windows.Forms.ComboBox();
            this.labelEdad = new System.Windows.Forms.Label();
            this.buttonCalc = new System.Windows.Forms.Button();
            this.labelValorEdad = new System.Windows.Forms.Label();
            this.comboMem = new System.Windows.Forms.ComboBox();
            this.labelCertif = new System.Windows.Forms.Label();
            this.checkBoxCertif = new System.Windows.Forms.CheckBox();
            this.labelDescuento = new System.Windows.Forms.Label();
            this.labelAltura = new System.Windows.Forms.Label();
            this.textBoxAltura = new System.Windows.Forms.TextBox();
            this.labelIMC = new System.Windows.Forms.Label();
            this.comboDesc = new System.Windows.Forms.ComboBox();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.clientesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // labelBuscar
            // 
            this.labelBuscar.Location = new System.Drawing.Point(310, 16);
            this.labelBuscar.Name = "labelBuscar";
            this.labelBuscar.Size = new System.Drawing.Size(75, 23);
            this.labelBuscar.TabIndex = 0;
            this.labelBuscar.Text = "Buscar";
            this.labelBuscar.UseVisualStyleBackColor = true;
            this.labelBuscar.Click += new System.EventHandler(this.btn_Buscar_Click);
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
            this.Select,
            this.dni,
            this.nombre,
            this.apellido});
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(12, 70);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(232, 188);
            this.listView.TabIndex = 3;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // Select
            // 
            this.Select.Text = "X";
            this.Select.Width = 21;
            // 
            // dni
            // 
            this.dni.Text = "DNI";
            this.dni.Width = 79;
            // 
            // nombre
            // 
            this.nombre.Text = "Nombre";
            this.nombre.Width = 62;
            // 
            // apellido
            // 
            this.apellido.Text = "Apellido";
            // 
            // labelMostrar
            // 
            this.labelMostrar.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelMostrar.Location = new System.Drawing.Point(93, 272);
            this.labelMostrar.Name = "labelMostrar";
            this.labelMostrar.Size = new System.Drawing.Size(75, 23);
            this.labelMostrar.TabIndex = 4;
            this.labelMostrar.Tag = "4";
            this.labelMostrar.Text = "Mostrar";
            this.labelMostrar.UseVisualStyleBackColor = true;
            this.labelMostrar.Click += new System.EventHandler(this.labelMostrar_Click);
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
            this.labelNumero.Text = "Número";
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.Location = new System.Drawing.Point(538, 77);
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
            this.labelTelefono.Text = "Teléfono";
            this.labelTelefono.Click += new System.EventHandler(this.label9_Click);
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Location = new System.Drawing.Point(262, 267);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(60, 26);
            this.labelFecha.TabIndex = 5;
            this.labelFecha.Text = "Fecha \r\nNacimiento";
            this.labelFecha.Click += new System.EventHandler(this.label9_Click);
            // 
            // labelMembres
            // 
            this.labelMembres.AutoSize = true;
            this.labelMembres.Location = new System.Drawing.Point(538, 202);
            this.labelMembres.Name = "labelMembres";
            this.labelMembres.Size = new System.Drawing.Size(60, 13);
            this.labelMembres.TabIndex = 5;
            this.labelMembres.Text = "Membresía";
            this.labelMembres.Click += new System.EventHandler(this.label9_Click);
            // 
            // labelAlta
            // 
            this.labelAlta.Location = new System.Drawing.Point(551, 336);
            this.labelAlta.Name = "labelAlta";
            this.labelAlta.Size = new System.Drawing.Size(64, 25);
            this.labelAlta.TabIndex = 6;
            this.labelAlta.Tag = "1";
            this.labelAlta.Text = "Alta";
            this.labelAlta.UseVisualStyleBackColor = true;
            this.labelAlta.Click += new System.EventHandler(this.labelAlta_Click);
            // 
            // labelBaja
            // 
            this.labelBaja.Location = new System.Drawing.Point(623, 336);
            this.labelBaja.Name = "labelBaja";
            this.labelBaja.Size = new System.Drawing.Size(64, 25);
            this.labelBaja.TabIndex = 7;
            this.labelBaja.Tag = "2";
            this.labelBaja.Text = "Baja";
            this.labelBaja.UseVisualStyleBackColor = true;
            this.labelBaja.Click += new System.EventHandler(this.labelBaja_Click);
            // 
            // labelModificar
            // 
            this.labelModificar.Location = new System.Drawing.Point(693, 336);
            this.labelModificar.Name = "labelModificar";
            this.labelModificar.Size = new System.Drawing.Size(71, 25);
            this.labelModificar.TabIndex = 8;
            this.labelModificar.Tag = "3";
            this.labelModificar.Text = "Modificar";
            this.labelModificar.UseVisualStyleBackColor = true;
            this.labelModificar.Click += new System.EventHandler(this.labelModificar_Click);
            // 
            // textBox_Nombre
            // 
            this.textBox_Nombre.Location = new System.Drawing.Point(393, 74);
            this.textBox_Nombre.MaxLength = 60;
            this.textBox_Nombre.Name = "textBox_Nombre";
            this.textBox_Nombre.Size = new System.Drawing.Size(100, 20);
            this.textBox_Nombre.TabIndex = 9;
            this.textBox_Nombre.TextChanged += new System.EventHandler(this.textBox_Nombre_TextChanged);
            // 
            // textBox_Apellido
            // 
            this.textBox_Apellido.Location = new System.Drawing.Point(393, 101);
            this.textBox_Apellido.MaxLength = 60;
            this.textBox_Apellido.Name = "textBox_Apellido";
            this.textBox_Apellido.Size = new System.Drawing.Size(100, 20);
            this.textBox_Apellido.TabIndex = 9;
            // 
            // textBox_Dni
            // 
            this.textBox_Dni.Location = new System.Drawing.Point(393, 130);
            this.textBox_Dni.MaxLength = 8;
            this.textBox_Dni.Name = "textBox_Dni";
            this.textBox_Dni.Size = new System.Drawing.Size(100, 20);
            this.textBox_Dni.TabIndex = 9;
            this.textBox_Dni.TextChanged += new System.EventHandler(this.textBox_Dni_TextChanged);
            // 
            // textBox_Calle
            // 
            this.textBox_Calle.Location = new System.Drawing.Point(393, 159);
            this.textBox_Calle.MaxLength = 30;
            this.textBox_Calle.Name = "textBox_Calle";
            this.textBox_Calle.Size = new System.Drawing.Size(100, 20);
            this.textBox_Calle.TabIndex = 9;
            // 
            // textBox_Numero
            // 
            this.textBox_Numero.Location = new System.Drawing.Point(393, 186);
            this.textBox_Numero.MaxLength = 5;
            this.textBox_Numero.Name = "textBox_Numero";
            this.textBox_Numero.Size = new System.Drawing.Size(100, 20);
            this.textBox_Numero.TabIndex = 9;
            this.textBox_Numero.TextChanged += new System.EventHandler(this.textBox_Numero_TextChanged);
            // 
            // textBox_Telefono
            // 
            this.textBox_Telefono.Location = new System.Drawing.Point(393, 238);
            this.textBox_Telefono.MaxLength = 12;
            this.textBox_Telefono.Name = "textBox_Telefono";
            this.textBox_Telefono.Size = new System.Drawing.Size(100, 20);
            this.textBox_Telefono.TabIndex = 9;
            this.textBox_Telefono.TextChanged += new System.EventHandler(this.textBox_Telefono_TextChanged);
            // 
            // textBox_CodPost
            // 
            this.textBox_CodPost.Location = new System.Drawing.Point(393, 212);
            this.textBox_CodPost.MaxLength = 5;
            this.textBox_CodPost.Name = "textBox_CodPost";
            this.textBox_CodPost.Size = new System.Drawing.Size(100, 20);
            this.textBox_CodPost.TabIndex = 9;
            this.textBox_CodPost.TextChanged += new System.EventHandler(this.textBox_CodPost_TextChanged);
            // 
            // labelSalir
            // 
            this.labelSalir.Location = new System.Drawing.Point(706, 410);
            this.labelSalir.Name = "labelSalir";
            this.labelSalir.Size = new System.Drawing.Size(82, 28);
            this.labelSalir.TabIndex = 10;
            this.labelSalir.Text = "Salir";
            this.labelSalir.UseVisualStyleBackColor = true;
            this.labelSalir.Click += new System.EventHandler(this.button6_Click);
            // 
            // labelPeso
            // 
            this.labelPeso.AutoSize = true;
            this.labelPeso.Location = new System.Drawing.Point(538, 107);
            this.labelPeso.Name = "labelPeso";
            this.labelPeso.Size = new System.Drawing.Size(47, 13);
            this.labelPeso.TabIndex = 5;
            this.labelPeso.Text = "Peso Kg";
            this.labelPeso.Click += new System.EventHandler(this.label9_Click);
            // 
            // textBox_Peso
            // 
            this.textBox_Peso.Location = new System.Drawing.Point(626, 106);
            this.textBox_Peso.MaxLength = 3;
            this.textBox_Peso.Name = "textBox_Peso";
            this.textBox_Peso.Size = new System.Drawing.Size(134, 20);
            this.textBox_Peso.TabIndex = 9;
            this.textBox_Peso.TextChanged += new System.EventHandler(this.textBox_Peso_TextChanged);
            // 
            // fechaNacimiento
            // 
            this.fechaNacimiento.Cursor = System.Windows.Forms.Cursors.PanSE;
            this.fechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaNacimiento.ImeMode = System.Windows.Forms.ImeMode.On;
            this.fechaNacimiento.Location = new System.Drawing.Point(393, 273);
            this.fechaNacimiento.MinDate = new System.DateTime(1945, 9, 2, 0, 0, 0, 0);
            this.fechaNacimiento.Name = "fechaNacimiento";
            this.fechaNacimiento.Size = new System.Drawing.Size(100, 20);
            this.fechaNacimiento.TabIndex = 11;
            this.fechaNacimiento.ValueChanged += new System.EventHandler(this.fechaNacimiento_ValueChanged);
            // 
            // comboBox_estado
            // 
            this.comboBox_estado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_estado.FormattingEnabled = true;
            this.comboBox_estado.Location = new System.Drawing.Point(626, 74);
            this.comboBox_estado.Name = "comboBox_estado";
            this.comboBox_estado.Size = new System.Drawing.Size(134, 21);
            this.comboBox_estado.TabIndex = 12;
            this.comboBox_estado.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // labelEdad
            // 
            this.labelEdad.AutoSize = true;
            this.labelEdad.Location = new System.Drawing.Point(262, 307);
            this.labelEdad.Name = "labelEdad";
            this.labelEdad.Size = new System.Drawing.Size(32, 13);
            this.labelEdad.TabIndex = 5;
            this.labelEdad.Text = "Edad";
            this.labelEdad.Click += new System.EventHandler(this.label9_Click);
            // 
            // buttonCalc
            // 
            this.buttonCalc.Font = new System.Drawing.Font("Arial Black", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCalc.Location = new System.Drawing.Point(541, 275);
            this.buttonCalc.Name = "buttonCalc";
            this.buttonCalc.Size = new System.Drawing.Size(57, 34);
            this.buttonCalc.TabIndex = 14;
            this.buttonCalc.Text = "IMC";
            this.buttonCalc.UseVisualStyleBackColor = true;
            this.buttonCalc.Click += new System.EventHandler(this.buttonCalc_Click);
            // 
            // labelValorEdad
            // 
            this.labelValorEdad.AutoSize = true;
            this.labelValorEdad.Location = new System.Drawing.Point(390, 307);
            this.labelValorEdad.Name = "labelValorEdad";
            this.labelValorEdad.Size = new System.Drawing.Size(14, 13);
            this.labelValorEdad.TabIndex = 5;
            this.labelValorEdad.Text = "X";
            this.labelValorEdad.Click += new System.EventHandler(this.label9_Click);
            // 
            // comboMem
            // 
            this.comboMem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboMem.FormattingEnabled = true;
            this.comboMem.Location = new System.Drawing.Point(626, 199);
            this.comboMem.Name = "comboMem";
            this.comboMem.Size = new System.Drawing.Size(134, 21);
            this.comboMem.TabIndex = 12;
            this.comboMem.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // labelCertif
            // 
            this.labelCertif.AutoSize = true;
            this.labelCertif.Location = new System.Drawing.Point(538, 162);
            this.labelCertif.Name = "labelCertif";
            this.labelCertif.Size = new System.Drawing.Size(60, 26);
            this.labelCertif.TabIndex = 5;
            this.labelCertif.Text = "Certificado \r\nMédico";
            this.labelCertif.Click += new System.EventHandler(this.label9_Click);
            // 
            // checkBoxCertif
            // 
            this.checkBoxCertif.AutoSize = true;
            this.checkBoxCertif.Location = new System.Drawing.Point(626, 170);
            this.checkBoxCertif.Name = "checkBoxCertif";
            this.checkBoxCertif.Size = new System.Drawing.Size(15, 14);
            this.checkBoxCertif.TabIndex = 15;
            this.checkBoxCertif.UseVisualStyleBackColor = true;
            this.checkBoxCertif.CheckedChanged += new System.EventHandler(this.checkBoxCertif_CheckedChanged);
            // 
            // labelDescuento
            // 
            this.labelDescuento.AutoSize = true;
            this.labelDescuento.Location = new System.Drawing.Point(538, 241);
            this.labelDescuento.Name = "labelDescuento";
            this.labelDescuento.Size = new System.Drawing.Size(59, 13);
            this.labelDescuento.TabIndex = 5;
            this.labelDescuento.Text = "Descuento";
            this.labelDescuento.Click += new System.EventHandler(this.label9_Click);
            // 
            // labelAltura
            // 
            this.labelAltura.AutoSize = true;
            this.labelAltura.Location = new System.Drawing.Point(538, 134);
            this.labelAltura.Name = "labelAltura";
            this.labelAltura.Size = new System.Drawing.Size(51, 13);
            this.labelAltura.TabIndex = 5;
            this.labelAltura.Text = "Altura cm";
            this.labelAltura.Click += new System.EventHandler(this.label9_Click);
            // 
            // textBoxAltura
            // 
            this.textBoxAltura.Location = new System.Drawing.Point(626, 133);
            this.textBoxAltura.MaxLength = 3;
            this.textBoxAltura.Name = "textBoxAltura";
            this.textBoxAltura.Size = new System.Drawing.Size(134, 20);
            this.textBoxAltura.TabIndex = 9;
            this.textBoxAltura.TextChanged += new System.EventHandler(this.textBoxAltura_TextChanged);
            // 
            // labelIMC
            // 
            this.labelIMC.AutoSize = true;
            this.labelIMC.Location = new System.Drawing.Point(627, 286);
            this.labelIMC.Name = "labelIMC";
            this.labelIMC.Size = new System.Drawing.Size(14, 13);
            this.labelIMC.TabIndex = 5;
            this.labelIMC.Text = "X";
            this.labelIMC.Click += new System.EventHandler(this.label9_Click);
            // 
            // comboDesc
            // 
            this.comboDesc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboDesc.Enabled = false;
            this.comboDesc.FormattingEnabled = true;
            this.comboDesc.Items.AddRange(new object[] {
            "0%",
            "10%",
            "20%",
            "30%",
            "40%",
            "50%",
            "60%",
            "70%",
            "80%",
            "90%",
            "100%"});
            this.comboDesc.Location = new System.Drawing.Point(626, 237);
            this.comboDesc.Name = "comboDesc";
            this.comboDesc.Size = new System.Drawing.Size(67, 21);
            this.comboDesc.TabIndex = 12;
            this.comboDesc.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataSource = typeof(UI.Clientes);
            // 
            // clientesBindingSource1
            // 
            this.clientesBindingSource1.DataSource = typeof(UI.Clientes);
            // 
            // clientesBindingSource2
            // 
            this.clientesBindingSource2.DataSource = typeof(UI.Clientes);
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBoxCertif);
            this.Controls.Add(this.buttonCalc);
            this.Controls.Add(this.comboDesc);
            this.Controls.Add(this.comboMem);
            this.Controls.Add(this.comboBox_estado);
            this.Controls.Add(this.fechaNacimiento);
            this.Controls.Add(this.labelSalir);
            this.Controls.Add(this.textBox_CodPost);
            this.Controls.Add(this.textBoxAltura);
            this.Controls.Add(this.textBox_Peso);
            this.Controls.Add(this.textBox_Calle);
            this.Controls.Add(this.textBox_Telefono);
            this.Controls.Add(this.textBox_Dni);
            this.Controls.Add(this.textBox_Numero);
            this.Controls.Add(this.textBox_Apellido);
            this.Controls.Add(this.textBox_Nombre);
            this.Controls.Add(this.labelModificar);
            this.Controls.Add(this.labelBaja);
            this.Controls.Add(this.labelAlta);
            this.Controls.Add(this.labelMembres);
            this.Controls.Add(this.labelAltura);
            this.Controls.Add(this.labelCertif);
            this.Controls.Add(this.labelPeso);
            this.Controls.Add(this.labelIMC);
            this.Controls.Add(this.labelValorEdad);
            this.Controls.Add(this.labelDescuento);
            this.Controls.Add(this.labelEdad);
            this.Controls.Add(this.labelFecha);
            this.Controls.Add(this.labelTelefono);
            this.Controls.Add(this.labelCodPostal);
            this.Controls.Add(this.labelEstado);
            this.Controls.Add(this.labelNumero);
            this.Controls.Add(this.labelCalle);
            this.Controls.Add(this.labelDNI);
            this.Controls.Add(this.labelApellido);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.labelMostrar);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.labelBuscarUnUsuario);
            this.Controls.Add(this.textBox_Buscar);
            this.Controls.Add(this.labelBuscar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Clientes";
            this.Text = "Gestion de Clientes";
            this.Load += new System.EventHandler(this.Clientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button labelBuscar;
        private System.Windows.Forms.TextBox textBox_Buscar;
        private System.Windows.Forms.Label labelBuscarUnUsuario;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.Button labelMostrar;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.Label labelDNI;
        private System.Windows.Forms.Label labelCalle;
        private System.Windows.Forms.Label labelNumero;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.Label labelCodPostal;
        private System.Windows.Forms.Label labelTelefono;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.Label labelMembres;
        private System.Windows.Forms.Button labelAlta;
        private System.Windows.Forms.Button labelBaja;
        private System.Windows.Forms.Button labelModificar;
        private System.Windows.Forms.TextBox textBox_Nombre;
        private System.Windows.Forms.TextBox textBox_Apellido;
        private System.Windows.Forms.TextBox textBox_Dni;
        private System.Windows.Forms.TextBox textBox_Calle;
        private System.Windows.Forms.TextBox textBox_Numero;
        private System.Windows.Forms.TextBox textBox_Telefono;
        private System.Windows.Forms.TextBox textBox_CodPost;
        private System.Windows.Forms.Button labelSalir;
        private System.Windows.Forms.Label labelPeso;
        private System.Windows.Forms.TextBox textBox_Peso;
        private System.Windows.Forms.DateTimePicker fechaNacimiento;
        private System.Windows.Forms.ComboBox comboBox_estado;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private System.Windows.Forms.BindingSource clientesBindingSource1;
        private System.Windows.Forms.BindingSource clientesBindingSource2;
        private System.Windows.Forms.Label labelEdad;
        private System.Windows.Forms.Button buttonCalc;
        private System.Windows.Forms.Label labelValorEdad;
        private System.Windows.Forms.ComboBox comboMem;
        private System.Windows.Forms.Label labelCertif;
        private System.Windows.Forms.CheckBox checkBoxCertif;
        private System.Windows.Forms.Label labelDescuento;
        private System.Windows.Forms.Label labelAltura;
        private System.Windows.Forms.TextBox textBoxAltura;
        private System.Windows.Forms.Label labelIMC;
        private System.Windows.Forms.ComboBox comboDesc;
        private System.Windows.Forms.ColumnHeader dni;
        private System.Windows.Forms.ColumnHeader nombre;
        private System.Windows.Forms.ColumnHeader apellido;
        private System.Windows.Forms.ColumnHeader Select;
    }
}