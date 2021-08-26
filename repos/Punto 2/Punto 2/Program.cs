using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_2
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Ingrese el valor del radio de la figura");
            String R = Console.ReadLine();
            int r = Int32.Parse(R);
            Console.WriteLine("Ingrese el valor de la hipotenusa");
            String H = Console.ReadLine();
            int h = Int32.Parse(H);
            int cateto = r * 2;
            double A1 = (Math.PI * (r*r)) / 2;
            double A2 = Math.Sqrt((cateto * cateto) - (h * h));
            double AT = A1 + A2;
            Console.WriteLine("El area total de la figura es:");
            Console.WriteLine(AT);
            String stop = Console.ReadLine();
        }
    }
}
