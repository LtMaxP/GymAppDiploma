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
            CascadeFilter("Provincia", "1");
            DameEstados();
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
                textBox_Estado.Text = client._idEstado.ToString();
                textBox_Sucursal.Text = client._IDSucursal.ToString();
                textBox_Profesor.Text = client._IDEmpleado.ToString();
            }
        }

        private void labelAlta_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox_Nombre.Text) || String.IsNullOrEmpty(textBox_Apellido.Text) || String.IsNullOrEmpty(textBox_Dni.Text) || String.IsNullOrEmpty(textBox_Calle.Text) || String.IsNullOrEmpty(textBox_Numero.Text) || String.IsNullOrEmpty(textBox_CodPost.Text) || String.IsNullOrEmpty(textBox_Telefono.Text) || String.IsNullOrEmpty(textBox_Peso.Text) || String.IsNullOrEmpty(textBox_Estado.Text) || String.IsNullOrEmpty(textBox_Sucursal.Text) || String.IsNullOrEmpty(textBox_Profesor.Text))
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
                client._idEstado = int.Parse(textBox_Estado.Text);
                client._IDSucursal = int.Parse(textBox_Sucursal.Text);
                client._IDEmpleado = int.Parse(textBox_Profesor.Text);
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
            }
        }

        private void CascadeFilter(string filter, string value)
        {
            switch (filter)
            {
                case "Provincia":
                    PopularProvincia(value);
                    break;
                case "Localidad":

                case "Sucursal":
                    break;

            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void comboBox_provincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            CascadeFilter("Localidad", comboBox_provincia.SelectedText);
        }
        private void PopularProvincia(string prov)
        {
            if (comboBox_provincia.Items.Count.Equals(0))
            {
                foreach (BE_Provincia value in bllClientes.dameProvincias())
                {
                    comboBox_provincia.Items.Add(value.Descripcion);
                }
            }
            else
            {
                foreach (BE_Localidad value in bllClientes.DameLocalidad(prov))
                {
                    comboBox_provincia.Items.Add(value.Descripcion);
                }
            }

        }

        private void comboBox_sucursal_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_profesor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
        }
    }
}
