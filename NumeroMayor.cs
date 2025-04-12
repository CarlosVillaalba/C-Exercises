using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeroMayor
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.WriteLine('Ingrese el numero 1');
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine('Ingrese el numero 2');
            num2 = int.Parse(Console.ReadLine());
            
            if(num1 > num2)
            {
                Console.WriteLine('{0} es mayor q {1}', num1, num2);
            }
            else
            {
                if (num1 == num2)
                {
                    Console.WriteLine('{0} es igual que {1}', num1, num2);
                }
                else
                {
                    Console.WriteLine('{O} es menor que {1}',num1,num2);
                }
            }
            Console.ReadKey();
        }
    }
}
