using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aldea123
{
    public static class Spawner
    {
        private static string generarNombreAleatorio()
        {
            string[] nombres = { "Count Roland", "Horatius Cocles", "Prince Rupert of the Rhine", "Vercingetorix", "William Wallace", "Basil II (The Bulgar-Slayer)", "Attila the Hun", "Yue Fei", "Eric Bloodaxe", "Arminius", "Miltiades", "Vlad the Impaler", "Sun Tzu", "Spartacus", "Xiahou Dun", "Hannibal Barca", "Pyrrhus of Epirus", "Richard the Lionheart2", "Miyamoto Musashi", "Julius Caesar", "Leonidas of Sparta", "Genghis Khan", "Alexander the Great" };
            Random rd = new Random();
            int posicion = rd.Next(0, 23);
            return nombres[posicion];
        }
        private static char generarGeneroAleatorio()
        {
            char[] generos = { 'M', 'F' };
            Random rd = new Random();
            int posicion = rd.Next(0, 1);
            return generos[posicion];
        }

        private static DateTime generarFechaNacimiento()
        {
            Random rd = new Random();
            int dia = rd.Next(1, 31);
            int mes = rd.Next(1, 12);
            int año = rd.Next(DateTime.Now.Year - 20, DateTime.Now.Year - 10);
            DateTime fechaNacimiento = new DateTime(año, mes, dia);
            return fechaNacimiento;
        }

        private static DateTime generarFechaFin()
        {
            Random rd = new Random();
            int dia = rd.Next(1, 31);
            int mes = rd.Next(1, 12);
            int año = rd.Next(DateTime.Now.Year - 5 , DateTime.Now.Year);
            DateTime fechaNacimiento = new DateTime(año, mes, dia);
            return fechaNacimiento;
        }

        private static string generarMestizajeAleatorio()
        {
            string[] mestizaje = { "blanco", "negro", "medio negro" };
            Random rd = new Random();
            int posicion = rd.Next(0, 2);
            return mestizaje[posicion];
        }

        private static string generarOficioAleatorio()
        {
            string[] oficio = { "arquero", "espadachin" };
            Random rd = new Random();
            int posicion = rd.Next(0, 1);
            return oficio[posicion];
        }

        private static string generarEquipamentoAleatorio()
        {
            string[] equipamento = { "bolsa", "pan", "hoja vacia" };
            Random rd = new Random();
            int posicion = rd.Next(0, 3);
            return equipamento[posicion];
        }

        public static Habitante generarNuevoHabitante()
        {

                string nombre = generarNombreAleatorio();
                char genero = generarGeneroAleatorio();
                DateTime fechaNacimiento = generarFechaNacimiento();
                DateTime fechaFin = generarFechaFin();
                string mestizaje = generarMestizajeAleatorio();
                string oficio = generarOficioAleatorio();
                string equipamento = generarEquipamentoAleatorio();
                Habitante unHabitante = new Habitante(nombre, genero, fechaNacimiento, fechaFin, mestizaje, oficio, equipamento);
                return unHabitante;
            }
    }
}
