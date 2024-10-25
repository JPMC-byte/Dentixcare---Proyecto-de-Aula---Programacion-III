using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Consultorio
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public TimeSpan Hora_Apertura { get; set; }
        public TimeSpan Hora_Cierre { get; set; }

        public Consultorio() { }

        public Consultorio(string codigo) { }
        public Consultorio(string codigo, string nombre, string telefono, string direccion, TimeSpan hora_Apertura, TimeSpan hora_Cierre)
        {
            Codigo = codigo;
            Nombre = nombre;
            Telefono = telefono;
            Direccion = direccion;
            Hora_Apertura = hora_Apertura;
            Hora_Cierre = hora_Cierre;
        }
        public override string ToString()
        {
            return $"{Codigo};{Nombre};{Telefono};{Direccion};{Hora_Apertura};{Hora_Cierre}";
        }
    }
}
