using System;
using System.Collections.Generic;
namespace Ejercicio_Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Medico> listaMedicos = new List<Medico>();
            List<Paciente> listaPacientes = new List<Paciente>();
            Console.WriteLine("Buenas! Bienvenido al hospital de Sant Pau. Que quieres hacer?");
            opciones(listaMedicos, listaPacientes);
        }
        static void opciones(List<Medico> listaNurses, List<Paciente> listaPatients)
        {
            Console.WriteLine(" Opcion 1) Dar de alta un medico");
            Console.WriteLine(" Opcion 2) Dar de alta un paciente (solo si hay medicos)");
            Console.WriteLine(" Opcion 3) listar todo el personal");
            Console.WriteLine(" Opcion 4) listar los medicos");
            Console.WriteLine(" Opcion 5) listar los pacientes de un medico");
            Console.WriteLine(" Opcion 6) Eliminar un paciente");
            Console.WriteLine(" Opcion 7) Salir");
            var keyStroke = Console.ReadKey();
            Console.Clear();
            switch (keyStroke.Key)
            {
                case ConsoleKey.D1:
                    listaNurses.Add(crearMedico());
                    break;
                case ConsoleKey.D2:
                    listaPatients.Add(crearPaciente(listaNurses, listaPatients));
                    Console.WriteLine("Paciente Creado!");
                    break;
                case ConsoleKey.D3:
                    listarTodoasPersonas(listaNurses, listaPatients);
                    break;
                case ConsoleKey.D4:
                    listarMedicos(listaNurses);
                    break;
                case ConsoleKey.D5:
                    listarPacientesDeMedico(listaNurses);
                    break;
                case ConsoleKey.D6:
                    eliminarPaciente(listaPatients, listaNurses);
                    break;
                case ConsoleKey.D7:
                    return;
                default:
                    Console.Clear();
                    Console.WriteLine("Opcion no valida, vuelve a escoger");
                    opciones(listaNurses, listaPatients);
                    return;
            }
            
            Console.WriteLine("\nQue quieres hacer ahora?");
            opciones(listaNurses, listaPatients);
            
        }
        static Medico crearMedico()
        {
            Console.WriteLine("Escribe el nombre del medico que quieras crear");
            string nombre = Console.ReadLine();
            Console.WriteLine("Escribe la edad del medico que quieras crear");
            int edad = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Escribe la especialidad del medico que quieras crear");
            string especialidad = Console.ReadLine();
            return new Medico(edad, especialidad, nombre);
        }

        static Paciente crearPaciente(List<Medico>listamedicos, List<Paciente> listapaciente)
        {
            if (listamedicos.Count == 0) return new Paciente(0, DateTime.Now, "NULL");
            Console.WriteLine("Escribe el nombre del Paciente a crear");
            string nombre = Console.ReadLine();
            Console.WriteLine("Escribe la edad del Paciente a crear");
            int edad = Int32.Parse(Console.ReadLine());
            Console.WriteLine("A que medico lo quieres asignar?");
            Paciente nuevoPaciente = new Paciente(edad, DateTime.Now, nombre);
            for (int y=0; y < listamedicos.Count; y++)
            {
                Console.WriteLine($"{y + 1} - {listamedicos[y].getNombre()} de {listamedicos[y].getEspecialidad()}");
            }
            ConsoleKeyInfo keyPressed = Console.ReadKey();
            try 
            { 
                listamedicos[int.Parse(keyPressed.KeyChar.ToString())-1].asignarleElPaciente(nuevoPaciente);

            } 
            catch { Console.WriteLine("No se ha añadido correctamente"); }
            return nuevoPaciente;
        }

        static void listarMedicos(List<Medico> listaMeddicos)
        {
            for(int i=0; i< listaMeddicos.Count; i++)
            {
                Console.WriteLine($" El medico numero {i + 1} es {listaMeddicos[i].getNombre()} de la rama de {listaMeddicos[i].getEspecialidad()} con {listaMeddicos[i].getEdad()} años");
            }
        }
        static void listarPacientesDeMedico(List<Medico> listamedicos)
        {
            Console.WriteLine(" De que medico quieres mirar los pacientes?");
            for (int y = 0; y < listamedicos.Count; y++)
            {
                Console.WriteLine($"{y + 1} - {listamedicos[y].getNombre()} de {listamedicos[y].getEspecialidad()}");
            }
            ConsoleKeyInfo keyPressed = Console.ReadKey();
            try 
            {

                int numeroMedicoAMirar = int.Parse(keyPressed.KeyChar.ToString()) - 1;
                Console.WriteLine($" Los Pacientes de {listamedicos[numeroMedicoAMirar].getNombre()} son:");
                for (int e = 0; e < listamedicos[numeroMedicoAMirar].pacientesAsignados().Count;e++)
                {
                    Console.Write($"\n {e+1} - {listamedicos[numeroMedicoAMirar].pacientesAsignados()[e].getNombre()} con {listamedicos[numeroMedicoAMirar].pacientesAsignados()[e].getEdad()} años");
                }
            }
            catch { Console.WriteLine(" No se ha añadido correctamente"); }
        }
        static void eliminarPaciente(List<Paciente> listaPacientes, List<Medico> listamedicos)
        {if (listaPacientes.Count != 0)
            {
                Console.WriteLine("Selecciona el paciente que quieras eliminar");
                for (int w = 0; w < listaPacientes.Count; w++)
                {
                    Console.WriteLine($"{w + 1} - {listaPacientes[w].getNombre()} de {listaPacientes[w].getEdad()} años");
                }
                ConsoleKeyInfo keyPressed = Console.ReadKey();
                for (int r=0; r<listamedicos.Count; r++)
                {
                    listamedicos[r].eliminarElPaciente(listaPacientes[int.Parse(keyPressed.KeyChar.ToString()) - 1]);
                }
                listaPacientes.RemoveAt(int.Parse(keyPressed.KeyChar.ToString()) - 1);

                Console.WriteLine(" Paciente Eliminado!");
            }
        else if (listaPacientes.Count == 0)
            {
                Console.WriteLine("No existe ningún paciente");
            }
        }

        static void listarTodoasPersonas(List<Medico> listaMeddicos, List<Paciente> listapaciente)
        {
            Console.WriteLine("La lista de doctores es: ");
            for (int i = 0; i < listaMeddicos.Count; i++)
            {
                Console.WriteLine($"{listaMeddicos[i].getNombre()} de la rama de {listaMeddicos[i].getEspecialidad()} con {listaMeddicos[i].getEdad()} años");
            }
            Console.WriteLine("\n y la lista de pacientes es: ");
            for (int h = 0; h < listaMeddicos.Count; h++)
            {
                Console.WriteLine($"{listapaciente[h].getNombre()} con {listapaciente[h].getEdad()} años");
            }
        }
    }
    class Persona 
    {
        int edad;
        private string nombre;
        public List<Persona> listaPersonas = new List<Persona>();
        

        public Persona(int _edad, string _nombre)
        {
            edad = _edad;
            nombre = _nombre;

        }
        public override string ToString()
        {
            return "Has utilizado el medoto ToString en la clase Persona";
        }
    }
   
}
