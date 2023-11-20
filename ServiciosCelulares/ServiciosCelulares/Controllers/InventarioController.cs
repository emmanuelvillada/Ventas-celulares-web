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
    public class InventarioController : ApiController
    {
        public Inventario Get(int InventarioID)
        {
            clsInventario inventario = new clsInventario();
            return inventario.Consultar(InventarioID);
        }

        // POST api/<controller>
        public string Post([FromBody] Inventario inventario)
        {
            clsInventario _inventario = new clsInventario();
            _inventario.inventario = inventario;
            return _inventario.Insertar();
        }

        // PUT api/<controller>/5
        public string Put([FromBody] Inventario inventario)
        {
            clsInventario _inventario = new clsInventario();
            _inventario.inventario = inventario;
            return _inventario.Actualizar();
        }

        // DELETE api/<controller>/5
        public string Delete([FromBody] Inventario inventario)
        {
            clsInventario _inventario = new clsInventario();
            _inventario.inventario = inventario;
            return _inventario.Eliminar();
        }
    }
}