using BLL.Observer;
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
    public partial class Facturas : Form, IObserver
    {
        public Facturas()
        {
            InitializeComponent();
        }

        private void Facturas_Load(object sender, EventArgs e)
        {
            Subject.AddObserver(this);
            Subject.Notify(SingletonIdioma.GetInstance().Idioma);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Subject.RemoveObserver(this);
            this.Close();
        }

        public void Update(Idioma idioma)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
