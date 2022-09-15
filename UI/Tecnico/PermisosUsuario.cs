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
        private BE.Composite.Component _pAsig;
        private BE.BE_Usuario user = null;

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
            _permisosTotal = _perm.TraerAgrupadosDAL();
            _users = bLLUsuario.TraerUsuarios();
            foreach (var id in _users)
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
            _pAsig = new BE.Composite.Composite();
            arbolAsignados.Nodes.Clear();
            arbolDisponibles.Nodes.Clear();
            user = (BE.BE_Usuario)comboBox1.SelectedItem;
            user = _perm.TraerUsuarioConPermisos(user);
            _pAsig = user.Permisos;
            CargarAsignados(_pAsig, arbolAsignados);
            CargarAsignados(_permisosTotal, arbolDisponibles);
        }

        /// <summary>
        /// Cargar arbol con datos deseados
        /// </summary>
        /// <param name="cmp"></param>
        /// <param name="arbolReferido"></param>
        private void CargarAsignados(BE.Composite.Component cmp, TreeView arbolReferido)
        {
            foreach (BE.Composite.Component perm in cmp.List())
            {
                if (!perm.descripcion.Equals("Arbol"))
                {
                    TreeNode nodoHijo = new TreeNode(perm.iDPatente + "-" + perm.descripcion);
                    if (perm is BE.Composite.Composite)
                    {
                        CheckTree(perm, arbolReferido);
                        arbolReferido.Nodes.Add(ExtenderArbol(perm, nodoHijo));
                    }
                    else
                    {
                        arbolReferido.Nodes.Add(nodoHijo);
                    }
                }
                else if (perm.descripcion.Equals("Arbol"))
                {
                    CargarAsignados(perm, arbolReferido);
                }
            }
        }
        private void CheckTree(BE.Composite.Component perm, TreeView tree)
        {
            List<TreeNode> nodesDelete = new List<TreeNode>();
            foreach (TreeNode node in tree.Nodes)
            {
                string[] permiso = node.Text.Split('-');
                if (perm.VerificarSiExistePermiso(permiso[0]))
                {
                    nodesDelete.Add(node);
                }
            }
            foreach (TreeNode nod in nodesDelete)
                tree.Nodes.Remove(nod);
        }

        private TreeNode ExtenderArbol(BE.Composite.Component perm, TreeNode nodo)
        {
            if (perm is BE.Composite.Composite)
            {
                foreach (var subperm in perm.List())
                {
                    TreeNode nodoHijo = new TreeNode(subperm.iDPatente + "-" + subperm.descripcion);
                    if (subperm is BE.Composite.Composite)
                    {
                        nodo.Nodes.Add(ExtenderArbol(subperm, nodoHijo));
                    }
                    else
                        nodo.Nodes.Add(nodoHijo);
                }
            }
            else
                nodo.Nodes.Add(perm.iDPatente + "-" + perm.descripcion);
            return nodo;
        }

        /// <summary>
        /// Boton de agregar Permiso
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            if (!arbolDisponibles.SelectedNode.IsSelected)
                MessageBox.Show("Debe seleccionar un permiso");
            else
            {
                string[] permiso = arbolDisponibles.SelectedNode.Text.Split('-');
                if (!_pAsig.VerificarSiExistePermiso(permiso[0]))
                {
                    foreach (var permT in _permisosTotal.List())
                    {
                        if (permT.iDPatente.Equals(permiso[0]) || permT.VerificarSiExistePermiso(permiso[0])) 
                        {
                            if (permT.iDPatente.Equals(permiso[0]))
                                CheckPerm(permT); 
                            else
                                CheckPerm(permT.TraetePermiso(permiso[0]));

                            _pAsig.Agregar(_permisosTotal.TraetePermiso(permiso[0]));
                            arbolAsignados.Nodes.Clear();
                            CargarAsignados(_pAsig, arbolAsignados);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("El usuario ya tiene el permiso");
                }
            }
        }

        /// <summary>
        /// Se pasa un permiso compuesto y verifica en el arbol si ya tiene sus hojas en el listado se quitan
        /// </summary>
        /// <param name="p"></param>
        private void CheckPerm(BE.Composite.Component permisoC)
        {
            foreach (var permisoAsignados in _pAsig.List())
            {
                if (permisoC.VerificarSiExiste(permisoAsignados))
                {
                    _pAsig.Eliminar(permisoAsignados);
                }
            }
        }

        /// <summary>
        /// Eliminar Permiso
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            if (!arbolAsignados.SelectedNode.IsSelected)
                MessageBox.Show("Debe seleccionar un permiso");
            else
            {
                string[] permiso = arbolAsignados.SelectedNode.Text.Split('-');
                if (_pAsig.VerificarSiExistePermiso(permiso[0]))
                {
                    _pAsig.Eliminar(_pAsig.TraetePermiso(permiso[0]));
                    arbolAsignados.Nodes.Clear();
                    CargarAsignados(_pAsig, arbolAsignados);
                }
                else
                {
                    MessageBox.Show("¿El usuario no tiene el permiso?");
                }
            }
        }
    }
}
