using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ServiciosCelulares.Models;

namespace ServiciosCelulares.Clases
{
    public class clsInventario
    {
        public Inventario inventario { get; set; }
        private CELULARESEntities DBCelulares = new CELULARESEntities();

        public Inventario Consultar(int inventarioID)
        {
            return DBCelulares.Inventarios.FirstOrDefault(e => e.InventarioID == inventarioID);
        }

        public String Insertar()
        {
            try
            {
                DBCelulares.Inventarios.Add(inventario);
                DBCelulares.SaveChanges();
                return "Se realizo la inventario con el InventarioID: " + inventario.InventarioID;
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
                Inventario _inventario = Consultar(inventario.InventarioID);
                if (_inventario == null)
                {
                    return "El inventario con ID: " + inventario.InventarioID + ", no existe en la base de datos";
                }
                _inventario.InventarioID = inventario.InventarioID;
                _inventario.ProductoID = inventario.ProductoID;
                _inventario.ProveedorID = inventario.ProveedorID;
                _inventario.PrecioCompra = inventario.PrecioCompra;
                _inventario.CantidadInventario = inventario.CantidadInventario;
                DBCelulares.SaveChanges();
                return "Se actualizó el inventario con el ID: " + inventario.InventarioID;
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
                Inventario _inventario = Consultar(inventario.InventarioID);
                if (_inventario == null)
                {
                    return "El inventario con InventarioID: " + inventario.InventarioID + ", no existe en la base de datos";
                }
                DBCelulares.Inventarios.Remove(_inventario);
                DBCelulares.SaveChanges();
                return "Se eliminó el inventario de la base de datos, ID: " + inventario.InventarioID;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}