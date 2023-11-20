using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ServiciosCelulares.Models;

namespace ServiciosCelulares.Clases
{
    public class clsProveedor
    {
        public Proveedore proveedor { get; set; }
        private CELULARESEntities DBCelulares = new CELULARESEntities();

        public List<Proveedore> ListarProveedores()
        {
            return DBCelulares.Proveedores
                .OrderBy(p => p.NombreProveedor)
                .ToList();

        }
        public Proveedore Consultar(int proveedorID)
        {
            return DBCelulares.Proveedores.FirstOrDefault(e => e.ProveedorID == proveedorID);
        }

        public String Insertar()
        {
            try
            {
                DBCelulares.Proveedores.Add(proveedor);
                DBCelulares.SaveChanges();
                return "Se realizo la proveedor con el ProveedorID: " + proveedor.ProveedorID;
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
                Proveedore _proveedor = Consultar(proveedor.ProveedorID);
                if (_proveedor == null)
                {
                    return "El proveedor con ID: " + proveedor.ProveedorID + ", no existe en la base de datos";
                }
                _proveedor.ProveedorID = proveedor.ProveedorID;
                _proveedor.NombreProveedor = proveedor.NombreProveedor;
                _proveedor.TelefonoProveedor = proveedor.TelefonoProveedor;
                _proveedor.CorreoElectronicoProveedor = proveedor.CorreoElectronicoProveedor;
                DBCelulares.SaveChanges();
                return "Se actualizó el proveedor con el ID: " + proveedor.ProveedorID;
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
                Proveedore _proveedor = Consultar(proveedor.ProveedorID);
                if (_proveedor == null)
                {
                    return "El proveedor con ProveedorID: " + proveedor.ProveedorID + ", no existe en la base de datos";
                }
                DBCelulares.Proveedores.Remove(_proveedor);
                DBCelulares.SaveChanges();
                return "Se eliminó el proveedor de la base de datos, ID: " + proveedor.ProveedorID;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}