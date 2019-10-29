using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Idioma
    {
        private string idiomaPerteneciente;

        public string _idiomaPerteneciente
        {
            get { return idiomaPerteneciente; }
            set { idiomaPerteneciente = value; }
        }

        private string texto_label;

        public string _textoLabel
        {
            get { return texto_label; }
            set { texto_label = value; }
        }

        private string nombreEtiqueta;

        public string _nombreEtiqueta
        {
            get { return nombreEtiqueta; }
            set { nombreEtiqueta = value; }
        }



    }
}
