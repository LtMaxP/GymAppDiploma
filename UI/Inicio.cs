using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }
        
        //Formularios
        Clientes Fclient;
        BitacoraYDV FbitDV;
        UsuariosABM FuserABM;

        private void Inicio_Load(object sender, EventArgs e)
        {

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
            if(Fclient == null)
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
                Fclient.Activate();
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
        }
    }
}
