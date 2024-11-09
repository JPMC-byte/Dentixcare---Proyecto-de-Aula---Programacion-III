using DAL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BLL
{
    public class ServicioFactura
    {
        DBFactura reposFactura;

        public ServicioFactura()
        {
            reposFactura = new DBFactura();
        }

        public string Add(Factura factura)
        {
            return reposFactura.SaveData(factura);
        }

        public List<Factura> GetAll()
        {
            return reposFactura.GetAll();
        }

        public Factura GetByID(string id)
        {
            return reposFactura.GetByID(id);
        }

        public string Delete(string id)
        {
            return reposFactura.Delete(id);
        }

        public string UpdateMonto(Factura factura, double Monto_total)
        {
            Factura facturaAModificar = GetByID(factura.ID_Factura);
            facturaAModificar.Total = Monto_total;
            return reposFactura.Update(facturaAModificar);
        }
        public string UpdateEstado(Factura factura, string estado)
        {
            Factura facturaAModificar = GetByID(factura.ID_Factura);
            facturaAModificar.Estado = estado;
            return reposFactura.Update(facturaAModificar);
        }
        public string GenerarCodigo()
        {
            List<Factura> facturasExistentes = GetAll();
            string nuevoCodigo;

            if (facturasExistentes.Count == 0 || facturasExistentes == null)
            {
                nuevoCodigo = "FC001";
            }
            else
            {
                Factura ultimaFactura = facturasExistentes.Last();
                int ultimoCodigoNumerico = int.Parse(ultimaFactura.ID_Factura);
                nuevoCodigo = "FC" + (ultimoCodigoNumerico + 1).ToString().PadLeft(3, '0');
            }
            return nuevoCodigo;
        }
    }
}
