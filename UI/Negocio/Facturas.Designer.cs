﻿
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelSalir = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.labelBuscar = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Exportar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Poor Richard", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Facturas";
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
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(214, 20);
            this.textBox.TabIndex = 3;
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
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(41, 92);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(431, 225);
            this.listBox.TabIndex = 5;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Introduzca DNI";
            // 
            // btn_Exportar
            // 
            this.btn_Exportar.Location = new System.Drawing.Point(41, 336);
            this.btn_Exportar.Name = "btn_Exportar";
            this.btn_Exportar.Size = new System.Drawing.Size(75, 23);
            this.btn_Exportar.TabIndex = 8;
            this.btn_Exportar.Text = "Exportar";
            this.btn_Exportar.UseVisualStyleBackColor = true;
            this.btn_Exportar.Click += new System.EventHandler(this.btn_Exportar_Click);
            // 
            // Facturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Exportar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.labelBuscar);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.labelSalir);
            this.Controls.Add(this.label1);
            this.Name = "Facturas";
            this.Text = "Facturas";
            this.Load += new System.EventHandler(this.Facturas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button labelSalir;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button labelBuscar;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Exportar;
    }
}