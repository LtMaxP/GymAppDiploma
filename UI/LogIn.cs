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
        private BLL.Login bllLog = new BLL.Login();

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
            string usuario = textBox1.Text;
            string pass = textBox2.Text;

            Boolean consulta = bllLog.DetectarUsuario(usuario, pass);
            if(consulta)
            {
                Console.WriteLine("OK");
            }
            else
            {
                Console.WriteLine("Usuario o Contraseña incorrecto");
            }
        }
    }
}
