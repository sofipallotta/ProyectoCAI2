using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsPrototype.Entidades;

namespace Entidades
{
    public class Alojamiento
    {

        public int idProductos { get ; set ; }
        public string nombreProducto { get ; set ; }
        public string codigoCiudad  { get ; set ; }
        public string direccion { get; set; }
        public char calificacion { get; set; }
        public List<HabitacionDisponibilidad> alojamientodispobiles { get; set; }


    }
}
