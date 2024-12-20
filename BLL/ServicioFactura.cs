﻿using DAL;
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
        public string UpdateEstado(Factura factura, string estado)
        {
            Factura facturaAModificar = GetByID(factura.ID_Factura);
            facturaAModificar.Estado = estado;
            return reposFactura.Update(facturaAModificar);
        }
        public string SumarMonto(Factura factura, double monto)
        {
            Factura facturaAModificar = GetByID(factura.ID_Factura);
            facturaAModificar.Total += monto;
            return reposFactura.Update(facturaAModificar);
        }
        public string SumarMontoAPagado(Factura factura, double monto)
        {
            Factura facturaAModificar = GetByID(factura.ID_Factura);
            facturaAModificar.Total_Pagado += monto;
            return reposFactura.Update(facturaAModificar);
        }
        public string SumarCambio(Factura factura)
        {
            Factura facturaAModificar = GetByID(factura.ID_Factura);
            facturaAModificar.Cambio = facturaAModificar.Total_Pagado - facturaAModificar.Total;
            return reposFactura.Update(facturaAModificar);
        }
        public string RestarMonto(Factura factura, double monto)
        {
            Factura facturaAModificar = GetByID(factura.ID_Factura);
            facturaAModificar.Total -= monto;
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
                int ultimoCodigoNumerico = int.Parse(ultimaFactura.ID_Factura.Substring(2));
                nuevoCodigo = "FC" + (ultimoCodigoNumerico + 1).ToString().PadLeft(3, '0');
            }
            return nuevoCodigo;
        }

    }
}
