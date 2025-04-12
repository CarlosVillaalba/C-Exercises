using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 
{
    class MenuDeOpciones
    {
        static void Main(string[]args)
        {
         char estado civil;
         Console.WriteLine('Elija una opcion:');
         Console.WriteLine('c=casado,s=soltero,d=divorciado,')
         estadocivil = char.Parse(Console.ReadLine());
         
         switch(estadocivil)
         {
            case 'c':
                Console.WriteLine('Casado');
                break;
            case 's':
                Console.WriteLine('Soltero')
                break;
            case 'd';
                 Console.WriteLine('Divorciado');
                 break;
            default:
                Console.WriteLine('No ha escogido una opcion valida')
                break;

         }
        Console.ReadKey();
        }
    }
}
