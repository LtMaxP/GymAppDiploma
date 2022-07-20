
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
    public partial class Permisos : Form, BE.ObserverIdioma.IObserverIdioma
    {
        BLL.Tecnico.PermisosBLL PermBLL = new BLL.Tecnico.PermisosBLL();
        public Permisos()
        {
            InitializeComponent();
        }


        private void Permisos_Load(object sender, EventArgs e)
        {
            BE.ObserverIdioma.SubjectIdioma.AddObserverIdioma(this);
            comboBox1.DataSource = PermBLL.TraerFamilias();
            comboBox2.DataSource = PermBLL.TraerPatentes();
        }

        private void SalirBtn_Click(object sender, EventArgs e)
        {
            BE.ObserverIdioma.SubjectIdioma.RemoveObserverIdioma(this);
            this.Close();
        }

        private void ConsultarBtn_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
