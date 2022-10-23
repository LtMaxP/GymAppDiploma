using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Servicios
{
    public class Serializar
    {
        public static void Guardar<T>(T data, String url)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                FileStream fStream = File.Open(url, FileMode.Create);
                serializer.Serialize(fStream, data);
                fStream.Close();
            }
            catch (Exception e)
            {
            }

        }
    }
}
