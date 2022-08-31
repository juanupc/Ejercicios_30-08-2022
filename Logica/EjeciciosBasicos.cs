using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class EjeciciosBasicos
    {
        public int Cuadrado(int a)
        {
            int r = 0;
            r = a * a;
            string ejercicio = String.Format("{0} --> f(cuadrado) --> in1: {1} -- OUT :{2}", DateTime.Now.ToString(), a, r);
            new Datos.Archivos().Guardar(ejercicio);
            return r;
        }
        public int Suma(int a,int b)
        {
            int r = 0;
            r = a + b;
            string ejercicio = String.Format("{0} --> f(suma) --> in1: {1} -- OUT :{2}", DateTime.Now.ToString(), a, b, r);
            new Datos.Archivos().Guardar(ejercicio);
            return r;
        }
        public int Resta(int a, int b)
        {
            int r = 0;
            r = a - b;
            string ejercicio = String.Format("{0} --> f(resta) --> in1: {1} -- OUT :{2}", DateTime.Now.ToString(), a, b, r);
            new Datos.Archivos().Guardar(ejercicio);
            return r;
        }
        public int Multiplicacion(int a, int b)
        {
            int r = 0;
            r = a * b;
            string ejercicio = String.Format("{0} --> f(multiplicacion) --> in1: {1} -- OUT :{2}", DateTime.Now.ToString(), a, b, r);
            new Datos.Archivos().Guardar(ejercicio);
            return r;
        }
    }
}
