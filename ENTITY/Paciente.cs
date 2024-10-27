﻿using System;

namespace ENTITY
{
    public class Paciente : Persona
    {
        public Paciente() { }

        public Paciente(Consultorio consultorio, string primerNombre, string segundoNombre, string primerApellido, string segundoApellido, string cedula, string telefono, int edad, DateTime fecha_De_Nacimiento, string contrasena)
            : base(consultorio, primerNombre, segundoNombre, primerApellido, segundoApellido, cedula, telefono, edad, fecha_De_Nacimiento, contrasena)
        {
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
