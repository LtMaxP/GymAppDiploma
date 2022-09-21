using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.Tecnico
{
    public class ControlCambio
    {
        public int idEntidad { get; set; }
        public string descripcion { get; set; }
        public string campo { get; set; }
        public string valorOriginal { get; set; }
        public string valorNuevo { get; set; }
        public DateTime fechaModificacion { get; set; }
        public int secuencia { get; set; }
        public string Operacion { get; set; }
        public int UsuarioID { get; set; }

    }
}
