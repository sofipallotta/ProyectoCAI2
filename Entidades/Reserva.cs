using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Reserva
    {
        private int _nroSolicitud;
        private int _DNI;
        private int _idEstado;
        private string _descripcion;

        public int nroSolicitud { get => _nroSolicitud; set => _nroSolicitud = value; }
        public int DNI { get => _DNI; set => _DNI = value; }
        public int idEstado { get => _idEstado; set => _idEstado = value; }
        public string descripcion { get => _descripcion; set => _descripcion = value; }


    }
}
