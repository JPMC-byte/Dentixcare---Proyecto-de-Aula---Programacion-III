using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BLL
{
    public class Validaciones
    {
        public bool ValidarLetras(string Texto)
        {
            string Patron = @"^[a-zA-ZñÑ\s]+$";
            return Regex.IsMatch(Texto, Patron);
        }

        public bool ValidarNumeros(string Texto)
        {
            string Patron = @"^[0-9]+$";
            return Regex.IsMatch(Texto, Patron);
        }
    }
}
