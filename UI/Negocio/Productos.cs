using BE;
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

namespace UI.Negocio
{
    public partial class Productos : Form, BE.ObserverIdioma.IObserverIdioma
    {
        BLL.Negocio.BLLProducto BLLProd = new BLL.Negocio.BLLProducto();
        BLL.BLLClientes clients = new BLL.BLLClientes();
        List<Item> items = new List<Item>();
        public Productos()
        {
            InitializeComponent();
        }


        private void button4_Click(object sender, EventArgs e)
        {
            //check cliente y guardar para productos a comprarle
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            BE.ObserverIdioma.SubjectIdioma.RemoveObserverIdioma(this);
            this.Close();
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            BE.ObserverIdioma.SubjectIdioma.AddObserverIdioma(this);
            items = BLLProd.TraerProductos();
            comboBox1.DataSource = items;
            comboBox1.DisplayMember = "Descripcion";
            GenerarGrilla();
        }
        private void GenerarGrilla()
        {
            dataGridView1.Columns.Add("Producto", "Producto");
            dataGridView1.Columns.Add("Cantidad", "Cantidad");
            dataGridView1.Columns.Add("Precio", "Precio");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillComboBox1();
        }
        private void FillComboBox1()
        {
            string selectioncmb = ((Item)comboBox1.SelectedItem).Descripcion;
            if (!String.IsNullOrEmpty(comboBox1.Text))
            {
                var item = items.First(x => x.Descripcion == selectioncmb);
                labelNroDisponible.Text = item.Cantidad.ToString();
                labelNroPrecio.Text = item.Valor.ToString();
            }
        }

        public void Update()
        {
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtBoxCantidad.Text))
            {
                if (!ValidarCantidadDisponible())
                {
                    string selectioncmb = ((Item)comboBox1.SelectedItem).Descripcion;
                    Boolean found = false;
                    try
                    {
                        if (dataGridView1.Rows.Count > 1)
                        {
                            foreach (DataGridViewRow dgr in dataGridView1.Rows)
                            {
                                if (!dgr.Index.Equals(dataGridView1.Rows.Count - 1))
                                    if (dgr.Cells["Producto"].Value.ToString().Equals(selectioncmb))
                                    {
                                        dgr.Cells["Cantidad"].Value = (int.Parse(dgr.Cells["Cantidad"].Value.ToString()) + int.Parse(txtBoxCantidad.Text)).ToString();
                                        items.First(x => x.Descripcion == selectioncmb).Cantidad -= int.Parse(txtBoxCantidad.Text);
                                        labelNroDisponible.Text = items.First(x => x.Descripcion == selectioncmb).Cantidad.ToString();
                                        found = true;
                                        break;
                                    }
                            }
                        }
                    }
                    catch { }
                    if (!found)
                    {
                        dataGridView1.Rows.Add(comboBox1.Text, txtBoxCantidad.Text, labelNroPrecio.Text);
                        items.First(x => x.Descripcion == selectioncmb).Cantidad -= int.Parse(txtBoxCantidad.Text);
                        labelNroDisponible.Text = items.First(x => x.Descripcion == selectioncmb).Cantidad.ToString();
                    }

                    CalcularValorTotal();
                }
                else
                {
                    MessageBox.Show("La cantidad del producto es mayor a la disponible");
                }
            }
            else
            {
                MessageBox.Show("Debe agregar una cantidad del producto seleccionado");
            }
        }

        /// <summary>
        /// Suma productos para el Total $$$
        /// </summary>
        private void CalcularValorTotal()
        {
            Decimal total = 0;
            try
            {
                foreach (DataGridViewRow dgr in dataGridView1.Rows)
                {
                    if (dgr.Cells[1].Value != null)
                    {
                        total += (Decimal.Parse(dgr.Cells["Cantidad"].Value.ToString()) * Decimal.Parse(dgr.Cells["Precio"].Value.ToString()));
                    }
                }
            }
            catch { }
            labelNroTotal.Text = total.ToString();
        }

        private void buttonQuitar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    //string selectioncmb = ((Item)comboBox1.SelectedItem).Descripcion;//aca estas tomando del combobox no de la lista seleccionada
                    //string selectioncmb = ((Item)row.DataBoundItem).Descripcion;
                    string selectioncmb = row.Cells[0].FormattedValue.ToString();
                    items.First(x => x.Descripcion == selectioncmb).Cantidad += int.Parse(txtBoxCantidad.Text);
                    labelNroDisponible.Text = items.First(x => x.Descripcion == selectioncmb).Cantidad.ToString();

                    labelNroTotal.Text = (decimal.Parse(labelNroTotal.Text) - (decimal.Parse(row.Cells[1].Value.ToString()) * decimal.Parse(row.Cells[2].Value.ToString()))).ToString();
                    dataGridView1.Rows.Remove(row);
                }
            }
        }


        /// <summary>
        /// Calcula si hay disponibilidad
        /// </summary>
        /// <returns></returns>
        private Boolean ValidarCantidadDisponible()
        {
            return int.Parse(txtBoxCantidad.Text) > int.Parse(labelNroDisponible.Text) ? true : false;
        }

        private void buttonComprar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBoxCliente.Text))
            {
                BE.Cliente cliente = new BE.Cliente();
                cliente.Dni = int.Parse(textBoxCliente.Text);
                if (clients.ValidarSiExiste(cliente))
                {
                    if (dataGridView1.Rows.Count > 1)
                    {
                        BE_Factura Compra = new BE_Factura();
                        List<Item> productos = new List<Item>();
                        foreach (DataGridViewRow dgr in dataGridView1.Rows)
                        {
                            if (dgr.Cells[1].Value != null)
                            {
                                productos.Add(new Item(dgr.Cells["Producto"].Value.ToString(), Decimal.Parse(dgr.Cells["Precio"].Value.ToString()), int.Parse(dgr.Cells["Cantidad"].Value.ToString())));
                            }
                        }
                        Compra.Items = productos;
                        Compra.Fecha = DateTime.Now;
                        Compra.Monto = Decimal.Parse(labelNroTotal.Text);
                        Compra.Id_Cliente = clients.DameIdCliente(cliente);
                        BLL.BLLFacturas.EjecutarCompra(Compra);

                        //refresh part
                        dataGridView1.Rows.Clear();
                        dataGridView1.Refresh();
                        items = BLLProd.TraerProductos();
                        FillComboBox1();
                        MessageBox.Show("Compra exitosa ^_^");

                    }
                    else
                    {
                        MessageBox.Show("Debe agregar productos a comprar");
                    }
                }
                else
                {
                    MessageBox.Show("Debe ingresar un DNI de cliente a comprar");
                }
            }

        }

        private void textBoxCliente_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBoxCliente.Text, "[^0-9]"))
            {
                MessageBox.Show("Ingrese solamente numeros");
                textBoxCliente.Text = textBoxCliente.Text.Remove(textBoxCliente.Text.Length - 1);
            }
        }
    }
}
