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
        private List<Paciente> pacientesDeMedico;
        private List<Medico> MedicosDeHospital = new List<Medico>();

        public Medico(int _edad, string _especialidad, string _nombre) :base(_edad, _nombre)
        {
            edad = _edad;
            especialidad = _especialidad;
            nombre = _nombre;
            Console.WriteLine("1");
            this.MedicosDeHospital.Add(new Medico(_edad, _especialidad, _nombre));
            Console.WriteLine("2");

        }
        public List<Paciente> pacientesAsignados()
        {
            return pacientesDeMedico;
        }
        public void darAltaPaciente(Paciente pacienteParaAlta, DateTime fechaDeAlta)
        {
            pacienteParaAlta.setAlta(fechaDeAlta);
            pacientesDeMedico.Remove(pacienteParaAlta);
        }
        //static List<Medico> GetMedicos()
        //{
        //    return MedicosDeHospital;
        //}
        public void asignarPacienteAMedico(Paciente pacienteQueSeVaAAsignar)
        {
            pacientesDeMedico.Add(pacienteQueSeVaAAsignar);
            
        }
        public void ListarAMedicos()
        {
            for (int i=0; i<MedicosDeHospital.Count; i++)
            {
                Console.WriteLine($"El medico numero {i + 1} es {MedicosDeHospital[i].nombre} de la rama de {MedicosDeHospital[i].especialidad}");
            }
        }

    }
}
