using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Seguridad
{
    public class Encriptacion
    {
        static void Main() { }
        public string Encriptador(string txtEnciptar)
        {
            byte[] cadenaDeBytes;
            cadenaDeBytes = new UnicodeEncoding().GetBytes(txtEnciptar);
            byte[] cadenaEncriptada = ((HashAlgorithm)CryptoConfig.CreateFromName("MD5")).ComputeHash(cadenaDeBytes);
            string cadena = BitConverter.ToString(cadenaEncriptada);
            return cadena;
        }
    }
}
