using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Tratamiento
    {
        public string ID_Tratamiento {  get; set; }
        public string Descripcion { get; set; }
        public string Duracion { get; set; }
        public double Costo { get; set; }
        public string CodigoDiagnostico {  get; set; }
        public string CodigoFactura {  get; set; }

        public Tratamiento() { }
        public Tratamiento(string iD_Tratamiento, string descripcion, string duracion, double costo, Diagnostico diagnostico, Factura factura)
        {
            ID_Tratamiento = iD_Tratamiento;
            Descripcion = descripcion;
            Duracion = duracion;
            Costo = costo;
            CodigoDiagnostico = diagnostico.Codigo;
            CodigoFactura = factura.ID_Factura;
        }

        public override string ToString()
        {
            return $"{ID_Tratamiento};{Descripcion};{Duracion};{Costo};{CodigoDiagnostico};{CodigoFactura}";
        }
    }
}
