
namespace UI
{
    partial class PagosCobros
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
            this.labelPagosYCobros = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelMostrar = new System.Windows.Forms.Button();
            this.listView = new System.Windows.Forms.ListView();
            this.Select = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dni = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.apellido = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelBuscarUnUsuario = new System.Windows.Forms.Label();
            this.textBox_Buscar = new System.Windows.Forms.TextBox();
            this.labelBuscar = new System.Windows.Forms.Button();
            this.textBoxCliente = new System.Windows.Forms.TextBox();
            this.labelCliente = new System.Windows.Forms.Label();
            this.buttonComprar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSalir
            // 
            this.labelSalir.Location = new System.Drawing.Point(618, 399);
            this.labelSalir.Name = "labelSalir";
            this.labelSalir.Size = new System.Drawing.Size(75, 23);
            this.labelSalir.TabIndex = 0;
            this.labelSalir.Text = "Salir";
            this.labelSalir.UseVisualStyleBackColor = true;
            this.labelSalir.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelPagosYCobros
            // 
            this.labelPagosYCobros.AutoSize = true;
            this.labelPagosYCobros.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPagosYCobros.Location = new System.Drawing.Point(12, 9);
            this.labelPagosYCobros.Name = "labelPagosYCobros";
            this.labelPagosYCobros.Size = new System.Drawing.Size(78, 25);
            this.labelPagosYCobros.TabIndex = 2;
            this.labelPagosYCobros.Text = "Pagos";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(323, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(316, 266);
            this.dataGridView1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(418, 367);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Total recaudado:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(513, 367);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "$$$";
            // 
            // labelMostrar
            // 
            this.labelMostrar.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelMostrar.Location = new System.Drawing.Point(90, 206);
            this.labelMostrar.Name = "labelMostrar";
            this.labelMostrar.Size = new System.Drawing.Size(75, 23);
            this.labelMostrar.TabIndex = 11;
            this.labelMostrar.Text = "Mostrar";
            this.labelMostrar.UseVisualStyleBackColor = true;
            this.labelMostrar.Click += new System.EventHandler(this.labelMostrar_Click);
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Select,
            this.dni,
            this.nombre,
            this.apellido});
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(20, 103);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(227, 97);
            this.listView.TabIndex = 10;
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
            // labelBuscarUnUsuario
            // 
            this.labelBuscarUnUsuario.AutoSize = true;
            this.labelBuscarUnUsuario.Location = new System.Drawing.Point(17, 74);
            this.labelBuscarUnUsuario.Name = "labelBuscarUnUsuario";
            this.labelBuscarUnUsuario.Size = new System.Drawing.Size(96, 13);
            this.labelBuscarUnUsuario.TabIndex = 9;
            this.labelBuscarUnUsuario.Text = "Nombre del Cliente";
            // 
            // textBox_Buscar
            // 
            this.textBox_Buscar.Location = new System.Drawing.Point(119, 71);
            this.textBox_Buscar.MaxLength = 20;
            this.textBox_Buscar.Name = "textBox_Buscar";
            this.textBox_Buscar.Size = new System.Drawing.Size(117, 20);
            this.textBox_Buscar.TabIndex = 8;
            this.textBox_Buscar.TextChanged += new System.EventHandler(this.textBox_Buscar_TextChanged);
            // 
            // labelBuscar
            // 
            this.labelBuscar.Location = new System.Drawing.Point(242, 68);
            this.labelBuscar.Name = "labelBuscar";
            this.labelBuscar.Size = new System.Drawing.Size(51, 23);
            this.labelBuscar.TabIndex = 7;
            this.labelBuscar.Text = "Buscar";
            this.labelBuscar.UseVisualStyleBackColor = true;
            this.labelBuscar.Click += new System.EventHandler(this.labelBuscar_Click);
            // 
            // textBoxCliente
            // 
            this.textBoxCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBoxCliente.Location = new System.Drawing.Point(63, 284);
            this.textBoxCliente.MaxLength = 8;
            this.textBoxCliente.Name = "textBoxCliente";
            this.textBoxCliente.Size = new System.Drawing.Size(148, 20);
            this.textBoxCliente.TabIndex = 14;
            this.textBoxCliente.TextChanged += new System.EventHandler(this.textBoxCliente_TextChanged);
            // 
            // labelCliente
            // 
            this.labelCliente.AutoSize = true;
            this.labelCliente.Location = new System.Drawing.Point(18, 287);
            this.labelCliente.Name = "labelCliente";
            this.labelCliente.Size = new System.Drawing.Size(39, 13);
            this.labelCliente.TabIndex = 13;
            this.labelCliente.Text = "Cliente";
            // 
            // buttonComprar
            // 
            this.buttonComprar.BackColor = System.Drawing.SystemColors.MenuBar;
            this.buttonComprar.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.buttonComprar.FlatAppearance.BorderSize = 10;
            this.buttonComprar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.buttonComprar.Location = new System.Drawing.Point(90, 310);
            this.buttonComprar.Name = "buttonComprar";
            this.buttonComprar.Size = new System.Drawing.Size(75, 23);
            this.buttonComprar.TabIndex = 12;
            this.buttonComprar.Text = "Pagar";
            this.buttonComprar.UseVisualStyleBackColor = false;
            this.buttonComprar.Click += new System.EventHandler(this.buttonComprar_Click);
            // 
            // PagosCobros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 436);
            this.ControlBox = false;
            this.Controls.Add(this.textBoxCliente);
            this.Controls.Add(this.labelCliente);
            this.Controls.Add(this.buttonComprar);
            this.Controls.Add(this.labelMostrar);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.labelBuscarUnUsuario);
            this.Controls.Add(this.textBox_Buscar);
            this.Controls.Add(this.labelBuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelPagosYCobros);
            this.Controls.Add(this.labelSalir);
            this.Name = "PagosCobros";
            this.Text = "PagosCobros";
            this.Load += new System.EventHandler(this.PagosCobros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button labelSalir;
        private System.Windows.Forms.Label labelPagosYCobros;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button labelMostrar;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader Select;
        private System.Windows.Forms.ColumnHeader dni;
        private System.Windows.Forms.ColumnHeader nombre;
        private System.Windows.Forms.ColumnHeader apellido;
        private System.Windows.Forms.Label labelBuscarUnUsuario;
        private System.Windows.Forms.TextBox textBox_Buscar;
        private System.Windows.Forms.Button labelBuscar;
        private System.Windows.Forms.TextBox textBoxCliente;
        private System.Windows.Forms.Label labelCliente;
        private System.Windows.Forms.Button buttonComprar;
    }
}