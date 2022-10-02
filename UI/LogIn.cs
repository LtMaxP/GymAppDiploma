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
        private BLL.DV DigitosVerificadores = new BLL.DV(); 

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
            else
            {
                BE.BE_Usuario user = new BE.BE_Usuario();
                user.User = textBox1.Text;
                user.Pass = textBox2.Text;
                //Detecta que el usuario exista
                if (bllLog.DetectarUsuario(user))
                {
                    //Validar DVV
                    if (DigitosVerificadores.VerificarDB())
                    {
                        this.Hide();
                        Inicio ini = new Inicio();
                        ini.Show();
                    }
                    else
                    {
                        MessageBox.Show("BASE DE DATOS CORRUPTA !!! ");
                        if (user.Permisos.VerificarSiExistePermiso("15"))
                        {
                            this.Hide();
                            Inicio ini = new Inicio();
                            ini.Show();
                            //yblablabla recupera
                        }

                    }
                }
                else
                {
                    MessageBox.Show("Usuario y/o Contraseña incorrectos");
                }
            }

        }

        private void Recuperacion_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(textBox1.Text) && !String.IsNullOrEmpty(textBox2.Text))
            {
                BE.BE_Usuario user = new BE.BE_Usuario();
                user.User = textBox1.Text;
                user.Pass = textBox2.Text;
                string respuesta = Microsoft.VisualBasic.Interaction.InputBox("Ingrese la palabra secreta", "Recuperar contraseña", "Palabra secreta");
                if (bllLog.ValidacionPalabraSecreta(user, respuesta))
                {
                    bllLog.CambiarPass(user);
                    MessageBox.Show("Cambio de contraseña exitoso");
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar un nombre de usuario y nueva contraseña a recuperar");
            }
        }
    }
}
