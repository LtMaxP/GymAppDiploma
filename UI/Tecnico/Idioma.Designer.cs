
namespace UI.Tecnico
{
    partial class Idioma
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelAlta = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.labelModificar = new System.Windows.Forms.Button();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.labelElegir = new System.Windows.Forms.Button();
            this.labelIdioma = new System.Windows.Forms.Label();
            this.LabelIdi = new System.Windows.Forms.Label();
            this.labelBaja = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(31, 317);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(96, 20);
            this.textBox1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(226, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(315, 464);
            this.dataGridView1.TabIndex = 2;
            // 
            // labelAlta
            // 
            this.labelAlta.Location = new System.Drawing.Point(133, 316);
            this.labelAlta.Name = "labelAlta";
            this.labelAlta.Size = new System.Drawing.Size(57, 21);
            this.labelAlta.TabIndex = 3;
            this.labelAlta.Tag = "1045";
            this.labelAlta.Text = "Alta";
            this.labelAlta.UseVisualStyleBackColor = true;
            this.labelAlta.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(28, 111);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(142, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(28, 301);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(44, 13);
            this.labelNombre.TabIndex = 5;
            this.labelNombre.Text = "Nombre";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(176, 111);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(24, 22);
            this.button2.TabIndex = 6;
            this.button2.Tag = "1048";
            this.button2.Text = "->";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelModificar
            // 
            this.labelModificar.Location = new System.Drawing.Point(133, 204);
            this.labelModificar.Name = "labelModificar";
            this.labelModificar.Size = new System.Drawing.Size(67, 22);
            this.labelModificar.TabIndex = 7;
            this.labelModificar.Tag = "1047";
            this.labelModificar.Text = "Modificar";
            this.labelModificar.UseVisualStyleBackColor = true;
            this.labelModificar.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonSalir
            // 
            this.buttonSalir.Location = new System.Drawing.Point(466, 534);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(75, 34);
            this.buttonSalir.TabIndex = 8;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.button4_Click);
            // 
            // labelElegir
            // 
            this.labelElegir.Location = new System.Drawing.Point(28, 148);
            this.labelElegir.Name = "labelElegir";
            this.labelElegir.Size = new System.Drawing.Size(62, 22);
            this.labelElegir.TabIndex = 9;
            this.labelElegir.Tag = "1048";
            this.labelElegir.Text = "Elegir";
            this.labelElegir.UseVisualStyleBackColor = true;
            this.labelElegir.Click += new System.EventHandler(this.button5_Click);
            // 
            // labelIdioma
            // 
            this.labelIdioma.AutoSize = true;
            this.labelIdioma.Font = new System.Drawing.Font("Niagara Solid", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdioma.Location = new System.Drawing.Point(19, 45);
            this.labelIdioma.Name = "labelIdioma";
            this.labelIdioma.Size = new System.Drawing.Size(100, 51);
            this.labelIdioma.TabIndex = 10;
            this.labelIdioma.Text = "Idioma";
            // 
            // LabelIdi
            // 
            this.LabelIdi.AutoSize = true;
            this.LabelIdi.Location = new System.Drawing.Point(226, 45);
            this.LabelIdi.Name = "LabelIdi";
            this.LabelIdi.Size = new System.Drawing.Size(0, 13);
            this.LabelIdi.TabIndex = 11;
            // 
            // labelBaja
            // 
            this.labelBaja.Location = new System.Drawing.Point(81, 176);
            this.labelBaja.Name = "labelBaja";
            this.labelBaja.Size = new System.Drawing.Size(61, 22);
            this.labelBaja.TabIndex = 12;
            this.labelBaja.Tag = "1046";
            this.labelBaja.Text = "Baja";
            this.labelBaja.UseVisualStyleBackColor = true;
            this.labelBaja.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // Idioma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(581, 591);
            this.ControlBox = false;
            this.Controls.Add(this.labelBaja);
            this.Controls.Add(this.LabelIdi);
            this.Controls.Add(this.labelIdioma);
            this.Controls.Add(this.labelElegir);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.labelModificar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.labelAlta);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Name = "Idioma";
            this.Text = "Idioma";
            this.Load += new System.EventHandler(this.Idioma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button labelAlta;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button labelModificar;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.Button labelElegir;
        private System.Windows.Forms.Label labelIdioma;
        private System.Windows.Forms.Label LabelIdi;
        private System.Windows.Forms.Button labelBaja;
    }
}