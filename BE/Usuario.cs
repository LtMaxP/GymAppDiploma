using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{

    public class Usuario
    {
        static void Main() { }

        #region singleton
        private static Usuario _instance;
        private Usuario()
        { }

        public static Usuario Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Usuario();
                }
                return _instance;
            }
        }
        #endregion


        private string user;

        public string User
        {
            get { return user; }
            set { user = value; }
        }

        private string pass;

        public string Pass
        {
            get { return pass; }
            set { pass = value; }
        }

        private int idUsuario;

        public int IdUsuario
        {
            get { return idUsuario; }
            set { idUsuario = value; }
        }

        private string rol;

        public string Rol
        {
            get { return rol; }
            set { rol = value; }
        }

        private string dvh;

        public string _DVH
        {
            get { return dvh; }
            set { dvh = value; }
        }

        private int id_Estado;

        public int idEstado
        {
            get { return id_Estado; }
            set { id_Estado = value; }
        }

        private int id_Idioma;

        public int idIdioma
        {
            get { return id_Idioma; }
            set { id_Idioma = value; }
        }


    }
}
