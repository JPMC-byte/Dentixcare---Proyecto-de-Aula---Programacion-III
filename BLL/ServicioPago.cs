using DAL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BLL
{
    public class ServicioPago
    {
        DBPago reposPago;

        public ServicioPago()
        {
            reposPago = new DBPago();
        }
        public string Add(Pago pago)
        {
            return reposPago.SaveData(pago);
        }

        public List<Pago> GetAll()
        {
            return reposPago.GetAll();
        }
        public Pago GetByID(string id)
        {
            return reposPago.GetById(id);
        }
        public List<Pago> LoadByFactura(string codigoFactura) 
        {
            return reposPago.LoadByFactura(codigoFactura);
        }

        public string GenerarCodigo()
        {
            List<Pago> pagosExistentes = GetAll();
            string nuevoCodigo;

            if (pagosExistentes.Count == 0 || pagosExistentes == null)
            {
                nuevoCodigo = "PG001";
            }
            else
            {
                Pago ultimoPago = pagosExistentes.Last();
                int ultimoCodigoNumerico = int.Parse(ultimoPago.ID_Pago.Substring(2));
                nuevoCodigo = "PG" + (ultimoCodigoNumerico + 1).ToString().PadLeft(3, '0');
            }
            return nuevoCodigo;
        }
    }
}
