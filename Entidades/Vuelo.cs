using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Vuelo
    {
        private int _idVuelo;
        private string _nombreProducto;
        private string _descripcion;
        private int _precio;

        public int idVuelo { get => _idVuelo; set => _idVuelo = value; }
        public string nombreProducto { get => _nombreProducto; set => _nombreProducto = value; }
        public string descripcion { get => _descripcion; set => _descripcion = value; }
        public int precio { get => _precio; set => _precio = value; }
    }
}
