using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public class Sesion
    {
        #region singleton

        private static Sesion _sesion;
        public BE.BE_Usuario usuario { get; set; }
        public DateTime FechaInicio { get; set; }

        private static object _lock = new object();

        public static Sesion GetInstance
        {
            get
            {
                if (_sesion == null) throw new Exception("Sesión no iniciada");

                return _sesion;
            }
        }
        public static void Login(BE.BE_Usuario user)
        {
            lock (_lock)
            {
                if (_sesion == null)
                {
                    _sesion = new Sesion();
                    _sesion.usuario = user;
                    _sesion.FechaInicio = DateTime.Now;
                }
                else
                {
                    throw new Exception("Sesión ya iniciada");
                }
            }
        }
        public static void Logout()
        {
            lock (_lock)
            {
                if (_sesion != null)
                {
                    _sesion = null;
                }
                else
                {
                    throw new Exception("Sesión no iniciada");
                }
            }
        }
        #endregion
    }
}
