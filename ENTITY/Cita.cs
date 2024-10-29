using ENTITY;
using System;

public class Cita
{
    public string Codigo { get; set; }
    public string CodigoConsultorio { get; set; }
    public string CodigoOrtodoncista { get; set; }
    public string CodigoPaciente { get; set; }
    public DateTime Fecha_Cita { get; set; }
    public DateTime Fecha_Creacion { get; set; }
    public TimeSpan Hora_Cita { get; set; }
    public string Razon_Cita { get; set; }
    public string Estado { get; set; }

    public Cita() { }

    public Cita(string codigo, Consultorio consultorio, Paciente paciente, DateTime fecha_creacion, DateTime fecha_Cita, TimeSpan hora_Cita, string razon_Cita, string estado)
    {
        Codigo = codigo;
        CodigoOrtodoncista = null;
        CodigoConsultorio = consultorio.Codigo;
        CodigoPaciente = paciente.Cedula;
        Fecha_Creacion = fecha_creacion;
        Fecha_Cita = fecha_Cita;
        Hora_Cita = hora_Cita;
        Razon_Cita = razon_Cita;
        Estado = estado;
    }

    public void AsignarOrtodoncista(string codigoOrtodoncista)
    {
        CodigoOrtodoncista = codigoOrtodoncista;
    }

    public override string ToString()
    {
        return $"{Codigo};{CodigoConsultorio};{CodigoOrtodoncista};{CodigoPaciente};{Fecha_Cita:dd/MM/yyyy};{Fecha_Creacion:dd/MM/yyyy};{Hora_Cita};{Razon_Cita};{Estado}";
    }
}
