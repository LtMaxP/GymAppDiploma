namespace UI
{
    partial class Bitacora
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
            this.buttonCargarBitacora = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.labelFechaDesde = new System.Windows.Forms.Label();
            this.labelFechaHasta = new System.Windows.Forms.Label();
            this.labelProblema = new System.Windows.Forms.Label();
            this.comboBoxProblema = new System.Windows.Forms.ComboBox();
            this.comboBoxUsuario = new System.Windows.Forms.ComboBox();
            this.labelUser = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCargarBitacora
            // 
            this.buttonCargarBitacora.Location = new System.Drawing.Point(33, 125);
            this.buttonCargarBitacora.Name = "buttonCargarBitacora";
            this.buttonCargarBitacora.Size = new System.Drawing.Size(121, 29);
            this.buttonCargarBitacora.TabIndex = 0;
            this.buttonCargarBitacora.Text = "Cargar Bitacora";
            this.buttonCargarBitacora.UseVisualStyleBackColor = true;
            this.buttonCargarBitacora.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(33, 160);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(498, 307);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // buttonSalir
            // 
            this.buttonSalir.Location = new System.Drawing.Point(456, 473);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(75, 23);
            this.buttonSalir.TabIndex = 3;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.button3_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(33, 28);
            this.dateTimePicker1.MaxDate = new System.DateTime(2108, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(221, 20);
            this.dateTimePicker1.TabIndex = 7;
            this.dateTimePicker1.Value = new System.DateTime(2022, 6, 2, 21, 19, 0, 0);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(35, 67);
            this.dateTimePicker2.MaxDate = new System.DateTime(2108, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker2.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(221, 20);
            this.dateTimePicker2.TabIndex = 8;
            this.dateTimePicker2.Value = new System.DateTime(2022, 7, 21, 21, 19, 0, 0);
            // 
            // labelFechaDesde
            // 
            this.labelFechaDesde.AutoSize = true;
            this.labelFechaDesde.Location = new System.Drawing.Point(32, 14);
            this.labelFechaDesde.Name = "labelFechaDesde";
            this.labelFechaDesde.Size = new System.Drawing.Size(69, 13);
            this.labelFechaDesde.TabIndex = 9;
            this.labelFechaDesde.Text = "Fecha desde";
            // 
            // labelFechaHasta
            // 
            this.labelFechaHasta.AutoSize = true;
            this.labelFechaHasta.Location = new System.Drawing.Point(32, 51);
            this.labelFechaHasta.Name = "labelFechaHasta";
            this.labelFechaHasta.Size = new System.Drawing.Size(66, 13);
            this.labelFechaHasta.TabIndex = 10;
            this.labelFechaHasta.Text = "Fecha hasta";
            // 
            // labelProblema
            // 
            this.labelProblema.AutoSize = true;
            this.labelProblema.Location = new System.Drawing.Point(332, 14);
            this.labelProblema.Name = "labelProblema";
            this.labelProblema.Size = new System.Drawing.Size(51, 13);
            this.labelProblema.TabIndex = 11;
            this.labelProblema.Text = "Problema";
            // 
            // comboBoxProblema
            // 
            this.comboBoxProblema.FormattingEnabled = true;
            this.comboBoxProblema.Items.AddRange(new object[] {
            "Ninguno",
            "Bajo",
            "Medio",
            "Alto"});
            this.comboBoxProblema.Location = new System.Drawing.Point(335, 26);
            this.comboBoxProblema.Name = "comboBoxProblema";
            this.comboBoxProblema.Size = new System.Drawing.Size(121, 21);
            this.comboBoxProblema.TabIndex = 12;
            // 
            // comboBoxUsuario
            // 
            this.comboBoxUsuario.FormattingEnabled = true;
            this.comboBoxUsuario.Location = new System.Drawing.Point(335, 66);
            this.comboBoxUsuario.Name = "comboBoxUsuario";
            this.comboBoxUsuario.Size = new System.Drawing.Size(121, 21);
            this.comboBoxUsuario.TabIndex = 14;
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Location = new System.Drawing.Point(332, 51);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(43, 13);
            this.labelUser.TabIndex = 13;
            this.labelUser.Text = "Usuario";
            // 
            // Bitacora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 508);
            this.ControlBox = false;
            this.Controls.Add(this.comboBoxUsuario);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.comboBoxProblema);
            this.Controls.Add(this.labelProblema);
            this.Controls.Add(this.labelFechaHasta);
            this.Controls.Add(this.labelFechaDesde);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonCargarBitacora);
            this.Name = "Bitacora";
            this.Text = "Bitacora";
            this.Load += new System.EventHandler(this.BitacoraYDV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCargarBitacora;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label labelFechaDesde;
        private System.Windows.Forms.Label labelFechaHasta;
        private System.Windows.Forms.Label labelProblema;
        private System.Windows.Forms.ComboBox comboBoxProblema;
        private System.Windows.Forms.ComboBox comboBoxUsuario;
        private System.Windows.Forms.Label labelUser;
    }
}