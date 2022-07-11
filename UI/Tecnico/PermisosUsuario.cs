using BE.ObserverIdioma;
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
    public partial class PermisosUsuario : Form, BE.ObserverIdioma.IObserverIdioma
    {
        public PermisosUsuario()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            SubjectIdioma.RemoveObserverIdioma(this);
            this.Close();
        }

        private void PermisosUsuario_Load_1(object sender, EventArgs e)
        {
            SubjectIdioma.AddObserverIdioma(this);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            SubjectIdioma.RemoveObserverIdioma(this);
            this.Close();
        }
    }
}
