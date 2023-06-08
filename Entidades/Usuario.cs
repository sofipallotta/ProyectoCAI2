using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario
    {
        private string _usuarios;
        private int _contraseña;


        public string usuarios { get => _usuarios; set => _usuarios = value; }
        public int constraseña { get => _contraseña; set => _contraseña = value; }


        private static List<T> TraerEntidades<T>(string rutaArchivo)
        {
            StreamReader r = new StreamReader(rutaArchivo);
            string jsonString = r.ReadToEnd();
            List<T> entidades = JsonConvert.DeserializeObject<List<T>>(jsonString);

            r.Close();

            return entidades;
        }

        public static List<Usuario> TraerUsuario()
        {
            string usuario = $"{AppDomain.CurrentDomain.BaseDirectory}/../../Datos/Usuario.json";

            return TraerEntidades<Usuario>(usuario);
        }
    }
}
