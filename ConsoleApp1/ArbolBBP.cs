using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ArbolBBP
    {
        public NodoP Primero { get; set; }

        public ArbolBBP()
        {
            Primero = null;
        }


        public void Agrega(Empleado e)
        {
            Primero = AgregaRec(Primero, e);
        }

        private NodoP AgregaRec(NodoP actual, Empleado e)
        {
            if (actual == null)
                return new NodoP(e);
            if (e.Codigo < actual.Valor.Codigo)
                actual.Izqu = AgregaRec(actual.Izqu, e);
            else
                actual.Dere = AgregaRec(actual.Dere, e);
            return actual;
        }

        public void MuestraInCodigo()
        {
            MuestraInRec(Primero);
        }

        private void MuestraInRec(NodoP actual)
        {
            if (actual == null) return;
            MuestraInRec(actual.Izqu);
            Console.WriteLine(actual.Valor);
            MuestraInRec(actual.Dere);
        }

        public void MuestraPosAntiguedad()
        {
            MuestraPosRec(Primero);
        }

        private void MuestraPosRec(NodoP actual)
        {
            if (actual == null) return;
            MuestraPosRec(actual.Izqu);
            MuestraPosRec(actual.Dere);
            Console.WriteLine($"{actual.Valor.Nombre}: {actual.Valor.Antiguedad} años");
        }

        public int MayoresA(int antiguedad)
        {
            return MayoresARec(Primero, antiguedad);
        }

        private int MayoresARec(NodoP actual, int antiguedad)
        {
            if (actual == null) return 0;
            int cuenta = actual.Valor.Antiguedad > antiguedad ? 1 : 0;
            cuenta += MayoresARec(actual.Izqu, antiguedad);
            cuenta += MayoresARec(actual.Dere, antiguedad);
            return cuenta;
        }

        public string Penultimo()
        {
            List<Empleado> lista = new List<Empleado>();
            EnListaRec(Primero, lista);
            if (lista.Count < 2)
                return "No hay penultimo";
            return lista[lista.Count - 2].ToString()!;
        }

        private void EnListaRec(NodoP actual, List<Empleado> lista)
        {
            if (actual == null) return;
            EnListaRec(actual.Izqu, lista);
            lista.Add(actual.Valor);
            EnListaRec(actual.Dere, lista);
        }
    }
}
