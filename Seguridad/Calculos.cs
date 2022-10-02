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
            float alturaf = float.Parse(altura);
            alturaf = alturaf / 100;
            float pesof = float.Parse(peso);
            float imc = (pesof / (alturaf * alturaf));
            if(imc <= 18.5)
            {
                return "Peso inferior al normal";
            }
            else if (imc >= 18.5 && imc <= 24.9)
            {
                return "Normal";
            }
            else if (imc >= 25.0 && imc <= 29.9)
            {
                return "Peso superior al normal";
            }
            else //(calculo >= 30.0)
            {
                return "Obesidad";
            }
        }
    }
}
