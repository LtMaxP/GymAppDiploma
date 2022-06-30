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

namespace UI.Negocio
{
    public partial class Productos : Form, IObserver
    {
        public Productos()
        {
            InitializeComponent();
        }

        public void Update(Idioma idioma)
        {
            throw new NotImplementedException();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //check cliente y guardar para productos a comprarle
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Subject.RemoveObserver(this);
            this.Close();
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            Subject.AddObserver(this);
            Subject.Notify(SingletonIdioma.GetInstance().Idioma);
        }
    }
}
