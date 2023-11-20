using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ServiciosCelulares.Models;
using ServiciosCelulares.Clases;
using System.Web.Http;
using System.Web.Http.Cors;

namespace ServiciosCelulares.Controllers
{

    [EnableCors(origins: "http://localhost:53462", headers: "*", methods: "*")]
    public class ProductosController : ApiController
    {
        public List<Producto> Get()
        {
            clsProductos producto = new clsProductos();
            return producto.ListarProductos();
        }
        public Producto Get(int ProductoID)
        {
            clsProductos producto = new clsProductos();
            return producto.Consultar(ProductoID);
        }

        // POST api/<controller>
        public string Post([FromBody] Producto producto)
        {
            clsProductos _producto = new clsProductos();
            _producto.producto = producto;
            return _producto.Insertar();
        }

        // PUT api/<controller>/5
        public string Put([FromBody] Producto producto)
        {
            clsProductos _producto = new clsProductos();
            _producto.producto = producto;
            return _producto.Actualizar();
        }

        // DELETE api/<controller>/5
        public string Delete([FromBody] Producto producto)
        {
            clsProductos _producto = new clsProductos();
            _producto.producto = producto;
            return _producto.Eliminar();
        }
    }
}
