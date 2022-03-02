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

    public partial class UsuariosABM : Form, BLL.Observer.IObserver
    {
        BLL.Usuario usuarioABM = new BLL.Usuario();

        public UsuariosABM()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Subject.RemoveObserver(this);
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String usuario = textBox3.Text;
            String contraseña = textBox4.Text;
            String idioma = comboBox1.Text;
            String estado = comboBox2.Text;

            if (String.IsNullOrEmpty(usuario) || String.IsNullOrEmpty(contraseña) || String.IsNullOrEmpty(idioma) || String.IsNullOrEmpty(estado))
            {
                MessageBox.Show("Debe completar todos los campos.");
            }
            else
            {
                if (usuarioABM.ValidarSiElUsuarioYaExiste(usuario))
                {
                    usuarioABM.AgregarUsuario(usuario, contraseña, idioma, estado);
                    MessageBox.Show("El usuario fue dado de Alta con éxito.");
                }
                else
                {
                    MessageBox.Show("El nombre de usuario ya existe");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String usuario = textBox3.Text;
            if (String.IsNullOrEmpty(usuario))
            {
                MessageBox.Show("Debe Ingresar un usuario para eliminar");
            }
            else
            {
                usuarioABM.EliminarUsuario(usuario);
                MessageBox.Show("El usuario fue neutralizado con éxito.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string valorDeBusqueda = textBox2.Text;
            String[] filaDeDatos = usuarioABM.BuscarUsuario(valorDeBusqueda);
            if (!string.IsNullOrEmpty(filaDeDatos[0]))
            {
                ListViewItem lvi = new ListViewItem(filaDeDatos[0]);
                for (int i = 1; i < 4; i++)
                {
                    lvi.SubItems.Add(filaDeDatos[i]);
                }
                listView1.Items.Add(lvi);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (listView1.CheckedIndices.Count > 1)
            {
                MessageBox.Show("Seleccione 1 usuario solo a mostrar");
            }
            else if (listView1.Items.Count > 0)
            {

                string user = listView1.SelectedItems[0].SubItems[1].Text;
                String[] filaDeDatos = usuarioABM.BuscarUsuario(user);
                textBox3.Text = filaDeDatos[1];
                comboBox1.SelectedItem = filaDeDatos[2];
                comboBox2.SelectedItem = filaDeDatos[3];
            }
            else
            {
                MessageBox.Show("Debe buscar un usuario y seleccionarlo para Mostrar");
            }
        }

        private void UsuariosABM_Load(object sender, EventArgs e)
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

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
