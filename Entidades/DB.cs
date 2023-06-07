using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace Entidades
{
    public class DB
    {
        public static List<Vuelo> TraerVuelo()
        {
            string vuelo = $"{AppDomain.CurrentDomain.BaseDirectory}/../../Datos/Vuelo.json";

            return TraerEntidades<Vuelo>(vuelo);
        }

        private static List<T> TraerEntidades<T>(string rutaArchivo)
        {
            StreamReader r = new StreamReader(rutaArchivo);
            string jsonString = r.ReadToEnd();
            List<T> entidades = JsonConvert.DeserializeObject<List<T>>(jsonString);

            r.Close();

            return entidades;
        }
    }

}
