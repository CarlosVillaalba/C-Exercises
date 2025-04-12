using System;

namespace NumerosAscendentes
{
    class Program
    {
        static void Main(string[]args)
        {
        int opcion=0, i=0;
        Console.WriteLine("Elija una opcion"+"1.-Numeros del 0 al 100\n"+
        "2.-Numeros del 100 al 0");
        opcion = int.Parse(Console.ReadLine());
        if (opcion == 1)
        {
            while(i<=100)
            {
                Console.WriteLine(i);
                i++;
            }
        }
        else
        {
            i = 100;
            while (i>=0)
            {
                Console.WriteLine(i);
                i--;
            }
        }
        Console.ReadKey();
        }
    }
}