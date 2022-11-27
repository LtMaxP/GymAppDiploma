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
            this.labelFacturas = new System.Windows.Forms.ToolStripMenuItem();
            this.labelPagosYCobros = new System.Windows.Forms.ToolStripMenuItem();
            this.labelVentas = new System.Windows.Forms.ToolStripMenuItem();
            this.labelStock = new System.Windows.Forms.ToolStripMenuItem();
            this.labelSistema = new System.Windows.Forms.ToolStripMenuItem();
            this.labelABMUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.labelFamiliaPatentes = new System.Windows.Forms.ToolStripMenuItem();
            this.labelPermisosGestion = new System.Windows.Forms.ToolStripMenuItem();
            this.labelPermisosUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.labelBitacoraDV = new System.Windows.Forms.ToolStripMenuItem();
            this.labelBackupRestore = new System.Windows.Forms.ToolStripMenuItem();
            this.labelControlCambios = new System.Windows.Forms.ToolStripMenuItem();
            this.labelIdioma = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolIdioma = new System.Windows.Forms.ToolStripMenuItem();
            this.labelAyuda = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolAyuda = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolContacto = new System.Windows.Forms.ToolStripMenuItem();
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
            this.labelVentas,
            this.labelStock});
            resources.ApplyResources(this.labelAcciones, "labelAcciones");
            this.labelAcciones.Name = "labelAcciones";
            this.labelAcciones.Tag = "";
            this.labelAcciones.Click += new System.EventHandler(this.labelAcciones_Click);
            // 
            // labelClientes
            // 
            this.labelClientes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelFacturas,
            this.labelPagosYCobros});
            this.labelClientes.Name = "labelClientes";
            resources.ApplyResources(this.labelClientes, "labelClientes");
            this.labelClientes.Tag = "4";
            this.labelClientes.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // labelFacturas
            // 
            this.labelFacturas.Name = "labelFacturas";
            resources.ApplyResources(this.labelFacturas, "labelFacturas");
            this.labelFacturas.Tag = "28";
            this.labelFacturas.Click += new System.EventHandler(this.labelFacturas_Click_1);
            // 
            // labelPagosYCobros
            // 
            this.labelPagosYCobros.Name = "labelPagosYCobros";
            resources.ApplyResources(this.labelPagosYCobros, "labelPagosYCobros");
            this.labelPagosYCobros.Tag = "28";
            this.labelPagosYCobros.Click += new System.EventHandler(this.labelPagosYCobros_Click_1);
            // 
            // labelVentas
            // 
            this.labelVentas.Name = "labelVentas";
            resources.ApplyResources(this.labelVentas, "labelVentas");
            this.labelVentas.Tag = "19";
            this.labelVentas.Click += new System.EventHandler(this.productosToolStripMenuItem_Click);
            // 
            // labelStock
            // 
            this.labelStock.Name = "labelStock";
            resources.ApplyResources(this.labelStock, "labelStock");
            this.labelStock.Tag = "20";
            this.labelStock.Click += new System.EventHandler(this.gestionDeStockToolStripMenuItem_Click);
            // 
            // labelSistema
            // 
            this.labelSistema.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelABMUsuario,
            this.labelFamiliaPatentes,
            this.labelBitacoraDV,
            this.labelBackupRestore,
            this.labelControlCambios});
            resources.ApplyResources(this.labelSistema, "labelSistema");
            this.labelSistema.Name = "labelSistema";
            this.labelSistema.Tag = "";
            // 
            // labelABMUsuario
            // 
            this.labelABMUsuario.Name = "labelABMUsuario";
            resources.ApplyResources(this.labelABMUsuario, "labelABMUsuario");
            this.labelABMUsuario.Tag = "9";
            this.labelABMUsuario.Click += new System.EventHandler(this.aBMUsuariosToolStripMenuItem_Click);
            // 
            // labelFamiliaPatentes
            // 
            this.labelFamiliaPatentes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelPermisosGestion,
            this.labelPermisosUsuario});
            this.labelFamiliaPatentes.Name = "labelFamiliaPatentes";
            resources.ApplyResources(this.labelFamiliaPatentes, "labelFamiliaPatentes");
            this.labelFamiliaPatentes.Tag = "15";
            this.labelFamiliaPatentes.Click += new System.EventHandler(this.labelFamiliaPatentes_Click);
            // 
            // labelPermisosGestion
            // 
            this.labelPermisosGestion.Name = "labelPermisosGestion";
            resources.ApplyResources(this.labelPermisosGestion, "labelPermisosGestion");
            this.labelPermisosGestion.Tag = "16";
            this.labelPermisosGestion.Click += new System.EventHandler(this.permisosGestionToolStripMenuItem_Click);
            // 
            // labelPermisosUsuario
            // 
            this.labelPermisosUsuario.Name = "labelPermisosUsuario";
            resources.ApplyResources(this.labelPermisosUsuario, "labelPermisosUsuario");
            this.labelPermisosUsuario.Tag = "16";
            this.labelPermisosUsuario.Click += new System.EventHandler(this.permisosUsuarioToolStripMenuItem_Click);
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
            this.labelBackupRestore.Tag = "18";
            this.labelBackupRestore.Click += new System.EventHandler(this.labelBackupRestore_Click);
            // 
            // labelControlCambios
            // 
            this.labelControlCambios.Name = "labelControlCambios";
            resources.ApplyResources(this.labelControlCambios, "labelControlCambios");
            this.labelControlCambios.Tag = "17";
            this.labelControlCambios.Click += new System.EventHandler(this.controlDeCambiosToolStripMenuItem_Click);
            // 
            // labelIdioma
            // 
            this.labelIdioma.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolIdioma});
            resources.ApplyResources(this.labelIdioma, "labelIdioma");
            this.labelIdioma.Name = "labelIdioma";
            this.labelIdioma.Tag = "99";
            this.labelIdioma.Click += new System.EventHandler(this.labelIdioma_Click);
            // 
            // ToolIdioma
            // 
            this.ToolIdioma.Name = "ToolIdioma";
            resources.ApplyResources(this.ToolIdioma, "ToolIdioma");
            this.ToolIdioma.Tag = "99";
            this.ToolIdioma.Click += new System.EventHandler(this.agregarIdiomaToolStripMenuItem_Click);
            // 
            // labelAyuda
            // 
            this.labelAyuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolAyuda,
            this.ToolContacto});
            resources.ApplyResources(this.labelAyuda, "labelAyuda");
            this.labelAyuda.Name = "labelAyuda";
            this.labelAyuda.Tag = "99";
            // 
            // ToolAyuda
            // 
            this.ToolAyuda.Name = "ToolAyuda";
            resources.ApplyResources(this.ToolAyuda, "ToolAyuda");
            this.ToolAyuda.Tag = "99";
            this.ToolAyuda.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // ToolContacto
            // 
            this.ToolContacto.Name = "ToolContacto";
            resources.ApplyResources(this.ToolContacto, "ToolContacto");
            this.ToolContacto.Tag = "99";
            this.ToolContacto.Click += new System.EventHandler(this.contactoToolStripMenuItem_Click);
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
        private System.Windows.Forms.ToolStripMenuItem labelSistema;
        private System.Windows.Forms.ToolStripMenuItem labelFamiliaPatentes;
        private System.Windows.Forms.ToolStripMenuItem labelBitacoraDV;
        private System.Windows.Forms.ToolStripMenuItem labelBackupRestore;
        private System.Windows.Forms.ToolStripMenuItem labelABMUsuario;
        private System.Windows.Forms.ToolStripMenuItem labelIdioma;
        private System.Windows.Forms.ToolStripMenuItem labelAyuda;
        private System.Windows.Forms.ToolStripMenuItem ToolAyuda;
        private System.Windows.Forms.ToolStripMenuItem ToolContacto;
        private System.Windows.Forms.ToolStripMenuItem ToolIdioma;
        private System.Windows.Forms.ToolStripMenuItem labelVentas;
        private System.Windows.Forms.ToolStripMenuItem labelControlCambios;
        private System.Windows.Forms.ToolStripMenuItem labelPermisosGestion;
        private System.Windows.Forms.ToolStripMenuItem labelPermisosUsuario;
        private System.Windows.Forms.ToolStripMenuItem labelPagosYCobros;
        private System.Windows.Forms.ToolStripMenuItem labelFacturas;
        private System.Windows.Forms.ToolStripMenuItem labelStock;
    }
}