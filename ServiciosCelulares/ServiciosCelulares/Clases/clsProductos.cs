using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ServiciosCelulares.Models;

namespace ServiciosCelulares.Clases
{
    public class clsProductos
    {
        public Producto producto { get; set; }
        private CELULARESEntities DBCelulares = new CELULARESEntities();

        public List<Producto> ListarProductos()
        {
            return DBCelulares.Productos
                .OrderBy(p => p.NombreProducto)
                .ToList();

        }
        public Producto Consultar(int productoID)
        {
            return DBCelulares.Productos.FirstOrDefault(e => e.ProductoID == productoID);
        }

        public String Insertar()
        {
            try
            {
                DBCelulares.Productos.Add(producto);
                DBCelulares.SaveChanges();
                return "Se realizo la producto con el ProductoID: " + producto.ProductoID;
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
                Producto _producto = Consultar(producto.ProductoID);
                if (_producto == null)
                {
                    return "El producto con ID: " + producto.ProductoID + ", no existe en la base de datos";
                }
                _producto.ProductoID = producto.ProductoID;
                _producto.ModeloID = producto.ModeloID;
                _producto.NombreProducto = producto.NombreProducto;
                _producto.Descripcion = producto.Descripcion;
                _producto.PrecioVenta = producto.PrecioVenta;
                DBCelulares.SaveChanges();
                return "Se actualizó el producto con el ID: " + producto.ProductoID;
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
                Producto _producto = Consultar(producto.ProductoID);
                if (_producto == null)
                {
                    return "El producto con ProductoID: " + producto.ProductoID + ", no existe en la base de datos";
                }
                DBCelulares.Productos.Remove(_producto);
                DBCelulares.SaveChanges();
                return "Se eliminó el producto de la base de datos, ID: " + producto.ProductoID;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}