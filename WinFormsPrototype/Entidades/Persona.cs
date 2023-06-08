using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
     public class Persona
    {
        private int _DNI;
        private string _nombreCompleto;

        public int DNI { get => _DNI;  set => _DNI = value;}
        public string nombreCompleto { get => _nombreCompleto; set => _nombreCompleto = value; }

    }
}
