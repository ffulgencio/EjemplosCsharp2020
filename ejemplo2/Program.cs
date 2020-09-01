using System;

namespace ejemplo2
{
    class Program
    {
        static void Main(string[] args)
        {
           double socio1 = 15000;
           double socio2 = 35000;
           double socio3 = 17000;
           double total = socio1 + socio2 + socio3;
           Console.WriteLine(total);

           double porcent1 = (socio1 * 100) / total;
           double porcent2 = (socio2 * 100) / total;
           double porcent3 = (socio3 * 100) / total;

           Console.WriteLine("Socio1: {0}  Socio2:{1} Socio3:{2}",porcent1,porcent2,porcent3);     

        }
    }
}
