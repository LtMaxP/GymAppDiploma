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

    public partial class UsuariosABM : Form, BE.ObserverIdioma.IObserverIdioma
    {
        BLL.Usuario usuarioABM = new BLL.Usuario();

        public UsuariosABM()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            BE.ObserverIdioma.SubjectIdioma.RemoveObserverIdioma(this);
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BE.BE_Usuario nuevoUsuario = new BE.BE_Usuario();
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
                nuevoUsuario.User = usuario;
                nuevoUsuario.Pass = contraseña;
                usuarioABM.DevolverIDs(nuevoUsuario, idioma, estado);

                if (!usuarioABM.ValidarSiElUsuarioYaExiste(nuevoUsuario.User))
                {
                    usuarioABM.AgregarUsuario(nuevoUsuario);
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
            BE.BE_Usuario usuarioDelete = new BE.BE_Usuario();
            usuarioDelete.User = textBox3.Text;
            usuarioDelete.Pass = textBox4.Text;
            if (String.IsNullOrEmpty(usuarioDelete.User))
            {
                MessageBox.Show("Debe Ingresar un usuario para eliminar");
            }
            else
            {
                usuarioABM.EliminarUsuario(usuarioDelete);
                MessageBox.Show("El usuario fue neutralizado con éxito.");
            }
        }
        /// <summary>
        /// Buscar Usuario y mostrar listado de match
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            BE.BE_Usuario usuario = new BE.BE_Usuario();
            usuario.User = textBox2.Text;
            List<BE.BE_Usuario> filaDeDatos = usuarioABM.BuscarUsuario(usuario);

            if (filaDeDatos.Count > 0)
            {
                if (listView1.Items.Count > 0)
                {
                    listView1.Items.RemoveAt(0);
                }
                foreach (BE.BE_Usuario u in filaDeDatos)
                {
                    ListViewItem lista = new ListViewItem();
                    lista.SubItems.Add(u.User.ToString());
                    lista.SubItems.Add(u.Idioma.Id.ToString());
                    lista.SubItems.Add(u.idEstado.ToString());
                    listView1.Items.AddRange(new ListViewItem[] { lista });
                }
            }
        }
        /// <summary>
        /// Buscar seleccion de Usuarios mostrados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button6_Click(object sender, EventArgs e)
        {
            if (listView1.CheckedIndices.Count > 1)
            {
                MessageBox.Show("Seleccione 1 usuario solo a mostrar");
            }
            else if (listView1.Items.Count > 0)
            {
                BE.BE_Usuario usuario = new BE.BE_Usuario();
                usuario.User = listView1.SelectedItems[0].SubItems[1].Text;
                BE.BE_Usuario filaDeDatos = usuarioABM.MostrarUsuario(usuario);
                textBox3.Text = filaDeDatos.User;
                comboBox1.SelectedIndex = filaDeDatos.Idioma.Id -1;
                comboBox2.SelectedIndex = filaDeDatos.idEstado -1;
            }
            else
            {
                MessageBox.Show("Debe buscar un usuario y seleccionarlo para Mostrar");
            }
        }

        private void UsuariosABM_Load(object sender, EventArgs e)
        {
            BE.ObserverIdioma.SubjectIdioma.AddObserverIdioma(this);

            //////////////DataTable dt = usuarioABM.CargarCombo("Rol");
            //////////////comboBox3.DataSource = dt;
            //////////////comboBox3.DisplayMember = "Nombre";
        }

        public void Update()
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

        private void labelModificar_Click(object sender, EventArgs e)
        {

            BE.BE_Usuario modUsuario = new BE.BE_Usuario();
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
                modUsuario.User = usuario;
                modUsuario.Pass = contraseña;
                usuarioABM.DevolverIDs(modUsuario, idioma, estado);

                if (!usuarioABM.ValidarSiElUsuarioYaExiste(modUsuario.User))
                {
                    usuarioABM.ModificarUsuario(modUsuario, idioma, estado);
                    MessageBox.Show("El usuario fue dado de Alta con éxito.");
                }
                else
                {
                    MessageBox.Show("El nombre de usuario ya existe");
                }
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }
    }
}
