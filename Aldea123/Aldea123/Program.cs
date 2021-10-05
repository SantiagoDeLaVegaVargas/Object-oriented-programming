using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Aldea123
{
    class Program
    {
        static void Main(string[] args)
        {
            ///instanciar
            Aldea unaAldea = new Aldea("cucoria", "brazil");

            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(3);
                Habitante unHabitante = Spawner.generarNuevoHabitante();
                unaAldea.recibirHabitante(unHabitante);
            }

            /*Imprimir la informacion de los diferentes habitantes*/
            foreach (Habitante unHabitante in unaAldea.habitantes)
            {
                Console.WriteLine(unHabitante.Nombre);
                /*el objeto es un habitante  no podemos acceder a
                 funcionalidades especificas de acuerd a su tipo guerrero o aldeano 
                 para esto debemos conocer de que tipo de objeto se trata  
                 para realizar un cast y acceder a sus metodos y atributos caracteristicos*/
                if (unHabitante.GetType().Name.Equals("Guerrero"))
                {
                    Console.WriteLine("Soy un Guerrero");

                    var guerrero = (Guerrero)unHabitante;
                    Console.WriteLine(guerrero.pelear());
                    Console.WriteLine(guerrero.defender());
                }
                



            }

            string b = Console.ReadLine(); 





        }
    }
}
