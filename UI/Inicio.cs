﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE.ObserverIdioma;
using BLL.Observer;
using UI.Negocio;

namespace UI
{
    public partial class Inicio : Form, IObserverIdioma
    {
        Bitmap secSemi45 = new Bitmap(Properties.Resources.focmili);//@"C:\Users\Portadag\source\repos\GymDiploma\UI\SecSemiR-45\focmili.jpg", true);
        Bitmap wallpaper = new Bitmap(Properties.Resources.gymwallpaper);// @"C:\Users\Portadag\source\repos\GymDiploma\UI\Resources\gymwallpaper.jpg", true);
        int speIma = 0;
        IdiomaBLL BLLIdioma;
        BLL.BitacoraBLL bit;
        public Inicio()
        {
            InitializeComponent();
            BLLIdioma = new IdiomaBLL();
            bit = new BLL.BitacoraBLL();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            SubjectIdioma.AddObserverIdioma(this);
            PermisosRecurseToolStripItems(this.menuStrip1.Items);
        }
        /// <summary>
        /// Recursividad para habilitar permisos
        /// </summary>
        /// <param name="tsic"></param>
        private void PermisosRecurseToolStripItems(ToolStripItemCollection tsic)
        {
            foreach (ToolStripItem item in tsic)
            {
                if (!string.IsNullOrEmpty(item.Tag.ToString()))
                    #region adPantallas
                    foreach (BE.Composite.Component cmp in Servicios.Sesion.GetInstance.usuario.Permisos.List())
                    {
                        if (cmp is BE.Composite.Composite)
                        {
                            if (!String.IsNullOrEmpty(cmp.iDPatente) && !cmp.descripcion.Equals("Arbol"))
                            {
                                if (cmp.VerificarSiExiste(new BE.Composite.Composite(item.Tag.ToString(), "T")))
                                    item.Visible = true;
                            }
                        }
                    }
                #endregion
                if (item is ToolStripMenuItem)
                {
                    //ToolStripMenuItem item2 = (ToolStripMenuItem)item;
                    PermisosRecurseToolStripItems(((ToolStripMenuItem)item).DropDown.Items);
                }
            }
        }
        /// <summary>
        /// Boton Logout
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            bit.RegistrarMovimiento("Usuario Logout", "Ninguno");
            this.Close();
            Servicios.Sesion.Logout();
            LogIn logg = new LogIn();
            logg.Mostrar();
        }

        #region formularios carga

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Fclient == null)
            {
                Fclient = new Clientes();
                Fclient.MdiParent = this;
                Fclient.FormClosed += new FormClosedEventHandler(Fclient_FormClosed);
                Fclient.Show();
            }
            else
            {
                Fclient.Activate();
            }
        }
        private void Fclient_FormClosed(object sender, FormClosedEventArgs e)
        {
            Fclient = null;
        }
        private void aBMUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FuserABM == null)
            {
                FuserABM = new UsuariosABM();
                FuserABM.MdiParent = this;
                FuserABM.FormClosed += FuserABM_FormClosed;
                FuserABM.Show();
            }
            else
            {
                FuserABM.Activate();
            }
        }
        private void FuserABM_FormClosed(object sender, FormClosedEventArgs e)
        {
            FuserABM = null;
        }
        private void bitacoraDVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FbitDV == null)
            {
                FbitDV = new BitacoraYDV();
                FbitDV.MdiParent = this;
                FbitDV.FormClosed += FbitDV_FormClosed;
                FbitDV.Show();
            }
            else
            {
                FbitDV.Activate();
            }
        }
        private void FbitDV_FormClosed(object sender, FormClosedEventArgs e)
        {
            FbitDV = null;
        }
        private void easterEggToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void permisosGestionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Permi == null)
            {
                Permi = new Permisos();
                Permi.MdiParent = this;
                Permi.FormClosed += new FormClosedEventHandler(Permi_FormClosed);
                Permi.Show();
            }
            else
            {
                Permi.Activate();
            }
        }
        private void permisosUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (PermUsu == null)
            {
                PermUsu = new PermisosUsuario();
                PermUsu.MdiParent = this;
                PermUsu.FormClosed += new FormClosedEventHandler(PermiUsu_FormClosed);
                PermUsu.Show();
            }
            else
            {
                PermUsu.Activate();
            }
        }
        private void controlDeCambiosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CC == null)
            {
                CC = new Tecnico.ControlCambios();
                CC.MdiParent = this;
                CC.FormClosed += new FormClosedEventHandler(CC_FormClosed);
                CC.Show();
            }
            else
            {
                PermUsu.Activate();
            }
        }
        private void CC_FormClosed(object sender, FormClosedEventArgs e)
        {
            CC = null;
        }
        private void labelAcciones_Click(object sender, EventArgs e)
        {

        }
        private void verSecretoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (speIma == 0)
            {
                this.BackgroundImage = secSemi45;
                speIma = 1;
            }
            else
            {
                this.BackgroundImage = wallpaper;
                speIma = 0;
            }
        }
        private void labelBackupRestore_Click(object sender, EventArgs e)
        {
            //if (Perm.ValidarPermiso("BackupRestore"))
            //{
            if (Fbackrest == null)
            {
                Fbackrest = new BackupRestore();
                Fbackrest.MdiParent = this;
                Fbackrest.FormClosed += new FormClosedEventHandler(Fbackrest_FormClosed);
                Fbackrest.Show();
            }
            else
            {
                Fbackrest.Activate();
            }
            //}
        }
        private void Fbackrest_FormClosed(object sender, FormClosedEventArgs e)
        {
            Fbackrest = null;
        }
        private void labelFacturas_Click_1(object sender, EventArgs e)
        {
            if (Factu == null)
            {
                Factu = new Facturas();
                Factu.MdiParent = this;
                Factu.FormClosed += new FormClosedEventHandler(Factu_FormClosed);
                Factu.Show();
            }
            else
            {
                Factu.Activate();
            }
        }
        private void Factu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Factu = null;
        }
        private void labelPagosYCobros_Click_1(object sender, EventArgs e)
        {
            if (PyG == null)
            {
                PyG = new PagosCobros();
                PyG.MdiParent = this;
                PyG.FormClosed += new FormClosedEventHandler(PyG_FormClosed);
                PyG.Show();
            }
            else
            {
                PyG.Activate();
            }
        }
        private void PyG_FormClosed(object sender, FormClosedEventArgs e)
        {
            PyG = null;
        }
        private void labelFamiliaPatentes_Click(object sender, EventArgs e)
        {

        }
        private void Permi_FormClosed(object sender, FormClosedEventArgs e)
        {
            Permi = null;
        }
        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (productos == null)
            {
                productos = new Productos();
                productos.MdiParent = this;
                productos.FormClosed += new FormClosedEventHandler(productos_FormClosed);
                productos.Show();
            }
            else
            {
                productos.Activate();
            }
        }
        private void productos_FormClosed(object sender, FormClosedEventArgs e)
        {
            productos = null;
        }
        private void PermiUsu_FormClosed(object sender, FormClosedEventArgs e)
        {
            PermUsu = null;
        }
        private void agregarIdiomaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (AgIdioma == null)
            {
                AgIdioma = new UI.Tecnico.Idioma();
                AgIdioma.MdiParent = this;
                AgIdioma.FormClosed += new FormClosedEventHandler(AgIdioma_FormClosed);
                AgIdioma.Show();
            }
            else
            {
                AgIdioma.Activate();
            }
        }
        private void gestionDeStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Stock == null)
            {
                Stock = new UI.Negocio.Stock();
                Stock.MdiParent = this;
                Stock.FormClosed += new FormClosedEventHandler(Stock_FormClosed);
                Stock.Show();
            }
            else
            {
                Stock.Activate();
            }
        }
        private void AgIdioma_FormClosed(object sender, FormClosedEventArgs e)
        {
            AgIdioma = null;
        }
        private void Stock_FormClosed(object sender, FormClosedEventArgs e)
        {
            Stock = null;
        }
        #endregion
        #region traducir


        public void Traducir(Control c)
        {
            if (!string.IsNullOrEmpty(c.Text))
            {
                foreach (Leyenda us in Servicios.Sesion.GetInstance.usuario.Idioma.Leyendas)
                {
                    if (us._nombreEtiqueta == c.Name)
                    {
                        c.Text = us._textoLabel;
                    }
                }
            }
            foreach (Control cont in c.Controls)
            {
                Traducir(cont);
            }
        }

        public void TraducirTodo()
        {
            RecurseToolStripItems(this.menuStrip1.Items);
            foreach (Control item in this.Controls)
            {
                Traducir(item);
            }
        }

        private void RecurseToolStripItems(ToolStripItemCollection tsic)
        {

            foreach (ToolStripItem item in tsic)
            {
                if (!string.IsNullOrEmpty(item.Name))
                {
                    foreach (Leyenda us in Servicios.Sesion.GetInstance.usuario.Idioma.Leyendas)
                    {
                        if (us._nombreEtiqueta == item.Name)
                        {
                            item.Text = us._textoLabel;
                        }
                    }
                }
                // Aqui implementamos la recursividad donde el método se llama a sí mismo, así trabaja para cualquier cantidad de niveles de menu.
                if (item is ToolStripMenuItem)
                {
                    ToolStripMenuItem item2 = (ToolStripMenuItem)item;
                    RecurseToolStripItems(item2.DropDown.Items);
                }
            }
        }
        #endregion
        #region formularios
        Clientes Fclient;
        BitacoraYDV FbitDV;
        UsuariosABM FuserABM;
        //Empleados Femp;
        BackupRestore Fbackrest;
        Facturas Factu;
        PagosCobros PyG;
        Permisos Permi;
        Productos productos;
        UI.Tecnico.Idioma AgIdioma;
        UI.Tecnico.ControlCambios CC;
        PermisosUsuario PermUsu;
        UI.Negocio.Stock Stock;
        #endregion

        public void Update()
        {
            TraducirTodo();
        }


    }
}
