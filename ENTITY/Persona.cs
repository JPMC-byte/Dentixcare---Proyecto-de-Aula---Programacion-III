using System;

namespace ENTITY
{
    public abstract class Persona
    {
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string Cedula { get; set; }
        public string CodigoConsultorio { get; set; }
        public string Telefono { get; set; }
        public DateTime Fecha_De_Nacimiento { get; set; }
        public string Contrasena { get; set; }

        public Persona()
        {
        }

        public Persona(Consultorio consultorio, string primerNombre, string segundoNombre, string primerApellido, string segundoApellido, string cedula, string telefono, DateTime fecha_De_Nacimiento, string contrasena)
        {
            CodigoConsultorio = consultorio.Codigo;
            PrimerNombre = primerNombre;
            SegundoNombre = segundoNombre;
            PrimerApellido = primerApellido;
            SegundoApellido = segundoApellido;
            Cedula = cedula;
            Telefono = telefono;
            Fecha_De_Nacimiento = fecha_De_Nacimiento;
            Contrasena = contrasena;
        }

        public int CalcularEdad(DateTime Fecha_Nacimiento)
        {
            DateTime Hoy = DateTime.Today;
            int edad = Hoy.Year - Fecha_Nacimiento.Year;
            if (Fecha_Nacimiento.Date > Hoy.AddYears(-edad)) edad--;
            return edad;
        }

        public override string ToString()
        {
            return $"{CodigoConsultorio};{PrimerNombre};{SegundoNombre};{PrimerApellido};{SegundoApellido};{Cedula};{Telefono};{Fecha_De_Nacimiento:dd/MM/yyyy};{Contrasena}";
        }
    }
}
