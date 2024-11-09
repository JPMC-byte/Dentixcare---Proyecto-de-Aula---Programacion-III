using System;

namespace ENTITY
{
    public class Pago
    {
        public string ID_Pago { get; set; }
        public DateTime Fecha_Pago { get; set; }
        public string Metodo_Pago { get; set; }
        public double Monto { get; set; }
        public string CodigoFactura { get; set; }
        public string CodigoPaciente { get; set; } 

        public Pago() { }

        public Pago(string id_Pago, DateTime fecha_Pago, string metodo_Pago, double monto, Factura factura ,Paciente paciente)
        {
            ID_Pago = id_Pago;
            Fecha_Pago = fecha_Pago;
            Metodo_Pago = metodo_Pago;
            Monto = monto;
            CodigoFactura = factura.ID_Factura;
            CodigoPaciente = paciente.Cedula;
        }

        public override string ToString()
        {
            return $"{ID_Pago};{Fecha_Pago:dd/MM/yyyy};{Metodo_Pago};{Monto};{CodigoFactura};{CodigoPaciente}";
        }
    }
}
