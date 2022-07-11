namespace UI
{
    partial class BackupRestore
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
            this.btnEjecutarRestore = new System.Windows.Forms.Button();
            this.DgBackup = new System.Windows.Forms.DataGridView();
            this.Checks = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnVerBackUp = new System.Windows.Forms.Button();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.btnEjecutarBackUp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgBackup)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEjecutarRestore
            // 
            this.btnEjecutarRestore.Location = new System.Drawing.Point(571, 53);
            this.btnEjecutarRestore.Name = "btnEjecutarRestore";
            this.btnEjecutarRestore.Size = new System.Drawing.Size(215, 52);
            this.btnEjecutarRestore.TabIndex = 44;
            this.btnEjecutarRestore.Text = "Realizar Restore";
            this.btnEjecutarRestore.UseVisualStyleBackColor = true;
            this.btnEjecutarRestore.Click += new System.EventHandler(this.btnEjecutarRestore_Click);
            // 
            // DgBackup
            // 
            this.DgBackup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgBackup.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Checks});
            this.DgBackup.Location = new System.Drawing.Point(12, 151);
            this.DgBackup.Name = "DgBackup";
            this.DgBackup.Size = new System.Drawing.Size(1060, 222);
            this.DgBackup.TabIndex = 40;
            this.DgBackup.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgBackup_CellContentClick);
            // 
            // Checks
            // 
            this.Checks.HeaderText = "Check";
            this.Checks.Name = "Checks";
            // 
            // btnVerBackUp
            // 
            this.btnVerBackUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnVerBackUp.Location = new System.Drawing.Point(12, 379);
            this.btnVerBackUp.Name = "btnVerBackUp";
            this.btnVerBackUp.Size = new System.Drawing.Size(102, 26);
            this.btnVerBackUp.TabIndex = 39;
            this.btnVerBackUp.Text = "Cargar Backups";
            this.btnVerBackUp.UseVisualStyleBackColor = false;
            this.btnVerBackUp.Click += new System.EventHandler(this.btnVerBackUp_Click);
            // 
            // buttonSalir
            // 
            this.buttonSalir.Location = new System.Drawing.Point(979, 446);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(93, 34);
            this.buttonSalir.TabIndex = 38;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.btnVolverBackUp_Click);
            // 
            // btnEjecutarBackUp
            // 
            this.btnEjecutarBackUp.Location = new System.Drawing.Point(160, 53);
            this.btnEjecutarBackUp.Name = "btnEjecutarBackUp";
            this.btnEjecutarBackUp.Size = new System.Drawing.Size(215, 52);
            this.btnEjecutarBackUp.TabIndex = 36;
            this.btnEjecutarBackUp.Text = "Realizar Backup";
            this.btnEjecutarBackUp.UseVisualStyleBackColor = true;
            this.btnEjecutarBackUp.Click += new System.EventHandler(this.btnEjecutarBackUp_Click);
            // 
            // BackupRestore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1091, 492);
            this.ControlBox = false;
            this.Controls.Add(this.btnEjecutarRestore);
            this.Controls.Add(this.DgBackup);
            this.Controls.Add(this.btnVerBackUp);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.btnEjecutarBackUp);
            this.Name = "BackupRestore";
            this.Text = "BackupRestore";
            this.Load += new System.EventHandler(this.BackupRestore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgBackup)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button btnEjecutarRestore;
        private System.Windows.Forms.DataGridView DgBackup;
        internal System.Windows.Forms.Button btnVerBackUp;
        internal System.Windows.Forms.Button buttonSalir;
        internal System.Windows.Forms.Button btnEjecutarBackUp;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Checks;
    }
}