using System;
using System.Collections.Generic;
namespace Ejercicio_Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Buenas! Bienvenido al hospital de Sant Pau. Que quieres hacer?");
            //opciones();
            Medico Carlos = new Medico(23, "hematologia", "Carlos");
            Console.WriteLine("Hello");
            Medico Mireia = new Medico(28, "cariologia", "Mireia");
            Mireia.ListarAMedicos();
        }
        static void opciones()
        {
            Console.WriteLine("1) Listar");
            Console.WriteLine("1) Asignar");
            var keyStroke = Console.ReadKey();
            switch (keyStroke.Key)
            {
                case ConsoleKey.D1:
                    Console.WriteLine("\nOpcion1");
                    break;
                case ConsoleKey.D2:
                    Console.WriteLine("\nOpcion2");
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Opcion no valida, vuelve a escoger");
                    opciones();
                    break;
            }
        }
    }
    class Persona 
    {
        int edad;
        string nombre;
        public List<Persona> listaPersonas = new List<Persona>();
        

        public Persona(int _edad, string _nombre)
        {
            edad = _edad;
            nombre = _nombre;

        }
        public void darAltaAMedico(Medico medico)
        {

        }
        public void ListarPersonas()
        {

        }
    }
   
}
