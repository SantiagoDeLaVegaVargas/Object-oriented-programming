using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_5
{
    class Program
    {
        static void Main(string[] args)
        {
            
                Console.WriteLine("Escoja un dia del 1 al 5 ");
                String dia;
                dia = Console.ReadLine();
                int day = Int32.Parse(dia);
          

                if (day == 1)
                {
                    Console.WriteLine("Hoy toca frutica :)");
                }
                if (day == 2)
                {
                    Console.WriteLine("Toco calentado");t
                }
                if (day == 3)
                {
                    Console.WriteLine("avena... solo avena :(");
                }
                if (day == 4)
                {
                    Console.WriteLine("caldo de costilla :D");
                }
                else
                {
                    Console.WriteLine("huevos .-.");
                }
            int testInt = 1;

            for(int i = 0; i < 10; i++)
            {
                testInt += i;
            }
        }
    }
}
