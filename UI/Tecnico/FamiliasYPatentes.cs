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
    public partial class FamiliasYPatentes : Form, IObserver
    {
        public FamiliasYPatentes()
        {
            InitializeComponent();
        }

        public void Update(Idioma idioma)
        {

        }

        private void FamiliasYPatentes_Load(object sender, EventArgs e)
        {
            Subject.AddObserver(this);
            Subject.Notify(SingletonIdioma.GetInstance().Idioma);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Subject.RemoveObserver(this);
            this.Close();
        }
    }
}
