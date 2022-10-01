using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public class Calculos
    {
        /// <summary>
        /// Devuelve la composición corporal por el calculo del IMC
        /// </summary>
        /// <param name="peso"></param>
        /// <param name="altura"></param>
        /// <returns></returns>
        public static string CalcularIMC(string peso, string altura)
        {
            double calculo = double.Parse(peso) / (Math.Pow(double.Parse(altura), 2));
            string respuesta = null;
            if(calculo <= 18.5)
            {
                respuesta = "Peso inferior al normal";
            }
            else if (calculo >= 18.5 && calculo <= 24.9)
            {
                respuesta = "Normal";
            }
            else if (calculo >= 25.0 && calculo <= 29.9)
            {
                respuesta = "Peso superior al normal";
            }
            else if (calculo >= 30.0)
            {
                respuesta = "Obesidad";
            }
            return respuesta;
        }
    }
}
