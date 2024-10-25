using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Paciente : Persona
    {
        public Paciente() { }

        public Paciente(Consultorio consultorio, string nombre, string apellido, string cedula, string telefono, int Edad, DateTime fecha_De_Nacimiento, string Contraseña) : base(consultorio, nombre, apellido, cedula, telefono, Edad,fecha_De_Nacimiento, Contraseña)
        {
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
