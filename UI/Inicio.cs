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

            TraducirTodo();
        }

      
        private void Traducir(Control c)
        {
            //traducis c

            //c.Text;
            foreach(Control item in c.Controls)
            {
                Traducir(item);
            }
        }

        private void TraducirTodo()
        {
            foreach (Control item in this.Controls)
            {

            }
        }

        //Formularios
        Clientes Fclient;
        BitacoraYDV FbitDV;
        UsuariosABM FuserABM;


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
            if (idioma.IdiomaSelected == IdiomaEnum.Español)
            {
                //SingletonIdioma.GetInstance().Idioma.IdiomaSelected = IdiomaEnum.Español;
                //List<BE.Idioma> listado = idioma.DamePackDeIdiomas;
                this.Text = "Form 1 Bienvenidos";
                var a = this.Container.Components;

            }
            else if (idioma.IdiomaSelected == IdiomaEnum.English)
            {
                //SingletonIdioma.GetInstance().Idioma.IdiomaSelected = IdiomaEnum.English;
                this.Text = "Form 1 Welcome";
            }
        }
    }
}
