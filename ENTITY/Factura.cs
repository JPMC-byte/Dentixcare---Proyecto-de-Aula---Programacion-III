using System;

namespace ENTITY
{
    public class Factura
    {
        public string ID_Factura { get; set; }
        public DateTime Fecha_Emision { get; set; }
        public string Estado { get; set; }
        public double Total { get; set; }
        public double Total_Pagado { get; set; }  
        public double Cambio { get; set; }        

        public Factura() { }

        public Factura(string iD_Factura, DateTime fecha_Emision, string estado, double total, double total_Pagado, double cambio)
        {
            ID_Factura = iD_Factura;
            Fecha_Emision = fecha_Emision;
            Estado = estado;
            Total = total;
            Total_Pagado = total_Pagado;
            Cambio = cambio;
        }

        public override string ToString()
        {
            return $"{ID_Factura};{Fecha_Emision:dd/MM/yyyy};{Estado};{Total};{Total_Pagado};{Cambio}";
        }
    }
}
