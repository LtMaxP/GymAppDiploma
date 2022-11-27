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
        public Clientes()
        {
            InitializeComponent();
        }
        //--
        private void label9_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Boton Salir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button6_Click(object sender, EventArgs e)
        {
            BE.ObserverIdioma.SubjectIdioma.RemoveObserverIdioma(this);
            this.Close();
        }
        /// <summary>
        /// Form open
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Clientes_Load(object sender, EventArgs e)
        {
            BE.ObserverIdioma.SubjectIdioma.AddObserverIdioma(this);
            DameEstados();
            SetDataInicial();
            BE.ObserverIdioma.SubjectIdioma.Notify();
        }
        /// <summary>
        /// Cargar data inicial
        /// </summary>
        private void SetDataInicial()
        {
            foreach (var memb in BLL.Negocio.BLLMembresia.DameMembresias())
            {
                comboMem.Items.Add(memb);
            }
            comboMem.ValueMember = "Descripcion";
            comboMem.Enabled = false;
        }
        public void Update()
        {

        }
        /// <summary>
        /// Mostrar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelMostrar_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un campo.");
            }
            else
            {
                resetAll();
                BE.Cliente client = new BE.Cliente();
                client.Dni = int.Parse(listView.SelectedItems[0].SubItems[1].Text.ToString());
                client = bllClientes.MostrarCliente(client);
                textBox_Nombre.Text = client.Nombre;
                textBox_Apellido.Text = client.Apellido;
                textBox_Dni.Text = client.Dni.ToString();
                textBox_Calle.Text = client._calle.ToString();
                textBox_Numero.Text = client._numero.ToString();
                textBox_CodPost.Text = client._codPostal.ToString();
                textBox_Telefono.Text = client._telefono.ToString();
                fechaNacimiento.Value = client._fechaNacimiento;
                comboBox_estado.SelectedItem = Enum.GetName(typeof(BLLClientes.Estado), client.Id_Estado); //formato para agarrar enums
                textBox_Peso.Text = client._pesokg.ToString();
                textBoxAltura.Text = client.Altura.ToString();
                checkBoxCertif.Checked = client.Certificado;
                BE.Negocio.BE_Membresia mem = BLL.Negocio.BLLMembresia.DameMembresiaPorId(client.Membresia.Id);
                int memComi = comboMem.FindString(mem.Descripcion);
                comboMem.SelectedItem = comboMem.Items[memComi];
                int descComi = comboDesc.FindString(client.Descuento.ToString());
                comboDesc.SelectedItem = comboDesc.Items[descComi];
            }
        }
        /// <summary>
        /// Limpiar todos los campos
        /// </summary>
        private void resetAll()
        {
            textBox_Nombre.Clear();
            textBox_Apellido.Clear();
            textBox_Calle.Clear();
            textBox_Numero.Clear();
            textBox_CodPost.Clear();
            textBox_Telefono.Clear();
            fechaNacimiento.ResetText();
            textBox_Peso.Clear();
            textBoxAltura.Clear();
            checkBoxCertif.Checked = false;
            comboMem.Enabled = false;
            comboDesc.Enabled = false;
            textBox_Dni.Clear();

        }
        /// <summary>
        /// Boton Alta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelAlta_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox_Nombre.Text) || String.IsNullOrEmpty(textBox_Apellido.Text) || String.IsNullOrEmpty(textBox_Dni.Text) || String.IsNullOrEmpty(textBox_Calle.Text) || String.IsNullOrEmpty(textBox_Numero.Text) || String.IsNullOrEmpty(textBox_CodPost.Text) || String.IsNullOrEmpty(textBox_Telefono.Text) || String.IsNullOrEmpty(textBox_Peso.Text) || String.IsNullOrEmpty(comboBox_estado.Text))
            {
                MessageBox.Show("Debe completar todos los campos.");
            }
            else
            {
                if (int.Parse(labelValorEdad.Text) > 18)
                {
                    BE.Cliente client = new BE.Cliente();
                    client.Dni = int.Parse(textBox_Dni.Text);
                    if (!bllClientes.ValidarSiExiste(client))
                    {
                        client.Nombre = textBox_Nombre.Text;
                        client.Apellido = textBox_Apellido.Text;
                        client._calle = textBox_Calle.Text;
                        client._numero = int.Parse(textBox_Numero.Text);
                        client._codPostal = int.Parse(textBox_CodPost.Text);
                        client._telefono = int.Parse(textBox_Telefono.Text);
                        client._fechaNacimiento = fechaNacimiento.Value;
                        client._pesokg = float.Parse(textBox_Peso.Text);
                        client.Altura = float.Parse(textBoxAltura.Text);
                        client.Certificado = checkBoxCertif.Checked;
                        if (checkBoxCertif.Checked)
                        {
                            client.Id_Estado = BLL.Negocio.BLLEstado.DameIdEst(comboBox_estado.SelectedItem.ToString());// BLLClientes.Estado;// comboBox_estado.SelectedItem["ID"];
                            client.Membresia = (BE.Negocio.BE_Membresia)comboMem.SelectedItem;
                            client.Descuento = int.Parse(comboDesc.SelectedItem.ToString().Replace("%", ""));
                        }
                        else
                        {
                            client.Id_Estado = (int)BLL.BLLClientes.Estado.Pendiente;
                        }
                        if (bllClientes.Alta(client))
                        {
                            MessageBox.Show("El cliente fue dado de Alta con éxito.");
                            resetAll();
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
                else
                {
                    MessageBox.Show("Solo se aceptan mayores de 18 años");
                }
            }

        }
        /// <summary>
        /// Buscar por nombre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                        ListViewItem lvi = new ListViewItem();
                        lvi.SubItems.Add(dr.Dni.ToString());
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
        //--
        private void textBox_Nombre_TextChanged(object sender, EventArgs e)
        {

        }
        //--
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Traer estados
        /// </summary>
        private void DameEstados()
        {
            if (comboBox_estado.Items.Count.Equals(0))
            {
                foreach (string value in bllClientes.dameEstados())
                {
                    comboBox_estado.Items.Add(value);
                }
                comboBox_estado.SelectedItem = comboBox_estado.Items[0]; //podrias modificarlo
            }
        }
        /// <summary>
        /// Calcular IMC
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCalc_Click(object sender, EventArgs e)
        {
            comboMem.Enabled = checkBoxCertif.Checked == true ? true : false;
            if (comboMem.Enabled && !String.IsNullOrEmpty(textBox_Dni.Text) && !String.IsNullOrEmpty(textBox_Peso.Text) && !String.IsNullOrEmpty(textBoxAltura.Text))
            {
                string peso = textBox_Peso.Text;
                string altura = textBoxAltura.Text;
                labelIMC.Text = Servicios.Calculos.CalcularIMC(peso, altura);
            }
            else
            {
                MessageBox.Show("Debe completar los datos del cliente para Calcular el IMC");
            }
        }
        /// <summary>
        /// Calculo automatico fecha de nacimiento
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fechaNacimiento_ValueChanged(object sender, EventArgs e)
        {
            var edad = DateTime.Now.Year - fechaNacimiento.Value.Year;
            labelValorEdad.Text = edad.ToString();
        }
        /// <summary>
        /// Validacion para checkbox certificado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBoxCertif_CheckedChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox_Dni.Text) && !comboMem.Enabled)
            {
                comboMem.Enabled = true;
                comboDesc.Enabled = true;
            }
            else if (comboMem.Enabled)
            {
                comboMem.Enabled = false;
                comboDesc.Enabled = false;
            }
            else if (String.IsNullOrEmpty(textBox_Dni.Text))
            {
                checkBoxCertif.CheckState = CheckState.Unchecked;
                MessageBox.Show("Debe completar los datos del cliente para esta validación");
            }
        }
        /// <summary>
        /// Modificar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelModificar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox_Nombre.Text) || String.IsNullOrEmpty(textBox_Apellido.Text) || String.IsNullOrEmpty(textBox_Dni.Text) || String.IsNullOrEmpty(textBox_Calle.Text) || String.IsNullOrEmpty(textBox_Numero.Text) || String.IsNullOrEmpty(textBox_CodPost.Text) || String.IsNullOrEmpty(textBox_Telefono.Text) || String.IsNullOrEmpty(textBox_Peso.Text) || String.IsNullOrEmpty(comboBox_estado.Text))
            {
                MessageBox.Show("Debe completar todos los campos.");
            }
            else
            {
                BE.Cliente client = new BE.Cliente();
                client.Dni = int.Parse(textBox_Dni.Text);
                if (bllClientes.ValidarSiExiste(client))
                {
                    client.Nombre = textBox_Nombre.Text;
                    client.Apellido = textBox_Apellido.Text;
                    client._calle = textBox_Calle.Text;
                    client._numero = int.Parse(textBox_Numero.Text);
                    client._codPostal = int.Parse(textBox_CodPost.Text);
                    client._telefono = int.Parse(textBox_Telefono.Text);
                    client._fechaNacimiento = fechaNacimiento.Value;
                    client._pesokg = int.Parse(textBox_Peso.Text);
                    client.Altura = float.Parse(textBoxAltura.Text);
                    client.Certificado = checkBoxCertif.Checked;
                    if (checkBoxCertif.Checked)
                    {
                        client.Id_Estado = BLL.Negocio.BLLEstado.DameIdEst(comboBox_estado.SelectedItem.ToString());
                        client.Membresia = (BE.Negocio.BE_Membresia)comboMem.SelectedItem;
                        client.Descuento = int.Parse(comboDesc.SelectedItem.ToString().Replace("%", ""));
                    }
                    else
                    {
                        client.Id_Estado = (int)BLL.BLLClientes.Estado.Pendiente;
                    }
                    if (bllClientes.Modificar(client))
                    {
                        MessageBox.Show("El cliente fue Modificado con éxito.");
                        resetAll();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo Modificar el cliente");
                    }
                }
                else
                {
                    MessageBox.Show("El usuario no ya existe");
                }
            }
        }

        private void labelBaja_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox_Nombre.Text) || String.IsNullOrEmpty(textBox_Apellido.Text) || String.IsNullOrEmpty(textBox_Dni.Text) || String.IsNullOrEmpty(textBox_Calle.Text) || String.IsNullOrEmpty(textBox_Numero.Text) || String.IsNullOrEmpty(textBox_CodPost.Text) || String.IsNullOrEmpty(textBox_Telefono.Text) || String.IsNullOrEmpty(textBox_Peso.Text) || String.IsNullOrEmpty(comboBox_estado.Text))
            {
                MessageBox.Show("Debe completar todos los campos.");
            }
            else
            {
                BE.Cliente client = new BE.Cliente();
                client.Dni = int.Parse(textBox_Dni.Text);
                if (bllClientes.ValidarSiExiste(client))
                {

                    if (BLL.Negocio.BLLEstado.DameIdEst(comboBox_estado.SelectedItem.ToString()) != 2)
                    {
                        bllClientes.Baja(client);
                        MessageBox.Show("Cliente dado de baja");
                        resetAll();
                    }
                    else
                    {
                        MessageBox.Show("El cliente ya esta dado de baja");
                    }
                }
                else
                {
                    MessageBox.Show("El usuario no existe");
                }
            }
        }

        private void textBox_Dni_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox_Dni.Text, "[^0-9]"))
            {
                MessageBox.Show("Ingrese solamente numeros");
                textBox_Dni.Text = textBox_Dni.Text.Remove(textBox_Dni.Text.Length - 1);
            }
        }

        private void textBox_Numero_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox_Numero.Text, "[^0-9]"))
            {
                MessageBox.Show("Ingrese solamente numeros");
                textBox_Numero.Text = textBox_Numero.Text.Remove(textBox_Numero.Text.Length - 1);
            }
        }

        private void textBox_Telefono_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox_Telefono.Text, "[^0-9]"))
            {
                MessageBox.Show("Ingrese solamente numeros");
                textBox_Telefono.Text = textBox_Telefono.Text.Remove(textBox_Telefono.Text.Length - 1);
            }
        }

        private void textBox_Peso_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox_Peso.Text, "[^0-9]"))
            {
                MessageBox.Show("Ingrese solamente numeros");
                textBox_Peso.Text = textBox_Peso.Text.Remove(textBox_Peso.Text.Length - 1);
            }
        }

        private void textBoxAltura_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBoxAltura.Text, "[^0-9]"))
            {
                MessageBox.Show("Ingrese solamente numeros");
                textBoxAltura.Text = textBoxAltura.Text.Remove(textBoxAltura.Text.Length - 1);
            }
        }

        private void textBox_CodPost_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox_Dni.Text, "[^0-9]"))
            {
                MessageBox.Show("Ingrese solamente numeros");
                textBox_CodPost.Text = textBox_CodPost.Text.Remove(textBox_CodPost.Text.Length - 1);
            }
        }
    }
}
