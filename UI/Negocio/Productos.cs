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
                                        var Citem = items.First(x => x.Descripcion == selectioncmb).Cantidad.ToString();
                                        var CUI = dgr.Cells["Cantidad"].Value.ToString();
                                        labelNroDisponible.Text = (int.Parse(Citem) - int.Parse(CUI)).ToString();
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
                        var Citem = items.First(x => x.Descripcion == selectioncmb).Cantidad.ToString();
                        var CUI = txtBoxCantidad.Text;
                        labelNroDisponible.Text = (int.Parse(Citem) - int.Parse(CUI)).ToString();
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
                    labelNroTotal.Text = (decimal.Parse(labelNroTotal.Text) - (decimal.Parse(row.Cells[1].Value.ToString()) * decimal.Parse(row.Cells[2].Value.ToString()))).ToString();
                    txtBoxCantidad.Text = (int.Parse(txtBoxCantidad.Text) + (int.Parse(row.Cells[1].Value.ToString()))).ToString();
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
    }
}
