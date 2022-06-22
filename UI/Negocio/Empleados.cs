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
    public partial class Empleados : Form, BLL.Observer.IObserver
    {
        public Empleados()
        {
            InitializeComponent();
        }

        public void Update(Idioma idioma)
        {
            
        }

        private void Empleados_Load(object sender, EventArgs e)
        {
            Subject.AddObserver(this);
            Subject.Notify(SingletonIdioma.GetInstance().Idioma);
        }

        private void labelSalir_Click(object sender, EventArgs e)
        {
            Subject.RemoveObserver(this);
            this.Close();
        }

        private void labelBuscar_Click(object sender, EventArgs e)
        {

        }

        private void labelAgregar_Click(object sender, EventArgs e)
        {

        }
    }
}
