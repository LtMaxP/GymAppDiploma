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
    public partial class Clientes : Form, BE.ObserverIdioma.IObserverIdioma
    {
        BLLClientes bllClientes = new BLLClientes();
        BLLEmpleados bllEmpleados = new BLLEmpleados();
        public Clientes()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            BE.ObserverIdioma.SubjectIdioma.RemoveObserverIdioma(this);
            this.Close();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            BE.ObserverIdioma.SubjectIdioma.AddObserverIdioma(this);
            DameEstados();
            comboMem.Enabled = false;
        }


        public void Update()
        {

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
                textBox_Nombre.Text = client.Nombre;
                textBox_Apellido.Text = client.Apellido;
                textBox_Dni.Text = client._dni.ToString();
                textBox_Calle.Text = client._calle.ToString();
                textBox_Numero.Text = client._numero.ToString();
                textBox_CodPost.Text = client._codPostal.ToString();
                textBox_Telefono.Text = client._telefono.ToString();
                fechaNacimiento.Value = client._fechaNacimiento;
                textBox_Peso.Text = client._pesokg.ToString();
                comboBox_estado.Text = client.Id_Estado.ToString();
            }
        }

        private void labelAlta_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox_Nombre.Text) || String.IsNullOrEmpty(textBox_Apellido.Text) || String.IsNullOrEmpty(textBox_Dni.Text) || String.IsNullOrEmpty(textBox_Calle.Text) || String.IsNullOrEmpty(textBox_Numero.Text) || String.IsNullOrEmpty(textBox_CodPost.Text) || String.IsNullOrEmpty(textBox_Telefono.Text) || String.IsNullOrEmpty(textBox_Peso.Text) || String.IsNullOrEmpty(comboBox_estado.Text))
            {
                MessageBox.Show("Debe completar todos los campos.");
            }
            else
            {
                BE.Cliente client = new BE.Cliente();
                client.Nombre = textBox_Nombre.Text;
                client.Apellido = textBox_Apellido.Text;
                client._dni = int.Parse(textBox_Dni.Text);
                client._calle = textBox_Calle.Text;
                client._numero = int.Parse(textBox_Numero.Text);
                client._codPostal = int.Parse(textBox_CodPost.Text);
                client._telefono = int.Parse(textBox_Telefono.Text);
                client._fechaNacimiento = fechaNacimiento.Value;
                client._pesokg = int.Parse(textBox_Peso.Text);
                client.Id_Estado = int.Parse(comboBox_estado.Text);
                if (!bllClientes.ValidarSiExiste(client))
                {
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
                cli.Nombre = textBox_Buscar.Text;
                List<Cliente> busquedaUsuario = bllClientes.AccionBusqueda(cli);
                if (!busquedaUsuario.Count.Equals(0))
                {
                    foreach (Cliente dr in busquedaUsuario)
                    {
                        ListViewItem lvi = new ListViewItem(dr._dni.ToString());
                        lvi.SubItems.Add(dr.Nombre);
                        lvi.SubItems.Add(dr.Apellido);
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




        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
        }

        private void textBox_Estado_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            comboMem.Enabled = checkBoxCertif.Checked == true ? true : false;
            if (comboMem.Enabled)
            {

            }
        }
    }
}
