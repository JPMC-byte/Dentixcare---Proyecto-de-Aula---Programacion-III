using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public abstract class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Cedula { get; set; }
        public string CodigoConsultorio { get; set; }
        public string Telefono { get; set; }
        public int Edad { get; set; }
        public DateTime Fecha_De_Nacimiento { get; set; }
        public string Contrasena { get; set; }

        public Persona()
        {

        }

        public Persona(Consultorio consultorio, string nombre, string apellido, string cedula, string telefono,int edad, DateTime fecha_De_Nacimiento, string contraseña)
        {
            CodigoConsultorio = consultorio.Codigo;
            Nombre = nombre;
            Apellido = apellido;
            Cedula = cedula;
            Telefono = telefono;
            Edad = edad;
            Fecha_De_Nacimiento = fecha_De_Nacimiento;
            Contrasena = contraseña;
        }
        public int CalcularEdad(DateTime Fecha_Nacimiento)
        {
            DateTime Hoy = DateTime.Today;
            Edad = Hoy.Year - Fecha_Nacimiento.Year;
            if (Fecha_Nacimiento.Date > Hoy.AddYears(-Edad)) Edad--;
            return Edad;
        }
        public override string ToString()
        {
            return $"{CodigoConsultorio};{Nombre};{Apellido};{Cedula};{Telefono};{Fecha_De_Nacimiento:dd/MM/yyyy};{Edad};{Contrasena}";
        }
    }
}
