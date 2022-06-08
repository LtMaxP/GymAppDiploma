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
    public partial class Permisos : Form, BLL.Observer.IObserver
    {
        public Permisos()
        {
            InitializeComponent();
        }

        public void Update(Idioma idioma)
        {
            throw new NotImplementedException();
        }

        private void Permisos_Load(object sender, EventArgs e)
        {

        }

        private void SalirBtn_Click(object sender, EventArgs e)
        {
            Subject.RemoveObserver(this);
            this.Close();
        }
    }
}
