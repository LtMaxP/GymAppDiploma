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

namespace UI
{
    public partial class Clientes : Form, BLL.Observer.IObserver
    {
        BLLClientes bllClientes;
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
        }

        public void Update(Idioma idioma)
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

        }

        private void labelAlta_Click(object sender, EventArgs e)
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
            //client.Ejercicio = BE_ejercicio. listRutina.Text;
            bllClientes.Alta(client);
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            string nomUser = textBox_Buscar.Text;

        }
    }
}
