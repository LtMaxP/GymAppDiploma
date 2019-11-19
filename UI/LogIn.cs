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

    public partial class LogIn : Form
    {
        public void Mostrar()
        {
            this.Show();
        }
        private BLL.Login bllLog = new BLL.Login();
        private BLL.BitacoraBLL bit = new BLL.BitacoraBLL();
        int contador = 0;
        public LogIn()
        {
            InitializeComponent();
        }

        public void LogIn_Load(object sender, EventArgs e)
        {

        }

        public void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == String.Empty || textBox2.Text == String.Empty)
            {
                MessageBox.Show("Debe ingresar un usuario o contraseña para avanzar");
            }
            
            //Detecta que el usuario exista
            if(bllLog.DetectarUsuario(textBox1.Text, textBox2.Text))
            {
                this.Hide();
                Inicio ini = new Inicio();
                ini.Show();
            }
            else
            {
                MessageBox.Show("Usuario y/o Contraseña incorrectos");
                if (contador == 3)
                {
                    contador = 0;
                }
                else
                { contador++; }
            }
            
            
        }

    }
}
