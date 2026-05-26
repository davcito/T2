using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class NodoP
    {
        public Empleado Valor { get; set; }
        public NodoP Izqu { get; set; }
        public NodoP Dere { get; set; }

        public NodoP(Empleado valor)
        {
            Valor = valor;
            Izqu = null;
            Dere = null;
        }
    }
}
