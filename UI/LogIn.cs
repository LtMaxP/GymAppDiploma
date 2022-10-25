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
        private BLL.DV DigitosVerificadores = new BLL.DV();

        public LogIn()
        {
            InitializeComponent();
        }

        public void LogIn_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Boton Salir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Boton Ingresar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                        if (user.Permisos != null)
                            if (user.Permisos.VerificarSiExistePermiso("15"))
                            {
                                this.Hide();
                                Inicio ini = new Inicio();
                                ini.Show();
                                BackupRestore bk = new BackupRestore();
                                bk.Show();
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
            if (!String.IsNullOrEmpty(textBox1.Text) && !String.IsNullOrEmpty(textBox2.Text))
            {
                BE.BE_Usuario user = new BE.BE_Usuario();
                user.User = textBox1.Text;
                user.Pass = textBox2.Text;
                string respuesta = Microsoft.VisualBasic.Interaction.InputBox("Usuario y Pass nueva tomados, ingrese la palabra secreta ya creada", "Recuperar contraseña", "Palabra secreta");
                user.PSecreta = respuesta;
                if (bllLog.ValidacionPalabraSecreta(user))
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

        private void btn_usa_Click(object sender, EventArgs e)
        {
            //UI.Inicio.
        }
    }
}
