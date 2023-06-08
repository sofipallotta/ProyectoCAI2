using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;
using Newtonsoft.Json;
using WinFormsPrototype.Entidades;

namespace Entidades
{
    internal class Vuelo
    {

        public string idVuelo { get; set ; }
        public string origen { get; set; }
        public string destino { get; set; }
        public DateTime fecha_Salida { get; set; }
        public DateTime fecha_Arrbo { get; set; }
        public TimeSpan Tiempo_Vuelo { get; set; }
        public string aerolinea { get; set; }
        public List<Tarifa> tarifas { get; set; }



    }
}
