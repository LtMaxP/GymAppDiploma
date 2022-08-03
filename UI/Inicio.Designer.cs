using System;

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
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profesoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.claseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rutinaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelSistema = new System.Windows.Forms.ToolStripMenuItem();
            this.labelABMUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.labelFamiliaPatentes = new System.Windows.Forms.ToolStripMenuItem();
            this.permisosGestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.permisosUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelBitacoraDV = new System.Windows.Forms.ToolStripMenuItem();
            this.labelBackupRestore = new System.Windows.Forms.ToolStripMenuItem();
            this.controlDeCambiosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelIdioma = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarIdiomaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelAyuda = new System.Windows.Forms.ToolStripMenuItem();
            this.easterEggToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verSecretoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.labelListas,
            this.productosToolStripMenuItem,
            this.profesoresToolStripMenuItem});
            resources.ApplyResources(this.labelAcciones, "labelAcciones");
            this.labelAcciones.Name = "labelAcciones";
            this.labelAcciones.Tag = "30";
            // 
            // labelClientes
            // 
            this.labelClientes.Name = "labelClientes";
            resources.ApplyResources(this.labelClientes, "labelClientes");
            this.labelClientes.Tag = "4";
            this.labelClientes.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // labelEmpleados
            // 
            this.labelEmpleados.Name = "labelEmpleados";
            resources.ApplyResources(this.labelEmpleados, "labelEmpleados");
            this.labelEmpleados.Tag = "22";
            this.labelEmpleados.Click += new System.EventHandler(this.labelEmpleados_Click);
            // 
            // labelFacturas
            // 
            this.labelFacturas.Name = "labelFacturas";
            resources.ApplyResources(this.labelFacturas, "labelFacturas");
            this.labelFacturas.Tag = "28";
            this.labelFacturas.Click += new System.EventHandler(this.labelFacturas_Click);
            // 
            // labelPagosYCobros
            // 
            this.labelPagosYCobros.Name = "labelPagosYCobros";
            resources.ApplyResources(this.labelPagosYCobros, "labelPagosYCobros");
            this.labelPagosYCobros.Tag = "24";
            this.labelPagosYCobros.Click += new System.EventHandler(this.labelPagosYCobros_Click);
            // 
            // labelListas
            // 
            this.labelListas.Name = "labelListas";
            resources.ApplyResources(this.labelListas, "labelListas");
            this.labelListas.Tag = "29";
            this.labelListas.Click += new System.EventHandler(this.labelListas_Click);
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            resources.ApplyResources(this.productosToolStripMenuItem, "productosToolStripMenuItem");
            this.productosToolStripMenuItem.Tag = "18";
            this.productosToolStripMenuItem.Click += new System.EventHandler(this.productosToolStripMenuItem_Click);
            // 
            // profesoresToolStripMenuItem
            // 
            this.profesoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.claseToolStripMenuItem,
            this.rutinaToolStripMenuItem});
            this.profesoresToolStripMenuItem.Name = "profesoresToolStripMenuItem";
            resources.ApplyResources(this.profesoresToolStripMenuItem, "profesoresToolStripMenuItem");
            this.profesoresToolStripMenuItem.Tag = "27";
            // 
            // claseToolStripMenuItem
            // 
            this.claseToolStripMenuItem.Name = "claseToolStripMenuItem";
            resources.ApplyResources(this.claseToolStripMenuItem, "claseToolStripMenuItem");
            this.claseToolStripMenuItem.Tag = "25";
            this.claseToolStripMenuItem.Click += new System.EventHandler(this.claseToolStripMenuItem_Click);
            // 
            // rutinaToolStripMenuItem
            // 
            this.rutinaToolStripMenuItem.Name = "rutinaToolStripMenuItem";
            resources.ApplyResources(this.rutinaToolStripMenuItem, "rutinaToolStripMenuItem");
            this.rutinaToolStripMenuItem.Tag = "26";
            this.rutinaToolStripMenuItem.Click += new System.EventHandler(this.rutinaToolStripMenuItem_Click);
            // 
            // labelSistema
            // 
            this.labelSistema.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelABMUsuarios,
            this.labelFamiliaPatentes,
            this.labelBitacoraDV,
            this.labelBackupRestore,
            this.controlDeCambiosToolStripMenuItem});
            resources.ApplyResources(this.labelSistema, "labelSistema");
            this.labelSistema.Name = "labelSistema";
            this.labelSistema.Tag = "31";
            // 
            // labelABMUsuarios
            // 
            this.labelABMUsuarios.Name = "labelABMUsuarios";
            resources.ApplyResources(this.labelABMUsuarios, "labelABMUsuarios");
            this.labelABMUsuarios.Tag = "10";
            this.labelABMUsuarios.Click += new System.EventHandler(this.aBMUsuariosToolStripMenuItem_Click);
            // 
            // labelFamiliaPatentes
            // 
            this.labelFamiliaPatentes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.permisosGestionToolStripMenuItem,
            this.permisosUsuarioToolStripMenuItem});
            this.labelFamiliaPatentes.Name = "labelFamiliaPatentes";
            resources.ApplyResources(this.labelFamiliaPatentes, "labelFamiliaPatentes");
            this.labelFamiliaPatentes.Tag = "15";
            this.labelFamiliaPatentes.Click += new System.EventHandler(this.labelFamiliaPatentes_Click);
            // 
            // permisosGestionToolStripMenuItem
            // 
            this.permisosGestionToolStripMenuItem.Name = "permisosGestionToolStripMenuItem";
            resources.ApplyResources(this.permisosGestionToolStripMenuItem, "permisosGestionToolStripMenuItem");
            this.permisosGestionToolStripMenuItem.Tag = "16";
            this.permisosGestionToolStripMenuItem.Click += new System.EventHandler(this.permisosGestionToolStripMenuItem_Click);
            // 
            // permisosUsuarioToolStripMenuItem
            // 
            this.permisosUsuarioToolStripMenuItem.Name = "permisosUsuarioToolStripMenuItem";
            resources.ApplyResources(this.permisosUsuarioToolStripMenuItem, "permisosUsuarioToolStripMenuItem");
            this.permisosUsuarioToolStripMenuItem.Tag = "16";
            this.permisosUsuarioToolStripMenuItem.Click += new System.EventHandler(this.permisosUsuarioToolStripMenuItem_Click);
            // 
            // labelBitacoraDV
            // 
            this.labelBitacoraDV.Name = "labelBitacoraDV";
            resources.ApplyResources(this.labelBitacoraDV, "labelBitacoraDV");
            this.labelBitacoraDV.Tag = "14";
            this.labelBitacoraDV.Click += new System.EventHandler(this.bitacoraDVToolStripMenuItem_Click);
            // 
            // labelBackupRestore
            // 
            this.labelBackupRestore.Name = "labelBackupRestore";
            resources.ApplyResources(this.labelBackupRestore, "labelBackupRestore");
            this.labelBackupRestore.Tag = "12";
            this.labelBackupRestore.Click += new System.EventHandler(this.labelBackupRestore_Click);
            // 
            // controlDeCambiosToolStripMenuItem
            // 
            this.controlDeCambiosToolStripMenuItem.Name = "controlDeCambiosToolStripMenuItem";
            resources.ApplyResources(this.controlDeCambiosToolStripMenuItem, "controlDeCambiosToolStripMenuItem");
            this.controlDeCambiosToolStripMenuItem.Tag = "17";
            this.controlDeCambiosToolStripMenuItem.Click += new System.EventHandler(this.controlDeCambiosToolStripMenuItem_Click);
            // 
            // labelIdioma
            // 
            this.labelIdioma.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarIdiomaToolStripMenuItem});
            resources.ApplyResources(this.labelIdioma, "labelIdioma");
            this.labelIdioma.Name = "labelIdioma";
            this.labelIdioma.Tag = "99";
            this.labelIdioma.Click += new System.EventHandler(this.labelIdioma_Click);
            // 
            // agregarIdiomaToolStripMenuItem
            // 
            this.agregarIdiomaToolStripMenuItem.Name = "agregarIdiomaToolStripMenuItem";
            resources.ApplyResources(this.agregarIdiomaToolStripMenuItem, "agregarIdiomaToolStripMenuItem");
            this.agregarIdiomaToolStripMenuItem.Tag = "99";
            this.agregarIdiomaToolStripMenuItem.Click += new System.EventHandler(this.agregarIdiomaToolStripMenuItem_Click);
            // 
            // labelAyuda
            // 
            this.labelAyuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.easterEggToolStripMenuItem,
            this.infoToolStripMenuItem,
            this.contactoToolStripMenuItem});
            resources.ApplyResources(this.labelAyuda, "labelAyuda");
            this.labelAyuda.Name = "labelAyuda";
            this.labelAyuda.Tag = "99";
            // 
            // easterEggToolStripMenuItem
            // 
            this.easterEggToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verSecretoToolStripMenuItem});
            this.easterEggToolStripMenuItem.Name = "easterEggToolStripMenuItem";
            resources.ApplyResources(this.easterEggToolStripMenuItem, "easterEggToolStripMenuItem");
            this.easterEggToolStripMenuItem.Tag = "99";
            this.easterEggToolStripMenuItem.Click += new System.EventHandler(this.easterEggToolStripMenuItem_Click);
            // 
            // verSecretoToolStripMenuItem
            // 
            this.verSecretoToolStripMenuItem.Name = "verSecretoToolStripMenuItem";
            resources.ApplyResources(this.verSecretoToolStripMenuItem, "verSecretoToolStripMenuItem");
            this.verSecretoToolStripMenuItem.Tag = "99";
            this.verSecretoToolStripMenuItem.Click += new System.EventHandler(this.verSecretoToolStripMenuItem_Click);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            resources.ApplyResources(this.infoToolStripMenuItem, "infoToolStripMenuItem");
            this.infoToolStripMenuItem.Tag = "99";
            // 
            // contactoToolStripMenuItem
            // 
            this.contactoToolStripMenuItem.Name = "contactoToolStripMenuItem";
            resources.ApplyResources(this.contactoToolStripMenuItem, "contactoToolStripMenuItem");
            this.contactoToolStripMenuItem.Tag = "99";
            // 
            // Inicio
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UI.Properties.Resources.gymwallpaper;
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

        private void labelIdioma_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
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
        private System.Windows.Forms.ToolStripMenuItem labelAyuda;
        private System.Windows.Forms.ToolStripMenuItem easterEggToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verSecretoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarIdiomaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profesoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem claseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rutinaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controlDeCambiosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem permisosGestionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem permisosUsuarioToolStripMenuItem;
    }
}