namespace UI
{
    partial class LogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            this.labelUser = new System.Windows.Forms.Label();
            this.buttonIngresar = new System.Windows.Forms.Button();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.labelPass = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.BackColor = System.Drawing.SystemColors.WindowText;
            this.labelUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelUser.Location = new System.Drawing.Point(92, 101);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(71, 20);
            this.labelUser.TabIndex = 0;
            this.labelUser.Text = "Usuario";
            // 
            // buttonIngresar
            // 
            this.buttonIngresar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonIngresar.Location = new System.Drawing.Point(309, 198);
            this.buttonIngresar.Name = "buttonIngresar";
            this.buttonIngresar.Size = new System.Drawing.Size(111, 37);
            this.buttonIngresar.TabIndex = 1;
            this.buttonIngresar.Text = "Ingresar";
            this.buttonIngresar.UseVisualStyleBackColor = false;
            this.buttonIngresar.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonSalir
            // 
            this.buttonSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSalir.Location = new System.Drawing.Point(521, 367);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(84, 40);
            this.buttonSalir.TabIndex = 2;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.BackColor = System.Drawing.SystemColors.WindowText;
            this.labelPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.labelPass.ForeColor = System.Drawing.SystemColors.Window;
            this.labelPass.Location = new System.Drawing.Point(92, 145);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(102, 20);
            this.labelPass.TabIndex = 3;
            this.labelPass.Text = "Contraseña";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox1.Location = new System.Drawing.Point(230, 101);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(305, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox2.Location = new System.Drawing.Point(230, 145);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(306, 20);
            this.textBox2.TabIndex = 5;
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(628, 419);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelPass);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.buttonIngresar);
            this.Controls.Add(this.labelUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.LogIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Button buttonIngresar;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

