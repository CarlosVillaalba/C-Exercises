using System;
namespace  CalculadorDeDescuento
{
    class Program
    {
        void static Main(string[]args)
        {
            int cantPiezas =0;
            double totalPago =0;
            
            Console.WriteLine("Cuantas Piezas comprara el clientes");
            cantPiezas = int.Parse(Console.ReadLine());
            if(cantPiezas>50 && cantPiezas =<100){
                totalPago = cantPiezas*4;

            }else if(cantPiezas>100){
                totalPago=cantPiezas*4;
            }else{
                totalPago=cantPiezas*5;
            }
            Console.WriteLine("El total a pagar es",totalPago);
        }Console.ReadKey();
    }
}