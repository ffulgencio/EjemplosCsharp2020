using System;

namespace ejemplo3
{
    class Program
    {
        static void Main(string[] args)
        {
            // condicional
            int opcion = 1; // usd-pesos 2 - pesos a dolares
            double monto = 1000;
            double tasa = 58.50;

            if(opcion == 1) // if ... else ... 
            {
                Console.WriteLine("en pesos son:" + (monto * tasa));
            }
            else
            {
                Console.WriteLine("en dolares son:" + (monto / tasa));

            }



        }
    }
}
