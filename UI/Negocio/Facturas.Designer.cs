
namespace UI
{
    partial class Facturas
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
            this.labelFacturas = new System.Windows.Forms.Label();
            this.labelSalir = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.labelBuscar = new System.Windows.Forms.Button();
            this.lblIntroduzcaDNI = new System.Windows.Forms.Label();
            this.btn_Exportar = new System.Windows.Forms.Button();
            this.dataGridViewFactura = new System.Windows.Forms.DataGridView();
            this.btn_PDF = new System.Windows.Forms.Button();
            this.LabelExportar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFactura)).BeginInit();
            this.SuspendLayout();
            // 
            // labelFacturas
            // 
            this.labelFacturas.AutoSize = true;
            this.labelFacturas.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelFacturas.Font = new System.Drawing.Font("Poor Richard", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFacturas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelFacturas.Location = new System.Drawing.Point(2, 0);
            this.labelFacturas.Name = "labelFacturas";
            this.labelFacturas.Size = new System.Drawing.Size(98, 31);
            this.labelFacturas.TabIndex = 0;
            this.labelFacturas.Text = "Facturas";
            // 
            // labelSalir
            // 
            this.labelSalir.Location = new System.Drawing.Point(424, 410);
            this.labelSalir.Name = "labelSalir";
            this.labelSalir.Size = new System.Drawing.Size(75, 28);
            this.labelSalir.TabIndex = 2;
            this.labelSalir.Text = "Salir";
            this.labelSalir.UseVisualStyleBackColor = true;
            this.labelSalir.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(41, 66);
            this.textBox.MaxLength = 8;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(214, 20);
            this.textBox.TabIndex = 3;
            this.textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // labelBuscar
            // 
            this.labelBuscar.Location = new System.Drawing.Point(276, 65);
            this.labelBuscar.Name = "labelBuscar";
            this.labelBuscar.Size = new System.Drawing.Size(129, 21);
            this.labelBuscar.TabIndex = 4;
            this.labelBuscar.Text = "Buscar";
            this.labelBuscar.UseVisualStyleBackColor = true;
            this.labelBuscar.Click += new System.EventHandler(this.labelBuscar_Click);
            // 
            // lblIntroduzcaDNI
            // 
            this.lblIntroduzcaDNI.AutoSize = true;
            this.lblIntroduzcaDNI.Location = new System.Drawing.Point(38, 50);
            this.lblIntroduzcaDNI.Name = "lblIntroduzcaDNI";
            this.lblIntroduzcaDNI.Size = new System.Drawing.Size(79, 13);
            this.lblIntroduzcaDNI.TabIndex = 7;
            this.lblIntroduzcaDNI.Text = "Introduzca DNI";
            // 
            // btn_Exportar
            // 
            this.btn_Exportar.Location = new System.Drawing.Point(90, 354);
            this.btn_Exportar.Name = "btn_Exportar";
            this.btn_Exportar.Size = new System.Drawing.Size(59, 23);
            this.btn_Exportar.TabIndex = 8;
            this.btn_Exportar.Text = "Serializar";
            this.btn_Exportar.UseVisualStyleBackColor = true;
            this.btn_Exportar.Click += new System.EventHandler(this.btn_Exportar_Click);
            // 
            // dataGridViewFactura
            // 
            this.dataGridViewFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFactura.Location = new System.Drawing.Point(41, 103);
            this.dataGridViewFactura.Name = "dataGridViewFactura";
            this.dataGridViewFactura.Size = new System.Drawing.Size(364, 227);
            this.dataGridViewFactura.TabIndex = 10;
            // 
            // btn_PDF
            // 
            this.btn_PDF.Location = new System.Drawing.Point(155, 354);
            this.btn_PDF.Name = "btn_PDF";
            this.btn_PDF.Size = new System.Drawing.Size(58, 23);
            this.btn_PDF.TabIndex = 9;
            this.btn_PDF.Text = "PDF";
            this.btn_PDF.UseVisualStyleBackColor = true;
            this.btn_PDF.Click += new System.EventHandler(this.btn_PDF_Click);
            // 
            // LabelExportar
            // 
            this.LabelExportar.AutoSize = true;
            this.LabelExportar.Location = new System.Drawing.Point(38, 359);
            this.LabelExportar.Name = "LabelExportar";
            this.LabelExportar.Size = new System.Drawing.Size(46, 13);
            this.LabelExportar.TabIndex = 11;
            this.LabelExportar.Text = "Exportar";
            // 
            // Facturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 450);
            this.ControlBox = false;
            this.Controls.Add(this.LabelExportar);
            this.Controls.Add(this.dataGridViewFactura);
            this.Controls.Add(this.btn_PDF);
            this.Controls.Add(this.btn_Exportar);
            this.Controls.Add(this.lblIntroduzcaDNI);
            this.Controls.Add(this.labelBuscar);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.labelSalir);
            this.Controls.Add(this.labelFacturas);
            this.Name = "Facturas";
            this.Text = "Facturas";
            this.Load += new System.EventHandler(this.Facturas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFactura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFacturas;
        private System.Windows.Forms.Button labelSalir;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button labelBuscar;
        private System.Windows.Forms.Label lblIntroduzcaDNI;
        private System.Windows.Forms.Button btn_Exportar;
        private System.Windows.Forms.DataGridView dataGridViewFactura;
        private System.Windows.Forms.Button btn_PDF;
        private System.Windows.Forms.Label LabelExportar;
    }
}