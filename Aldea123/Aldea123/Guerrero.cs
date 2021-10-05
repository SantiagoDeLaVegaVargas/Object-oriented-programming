using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aldea123
{
    public class Guerrero : Habitante
    {
        private string nombreGuerrero;

        public Guerrero(string nombreGuerrero, string nombre, char genero, DateTime fechaNacimiento, DateTime fechaFin, string mestizaje, string oficio, string equipamento) : base(nombre, genero, fechaNacimiento, fechaFin, mestizaje, oficio, equipamento)
        {
            this.nombreGuerrero = nombreGuerrero;
        }

        public string pelear()
        {
            return "estoy peleando ";
        }

        public string defender()
        {
            return "estoy defendiendo";
        }


    }
}

