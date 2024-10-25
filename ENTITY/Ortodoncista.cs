using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidadeds
{
    public class Ortodoncista : Persona
    {
        public Ortodoncista() { }

        public Ortodoncista(Consultorio consultorio, string nombre, string apellido, string cedula, string telefono, int Edad, DateTime fecha_De_Nacimiento, string contraseña) : base(consultorio, nombre, apellido, cedula, telefono, Edad, fecha_De_Nacimiento, contraseña)
        {

        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
