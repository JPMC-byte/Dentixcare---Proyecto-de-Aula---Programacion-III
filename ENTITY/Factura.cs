using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Factura
    {
        public string ID_Factura {  get; set; }
        public DateTime Fecha_Emision { get; set; }
        public string Estado {  get; set; }
        public double Total {  get; set; }

        public Factura() { }

        public Factura(string iD_Factura, DateTime fecha_Emision, string estado, double total)
        {
            ID_Factura = iD_Factura;
            Fecha_Emision = fecha_Emision;
            Estado = estado;
            Total = total;
        }

        public override string ToString()
        {
            return $"{ID_Factura};{Fecha_Emision:dd/MM/yyyy};{Estado};{Total}";
        }

    }
}
