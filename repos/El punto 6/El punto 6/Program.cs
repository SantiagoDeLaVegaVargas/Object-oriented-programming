using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace El_punto_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            while (count < 10)
            {
                Console.WriteLine(" _" + "\n__(.)<" + "\n|___)");
                String nombre;
                nombre = Console.ReadLine();
                String nombrenuevo1 = nombre.Replace("a", "4").Replace("e", "3");
                String nombrenuevo2 = nombrenuevo1.Replace("i", "1").Replace("o", "0");
                String nombrenuevof = nombrenuevo2.Replace("u", ")");
                Console.WriteLine("Su nombre con caracteres especiales es: " + nombrenuevof);

            }    
        }
    }
}
