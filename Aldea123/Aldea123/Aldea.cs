using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aldea123
{
    public class Aldea
    {
        private string nombre;
        private string ubicacion;
        public Habitante[] habitantes = new Habitante[100];

        public Aldea(string nombre, string ubicacion)
        {
            this.nombre = nombre;
            this.ubicacion = ubicacion;
        }

        public string getNombre()
        {
            return this.nombre;
        }

        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public string getUbicacion()
        {
            return this.ubicacion;
        }

        public void setUbicacion(string ubicacion)
        {
            this.ubicacion = ubicacion;
        }
        public void recibirHabitante(Habitante unHabitante)
        {
            int posicionVacio = 0;
            foreach (Habitante habitante in this.habitantes)
            {
                if (habitante == null) break;
                posicionVacio++;
            }
            if (posicionVacio < 100)
            {
                habitantes[posicionVacio] = unHabitante;

            }

        }
    }
}
    

