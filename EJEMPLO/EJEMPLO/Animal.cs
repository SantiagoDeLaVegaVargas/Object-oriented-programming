using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJEMPLO
{
    class Animal
    {
        private string nombre;
        private string color;
        private int numeroDePatas;

        public Animal(string nombre, string color, int numeroDePatas)
        {
            this.nombre = nombre;
            this.color = color;
            this.numeroDePatas = numeroDePatas;
        }

        public string Nombre
        {
            get => nombre;
            set => nombre = value;
        }
        public string Color
        {
            get => color;
            set => color = value; 
        }
        public int NumeroDePatas
        {
            get => numeroDePatas;
            set => numeroDePatas = value; 
        }
    }
}
