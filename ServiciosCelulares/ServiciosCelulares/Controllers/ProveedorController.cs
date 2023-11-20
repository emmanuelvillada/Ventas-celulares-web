using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Http;
using System.Web.Http.Cors;
using ServiciosCelulares.Models;
using ServiciosCelulares.Clases;

namespace ServiciosCelulares.Controllers
{
    [EnableCors(origins: "http://localhost:53462", headers: "*", methods: "*")]
    public class ProveedorController : ApiController
    {
        public List<Proveedore> Get()
        {
            clsProveedor proveedor = new clsProveedor();
            return proveedor.ListarProveedores();
        }
        public Proveedore Get(int ProveedorID)
        {
            clsProveedor proveedor = new clsProveedor();
            return proveedor.Consultar(ProveedorID);
        }

        // POST api/<controller>
        public string Post([FromBody] Proveedore proveedor)
        {
            clsProveedor _proveedor = new clsProveedor();
            _proveedor.proveedor = proveedor;
            return _proveedor.Insertar();
        }

        // PUT api/<controller>/5
        public string Put([FromBody] Proveedore proveedor)
        {
            clsProveedor _proveedor = new clsProveedor();
            _proveedor.proveedor = proveedor;
            return _proveedor.Actualizar();
        }

        // DELETE api/<controller>/5
        public string Delete([FromBody] Proveedore proveedor)
        {
            clsProveedor _proveedor = new clsProveedor();
            _proveedor.proveedor = proveedor;
            return _proveedor.Eliminar();
        }
    }
}