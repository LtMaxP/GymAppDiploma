using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    class Idioma
    {
        private int id_idioma;

        public int IdIdioma
        {
            get { return id_idioma; }
            set { id_idioma = value; }
        }
        private string texto_label;

        public string TextoLabel
        {
            get { return texto_label; }
            set { texto_label = value; }
        }

        private int _idLbl;

        public int IDlbl
        {
            get { return _idLbl; }
            set { _idLbl = value; }
        }



    }
}
