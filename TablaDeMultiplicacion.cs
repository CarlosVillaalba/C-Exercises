using System;

namespace TablaDeMuliplicar
{
    class Program
    {
        static void Main(string[]args)
        {
            int num=0, i=1, resultado=0;

            Console.WriteLine("Cual tabla de multiplicar quieres");
            num=int.Parse(Console.ReadLine());
            
            while(i<=30)
            {
                resultado = num*i;
                Console.WriteLine("{0}*{1}={2}",num, i, resultado);
                i++;
            }
            Console.ReadKey();
        }
    }

    
}