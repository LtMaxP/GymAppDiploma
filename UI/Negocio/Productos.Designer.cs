
namespace UI.Negocio
{
    partial class Productos
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelNroTotal = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonQuitar = new System.Windows.Forms.Button();
            this.buttonComprar = new System.Windows.Forms.Button();
            this.labelCliente = new System.Windows.Forms.Label();
            this.textBoxCliente = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.labelProducto = new System.Windows.Forms.Label();
            this.labelCantidad = new System.Windows.Forms.Label();
            this.txtBoxCantidad = new System.Windows.Forms.TextBox();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.labelDisponible = new System.Windows.Forms.Label();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.labelNroDisponible = new System.Windows.Forms.Label();
            this.labelNroPrecio = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mistral", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "Producto";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(188, 117);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(193, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonAgregar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAgregar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.buttonAgregar.Location = new System.Drawing.Point(155, 215);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(102, 32);
            this.buttonAgregar.TabIndex = 2;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = false;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(236, 462);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(34, 13);
            this.labelTotal.TabIndex = 4;
            this.labelTotal.Text = "Total:";
            // 
            // labelNroTotal
            // 
            this.labelNroTotal.AutoSize = true;
            this.labelNroTotal.Location = new System.Drawing.Point(278, 462);
            this.labelNroTotal.Name = "labelNroTotal";
            this.labelNroTotal.Size = new System.Drawing.Size(13, 13);
            this.labelNroTotal.TabIndex = 5;
            this.labelNroTotal.Text = "0";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(44, 253);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(464, 206);
            this.dataGridView1.TabIndex = 6;
            // 
            // buttonQuitar
            // 
            this.buttonQuitar.BackColor = System.Drawing.Color.Maroon;
            this.buttonQuitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuitar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.buttonQuitar.Location = new System.Drawing.Point(297, 215);
            this.buttonQuitar.Name = "buttonQuitar";
            this.buttonQuitar.Size = new System.Drawing.Size(102, 32);
            this.buttonQuitar.TabIndex = 7;
            this.buttonQuitar.Text = "Quitar";
            this.buttonQuitar.UseVisualStyleBackColor = false;
            this.buttonQuitar.Click += new System.EventHandler(this.buttonQuitar_Click);
            // 
            // buttonComprar
            // 
            this.buttonComprar.BackColor = System.Drawing.SystemColors.MenuBar;
            this.buttonComprar.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.buttonComprar.FlatAppearance.BorderSize = 10;
            this.buttonComprar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.buttonComprar.Location = new System.Drawing.Point(225, 524);
            this.buttonComprar.Name = "buttonComprar";
            this.buttonComprar.Size = new System.Drawing.Size(75, 23);
            this.buttonComprar.TabIndex = 8;
            this.buttonComprar.Text = "Comprar";
            this.buttonComprar.UseVisualStyleBackColor = false;
            this.buttonComprar.Click += new System.EventHandler(this.buttonComprar_Click);
            // 
            // labelCliente
            // 
            this.labelCliente.AutoSize = true;
            this.labelCliente.Location = new System.Drawing.Point(153, 501);
            this.labelCliente.Name = "labelCliente";
            this.labelCliente.Size = new System.Drawing.Size(39, 13);
            this.labelCliente.TabIndex = 9;
            this.labelCliente.Text = "Cliente";
            // 
            // textBoxCliente
            // 
            this.textBoxCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBoxCliente.Location = new System.Drawing.Point(198, 498);
            this.textBoxCliente.MaxLength = 8;
            this.textBoxCliente.Name = "textBoxCliente";
            this.textBoxCliente.Size = new System.Drawing.Size(148, 20);
            this.textBoxCliente.TabIndex = 10;
            this.textBoxCliente.TextChanged += new System.EventHandler(this.textBoxCliente_TextChanged);
            // 
            // labelProducto
            // 
            this.labelProducto.AutoSize = true;
            this.labelProducto.Location = new System.Drawing.Point(185, 101);
            this.labelProducto.Name = "labelProducto";
            this.labelProducto.Size = new System.Drawing.Size(50, 13);
            this.labelProducto.TabIndex = 11;
            this.labelProducto.Text = "Producto";
            // 
            // labelCantidad
            // 
            this.labelCantidad.AutoSize = true;
            this.labelCantidad.Location = new System.Drawing.Point(387, 172);
            this.labelCantidad.Name = "labelCantidad";
            this.labelCantidad.Size = new System.Drawing.Size(49, 13);
            this.labelCantidad.TabIndex = 12;
            this.labelCantidad.Text = "Cantidad";
            // 
            // txtBoxCantidad
            // 
            this.txtBoxCantidad.Location = new System.Drawing.Point(442, 169);
            this.txtBoxCantidad.Name = "txtBoxCantidad";
            this.txtBoxCantidad.Size = new System.Drawing.Size(43, 20);
            this.txtBoxCantidad.TabIndex = 13;
            // 
            // buttonSalir
            // 
            this.buttonSalir.Location = new System.Drawing.Point(464, 554);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(75, 30);
            this.buttonSalir.TabIndex = 14;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // labelDisponible
            // 
            this.labelDisponible.AutoSize = true;
            this.labelDisponible.Location = new System.Drawing.Point(90, 172);
            this.labelDisponible.Name = "labelDisponible";
            this.labelDisponible.Size = new System.Drawing.Size(56, 13);
            this.labelDisponible.TabIndex = 15;
            this.labelDisponible.Text = "Disponible";
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.Location = new System.Drawing.Point(247, 172);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(37, 13);
            this.labelPrecio.TabIndex = 16;
            this.labelPrecio.Text = "Precio";
            // 
            // labelNroDisponible
            // 
            this.labelNroDisponible.AutoSize = true;
            this.labelNroDisponible.Location = new System.Drawing.Point(152, 172);
            this.labelNroDisponible.Name = "labelNroDisponible";
            this.labelNroDisponible.Size = new System.Drawing.Size(37, 13);
            this.labelNroDisponible.TabIndex = 17;
            this.labelNroDisponible.Text = "labelD";
            // 
            // labelNroPrecio
            // 
            this.labelNroPrecio.AutoSize = true;
            this.labelNroPrecio.Location = new System.Drawing.Point(290, 172);
            this.labelNroPrecio.Name = "labelNroPrecio";
            this.labelNroPrecio.Size = new System.Drawing.Size(36, 13);
            this.labelNroPrecio.TabIndex = 18;
            this.labelNroPrecio.Text = "labelP";
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(551, 596);
            this.Controls.Add(this.labelNroPrecio);
            this.Controls.Add(this.labelNroDisponible);
            this.Controls.Add(this.labelPrecio);
            this.Controls.Add(this.labelDisponible);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.txtBoxCantidad);
            this.Controls.Add(this.labelCantidad);
            this.Controls.Add(this.labelProducto);
            this.Controls.Add(this.textBoxCliente);
            this.Controls.Add(this.labelCliente);
            this.Controls.Add(this.buttonComprar);
            this.Controls.Add(this.buttonQuitar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelNroTotal);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Productos";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.Productos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelNroTotal;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonQuitar;
        private System.Windows.Forms.Button buttonComprar;
        private System.Windows.Forms.Label labelCliente;
        private System.Windows.Forms.TextBox textBoxCliente;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label labelProducto;
        private System.Windows.Forms.Label labelCantidad;
        private System.Windows.Forms.TextBox txtBoxCantidad;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.Label labelDisponible;
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.Label labelNroDisponible;
        private System.Windows.Forms.Label labelNroPrecio;
    }
}