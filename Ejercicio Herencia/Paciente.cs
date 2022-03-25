using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_Herencia
{
    class Paciente : Persona
    {
        private int edad;
        private DateTime fechaBaja;
        private string nombre;
        public Paciente(int _edad, DateTime _fechaBaja, string _nombre) : base(_edad, _nombre)
        {
            nombre= _nombre;
            edad = _edad;
            fechaBaja = _fechaBaja;
            
        }
        public string getNombre() { return nombre; }

        public int getEdad() { return edad; }
        public override string ToString()
        {
            return "Has utilizado el medoto ToString en la clase Paciente";
        }

    }
}
