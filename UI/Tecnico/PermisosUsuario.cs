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
        private BLL.Usuario bLLUsuario = new BLL.Usuario();
        private BLL.Tecnico.PermisosBLL _perm = new BLL.Tecnico.PermisosBLL();
        private List<BE.BE_Usuario> _users;
        private BE.Composite.Component _permisosTotal;
        private BE.Composite.Component _pDispo = new BE.Composite.Composite();
        private BE.Composite.Component _pAsig = new BE.Composite.Composite();

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
            _users = bLLUsuario.TraerUsuarios();
            foreach (var id in _users)
            {
                comboBox1.Items.Add(id);
            }
            comboBox1.ValueMember = "User";
            _permisosTotal = _perm.TraerComponentesFyP();
            CargarDisponibles();
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
                lblUserName.Text = _users.First(x => x.IdUsuario == int.Parse(comboBox1.Text)).User;
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
            BE.BE_Usuario user = (BE.BE_Usuario)comboBox1.SelectedItem;
            user = _perm.TraerUsuarioConPermisos(user);
            CargarAsignadosUsuario(user);
        }

        /// <summary>
        /// Carga Todo el campo PyF Disponibles 
        /// </summary>
        private void CargarDisponibles()
        {
            foreach (BE.Composite.Component perm in _permisosTotal.List())
            {
                if (!perm.descripcion.Equals("Arbol"))
                {
                    TreeNode nodoHijo = new TreeNode(perm.iDPatente + "-" + perm.descripcion);
                    if (perm is BE.Composite.Composite)
                    {
                        CheckTree(perm, treeView1);
                        treeView1.Nodes.Add(ExtenderArbol(perm, nodoHijo));
                    }
                    else
                    {
                        treeView1.Nodes.Add(nodoHijo);
                    }
                }
            }
        }

        /// <summary>
        /// Cargar los permisos asignados por usuario
        /// </summary>
        /// <param name="user"></param>
        private void CargarAsignadosUsuario(BE.BE_Usuario user)
        {
            foreach (BE.Composite.Component perm in user.Permisos.List())
            {
                if (!perm.descripcion.Equals("Arbol"))
                {
                    TreeNode nodoHijo = new TreeNode(perm.iDPatente + "-" + perm.descripcion);
                    if (perm is BE.Composite.Composite)
                    {
                        CheckTree(perm, treeView2);
                        treeView2.Nodes.Add(ExtenderArbol(perm, nodoHijo));
                    }
                    else
                    {
                        treeView2.Nodes.Add(nodoHijo);
                    }
                }
            }
        }

        private void CheckTree(BE.Composite.Component perm, TreeView tree)
        {
            List<TreeNode> nodesDelete = new List<TreeNode>();
            foreach (TreeNode node in tree.Nodes)
            {
                string[] permiso = node.Text.Split('-');
                if (perm.VerificarSiExiste(perm.TraetePermiso(permiso[0])))
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
