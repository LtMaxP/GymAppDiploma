
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
    public partial class Permisos : Form, BE.ObserverIdioma.IObserverIdioma
    {
        private BLL.Tecnico.PermisosBLL PermBLL = new BLL.Tecnico.PermisosBLL();
        BE.Composite.Component family = new BE.Composite.Composite();
        public Permisos()
        {
            InitializeComponent();
        }

        private void Permisos_Load(object sender, EventArgs e)
        {
            BE.ObserverIdioma.SubjectIdioma.AddObserverIdioma(this);
            var PermisosTotal = PermBLL.TraerComponentesFyP();
            foreach (var element in PermisosTotal.List())
            {
                if (element.GetType() == typeof(BE.Composite.Composite))
                {
                    comboBox1.Items.Add(element);
                }
                else
                {
                    comboBox2.Items.Add(element);
                }
            }
            comboBox1.ValueMember = "descripcion";
            comboBox2.ValueMember = "descripcion";

        }

        private void SalirBtn_Click(object sender, EventArgs e)
        {
            BE.ObserverIdioma.SubjectIdioma.RemoveObserverIdioma(this);
            this.Close();
        }

        private void ConsultarBtn_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AgregarBtn_Click(object sender, EventArgs e)
        {
            BE.Composite.Component elem = (BE.Composite.Component)comboBox1.SelectedItem;
            VerificarSiEsta(elem);
        }

        private void AgregarBtn2_Click(object sender, EventArgs e)
        {
            BE.Composite.Component elem = (BE.Composite.Component)comboBox2.SelectedItem;
            VerificarSiEsta(elem);

        }
        private void VerificarSiEsta(BE.Composite.Component element)
        {
            if (element == null)
            {
                MessageBox.Show("Debe seleccionar un permiso");
            }
            else if (family.VerificarSiExiste(element))
            {
                MessageBox.Show("El permiso ya existe");
            }
            else
            {
                family.Agregar(element);
                TreeNode nodoHijo = new TreeNode(element.iDPatente + "-" + element.descripcion);
                if (element is BE.Composite.Composite)
                {
                    CheckTree(element);
                    ListaPerm.Nodes.Add(ExtenderArbol(element, nodoHijo));
                }
                else
                    ListaPerm.Nodes.Add(nodoHijo);

            }
        }

        private void CheckTree(BE.Composite.Component perm)
        {
            List<TreeNode> nodesDelete = new List<TreeNode>();
            foreach (TreeNode node in ListaPerm.Nodes)
            {
                string[] permiso = node.Text.Split('-');
                if (perm.VerificarSiExiste(new BE.Composite.Composite(permiso[0], permiso[1])))
                {
                    nodesDelete.Add(node);
                }
            }
            foreach(TreeNode nod in nodesDelete)
                    ListaPerm.Nodes.Remove(nod);//si se remueve se caga el ListaPerm.Nodes
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
                nodo.Nodes.Add(perm.iDPatente + "-" + perm.descripcion);//element.iDPatente + "-" + element.descripcion
            return nodo;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtName.Text))
            {
                BE.BE_Usuario user = new BE.BE_Usuario();
                user.User = txtName.Text;
                if (PermBLL.DetectarUsuario(user))
                {
                    BE.Composite.Component permisos = new BE.Composite.Composite();
                    //foreach (BE.Composite.Component element in ListaPerm.Items)
                    //{
                    //    permisos.Agregar(element);
                    //}
                    //user.Permisos = permisos;
                    //agregar al usuario permisos y fin
                }
                else
                {
                    MessageBox.Show("Usuario no encontrado");
                }
            }
            else
            {
                MessageBox.Show("Ingrese un usuario");
            }
        }
    }
}
