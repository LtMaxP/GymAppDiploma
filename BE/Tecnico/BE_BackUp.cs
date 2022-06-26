using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.Tecnico
{
    public class BE_BackUp
    {
        private string _path;

        public string Path
        {
            get { return _path; }
            set { _path = value; }
        }
        private DateTime _fecha;

        public DateTime Fecha
        {
            get { return _fecha; }
            set { _fecha = value; }
        }


        public BE_BackUp(string ruta, DateTime fechaV)
        {
            this.Path = ruta;
            this.Fecha = fechaV;
        }
    }
}
