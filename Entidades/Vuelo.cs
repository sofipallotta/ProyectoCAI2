using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;
using Newtonsoft.Json;

namespace Entidades
{
    public class Vuelo
    {
        private int _idVuelo;
        private string _nombreProducto;
        private string _descripcion;
        private int _precio;
        private string _destino;
        private string _origen;

        public int idVuelo { get => _idVuelo; set => _idVuelo = value; }
        public string nombreProducto { get => _nombreProducto; set => _nombreProducto = value; }
        public string descripcion { get => _descripcion; set => _descripcion = value; }
        public int precio { get => _precio; set => _precio = value; }
        public string destino { get => _destino; set => _destino = value; }
        public string origen { get => _origen; set => _origen = value; }



        private static List<Vuelo> TraerEntidades<T>(string rutaArchivo)
        {
            StreamReader r = new StreamReader(rutaArchivo);
            string jsonString = r.ReadToEnd();
            List<Vuelo> entidades = JsonConvert.DeserializeObject<List<Vuelo>>(jsonString);

            r.Close();

            return entidades;
        }

        public static List<Vuelo> TraerVuelo()
        {
            string vuelo = $"{AppDomain.CurrentDomain.BaseDirectory}/../../Datos/Vuelo.json";

            return TraerEntidades<Vuelo>(vuelo);
        }


    }
}
