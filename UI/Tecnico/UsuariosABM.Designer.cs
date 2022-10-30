namespace UI
{
    partial class UsuariosABM
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
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
            this.labelAlta = new System.Windows.Forms.Button();
            this.labelBaja = new System.Windows.Forms.Button();
            this.labelModificar = new System.Windows.Forms.Button();
            this.labelBuscar = new System.Windows.Forms.Button();
            this.labelUser = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelBuscarUnUsuario = new System.Windows.Forms.Label();
            this.labelUsuario2 = new System.Windows.Forms.Label();
            this.labelPass = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.labelEstado = new System.Windows.Forms.Label();
            this.labelIdioma = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.labelMostrar = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.hide = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.usuarioCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IdiomaCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Estadocol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelPalabraS = new System.Windows.Forms.Label();
            this.textBoxPalabraS = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelAlta
            // 
            this.labelAlta.Location = new System.Drawing.Point(295, 333);
            this.labelAlta.Name = "labelAlta";
            this.labelAlta.Size = new System.Drawing.Size(75, 23);
            this.labelAlta.TabIndex = 0;
            this.labelAlta.Text = "Dar de Alta";
            this.labelAlta.UseVisualStyleBackColor = true;
            this.labelAlta.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelBaja
            // 
            this.labelBaja.Location = new System.Drawing.Point(386, 333);
            this.labelBaja.Name = "labelBaja";
            this.labelBaja.Size = new System.Drawing.Size(75, 23);
            this.labelBaja.TabIndex = 1;
            this.labelBaja.Text = "Dar de Baja";
            this.labelBaja.UseVisualStyleBackColor = true;
            this.labelBaja.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelModificar
            // 
            this.labelModificar.Location = new System.Drawing.Point(467, 333);
            this.labelModificar.Name = "labelModificar";
            this.labelModificar.Size = new System.Drawing.Size(75, 23);
            this.labelModificar.TabIndex = 2;
            this.labelModificar.Text = "Modificar";
            this.labelModificar.UseVisualStyleBackColor = true;
            this.labelModificar.Click += new System.EventHandler(this.labelModificar_Click);
            // 
            // labelBuscar
            // 
            this.labelBuscar.Location = new System.Drawing.Point(197, 61);
            this.labelBuscar.Name = "labelBuscar";
            this.labelBuscar.Size = new System.Drawing.Size(59, 20);
            this.labelBuscar.TabIndex = 3;
            this.labelBuscar.Text = "Buscar Usuario";
            this.labelBuscar.UseVisualStyleBackColor = true;
            this.labelBuscar.Click += new System.EventHandler(this.button4_Click);
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Location = new System.Drawing.Point(9, 64);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(46, 13);
            this.labelUser.TabIndex = 7;
            this.labelUser.Text = "Usuario:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(57, 61);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(122, 20);
            this.textBox2.TabIndex = 5;
            // 
            // labelBuscarUnUsuario
            // 
            this.labelBuscarUnUsuario.AutoSize = true;
            this.labelBuscarUnUsuario.Location = new System.Drawing.Point(12, 23);
            this.labelBuscarUnUsuario.Name = "labelBuscarUnUsuario";
            this.labelBuscarUnUsuario.Size = new System.Drawing.Size(92, 13);
            this.labelBuscarUnUsuario.TabIndex = 8;
            this.labelBuscarUnUsuario.Text = "Buscar un usuario";
            // 
            // labelUsuario2
            // 
            this.labelUsuario2.AutoSize = true;
            this.labelUsuario2.Location = new System.Drawing.Point(292, 117);
            this.labelUsuario2.Name = "labelUsuario2";
            this.labelUsuario2.Size = new System.Drawing.Size(49, 13);
            this.labelUsuario2.TabIndex = 9;
            this.labelUsuario2.Text = "Usuario: ";
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Location = new System.Drawing.Point(292, 155);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(64, 13);
            this.labelPass.TabIndex = 9;
            this.labelPass.Text = "Contraseña:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(392, 114);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(131, 20);
            this.textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(392, 152);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(131, 20);
            this.textBox4.TabIndex = 10;
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.Location = new System.Drawing.Point(292, 274);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(43, 13);
            this.labelEstado.TabIndex = 9;
            this.labelEstado.Text = "Estado:";
            // 
            // labelIdioma
            // 
            this.labelIdioma.AutoSize = true;
            this.labelIdioma.Location = new System.Drawing.Point(292, 230);
            this.labelIdioma.Name = "labelIdioma";
            this.labelIdioma.Size = new System.Drawing.Size(41, 13);
            this.labelIdioma.TabIndex = 9;
            this.labelIdioma.Text = "Idioma:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Español",
            "Ingles"});
            this.comboBox1.Location = new System.Drawing.Point(392, 227);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(131, 21);
            this.comboBox1.TabIndex = 11;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Alta",
            "Baja"});
            this.comboBox2.Location = new System.Drawing.Point(392, 271);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(131, 21);
            this.comboBox2.TabIndex = 11;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // buttonSalir
            // 
            this.buttonSalir.Location = new System.Drawing.Point(494, 395);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(99, 42);
            this.buttonSalir.TabIndex = 3;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.button5_Click);
            // 
            // labelMostrar
            // 
            this.labelMostrar.Location = new System.Drawing.Point(99, 328);
            this.labelMostrar.Name = "labelMostrar";
            this.labelMostrar.Size = new System.Drawing.Size(95, 32);
            this.labelMostrar.TabIndex = 12;
            this.labelMostrar.Text = "Mostrar";
            this.labelMostrar.UseVisualStyleBackColor = true;
            this.labelMostrar.Click += new System.EventHandler(this.button6_Click);
            // 
            // listView1
            // 
            this.listView1.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.hide,
            this.usuarioCol,
            this.IdiomaCol,
            this.Estadocol});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
            this.listView1.Location = new System.Drawing.Point(15, 103);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(241, 219);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // hide
            // 
            this.hide.DisplayIndex = 3;
            this.hide.Text = "";
            this.hide.Width = 1;
            // 
            // usuarioCol
            // 
            this.usuarioCol.DisplayIndex = 0;
            this.usuarioCol.Text = "Usuario";
            this.usuarioCol.Width = 100;
            // 
            // IdiomaCol
            // 
            this.IdiomaCol.DisplayIndex = 1;
            this.IdiomaCol.Text = "Idioma";
            this.IdiomaCol.Width = 100;
            // 
            // Estadocol
            // 
            this.Estadocol.DisplayIndex = 2;
            this.Estadocol.Text = "Estado";
            this.Estadocol.Width = 100;
            // 
            // labelPalabraS
            // 
            this.labelPalabraS.AutoSize = true;
            this.labelPalabraS.Location = new System.Drawing.Point(292, 191);
            this.labelPalabraS.Name = "labelPalabraS";
            this.labelPalabraS.Size = new System.Drawing.Size(86, 13);
            this.labelPalabraS.TabIndex = 9;
            this.labelPalabraS.Text = "Palabra Secreta:";
            // 
            // textBoxPalabraS
            // 
            this.textBoxPalabraS.Location = new System.Drawing.Point(392, 188);
            this.textBoxPalabraS.Name = "textBoxPalabraS";
            this.textBoxPalabraS.Size = new System.Drawing.Size(131, 20);
            this.textBoxPalabraS.TabIndex = 10;
            // 
            // UsuariosABM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(605, 449);
            this.ControlBox = false;
            this.Controls.Add(this.labelMostrar);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBoxPalabraS);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.labelIdioma);
            this.Controls.Add(this.labelEstado);
            this.Controls.Add(this.labelPalabraS);
            this.Controls.Add(this.labelPass);
            this.Controls.Add(this.labelUsuario2);
            this.Controls.Add(this.labelBuscarUnUsuario);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.labelBuscar);
            this.Controls.Add(this.labelModificar);
            this.Controls.Add(this.labelBaja);
            this.Controls.Add(this.labelAlta);
            this.Name = "UsuariosABM";
            this.Text = "UsuariosABM";
            this.Load += new System.EventHandler(this.UsuariosABM_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button labelAlta;
        private System.Windows.Forms.Button labelBaja;
        private System.Windows.Forms.Button labelModificar;
        private System.Windows.Forms.Button labelBuscar;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label labelBuscarUnUsuario;
        private System.Windows.Forms.Label labelUsuario2;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.Label labelIdioma;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.Button labelMostrar;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader usuarioCol;
        private System.Windows.Forms.ColumnHeader IdiomaCol;
        private System.Windows.Forms.ColumnHeader Estadocol;
        private System.Windows.Forms.ColumnHeader hide;
        private System.Windows.Forms.Label labelPalabraS;
        private System.Windows.Forms.TextBox textBoxPalabraS;
    }
}