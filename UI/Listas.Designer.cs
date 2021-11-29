
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.checkBox_Clientes = new System.Windows.Forms.CheckBox();
            this.checkBox_Estado = new System.Windows.Forms.CheckBox();
            this.checkBox_Empleados = new System.Windows.Forms.CheckBox();
            this.checkBox_Pago = new System.Windows.Forms.CheckBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Listas";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(713, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // checkBox_Clientes
            // 
            this.checkBox_Clientes.AutoSize = true;
            this.checkBox_Clientes.Location = new System.Drawing.Point(16, 52);
            this.checkBox_Clientes.Name = "checkBox_Clientes";
            this.checkBox_Clientes.Size = new System.Drawing.Size(63, 17);
            this.checkBox_Clientes.TabIndex = 3;
            this.checkBox_Clientes.Text = "Clientes";
            this.checkBox_Clientes.UseVisualStyleBackColor = true;
            // 
            // checkBox_Estado
            // 
            this.checkBox_Estado.AutoSize = true;
            this.checkBox_Estado.Location = new System.Drawing.Point(226, 52);
            this.checkBox_Estado.Name = "checkBox_Estado";
            this.checkBox_Estado.Size = new System.Drawing.Size(59, 17);
            this.checkBox_Estado.TabIndex = 4;
            this.checkBox_Estado.Text = "Estado";
            this.checkBox_Estado.UseVisualStyleBackColor = true;
            // 
            // checkBox_Empleados
            // 
            this.checkBox_Empleados.AutoSize = true;
            this.checkBox_Empleados.Location = new System.Drawing.Point(85, 52);
            this.checkBox_Empleados.Name = "checkBox_Empleados";
            this.checkBox_Empleados.Size = new System.Drawing.Size(78, 17);
            this.checkBox_Empleados.TabIndex = 5;
            this.checkBox_Empleados.Text = "Empleados";
            this.checkBox_Empleados.UseVisualStyleBackColor = true;
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
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.checkBox_Pago);
            this.Controls.Add(this.checkBox_Empleados);
            this.Controls.Add(this.checkBox_Estado);
            this.Controls.Add(this.checkBox_Clientes);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Listas";
            this.Text = "Listas";
            this.Load += new System.EventHandler(this.Listas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox checkBox_Clientes;
        private System.Windows.Forms.CheckBox checkBox_Estado;
        private System.Windows.Forms.CheckBox checkBox_Empleados;
        private System.Windows.Forms.CheckBox checkBox_Pago;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}