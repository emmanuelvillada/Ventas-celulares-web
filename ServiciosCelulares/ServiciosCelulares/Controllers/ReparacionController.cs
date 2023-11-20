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
    public class ReparacionController : ApiController
    {
        public List<Reparacione> Get()
        {
            clsReparacion reparacion = new clsReparacion();
            return reparacion.ListarReparaciones();
        }
        public Reparacione Get(int ReparacionID)
        {
            clsReparacion reparacion = new clsReparacion();
            return reparacion.Consultar(ReparacionID);
        }

        // POST api/<controller>
        public string Post([FromBody] Reparacione reparacion)
        {
            clsReparacion _reparacion = new clsReparacion();
            _reparacion.reparacion = reparacion;
            return _reparacion.Insertar();
        }

        // PUT api/<controller>/5
        public string Put([FromBody] Reparacione reparacion)
        {
            clsReparacion _reparacion = new clsReparacion();
            _reparacion.reparacion = reparacion;
            return _reparacion.Actualizar();
        }

        // DELETE api/<controller>/5
        public string Delete([FromBody] Reparacione reparacion)
        {
            clsReparacion _reparacion = new clsReparacion();
            _reparacion.reparacion = reparacion;
            return _reparacion.Eliminar();
        }
    }
}