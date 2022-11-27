
namespace UI.Negocio
{
    partial class Stock
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
            this.buttonSalir = new System.Windows.Forms.Button();
            this.labelNroDisponible = new System.Windows.Forms.Label();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.labelDisponible = new System.Windows.Forms.Label();
            this.txtBoxCantidad = new System.Windows.Forms.TextBox();
            this.labelCantidad = new System.Windows.Forms.Label();
            this.labelProducto = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtBoxPrecio = new System.Windows.Forms.TextBox();
            this.buttonCargar = new System.Windows.Forms.Button();
            this.lblStock = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSalir
            // 
            this.buttonSalir.Location = new System.Drawing.Point(418, 291);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(75, 23);
            this.buttonSalir.TabIndex = 0;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelNroDisponible
            // 
            this.labelNroDisponible.AutoSize = true;
            this.labelNroDisponible.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNroDisponible.Location = new System.Drawing.Point(98, 168);
            this.labelNroDisponible.Name = "labelNroDisponible";
            this.labelNroDisponible.Size = new System.Drawing.Size(49, 16);
            this.labelNroDisponible.TabIndex = 25;
            this.labelNroDisponible.Text = "labelD";
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecio.Location = new System.Drawing.Point(173, 168);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(49, 16);
            this.labelPrecio.TabIndex = 24;
            this.labelPrecio.Text = "Precio";
            // 
            // labelDisponible
            // 
            this.labelDisponible.AutoSize = true;
            this.labelDisponible.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDisponible.Location = new System.Drawing.Point(17, 168);
            this.labelDisponible.Name = "labelDisponible";
            this.labelDisponible.Size = new System.Drawing.Size(75, 16);
            this.labelDisponible.TabIndex = 23;
            this.labelDisponible.Text = "Disponible";
            // 
            // txtBoxCantidad
            // 
            this.txtBoxCantidad.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCantidad.Location = new System.Drawing.Point(361, 165);
            this.txtBoxCantidad.Name = "txtBoxCantidad";
            this.txtBoxCantidad.Size = new System.Drawing.Size(43, 22);
            this.txtBoxCantidad.TabIndex = 22;
            // 
            // labelCantidad
            // 
            this.labelCantidad.AutoSize = true;
            this.labelCantidad.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCantidad.Location = new System.Drawing.Point(290, 168);
            this.labelCantidad.Name = "labelCantidad";
            this.labelCantidad.Size = new System.Drawing.Size(65, 16);
            this.labelCantidad.TabIndex = 21;
            this.labelCantidad.Text = "Cantidad";
            // 
            // labelProducto
            // 
            this.labelProducto.AutoSize = true;
            this.labelProducto.Font = new System.Drawing.Font("Algerian", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProducto.ForeColor = System.Drawing.Color.SaddleBrown;
            this.labelProducto.Location = new System.Drawing.Point(54, 73);
            this.labelProducto.Name = "labelProducto";
            this.labelProducto.Size = new System.Drawing.Size(110, 21);
            this.labelProducto.TabIndex = 20;
            this.labelProducto.Text = "Producto";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(57, 103);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(286, 21);
            this.comboBox1.TabIndex = 19;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtBoxPrecio
            // 
            this.txtBoxPrecio.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPrecio.Location = new System.Drawing.Point(228, 165);
            this.txtBoxPrecio.Name = "txtBoxPrecio";
            this.txtBoxPrecio.Size = new System.Drawing.Size(43, 22);
            this.txtBoxPrecio.TabIndex = 22;
            // 
            // buttonCargar
            // 
            this.buttonCargar.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonCargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCargar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonCargar.Location = new System.Drawing.Point(188, 213);
            this.buttonCargar.Name = "buttonCargar";
            this.buttonCargar.Size = new System.Drawing.Size(75, 31);
            this.buttonCargar.TabIndex = 26;
            this.buttonCargar.Text = "Cargar";
            this.buttonCargar.UseVisualStyleBackColor = false;
            this.buttonCargar.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Microsoft PhagsPa", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.ForeColor = System.Drawing.Color.Maroon;
            this.lblStock.Location = new System.Drawing.Point(12, 9);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(108, 44);
            this.lblStock.TabIndex = 27;
            this.lblStock.Text = "Stock";
            // 
            // Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(509, 325);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.buttonCargar);
            this.Controls.Add(this.labelNroDisponible);
            this.Controls.Add(this.labelPrecio);
            this.Controls.Add(this.labelDisponible);
            this.Controls.Add(this.txtBoxPrecio);
            this.Controls.Add(this.txtBoxCantidad);
            this.Controls.Add(this.labelCantidad);
            this.Controls.Add(this.labelProducto);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buttonSalir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Stock";
            this.Text = "Gestion de Stock";
            this.Load += new System.EventHandler(this.Stock_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.Label labelNroDisponible;
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.Label labelDisponible;
        private System.Windows.Forms.TextBox txtBoxCantidad;
        private System.Windows.Forms.Label labelCantidad;
        private System.Windows.Forms.Label labelProducto;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtBoxPrecio;
        private System.Windows.Forms.Button buttonCargar;
        private System.Windows.Forms.Label lblStock;
    }
}