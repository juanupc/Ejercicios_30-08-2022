using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion
{
    public class MenuPrincipal
    {
        public MenuPrincipal()
        {

        }
        public  void VerPrincipal(int l, int t)
        {
            int op;
            do
            {
                Console.Clear();
                Console.SetCursorPosition(l, t - 2); Console.WriteLine("M E N U   P R I N C I P A L");
                Console.SetCursorPosition(l, t + 2); Console.WriteLine("1. BASICOS");
                Console.SetCursorPosition(l, t + 4); Console.WriteLine("2. INTERMEDIOS");
                Console.SetCursorPosition(l, t + 6); Console.WriteLine("3. AVANZADOS");
                Console.SetCursorPosition(l, t + 8); Console.WriteLine("4. salir");
                Console.SetCursorPosition(l, t + 10); Console.WriteLine("digite opcion ...");

                Console.SetCursorPosition(l + 20, t + 10);
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        MenuBasicos(15, 5);
                        break;
                    case 4:
                        Console.Clear();
                        Console.SetCursorPosition(l, t - 2); Console.WriteLine("GRACIAS POR USAR PRODUCTOS JOHNP...");
                        Console.ReadKey();
                        break;
                }

            } while (op != 4);
        }
        public  void MenuBasicos(int l, int t)
        {
            int op;
            do
            {
                Console.Clear();
                Console.SetCursorPosition(l, t - 2); Console.WriteLine("M E N U   B A S I C O S");
                Console.SetCursorPosition(l, t + 2); Console.WriteLine("1. Cuadrado de numeros");
                Console.SetCursorPosition(l, t + 4); Console.WriteLine("2. Suma");
                Console.SetCursorPosition(l, t + 6); Console.WriteLine("3. Resta");
                Console.SetCursorPosition(l, t + 8); Console.WriteLine("4. Division");
                Console.SetCursorPosition(l, t + 10); Console.WriteLine("5. Volver");
                Console.SetCursorPosition(l, t + 12); Console.WriteLine("digite opcion ...");

                Console.SetCursorPosition(l + 20, t + 12); op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        new PresentacionBasicos().EjecutarCuadrado();            
                        break;
                    case 2:
                        new PresentacionBasicos().EjecutarSuma();
                        break;
                    case 3:
                        new PresentacionBasicos().EjecutarResta();
                        break;
                    case 4:
                        new PresentacionBasicos().EjecutarMultiplicacion();
                        break;
                    default:
                        break;
                }
            } while (op != 5);
        }
    }
}
