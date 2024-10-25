using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public interface ServicioPersona<T>
    {
        string Add(T value);
        T IniciarSesion(string id, string Password);

        List<T> GetAll();
    }
}
