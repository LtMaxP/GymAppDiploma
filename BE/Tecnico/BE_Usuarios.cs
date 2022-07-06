using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BE_Usuarios
    {
        public BE_Usuarios(string usuario, string password, int id_Idioma)
        {
            this.User = usuario;
            this.Pass = password;
            this.idIdioma = id_Idioma;
        }
        public BE_Usuarios(string usuario, int id_Idioma, int id_Estado)
        {
            this.User = usuario;
            this.idEstado = id_Estado;
            this.idIdioma = id_Idioma;
        }
        public BE_Usuarios() { }

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

        private ObserverIdioma.BE_Idioma _idioma;

        public ObserverIdioma.BE_Idioma Idioma
        {
            get { return _idioma; }
            set { _idioma = value; }
        }


        private string _rol;

        public string rol
        {
            get { return _rol; }
            set { _rol = value; }
        }

        //private List<Composite.component> _arbol;  //Mal tiene q venir el Component de la bll, pasar todo eso tmb a la BE

        //public List<BE.> arbol
        //{
        //    get { return _arbol; }
        //    set { _arbol = value; }
        //}

    }
}
