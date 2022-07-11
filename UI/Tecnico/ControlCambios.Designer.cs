
namespace UI.Tecnico
{
    partial class ControlCambios
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelControlCambios = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.labelEntidad = new System.Windows.Forms.Label();
            this.labelUsuarioOriginal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelUsuarioModificado = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(749, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // labelControlCambios
            // 
            this.labelControlCambios.AutoSize = true;
            this.labelControlCambios.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControlCambios.Location = new System.Drawing.Point(247, 9);
            this.labelControlCambios.Name = "labelControlCambios";
            this.labelControlCambios.Size = new System.Drawing.Size(310, 42);
            this.labelControlCambios.TabIndex = 1;
            this.labelControlCambios.Text = "Control Cambios";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(636, 267);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 42);
            this.button1.TabIndex = 2;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // labelEntidad
            // 
            this.labelEntidad.AutoSize = true;
            this.labelEntidad.Location = new System.Drawing.Point(25, 80);
            this.labelEntidad.Name = "labelEntidad";
            this.labelEntidad.Size = new System.Drawing.Size(65, 13);
            this.labelEntidad.TabIndex = 3;
            this.labelEntidad.Text = "labelEntidad";
            // 
            // labelUsuarioOriginal
            // 
            this.labelUsuarioOriginal.AutoSize = true;
            this.labelUsuarioOriginal.Location = new System.Drawing.Point(251, 336);
            this.labelUsuarioOriginal.Name = "labelUsuarioOriginal";
            this.labelUsuarioOriginal.Size = new System.Drawing.Size(100, 13);
            this.labelUsuarioOriginal.TabIndex = 4;
            this.labelUsuarioOriginal.Text = "labelUsuarioOriginal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(370, 337);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // labelUsuarioModificado
            // 
            this.labelUsuarioModificado.AutoSize = true;
            this.labelUsuarioModificado.Location = new System.Drawing.Point(539, 336);
            this.labelUsuarioModificado.Name = "labelUsuarioModificado";
            this.labelUsuarioModificado.Size = new System.Drawing.Size(117, 13);
            this.labelUsuarioModificado.TabIndex = 6;
            this.labelUsuarioModificado.Text = "labelUsuarioModificado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(681, 336);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "label2";
            // 
            // buttonSalir
            // 
            this.buttonSalir.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonSalir.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonSalir.Location = new System.Drawing.Point(714, 398);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(72, 38);
            this.buttonSalir.TabIndex = 8;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = false;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // ControlCambios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelUsuarioModificado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelUsuarioOriginal);
            this.Controls.Add(this.labelEntidad);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelControlCambios);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ControlCambios";
            this.Text = "ControlCambios";
            this.Load += new System.EventHandler(this.ControlCambios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelControlCambios;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelEntidad;
        private System.Windows.Forms.Label labelUsuarioOriginal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelUsuarioModificado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSalir;
    }
}