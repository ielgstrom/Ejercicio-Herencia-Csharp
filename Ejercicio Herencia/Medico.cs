using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_Herencia
{
    class Medico : Persona
    {
        private int edad;
        private string especialidad;
        private string nombre;
        private List<Paciente> pacientesDeMedico = new List<Paciente>();

        public Medico(int _edad, string _especialidad, string _nombre) :base(_edad, _nombre)
        {
            edad = _edad;
            especialidad = _especialidad;
            nombre = _nombre;

        }
        public List<Paciente> pacientesAsignados()
        {
            return pacientesDeMedico;
        }

        public void asignarleElPaciente(Paciente pacienteQueSeVaAAsignar)
        {
            pacientesDeMedico.Add(pacienteQueSeVaAAsignar);
            
        }
        public void eliminarElPaciente(Paciente pacienteQueVasAEliminar)
        {
            pacientesDeMedico.Remove(pacienteQueVasAEliminar);
        }
        //public void quitarPaciente
        public string getNombre() { return nombre; }
        public string getEspecialidad() { return especialidad; }
        public int getEdad() { return edad; }
        public override string ToString()
        {
            return "Has utilizado el medoto ToString en la clase Medico";
        }

    }
}
