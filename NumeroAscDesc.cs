using System;


namespace NumeroAscDesc
{
    class program
    {
        static void Main(string[]args)
        {
            int i;
			
            Console.WriteLine("numeros ascendentes del 0 al 100");
            for (i=0;i<=100;i++)
            {
                Console.WriteLine("Valor de i: "+i);
            }
            Console.WriteLine("Numeros decendentes del 100 al 0");
			for (i=100;i>=0;i--)
			{
				Console.WriteLine(i);
			}
			Console.ReadKey();
            
        }
    }
        

        
}