
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
        BE.Composite.Component family;
        public Permisos()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Inicio de carga Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Permisos_Load(object sender, EventArgs e)
        {
            BE.ObserverIdioma.SubjectIdioma.AddObserverIdioma(this);
            this.LoadForm();
        }
        /// <summary>
        /// Limpiar y cargar form
        /// </summary>
        private void LoadForm()
        {
            this.ClearAll();
            this.LoadStart();
        }
        /// <summary>
        /// Limpiar todo
        /// </summary>
        private void ClearAll()
        {
            ListaPerm.Nodes.Clear();
            ListaPerm.Refresh();
            comboBox1.Items.Clear();
            comboBox1.Refresh();
            comboBox2.Items.Clear();
            comboBox2.Refresh();
        }
        /// <summary>
        /// Cargar comboboxes
        /// </summary>
        private void LoadStart()
        {
            family = new BE.Composite.Composite();
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
        /// <summary>
        /// Salir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SalirBtn_Click(object sender, EventArgs e)
        {
            BE.ObserverIdioma.SubjectIdioma.RemoveObserverIdioma(this);
            this.Close();
        }
        //-
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Agregar Familia en arbol
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AgregarBtn_Click(object sender, EventArgs e)
        {
            BE.Composite.Component elem = (BE.Composite.Component)comboBox1.SelectedItem;
            VerificarSiEsta(elem);
        }
        /// <summary>
        /// Agregar Patente en arbol
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AgregarBtn2_Click(object sender, EventArgs e)
        {
            BE.Composite.Component elem = (BE.Composite.Component)comboBox2.SelectedItem;
            VerificarSiEsta(elem);
        }
        /// <summary>
        /// Verifica si no existe entre los permisos, sino lo agrega
        /// </summary>
        /// <param name="element"></param>
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
        /// <summary>
        /// Filtrado del arbol, eliminando los q estan y generando un desgloce de hojas en la rama componente
        /// </summary>
        /// <param name="perm"></param>
        private void CheckTree(BE.Composite.Component perm)
        {
            List<TreeNode> nodesDelete = new List<TreeNode>();
            foreach (TreeNode node in ListaPerm.Nodes)
            {
                string[] permiso = node.Text.Split('-');
                if (perm.VerificarSiExiste(new BE.Composite.Composite(permiso[0], permiso[1])))
                {
                    nodesDelete.Add(node);
                    family.Eliminar(family.TraetePermiso(permiso[0]));
                }
            }
            foreach (TreeNode nod in nodesDelete)
                ListaPerm.Nodes.Remove(nod);
        }
        /// <summary>
        /// Extender arbol
        /// </summary>
        /// <param name="perm"></param>
        /// <param name="nodo"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Guardar Familia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtName.Text))
            {
                string familiaNombre = txtName.Text;
                BE.Composite.Composite newFamilia = new BE.Composite.Composite();
                foreach (TreeNode element in ListaPerm.Nodes)
                {
                    string[] permiso = element.Text.Split('-');
                    if (element.Nodes.Count > 1)
                        newFamilia.Agregar(new BE.Composite.Composite(permiso[0], permiso[1]));
                    else
                        newFamilia.Agregar(new BE.Composite.Hoja(permiso[0], permiso[1]));
                }

                if (PermBLL.CrearFamilia(newFamilia, familiaNombre))
                {
                    txtName.Clear();
                    this.LoadForm();
                    MessageBox.Show("Familia creada");
                }
                else
                {
                    MessageBox.Show("Familia ya existente");
                }
            }
            else if (ListaPerm.Nodes.Count == 0)
            {
                MessageBox.Show("Ingrese al menos 1 permiso");
            }
            else
            {
                MessageBox.Show("Ingrese un nombre a la familia");
            }
        }
        /// <summary>
        /// Quitar de la lista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (!ListaPerm.SelectedNode.IsSelected)
                MessageBox.Show("Debe seleccionar una patente");
            else
            {
                //if (ListaPerm.SelectedNode.Level > 0)
                //{
                //    MessageBox.Show("No puede quitar un permiso de una familia ya creada");
                //}
                //else
                //{
                    string[] permiso = ListaPerm.SelectedNode.Text.Split('-');
                    family.Eliminar(family.TraetePermiso(permiso[0]));
                    ListaPerm.SelectedNode.Remove();
                //}
            }
        }
        /// <summary>
        /// Eliminar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(comboBox1.Text))
            {
                MessageBox.Show("Debe seleccionar un permiso");
            }
            else
            {
                var result = MessageBox.Show("¿Desea borrar la familia?", "Advertencia", MessageBoxButtons.YesNo);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    if (PermBLL.EliminarFamilia(comboBox1.Text))
                    {
                        MessageBox.Show("Familia eliminada con exito");
                        this.ClearAll();
                        this.LoadStart();
                    }
                }
            }
        }
    }
}
