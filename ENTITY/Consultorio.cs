using System;

namespace ENTITY
{
    public class Consultorio
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Barrio { get; set; }
        public string Etapa { get; set; }
        public string Manzana { get; set; }
        public string Calle { get; set; }
        public TimeSpan Hora_Apertura { get; set; }
        public TimeSpan Hora_Cierre { get; set; }

        public Consultorio() { }

        public Consultorio(string codigo) { }
        public Consultorio(string codigo, string nombre, string telefono, string barrio, string etapa, string manzana, string calle, TimeSpan horaApertura, TimeSpan horaCierre)
        {
            Codigo = codigo;
            Nombre = nombre;
            Telefono = telefono;
            Barrio = barrio;
            Etapa = etapa;
            Manzana = manzana;
            Calle = calle;
            Hora_Apertura = horaApertura;
            Hora_Cierre = horaCierre;
        }
        public override string ToString()
        {
            return $"{Codigo};{Nombre};{Telefono};{Barrio};{Etapa};{Manzana};{Calle};{Hora_Apertura};{Hora_Cierre}";
        }
    }
}
