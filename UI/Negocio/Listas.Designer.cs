
namespace UI
{
    partial class Listas
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
            this.labelListas = new System.Windows.Forms.Label();
            this.labelSalir = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.labelClientes = new System.Windows.Forms.CheckBox();
            this.labelEstado = new System.Windows.Forms.CheckBox();
            this.labelEmpleados = new System.Windows.Forms.CheckBox();
            this.checkBox_Pago = new System.Windows.Forms.CheckBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // labelListas
            // 
            this.labelListas.AutoSize = true;
            this.labelListas.Location = new System.Drawing.Point(13, 13);
            this.labelListas.Name = "labelListas";
            this.labelListas.Size = new System.Drawing.Size(34, 13);
            this.labelListas.TabIndex = 0;
            this.labelListas.Text = "Listas";
            this.labelListas.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelSalir
            // 
            this.labelSalir.Location = new System.Drawing.Point(713, 415);
            this.labelSalir.Name = "labelSalir";
            this.labelSalir.Size = new System.Drawing.Size(75, 23);
            this.labelSalir.TabIndex = 1;
            this.labelSalir.Text = "Salir";
            this.labelSalir.UseVisualStyleBackColor = true;
            this.labelSalir.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(21, 395);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Ver";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelClientes
            // 
            this.labelClientes.AutoSize = true;
            this.labelClientes.Location = new System.Drawing.Point(16, 52);
            this.labelClientes.Name = "labelClientes";
            this.labelClientes.Size = new System.Drawing.Size(63, 17);
            this.labelClientes.TabIndex = 3;
            this.labelClientes.Text = "Clientes";
            this.labelClientes.UseVisualStyleBackColor = true;
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.Location = new System.Drawing.Point(226, 52);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(59, 17);
            this.labelEstado.TabIndex = 4;
            this.labelEstado.Text = "Estado";
            this.labelEstado.UseVisualStyleBackColor = true;
            // 
            // labelEmpleados
            // 
            this.labelEmpleados.AutoSize = true;
            this.labelEmpleados.Location = new System.Drawing.Point(85, 52);
            this.labelEmpleados.Name = "labelEmpleados";
            this.labelEmpleados.Size = new System.Drawing.Size(78, 17);
            this.labelEmpleados.TabIndex = 5;
            this.labelEmpleados.Text = "Empleados";
            this.labelEmpleados.UseVisualStyleBackColor = true;
            // 
            // checkBox_Pago
            // 
            this.checkBox_Pago.AutoSize = true;
            this.checkBox_Pago.Location = new System.Drawing.Point(169, 52);
            this.checkBox_Pago.Name = "checkBox_Pago";
            this.checkBox_Pago.Size = new System.Drawing.Size(51, 17);
            this.checkBox_Pago.TabIndex = 6;
            this.checkBox_Pago.Text = "Pago";
            this.checkBox_Pago.UseVisualStyleBackColor = true;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(16, 85);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(748, 291);
            this.dataGridView.TabIndex = 7;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Listas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.checkBox_Pago);
            this.Controls.Add(this.labelEmpleados);
            this.Controls.Add(this.labelEstado);
            this.Controls.Add(this.labelClientes);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.labelSalir);
            this.Controls.Add(this.labelListas);
            this.Name = "Listas";
            this.Text = "Listas";
            this.Load += new System.EventHandler(this.Listas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelListas;
        private System.Windows.Forms.Button labelSalir;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox labelClientes;
        private System.Windows.Forms.CheckBox labelEstado;
        private System.Windows.Forms.CheckBox labelEmpleados;
        private System.Windows.Forms.CheckBox checkBox_Pago;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}