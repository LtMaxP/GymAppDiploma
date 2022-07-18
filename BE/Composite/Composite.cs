using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.Composite
{
    public class Composite
    {
        /// <summary>
        /// Codigo de usuario de composite
        /// </summary>
        public string UsuarioCodigo { get; set; }
        /// <summary>
        /// Codigo del permiso
        /// </summary>
        public string PermisoCodigo { get; set; }
        /// <summary>
        /// Representa el id del compontene
        /// </summary>
        public string IdComponente { get; set; }
        /// <summary>
        /// Representa la descripcion del composite
        /// </summary>
        public string Descripcion { get; set; }
        /// <summary>
        /// Representa el id del componente hijo
        /// </summary>
        public string IdComponenteHijo { get; set; }
        /// <summary>
        /// Constructor
        /// </summary>
        public Composite()
        { }
        /// <summary>
        /// Constructor sobrecargado
        /// </summary>
        /// <param name="UsuarioCodigo"></param>
        /// <param name="PermisoCodigo"></param>
        /// <param name="IdComponente"></param>
        /// <param name="Descripcion"></param>
        /// <param name="IdComponenteHijo"></param>
        public Composite(string UsuarioCodigo, string PermisoCodigo, string IdComponente, string Descripcion, string IdComponenteHijo)
        {
            this.UsuarioCodigo = UsuarioCodigo;
            this.PermisoCodigo = PermisoCodigo;
            this.IdComponente = IdComponente;
            this.Descripcion = Descripcion;
            this.IdComponenteHijo = IdComponenteHijo;
        }
    }

}
