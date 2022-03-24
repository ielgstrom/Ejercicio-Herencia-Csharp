﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_Herencia
{
    class Paciente : Persona
    {
        private int edad;
        private DateTime fechaBaja;
        private DateTime fechaAlta;
        private bool estaDeAlta;
        private string nombre;
        public Paciente(int _edad, DateTime _fechaBaja, string _nombre) : base(_edad, _nombre)
        {
            nombre= _nombre;
            edad = _edad;
            fechaBaja = _fechaBaja;
            estaDeAlta = false;
        }
        public void setAlta(DateTime _fechaAlta)
        {
            fechaAlta = _fechaAlta;
            estaDeAlta = true;
        }
        public string getNombre() { return nombre; }

        public int getEdad() { return edad; }

    }
}
