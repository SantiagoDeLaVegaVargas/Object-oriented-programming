using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace El_punto_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            String espacio = ("");
            while (count < 10)
            {
                Console.WriteLine(espacio + " _\n" + espacio +  "__(.)<\n" + espacio + "|___)");
                espacio = espacio + (" ");
                count = count + 1;     
            }



        }
    }
}
