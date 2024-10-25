using DAL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ServicioPaciente : ServicioPersona<Paciente>
    {
        RepositorioPaciente RepsPaciente;

        public ServicioPaciente()
        {
            RepsPaciente = new RepositorioPaciente(Config.FILENAME_PACIENTE);
        }
        public string Add(Paciente value)
        {
            return RepsPaciente.SaveData(value);
        }

        public List<Paciente> GetAll()
        {
            return RepsPaciente.LoadData();
        }

        public Paciente IniciarSesion(string id, string Password)
        {
            return RepsPaciente.GetByUser(id, Password);
        }
    }
}
