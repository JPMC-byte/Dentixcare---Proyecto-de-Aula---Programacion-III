using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public abstract class BaseRepository<T>
    {
        protected string _fileName;

        protected BaseRepository(string fileName)
        {
            _fileName = fileName;
        }

        public string SaveData(T entidad)
        {
            try
            {
                StreamWriter Writer = new StreamWriter(_fileName, true);
                Writer.WriteLine(entidad.ToString());
                Writer.Close();
                return "Datos almacenados correctamente";
            }
            catch (Exception ex)
            {
                return ("error al guardar " + ex.Message);
            }
        }
        public string SaveData(List<T> List)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(_fileName, false))
                {
                    foreach (var T in List)
                    {
                        writer.WriteLine(T.ToString());
                    }
                    writer.Close();
                    return "Datos modificados correctamente";
                }
            }
            catch (Exception ex)
            {
                return "Error al sobrescribir el archivo: " + ex.Message;
            }
        }

        public abstract List<T> LoadData();
    }
}
