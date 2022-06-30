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
    public partial class Clases : Form, IObserver
    {
        public Clases()
        {
            InitializeComponent();
        }

        public void Update(Idioma idioma)
        {
            throw new NotImplementedException();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Subject.RemoveObserver(this);
            this.Close();
        }

        private void Clases_Load(object sender, EventArgs e)
        {
            Subject.AddObserver(this);
            Subject.Notify(SingletonIdioma.GetInstance().Idioma);
        }
    }
}
