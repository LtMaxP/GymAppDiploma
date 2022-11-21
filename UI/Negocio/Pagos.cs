using BLL.Observer;
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
    public partial class PagosCobros : Form, BE.ObserverIdioma.IObserverIdioma
    {
        BLL.BLLClientes bllClientes;
        public PagosCobros()
        {
            InitializeComponent();
        }

        public void Update()
        {

        }

        private void PagosCobros_Load(object sender, EventArgs e)
        {
            bllClientes = new BLL.BLLClientes();
            BE.ObserverIdioma.SubjectIdioma.AddObserverIdioma(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BE.ObserverIdioma.SubjectIdioma.RemoveObserverIdioma(this);
            this.Close();
        }
        /// <summary>
        /// Ver
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void labelBuscar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox_Buscar.Text))
            {
                MessageBox.Show("Debe completar todos los campos.");
            }
            else
            {
                BE.Cliente cli = new BE.Cliente();
                cli.Nombre = textBox_Buscar.Text;
                List<BE.Cliente> busquedaUsuario = bllClientes.AccionBusqueda(cli);
                if (!busquedaUsuario.Count.Equals(0))
                {
                    foreach (BE.Cliente dr in busquedaUsuario)
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

        private void labelMostrar_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un campo.");
            }
            else
            {
                dataGridView1.DataSource = null;
                BE.Cliente client = new BE.Cliente();
                client.Dni = int.Parse(listView.SelectedItems[0].SubItems[1].Text.ToString());
                client = bllClientes.MostrarCliente(client);
                dataGridView1.DataSource = BLL.Negocio.BLLMembresia.DamePagosCliente(client);
                if(dataGridView1.DataSource != null)
                {
                    label2.Text = "$ " + sumarFacturasCliente((List<BE.BE_Cuenta>)dataGridView1.DataSource);
                }
            }
        }

        private string sumarFacturasCliente(List<BE.BE_Cuenta> cuentaPagos)
        {
            double sumatoria = 0;
            foreach(var cuenta in cuentaPagos)
            {
                sumatoria = sumatoria + cuenta.Monto;
            }
            return sumatoria.ToString();
        }

        private void textBox_Buscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxCliente_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBoxCliente.Text, "[^0-9]"))
            {
                MessageBox.Show("Ingrese solamente numeros");
                textBoxCliente.Text = textBoxCliente.Text.Remove(textBoxCliente.Text.Length - 1);
            }
        }

        private void buttonComprar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBoxCliente.Text))
            {
                BE.Cliente cliente = new BE.Cliente();
                cliente.Dni = int.Parse(textBoxCliente.Text);
                if (bllClientes.ValidarSiExiste(cliente))
                {
                    if (BLL.Negocio.BLLMembresia.ValidarFaltaPago(cliente))////
                    {
                        if (BLL.Negocio.BLLMembresia.EjecutarPago(cliente))////
                        {
                            //refresh part
                            dataGridView1.Rows.Clear();
                            dataGridView1.Refresh();
                            MessageBox.Show("Pago exitos ^_^");
                        }
                        else
                            MessageBox.Show("Error a realizar el pago");
                    }
                    else
                    {
                        MessageBox.Show("No pasaron 30 días del último pago");
                    }
                }
                else
                {
                    MessageBox.Show("Cliente no existe");
                }
            }
        }
    }
}
