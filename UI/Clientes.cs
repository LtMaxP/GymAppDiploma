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
using BLL;
using BE;

namespace UI
{
    public partial class Clientes : Form, BLL.Observer.IObserver
    {
        BLLClientes bllClientes = new BLLClientes();
        public Clientes()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Subject.RemoveObserver(this);
            this.Close();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            Subject.AddObserver(this);
            Subject.Notify(SingletonIdioma.GetInstance().Idioma);
            llenarLugaresDefault();
            DameEstados();
        }

        public void llenarLugaresDefault()
        {
            if (comboBox_provincia.Items.Count.Equals(0))
            {
                foreach (BE_Provincia value in bllClientes.dameTodasProvincias())
                {
                    comboBox_provincia.Items.Add(value.Descripcion);
                }
                comboBox_provincia.SelectedItem = comboBox_provincia.Items[0];
                //string provincia = comboBox_provincia.Items[0].ToString();
                //comboBox_Localidad.Items.Clear();
                //foreach (BE_Localidad value in bllClientes.DameLocalidad(provincia))
                //{
                //    comboBox_Localidad.Items.Add(value.Descripcion);
                //}
                //comboBox_Localidad.SelectedItem = comboBox_Localidad.Items[0];
                //foreach (BE_Sucursal value in bllClientes.DameSucursales(comboBox_Localidad.Items[0].ToString()))
                //{
                //    comboBox_sucursal.Items.Add(value.Descripcion);
                //}
                //comboBox_sucursal.SelectedItem = comboBox_sucursal.Items[0];
            }
        }

        public void Update(BLL.Observer.Idioma idioma)
        {
            //RecurseToolStripItems(this.menuStrip1.Items);
            //foreach (Control item in this.Controls)
            //{
            //    Inicio ini = new Inicio();
            //    ini.Traducir(item);
            //}
        }

        private void labelMostrar_Click(object sender, EventArgs e)
        {

            string seleccionado = listView.SelectedItems[0].Text;
            if (String.IsNullOrEmpty(seleccionado))
            {
                MessageBox.Show("Debe seleccionar un campo.");
            }
            else
            {
                BE.Cliente client = new BE.Cliente();
                client._dni = int.Parse(seleccionado);
                client = bllClientes.MostrarCliente(client);
                textBox_Nombre.Text = client._nombre;
                textBox_Apellido.Text = client._apellido;
                textBox_Dni.Text = client._dni.ToString();
                textBox_Calle.Text = client._calle.ToString();
                textBox_Numero.Text = client._numero.ToString();
                textBox_CodPost.Text = client._codPostal.ToString();
                textBox_Telefono.Text = client._telefono.ToString();
                fechaNacimiento.Value = client._fechaNacimiento;
                textBox_Peso.Text = client._pesokg.ToString();
                comboBox_estado.Text = client._idEstado.ToString();
                comboBox_sucursal.Text = client._IDSucursal.ToString();

                comboBox_profesor.Text = client._IDEmpleado.ToString();
            }
        }

        private void labelAlta_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox_Nombre.Text) || String.IsNullOrEmpty(textBox_Apellido.Text) || String.IsNullOrEmpty(textBox_Dni.Text) || String.IsNullOrEmpty(textBox_Calle.Text) || String.IsNullOrEmpty(textBox_Numero.Text) || String.IsNullOrEmpty(textBox_CodPost.Text) || String.IsNullOrEmpty(textBox_Telefono.Text) || String.IsNullOrEmpty(textBox_Peso.Text) || String.IsNullOrEmpty(comboBox_estado.Text) || String.IsNullOrEmpty(comboBox_sucursal.Text) || String.IsNullOrEmpty(comboBox_profesor.Text))
            {
                MessageBox.Show("Debe completar todos los campos.");
            }
            else
            {
                BE.Cliente client = new BE.Cliente();
                client._nombre = textBox_Nombre.Text;
                client._apellido = textBox_Apellido.Text;
                client._dni = int.Parse(textBox_Dni.Text);
                client._calle = textBox_Calle.Text;
                client._numero = int.Parse(textBox_Numero.Text);
                client._codPostal = int.Parse(textBox_CodPost.Text);
                client._telefono = int.Parse(textBox_Telefono.Text);
                client._fechaNacimiento = fechaNacimiento.Value;
                client._pesokg = int.Parse(textBox_Peso.Text);
                client._idEstado = int.Parse(comboBox_estado.Text);
                client._IDSucursal = int.Parse(comboBox_sucursal.Text);
                client._IDEmpleado = int.Parse(comboBox_profesor.Text);
                if (!bllClientes.ValidarSiExiste(client))
                {
                    //client.Ejercicio = BE_ejercicio. listRutina.Text;
                    if (bllClientes.Alta(client))
                    {

                        MessageBox.Show("El cliente fue dado de Alta con éxito.");
                    }
                    else
                    {
                        MessageBox.Show("No se pudo dar de alta el cliente");
                    }
                }
                else
                {
                    MessageBox.Show("El nombre de usuario ya existe");
                }
            }

        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox_Buscar.Text))
            {
                MessageBox.Show("Debe completar todos los campos.");
            }
            else
            {
                BE.Cliente cli = new BE.Cliente();
                cli._nombre = textBox_Buscar.Text;
                List<Cliente> busquedaUsuario = bllClientes.AccionBusqueda(cli);
                if (!busquedaUsuario.Count.Equals(0))
                {
                    foreach (Cliente dr in busquedaUsuario)
                    {
                        ListViewItem lvi = new ListViewItem(dr._dni.ToString());
                        lvi.SubItems.Add(dr._nombre);
                        lvi.SubItems.Add(dr._apellido);
                        listView.Items.Add(lvi);
                    }
                }
                else
                {
                    MessageBox.Show("No se encontraron clientes con ese nombre");
                }

            }
        }

        private void textBox_Nombre_TextChanged(object sender, EventArgs e)
        {

        }

        //Manera de agregar al combobox valores
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void DameEstados()
        {
            if (comboBox_estado.Items.Count.Equals(0))
            {
                foreach (string value in bllClientes.dameEstados())
                {
                    comboBox_estado.Items.Add(value);
                }
                comboBox_estado.SelectedItem = comboBox_estado.Items[0];
            }
        }

        string nextVal;
        private void CascadeFilter(string filter, string value)
        {
            
            switch (filter)
            {
                case "Provincia":
                    PopularProvincia(value);
                    nextVal = value;
                    goto case "Localidad";
                case "Localidad":
                    PopularLocalidad(value ?? nextVal);
                    nextVal = value;
                    goto case "Sucursal";
                case "Sucursal":
                    PopularSucursal(value);
                    nextVal = value;
                    goto case "Profesor";
                case "Profesor":
                    PopularProfesor(value);
                    break;
            }
        }

        private void PopularProfesor(string sucursal)
        {
            ////////////foreach (BE_Profesor value in bllClientes.DameProfesores(sucursal))
            ////////////{
            ////////////    comboBox_profesor.Items.Add(value.Descripcion);
            ////////////}
            ////////////comboBox_profesor.SelectedItem = comboBox_profesor.Items[0];
        }

        private void PopularLocalidad(string provincia)
        {
            foreach (BE_Localidad value in bllClientes.DameLocalidad(provincia))
            {
                comboBox_Localidad.Items.Add(value.Descripcion);
            }
            comboBox_Localidad.SelectedItem = comboBox_Localidad.Items[0];
        }

        //Sucursal
        private void PopularSucursal(string localidad)
        {
            foreach (BE_Sucursal value in bllClientes.DameSucursales(localidad))
            {
                comboBox_sucursal.Items.Add(value.Descripcion);
            }
            comboBox_sucursal.SelectedItem = comboBox_sucursal.Items[0];
        }

        //localidad
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(comboBox_Localidad.SelectedItem.ToString()))
            {
                string localidad = comboBox_Localidad.SelectedItem.ToString();
                comboBox_sucursal.Items.Clear();
                CascadeFilter("Sucursal", localidad);
            }
        }

        public void comboBox_provincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(comboBox_provincia.SelectedItem.ToString()))
            {
                string provin = comboBox_provincia.SelectedItem.ToString();
                comboBox_Localidad.Items.Clear();
                comboBox_sucursal.Items.Clear();
                CascadeFilter("Localidad", provin);
            }
        }
        private void PopularProvincia(string prov)
        {
            if (comboBox_provincia.Items.Count.Equals(0))
            {
                foreach (BE_Provincia value in bllClientes.dameTodasProvincias())
                {
                    comboBox_provincia.Items.Add(value.Descripcion);
                }
            }
            else
            {
                foreach (BE_Localidad value in bllClientes.DameLocalidad(prov))
                {
                    comboBox_Localidad.Items.Add(value.Descripcion);
                }
            }
        }



        private void comboBox_sucursal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(comboBox_sucursal.SelectedItem.ToString()))
            {
                //string sucursal = comboBox_sucursal.SelectedItem.ToString();
                //comboBox_sucursal.Items.Clear();
                //CascadeFilter("Sucursal", sucursal);
            }
        }

        private void comboBox_profesor_SelectedIndexChanged(object sender, EventArgs e)
        {
            //dar profesor usar en la bll y dal [dbo].[DameProfesoresEnSucursal] te da 3 campos ya de una <=5
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
        }

        private void textBox_Estado_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
