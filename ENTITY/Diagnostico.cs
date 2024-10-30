using System;

namespace ENTITY
{
    public class Diagnostico
    {
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fecha_Diagnostico { get; set; }
        public string CodigoCita { get; set; }

        public string CedulaPaciente { get; set; }

        public Diagnostico() { }

        public Diagnostico(string codigo, string descripcion, DateTime fecha_Diagnostico, Cita cita, Paciente paciente)
        {
            Codigo = codigo;
            Descripcion = descripcion;
            Fecha_Diagnostico = fecha_Diagnostico;
            CodigoCita = cita.Codigo;
            CedulaPaciente = paciente.Cedula;
        }
        public override string ToString()
        {
            return $"{Codigo};{Descripcion};{Fecha_Diagnostico};{CodigoCita}";
        }

    }
}
