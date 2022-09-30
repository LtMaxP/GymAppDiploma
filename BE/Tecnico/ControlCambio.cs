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
        public decimal valor { get; set; }
        public int cantidad { get; set; }
        public DateTime fechaModificacion { get; set; }
        public int usuarioID { get; set; }
        public string operacion { get; set; }
        public int secuencia { get; set; }

        public ControlCambio() { }

        public ControlCambio(int idEntidad, string descrip, decimal valor, int cantidad, DateTime fecha, int usuarioID, string operac, int secuencia)
        {
            this.idEntidad = idEntidad;
            this.descripcion = descrip;
            this.valor = valor;
            this.cantidad = cantidad;
            this.fechaModificacion = fecha;
            this.usuarioID = usuarioID;
            this.operacion = operac;
            this.secuencia = secuencia;
        }

        /// <summary>
        /// Constructor para datos principales
        /// </summary>
        /// <param name="idEntidad"></param>
        /// <param name="valor"></param>
        /// <param name="cantidad"></param>
        /// <param name="secuencia"></param>
        public ControlCambio(int idEntidad, decimal valor, int cantidad, string descripcion, string operacion, int secuencia)
        {
            this.idEntidad = idEntidad;
            this.valor = valor;
            this.cantidad = cantidad;
            this.descripcion = descripcion;
            this.operacion = operacion;
            this.secuencia = secuencia;
        }
    }
}