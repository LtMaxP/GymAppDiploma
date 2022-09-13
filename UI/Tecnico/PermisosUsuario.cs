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
            _permisosTotal = _perm.TraerAgrupadosDAL();
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

            //CargarArbol(_permisosTotal, arbolDisponibles);
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
        #region guardado
        //private void button2_Click(object sender, EventArgs e)
        //{
        //    BE.BE_Usuario user = (BE.BE_Usuario)comboBox1.SelectedItem;
        //    _pDispo = new BE.Composite.Composite("0", "Arbol");
        //    _pAsig = new BE.Composite.Composite("0", "Arbol");
        //    user = _perm.TraerUsuarioConPermisos(user);
        //    CargarArboles(user.Permisos);
        //}

        //private void CargarArboles(BE.Composite.Component _permisosUsuario)
        //{
        //    foreach (BE.Composite.Component permiso in _permisosTotal.List())
        //    {
        //        if (!permiso.descripcion.Equals("Arbol"))
        //        {
        //            if (_permisosUsuario.VerificarSiExiste(permiso))
        //            {
        //                if (permiso is BE.Composite.Composite)
        //                {
        //                    FormateoFamilia(permiso, _pAsig);
        //                    _pAsig.Agregar(permiso);
        //                }
        //                else
        //                    _pAsig.Agregar(permiso);
        //            }
        //            else
        //            {
        //                if (permiso is BE.Composite.Composite)
        //                {
        //                    FormateoFamilia(permiso, _pDispo);
        //                    _pDispo.Agregar(permiso);
        //                }
        //                else
        //                    _pDispo.Agregar(permiso);
        //            }
        //        }
        //    }
        //}

        //private void FormateoFamilia(BE.Composite.Component perm, BE.Composite.Component permContenedor)
        //{
        //    foreach (var node in permContenedor.List())
        //    {
        //        if (perm.VerificarSiExiste(node))
        //        {
        //            perm.Eliminar(node);
        //        }
        //    }
        //}

        #endregion
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
            //CargarArbol(user.Permisos, arbolAsignados, _pAsig);
            CargarAsignados(_pAsig, arbolAsignados);
            CargarAsignados(_permisosTotal, arbolDisponibles);
        }

        private void CargarDisponibles(TreeView arbolDisponibles)
        {
            foreach (BE.Composite.Component perm in _permisosTotal.List())
            {
                if (!perm.descripcion.Equals("Arbol"))
                {
                    TreeNode nodoHijo = new TreeNode(perm.iDPatente + "-" + perm.descripcion);
                    if (perm is BE.Composite.Composite)
                    {
                        CheckTree(perm, arbolDisponibles);
                        arbolDisponibles.Nodes.Add(ExtenderArbol(perm, nodoHijo));
                    }
                    else
                    {
                        arbolDisponibles.Nodes.Add(nodoHijo);
                    }
                    //_pDispo.Agregar(perm);
                }
            }
        }

        /// <summary>
        /// Cargar los permisos asignados por usuario
        /// </summary>
        /// <param name="user"></param>
        private void CargarArbol(BE.Composite.Component cmp, TreeView arbolReferido, BE.Composite.Component permReferido)
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
                    permReferido.Agregar(cmp);
                }
            }
        }
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
                    //if (!_pAsig.VerificarSiExiste(subperm))
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
        /// Agregar Permiso
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
                    foreach (var p in _permisosTotal.List())
                    {
                        if (p.iDPatente.Equals(permiso[0]) || p.VerificarSiExistePermiso(permiso[0])) 
                        {
                            if (p.iDPatente.Equals(permiso[0]))
                                CheckPerm(p); 
                            else
                                CheckPerm(p.TraetePermiso(permiso[0]));

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

        private void CheckPerm(BE.Composite.Component p)
        {
            foreach (var pow in _pAsig.List())
            {
                if (p.VerificarSiExiste(pow))
                {
                    _pAsig.Eliminar(pow);
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
