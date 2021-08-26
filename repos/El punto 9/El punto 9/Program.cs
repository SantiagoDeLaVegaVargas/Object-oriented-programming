using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace El_punto_9
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 1;
            int count = 0;
            
            
            while (count < 10)
            {   
                int b = 1;
                int count2 = 0;
                String num = a.ToString();
                Console.WriteLine("\nTabla del " + num + ":");
                while (count2 < 10)
                {
                    int c = a * b;
                    Console.WriteLine(a + "x" + b + "=" + c);
                    b = b + 1;
                    count2 = count2 + 1;
                }
                a = a + 1;
                count = count + 1;
            }
            

        }
    }
}