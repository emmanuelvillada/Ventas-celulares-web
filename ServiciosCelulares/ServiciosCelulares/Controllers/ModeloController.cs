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
    public class ModeloController : ApiController
    {
        public List<Modelo> Get()
        {
            clsModelo _modelo = new clsModelo();
            return _modelo.ListarModelos();
        }
        public Modelo Get(int ModeloID)
        {
            clsModelo _modelo = new clsModelo();
            return _modelo.Consultar(ModeloID);
        }

        // POST api/<controller>
        public string Post([FromBody] Modelo modelo)
        {
            clsModelo _modelo = new clsModelo();
            _modelo.modelo = modelo;
            return _modelo.Insertar();
        }

        // PUT api/<controller>/5
        public string Put([FromBody] Modelo modelo)
        {
            clsModelo _modelo = new clsModelo();
            _modelo.modelo = modelo;
            return _modelo.Actualizar();
        }

        // DELETE api/<controller>/5
        public string Delete([FromBody] Modelo modelo)
        {
            clsModelo _modelo = new clsModelo();
            _modelo.modelo = modelo;
            return _modelo.Eliminar();
        }
    }
}