using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class ABMUsuarios
    {
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



        //private string dvh;

        //public string _DVH
        //{
        //    get { return dvh; }
        //    set { dvh = value; }
        //}

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

        private string _rol;

        public string rol
        {
            get { return _rol; }
            set { _rol = value; }
        }

    }
}
