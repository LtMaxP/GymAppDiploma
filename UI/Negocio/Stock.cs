using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE;

namespace UI.Negocio
{
    public partial class Stock : Form, BE.ObserverIdioma.IObserverIdioma
    {
        BLL.Negocio.BLLProducto BLLProd = new BLL.Negocio.BLLProducto();
        List<Item> items = new List<Item>();
        public Stock()
        {
            InitializeComponent();
        }

        private void Stock_Load(object sender, EventArgs e)
        {
            BE.ObserverIdioma.SubjectIdioma.AddObserverIdioma(this);
            BE.ObserverIdioma.SubjectIdioma.Notify();
            LoadItems();
        }
        private void LoadItems()
        {
            items = BLLProd.TraerProductos();
            comboBox1.DataSource = items;
            comboBox1.DisplayMember = "Descripcion";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BE.ObserverIdioma.SubjectIdioma.RemoveObserverIdioma(this);
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectioncmb = ((Item)comboBox1.SelectedItem).Descripcion;
            if (!String.IsNullOrEmpty(comboBox1.Text))
            {
                var item = items.First(x => x.Descripcion == selectioncmb);
                labelNroDisponible.Text = item.Cantidad.ToString();
                txtBoxPrecio.Text = item.Valor.ToString();
                txtBoxCantidad.Text = "0";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (int.Parse(txtBoxCantidad.Text) > 0 || Decimal.Parse(txtBoxPrecio.Text) != ((Item)comboBox1.SelectedItem).Valor)
            {
                Item it = new Item();
                it.Descripcion = comboBox1.Text;
                it.Cantidad = int.Parse(txtBoxCantidad.Text);
                it.Valor = Decimal.Parse(txtBoxPrecio.Text);
                if (BLLProd.CargarProducto(it))
                {
                    MessageBox.Show("Se cargo stock con exito");
                    LoadItems();
                }
                else
                    MessageBox.Show("No se pudo cargar stock");
            }
            else
            {
                MessageBox.Show("Debe modificar al menos 1 producto");
            }
        }
    }
}
