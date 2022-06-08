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

        private int _intentosFallidos;

        public int IntentosFallidos
        {
            get { return _intentosFallidos; }
            set { _intentosFallidos = value; }
        }

        private string _dVH;

        public string DVH
        {
            get { return _dVH; }
            set { _dVH = value; }
        }


        private Composite _arbol;

        public Composite arbol
        {
            get { return _arbol; }
            set { _arbol = value; }
        }
    }
}
