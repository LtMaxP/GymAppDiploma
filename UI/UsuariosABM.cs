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

    public partial class UsuariosABM : Form
    {
        BLL.Usuario usuarioABM = new BLL.Usuario();

        public UsuariosABM()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            Inicio ventanaAAbrir = new Inicio();
            ventanaAAbrir.Show();
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
                usuarioABM.AgregarUsuario(usuario, contraseña, idioma, estado);
                MessageBox.Show("El usuario fue dado de Alta con éxito.");
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

            ListViewItem lvi = new ListViewItem(filaDeDatos[0]);
            for (int i = 1; i < 4; i++)
            {
                lvi.SubItems.Add(filaDeDatos[i]);
            }
            listView1.Items.Add(lvi);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (listView1.Focused)
            {
                MessageBox.Show(listView1.FocusedItem.ToString());

            }
        }
    }
}
