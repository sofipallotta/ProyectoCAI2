using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pasajeros
    {
        private int _DNI;
        private string _nombreCompleto;
        private DateTime _fechaNacimiento;

        public int DNI { get => _DNI; set => _DNI = value; }
        public string nombreCompleto { get => _nombreCompleto; set => _nombreCompleto = value; }
        public DateTime fechaNacimiento { get => _fechaNacimiento; }

    }
}
