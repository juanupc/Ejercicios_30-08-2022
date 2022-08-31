using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion
{
    public class PresentacionBasicos
    {
        public void EjecutarCuadrado()
        {
            int a, r;
            Console.Clear();
            Console.WriteLine("CUADRADO DE UN NUMERO");

            Console.Write("digite A: ");
            a = int.Parse(Console.ReadLine());

            Logica.EjeciciosBasicos ejeciciosBasicos = new Logica.EjeciciosBasicos();
            r = ejeciciosBasicos.Cuadrado(a);
            Console.WriteLine("EL CUADRADO ES --> " + r.ToString());
            Console.ReadKey();
        }
        public void EjecutarSuma()
        {
            int a, b, r;
            Console.Clear();
            Console.WriteLine("SUMA DE UN NUMERO");

            Console.Write("digite A: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("digite B: ");
            b = int.Parse(Console.ReadLine());

            Logica.EjeciciosBasicos ejeciciosBasicos = new Logica.EjeciciosBasicos();
            r = ejeciciosBasicos.Suma(a,b);
            Console.WriteLine("LA SUMA ES --> " + r.ToString());
            Console.ReadKey();
        }
        public void EjecutarResta()
        {
            int a, b, r;
            Console.Clear();
            Console.WriteLine("RESTA DE UN NUMERO");

            Console.Write("digite A: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("digite B: ");
            b = int.Parse(Console.ReadLine());

            Logica.EjeciciosBasicos ejeciciosBasicos = new Logica.EjeciciosBasicos();
            r = ejeciciosBasicos.Resta(a, b);
            Console.WriteLine("LA RESTA ES --> " + r.ToString());
            Console.ReadKey();
        }
        public void EjecutarMultiplicacion()
        {
            int a, b, r;
            Console.Clear();
            Console.WriteLine("DIVISION DE UN NUMERO");

            Console.Write("digite A: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("digite B: ");
            b = int.Parse(Console.ReadLine());

            Logica.EjeciciosBasicos ejeciciosBasicos = new Logica.EjeciciosBasicos();
            r = ejeciciosBasicos.Multiplicacion(a, b);
            Console.WriteLine("LA DIVISION ES --> " + r.ToString());
            Console.ReadKey();
        }
    }
}
