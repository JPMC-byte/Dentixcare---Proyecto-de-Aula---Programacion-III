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

        public Consultorio() { }

        public Consultorio(string codigo) { }
        public Consultorio(string codigo, string nombre, string telefono, string direccion)
        {
            Codigo = codigo;
            Nombre = nombre;
            Telefono = telefono;
            Direccion = direccion;
        }
        public override string ToString()
        {
            return $"{Codigo};{Nombre};{Telefono};{Direccion}";
        }
    }
}
