using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operaciones
{
    class Program
    {
        static void Main(string[]args)
        {
            int num1, num2, resultado;
            Console.WriteLine('Ingresa el numero 1');
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine('Ingresa el numero 2');
            num2 = int.Parse(Console.ReadLine());
            resultado = num1 + num2;
            Console.WriteLine('La suma es : {0}', resultado);
            resultado = num1 - num2;
            Console.WriteLine('La resta es {0}', resultado);
            resultado = num1 * num2;
            Console.WriteLine('La multiplicacion es {0}, resultado', resultado);
            if(num2 != 0)
            {
                resultado = num1 / num2;
                Console.WriteLine('La divicion es {0}', resultado);
            }
            else
            {
                Console.WriteLine('No es posible dividir por 0');
            }
            Console.ReadKey();
        }
    }
}
