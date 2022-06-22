﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL.Observer;
using UI.Negocio;

namespace UI
{
    public partial class Inicio : Form, BLL.Observer.IObserver
    {
        Bitmap secSemi45 = new Bitmap(@"C:\Users\Portadag\source\repos\GymDiploma\UI\SecSemiR-45\focmili.jpg", true);
        Bitmap wallpaper = new Bitmap(@"C:\Users\Portadag\source\repos\GymDiploma\UI\Resources\gymwallpaper.jpg", true);
        int speIma = 0;
        public Inicio()
        {
            InitializeComponent();
            //TraducirTodo();
        }

        #region traducir
        private List<BE.Idioma> _pack;
        private List<BE.Idioma> pack
        {
            get
            {
                if(_pack == null)
                {
                    _pack = IdiomaBLL.Instance.DamePackDeIdiomas;
                }
                return _pack;
            }
        }

        public void Traducir(Control c)
        {
            if (!string.IsNullOrEmpty(c.Text))
            {
                foreach (BE.Idioma us in pack)
                {
                    if (us._nombreEtiqueta == c.Name && us._idiomaPerteneciente == BE.Usuario.Instance.idIdioma)
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
                    foreach (BE.Idioma us in pack)
                    {
                        if (us._nombreEtiqueta == item.Name && us._idiomaPerteneciente == BE.Usuario.Instance.idIdioma)
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
        Empleados Femp;
        BackupRestore Fbackrest;
        Facturas Factu;
        PagosCobros PyG;
        Listas Listados;
        Permisos Permi;
        Rutina Rutina;
        Clases clases;
        Productos productos;
        #endregion

        private void Inicio_Load(object sender, EventArgs e)
        {
            Subject.AddObserver(this);
            Subject.Notify(SingletonIdioma.GetInstance().Idioma);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            LogIn logg = new LogIn();
            logg.Mostrar();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //this.Close();
            //UsuariosABM uABM = new UsuariosABM();
            //uABM.Show();
        }

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


        private void Inicio_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
            LogIn logg = new LogIn();
            logg.Mostrar();

        }
        public void Update(Idioma idioma)
        {
            TraducirTodo();
        }

        private void españolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SingletonIdioma.GetInstance().Idioma.IdiomaSelected = IdiomaEnum.Español;
            BLL.Observer.IdiomaBLL.Instance.CambiarIdiomaDeUsuario();
            Subject.Notify(SingletonIdioma.GetInstance().Idioma);
        }

        private void inglesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SingletonIdioma.GetInstance().Idioma.IdiomaSelected = IdiomaEnum.English;
            BLL.Observer.IdiomaBLL.Instance.CambiarIdiomaDeUsuario();
            Subject.Notify(SingletonIdioma.GetInstance().Idioma);

        }




        private void easterEggToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
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

        private void labelEmpleados_Click(object sender, EventArgs e)
        {
            if (Femp == null)
            {
                Femp = new Empleados();
                Femp.MdiParent = this;
                Femp.FormClosed += new FormClosedEventHandler(Femp_FormClosed);
                Femp.Show();
            }
            else
            {
                Femp.Activate();
            }
        }
        private void Femp_FormClosed(object sender, FormClosedEventArgs e)
        {
            Femp = null;
        }

        private void labelBackupRestore_Click(object sender, EventArgs e)
        {
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
        }
        private void Fbackrest_FormClosed(object sender, FormClosedEventArgs e)
        {
            Fbackrest = null;
        }

        private void labelFacturas_Click(object sender, EventArgs e)
        {
            //facturas-pagoscobros-listas FALTANTE
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

        private void labelPagosYCobros_Click(object sender, EventArgs e)
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

        private void labelListas_Click(object sender, EventArgs e)
        {
            if (Listados == null)
            {
                Listados = new Listas();
                Listados.MdiParent = this;
                Listados.FormClosed += new FormClosedEventHandler(Listados_FormClosed);
                Listados.Show();
            }
            else
            {
                Listados.Activate();
            }
        }
        private void Listados_FormClosed(object sender, FormClosedEventArgs e)
        {
            Listados = null;
        }

        private void permisosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void labelFamiliaPatentes_Click(object sender, EventArgs e)
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
        private void claseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clases == null)
            {
                clases = new Clases();
                clases.MdiParent = this;
                clases.FormClosed += new FormClosedEventHandler(clases_FormClosed);
                clases.Show();
            }
            else
            {
                clases.Activate();
            }
        }
        private void clases_FormClosed(object sender, FormClosedEventArgs e)
        {
            clases = null;
        }

        private void rutinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Rutina == null)
            {
                Rutina = new Rutina();
                Rutina.MdiParent = this;
                Rutina.FormClosed += new FormClosedEventHandler(Rutina_FormClosed);
                Rutina.Show();
            }
            else
            {
                Rutina.Activate();
            }
        }
        private void Rutina_FormClosed(object sender, FormClosedEventArgs e)
        {
            Rutina = null;
        }
    }
}
