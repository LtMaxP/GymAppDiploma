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
            this.btnExaminarRestore = new System.Windows.Forms.Button();
            this.txtDirectorioRestore = new System.Windows.Forms.TextBox();
            this.lblDirectorioRestore = new System.Windows.Forms.Label();
            this.btnVerRestore = new System.Windows.Forms.Button();
            this.DgBackup = new System.Windows.Forms.DataGridView();
            this.btnVerBackUp = new System.Windows.Forms.Button();
            this.btnVolverBackUp = new System.Windows.Forms.Button();
            this.btnEjecutarBackUp = new System.Windows.Forms.Button();
            this.btnExaminarBackUp = new System.Windows.Forms.Button();
            this.txtDirectorioBackUp = new System.Windows.Forms.TextBox();
            this.lblDirectorioBackUp = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgBackup)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEjecutarRestore
            // 
            this.btnEjecutarRestore.Location = new System.Drawing.Point(70, 119);
            this.btnEjecutarRestore.Name = "btnEjecutarRestore";
            this.btnEjecutarRestore.Size = new System.Drawing.Size(98, 26);
            this.btnEjecutarRestore.TabIndex = 44;
            this.btnEjecutarRestore.Text = "Realizar Restore";
            this.btnEjecutarRestore.UseVisualStyleBackColor = true;
            // 
            // btnExaminarRestore
            // 
            this.btnExaminarRestore.Location = new System.Drawing.Point(329, 93);
            this.btnExaminarRestore.Name = "btnExaminarRestore";
            this.btnExaminarRestore.Size = new System.Drawing.Size(75, 20);
            this.btnExaminarRestore.TabIndex = 43;
            this.btnExaminarRestore.Text = "Examinar";
            this.btnExaminarRestore.UseVisualStyleBackColor = true;
            this.btnExaminarRestore.Click += new System.EventHandler(this.btnExaminarRestore_Click);
            // 
            // txtDirectorioRestore
            // 
            this.txtDirectorioRestore.Location = new System.Drawing.Point(70, 93);
            this.txtDirectorioRestore.Name = "txtDirectorioRestore";
            this.txtDirectorioRestore.ReadOnly = true;
            this.txtDirectorioRestore.Size = new System.Drawing.Size(242, 20);
            this.txtDirectorioRestore.TabIndex = 45;
            // 
            // lblDirectorioRestore
            // 
            this.lblDirectorioRestore.AutoSize = true;
            this.lblDirectorioRestore.Location = new System.Drawing.Point(12, 96);
            this.lblDirectorioRestore.Name = "lblDirectorioRestore";
            this.lblDirectorioRestore.Size = new System.Drawing.Size(52, 13);
            this.lblDirectorioRestore.TabIndex = 42;
            this.lblDirectorioRestore.Text = "Directorio";
            // 
            // btnVerRestore
            // 
            this.btnVerRestore.Location = new System.Drawing.Point(120, 379);
            this.btnVerRestore.Name = "btnVerRestore";
            this.btnVerRestore.Size = new System.Drawing.Size(105, 26);
            this.btnVerRestore.TabIndex = 41;
            this.btnVerRestore.Text = "Cargar Restore";
            this.btnVerRestore.UseVisualStyleBackColor = true;
            // 
            // DgBackup
            // 
            this.DgBackup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgBackup.Location = new System.Drawing.Point(12, 151);
            this.DgBackup.Name = "DgBackup";
            this.DgBackup.Size = new System.Drawing.Size(392, 222);
            this.DgBackup.TabIndex = 40;
            // 
            // btnVerBackUp
            // 
            this.btnVerBackUp.Location = new System.Drawing.Point(12, 379);
            this.btnVerBackUp.Name = "btnVerBackUp";
            this.btnVerBackUp.Size = new System.Drawing.Size(102, 26);
            this.btnVerBackUp.TabIndex = 39;
            this.btnVerBackUp.Text = "Cargar Backups";
            this.btnVerBackUp.UseVisualStyleBackColor = true;
            // 
            // btnVolverBackUp
            // 
            this.btnVolverBackUp.Location = new System.Drawing.Point(311, 449);
            this.btnVolverBackUp.Name = "btnVolverBackUp";
            this.btnVolverBackUp.Size = new System.Drawing.Size(93, 34);
            this.btnVolverBackUp.TabIndex = 38;
            this.btnVolverBackUp.Text = "Salir";
            this.btnVolverBackUp.UseVisualStyleBackColor = true;
            this.btnVolverBackUp.Click += new System.EventHandler(this.btnVolverBackUp_Click);
            // 
            // btnEjecutarBackUp
            // 
            this.btnEjecutarBackUp.Location = new System.Drawing.Point(70, 38);
            this.btnEjecutarBackUp.Name = "btnEjecutarBackUp";
            this.btnEjecutarBackUp.Size = new System.Drawing.Size(98, 23);
            this.btnEjecutarBackUp.TabIndex = 36;
            this.btnEjecutarBackUp.Text = "Realizar Backup";
            this.btnEjecutarBackUp.UseVisualStyleBackColor = true;
            // 
            // btnExaminarBackUp
            // 
            this.btnExaminarBackUp.Location = new System.Drawing.Point(329, 12);
            this.btnExaminarBackUp.Name = "btnExaminarBackUp";
            this.btnExaminarBackUp.Size = new System.Drawing.Size(75, 20);
            this.btnExaminarBackUp.TabIndex = 35;
            this.btnExaminarBackUp.Text = "Examinar";
            this.btnExaminarBackUp.UseVisualStyleBackColor = true;
            this.btnExaminarBackUp.Click += new System.EventHandler(this.btnExaminarBackUp_Click);
            // 
            // txtDirectorioBackUp
            // 
            this.txtDirectorioBackUp.Location = new System.Drawing.Point(70, 12);
            this.txtDirectorioBackUp.Name = "txtDirectorioBackUp";
            this.txtDirectorioBackUp.ReadOnly = true;
            this.txtDirectorioBackUp.Size = new System.Drawing.Size(242, 20);
            this.txtDirectorioBackUp.TabIndex = 37;
            // 
            // lblDirectorioBackUp
            // 
            this.lblDirectorioBackUp.AutoSize = true;
            this.lblDirectorioBackUp.Location = new System.Drawing.Point(12, 16);
            this.lblDirectorioBackUp.Name = "lblDirectorioBackUp";
            this.lblDirectorioBackUp.Size = new System.Drawing.Size(52, 13);
            this.lblDirectorioBackUp.TabIndex = 34;
            this.lblDirectorioBackUp.Text = "Directorio";
            // 
            // BackupRestore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 492);
            this.ControlBox = false;
            this.Controls.Add(this.btnEjecutarRestore);
            this.Controls.Add(this.btnExaminarRestore);
            this.Controls.Add(this.txtDirectorioRestore);
            this.Controls.Add(this.lblDirectorioRestore);
            this.Controls.Add(this.btnVerRestore);
            this.Controls.Add(this.DgBackup);
            this.Controls.Add(this.btnVerBackUp);
            this.Controls.Add(this.btnVolverBackUp);
            this.Controls.Add(this.btnEjecutarBackUp);
            this.Controls.Add(this.btnExaminarBackUp);
            this.Controls.Add(this.txtDirectorioBackUp);
            this.Controls.Add(this.lblDirectorioBackUp);
            this.Name = "BackupRestore";
            this.Text = "BackupRestore";
            this.Load += new System.EventHandler(this.BackupRestore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgBackup)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnEjecutarRestore;
        internal System.Windows.Forms.Button btnExaminarRestore;
        internal System.Windows.Forms.TextBox txtDirectorioRestore;
        internal System.Windows.Forms.Label lblDirectorioRestore;
        internal System.Windows.Forms.Button btnVerRestore;
        private System.Windows.Forms.DataGridView DgBackup;
        internal System.Windows.Forms.Button btnVerBackUp;
        internal System.Windows.Forms.Button btnVolverBackUp;
        internal System.Windows.Forms.Button btnEjecutarBackUp;
        internal System.Windows.Forms.Button btnExaminarBackUp;
        internal System.Windows.Forms.TextBox txtDirectorioBackUp;
        internal System.Windows.Forms.Label lblDirectorioBackUp;
    }
}