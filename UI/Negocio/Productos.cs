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
            dataGridView1.Columns.Add("ProductoCol", "Producto");
            dataGridView1.Columns.Add("CantidadCol", "Cantidad");
            dataGridView1.Columns.Add("PrecioCol", "Precio");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(comboBox1.Text))
            {
                var item = items.FirstOrDefault(x => x.Descripcion == comboBox1.Text);
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
                dataGridView1.Rows.Add(comboBox1.Text, txtBoxCantidad.Text, labelNroPrecio.Text);

                labelNroTotal.Text = ((Decimal.Parse(txtBoxCantidad.Text) * Decimal.Parse(labelNroPrecio.Text)) + Decimal.Parse(labelNroTotal.Text)).ToString();
            }
            else
            {
                MessageBox.Show("Debe agregar una cantidad del producto seleccionado");
            }
        }

        private void buttonQuitar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                //////////////////
                foreach (int row in dataGridView1.SelectedRows)
                {
                    dataGridView1.Rows.RemoveAt(row);
                }
            }
        }
    }
}
