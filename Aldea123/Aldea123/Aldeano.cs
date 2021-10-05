using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aldea123
{
    public class Aldeano : Habitante
    {
        public Aldeano(string nombre, char genero, DateTime fechaNacimiento, DateTime fechaFin, string mestizaje, string oficio, string equipamento) : base(nombre, genero, fechaNacimiento, fechaFin, mestizaje, oficio, equipamento)
        {
        }

        public string cultivar()
        {
            return "estoy cultivando";
        }

        public string edificar()
        {
            return "estoy edificando";
        }

    }
}
