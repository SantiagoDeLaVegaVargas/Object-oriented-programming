using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJEMPLO
{
    class Perro:Animal
    {
        private string NombreDePerro;

        public Perro(string nombre, string color, int numeroDePatas) : base(nombre, color, numeroDePatas)
        {
            this.NombreDePerro = NombreDePerro;
        }
    }
}
