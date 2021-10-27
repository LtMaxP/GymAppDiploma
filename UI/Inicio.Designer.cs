namespace UI
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.labelAcciones = new System.Windows.Forms.ToolStripMenuItem();
            this.labelClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.labelEmpleados = new System.Windows.Forms.ToolStripMenuItem();
            this.labelFacturas = new System.Windows.Forms.ToolStripMenuItem();
            this.labelPagosYCobros = new System.Windows.Forms.ToolStripMenuItem();
            this.labelListas = new System.Windows.Forms.ToolStripMenuItem();
            this.labelSistema = new System.Windows.Forms.ToolStripMenuItem();
            this.labelABMUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.labelFamiliaPatentes = new System.Windows.Forms.ToolStripMenuItem();
            this.labelBitacoraDV = new System.Windows.Forms.ToolStripMenuItem();
            this.labelBackupRestore = new System.Windows.Forms.ToolStripMenuItem();
            this.labelIdioma = new System.Windows.Forms.ToolStripMenuItem();
            this.labelEspañol = new System.Windows.Forms.ToolStripMenuItem();
            this.labelIngles = new System.Windows.Forms.ToolStripMenuItem();
            this.labelAyuda = new System.Windows.Forms.ToolStripMenuItem();
            this.easterEggToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verSecretoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            resources.ApplyResources(this.button1, "button1");
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Highlight;
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelAcciones,
            this.labelSistema,
            this.labelIdioma,
            this.labelAyuda});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // labelAcciones
            // 
            this.labelAcciones.BackColor = System.Drawing.SystemColors.Highlight;
            this.labelAcciones.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelClientes,
            this.labelEmpleados,
            this.labelFacturas,
            this.labelPagosYCobros,
            this.labelListas});
            resources.ApplyResources(this.labelAcciones, "labelAcciones");
            this.labelAcciones.Name = "labelAcciones";
            this.labelAcciones.Tag = "";
            // 
            // labelClientes
            // 
            this.labelClientes.Name = "labelClientes";
            resources.ApplyResources(this.labelClientes, "labelClientes");
            this.labelClientes.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // labelEmpleados
            // 
            this.labelEmpleados.Name = "labelEmpleados";
            resources.ApplyResources(this.labelEmpleados, "labelEmpleados");
            // 
            // labelFacturas
            // 
            this.labelFacturas.Name = "labelFacturas";
            resources.ApplyResources(this.labelFacturas, "labelFacturas");
            // 
            // labelPagosYCobros
            // 
            this.labelPagosYCobros.Name = "labelPagosYCobros";
            resources.ApplyResources(this.labelPagosYCobros, "labelPagosYCobros");
            // 
            // labelListas
            // 
            this.labelListas.Name = "labelListas";
            resources.ApplyResources(this.labelListas, "labelListas");
            // 
            // labelSistema
            // 
            this.labelSistema.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelABMUsuarios,
            this.labelFamiliaPatentes,
            this.labelBitacoraDV,
            this.labelBackupRestore});
            resources.ApplyResources(this.labelSistema, "labelSistema");
            this.labelSistema.Name = "labelSistema";
            // 
            // labelABMUsuarios
            // 
            this.labelABMUsuarios.Name = "labelABMUsuarios";
            resources.ApplyResources(this.labelABMUsuarios, "labelABMUsuarios");
            this.labelABMUsuarios.Click += new System.EventHandler(this.aBMUsuariosToolStripMenuItem_Click);
            // 
            // labelFamiliaPatentes
            // 
            this.labelFamiliaPatentes.Name = "labelFamiliaPatentes";
            resources.ApplyResources(this.labelFamiliaPatentes, "labelFamiliaPatentes");
            // 
            // labelBitacoraDV
            // 
            this.labelBitacoraDV.Name = "labelBitacoraDV";
            resources.ApplyResources(this.labelBitacoraDV, "labelBitacoraDV");
            this.labelBitacoraDV.Click += new System.EventHandler(this.bitacoraDVToolStripMenuItem_Click);
            // 
            // labelBackupRestore
            // 
            this.labelBackupRestore.Name = "labelBackupRestore";
            resources.ApplyResources(this.labelBackupRestore, "labelBackupRestore");
            // 
            // labelIdioma
            // 
            this.labelIdioma.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelEspañol,
            this.labelIngles});
            resources.ApplyResources(this.labelIdioma, "labelIdioma");
            this.labelIdioma.Name = "labelIdioma";
            // 
            // labelEspañol
            // 
            this.labelEspañol.Name = "labelEspañol";
            resources.ApplyResources(this.labelEspañol, "labelEspañol");
            this.labelEspañol.Click += new System.EventHandler(this.españolToolStripMenuItem_Click);
            // 
            // labelIngles
            // 
            this.labelIngles.Name = "labelIngles";
            resources.ApplyResources(this.labelIngles, "labelIngles");
            this.labelIngles.Click += new System.EventHandler(this.inglesToolStripMenuItem_Click);
            // 
            // labelAyuda
            // 
            this.labelAyuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.easterEggToolStripMenuItem});
            resources.ApplyResources(this.labelAyuda, "labelAyuda");
            this.labelAyuda.Name = "labelAyuda";
            // 
            // easterEggToolStripMenuItem
            // 
            this.easterEggToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verSecretoToolStripMenuItem});
            this.easterEggToolStripMenuItem.Name = "easterEggToolStripMenuItem";
            resources.ApplyResources(this.easterEggToolStripMenuItem, "easterEggToolStripMenuItem");
            // 
            // verSecretoToolStripMenuItem
            // 
            this.verSecretoToolStripMenuItem.Name = "verSecretoToolStripMenuItem";
            resources.ApplyResources(this.verSecretoToolStripMenuItem, "verSecretoToolStripMenuItem");
            this.verSecretoToolStripMenuItem.Click += new System.EventHandler(this.verSecretoToolStripMenuItem_Click);
            // 
            // Inicio
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Inicio";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem labelAcciones;
        private System.Windows.Forms.ToolStripMenuItem labelClientes;
        private System.Windows.Forms.ToolStripMenuItem labelEmpleados;
        private System.Windows.Forms.ToolStripMenuItem labelFacturas;
        private System.Windows.Forms.ToolStripMenuItem labelPagosYCobros;
        private System.Windows.Forms.ToolStripMenuItem labelListas;
        private System.Windows.Forms.ToolStripMenuItem labelSistema;
        private System.Windows.Forms.ToolStripMenuItem labelFamiliaPatentes;
        private System.Windows.Forms.ToolStripMenuItem labelBitacoraDV;
        private System.Windows.Forms.ToolStripMenuItem labelBackupRestore;
        private System.Windows.Forms.ToolStripMenuItem labelABMUsuarios;
        private System.Windows.Forms.ToolStripMenuItem labelIdioma;
        private System.Windows.Forms.ToolStripMenuItem labelEspañol;
        private System.Windows.Forms.ToolStripMenuItem labelIngles;
        private System.Windows.Forms.ToolStripMenuItem labelAyuda;
        private System.Windows.Forms.ToolStripMenuItem easterEggToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verSecretoToolStripMenuItem;
    }
}