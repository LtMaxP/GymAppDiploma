using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL.Observer;

namespace UI
{
    public partial class Inicio : Form, BLL.Observer.IObserver
    {
        public Inicio()
        {
            InitializeComponent();
            pack = idiomaOb.DamePackDeIdiomas;
            TraducirTodo();
        }

        private List<BE.Idioma> pack;
        private void Traducir(Control c)
        {
            if(!string.IsNullOrEmpty(c.Text))
            {
                foreach(BE.Idioma us in pack)
                {
                    if(us._nombreEtiqueta == c.Name && us._idiomaPerteneciente == BE.Usuario.Instance.idIdioma)
                    {
                        c.Text = us._textoLabel;
                    }
                }
            }
            foreach(Control cont in c.Controls)
            {
                Traducir(cont);
            }
        }

        private void TraducirTodo()
        {
            RecurseToolStripItems(this.menuStrip1.Items);
            foreach (Control item in this.Controls)
            {
                Traducir(item);
            }
        }

        //Formularios
        Clientes Fclient;
        BitacoraYDV FbitDV;
        UsuariosABM FuserABM;
        BLL.Observer.Idioma idiomaOb = new BLL.Observer.Idioma();
        
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
            this.Close();
            UsuariosABM uABM = new UsuariosABM();
            uABM.Show();
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
            Subject.RemoveObserver(this);
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
                Fclient.Activate();
            }
        }

        private void FuserABM_FormClosed(object sender, FormClosedEventArgs e)
        {
            FuserABM = null;
            Subject.RemoveObserver(this);
        }

        private void bitacoraDVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FbitDV == null)
            {
                FbitDV = new BitacoraYDV();
                FbitDV.MdiParent = this;
                FbitDV.FormClosed += FbitDV_FormClosed; ;
                FbitDV.Show();
            }
            else
            {
                Fclient.Activate();
            }
        }

        private void FbitDV_FormClosed(object sender, FormClosedEventArgs e)
        {
            FbitDV = null;
            Subject.RemoveObserver(this);
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
            Subject.Notify(SingletonIdioma.GetInstance().Idioma);
            idiomaOb.CambiarIdiomaDeUsuario();
        }

        private void inglesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SingletonIdioma.GetInstance().Idioma.IdiomaSelected = IdiomaEnum.English;
            Subject.Notify(SingletonIdioma.GetInstance().Idioma);
            idiomaOb.CambiarIdiomaDeUsuario();
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
    }
}
