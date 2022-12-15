
namespace UI
{
    partial class Permisos
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
            this.labelPatente = new System.Windows.Forms.Label();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.buttonAgregar2 = new System.Windows.Forms.Button();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.labelFamilia = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.labelPermisosGestion = new System.Windows.Forms.Label();
            this.ListaPerm = new System.Windows.Forms.TreeView();
            this.button1 = new System.Windows.Forms.Button();
            this.Eliminarbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelPatente
            // 
            this.labelPatente.AutoSize = true;
            this.labelPatente.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPatente.Location = new System.Drawing.Point(388, 220);
            this.labelPatente.Name = "labelPatente";
            this.labelPatente.Size = new System.Drawing.Size(92, 21);
            this.labelPatente.TabIndex = 0;
            this.labelPatente.Text = "Patente";
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAgregar.Location = new System.Drawing.Point(350, 157);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(75, 28);
            this.buttonAgregar.TabIndex = 1;
            this.buttonAgregar.Tag = "AgregarBtn";
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.AgregarBtn_Click);
            // 
            // buttonAgregar2
            // 
            this.buttonAgregar2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAgregar2.Location = new System.Drawing.Point(392, 271);
            this.buttonAgregar2.Name = "buttonAgregar2";
            this.buttonAgregar2.Size = new System.Drawing.Size(75, 28);
            this.buttonAgregar2.TabIndex = 2;
            this.buttonAgregar2.Tag = "AgregarBtn";
            this.buttonAgregar2.Text = "Agregar";
            this.buttonAgregar2.UseVisualStyleBackColor = true;
            this.buttonAgregar2.Click += new System.EventHandler(this.AgregarBtn2_Click);
            // 
            // buttonSalir
            // 
            this.buttonSalir.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalir.Location = new System.Drawing.Point(514, 427);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(83, 38);
            this.buttonSalir.TabIndex = 4;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.SalirBtn_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(335, 129);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(207, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(335, 244);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(207, 21);
            this.comboBox2.TabIndex = 7;
            // 
            // labelFamilia
            // 
            this.labelFamilia.AutoSize = true;
            this.labelFamilia.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFamilia.Location = new System.Drawing.Point(385, 105);
            this.labelFamilia.Name = "labelFamilia";
            this.labelFamilia.Size = new System.Drawing.Size(95, 21);
            this.labelFamilia.TabIndex = 8;
            this.labelFamilia.Text = "Familias";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.Location = new System.Drawing.Point(26, 333);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(70, 18);
            this.labelNombre.TabIndex = 9;
            this.labelNombre.Tag = "Nombre";
            this.labelNombre.Text = "Nombre";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(114, 357);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(91, 41);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Tag = "Guardar";
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Location = new System.Drawing.Point(102, 331);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(173, 20);
            this.txtName.TabIndex = 11;
            // 
            // labelPermisosGestion
            // 
            this.labelPermisosGestion.AutoSize = true;
            this.labelPermisosGestion.Font = new System.Drawing.Font("Arial", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPermisosGestion.Location = new System.Drawing.Point(152, 9);
            this.labelPermisosGestion.Name = "labelPermisosGestion";
            this.labelPermisosGestion.Size = new System.Drawing.Size(298, 28);
            this.labelPermisosGestion.TabIndex = 12;
            this.labelPermisosGestion.Text = "Administracion Permisos";
            // 
            // ListaPerm
            // 
            this.ListaPerm.Location = new System.Drawing.Point(29, 104);
            this.ListaPerm.Name = "ListaPerm";
            this.ListaPerm.Size = new System.Drawing.Size(246, 221);
            this.ListaPerm.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(282, 201);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "-->";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Eliminarbtn
            // 
            this.Eliminarbtn.Location = new System.Drawing.Point(451, 158);
            this.Eliminarbtn.Name = "Eliminarbtn";
            this.Eliminarbtn.Size = new System.Drawing.Size(75, 27);
            this.Eliminarbtn.TabIndex = 15;
            this.Eliminarbtn.Text = "Eliminar";
            this.Eliminarbtn.UseVisualStyleBackColor = true;
            this.Eliminarbtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // Permisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(609, 477);
            this.ControlBox = false;
            this.Controls.Add(this.Eliminarbtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ListaPerm);
            this.Controls.Add(this.labelPermisosGestion);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.labelFamilia);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.buttonAgregar2);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.labelPatente);
            this.Name = "Permisos";
            this.Text = "Permisos";
            this.Load += new System.EventHandler(this.Permisos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPatente;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.Button buttonAgregar2;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label labelFamilia;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label labelPermisosGestion;
        private System.Windows.Forms.TreeView ListaPerm;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Eliminarbtn;
    }
}