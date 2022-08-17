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
        BLL.Usuario bLLUsuario = new BLL.Usuario();
        BLL.Tecnico.PermisosBLL Perm = new BLL.Tecnico.PermisosBLL();
        private List<BE.BE_Usuario> users;
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
            users = bLLUsuario.TraerUsuarios();
            foreach (var id in users)
            {
                comboBox1.Items.Add(id);
            }
            comboBox1.ValueMember = "User";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            SubjectIdioma.RemoveObserverIdioma(this);
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            BE.BE_Usuario us = (BE.BE_Usuario)comboBox1.SelectedItem;
            lblUserName.Text = us.User;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(lblUserName.Text))
            {
                lblUserName.Text = users.First(x => x.IdUsuario == int.Parse(comboBox1.Text)).User;
            }
        }
        /// <summary>
        /// Boton Consultar carga los asignados al cliente y llama a la función que detecte los q no estan en la lista para cargad disponible
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            treeView2.Nodes.Clear();
            TreeNode nodoHijo = null;
            BE.BE_Usuario user = (BE.BE_Usuario)comboBox1.SelectedItem;
            user = Perm.TraerUsuarioConPermisos(user);

            foreach (var perm in user.Permisos.List())
            {
                if (!perm.descripcion.Equals("Arbol"))
                {

                    nodoHijo = new TreeNode(perm.descripcion);
                    treeView2.Nodes.Add(ExtenderArbol(perm, nodoHijo));
                }
            }
            CargarDisponibles(treeView1);

        }

        private void CargarDisponibles(TreeView tree)
        {
            List<TreeNode> nodesAdd = new List<TreeNode>();
            foreach (TreeNode node in tree.Nodes)
            {
                string[] permiso = node.Text.Split('-');
                //if (perm.VerificarSiExiste(new BE.Composite.Composite(permiso[0], permiso[1])))
                //{
                    nodesAdd.Add(node);
                //}
            }
            foreach (TreeNode nod in nodesAdd)
                tree.Nodes.Add(nod);
        }

        private void CheckTree(BE.Composite.Component perm, TreeNode tree)
        {
            List<TreeNode> nodesDelete = new List<TreeNode>();
            foreach (TreeNode node in tree.Nodes)
            {
                string[] permiso = node.Text.Split('-');
                if (perm.VerificarSiExiste(new BE.Composite.Composite(permiso[0], permiso[1])))
                {
                    nodesDelete.Add(node);
                }
            }
            foreach (TreeNode nod in nodesDelete)
                tree.Nodes.Remove(nod);
        }
        private TreeNode ExtenderArbol(BE.Composite.Component perm, TreeNode nodo)
        {
            TreeNode nodoHijo = null;
            if (perm is BE.Composite.Composite)
            {
                foreach (var subperm in perm.List())
                {
                    if (subperm is BE.Composite.Composite)
                    {
                        nodoHijo = new TreeNode(subperm.iDPatente + "-" + subperm.descripcion);
                        nodo.Nodes.Add(ExtenderArbol(subperm, nodoHijo));
                    }
                    else
                        nodo.Nodes.Add(subperm.iDPatente + "-" + subperm.descripcion);
                }
            }
            else
                nodo.Nodes.Add(perm.iDPatente + "-" + perm.descripcion);
            return nodo;
        }
    }
}
