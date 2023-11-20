using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ServiciosCelulares.Models;

namespace ServiciosCelulares.Clases
{
    public class clsReparacion
    {
        public Reparacione reparacion { get; set; }
        private CELULARESEntities DBCelulares = new CELULARESEntities();

        public List<Reparacione> ListarReparaciones()
        {
            return DBCelulares.Reparaciones
                .OrderBy(p => p.ReparacionID)
                .ToList();

        }
        public Reparacione Consultar(int reparacionID)
        {
            return DBCelulares.Reparaciones.FirstOrDefault(e => e.ReparacionID == reparacionID);
        }

        public String Insertar()
        {
            try
            {
                DBCelulares.Reparaciones.Add(reparacion);
                DBCelulares.SaveChanges();
                return "Se realizo la reparacion con el ReparacionID: " + reparacion.ReparacionID;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Actualizar()
        {
            try
            {
                Reparacione _reparacion = Consultar(reparacion.ReparacionID);
                if (_reparacion == null)
                {
                    return "El reparacion con ID: " + reparacion.ReparacionID + ", no existe en la base de datos";
                }
                _reparacion.ReparacionID = reparacion.ReparacionID;
                _reparacion.ClienteID = reparacion.ClienteID;
                _reparacion.CelularReparacionID = reparacion.CelularReparacionID;
                _reparacion.EmpleadoID = reparacion.EmpleadoID;
                _reparacion.FechaIngreso = reparacion.FechaIngreso;
                _reparacion.ProblemaReportado = reparacion.ProblemaReportado;
                _reparacion.EstadoReparacion = reparacion.EstadoReparacion;
                _reparacion.CostoReparacion = reparacion.CostoReparacion;
                DBCelulares.SaveChanges();
                return "Se actualizó el reparacion con el ID: " + reparacion.ReparacionID;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string Eliminar()
        {
            try
            {
                Reparacione _reparacion = Consultar(reparacion.ReparacionID);
                if (_reparacion == null)
                {
                    return "El reparacion con ReparacionID: " + reparacion.ReparacionID + ", no existe en la base de datos";
                }
                DBCelulares.Reparaciones.Remove(_reparacion);
                DBCelulares.SaveChanges();
                return "Se eliminó el reparacion de la base de datos, ID: " + reparacion.ReparacionID;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}