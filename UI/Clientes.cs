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
    public partial class Clientes : Form, BLL.Observer.IObserver
    {
        public Clientes()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Subject.RemoveObserver(this);
            this.Close();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            Subject.AddObserver(this);
            Subject.Notify(SingletonIdioma.GetInstance().Idioma);
        }

        public void Update(Idioma idioma)
        {
            //RecurseToolStripItems(this.menuStrip1.Items);
            //foreach (Control item in this.Controls)
            //{
            //    Inicio ini = new Inicio();
            //    ini.Traducir(item);
            //}
        }

        private void labelMostrar_Click(object sender, EventArgs e)
        {

        }

        private void labelAlta_Click(object sender, EventArgs e)
        {

        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            string nomUser = textBox_Buscar.Text;

        }
    }
}
