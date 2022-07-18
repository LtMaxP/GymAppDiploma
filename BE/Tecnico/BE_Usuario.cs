using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BE_Usuario
    {
        public BE_Usuario() { }

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

        private ObserverIdioma.BE_Idioma _idioma;
        public ObserverIdioma.BE_Idioma Idioma
        {
            get { return _idioma; }
            set { _idioma = value; }
        }


        private List<BE.Composite.Component> _permisos;
        public List<BE.Composite.Component> Permisos
        {
            get { return _permisos; }
            set { _permisos = value; }
        }

    }
}
