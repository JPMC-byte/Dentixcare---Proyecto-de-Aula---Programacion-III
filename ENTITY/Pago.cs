using System;

namespace ENTITY
{
    public class Pago
    {
        public string ID_Pago { get; set; }
        public DateTime Fecha_Pago { get; set; }
        public string Metodo_Pago { get; set; }
        public double Monto { get; set; }
        public string CodigoPaciente { get; set; } 

        public Pago() { }

        public Pago(string id_Pago, DateTime fecha_Pago, string metodo_Pago, double monto, Paciente paciente)
        {
            ID_Pago = id_Pago;
            Fecha_Pago = fecha_Pago;
            Metodo_Pago = metodo_Pago;
            Monto = monto;
            CodigoPaciente = paciente.Cedula;
        }

        public override string ToString()
        {
            return $"{ID_Pago};{Fecha_Pago:yyyy-MM-dd};{Metodo_Pago};{Monto};{CodigoPaciente}";
        }
    }
}
