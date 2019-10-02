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

        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            LogIn log = new LogIn();
            log.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Clientes cl = new Clientes();
            cl.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
            BitacoraYDV bitDV = new BitacoraYDV();
            bitDV.Show();
        }
    }
}
