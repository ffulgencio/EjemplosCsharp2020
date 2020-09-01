using System;
class Program
{
   public static void Main()
   {
      //variable
      double usd = 125;
      double tasa = 58.50;
      double peso = 1000000;

      Console.WriteLine( usd * tasa );
      Console.WriteLine("50 dolares son:" + (usd * tasa));

      Console.WriteLine("en pesos son:" + (peso / tasa));

   }
}
