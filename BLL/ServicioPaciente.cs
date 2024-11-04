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
        DBPaciente RepsPaciente;

        public ServicioPaciente()
        {
            //RepsPaciente = new RepositorioPaciente(Config.FILENAME_PACIENTE);
            RepsPaciente = new DBPaciente();
        }
        public string Add(Paciente value)
        {
            return RepsPaciente.SaveData(value);
        }

        public List<Paciente> GetAll()
        {
            return RepsPaciente.GetAll();
        }

        public Paciente GetByID(string ID)
        {
            return RepsPaciente.GetByID(ID);
        }

        public List<Paciente> LoadByID(string ID)
        {
            return RepsPaciente.LoadByID(ID);
        }

        public Paciente IniciarSesion(string id, string Password)
        {
            return RepsPaciente.GetByUser(id, Password);
        }
    }
}
